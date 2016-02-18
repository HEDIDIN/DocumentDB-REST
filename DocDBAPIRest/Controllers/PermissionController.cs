using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DocDBAPIRest.Models;
using RestSharp;

namespace DocDBAPIRest.Controllers
{
    public class PermissionController : ApiController
    {
        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public interface IPermissionApi
        {
            /// <summary>
            ///     Query a Permission
            /// </summary>
            /// <remarks>
            ///     Query a Permission
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request">The Request Body</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example -
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <returns>QueryResponseBody</returns>
            QueryResponseBody QueryPermission(string ridDb, string ridUser, QueryRequest request, string authorization,
                string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string xMsDate,
                string xMsVersion);

            /// <summary>
            ///     Query a Permission
            /// </summary>
            /// <remarks>
            ///     Query a Permission
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request">The Request Body</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example -
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <returns>ApiResponse of QueryResponseBody</returns>
            ApiResponse<QueryResponseBody> QueryPermissionWithHttpInfo(string ridDb, string ridUser,
                QueryRequest request, string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan,
                bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion);

            /// <summary>
            ///     Query a Permission
            /// </summary>
            /// <remarks>
            ///     Query a Permission
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request">The Request Body</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example -
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <returns>Task of QueryResponseBody</returns>
            Task<QueryResponseBody> QueryPermissionAsync(string ridDb, string ridUser, QueryRequest request,
                string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery,
                string xMsDate, string xMsVersion);

            /// <summary>
            ///     Query a Permission
            /// </summary>
            /// <remarks>
            ///     Query a Permission
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request">The Request Body</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example -
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <returns>Task of ApiResponse (QueryResponseBody)</returns>
            Task<ApiResponse<QueryResponseBody>> QueryPermissionAsyncWithHttpInfo(string ridDb, string ridUser,
                QueryRequest request, string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan,
                bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion);

            /// <summary>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, f
            /// </summary>
            /// <remarks>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, for the particular permission. A new resource token is created every time a GET is invoked on the permission
            ///     resource. This new token has the default validity period of one hour, unless it is overridden.
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     {user agent name}/{version}.
            /// </param>
            /// <returns>Permission</returns>
            Permission GetPermission(string ridDb, string ridUser, string ridPerm, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, f
            /// </summary>
            /// <remarks>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, for the particular permission. A new resource token is created every time a GET is invoked on the permission
            ///     resource. This new token has the default validity period of one hour, unless it is overridden.
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     {user agent name}/{version}.
            /// </param>
            /// <returns>ApiResponse of Permission</returns>
            ApiResponse<Permission> GetPermissionWithHttpInfo(string ridDb, string ridUser, string ridPerm,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null);

            /// <summary>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, f
            /// </summary>
            /// <remarks>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, for the particular permission. A new resource token is created every time a GET is invoked on the permission
            ///     resource. This new token has the default validity period of one hour, unless it is overridden.
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     {user agent name}/{version}.
            /// </param>
            /// <returns>Task of Permission</returns>
            Task<Permission> GetPermissionAsync(string ridDb, string ridUser, string ridPerm, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, f
            /// </summary>
            /// <remarks>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, for the particular permission. A new resource token is created every time a GET is invoked on the permission
            ///     resource. This new token has the default validity period of one hour, unless it is overridden.
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     {user agent name}/{version}.
            /// </param>
            /// <returns>Task of ApiResponse (Permission)</returns>
            Task<ApiResponse<Permission>> GetPermissionAsyncWithHttpInfo(string ridDb, string ridUser, string ridPerm,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null);

            /// <summary>
            ///     Replaces the entire user Permission.
            /// </summary>
            /// <remarks>
            ///     Replaces the entire user Permission.
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example:
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <returns>Permission</returns>
            Permission ReplacePermission(string ridDb, string ridUser, string ridPerm, Permission request,
                string authorization, string userAgent, string xMsVersion, string xMsDate, string contentType = null);

            /// <summary>
            ///     Replaces the entire user Permission.
            /// </summary>
            /// <remarks>
            ///     Replaces the entire user Permission.
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example:
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <returns>ApiResponse of Permission</returns>
            ApiResponse<Permission> ReplacePermissionWithHttpInfo(string ridDb, string ridUser, string ridPerm,
                Permission request, string authorization, string userAgent, string xMsVersion, string xMsDate,
                string contentType = null);

            /// <summary>
            ///     Replaces the entire user Permission.
            /// </summary>
            /// <remarks>
            ///     Replaces the entire user Permission.
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example:
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <returns>Task of Permission</returns>
            Task<Permission> ReplacePermissionAsync(string ridDb, string ridUser, string ridPerm, Permission request,
                string authorization, string userAgent, string xMsVersion, string xMsDate, string contentType = null);

            /// <summary>
            ///     Replaces the entire user Permission.
            /// </summary>
            /// <remarks>
            ///     Replaces the entire user Permission.
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example:
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <returns>Task of ApiResponse (Permission)</returns>
            Task<ApiResponse<Permission>> ReplacePermissionAsyncWithHttpInfo(string ridDb, string ridUser,
                string ridPerm, Permission request, string authorization, string userAgent, string xMsVersion,
                string xMsDate, string contentType = null);

            /// <summary>
            ///     DELETE operation on that permission resource
            /// </summary>
            /// <remarks>
            ///     To delete a permission resource, perform a DELETE operation on that permission resource
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;
            /// </param>
            /// <returns></returns>
            void DeletePermission(string ridDb, string ridPerm, string ridUser, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     DELETE operation on that permission resource
            /// </summary>
            /// <remarks>
            ///     To delete a permission resource, perform a DELETE operation on that permission resource
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;
            /// </param>
            /// <returns>ApiResponse of Object(void)</returns>
            ApiResponse<object> DeletePermissionWithHttpInfo(string ridDb, string ridPerm, string ridUser,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null);

            /// <summary>
            ///     DELETE operation on that permission resource
            /// </summary>
            /// <remarks>
            ///     To delete a permission resource, perform a DELETE operation on that permission resource
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;
            /// </param>
            /// <returns>Task of void</returns>
            Task DeletePermissionAsync(string ridDb, string ridPerm, string ridUser, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     DELETE operation on that permission resource
            /// </summary>
            /// <remarks>
            ///     To delete a permission resource, perform a DELETE operation on that permission resource
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;
            /// </param>
            /// <returns>Task of ApiResponse</returns>
            Task<ApiResponse<object>> DeletePermissionAsyncWithHttpInfo(string ridDb, string ridPerm, string ridUser,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null);
        }

        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public class PermissionApi : IPermissionApi
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="PermissionApi" /> class.
            /// </summary>
            /// <returns></returns>
            public PermissionApi(string basePath)
            {
                Configuration = new Configuration(new ApiClient(basePath));
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="PermissionApi" /> class
            ///     using Configuration object
            /// </summary>
            /// <param name="configuration">An instance of Configuration</param>
            /// <returns></returns>
            public PermissionApi(Configuration configuration = null)
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
            ///     Query a Permission Query a Permission
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request">The Request Body</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example -
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <returns>QueryResponseBody</returns>
            public QueryResponseBody QueryPermission(string ridDb, string ridUser, QueryRequest request,
                string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery,
                string xMsDate, string xMsVersion)
            {
                var response = QueryPermissionWithHttpInfo(ridDb, ridUser, request, authorization, contentType,
                    xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, xMsDate, xMsVersion);
                return response.Data;
            }

            /// <summary>
            ///     Query a Permission Query a Permission
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request">The Request Body</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example -
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <returns>ApiResponse of QueryResponseBody</returns>
            public ApiResponse<QueryResponseBody> QueryPermissionWithHttpInfo(string ridDb, string ridUser,
                QueryRequest request, string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan,
                bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling QueryPermission");

                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling QueryPermission");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling QueryPermission");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling QueryPermission");

                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400, "Missing required parameter 'contentType' when calling QueryPermission");

                // verify the required parameter 'xMsDocumentdbQueryEnableScan' is set
                if (xMsDocumentdbQueryEnableScan == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbQueryEnableScan' when calling QueryPermission");

                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryPermission");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling QueryPermission");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling QueryPermission");


                var path = "/{rid-db}/users/{rid-user}/permissions";

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
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter


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
                    throw new ApiException(statusCode, "Error calling QueryPermission: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryPermission: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResponseBody) Configuration.ApiClient.Deserialize(response, typeof (QueryResponseBody)));
            }

            /// <summary>
            ///     Query a Permission Query a Permission
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request">The Request Body</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example -
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <returns>Task of QueryResponseBody</returns>
            public async Task<QueryResponseBody> QueryPermissionAsync(string ridDb, string ridUser, QueryRequest request,
                string authorization, string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery,
                string xMsDate, string xMsVersion)
            {
                var response =
                    await
                        QueryPermissionAsyncWithHttpInfo(ridDb, ridUser, request, authorization, contentType,
                            xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, xMsDate, xMsVersion);
                return response.Data;
            }

            /// <summary>
            ///     Query a Permission Query a Permission
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request">The Request Body</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example -
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <returns>Task of ApiResponse (QueryResponseBody)</returns>
            public async Task<ApiResponse<QueryResponseBody>> QueryPermissionAsyncWithHttpInfo(string ridDb,
                string ridUser, QueryRequest request, string authorization, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string xMsDate, string xMsVersion)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling QueryPermission");
                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling QueryPermission");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling QueryPermission");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling QueryPermission");
                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400, "Missing required parameter 'contentType' when calling QueryPermission");
                // verify the required parameter 'xMsDocumentdbQueryEnableScan' is set
                if (xMsDocumentdbQueryEnableScan == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbQueryEnableScan' when calling QueryPermission");
                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryPermission");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling QueryPermission");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling QueryPermission");


                var path = "/{rid-db}/users/{rid-user}/permissions";

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
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter


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
                    throw new ApiException(statusCode, "Error calling QueryPermission: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryPermission: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResponseBody) Configuration.ApiClient.Deserialize(response, typeof (QueryResponseBody)));
            }

            /// <summary>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, f Performing a GET operation on a specific permission resource retrieves the permission properties,
            ///     including the token, for the particular permission. A new resource token is created every time a GET is invoked on
            ///     the permission resource. This new token has the default validity period of one hour, unless it is overridden.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     {user agent name}/{version}.
            /// </param>
            /// <returns>Permission</returns>
            public Permission GetPermission(string ridDb, string ridUser, string ridPerm, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response = GetPermissionWithHttpInfo(ridDb, ridUser, ridPerm, authorization, xMsDate, xMsVersion,
                    contentType, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, f Performing a GET operation on a specific permission resource retrieves the permission properties,
            ///     including the token, for the particular permission. A new resource token is created every time a GET is invoked on
            ///     the permission resource. This new token has the default validity period of one hour, unless it is overridden.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     {user agent name}/{version}.
            /// </param>
            /// <returns>ApiResponse of Permission</returns>
            public ApiResponse<Permission> GetPermissionWithHttpInfo(string ridDb, string ridUser, string ridPerm,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetPermission");

                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling GetPermission");

                // verify the required parameter 'ridPerm' is set
                if (ridPerm == null)
                    throw new ApiException(400, "Missing required parameter 'ridPerm' when calling GetPermission");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetPermission");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetPermission");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetPermission");


                var path = "/{rid-db}/users/{rid-user}/permissions/{rid-perm}";

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
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter
                if (ridPerm != null)
                    pathParams.Add("rid-perm", Configuration.ApiClient.ParameterToString(ridPerm)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
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
                    throw new ApiException(statusCode, "Error calling GetPermission: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetPermission: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Permission>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Permission) Configuration.ApiClient.Deserialize(response, typeof (Permission)));
            }

            /// <summary>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, f Performing a GET operation on a specific permission resource retrieves the permission properties,
            ///     including the token, for the particular permission. A new resource token is created every time a GET is invoked on
            ///     the permission resource. This new token has the default validity period of one hour, unless it is overridden.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     {user agent name}/{version}.
            /// </param>
            /// <returns>Task of Permission</returns>
            public async Task<Permission> GetPermissionAsync(string ridDb, string ridUser, string ridPerm,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                var response =
                    await
                        GetPermissionAsyncWithHttpInfo(ridDb, ridUser, ridPerm, authorization, xMsDate, xMsVersion,
                            contentType, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Performing a GET operation on a specific permission resource retrieves the permission properties, including the
            ///     token, f Performing a GET operation on a specific permission resource retrieves the permission properties,
            ///     including the token, for the particular permission. A new resource token is created every time a GET is invoked on
            ///     the permission resource. This new token has the default validity period of one hour, unless it is overridden.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     {user agent name}/{version}.
            /// </param>
            /// <returns>Task of ApiResponse (Permission)</returns>
            public async Task<ApiResponse<Permission>> GetPermissionAsyncWithHttpInfo(string ridDb, string ridUser,
                string ridPerm, string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetPermission");
                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling GetPermission");
                // verify the required parameter 'ridPerm' is set
                if (ridPerm == null)
                    throw new ApiException(400, "Missing required parameter 'ridPerm' when calling GetPermission");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetPermission");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetPermission");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetPermission");


                var path = "/{rid-db}/users/{rid-user}/permissions/{rid-perm}";

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
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter
                if (ridPerm != null)
                    pathParams.Add("rid-perm", Configuration.ApiClient.ParameterToString(ridPerm)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
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
                    throw new ApiException(statusCode, "Error calling GetPermission: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetPermission: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Permission>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Permission) Configuration.ApiClient.Deserialize(response, typeof (Permission)));
            }

            /// <summary>
            ///     Replaces the entire user Permission. Replaces the entire user Permission.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example:
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <returns>Permission</returns>
            public Permission ReplacePermission(string ridDb, string ridUser, string ridPerm, Permission request,
                string authorization, string userAgent, string xMsVersion, string xMsDate, string contentType = null)
            {
                var response = ReplacePermissionWithHttpInfo(ridDb, ridUser, ridPerm, request, authorization, userAgent,
                    xMsVersion, xMsDate, contentType);
                return response.Data;
            }

            /// <summary>
            ///     Replaces the entire user Permission. Replaces the entire user Permission.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example:
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <returns>ApiResponse of Permission</returns>
            public ApiResponse<Permission> ReplacePermissionWithHttpInfo(string ridDb, string ridUser, string ridPerm,
                Permission request, string authorization, string userAgent, string xMsVersion, string xMsDate,
                string contentType = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ReplacePermission");

                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling ReplacePermission");

                // verify the required parameter 'ridPerm' is set
                if (ridPerm == null)
                    throw new ApiException(400, "Missing required parameter 'ridPerm' when calling ReplacePermission");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling ReplacePermission");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling ReplacePermission");

                // verify the required parameter 'userAgent' is set
                if (userAgent == null)
                    throw new ApiException(400, "Missing required parameter 'userAgent' when calling ReplacePermission");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ReplacePermission");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ReplacePermission");


                var path = "/{rid-db}/users/{rid-user}/permissions/{rid-perm}";

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
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter
                if (ridPerm != null)
                    pathParams.Add("rid-perm", Configuration.ApiClient.ParameterToString(ridPerm)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling ReplacePermission: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ReplacePermission: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Permission>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Permission) Configuration.ApiClient.Deserialize(response, typeof (Permission)));
            }

            /// <summary>
            ///     Replaces the entire user Permission. Replaces the entire user Permission.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example:
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <returns>Task of Permission</returns>
            public async Task<Permission> ReplacePermissionAsync(string ridDb, string ridUser, string ridPerm,
                Permission request, string authorization, string userAgent, string xMsVersion, string xMsDate,
                string contentType = null)
            {
                var response =
                    await
                        ReplacePermissionAsyncWithHttpInfo(ridDb, ridUser, ridPerm, request, authorization, userAgent,
                            xMsVersion, xMsDate, contentType);
                return response.Data;
            }

            /// <summary>
            ///     Replaces the entire user Permission. Replaces the entire user Permission.
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="userAgent">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example:
            ///    
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example- &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <returns>Task of ApiResponse (Permission)</returns>
            public async Task<ApiResponse<Permission>> ReplacePermissionAsyncWithHttpInfo(string ridDb, string ridUser,
                string ridPerm, Permission request, string authorization, string userAgent, string xMsVersion,
                string xMsDate, string contentType = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ReplacePermission");
                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling ReplacePermission");
                // verify the required parameter 'ridPerm' is set
                if (ridPerm == null)
                    throw new ApiException(400, "Missing required parameter 'ridPerm' when calling ReplacePermission");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling ReplacePermission");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling ReplacePermission");
                // verify the required parameter 'userAgent' is set
                if (userAgent == null)
                    throw new ApiException(400, "Missing required parameter 'userAgent' when calling ReplacePermission");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ReplacePermission");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ReplacePermission");


                var path = "/{rid-db}/users/{rid-user}/permissions/{rid-perm}";

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
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter
                if (ridPerm != null)
                    pathParams.Add("rid-perm", Configuration.ApiClient.ParameterToString(ridPerm)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
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
                    throw new ApiException(statusCode, "Error calling ReplacePermission: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ReplacePermission: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Permission>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Permission) Configuration.ApiClient.Deserialize(response, typeof (Permission)));
            }

            /// <summary>
            ///     DELETE operation on that permission resource To delete a permission resource, perform a DELETE operation on that
            ///     permission resource
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;
            /// </param>
            /// <returns></returns>
            public void DeletePermission(string ridDb, string ridPerm, string ridUser, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                DeletePermissionWithHttpInfo(ridDb, ridPerm, ridUser, authorization, xMsDate, xMsVersion, contentType,
                    userAgent);
            }

            /// <summary>
            ///     DELETE operation on that permission resource To delete a permission resource, perform a DELETE operation on that
            ///     permission resource
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;
            /// </param>
            /// <returns>ApiResponse of Object(void)</returns>
            public ApiResponse<object> DeletePermissionWithHttpInfo(string ridDb, string ridPerm, string ridUser,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling DeletePermission");

                // verify the required parameter 'ridPerm' is set
                if (ridPerm == null)
                    throw new ApiException(400, "Missing required parameter 'ridPerm' when calling DeletePermission");

                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling DeletePermission");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling DeletePermission");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling DeletePermission");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling DeletePermission");


                var path = "/{rid-db}/users/{rid-user}/permissions/{rid-perm}";

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
                if (ridPerm != null)
                    pathParams.Add("rid-perm", Configuration.ApiClient.ParameterToString(ridPerm)); // path parameter
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
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
                    throw new ApiException(statusCode, "Error calling DeletePermission: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling DeletePermission: " + response.ErrorMessage,
                        response.ErrorMessage);


                return new ApiResponse<object>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    null);
            }

            /// <summary>
            ///     DELETE operation on that permission resource To delete a permission resource, perform a DELETE operation on that
            ///     permission resource
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;
            /// </param>
            /// <returns>Task of void</returns>
            public async Task DeletePermissionAsync(string ridDb, string ridPerm, string ridUser, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                await
                    DeletePermissionAsyncWithHttpInfo(ridDb, ridPerm, ridUser, authorization, xMsDate, xMsVersion,
                        contentType, userAgent);
            }

            /// <summary>
            ///     DELETE operation on that permission resource To delete a permission resource, perform a DELETE operation on that
            ///     permission resource
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
            /// <param name="ridPerm">The Permission Id</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;
            /// </param>
            /// <returns>Task of ApiResponse</returns>
            public async Task<ApiResponse<object>> DeletePermissionAsyncWithHttpInfo(string ridDb, string ridPerm,
                string ridUser, string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling DeletePermission");
                // verify the required parameter 'ridPerm' is set
                if (ridPerm == null)
                    throw new ApiException(400, "Missing required parameter 'ridPerm' when calling DeletePermission");
                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling DeletePermission");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling DeletePermission");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling DeletePermission");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling DeletePermission");


                var path = "/{rid-db}/users/{rid-user}/permissions/{rid-perm}";

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
                if (ridPerm != null)
                    pathParams.Add("rid-perm", Configuration.ApiClient.ParameterToString(ridPerm)); // path parameter
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
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
                    throw new ApiException(statusCode, "Error calling DeletePermission: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling DeletePermission: " + response.ErrorMessage,
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