using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DocDBAPIRest.Models;
using RestSharp;

namespace DocDBAPIRest.Controllers
{
    public class UdfController : ApiController
    {
        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public interface IUdfApi
        {
            /// <summary>
            ///     Get an List of Udf&#39;s
            /// </summary>
            /// <remarks>
            ///     Get a list of Udf&#39;s from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>List&lt;Udf&gt;</returns>
            List<Udf> GetUdfList(string ridDb, string ridColl, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null);

            /// <summary>
            ///     Get an List of Udf&#39;s
            /// </summary>
            /// <remarks>
            ///     Get a list of Udf&#39;s from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>ApiResponse of List&lt;Udf&gt;</returns>
            ApiResponse<List<Udf>> GetUdfListWithHttpInfo(string ridDb, string ridColl, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Get an List of Udf&#39;s
            /// </summary>
            /// <remarks>
            ///     Get a list of Udf&#39;s from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>Task of List&lt;Udf&gt;</returns>
            Task<List<Udf>> GetUdfListAsync(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Get an List of Udf&#39;s
            /// </summary>
            /// <remarks>
            ///     Get a list of Udf&#39;s from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>Task of ApiResponse (List&lt;Udf&gt;)</returns>
            Task<ApiResponse<List<Udf>>> GetUdfListAsyncWithHttpInfo(string ridDb, string ridColl, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Query a UDF
            /// </summary>
            /// <remarks>
            ///     Query a UDF from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>QueryResponseBody</returns>
            QueryResponseBody QueryUdf(string ridDb, string ridColl, QueryRequest request, string authorization,
                string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string xMsDate,
                string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Query a UDF
            /// </summary>
            /// <remarks>
            ///     Query a UDF from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>ApiResponse of QueryResponseBody</returns>
            ApiResponse<QueryResponseBody> QueryUdfWithHttpInfo(string ridDb, string ridColl, QueryRequest request,
                string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery,
                string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Query a UDF
            /// </summary>
            /// <remarks>
            ///     Query a UDF from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>Task of QueryResponseBody</returns>
            Task<QueryResponseBody> QueryUdfAsync(string ridDb, string ridColl, QueryRequest request,
                string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery,
                string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Query a UDF
            /// </summary>
            /// <remarks>
            ///     Query a UDF from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>Task of ApiResponse (QueryResponseBody)</returns>
            Task<ApiResponse<QueryResponseBody>> QueryUdfAsyncWithHttpInfo(string ridDb, string ridColl,
                QueryRequest request, string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan,
                bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion, string userAgent = null);
        }

        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public class UdfApi : IUdfApi
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="UdfApi" /> class.
            /// </summary>
            /// <returns></returns>
            public UdfApi(string basePath)
            {
                Configuration = new Configuration(new ApiClient(basePath));
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="UdfApi" /> class
            ///     using Configuration object
            /// </summary>
            /// <param name="configuration">An instance of Configuration</param>
            /// <returns></returns>
            public UdfApi(Configuration configuration = null)
            {
                Configuration = configuration ?? Configuration.Default;
            }

            /// <summary>
            ///     Gets or sets the configuration object
            /// </summary>
            /// <value>An instance of the Configuration</value>
            public Configuration Configuration { get; set; }

            /// <summary>
            ///     Gets the base path of the API client.
            /// </summary>
            /// <value>The base path</value>
            public string GetBasePath()
            {
                return Configuration.ApiClient.RestClient.BaseUrl.ToString();
            }

            /// <summary>
            ///     Get an List of Udf&#39;s
            /// </summary>
            /// <remarks>
            ///     Get a list of Udf&#39;s from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>List&lt;Udf&gt;</returns>
            public List<Udf> GetUdfList(string ridDb, string ridColl, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null)
            {
                throw new NotImplementedException();
            }


            /// <summary>
            ///     Get an List of Udf&#39;s Get a list of Udf&#39;s from a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>List&lt;Udf&gt;</returns>
            public List<Udf> GetUDFList(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                var response = GetUDFListWithHttpInfo(ridDb, ridColl, authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get an List of Udf&#39;s
            /// </summary>
            /// <remarks>
            ///     Get a list of Udf&#39;s from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>Task of List&lt;Udf&gt;</returns>
            public Task<List<Udf>> GetUdfListAsync(string ridDb, string ridColl, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            ///     Get an List of Udf&#39;s Get a list of Udf&#39;s from a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>Task of List&lt;Udf&gt;</returns>
            public async Task<List<Udf>> GetUDFListAsync(string ridDb, string ridColl, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response =
                    await GetUDFListAsyncWithHttpInfo(ridDb, ridColl, authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get an List of Udf&#39;s
            /// </summary>
            /// <remarks>
            ///     Get a list of Udf&#39;s from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>Task of ApiResponse (List&lt;Udf&gt;)</returns>
            public Task<ApiResponse<List<Udf>>> GetUdfListAsyncWithHttpInfo(string ridDb, string ridColl, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            ///     Get an List of Udf&#39;s Get a list of Udf&#39;s from a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>Task of ApiResponse (List&lt;Udf&gt;)</returns>
            public async Task<ApiResponse<List<Udf>>> GetUDFListAsyncWithHttpInfo(string ridDb, string ridColl,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetUDFList");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling GetUDFList");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetUDFList");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetUDFList");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetUDFList");


                var path = "/{rid-db}/colls/{rid-coll}/udf";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridColl != null)
                    pathParams.Add("rid-coll", Configuration.ApiClient.ParameterToString(ridColl)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int)response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetUDFList: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetUDFList: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<Udf>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<Udf>)Configuration.ApiClient.Deserialize(response, typeof(List<Udf>)));
            }

            /// <summary>
            ///     Get an List of Udf&#39;s
            /// </summary>
            /// <remarks>
            ///     Get a list of Udf&#39;s from a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>ApiResponse of List&lt;Udf&gt;</returns>
            public ApiResponse<List<Udf>> GetUdfListWithHttpInfo(string ridDb, string ridColl, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            ///     Get an List of Udf&#39;s Get a list of Udf&#39;s from a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>ApiResponse of List&lt;Udf&gt;</returns>
            public ApiResponse<List<Udf>> GetUDFListWithHttpInfo(string ridDb, string ridColl, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetUDFList");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling GetUDFList");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetUDFList");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetUDFList");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetUDFList");


                var path = "/{rid-db}/colls/{rid-coll}/udf";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridColl != null)
                    pathParams.Add("rid-coll", Configuration.ApiClient.ParameterToString(ridColl)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int)response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetUDFList: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetUDFList: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<Udf>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<Udf>)Configuration.ApiClient.Deserialize(response, typeof(List<Udf>)));
            }

            /// <summary>
            ///     Query a UDF Query a UDF from a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>QueryResponseBody</returns>
            public QueryResponseBody QueryUdf(string ridDb, string ridColl, QueryRequest request, string authorization,
                string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                var response = QueryUdfWithHttpInfo(ridDb, ridColl, request, authorization, contentType,
                    xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Query a UDF Query a UDF from a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>Task of QueryResponseBody</returns>
            public async Task<QueryResponseBody> QueryUdfAsync(string ridDb, string ridColl, QueryRequest request,
                string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery,
                string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response =
                    await
                        QueryUdfAsyncWithHttpInfo(ridDb, ridColl, request, authorization, contentType,
                            xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Query a UDF Query a UDF from a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>Task of ApiResponse (QueryResponseBody)</returns>
            public async Task<ApiResponse<QueryResponseBody>> QueryUdfAsyncWithHttpInfo(string ridDb, string ridColl,
                QueryRequest request, string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan,
                bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling QueryUdf");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling QueryUdf");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling QueryUdf");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling QueryUdf");
                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400, "Missing required parameter 'contentType' when calling QueryUdf");
                // verify the required parameter 'xMsDocumentdbQueryEnableScan' is set
                if (xMsDocumentdbQueryEnableScan == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbQueryEnableScan' when calling QueryUdf");
                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryUdf");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling QueryUdf");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling QueryUdf");


                const string path = "/{rid-db}/colls/{rid-coll}/udf";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridColl != null)
                    pathParams.Add("rid-coll", Configuration.ApiClient.ParameterToString(ridColl)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                // header parameter
                if (xMsDocumentdbQueryEnableScan != null)
                    headerParams.Add("x-ms-documentdb-query-enable-scan",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbQueryEnableScan)); // header parameter
                if (xMsDocumentdbIsquery != null)
                    headerParams.Add("x-ms-documentdb-isquery",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbIsquery)); // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int)response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling QueryUdf: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryUdf: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResponseBody)Configuration.ApiClient.Deserialize(response, typeof(QueryResponseBody)));
            }

            /// <summary>
            ///     Query a UDF Query a UDF from a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///    <c>{user agent name}/{version}</c>
            /// </param>
            /// <returns>ApiResponse of QueryResponseBody</returns>
            public ApiResponse<QueryResponseBody> QueryUdfWithHttpInfo(string ridDb, string ridColl,
                QueryRequest request, string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan,
                bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling QueryUdf");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling QueryUdf");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling QueryUdf");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling QueryUdf");

                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400, "Missing required parameter 'contentType' when calling QueryUdf");

                // verify the required parameter 'xMsDocumentdbQueryEnableScan' is set
                if (xMsDocumentdbQueryEnableScan == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbQueryEnableScan' when calling QueryUdf");

                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryUdf");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling QueryUdf");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling QueryUdf");


                const string path = "/{rid-db}/colls/{rid-coll}/udf";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridColl != null)
                    pathParams.Add("rid-coll", Configuration.ApiClient.ParameterToString(ridColl)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                // header parameter
                if (xMsDocumentdbQueryEnableScan != null)
                    headerParams.Add("x-ms-documentdb-query-enable-scan",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbQueryEnableScan)); // header parameter
                if (xMsDocumentdbIsquery != null)
                    headerParams.Add("x-ms-documentdb-isquery",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbIsquery)); // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                var postBody = Configuration.ApiClient.Serialize(request);


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int)response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling QueryUdf: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryUdf: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResponseBody)Configuration.ApiClient.Deserialize(response, typeof(QueryResponseBody)));
            }


        }
    }
}