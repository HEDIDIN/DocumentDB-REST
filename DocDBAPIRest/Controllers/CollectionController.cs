using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DocDBAPIRest.Models;
using RestSharp;

namespace DocDBAPIRest.Controllers
{
    public class CollectionController : ApiController
    {
        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public interface ICollectionApi
        {
            /// <summary>
            ///     List Collections
            /// </summary>
            /// <remarks>
            ///     List Collections
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>List&lt;Collection&gt;</returns>
            List<Collection> ListCollections(string ridDb, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null);

            /// <summary>
            ///     List Collections
            /// </summary>
            /// <remarks>
            ///     List Collections
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>ApiResponse of List&lt;Collection&gt;</returns>
            ApiResponse<List<Collection>> ListCollectionsWithHttpInfo(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null);

            /// <summary>
            ///     List Collections
            /// </summary>
            /// <remarks>
            ///     List Collections
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of List&lt;Collection&gt;</returns>
            Task<List<Collection>> ListCollectionsAsync(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null);

            /// <summary>
            ///     List Collections
            /// </summary>
            /// <remarks>
            ///     List Collections
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of ApiResponse (List&lt;Collection&gt;)</returns>
            Task<ApiResponse<List<Collection>>> ListCollectionsAsyncWithHttpInfo(string ridDb, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Create a Collection
            /// </summary>
            /// <remarks>
            ///     Create a new Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Collection</returns>
            Collection CreateCollection(string ridDb, string authorization, string xMsDate, string xMsVersion,
                CustomBodyCollection id);

            /// <summary>
            ///     Create a Collection
            /// </summary>
            /// <remarks>
            ///     Create a new Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>ApiResponse of Collection</returns>
            ApiResponse<Collection> CreateCollectionWithHttpInfo(string ridDb, string authorization, string xMsDate,
                string xMsVersion, CustomBodyCollection id);

            /// <summary>
            ///     Create a Collection
            /// </summary>
            /// <remarks>
            ///     Create a new Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Task of Collection</returns>
            Task<Collection> CreateCollectionAsync(string ridDb, string authorization, string xMsDate, string xMsVersion,
                CustomBodyCollection id);

            /// <summary>
            ///     Create a Collection
            /// </summary>
            /// <remarks>
            ///     Create a new Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Task of ApiResponse (Collection)</returns>
            Task<ApiResponse<Collection>> CreateCollectionAsyncWithHttpInfo(string ridDb, string authorization,
                string xMsDate, string xMsVersion, CustomBodyCollection id);

            /// <summary>
            ///     Get a Collection
            /// </summary>
            /// <remarks>
            ///     Get a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Collection</returns>
            Collection GetCollectionById(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Get a Collection
            /// </summary>
            /// <remarks>
            ///     Get a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>ApiResponse of Collection</returns>
            ApiResponse<Collection> GetCollectionByIdWithHttpInfo(string ridDb, string ridColl, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Get a Collection
            /// </summary>
            /// <remarks>
            ///     Get a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of Collection</returns>
            Task<Collection> GetCollectionByIdAsync(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Get a Collection
            /// </summary>
            /// <remarks>
            ///     Get a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of ApiResponse (Collection)</returns>
            Task<ApiResponse<Collection>> GetCollectionByIdAsyncWithHttpInfo(string ridDb, string ridColl,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Delete a Collection
            /// </summary>
            /// <remarks>
            ///     Delete a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns></returns>
            void DeleteCollection(string ridDb, string ridColl, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null);

            /// <summary>
            ///     Delete a Collection
            /// </summary>
            /// <remarks>
            ///     Delete a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>ApiResponse of Object(void)</returns>
            ApiResponse<object> DeleteCollectionWithHttpInfo(string ridDb, string ridColl, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Delete a Collection
            /// </summary>
            /// <remarks>
            ///     Delete a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of void</returns>
            Task DeleteCollectionAsync(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Delete a Collection
            /// </summary>
            /// <remarks>
            ///     Delete a Collection
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of ApiResponse</returns>
            Task<ApiResponse<object>> DeleteCollectionAsyncWithHttpInfo(string ridDb, string ridColl,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null);
        }

        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public class CollectionApi : ICollectionApi
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="CollectionApi" /> class.
            /// </summary>
            /// <returns></returns>
            public CollectionApi(string basePath)
            {
                Configuration = new Configuration(new ApiClient(basePath));
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="CollectionApi" /> class
            ///     using Configuration object
            /// </summary>
            /// <param name="configuration">An instance of Configuration</param>
            /// <returns></returns>
            public CollectionApi(Configuration configuration = null)
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
            ///     List Collections List Collections
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>List&lt;Collection&gt;</returns>
            public List<Collection> ListCollections(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                var response = ListCollectionsWithHttpInfo(ridDb, authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     List Collections List Collections
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>ApiResponse of List&lt;Collection&gt;</returns>
            public ApiResponse<List<Collection>> ListCollectionsWithHttpInfo(string ridDb, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ListCollections");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling ListCollections");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ListCollections");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ListCollections");


                const string path = "/{rid-db}/colls";

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
                pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.GET, queryParams, null, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling ListCollections: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ListCollections: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<Collection>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<Collection>) Configuration.ApiClient.Deserialize(response, typeof (List<Collection>)));
            }

            /// <summary>
            ///     List Collections List Collections
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of List&lt;Collection&gt;</returns>
            public async Task<List<Collection>> ListCollectionsAsync(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                var response =
                    await ListCollectionsAsyncWithHttpInfo(ridDb, authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     List Collections List Collections
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of ApiResponse (List&lt;Collection&gt;)</returns>
            public async Task<ApiResponse<List<Collection>>> ListCollectionsAsyncWithHttpInfo(string ridDb,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ListCollections");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling ListCollections");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ListCollections");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ListCollections");


                var path = "/{rid-db}/colls";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
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
                pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.GET, queryParams, null, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling ListCollections: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ListCollections: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<Collection>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<Collection>) Configuration.ApiClient.Deserialize(response, typeof (List<Collection>)));
            }

            /// <summary>
            ///     Create a Collection Create a new Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Collection</returns>
            public Collection CreateCollection(string ridDb, string authorization, string xMsDate, string xMsVersion,
                CustomBodyCollection id)
            {
                var response = CreateCollectionWithHttpInfo(ridDb, authorization, xMsDate, xMsVersion, id);
                return response.Data;
            }

            /// <summary>
            ///     Create a Collection Create a new Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>ApiResponse of Collection</returns>
            public ApiResponse<Collection> CreateCollectionWithHttpInfo(string ridDb, string authorization,
                string xMsDate, string xMsVersion, CustomBodyCollection id)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling CreateCollection");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling CreateCollection");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling CreateCollection");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling CreateCollection");

                // verify the required parameter 'id' is set
                if (id == null)
                    throw new ApiException(400, "Missing required parameter 'id' when calling CreateCollection");


                const string path = "/{rid-db}/colls";

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
                pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                var postBody = Configuration.ApiClient.Serialize(id);


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling CreateCollection: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling CreateCollection: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Collection>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Collection) Configuration.ApiClient.Deserialize(response, typeof (Collection)));
            }

