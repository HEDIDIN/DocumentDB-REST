using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DocDBAPIRest.Models;
using RestSharp;

namespace DocDBAPIRest.Controllers
{
    public class StoredProcedureController : ApiController
    {
        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public interface IStoredProcedureApi
        {
            /// <summary>
            ///     Get an List of all the stored procedures
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <returns>List&lt;StoredProcedure&gt;</returns>
            List<StoredProcedure> GetStoredProceduresList(string ridDb, string ridColl);

            /// <summary>
            ///     Get an List of all the stored procedures
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <returns>ApiResponse of List&lt;StoredProcedure&gt;</returns>
            ApiResponse<List<StoredProcedure>> GetStoredProceduresListWithHttpInfo(string ridDb, string ridColl);

            /// <summary>
            ///     Get an List of all the stored procedures
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <returns>Task of List&lt;StoredProcedure&gt;</returns>
            Task<List<StoredProcedure>> GetStoredProceduresListAsync(string ridDb, string ridColl);

            /// <summary>
            ///     Get an List of all the stored procedures
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <returns>Task of ApiResponse (List&lt;StoredProcedure&gt;)</returns>
            Task<ApiResponse<List<StoredProcedure>>> GetStoredProceduresListAsyncWithHttpInfo(string ridDb,
                string ridColl);

            /// <summary>
            ///     Register a Stored Procedure
            /// </summary>
            /// <remarks>
            ///     Register a Stored Procedure
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
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
            ///     
            /// </param>
            /// <returns>StoredProcedure</returns>
            StoredProcedure RegisterStoredProcedure(string ridDb, string ridColl, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Register a Stored Procedure
            /// </summary>
            /// <remarks>
            ///     Register a Stored Procedure
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
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
            ///     
            /// </param>
            /// <returns>ApiResponse of StoredProcedure</returns>
            ApiResponse<StoredProcedure> RegisterStoredProcedureWithHttpInfo(string ridDb, string ridColl,
                QueryRequest request, string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Register a Stored Procedure
            /// </summary>
            /// <remarks>
            ///     Register a Stored Procedure
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
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
            ///     
            /// </param>
            /// <returns>Task of StoredProcedure</returns>
            Task<StoredProcedure> RegisterStoredProcedureAsync(string ridDb, string ridColl, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Register a Stored Procedure
            /// </summary>
            /// <remarks>
            ///     Register a Stored Procedure
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
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
            ///     
            /// </param>
            /// <returns>Task of ApiResponse (StoredProcedure)</returns>
            Task<ApiResponse<StoredProcedure>> RegisterStoredProcedureAsyncWithHttpInfo(string ridDb, string ridColl,
                QueryRequest request, string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Execute a Stored Procedure
            /// </summary>
            /// <remarks>
            ///     Execute a Stored Procedure
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridProc">The Procedure ID</param>
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
            ///     
            /// </param>
            /// <returns>QueryResponseBody</returns>
            QueryResponseBody ExecuteStoredProcedure(string ridDb, string ridColl, string ridProc, QueryRequest request,
                string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery,
                string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Execute a Stored Procedure
            /// </summary>
            /// <remarks>
            ///     Execute a Stored Procedure
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridProc">The Procedure ID</param>
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
            ///     
            /// </param>
            /// <returns>ApiResponse of QueryResponseBody</returns>
            ApiResponse<QueryResponseBody> ExecuteStoredProcedureWithHttpInfo(string ridDb, string ridColl,
                string ridProc, QueryRequest request, string authorization, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion,
                string userAgent = null);

            /// <summary>
            ///     Execute a Stored Procedure
            /// </summary>
            /// <remarks>
            ///     Execute a Stored Procedure
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridProc">The Procedure ID</param>
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
            ///     
            /// </param>
            /// <returns>Task of QueryResponseBody</returns>
            Task<QueryResponseBody> ExecuteStoredProcedureAsync(string ridDb, string ridColl, string ridProc,
                QueryRequest request, string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan,
                bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Execute a Stored Procedure
            /// </summary>
            /// <remarks>
            ///     Execute a Stored Procedure
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridProc">The Procedure ID</param>
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
            ///     
            /// </param>
            /// <returns>Task of ApiResponse (QueryResponseBody)</returns>
            Task<ApiResponse<QueryResponseBody>> ExecuteStoredProcedureAsyncWithHttpInfo(string ridDb, string ridColl,
                string ridProc, QueryRequest request, string authorization, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion,
                string userAgent = null);
        }

        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public class StoredProcedureApi : IStoredProcedureApi
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="StoredProcedureApi" /> class.
            /// </summary>
            /// <returns></returns>
            public StoredProcedureApi(string basePath)
            {
                Configuration = new Configuration(new ApiClient(basePath));
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="StoredProcedureApi" /> class
            ///     using Configuration object
            /// </summary>
            /// <param name="configuration">An instance of Configuration</param>
            /// <returns></returns>
            public StoredProcedureApi(Configuration configuration = null)
            {
                if (configuration == null) // use the default one in Configuration
                    Configuration = Configuration.Default;
                else
                    Configuration = configuration;
            }

            /// <summary>
            ///     Gets or sets the configuration object
            /// </summary>
            /// <value>An instance of the Configuration</value>
            public Configuration Configuration { get; set; }


            /// <summary>
            ///     Get an List of all the stored procedures
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <returns>List&lt;StoredProcedure&gt;</returns>
            public List<StoredProcedure> GetStoredProceduresList(string ridDb, string ridColl)
            {
                var response = GetStoredProceduresListWithHttpInfo(ridDb, ridColl);
                return response.Data;
            }

            /// <summary>
            ///     Get an List of all the stored procedures
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <returns>ApiResponse of List&lt;StoredProcedure&gt;</returns>
            public ApiResponse<List<StoredProcedure>> GetStoredProceduresListWithHttpInfo(string ridDb, string ridColl)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridDb' when calling GetStoredProceduresList");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridColl' when calling GetStoredProceduresList");


                var path = "/{rid-db}/colls/{rid-coll}/sprocs";

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


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetStoredProceduresList: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetStoredProceduresList: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<StoredProcedure>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<StoredProcedure>)
                        Configuration.ApiClient.Deserialize(response, typeof (List<StoredProcedure>)));
            }

            /// <summary>
            ///     Get an List of all the stored procedures
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <returns>Task of List&lt;StoredProcedure&gt;</returns>
            public async Task<List<StoredProcedure>> GetStoredProceduresListAsync(string ridDb, string ridColl)
            {
                var response = await GetStoredProceduresListAsyncWithHttpInfo(ridDb, ridColl);
                return response.Data;
            }

            /// <summary>
            ///     Get an List of all the stored procedures
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <returns>Task of ApiResponse (List&lt;StoredProcedure&gt;)</returns>
            public async Task<ApiResponse<List<StoredProcedure>>> GetStoredProceduresListAsyncWithHttpInfo(string ridDb,
                string ridColl)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridDb' when calling GetStoredProceduresList");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridColl' when calling GetStoredProceduresList");


                var path = "/{rid-db}/colls/{rid-coll}/sprocs";

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


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetStoredProceduresList: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetStoredProceduresList: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<StoredProcedure>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<StoredProcedure>)
                        Configuration.ApiClient.Deserialize(response, typeof (List<StoredProcedure>)));
            }

            /// <summary>
            ///     Register a Stored Procedure Register a Stored Procedure
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
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
            ///     
            /// </param>
            /// <returns>StoredProcedure</returns>
            public StoredProcedure RegisterStoredProcedure(string ridDb, string ridColl, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response = RegisterStoredProcedureWithHttpInfo(ridDb, ridColl, request, authorization, xMsDate,
                    xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Register a Stored Procedure Register a Stored Procedure
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
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
            ///     
            /// </param>
            /// <returns>ApiResponse of StoredProcedure</returns>
            public ApiResponse<StoredProcedure> RegisterStoredProcedureWithHttpInfo(string ridDb, string ridColl,
                QueryRequest request, string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridDb' when calling RegisterStoredProcedure");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridColl' when calling RegisterStoredProcedure");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400,
                        "Missing required parameter 'request' when calling RegisterStoredProcedure");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling RegisterStoredProcedure");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDate' when calling RegisterStoredProcedure");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsVersion' when calling RegisterStoredProcedure");


                var path = "/{rid-db}/colls/{rid-coll}/sprocs";

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


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling RegisterStoredProcedure: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling RegisterStoredProcedure: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<StoredProcedure>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (StoredProcedure) Configuration.ApiClient.Deserialize(response, typeof (StoredProcedure)));
            }

