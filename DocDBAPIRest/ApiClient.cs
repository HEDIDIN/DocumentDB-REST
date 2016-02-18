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

namespace DocDBAPIRest
{
    /// <summary>
    ///     API client is mainly responible for making the HTTP call to the API backend.
    /// </summary>
    public class ApiClient
    {
        /// <summary>
        ///     Gets or sets the default API client for making HTTP calls.
        /// </summary>
        /// <value>The default API client.</value>
        public static ApiClient Default = new ApiClient(Configuration.Default);

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApiClient" /> class
        ///     with default configuration and base path (https://databaseaccount.documents.azure.com:443/dbs).
        /// </summary>
        public ApiClient()
        {
            Configuration = Configuration.Default;
            RestClient = new RestClient("https://databaseaccount.documents.azure.com:443/dbs");
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApiClient" /> class
        ///     with default base path (https://databaseaccount.documents.azure.com:443/dbs).
        /// </summary>
        /// <param name="config">An instance of Configuration.</param>
        public ApiClient(Configuration config = null)
        {
            Configuration = config ?? Configuration.Default;

            RestClient = new RestClient("https://databaseaccount.documents.azure.com:443/dbs");
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApiClient" /> class
        ///     with default configuration.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public ApiClient(string basePath = "https://databaseaccount.documents.azure.com:443/dbs")
        {
            if (string.IsNullOrEmpty(basePath))
                throw new ArgumentException("basePath cannot be empty");

            RestClient = new RestClient(basePath);
            Configuration = Configuration.Default;
        }

        /// <summary>
        ///     Gets or sets the Configuration.
        /// </summary>
        /// <value>An instance of the Configuration.</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        ///     Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        public RestClient RestClient { get; set; }

        // Creates and sets up a RestRequest prior to a call.
        private RestRequest PrepareRequest(
            string path, Method method, Dictionary<string, string> queryParams, string postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams)
        {
            var request = new RestRequest(path, method);

            // add path parameter, if any
            foreach (var param in pathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            // add header parameter, if any
            foreach (var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            // add query parameter, if any
            foreach (var param in queryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // add form parameter, if any
            foreach (var param in formParams)
                request.AddParameter(param.Key, param.Value);

            // add file parameter, if any
            foreach (var param in fileParams)
                request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentType);

            if (postBody != null) // http body (model) parameter
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);

            return request;
        }

        /// <summary>
        ///     Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <returns>Object</returns>
        public object CallApi(
            string path, Method method, Dictionary<string, string> queryParams, string postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams)
        {
            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams);
            var response = RestClient.Execute(request);
            return response;
        }

        /// <summary>
        ///     Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <returns>The Task instance.</returns>
        public async Task<object> CallApiAsync(
            string path, Method method, Dictionary<string, string> queryParams, string postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams)
        {
            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams);
            var response = await RestClient.ExecuteTaskAsync(request);
            return (object) response;
        }

        /// <summary>
        ///     Escape string (url-encoded).
        /// </summary>
        /// <param name="str">String to be escaped.</param>
        /// <returns>Escaped string.</returns>
        public string EscapeString(string str)
        {
            return UrlEncode(str);
        }

        /// <summary>
        ///     Create FileParameter based on Stream.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        public FileParameter ParameterToFile(string name, Stream stream)
        {
            var fileStream = stream as FileStream;
            return fileStream != null ? FileParameter.Create(name, ReadAsBytes(fileStream), Path.GetFileName(fileStream.Name)) : FileParameter.Create(name, ReadAsBytes(stream), "no_file_name_provided");
        }

        /// <summary>
        ///     If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with
        ///     Configuration.DateTime.
        ///     If parameter is a list, join the list with ",".
        ///     Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            if (obj is DateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTime) obj).ToString(Configuration.DateTimeFormat);
            var list = obj as IList;
            if (list == null) return Convert.ToString(obj);
            var flattenedString = new StringBuilder();
            foreach (var param in list)
            {
                if (flattenedString.Length > 0)
                    flattenedString.Append(",");
                flattenedString.Append(param);
            }
            return flattenedString.ToString();
        }

        /// <summary>
        ///     Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize(IRestResponse response, Type type)
        {
            var data = response.RawBytes;
            var content = response.Content;
            var headers = response.Headers;
            if (type == typeof (object)) // return an object
            {
                return content;
            }

            if (type == typeof (Stream))
            {
                if (headers != null)
                {
                    var filePath = string.IsNullOrEmpty(Configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : Configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                    foreach (var header in headers)
                    {
                        var match = regex.Match(header.ToString());
                        if (match.Success)
                        {
                            var fileName = filePath + match.Groups[1].Value.Replace("\"", "").Replace("'", "");
                            File.WriteAllBytes(fileName, data);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                var stream = new MemoryStream(data);
                return stream;
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(content, null, DateTimeStyles.RoundtripKind);
            }

            if (type == typeof (string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return ConvertType(content, type);
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(content, type);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        ///     Serialize an object into JSON string.
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public string Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        ///     Select the Accept header's value from the given accepts array:
        ///     if JSON exists in the given array, use it;
        ///     otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public string SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            return accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase) ? "application/json" : string.Join(",", accepts);
        }

        /// <summary>
        ///     Encode string in base64 format.
        /// </summary>
        /// <param name="text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        ///     Dynamically cast the object into target type.
        ///     Ref: http://stackoverflow.com/questions/4925718/c-dynamic-runtime-cast
        /// </summary>
        /// <param name="source">Object to be casted</param>
        /// <param name="dest">Target type</param>
        /// <returns>Casted object</returns>
        public static dynamic ConvertType(dynamic source, Type dest)
        {
            return Convert.ChangeType(source, dest);
        }

        /// <summary>
        ///     Convert stream to byte array
        ///     Credit/Ref: http://stackoverflow.com/a/221941/677735
        /// </summary>
        /// <param name="input">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream input)
        {
            var buffer = new byte[16*1024];
            using (var ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        /// <summary>
        ///     URL encode a string
        ///     Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">String to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            var sb = new StringBuilder(input.Length*2);
            var index = 0;

            while (index < input.Length)
            {
                var length = Math.Min(input.Length - index, maxLength);
                var subString = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(subString));
                index += subString.Length;
            }

            return sb.ToString();
        }
    }
}