using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DocDBAPIRest.Models;
using RestSharp;

namespace DocDBAPIRest.Controllers
{
    public class ResourceController : ApiController
    {
        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public interface IResourceApi
        {
            /// <summary>
            ///     Perform a query on a Collection Resource
            /// </summary>
            /// <remarks>
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>QueryResourceResponseBody</returns>
            QueryResourceResponseBody QueryCollectionResource(string ridDb, string ridColl, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string contentType, bool? xMsDocumentdbIsquery,
                string userAgent = null, string xMsMaxItemCount = null, string xMsContinuation = null,
                bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null, string accept = null);

            /// <summary>
            ///     Perform a query on a Collection Resource
            /// </summary>
            /// <remarks>
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>ApiResponse of QueryResourceResponseBody</returns>
            ApiResponse<QueryResourceResponseBody> QueryCollectionResourceWithHttpInfo(string ridDb, string ridColl,
                QueryRequest request, string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbIsquery, string userAgent = null, string xMsMaxItemCount = null,
                string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null,
                string accept = null);

            /// <summary>
            ///     Perform a query on a Collection Resource
            /// </summary>
            /// <remarks>
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>Task of QueryResourceResponseBody</returns>
            Task<QueryResourceResponseBody> QueryCollectionResourceAsync(string ridDb, string ridColl,
                QueryRequest request, string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbIsquery, string userAgent = null, string xMsMaxItemCount = null,
                string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null,
                string accept = null);

            /// <summary>
            ///     Perform a query on a Collection Resource
            /// </summary>
            /// <remarks>
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>Task of ApiResponse (QueryResourceResponseBody)</returns>
            Task<ApiResponse<QueryResourceResponseBody>> QueryCollectionResourceAsyncWithHttpInfo(string ridDb,
                string ridColl, QueryRequest request, string authorization, string xMsDate, string xMsVersion,
                string contentType, bool? xMsDocumentdbIsquery, string userAgent = null, string xMsMaxItemCount = null,
                string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null,
                string accept = null);

            /// <summary>
            ///     Perform a query on a Document Resource
            /// </summary>
            /// <remarks>
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>QueryResourceResponseBody</returns>
            QueryResourceResponseBody QueryDocumentResource(string ridDb, string ridColl, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string contentType, bool? xMsDocumentdbIsquery,
                string userAgent = null, string xMsMaxItemCount = null, string xMsContinuation = null,
                bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null, string accept = null);

            /// <summary>
            ///     Perform a query on a Document Resource
            /// </summary>
            /// <remarks>
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>ApiResponse of QueryResourceResponseBody</returns>
            ApiResponse<QueryResourceResponseBody> QueryDocumentResourceWithHttpInfo(string ridDb, string ridColl,
                QueryRequest request, string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbIsquery, string userAgent = null, string xMsMaxItemCount = null,
                string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null,
                string accept = null);

            /// <summary>
            ///     Perform a query on a Document Resource
            /// </summary>
            /// <remarks>
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>Task of QueryResourceResponseBody</returns>
            Task<QueryResourceResponseBody> QueryDocumentResourceAsync(string ridDb, string ridColl,
                QueryRequest request, string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbIsquery, string userAgent = null, string xMsMaxItemCount = null,
                string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null,
                string accept = null);

            /// <summary>
            ///     Perform a query on a Document Resource
            /// </summary>
            /// <remarks>
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>Task of ApiResponse (QueryResourceResponseBody)</returns>
            Task<ApiResponse<QueryResourceResponseBody>> QueryDocumentResourceAsyncWithHttpInfo(string ridDb,
                string ridColl, QueryRequest request, string authorization, string xMsDate, string xMsVersion,
                string contentType, bool? xMsDocumentdbIsquery, string userAgent = null, string xMsMaxItemCount = null,
                string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null,
                string accept = null);
        }

        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public class ResourceApi : IResourceApi
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="ResourceApi" /> class.
            /// </summary>
            /// <returns></returns>
            public ResourceApi(string basePath)
            {
                Configuration = new Configuration(new ApiClient(basePath));
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="ResourceApi" /> class
            ///     using Configuration object
            /// </summary>
            /// <param name="configuration">An instance of Configuration</param>
            /// <returns></returns>
            public ResourceApi(Configuration configuration = null)
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
            ///     Perform a query on a Collection Resource
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>QueryResourceResponseBody</returns>
            public QueryResourceResponseBody QueryCollectionResource(string ridDb, string ridColl, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string contentType, bool? xMsDocumentdbIsquery,
                string userAgent = null, string xMsMaxItemCount = null, string xMsContinuation = null,
                bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null, string accept = null)
            {
                var response = QueryCollectionResourceWithHttpInfo(ridDb, ridColl, request, authorization, xMsDate,
                    xMsVersion, contentType, xMsDocumentdbIsquery, userAgent, xMsMaxItemCount, xMsContinuation,
                    xMsDocumentdbQueryEnableScan, xMsSessionToken, accept);
                return response.Data;
            }

            /// <summary>
            ///     Perform a query on a Collection Resource
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>ApiResponse of QueryResourceResponseBody</returns>
            public ApiResponse<QueryResourceResponseBody> QueryCollectionResourceWithHttpInfo(string ridDb,
                string ridColl, QueryRequest request, string authorization, string xMsDate, string xMsVersion,
                string contentType, bool? xMsDocumentdbIsquery, string userAgent = null, string xMsMaxItemCount = null,
                string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null,
                string accept = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridDb' when calling QueryCollectionResource");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridColl' when calling QueryCollectionResource");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400,
                        "Missing required parameter 'request' when calling QueryCollectionResource");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling QueryCollectionResource");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDate' when calling QueryCollectionResource");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsVersion' when calling QueryCollectionResource");

                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400,
                        "Missing required parameter 'contentType' when calling QueryCollectionResource");

                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryCollectionResource");