            /// <summary>
            ///     Register a Stored Procedure Register a Stored Procedure
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
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
            ///     
            /// </param>
            /// <returns>Task of StoredProcedure</returns>
            public async Task<StoredProcedure> RegisterStoredProcedureAsync(string ridDb, string ridColl,
                QueryRequest request, string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response =
                    await
                        RegisterStoredProcedureAsyncWithHttpInfo(ridDb, ridColl, request, authorization, xMsDate,
                            xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Register a Stored Procedure Register a Stored Procedure
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="request"></param>
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
            ///     
            /// </param>
            /// <returns>Task of ApiResponse (StoredProcedure)</returns>
            public async Task<ApiResponse<StoredProcedure>> RegisterStoredProcedureAsyncWithHttpInfo(string ridDb,
                string ridColl, QueryRequest request, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridDb' when calling RegisterStoredProcedure");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridColl' when calling RegisterStoredProcedure");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400,
                        "Missing required parameter 'request' when calling RegisterStoredProcedure");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling RegisterStoredProcedure");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDate' when calling RegisterStoredProcedure");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsVersion' when calling RegisterStoredProcedure");


                var path = "/{rid-db}/colls/{rid-coll}/sprocs";

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


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling RegisterStoredProcedure: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling RegisterStoredProcedure: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<StoredProcedure>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (StoredProcedure) Configuration.ApiClient.Deserialize(response, typeof (StoredProcedure)));
            }

