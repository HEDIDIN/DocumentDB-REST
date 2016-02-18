using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DocDBAPIRest.Models;
using RestSharp;

namespace DocDBAPIRest.Controllers
{
    public class TriggerController : ApiController
    {
        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public interface ITriggerApi
        {
            /// <summary>
            ///     Get an List of all the Triggers
            /// </summary>
            /// <remarks>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>List&lt;Trigger&gt;</returns>
            List<Trigger> GetTriggerList(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Get an List of all the Triggers
            /// </summary>
            /// <remarks>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of List&lt;Trigger&gt;</returns>
            ApiResponse<List<Trigger>> GetTriggerListWithHttpInfo(string ridDb, string ridColl, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Get an List of all the Triggers
            /// </summary>
            /// <remarks>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of List&lt;Trigger&gt;</returns>
            Task<List<Trigger>> GetTriggerListAsync(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Get an List of all the Triggers
            /// </summary>
            /// <remarks>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (List&lt;Trigger&gt;)</returns>
            Task<ApiResponse<List<Trigger>>> GetTriggerListAsyncWithHttpInfo(string ridDb, string ridColl,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Query a Trigger
            /// </summary>
            /// <remarks>
            ///     Query a Trigger
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>QueryResponseBody</returns>
            QueryResponseBody QueryTrigger(string ridDb, string ridColl, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Query a Trigger
            /// </summary>
            /// <remarks>
            ///     Query a Trigger
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of QueryResponseBody</returns>
            ApiResponse<QueryResponseBody> QueryTriggerWithHttpInfo(string ridDb, string ridColl, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Query a Trigger
            /// </summary>
            /// <remarks>
            ///     Query a Trigger
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of QueryResponseBody</returns>
            Task<QueryResponseBody> QueryTriggerAsync(string ridDb, string ridColl, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Query a Trigger
            /// </summary>
            /// <remarks>
            ///     Query a Trigger
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (QueryResponseBody)</returns>
            Task<ApiResponse<QueryResponseBody>> QueryTriggerAsyncWithHttpInfo(string ridDb, string ridColl,
                string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null);
        }

        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public class TriggerApi : ITriggerApi
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="TriggerApi" /> class.
            /// </summary>
            /// <returns></returns>
            public TriggerApi(string basePath)
            {
                Configuration = new Configuration(new ApiClient(basePath));
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="TriggerApi" /> class
            ///     using Configuration object
            /// </summary>
            /// <param name="configuration">An instance of Configuration</param>
            /// <returns></returns>
            public TriggerApi(Configuration configuration = null)
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
            ///     Get an List of all the Triggers
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>List&lt;Trigger&gt;</returns>
            public List<Trigger> GetTriggerList(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                var response = GetTriggerListWithHttpInfo(ridDb, ridColl, authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get an List of all the Triggers
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of List&lt;Trigger&gt;</returns>
            public ApiResponse<List<Trigger>> GetTriggerListWithHttpInfo(string ridDb, string ridColl,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetTriggerList");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling GetTriggerList");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetTriggerList");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetTriggerList");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetTriggerList");


                var path = "/{rid-db}/colls/{rid-coll}/trigger";

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

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetTriggerList: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetTriggerList: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<Trigger>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<Trigger>) Configuration.ApiClient.Deserialize(response, typeof (List<Trigger>)));
            }

            /// <summary>
            ///     Get an List of all the Triggers
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of List&lt;Trigger&gt;</returns>
            public async Task<List<Trigger>> GetTriggerListAsync(string ridDb, string ridColl, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response =
                    await GetTriggerListAsyncWithHttpInfo(ridDb, ridColl, authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get an List of all the Triggers
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (List&lt;Trigger&gt;)</returns>
            public async Task<ApiResponse<List<Trigger>>> GetTriggerListAsyncWithHttpInfo(string ridDb, string ridColl,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetTriggerList");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling GetTriggerList");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetTriggerList");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetTriggerList");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetTriggerList");


                var path = "/{rid-db}/colls/{rid-coll}/trigger";

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

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetTriggerList: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetTriggerList: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<Trigger>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<Trigger>) Configuration.ApiClient.Deserialize(response, typeof (List<Trigger>)));
            }

            /// <summary>
            ///     Query a Trigger Query a Trigger
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>QueryResponseBody</returns>
            public QueryResponseBody QueryTrigger(string ridDb, string ridColl, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response = QueryTriggerWithHttpInfo(ridDb, ridColl, contentType, xMsDocumentdbQueryEnableScan,
                    xMsDocumentdbIsquery, request, authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Query a Trigger Query a Trigger
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of QueryResponseBody</returns>
            public ApiResponse<QueryResponseBody> QueryTriggerWithHttpInfo(string ridDb, string ridColl,
                string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling QueryTrigger");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling QueryTrigger");

                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400, "Missing required parameter 'contentType' when calling QueryTrigger");

                // verify the required parameter 'xMsDocumentdbQueryEnableScan' is set
                if (xMsDocumentdbQueryEnableScan == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbQueryEnableScan' when calling QueryTrigger");

                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryTrigger");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling QueryTrigger");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling QueryTrigger");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling QueryTrigger");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling QueryTrigger");


                var path = "/{rid-db}/colls/{rid-coll}/trigger";

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


                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (xMsDocumentdbQueryEnableScan != null)
                    headerParams.Add("x-ms-documentdb-query-enable-scan",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbQueryEnableScan)); // header parameter
                if (xMsDocumentdbIsquery != null)
                    headerParams.Add("x-ms-documentdb-isquery",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbIsquery)); // header parameter
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
                    throw new ApiException(statusCode, "Error calling QueryTrigger: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryTrigger: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResponseBody) Configuration.ApiClient.Deserialize(response, typeof (QueryResponseBody)));
            }

            /// <summary>
            ///     Query a Trigger Query a Trigger
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of QueryResponseBody</returns>
            public async Task<QueryResponseBody> QueryTriggerAsync(string ridDb, string ridColl, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response =
                    await
                        QueryTriggerAsyncWithHttpInfo(ridDb, ridColl, contentType, xMsDocumentdbQueryEnableScan,
                            xMsDocumentdbIsquery, request, authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Query a Trigger Query a Trigger
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
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
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (QueryResponseBody)</returns>
            public async Task<ApiResponse<QueryResponseBody>> QueryTriggerAsyncWithHttpInfo(string ridDb, string ridColl,
                string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling QueryTrigger");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling QueryTrigger");
                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400, "Missing required parameter 'contentType' when calling QueryTrigger");
                // verify the required parameter 'xMsDocumentdbQueryEnableScan' is set
                if (xMsDocumentdbQueryEnableScan == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbQueryEnableScan' when calling QueryTrigger");
                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryTrigger");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling QueryTrigger");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling QueryTrigger");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling QueryTrigger");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling QueryTrigger");


                var path = "/{rid-db}/colls/{rid-coll}/trigger";

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


                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (xMsDocumentdbQueryEnableScan != null)
                    headerParams.Add("x-ms-documentdb-query-enable-scan",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbQueryEnableScan)); // header parameter
                if (xMsDocumentdbIsquery != null)
                    headerParams.Add("x-ms-documentdb-isquery",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbIsquery)); // header parameter
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
                    throw new ApiException(statusCode, "Error calling QueryTrigger: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryTrigger: " + response.ErrorMessage,
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