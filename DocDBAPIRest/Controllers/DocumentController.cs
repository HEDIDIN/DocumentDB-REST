using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DocDBAPIRest.Models;
using RestSharp;

namespace DocDBAPIRest.Controllers
{
    public class DocumentController : ApiController
    {
        
        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public class DocumentApi : IDocumentApi
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="DocumentApi" /> class.
            /// </summary>
            /// <returns></returns>
            public DocumentApi(string basePath)
            {
                Configuration = new Configuration(new ApiClient(basePath));
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="DocumentApi" /> class
            ///     using Configuration object
            /// </summary>
            /// <param name="configuration">An instance of Configuration</param>
            /// <returns></returns>
            public DocumentApi(Configuration configuration = null)
            {
                Configuration = configuration ?? Configuration.Default;
            }

            /// <summary>
            ///     Gets or sets the configuration object
            /// </summary>
            /// <value>An instance of the Configuration</value>
            public Configuration Configuration { get; set; }


            /// <summary>
            ///     List Documents List Documents
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
            ///     provided use 
            /// </param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>List&lt;Document&gt;</returns>
            public List<Document> ListDocuments(string ridDb, string ridColl, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                var response = ListDocumentsWithHttpInfo(ridDb, ridColl, authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     List Documents List Documents
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
            ///     provided use 
            /// </param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>ApiResponse of List&lt;Document&gt;</returns>
            public ApiResponse<List<Document>> ListDocumentsWithHttpInfo(string ridDb, string ridColl,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ListDocuments");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling ListDocuments");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling ListDocuments");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ListDocuments");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ListDocuments");


                const string path = "/{rid-db}/colls/{rid-coll}/docs";

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
                    throw new ApiException(statusCode, "Error calling ListDocuments: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ListDocuments: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<Document>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<Document>) Configuration.ApiClient.Deserialize(response, typeof (List<Document>)));
            }

            /// <summary>
            ///     List Documents List Documents
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
            ///     provided use 
            /// </param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of List&lt;Document&gt;</returns>
            public async Task<List<Document>> ListDocumentsAsync(string ridDb, string ridColl, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response =
                    await ListDocumentsAsyncWithHttpInfo(ridDb, ridColl, authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     List Documents List Documents
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
            ///     provided use 
            /// </param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of ApiResponse (List&lt;Document&gt;)</returns>
            public async Task<ApiResponse<List<Document>>> ListDocumentsAsyncWithHttpInfo(string ridDb, string ridColl,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ListDocuments");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling ListDocuments");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling ListDocuments");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ListDocuments");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ListDocuments");


                const string path = "/{rid-db}/colls/{rid-coll}/docs";

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
                    throw new ApiException(statusCode, "Error calling ListDocuments: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ListDocuments: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<Document>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<Document>) Configuration.ApiClient.Deserialize(response, typeof (List<Document>)));
            }

            /// <summary>
            ///     Create a Document Create a new Document
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Document</returns>
            public Document CreateDocument(string ridDb, string ridColl, CustomBody request, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response = CreateDocumentWithHttpInfo(ridDb, ridColl, request, authorization, xMsDate, xMsVersion,
                    userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Create a Document Create a new Document
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>ApiResponse of Document</returns>
            public ApiResponse<Document> CreateDocumentWithHttpInfo(string ridDb, string ridColl, CustomBody request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling CreateDocument");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling CreateDocument");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling CreateDocument");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling CreateDocument");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling CreateDocument");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling CreateDocument");


                var path = "/{rid-db}/colls/{rid-coll}/docs";

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


                var postBody = Configuration.ApiClient.Serialize(request);


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling CreateDocument: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling CreateDocument: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Document>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Document) Configuration.ApiClient.Deserialize(response, typeof (Document)));
            }

            /// <summary>
            ///     Create a Document Create a new Document
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of Document</returns>
            public async Task<Document> CreateDocumentAsync(string ridDb, string ridColl, CustomBody request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response =
                    await
                        CreateDocumentAsyncWithHttpInfo(ridDb, ridColl, request, authorization, xMsDate, xMsVersion,
                            userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Create a Document Create a new Document
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of ApiResponse (Document)</returns>
            public async Task<ApiResponse<Document>> CreateDocumentAsyncWithHttpInfo(string ridDb, string ridColl,
                CustomBody request, string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling CreateDocument");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling CreateDocument");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling CreateDocument");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling CreateDocument");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling CreateDocument");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling CreateDocument");


                var path = "/{rid-db}/colls/{rid-coll}/docs";

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