                var path = "/{rid-db}/colls/{rid-coll}/";

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
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (xMsDocumentdbIsquery != null)
                    headerParams.Add("x-ms-documentdb-isquery",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbIsquery)); // header parameter
                if (xMsMaxItemCount != null)
                    headerParams.Add("x-ms-max-item-count", Configuration.ApiClient.ParameterToString(xMsMaxItemCount));
                        // header parameter
                if (xMsContinuation != null)
                    headerParams.Add("x-ms-continuation", Configuration.ApiClient.ParameterToString(xMsContinuation));
                        // header parameter
                if (xMsDocumentdbQueryEnableScan != null)
                    headerParams.Add("x-ms-documentdb-query-enable-scan",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbQueryEnableScan)); // header parameter
                if (xMsSessionToken != null)
                    headerParams.Add("x-ms-session-token", Configuration.ApiClient.ParameterToString(xMsSessionToken));
                        // header parameter
                if (accept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.ParameterToString(accept)); // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling QueryCollectionResource: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryCollectionResource: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResourceResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResourceResponseBody)
                        Configuration.ApiClient.Deserialize(response, typeof (QueryResourceResponseBody)));
            }

            /// <summary>
            ///     Perform a query on a Collection Resource
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>Task of QueryResourceResponseBody</returns>
            public async Task<QueryResourceResponseBody> QueryCollectionResourceAsync(string ridDb, string ridColl,
                QueryRequest request, string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbIsquery, string userAgent = null, string xMsMaxItemCount = null,
                string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null,
                string accept = null)
            {
                var response =
                    await
                        QueryCollectionResourceAsyncWithHttpInfo(ridDb, ridColl, request, authorization, xMsDate,
                            xMsVersion, contentType, xMsDocumentdbIsquery, userAgent, xMsMaxItemCount, xMsContinuation,
                            xMsDocumentdbQueryEnableScan, xMsSessionToken, accept);
                return response.Data;
            }

            /// <summary>
            ///     Perform a query on a Collection Resource
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>Task of ApiResponse (QueryResourceResponseBody)</returns>
            public async Task<ApiResponse<QueryResourceResponseBody>> QueryCollectionResourceAsyncWithHttpInfo(
                string ridDb, string ridColl, QueryRequest request, string authorization, string xMsDate,
                string xMsVersion, string contentType, bool? xMsDocumentdbIsquery, string userAgent = null,
                string xMsMaxItemCount = null, string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null,
                string xMsSessionToken = null, string accept = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridDb' when calling QueryCollectionResource");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridColl' when calling QueryCollectionResource");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400,
                        "Missing required parameter 'request' when calling QueryCollectionResource");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling QueryCollectionResource");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDate' when calling QueryCollectionResource");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsVersion' when calling QueryCollectionResource");
                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400,
                        "Missing required parameter 'contentType' when calling QueryCollectionResource");
                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryCollectionResource");


                var path = "/{rid-db}/colls/{rid-coll}/";

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
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (xMsDocumentdbIsquery != null)
                    headerParams.Add("x-ms-documentdb-isquery",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbIsquery)); // header parameter
                if (xMsMaxItemCount != null)
                    headerParams.Add("x-ms-max-item-count", Configuration.ApiClient.ParameterToString(xMsMaxItemCount));
                        // header parameter
                if (xMsContinuation != null)
                    headerParams.Add("x-ms-continuation", Configuration.ApiClient.ParameterToString(xMsContinuation));
                        // header parameter
                if (xMsDocumentdbQueryEnableScan != null)
                    headerParams.Add("x-ms-documentdb-query-enable-scan",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbQueryEnableScan)); // header parameter
                if (xMsSessionToken != null)
                    headerParams.Add("x-ms-session-token", Configuration.ApiClient.ParameterToString(xMsSessionToken));
                        // header parameter
                if (accept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.ParameterToString(accept)); // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling QueryCollectionResource: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryCollectionResource: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResourceResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResourceResponseBody)
                        Configuration.ApiClient.Deserialize(response, typeof (QueryResourceResponseBody)));
            }

            /// <summary>
            ///     Perform a query on a Document Resource
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>QueryResourceResponseBody</returns>
            public QueryResourceResponseBody QueryDocumentResource(string ridDb, string ridColl, QueryRequest request,
                string authorization, string xMsDate, string xMsVersion, string contentType, bool? xMsDocumentdbIsquery,
                string userAgent = null, string xMsMaxItemCount = null, string xMsContinuation = null,
                bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null, string accept = null)
            {
                var response = QueryDocumentResourceWithHttpInfo(ridDb, ridColl, request, authorization, xMsDate,
                    xMsVersion, contentType, xMsDocumentdbIsquery, userAgent, xMsMaxItemCount, xMsContinuation,
                    xMsDocumentdbQueryEnableScan, xMsSessionToken, accept);
                return response.Data;
            }

            /// <summary>
            ///     Perform a query on a Document Resource
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>ApiResponse of QueryResourceResponseBody</returns>
            public ApiResponse<QueryResourceResponseBody> QueryDocumentResourceWithHttpInfo(string ridDb, string ridColl,
                QueryRequest request, string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbIsquery, string userAgent = null, string xMsMaxItemCount = null,
                string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null,
                string accept = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling QueryDocumentResource");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridColl' when calling QueryDocumentResource");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400,
                        "Missing required parameter 'request' when calling QueryDocumentResource");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling QueryDocumentResource");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDate' when calling QueryDocumentResource");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsVersion' when calling QueryDocumentResource");

                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400,
                        "Missing required parameter 'contentType' when calling QueryDocumentResource");

                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryDocumentResource");


                var path = "/{rid-db}/colls/{rid-coll}/doc";

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
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (xMsDocumentdbIsquery != null)
                    headerParams.Add("x-ms-documentdb-isquery",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbIsquery)); // header parameter
                if (xMsMaxItemCount != null)
                    headerParams.Add("x-ms-max-item-count", Configuration.ApiClient.ParameterToString(xMsMaxItemCount));
                        // header parameter
                if (xMsContinuation != null)
                    headerParams.Add("x-ms-continuation", Configuration.ApiClient.ParameterToString(xMsContinuation));
                        // header parameter
                if (xMsDocumentdbQueryEnableScan != null)
                    headerParams.Add("x-ms-documentdb-query-enable-scan",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbQueryEnableScan)); // header parameter
                if (xMsSessionToken != null)
                    headerParams.Add("x-ms-session-token", Configuration.ApiClient.ParameterToString(xMsSessionToken));
                        // header parameter
                if (accept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.ParameterToString(accept)); // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling QueryDocumentResource: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryDocumentResource: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResourceResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResourceResponseBody)
                        Configuration.ApiClient.Deserialize(response, typeof (QueryResourceResponseBody)));
            }

            /// <summary>
            ///     Perform a query on a Document Resource
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>Task of QueryResourceResponseBody</returns>
            public async Task<QueryResourceResponseBody> QueryDocumentResourceAsync(string ridDb, string ridColl,
                QueryRequest request, string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbIsquery, string userAgent = null, string xMsMaxItemCount = null,
                string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null, string xMsSessionToken = null,
                string accept = null)
            {
                var response =
                    await
                        QueryDocumentResourceAsyncWithHttpInfo(ridDb, ridColl, request, authorization, xMsDate,
                            xMsVersion, contentType, xMsDocumentdbIsquery, userAgent, xMsMaxItemCount, xMsContinuation,
                            xMsDocumentdbQueryEnableScan, xMsSessionToken, accept);
                return response.Data;
            }

            /// <summary>
            ///     Perform a query on a Document Resource
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
            ///     provided use 
            /// </param>
            /// <param name="contentType">Must be set to application/query+json</param>
            /// <param name="xMsDocumentdbIsquery">Required. This property must be set to true</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <param name="xMsMaxItemCount">
            ///     To page through a result set, set this header to the maximum number for items to be
            ///     returned back in a single page. &lt;remarks&gt;Range 1 - 1000 Default value = 100&lt;/remarks&gt;
            /// </param>
            /// <param name="xMsContinuation">
            ///     To navigate to the next page of items, set this header to the continuation token for the
            ///     next page.
            /// </param>
            /// <param name="xMsDocumentdbQueryEnableScan">
            ///     Use an index scan to process the query if the right index path of type is
            ///     not available.
            /// </param>
            /// <param name="xMsSessionToken">The session token for the request. Used for session consistency</param>
            /// <param name="accept">
            ///     Optional. At the moment, DocumentDB always returns the response payload in standard JSON format.
            ///     The client must be able to accept the response body in standard JSON format
            /// </param>
            /// <returns>Task of ApiResponse (QueryResourceResponseBody)</returns>
            public async Task<ApiResponse<QueryResourceResponseBody>> QueryDocumentResourceAsyncWithHttpInfo(
                string ridDb, string ridColl, QueryRequest request, string authorization, string xMsDate,
                string xMsVersion, string contentType, bool? xMsDocumentdbIsquery, string userAgent = null,
                string xMsMaxItemCount = null, string xMsContinuation = null, bool? xMsDocumentdbQueryEnableScan = null,
                string xMsSessionToken = null, string accept = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling QueryDocumentResource");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400,
                        "Missing required parameter 'ridColl' when calling QueryDocumentResource");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400,
                        "Missing required parameter 'request' when calling QueryDocumentResource");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling QueryDocumentResource");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDate' when calling QueryDocumentResource");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsVersion' when calling QueryDocumentResource");
                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400,
                        "Missing required parameter 'contentType' when calling QueryDocumentResource");
                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryDocumentResource");


                var path = "/{rid-db}/colls/{rid-coll}/doc";

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
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (xMsDocumentdbIsquery != null)
                    headerParams.Add("x-ms-documentdb-isquery",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbIsquery)); // header parameter
                if (xMsMaxItemCount != null)
                    headerParams.Add("x-ms-max-item-count", Configuration.ApiClient.ParameterToString(xMsMaxItemCount));
                        // header parameter
                if (xMsContinuation != null)
                    headerParams.Add("x-ms-continuation", Configuration.ApiClient.ParameterToString(xMsContinuation));
                        // header parameter
                if (xMsDocumentdbQueryEnableScan != null)
                    headerParams.Add("x-ms-documentdb-query-enable-scan",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbQueryEnableScan)); // header parameter
                if (xMsSessionToken != null)
                    headerParams.Add("x-ms-session-token", Configuration.ApiClient.ParameterToString(xMsSessionToken));
                        // header parameter
                if (accept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.ParameterToString(accept)); // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling QueryDocumentResource: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryDocumentResource: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResourceResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResourceResponseBody)
                        Configuration.ApiClient.Deserialize(response, typeof (QueryResourceResponseBody)));
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