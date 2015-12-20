using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;

namespace DocumentDBRestApi
{
    /// <summary>
    /// API client is mainly responible for making the HTTP call to the API backend.
    /// </summary>
    public class ApiClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        // ReSharper disable once InconsistentNaming
        public ApiClient(string basePath = "https://healthcare.documents.azure.com:443/dbs")
        {
            if (basePath == null) throw new ArgumentNullException(nameof(basePath));
            BasePath = basePath;
            RestClient = new RestClient(BasePath);
        }


        // Creates and sets up a RestRequest prior to a call.
        private RestRequest PrepareRequest(
            string Path, Method Method, Dictionary<string, string> QueryParams, string PostBody,
            Dictionary<string, string> HeaderParams, Dictionary<string, string> FormParams,
            Dictionary<string, FileParameter> FileParams, Dictionary<string, string> PathParams, string[] AuthSettings)
        {
            var request = new RestRequest(Path, Method);

            UpdateParamsForAuth(QueryParams, HeaderParams, AuthSettings);

            // add default header, if any
            foreach (var defaultHeader in DefaultHeader)
                request.AddHeader(defaultHeader.Key, defaultHeader.Value);

            // add path parameter, if any
            foreach (var param in PathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            // add header parameter, if any
            foreach (var param in HeaderParams)
                request.AddHeader(param.Key, param.Value);

            // add query parameter, if any
            foreach (var param in QueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // add form parameter, if any
            foreach (var param in FormParams)
                request.AddParameter(param.Key, param.Value);

            // add file parameter, if any
            foreach (var param in FileParams)
                request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentType);

            if (PostBody != null) // http body (model) parameter
                request.AddParameter("application/json", PostBody, ParameterType.RequestBody);

            return request;
        }


        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="Key">Header field name.</param>
        /// <param name="Value">Header field value.</param>
        /// <returns></returns>
        public void AddDefaultHeader(string Key, string Value)
        {
            DefaultHeader.Add(Key, Value);
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="Text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string Text)
        {
            var textByte = Encoding.UTF8.GetBytes(Text);
            return Convert.ToBase64String(textByte);
        }

        /// <summary>
        /// Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="Path">URL path.</param>
        /// <param name="Method">HTTP method.</param>
        /// <param name="QueryParams">Query parameters.</param>
        /// <param name="PostBody">HTTP body (POST request).</param>
        /// <param name="HeaderParams">Header parameters.</param>
        /// <param name="FormParams">Form parameters.</param>
        /// <param name="FileParams">File parameters.</param>
        /// <param name="PathParams">Path parameters.</param>
        /// <param name="AuthSettings">Authentication settings.</param>
        /// <returns>Object</returns>
        public Object CallApi(
            string Path, Method Method, Dictionary<string, string> QueryParams, string PostBody,
            Dictionary<string, string> HeaderParams, Dictionary<string, string> FormParams,
            Dictionary<string, FileParameter> FileParams, Dictionary<string, string> PathParams, string[] AuthSettings)
        {
            var request = PrepareRequest(
                Path, Method, QueryParams, PostBody, HeaderParams, FormParams, FileParams, PathParams, AuthSettings);
            var response = RestClient.Execute(request);
            StatusCode = (int)response.StatusCode;
            ResponseHeaders = response.Headers.ToDictionary(X => X.Name, X => X.Value.ToString());
            return response;
        }

        /// <summary>
        /// Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="Path">URL path.</param>
        /// <param name="Method">HTTP method.</param>
        /// <param name="QueryParams">Query parameters.</param>
        /// <param name="PostBody">HTTP body (POST request).</param>
        /// <param name="HeaderParams">Header parameters.</param>
        /// <param name="FormParams">Form parameters.</param>
        /// <param name="FileParams">File parameters.</param>
        /// <param name="PathParams">Path parameters.</param>
        /// <param name="AuthSettings">Authentication settings.</param>
        /// <returns>The Task instance.</returns>
        public async Task<Object> CallApiAsync(
            string Path, Method Method, Dictionary<string, string> QueryParams, string PostBody,
            Dictionary<string, string> HeaderParams, Dictionary<string, string> FormParams,
            Dictionary<string, FileParameter> FileParams, Dictionary<string, string> PathParams, string[] AuthSettings)
        {
            var request = PrepareRequest(
                Path, Method, QueryParams, PostBody, HeaderParams, FormParams, FileParams, PathParams, AuthSettings);
            var response = await RestClient.ExecuteTaskAsync(request);
            StatusCode = (int)response.StatusCode;
            ResponseHeaders = response.Headers.ToDictionary(X => X.Name, X => X.Value.ToString());
            return response;
        }

        /// <summary>
        /// Dynamically cast the object into target type.
        /// Ref: http://stackoverflow.com/questions/4925718/c-dynamic-runtime-cast
        /// </summary>
        /// <param name="Source">Object to be casted</param>
        /// <param name="Dest">Target type</param>
        /// <returns>Casted object</returns>
        public static dynamic ConvertType(dynamic Source, Type Dest)
        {
            return Convert.ChangeType(Source, Dest);
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="Response">The HTTP response.</param>
        /// <param name="Type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize(IRestResponse Response, Type Type)
        {
            var data = Response.RawBytes;
            var content = Response.Content;
            var headers = Response.Headers;
            if (Type == typeof (Object)) // return an object
                return content;

            if (Type == typeof(Stream))
            {
                if (headers != null)
                {
                    var filePath = string.IsNullOrEmpty(Configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : Configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition:.*filename=['""]?([^'""\s]+)['""]?$");
                    var match = regex.Match(headers.ToString());
                    if (match.Success)
                    {
                        var fileName = filePath + match.Value.Replace("\"", "").Replace("'", "");
                        File.WriteAllBytes(fileName, data);
                        return new FileStream(fileName, FileMode.Open);
                    }
                }
                var stream = new MemoryStream(data);
                return stream;
            }

            if (Type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object

                return DateTime.Parse(content, null, DateTimeStyles.RoundtripKind);

            if (Type == typeof(string) || Type.Name.StartsWith("System.Nullable")) // return primitive type

                return ConvertType(content, Type);

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(content, Type);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="Str">String to be escaped.</param>
        /// <returns>Escaped string.</returns>
        public string EscapeString(string Str)
        {
            return Str.UrlEncode();
        }

        /// <summary>
        /// Get the API key with prefix.
        /// </summary>
        /// <param name="ApiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix(string ApiKeyIdentifier)
        {
            string apiKeyValue;
            Configuration.ApiKey.TryGetValue(ApiKeyIdentifier, out apiKeyValue);
            string apiKeyPrefix;
            if (Configuration.ApiKeyPrefix.TryGetValue(ApiKeyIdentifier, out apiKeyPrefix))
                return apiKeyPrefix + " " + apiKeyValue;
            return apiKeyValue;
        }

        /// <summary>
        /// Create FileParameter based on Stream.
        /// </summary>
        /// <param name="Name">Parameter name.</param>
        /// <param name="Stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        public FileParameter ParameterToFile(string Name, Stream Stream)
        {
            var stream = Stream as FileStream;
            return stream != null ? FileParameter.Create(Name, stream.ReadAsBytes(), Path.GetFileName(stream.Name)) : FileParameter.Create(Name, Stream.ReadAsBytes(), "no_file_name_provided");
        }

        /// <summary>
        /// If parameter is DateTime, output in ISO8601 format.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="Obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object Obj)
        {
            if (Obj is DateTime)
                return ((DateTime)Obj).ToString("u");
            if (!(Obj is IList)) return Convert.ToString(Obj);
            const string separator = ",";
            var flattenString = ((IList)Obj).Cast<object>().Aggregate("", (Current, Param) => Current + (Param + separator));
            return flattenString.Remove(flattenString.Length - 1);
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="Accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public string SelectHeaderAccept(string[] Accepts)
        {
            if (Accepts.Length == 0)
                return null;
            if (Accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";
            return string.Join(",", Accepts);
        }

        /// <summary>
        /// Serialize an object into JSON string.
        /// </summary>
        /// <param name="Obj">Object.</param>
        /// <returns>JSON string.</returns>
        public string Serialize(object Obj)
        {
            try
            {
                return Obj != null ? JsonConvert.SerializeObject(Obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Update parameters based on authentication.
        /// NOT CURRENTLY USED
        /// </summary>
        /// <param name="QueryParams">Query parameters.</param>
        /// <param name="HeaderParams">Header parameters.</param>
        /// <param name="AuthSettings">Authentication settings.</param>
        public void UpdateParamsForAuth(Dictionary<string, string> QueryParams, Dictionary<string, string> HeaderParams, string[] AuthSettings)
        {
            if (AuthSettings == null || AuthSettings.Length == 0)
                return;

            foreach (var auth in AuthSettings)
            {
                // determine which one to use
                switch (auth)
                {

                   
                    default:
                        //TODO show warning about security definition not found
                        throw new ArgumentNullException();
                        
                }
            }
        }


        /// <summary>
        /// Gets or sets the base path.
        /// </summary>
        /// <value>The base path</value>
        public string BasePath { get; set; }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        public Dictionary<string, string> DefaultHeader { get; } = new Dictionary<string, string>();

        /// <summary>
        /// Gets the response headers of the previous request
        /// </summary>
        public Dictionary<string, string> ResponseHeaders { get; private set; }

        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        public RestClient RestClient { get; set; }

        /// <summary>
        /// Gets the status code of the previous request
        /// </summary>
        public int StatusCode { get; private set; }

    }
}