            /// <summary>
            ///     Execute a Stored Procedure Execute a Stored Procedure
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridProc">The Procedure ID</param>
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
            ///     
            /// </param>
            /// <returns>QueryResponseBody</returns>
            public QueryResponseBody ExecuteStoredProcedure(string ridDb, string ridColl, string ridProc,
                QueryRequest request, string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan,
                bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response = ExecuteStoredProcedureWithHttpInfo(ridDb, ridColl, ridProc, request, authorization,
                    contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Execute a Stored Procedure Execute a Stored Procedure
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridProc">The Procedure ID</param>
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
            ///     
            /// </param>
            /// <returns>ApiResponse of QueryResponseBody</returns>
            public ApiResponse<QueryResponseBody> ExecuteStoredProcedureWithHttpInfo(string ridDb, string ridColl,
                string ridProc, QueryRequest request, string authorization, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ExecuteStoredProcedure");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridColl' when calling ExecuteStoredProcedure");

                // verify the required parameter 'ridProc' is set
                if (ridProc == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridProc' when calling ExecuteStoredProcedure");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400,
                        "Missing required parameter 'request' when calling ExecuteStoredProcedure");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling ExecuteStoredProcedure");

                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400,
                        "Missing required parameter 'contentType' when calling ExecuteStoredProcedure");

                // verify the required parameter 'xMsDocumentdbQueryEnableScan' is set
                if (xMsDocumentdbQueryEnableScan == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbQueryEnableScan' when calling ExecuteStoredProcedure");

                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling ExecuteStoredProcedure");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDate' when calling ExecuteStoredProcedure");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsVersion' when calling ExecuteStoredProcedure");


                var path = "/{rid-db}/colls/{rid-coll}/sprocs/{rid-proc}";

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
                if (ridProc != null)
                    pathParams.Add("rid-proc", Configuration.ApiClient.ParameterToString(ridProc)); // path parameter


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
                        Configuration.ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling ExecuteStoredProcedure: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ExecuteStoredProcedure: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResponseBody) Configuration.ApiClient.Deserialize(response, typeof (QueryResponseBody)));
            }

            /// <summary>
            ///     Execute a Stored Procedure Execute a Stored Procedure
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridProc">The Procedure ID</param>
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
            ///     
            /// </param>
            /// <returns>Task of QueryResponseBody</returns>
            public async Task<QueryResponseBody> ExecuteStoredProcedureAsync(string ridDb, string ridColl,
                string ridProc, QueryRequest request, string authorization, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion,
                string userAgent = null)
            {
                var response =
                    await
                        ExecuteStoredProcedureAsyncWithHttpInfo(ridDb, ridColl, ridProc, request, authorization,
                            contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, xMsDate, xMsVersion,
                            userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Execute a Stored Procedure Execute a Stored Procedure
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridProc">The Procedure ID</param>
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
            ///     
            /// </param>
            /// <returns>Task of ApiResponse (QueryResponseBody)</returns>
            public async Task<ApiResponse<QueryResponseBody>> ExecuteStoredProcedureAsyncWithHttpInfo(string ridDb,
                string ridColl, string ridProc, QueryRequest request, string authorization, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ExecuteStoredProcedure");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridColl' when calling ExecuteStoredProcedure");
                // verify the required parameter 'ridProc' is set
                if (ridProc == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridProc' when calling ExecuteStoredProcedure");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400,
                        "Missing required parameter 'request' when calling ExecuteStoredProcedure");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling ExecuteStoredProcedure");
                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400,
                        "Missing required parameter 'contentType' when calling ExecuteStoredProcedure");
                // verify the required parameter 'xMsDocumentdbQueryEnableScan' is set
                if (xMsDocumentdbQueryEnableScan == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbQueryEnableScan' when calling ExecuteStoredProcedure");
                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling ExecuteStoredProcedure");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDate' when calling ExecuteStoredProcedure");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsVersion' when calling ExecuteStoredProcedure");


                var path = "/{rid-db}/colls/{rid-coll}/sprocs/{rid-proc}";

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
                if (ridProc != null)
                    pathParams.Add("rid-proc", Configuration.ApiClient.ParameterToString(ridProc)); // path parameter


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
                            Configuration.ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling ExecuteStoredProcedure: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ExecuteStoredProcedure: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResponseBody) Configuration.ApiClient.Deserialize(response, typeof (QueryResponseBody)));
            }

            /// <summary>
            ///     Gets the base path of the API client.
            /// </summary>
            /// <value>The base path</value>
            public string GetBasePath()
            {
                return Configuration.ApiClient.RestClient.BaseUrl.ToString();
            }

            
        }
    }
}