            /// <summary>
            ///     Create a Collection Create a new Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Task of Collection</returns>
            public async Task<Collection> CreateCollectionAsync(string ridDb, string authorization, string xMsDate,
                string xMsVersion, CustomBodyCollection id)
            {
                var response = await CreateCollectionAsyncWithHttpInfo(ridDb, authorization, xMsDate, xMsVersion, id);
                return response.Data;
            }

            /// <summary>
            ///     Create a Collection Create a new Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Task of ApiResponse (Collection)</returns>
            public async Task<ApiResponse<Collection>> CreateCollectionAsyncWithHttpInfo(string ridDb,
                string authorization, string xMsDate, string xMsVersion, CustomBodyCollection id)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling CreateCollection");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling CreateCollection");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling CreateCollection");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling CreateCollection");
                // verify the required parameter 'id' is set
                if (id == null)
                    throw new ApiException(400, "Missing required parameter 'id' when calling CreateCollection");


                const string path = "/{rid-db}/colls";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
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
                pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                var postBody = Configuration.ApiClient.Serialize(id);


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling CreateCollection: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling CreateCollection: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Collection>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Collection) Configuration.ApiClient.Deserialize(response, typeof (Collection)));
            }

            /// <summary>
            ///     Get a Collection Get a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Collection</returns>
            public Collection GetCollectionById(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                var response = GetCollectionByIdWithHttpInfo(ridDb, ridColl, authorization, xMsDate, xMsVersion,
                    userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get a Collection Get a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>ApiResponse of Collection</returns>
            public ApiResponse<Collection> GetCollectionByIdWithHttpInfo(string ridDb, string ridColl,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetCollectionById");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling GetCollectionById");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling GetCollectionById");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetCollectionById");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetCollectionById");


                const string path = "/{rid-db}/colls/{rid-coll}";

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
                pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                pathParams.Add("rid-coll", Configuration.ApiClient.ParameterToString(ridColl)); // path parameter


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.GET, queryParams, null, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetCollectionById: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetCollectionById: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Collection>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Collection) Configuration.ApiClient.Deserialize(response, typeof (Collection)));
            }

            /// <summary>
            ///     Get a Collection Get a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of Collection</returns>
            public async Task<Collection> GetCollectionByIdAsync(string ridDb, string ridColl, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response =
                    await
                        GetCollectionByIdAsyncWithHttpInfo(ridDb, ridColl, authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get a Collection Get a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of ApiResponse (Collection)</returns>
            public async Task<ApiResponse<Collection>> GetCollectionByIdAsyncWithHttpInfo(string ridDb, string ridColl,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetCollectionById");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling GetCollectionById");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling GetCollectionById");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetCollectionById");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetCollectionById");


                const string path = "/{rid-db}/colls/{rid-coll}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
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
                pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                pathParams.Add("rid-coll", Configuration.ApiClient.ParameterToString(ridColl)); // path parameter


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.GET, queryParams, null, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetCollectionById: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetCollectionById: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Collection>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Collection) Configuration.ApiClient.Deserialize(response, typeof (Collection)));
            }

            /// <summary>
            ///     Delete a Collection Delete a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns></returns>
            public void DeleteCollection(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                DeleteCollectionWithHttpInfo(ridDb, ridColl, authorization, xMsDate, xMsVersion, userAgent);
            }

            /// <summary>
            ///     Delete a Collection Delete a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>ApiResponse of Object(void)</returns>
            public ApiResponse<object> DeleteCollectionWithHttpInfo(string ridDb, string ridColl, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling DeleteCollection");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling DeleteCollection");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling DeleteCollection");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling DeleteCollection");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling DeleteCollection");


                const string path = "/{rid-db}/colls/{rid-coll}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();


                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                pathParams.Add("rid-coll", Configuration.ApiClient.ParameterToString(ridColl)); // path parameter


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.DELETE, queryParams, null, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling DeleteCollection: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling DeleteCollection: " + response.ErrorMessage,
                        response.ErrorMessage);


                return new ApiResponse<object>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    null);
            }

            /// <summary>
            ///     Delete a Collection Delete a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of void</returns>
            public async Task DeleteCollectionAsync(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                await DeleteCollectionAsyncWithHttpInfo(ridDb, ridColl, authorization, xMsDate, xMsVersion, userAgent);
            }

            /// <summary>
            ///     Delete a Collection Delete a Collection
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection Id</param>
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
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of ApiResponse</returns>
            public async Task<ApiResponse<object>> DeleteCollectionAsyncWithHttpInfo(string ridDb, string ridColl,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling DeleteCollection");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling DeleteCollection");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling DeleteCollection");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling DeleteCollection");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling DeleteCollection");


                const string path = "/{rid-db}/colls/{rid-coll}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();


                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                pathParams.Add("rid-coll", Configuration.ApiClient.ParameterToString(ridColl)); // path parameter


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.DELETE, queryParams, null,
                                headerParams, formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling DeleteCollection: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling DeleteCollection: " + response.ErrorMessage,
                        response.ErrorMessage);


                return new ApiResponse<object>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    null);
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