                var postBody = Configuration.ApiClient.Serialize(request);


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling CreateDocument: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling CreateDocument: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Document>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Document) Configuration.ApiClient.Deserialize(response, typeof (Document)));
            }

            /// <summary>
            ///     Get a Document. Get a Document.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 
            /// </param>
            /// <returns>Document</returns>
            public Document GetDocumentById(string ridDb, string ridColl, string ridDoc, string authorization,
                string userAgent, string xMsVersion)
            {
                var response = GetDocumentByIdWithHttpInfo(ridDb, ridColl, ridDoc, authorization, userAgent, xMsVersion);
                return response.Data;
            }

            /// <summary>
            ///     Get a Document. Get a Document.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 
            /// </param>
            /// <returns>ApiResponse of Document</returns>
            public ApiResponse<Document> GetDocumentByIdWithHttpInfo(string ridDb, string ridColl, string ridDoc,
                string authorization, string userAgent, string xMsVersion)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetDocumentById");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling GetDocumentById");

                // verify the required parameter 'ridDoc' is set
                if (ridDoc == null)
                    throw new ApiException(400, "Missing required parameter 'ridDoc' when calling GetDocumentById");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling GetDocumentById");

                // verify the required parameter 'userAgent' is set
                if (userAgent == null)
                    throw new ApiException(400, "Missing required parameter 'userAgent' when calling GetDocumentById");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetDocumentById");


                const string path = "/{rid-db}/colls/{rid-coll}/docs/{rid-doc}";

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
                if (ridDoc != null)
                    pathParams.Add("rid-doc", Configuration.ApiClient.ParameterToString(ridDoc)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
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
                    throw new ApiException(statusCode, "Error calling GetDocumentById: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetDocumentById: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Document>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Document) Configuration.ApiClient.Deserialize(response, typeof (Document)));
            }

            /// <summary>
            ///     Get a Document. Get a Document.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 
            /// </param>
            /// <returns>Task of Document</returns>
            public async Task<Document> GetDocumentByIdAsync(string ridDb, string ridColl, string ridDoc,
                string authorization, string userAgent, string xMsVersion)
            {
                var response =
                    await GetDocumentByIdAsyncWithHttpInfo(ridDb, ridColl, ridDoc, authorization, userAgent, xMsVersion);
                return response.Data;
            }

            /// <summary>
            ///     Get a Document. Get a Document.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 
            /// </param>
            /// <returns>Task of ApiResponse (Document)</returns>
            public async Task<ApiResponse<Document>> GetDocumentByIdAsyncWithHttpInfo(string ridDb, string ridColl,
                string ridDoc, string authorization, string userAgent, string xMsVersion)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetDocumentById");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling GetDocumentById");
                // verify the required parameter 'ridDoc' is set
                if (ridDoc == null)
                    throw new ApiException(400, "Missing required parameter 'ridDoc' when calling GetDocumentById");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling GetDocumentById");
                // verify the required parameter 'userAgent' is set
                if (userAgent == null)
                    throw new ApiException(400, "Missing required parameter 'userAgent' when calling GetDocumentById");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetDocumentById");


                var path = "/{rid-db}/colls/{rid-coll}/docs/{rid-doc}";

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
                if (ridDoc != null)
                    pathParams.Add("rid-doc", Configuration.ApiClient.ParameterToString(ridDoc)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
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
                    throw new ApiException(statusCode, "Error calling GetDocumentById: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetDocumentById: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Document>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Document) Configuration.ApiClient.Deserialize(response, typeof (Document)));
            }

            /// <summary>
            ///     Replace a Document Replace a Document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
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
            /// <param name="request"></param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Document</returns>
            public Document ReplaceDocument(string ridDb, string ridColl, string ridDoc, string authorization,
                string xMsDate, string xMsVersion, Document request = null, string userAgent = null)
            {
                var response = ReplaceDocumentWithHttpInfo(ridDb, ridColl, ridDoc, authorization, xMsDate, xMsVersion,
                    request, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Replace a Document Replace a Document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
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
            /// <param name="request"></param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>ApiResponse of Document</returns>
            public ApiResponse<Document> ReplaceDocumentWithHttpInfo(string ridDb, string ridColl, string ridDoc,
                string authorization, string xMsDate, string xMsVersion, Document request = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ReplaceDocument");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling ReplaceDocument");

                // verify the required parameter 'ridDoc' is set
                if (ridDoc == null)
                    throw new ApiException(400, "Missing required parameter 'ridDoc' when calling ReplaceDocument");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling ReplaceDocument");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ReplaceDocument");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ReplaceDocument");


                var path = "/{rid-db}/colls/{rid-coll}/docs/{rid-doc}";

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
                if (ridDoc != null)
                    pathParams.Add("rid-doc", Configuration.ApiClient.ParameterToString(ridDoc)); // path parameter


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


                var postBody = Configuration.ApiClient.Serialize(request);


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling ReplaceDocument: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ReplaceDocument: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Document>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Document) Configuration.ApiClient.Deserialize(response, typeof (Document)));
            }

            /// <summary>
            ///     Replace a Document Replace a Document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
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
            /// <param name="request"></param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of Document</returns>
            public async Task<Document> ReplaceDocumentAsync(string ridDb, string ridColl, string ridDoc,
                string authorization, string xMsDate, string xMsVersion, Document request = null,
                string userAgent = null)
            {
                var response =
                    await
                        ReplaceDocumentAsyncWithHttpInfo(ridDb, ridColl, ridDoc, authorization, xMsDate, xMsVersion,
                            request, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Replace a Document Replace a Document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
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
            /// <param name="request"></param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of ApiResponse (Document)</returns>
            public async Task<ApiResponse<Document>> ReplaceDocumentAsyncWithHttpInfo(string ridDb, string ridColl,
                string ridDoc, string authorization, string xMsDate, string xMsVersion, Document request = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ReplaceDocument");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling ReplaceDocument");
                // verify the required parameter 'ridDoc' is set
                if (ridDoc == null)
                    throw new ApiException(400, "Missing required parameter 'ridDoc' when calling ReplaceDocument");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling ReplaceDocument");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ReplaceDocument");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ReplaceDocument");


                const string path = "/{rid-db}/colls/{rid-coll}/docs/{rid-doc}";

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
                pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                pathParams.Add("rid-coll", Configuration.ApiClient.ParameterToString(ridColl)); // path parameter
                pathParams.Add("rid-doc", Configuration.ApiClient.ParameterToString(ridDoc)); // path parameter


                headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter
                headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.PUT, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling ReplaceDocument: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ReplaceDocument: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Document>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Document) Configuration.ApiClient.Deserialize(response, typeof (Document)));
            }

            /// <summary>
            ///     Delete a Document Delete a Document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.&lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c&gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns></returns>
            public void DeleteDocument(string ridDb, string ridColl, string ridDoc, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                DeleteDocumentWithHttpInfo(ridDb, ridColl, ridDoc, authorization, xMsDate, xMsVersion, userAgent);
            }

            /// <summary>
            ///     Delete a Document Delete a Document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.&lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c&gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>ApiResponse of Object(void)</returns>
            public ApiResponse<object> DeleteDocumentWithHttpInfo(string ridDb, string ridColl, string ridDoc,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling DeleteDocument");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling DeleteDocument");

                // verify the required parameter 'ridDoc' is set
                if (ridDoc == null)
                    throw new ApiException(400, "Missing required parameter 'ridDoc' when calling DeleteDocument");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling DeleteDocument");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling DeleteDocument");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling DeleteDocument");


                var path = "/{rid-db}/colls/{rid-coll}/docs/{rid-doc}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

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
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridColl != null)
                    pathParams.Add("rid-coll", Configuration.ApiClient.ParameterToString(ridColl)); // path parameter
                if (ridDoc != null)
                    pathParams.Add("rid-doc", Configuration.ApiClient.ParameterToString(ridDoc)); // path parameter


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
                        Configuration.ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling DeleteDocument: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling DeleteDocument: " + response.ErrorMessage,
                        response.ErrorMessage);


                return new ApiResponse<object>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    null);
            }

            /// <summary>
            ///     Delete a Document Delete a Document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.&lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c&gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of void</returns>
            public async Task DeleteDocumentAsync(string ridDb, string ridColl, string ridDoc, string authorization,
                string xMsDate, string xMsVersion, string userAgent = null)
            {
                await
                    DeleteDocumentAsyncWithHttpInfo(ridDb, ridColl, ridDoc, authorization, xMsDate, xMsVersion,
                        userAgent);
            }

            /// <summary>
            ///     Delete a Document Delete a Document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.&lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c&gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. 
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of ApiResponse</returns>
            public async Task<ApiResponse<object>> DeleteDocumentAsyncWithHttpInfo(string ridDb, string ridColl,
                string ridDoc, string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling DeleteDocument");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling DeleteDocument");
                // verify the required parameter 'ridDoc' is set
                if (ridDoc == null)
                    throw new ApiException(400, "Missing required parameter 'ridDoc' when calling DeleteDocument");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling DeleteDocument");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling DeleteDocument");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling DeleteDocument");


                var path = "/{rid-db}/colls/{rid-coll}/docs/{rid-doc}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

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
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridColl != null)
                    pathParams.Add("rid-coll", Configuration.ApiClient.ParameterToString(ridColl)); // path parameter
                if (ridDoc != null)
                    pathParams.Add("rid-doc", Configuration.ApiClient.ParameterToString(ridDoc)); // path parameter


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
                            Configuration.ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody,
                                headerParams, formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling DeleteDocument: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling DeleteDocument: " + response.ErrorMessage,
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

            /// <summary>
            ///     Sets the base path of the API client.
            /// </summary>
            /// <value>The base path</value>
            [Obsolete(
                "SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead."
                )]
            public void SetBasePath(string basePath)
            {
                // do nothing
            }

            /// <summary>
            ///     Gets the default header.
            /// </summary>
            /// <returns>Dictionary of HTTP header</returns>
            [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
            public Dictionary<string, string> DefaultHeader()
            {
                return Configuration.DefaultHeader;
            }

            /// <summary>
            ///     Add default header.
            /// </summary>
            /// <param name="key">Header field name.</param>
            /// <param name="value">Header field value.</param>
            /// <returns></returns>
            [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
            public void AddDefaultHeader(string key, string value)
            {
                Configuration.AddDefaultHeader(key, value);
            }
        }
    }
}