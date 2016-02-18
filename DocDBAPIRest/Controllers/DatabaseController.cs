using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DocDBAPIRest.Models;
using RestSharp;

namespace DocDBAPIRest.Controllers
{
    public class DatabaseController : ApiController
    {
        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public interface IDatabaseApi
        {
            /// <summary>
            ///     List Databases
            /// </summary>
            /// <remarks>
            ///     List Databases
            /// </remarks>
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
            /// <param name="xMsGatewayversion">The Microsft Date Gateway version</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is `
            ///    
            /// </param>
            /// <returns>List&lt;DatabaseCollection&gt;</returns>
            List<DatabaseCollection> GetDatabaseList(string authorization, string xMsDate, string xMsVersion,
                string xMsGatewayversion, string userAgent = null);

            /// <summary>
            ///     List Databases
            /// </summary>
            /// <remarks>
            ///     List Databases
            /// </remarks>
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
            /// <param name="xMsGatewayversion">The Microsft Date Gateway version</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is `
            ///    
            /// </param>
            /// <returns>ApiResponse of List&lt;DatabaseCollection&gt;</returns>
            ApiResponse<List<DatabaseCollection>> GetDatabaseListWithHttpInfo(string authorization, string xMsDate,
                string xMsVersion, string xMsGatewayversion, string userAgent = null);

            /// <summary>
            ///     List Databases
            /// </summary>
            /// <remarks>
            ///     List Databases
            /// </remarks>
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
            /// <param name="xMsGatewayversion">The Microsft Date Gateway version</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is `
            ///    
            /// </param>
            /// <returns>Task of List&lt;DatabaseCollection&gt;</returns>
            Task<List<DatabaseCollection>> GetDatabaseListAsync(string authorization, string xMsDate, string xMsVersion,
                string xMsGatewayversion, string userAgent = null);

            /// <summary>
            ///     List Databases
            /// </summary>
            /// <remarks>
            ///     List Databases
            /// </remarks>
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
            /// <param name="xMsGatewayversion">The Microsft Date Gateway version</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is `
            ///    
            /// </param>
            /// <returns>Task of ApiResponse (List&lt;DatabaseCollection&gt;)</returns>
            Task<ApiResponse<List<DatabaseCollection>>> GetDatabaseListAsyncWithHttpInfo(string authorization,
                string xMsDate, string xMsVersion, string xMsGatewayversion, string userAgent = null);

            /// <summary>
            ///     Create a new Database
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">
            ///     For creating a database, the Content-Type header must be `&lt;c&gt;application/json&lt;/c&gt;
            ///     `.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.  
            ///    
            /// </param>
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Database</returns>
            Database CreateDatabase(string authorization, string contentType, string xMsDate, CustomBodyCollection id);

            /// <summary>
            ///     Create a new Database
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">
            ///     For creating a database, the Content-Type header must be `&lt;c&gt;application/json&lt;/c&gt;
            ///     `.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.  
            ///    
            /// </param>
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>ApiResponse of Database</returns>
            ApiResponse<Database> CreateDatabaseWithHttpInfo(string authorization, string contentType, string xMsDate,
                CustomBodyCollection id);

            /// <summary>
            ///     Create a new Database
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">
            ///     For creating a database, the Content-Type header must be `&lt;c&gt;application/json&lt;/c&gt;
            ///     `.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.  
            ///    
            /// </param>
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Task of Database</returns>
            Task<Database> CreateDatabaseAsync(string authorization, string contentType, string xMsDate,
                CustomBodyCollection id);

            /// <summary>
            ///     Create a new Database
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">
            ///     For creating a database, the Content-Type header must be `&lt;c&gt;application/json&lt;/c&gt;
            ///     `.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.  
            ///    
            /// </param>
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Task of ApiResponse (Database)</returns>
            Task<ApiResponse<Database>> CreateDatabaseAsyncWithHttpInfo(string authorization, string contentType,
                string xMsDate, CustomBodyCollection id);

            /// <summary>
            ///     Retrieve a database resource by Id
            /// </summary>
            /// <remarks>
            ///     Retrieve a database resource by Id
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
            /// <param name="xMsGatewayversion"></param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be `application/json`.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Database</returns>
            Database GetDatabaseById(string ridDb, string authorization, string xMsDate, string xMsVersion,
                string xMsGatewayversion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Retrieve a database resource by Id
            /// </summary>
            /// <remarks>
            ///     Retrieve a database resource by Id
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
            /// <param name="xMsGatewayversion"></param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be `application/json`.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>ApiResponse of Database</returns>
            ApiResponse<Database> GetDatabaseByIdWithHttpInfo(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string xMsGatewayversion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Retrieve a database resource by Id
            /// </summary>
            /// <remarks>
            ///     Retrieve a database resource by Id
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
            /// <param name="xMsGatewayversion"></param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be `application/json`.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of Database</returns>
            Task<Database> GetDatabaseByIdAsync(string ridDb, string authorization, string xMsDate, string xMsVersion,
                string xMsGatewayversion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Retrieve a database resource by Id
            /// </summary>
            /// <remarks>
            ///     Retrieve a database resource by Id
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
            /// <param name="xMsGatewayversion"></param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be `application/json`.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of ApiResponse (Database)</returns>
            Task<ApiResponse<Database>> GetDatabaseByIdAsyncWithHttpInfo(string ridDb, string authorization,
                string xMsDate, string xMsVersion, string xMsGatewayversion, string contentType = null,
                string userAgent = null);

            /// <summary>
            ///     Delete a Database
            /// </summary>
            /// <remarks>
            ///     Delete a Database
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;sample&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/sample&gt;{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns></returns>
            void DeleteDatabase(string ridDb, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null);

            /// <summary>
            ///     Delete a Database
            /// </summary>
            /// <remarks>
            ///     Delete a Database
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;sample&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/sample&gt;{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of Object(void)</returns>
            ApiResponse<object> DeleteDatabaseWithHttpInfo(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Delete a Database
            /// </summary>
            /// <remarks>
            ///     Delete a Database
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;sample&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/sample&gt;{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of void</returns>
            Task DeleteDatabaseAsync(string ridDb, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null);

            /// <summary>
            ///     Delete a Database
            /// </summary>
            /// <remarks>
            ///     Delete a Database
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;sample&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/sample&gt;{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse</returns>
            Task<ApiResponse<object>> DeleteDatabaseAsyncWithHttpInfo(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);
        }

        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public class DatabaseApi : IDatabaseApi
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="DatabaseApi" /> class.
            /// </summary>
            /// <returns></returns>
            public DatabaseApi(string basePath)
            {
                Configuration = new Configuration(new ApiClient(basePath));
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="DatabaseApi" /> class
            ///     using Configuration object
            /// </summary>
            /// <param name="configuration">An instance of Configuration</param>
            /// <returns></returns>
            public DatabaseApi(Configuration configuration = null)
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
            ///     List Databases List Databases
            /// </summary>
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
            /// <param name="xMsGatewayversion">The Microsft Date Gateway version</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is `
            ///    
            /// </param>
            /// <returns>List&lt;DatabaseCollection&gt;</returns>
            public List<DatabaseCollection> GetDatabaseList(string authorization, string xMsDate, string xMsVersion,
                string xMsGatewayversion, string userAgent = null)
            {
                var response = GetDatabaseListWithHttpInfo(authorization, xMsDate, xMsVersion, xMsGatewayversion,
                    userAgent);
                return response.Data;
            }

            /// <summary>
            ///     List Databases List Databases
            /// </summary>
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
            /// <param name="xMsGatewayversion">The Microsft Date Gateway version</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is `
            ///    
            /// </param>
            /// <returns>ApiResponse of List&lt;DatabaseCollection&gt;</returns>
            public ApiResponse<List<DatabaseCollection>> GetDatabaseListWithHttpInfo(string authorization,
                string xMsDate, string xMsVersion, string xMsGatewayversion, string userAgent = null)
            {
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling GetDatabaseList");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetDatabaseList");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetDatabaseList");

                // verify the required parameter 'xMsGatewayversion' is set
                if (xMsGatewayversion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsGatewayversion' when calling GetDatabaseList");


                const string path = "/";

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


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter
                headerParams.Add("x-ms-gatewayversion", Configuration.ApiClient.ParameterToString(xMsGatewayversion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.GET, queryParams, null, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetDatabaseList: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetDatabaseList: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<DatabaseCollection>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<DatabaseCollection>)
                        Configuration.ApiClient.Deserialize(response, typeof (List<DatabaseCollection>)));
            }

            /// <summary>
            ///     List Databases List Databases
            /// </summary>
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
            /// <param name="xMsGatewayversion">The Microsft Date Gateway version</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is `
            ///    
            /// </param>
            /// <returns>Task of List&lt;DatabaseCollection&gt;</returns>
            public async Task<List<DatabaseCollection>> GetDatabaseListAsync(string authorization, string xMsDate,
                string xMsVersion, string xMsGatewayversion, string userAgent = null)
            {
                var response =
                    await
                        GetDatabaseListAsyncWithHttpInfo(authorization, xMsDate, xMsVersion, xMsGatewayversion,
                            userAgent);
                return response.Data;
            }

            /// <summary>
            ///     List Databases List Databases
            /// </summary>
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
            /// <param name="xMsGatewayversion">The Microsft Date Gateway version</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is `
            ///    
            /// </param>
            /// <returns>Task of ApiResponse (List&lt;DatabaseCollection&gt;)</returns>
            public async Task<ApiResponse<List<DatabaseCollection>>> GetDatabaseListAsyncWithHttpInfo(
                string authorization, string xMsDate, string xMsVersion, string xMsGatewayversion,
                string userAgent = null)
            {
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling GetDatabaseList");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetDatabaseList");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetDatabaseList");
                // verify the required parameter 'xMsGatewayversion' is set
                if (xMsGatewayversion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsGatewayversion' when calling GetDatabaseList");


                const string path = "/";

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


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter
                headerParams.Add("x-ms-gatewayversion", Configuration.ApiClient.ParameterToString(xMsGatewayversion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.GET, queryParams, null, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetDatabaseList: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetDatabaseList: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<DatabaseCollection>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<DatabaseCollection>)
                        Configuration.ApiClient.Deserialize(response, typeof (List<DatabaseCollection>)));
            }

            /// <summary>
            ///     Create a new Database
            /// </summary>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">
            ///     For creating a database, the Content-Type header must be `&lt;c&gt;application/json&lt;/c&gt;
            ///     `.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.  
            ///    
            /// </param>
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Database</returns>
            public Database CreateDatabase(string authorization, string contentType, string xMsDate,
                CustomBodyCollection id)
            {
                var response = CreateDatabaseWithHttpInfo(authorization, contentType, xMsDate, id);
                return response.Data;
            }

            /// <summary>
            ///     Create a new Database
            /// </summary>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">
            ///     For creating a database, the Content-Type header must be `&lt;c&gt;application/json&lt;/c&gt;
            ///     `.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.  
            ///    
            /// </param>
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>ApiResponse of Database</returns>
            public ApiResponse<Database> CreateDatabaseWithHttpInfo(string authorization, string contentType,
                string xMsDate, CustomBodyCollection id)
            {
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling CreateDatabase");

                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400, "Missing required parameter 'contentType' when calling CreateDatabase");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling CreateDatabase");

                // verify the required parameter 'id' is set
                if (id == null)
                    throw new ApiException(400, "Missing required parameter 'id' when calling CreateDatabase");


                const string path = "/";

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


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter


                var postBody = Configuration.ApiClient.Serialize(id);


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling CreateDatabase: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling CreateDatabase: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Database>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Database) Configuration.ApiClient.Deserialize(response, typeof (Database)));
            }

            /// <summary>
            ///     Create a new Database
            /// </summary>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">
            ///     For creating a database, the Content-Type header must be `&lt;c&gt;application/json&lt;/c&gt;
            ///     `.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.  
            ///    
            /// </param>
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Task of Database</returns>
            public async Task<Database> CreateDatabaseAsync(string authorization, string contentType, string xMsDate,
                CustomBodyCollection id)
            {
                var response = await CreateDatabaseAsyncWithHttpInfo(authorization, contentType, xMsDate, id);
                return response.Data;
            }

            /// <summary>
            ///     Create a new Database
            /// </summary>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">
            ///     For creating a database, the Content-Type header must be `&lt;c&gt;application/json&lt;/c&gt;
            ///     `.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.  
            ///    
            /// </param>
            /// <param name="id">This is a user settable property. It is the unique name that identifies the collection</param>
            /// <returns>Task of ApiResponse (Database)</returns>
            public async Task<ApiResponse<Database>> CreateDatabaseAsyncWithHttpInfo(string authorization,
                string contentType, string xMsDate, CustomBodyCollection id)
            {
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling CreateDatabase");
                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400, "Missing required parameter 'contentType' when calling CreateDatabase");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling CreateDatabase");
                // verify the required parameter 'id' is set
                if (id == null)
                    throw new ApiException(400, "Missing required parameter 'id' when calling CreateDatabase");


                const string path = "/";

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


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
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
                    throw new ApiException(statusCode, "Error calling CreateDatabase: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling CreateDatabase: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Database>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Database) Configuration.ApiClient.Deserialize(response, typeof (Database)));
            }

            /// <summary>
            ///     Retrieve a database resource by Id Retrieve a database resource by Id
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
            /// <param name="xMsGatewayversion"></param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be `application/json`.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Database</returns>
            public Database GetDatabaseById(string ridDb, string authorization, string xMsDate, string xMsVersion,
                string xMsGatewayversion, string contentType = null, string userAgent = null)
            {
                var response = GetDatabaseByIdWithHttpInfo(ridDb, authorization, xMsDate, xMsVersion, xMsGatewayversion,
                    contentType, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Retrieve a database resource by Id Retrieve a database resource by Id
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
            /// <param name="xMsGatewayversion"></param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be `application/json`.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>ApiResponse of Database</returns>
            public ApiResponse<Database> GetDatabaseByIdWithHttpInfo(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string xMsGatewayversion, string contentType = null, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetDatabaseById");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling GetDatabaseById");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetDatabaseById");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetDatabaseById");

                // verify the required parameter 'xMsGatewayversion' is set
                if (xMsGatewayversion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsGatewayversion' when calling GetDatabaseById");


                const string path = "/{rid-db}";

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
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter
                headerParams.Add("x-ms-gatewayversion", Configuration.ApiClient.ParameterToString(xMsGatewayversion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.GET, queryParams, null, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetDatabaseById: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetDatabaseById: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Database>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Database) Configuration.ApiClient.Deserialize(response, typeof (Database)));
            }

            /// <summary>
            ///     Retrieve a database resource by Id Retrieve a database resource by Id
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
            /// <param name="xMsGatewayversion"></param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be `application/json`.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of Database</returns>
            public async Task<Database> GetDatabaseByIdAsync(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string xMsGatewayversion, string contentType = null, string userAgent = null)
            {
                var response =
                    await
                        GetDatabaseByIdAsyncWithHttpInfo(ridDb, authorization, xMsDate, xMsVersion, xMsGatewayversion,
                            contentType, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Retrieve a database resource by Id Retrieve a database resource by Id
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
            /// <param name="xMsGatewayversion"></param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be `application/json`.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     
            /// </param>
            /// <returns>Task of ApiResponse (Database)</returns>
            public async Task<ApiResponse<Database>> GetDatabaseByIdAsyncWithHttpInfo(string ridDb, string authorization,
                string xMsDate, string xMsVersion, string xMsGatewayversion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetDatabaseById");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling GetDatabaseById");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetDatabaseById");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetDatabaseById");
                // verify the required parameter 'xMsGatewayversion' is set
                if (xMsGatewayversion == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsGatewayversion' when calling GetDatabaseById");


                const string path = "/{rid-db}";

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
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                // header parameter
                headerParams.Add("x-ms-gatewayversion", Configuration.ApiClient.ParameterToString(xMsGatewayversion));
                // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.GET, queryParams, null, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetDatabaseById: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetDatabaseById: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Database>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Database) Configuration.ApiClient.Deserialize(response, typeof (Database)));
            }

            /// <summary>
            ///     Delete a Database Delete a Database
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;sample&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/sample&gt;{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns></returns>
            public void DeleteDatabase(string ridDb, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null)
            {
                DeleteDatabaseWithHttpInfo(ridDb, authorization, xMsDate, xMsVersion, contentType, userAgent);
            }

            /// <summary>
            ///     Delete a Database Delete a Database
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;sample&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/sample&gt;{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of Object(void)</returns>
            public ApiResponse<object> DeleteDatabaseWithHttpInfo(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling DeleteDatabase");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling DeleteDatabase");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling DeleteDatabase");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling DeleteDatabase");


                var path = "/{rid-db}";

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


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
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
                    throw new ApiException(statusCode, "Error calling DeleteDatabase: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling DeleteDatabase: " + response.ErrorMessage,
                        response.ErrorMessage);


                return new ApiResponse<object>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    null);
            }

            /// <summary>
            ///     Delete a Database Delete a Database
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;sample&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/sample&gt;{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of void</returns>
            public async Task DeleteDatabaseAsync(string ridDb, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null)
            {
                await DeleteDatabaseAsyncWithHttpInfo(ridDb, authorization, xMsDate, xMsVersion, contentType, userAgent);
            }

            /// <summary>
            ///     Delete a Database Delete a Database
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;sample&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/sample&gt;{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse</returns>
            public async Task<ApiResponse<object>> DeleteDatabaseAsyncWithHttpInfo(string ridDb, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling DeleteDatabase");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling DeleteDatabase");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling DeleteDatabase");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling DeleteDatabase");


                var path = "/{rid-db}";

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


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
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
                    throw new ApiException(statusCode, "Error calling DeleteDatabase: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling DeleteDatabase: " + response.ErrorMessage,
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