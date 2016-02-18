using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DocDBAPIRest.Models;
using RestSharp;

namespace DocDBAPIRest.Controllers
{
    public class AttachmentController : ApiController
    {
        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public interface IAttachmentApi       {
            /// <summary>
            ///     Get an Attachment
            /// </summary>
            /// <remarks>
            ///     Get an Attachment from document
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="ridAttch">The Attachment ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>AttachmentRaw</returns>
            AttachmentRaw GetAttachement(string ridDb, string ridColl, string ridDoc, string ridAttch,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Get an Attachment
            /// </summary>
            /// <remarks>
            ///     Get an Attachment from document
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="ridAttch">The Attachment ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>ApiResponse of AttachmentRaw</returns>
            ApiResponse<AttachmentRaw> GetAttachementWithHttpInfo(string ridDb, string ridColl, string ridDoc,
                string ridAttch, string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Get an Attachment
            /// </summary>
            /// <remarks>
            ///     Get an Attachment from document
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="ridAttch">The Attachment ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>Task of AttachmentRaw</returns>
            Task<AttachmentRaw> GetAttachementAsync(string ridDb, string ridColl, string ridDoc,
                string ridAttch, string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Get an Attachment
            /// </summary>
            /// <remarks>
            ///     Get an Attachment from document
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="ridAttch">The Attachment ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>Task of ApiResponse (AttachmentRaw)</returns>
            Task<ApiResponse<AttachmentRaw>> GetAttachementAsyncWithHttpInfo(string ridDb,
                string ridColl, string ridDoc, string ridAttch, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null);

            /// <summary>
            ///     Create an Attachment
            /// </summary>
            /// <remarks>
            ///     Create an Attachment
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>AttachmentResponse</returns>
            AttachmentResponse CreateAttachement(string ridDb, string ridColl, string ridDoc, AttachmentRaw request,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Create an Attachment
            /// </summary>
            /// <remarks>
            ///     Create an Attachment
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>ApiResponse of AttachmentResponse</returns>
            ApiResponse<AttachmentResponse> CreateAttachementWithHttpInfo(string ridDb, string ridColl, string ridDoc,
                AttachmentRaw request, string authorization, string xMsDate, string xMsVersion, string userAgent = null);

            /// <summary>
            ///     Create an Attachment
            /// </summary>
            /// <remarks>
            ///     Create an Attachment
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>Task of AttachmentResponse</returns>
            Task<AttachmentResponse> CreateAttachementAsync(string ridDb, string ridColl,
                string ridDoc, AttachmentRaw request, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null);

            /// <summary>
            ///     Create an Attachment
            /// </summary>
            /// <remarks>
            ///     Create an Attachment
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>Task of ApiResponse (AttachmentResponse)</returns>
            Task<ApiResponse<AttachmentResponse>> CreateAttachementAsyncWithHttpInfo(
                string ridDb, string ridColl, string ridDoc, AttachmentRaw request, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null);
        }

        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public class AttachmentApi : IAttachmentApi
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="AttachmentApi" /> class.
            /// </summary>
            /// <returns></returns>
            public AttachmentApi(string basePath)
            {
                Configuration = new Configuration(new ApiClient(basePath));
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="AttachmentApi" /> class
            ///     using Configuration object
            /// </summary>
            /// <param name="configuration">An instance of Configuration</param>
            /// <returns></returns>
            public AttachmentApi(Configuration configuration = null)
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
            ///     Get an Attachment Get an Attachment from document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="ridAttch">The Attachment ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>AttachmentRaw</returns>
            public AttachmentRaw GetAttachement(string ridDb, string ridColl, string ridDoc, string ridAttch,
                string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response = GetAttachementWithHttpInfo(ridDb, ridColl, ridDoc, ridAttch,
                    authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get an Attachment Get an Attachment from document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="ridAttch">The Attachment ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>ApiResponse of AttachmentRaw</returns>
            public ApiResponse<AttachmentRaw> GetAttachementWithHttpInfo(string ridDb, string ridColl, string ridDoc,
                string ridAttch, string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetAttachement");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling GetAttachement");

                // verify the required parameter 'ridDoc' is set
                if (ridDoc == null)
                    throw new ApiException(400, "Missing required parameter 'ridDoc' when calling GetAttachement");

                // verify the required parameter 'ridAttch' is set
                if (ridAttch == null)
                    throw new ApiException(400, "Missing required parameter 'ridAttch' when calling GetAttachement");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetAttachement");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetAttachement");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetAttachement");


                const string path = "//{rid-db}/colls/{rid-coll}/docs/{rid-doc}/attachments/{rid-attch}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();


                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json", "image/jpeg", "application/dicom"
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
                pathParams.Add("rid-attch", Configuration.ApiClient.ParameterToString(ridAttch)); // path parameter


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
                    throw new ApiException(statusCode, "Error calling GetAttachement: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetAttachement: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<AttachmentRaw>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (AttachmentRaw) Configuration.ApiClient.Deserialize(response, typeof (AttachmentRaw)));
            }

            /// <summary>
            ///     Get an Attachment Get an Attachment from document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="ridAttch">The Attachment ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>Task of AttachmentRaw</returns>
            public async Task<AttachmentRaw> GetAttachementAsync(string ridDb, string ridColl,
                string ridDoc, string ridAttch, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null)
            {
                var response =
                    await
                        GetAttachementAsyncWithHttpInfo(ridDb, ridColl, ridDoc, ridAttch, authorization, xMsDate,
                            xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get an Attachment Get an Attachment from document
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="ridAttch">The Attachment ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>Task of ApiResponse (AttachmentRaw)</returns>
            public async Task<ApiResponse<AttachmentRaw>> GetAttachementAsyncWithHttpInfo(
                string ridDb, string ridColl, string ridDoc, string ridAttch, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetAttachement");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling GetAttachement");
                // verify the required parameter 'ridDoc' is set
                if (ridDoc == null)
                    throw new ApiException(400, "Missing required parameter 'ridDoc' when calling GetAttachement");
                // verify the required parameter 'ridAttch' is set
                if (ridAttch == null)
                    throw new ApiException(400, "Missing required parameter 'ridAttch' when calling GetAttachement");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetAttachement");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetAttachement");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetAttachement");


                const string path = "//{rid-db}/colls/{rid-coll}/docs/{rid-doc}/attachments/{rid-attch}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();


                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json", "image/jpeg", "application/dicom"
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
                pathParams.Add("rid-attch", Configuration.ApiClient.ParameterToString(ridAttch)); // path parameter


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
                    throw new ApiException(statusCode, "Error calling GetAttachement: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetAttachement: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<AttachmentRaw>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (AttachmentRaw) Configuration.ApiClient.Deserialize(response, typeof (AttachmentRaw)));
            }

            /// <summary>
            ///     Create an Attachment Create an Attachment
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>AttachmentResponse</returns>
            public AttachmentResponse CreateAttachement(string ridDb, string ridColl, string ridDoc,
                AttachmentRaw request, string authorization, string xMsDate, string xMsVersion, string userAgent = null)
            {
                var response = CreateAttachementWithHttpInfo(ridDb, ridColl, ridDoc, request,
                    authorization, xMsDate, xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Create an Attachment Create an Attachment
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>ApiResponse of AttachmentResponse</returns>
            public ApiResponse<AttachmentResponse> CreateAttachementWithHttpInfo(string ridDb, string ridColl,
                string ridDoc, AttachmentRaw request, string authorization, string xMsDate, string xMsVersion,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling CreateAttachement");

                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling CreateAttachement");

                // verify the required parameter 'ridDoc' is set
                if (ridDoc == null)
                    throw new ApiException(400, "Missing required parameter 'ridDoc' when calling CreateAttachement");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling CreateAttachement");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling CreateAttachement");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling CreateAttachement");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling CreateAttachement");


                const string path = "/{rid-db}/colls/{rid-coll}/docs/{rid-doc}/attachments";

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


                var postBody = Configuration.ApiClient.Serialize(request);


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling CreateAttachement: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling CreateAttachement: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<AttachmentResponse>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (AttachmentResponse) Configuration.ApiClient.Deserialize(response, typeof (AttachmentResponse)));
            }

            /// <summary>
            ///     Create an Attachment Create an Attachment
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>Task of AttachmentResponse</returns>
            public async Task<AttachmentResponse> CreateAttachementAsync(string ridDb,
                string ridColl, string ridDoc, AttachmentRaw request, string authorization, string xMsDate,
                string xMsVersion, string userAgent = null)
            {
                var response =
                    await
                        CreateAttachementAsyncWithHttpInfo(ridDb, ridColl, ridDoc, request, authorization, xMsDate,
                            xMsVersion, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Create an Attachment Create an Attachment
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridColl">The Collection ID</param>
            /// <param name="ridDoc">The Document ID</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     <c>{user agent name}/{version}</c>.
            /// </param>
            /// <returns>Task of ApiResponse (AttachmentResponse)</returns>
            public async Task<ApiResponse<AttachmentResponse>> CreateAttachementAsyncWithHttpInfo
                (string ridDb, string ridColl, string ridDoc, AttachmentRaw request, string authorization,
                    string xMsDate, string xMsVersion, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling CreateAttachement");
                // verify the required parameter 'ridColl' is set
                if (ridColl == null)
                    throw new ApiException(400, "Missing required parameter 'ridColl' when calling CreateAttachement");
                // verify the required parameter 'ridDoc' is set
                if (ridDoc == null)
                    throw new ApiException(400, "Missing required parameter 'ridDoc' when calling CreateAttachement");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling CreateAttachement");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling CreateAttachement");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling CreateAttachement");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling CreateAttachement");


                const string path = "/{rid-db}/colls/{rid-coll}/docs/{rid-doc}/attachments";

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


                var postBody = Configuration.ApiClient.Serialize(request);


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling CreateAttachement: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling CreateAttachement: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<AttachmentResponse>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (AttachmentResponse) Configuration.ApiClient.Deserialize(response, typeof (AttachmentResponse)));
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