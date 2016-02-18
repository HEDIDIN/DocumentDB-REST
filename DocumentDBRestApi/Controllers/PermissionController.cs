using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using DocumentDBRestApi.Models;

namespace DocumentDBRestApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class PermissionController : ApiController
    {

        /// <summary>
        ///     To delete a permission resource, perform a DELETE operation on that
        ///     permission resource
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
        /// </param>
        /// <param name='ridPerm'>
        ///     Required. The Permission Id
        /// </param>
        /// <param name='ridUser'>
        ///     Required. The User Id
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for  operation.
        ///     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        /// </param>
        /// <param name='contentType'>
        ///     Required. Optional. For creating a database, the Content-Type
        ///     header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        ///     Required. Optional. The string of client user agent performing the
        ///     request. The recommended format is
        ///     <c>{ user agentname}/{ version}</c>
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format. example:
        ///     <example>
        ///         Fri, 08 Apr
        ///         2015 03:52:31 GMT
        ///     </example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        public static object DeletePermission(IDocumentDbConnector operations, string ridDB, string ridPerm,
            string ridUser, string authorization, string contentType, string userAgent, string xMSDate,
            string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).DeletePermissionAsync(ridDB, ridPerm, ridUser, authorization,
                        contentType, userAgent, xMSDate, xMSVersion), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     To delete a permission resource, perform a DELETE operation on that
        /////     permission resource
        ///// </summary>
        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='ridDB'>
        /////     Required. The Database Id
        ///// </param>
        ///// <param name='ridPerm'>
        /////     Required. The Permission Id
        ///// </param>
        ///// <param name='ridUser'>
        /////     Required. The User Id
        ///// </param>
        ///// <param name='authorization'>
        /////     Required. The authentication type and signature token. Both master
        /////     key and resource tokens are allowed for  operation.
        /////     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        ///// </param>
        ///// <param name='contentType'>
        /////     Required. Optional. For creating a database, the Content-Type
        /////     header must be application/json.
        ///// </param>
        ///// <param name='userAgent'>
        /////     Required. Optional. The string of client user agent performing the
        /////     request. The recommended format is
        /////     <c>{ user agentname}/{ version}</c>
        ///// </param>
        ///// <param name='xMSDate'>
        /////     Required. The date of the request The date is expressed in
        /////     Coordinated Universal Time format. example:
        /////     <example>
        /////         Fri, 08 Apr
        /////         2015 03:52:31 GMT
        /////     </example>
        ///// </param>
        ///// <param name='xMSVersion'>
        /////     Required. The version of DocumentDB REST service. The latest
        /////     version is used when the header is not provided use 2015-08-06
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<object> DeletePermissionAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridPerm, string ridUser, string authorization, string contentType, string userAgent, string xMSDate,
        //    string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.DeletePermissionWithOperationResponseAsync(ridDB, ridPerm, ridUser, authorization,
        //                contentType, userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}


        /// <summary>
        ///     Performing a GET operation on a specific permission resource
        ///     retrieves the permission properties, including the token, for the
        ///     particular permission. A new resource token is created every time
        ///     a GET is invoked on the permission resource.  new token has
        ///     the default validity period of one hour, unless it is overridden.
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        ///     Required. The User Id
        /// </param>
        /// <param name='ridPerm'>
        ///     Required. The Permission Id
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for  operation. example:
        ///     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        /// </param>
        /// <param name='contentType'>
        ///     Required. Optional. For creating a database, the Content-Type
        ///     header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        ///     Required. Optional. The string of client user agent performing the
        ///     request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format. example-
        ///     <example>
        ///         Fri, 08 Apr
        ///         2015 03:52:31 GMT
        ///     </example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        public static Permission GetPermission(IDocumentDbConnector operations, string ridDB, string ridUser,
            string ridPerm, string authorization, string contentType, string userAgent, string xMSDate,
            string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).GetPermissionAsync(ridDB, ridUser, ridPerm, authorization,
                        contentType, userAgent, xMSDate, xMSVersion), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Performing a GET operation on a specific permission resource
        /////     retrieves the permission properties, including the token, for the
        /////     particular permission. A new resource token is created every time
        /////     a GET is invoked on the permission resource.  new token has
        /////     the default validity period of one hour, unless it is overridden.
        ///// </summary>
        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='ridDB'>
        /////     Required. The Database Id
        ///// </param>
        ///// <param name='ridUser'>
        /////     Required. The User Id
        ///// </param>
        ///// <param name='ridPerm'>
        /////     Required. The Permission Id
        ///// </param>
        ///// <param name='authorization'>
        /////     Required. The authentication type and signature token. Both master
        /////     key and resource tokens are allowed for  operation. example:
        /////     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        ///// </param>
        ///// <param name='contentType'>
        /////     Required. Optional. For creating a database, the Content-Type
        /////     header must be application/json.
        ///// </param>
        ///// <param name='userAgent'>
        /////     Required. Optional. The string of client user agent performing the
        /////     request. The recommended format is {user agent name}/{version}.
        ///// </param>
        ///// <param name='xMSDate'>
        /////     Required. The date of the request The date is expressed in
        /////     Coordinated Universal Time format. example-
        /////     <example>
        /////         Fri, 08 Apr
        /////         2015 03:52:31 GMT
        /////     </example>
        ///// </param>
        ///// <param name='xMSVersion'>
        /////     Required. The version of DocumentDB REST service. The latest
        /////     version is used when the header is not provided use 2015-08-06
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<Permission> GetPermissionAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridUser, string ridPerm, string authorization, string contentType, string userAgent, string xMSDate,
        //    string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.GetPermissionWithOperationResponseAsync(ridDB, ridUser, ridPerm, authorization,
        //                contentType, userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

        /// <summary>
        ///     Query a Permission
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        ///     Required. The User Id
        /// </param>
        /// <param name='request'>
        ///     Required. The Request Body
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for  operation.
        ///     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        /// </param>
        /// <param name='contentType'>
        ///     Required. Required. The Content-Type header must be
        ///     application/json.
        /// </param>
        /// <param name='xMSDocumentdbQueryEnableScan'>
        ///     Required.
        /// </param>
        /// <param name='xMSDocumentdbIsquery'>
        ///     Required.
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format. 
        ///     <example>
        ///         Fri, 08 Apr
        ///         2015 03:52:31 GMT
        ///     </example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        public static QueryResponseBody QueryPermission(IDocumentDbConnector operations, string ridDB,
            string ridUser,
            QueryRequest request, string authorization, string contentType, bool xMSDocumentdbQueryEnableScan,
            bool xMSDocumentdbIsquery, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).QueryPermissionAsync(ridDB, ridUser, request, authorization,
                        contentType, xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, xMSDate, xMSVersion),
                    operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Query a Permission
        ///// </summary>
        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='ridDB'>
        /////     Required. The Database Id
        ///// </param>
        ///// <param name='ridUser'>
        /////     Required. The User Id
        ///// </param>
        ///// <param name='request'>
        /////     Required. The Request Body
        ///// </param>
        ///// <param name='authorization'>
        /////     Required. The authentication type and signature token. Both master
        /////     key and resource tokens are allowed for  operation.
        /////     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        ///// </param>
        ///// <param name='contentType'>
        /////     Required. Required. The Content-Type header must be
        /////     application/json.
        ///// </param>
        ///// <param name='xMSDocumentdbQueryEnableScan'>
        /////     Required.
        ///// </param>
        ///// <param name='xMSDocumentdbIsquery'>
        /////     Required.
        ///// </param>
        ///// <param name='xMSDate'>
        /////     Required. The date of the request The date is expressed in
        /////     Coordinated Universal Time format. 
        /////     <example>
        /////         Fri, 08 Apr
        /////         2015 03:52:31 GMT
        /////     </example>
        ///// </param>
        ///// <param name='xMSVersion'>
        /////     Required. The version of DocumentDB REST service. The latest
        /////     version is used when the header is not provided use 2015-08-06
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<QueryResponseBody> QueryPermissionAsync(IDocumentDbConnector operations,
        //    string ridDB, string ridUser, QueryRequest request, string authorization, string contentType,
        //    bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery, string xMSDate, string xMSVersion,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.QueryPermissionWithOperationResponseAsync(ridDB, ridUser, request, authorization,
        //                contentType, xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, xMSDate, xMSVersion,
        //                cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

        /// <summary>
        ///     Replaces the entire user Permission.
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        ///     Required. The User Id
        /// </param>
        /// <param name='ridPerm'>
        ///     Required. The Permission Id
        /// </param>
        /// <param name='request'>
        ///     Required.
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for  operation.
        ///     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        /// </param>
        /// <param name='contentType'>
        ///     Required. Optional. For creating a database, the Content-Type
        ///     header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format. example:
        ///     <example>
        ///         Fri, 08 Apr
        ///         2015 03:52:31 GMT
        ///     </example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format. example-
        ///     <example>
        ///         Fri, 08 Apr
        ///         2015 03:52:31 GMT
        ///     </example>
        /// </param>
        public static Permission ReplacePermission(IDocumentDbConnector operations, string ridDB, string ridUser,
            string ridPerm, Permission request, string authorization, string contentType, string userAgent,
            string xMSVersion, string xMSDate)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).ReplacePermissionAsync(ridDB, ridUser, ridPerm, request,
                        authorization, contentType, userAgent, xMSVersion, xMSDate), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Replaces the entire user Permission.
        ///// </summary>
        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='ridDB'>
        /////     Required. The Database Id
        ///// </param>
        ///// <param name='ridUser'>
        /////     Required. The User Id
        ///// </param>
        ///// <param name='ridPerm'>
        /////     Required. The Permission Id
        ///// </param>
        ///// <param name='request'>
        /////     Required.
        ///// </param>
        ///// <param name='authorization'>
        /////     Required. The authentication type and signature token. Both master
        /////     key and resource tokens are allowed for  operation.
        /////     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        ///// </param>
        ///// <param name='contentType'>
        /////     Required. Optional. For creating a database, the Content-Type
        /////     header must be application/json.
        ///// </param>
        ///// <param name='userAgent'>
        /////     Required. The date of the request The date is expressed in
        /////     Coordinated Universal Time format. example:
        /////     <example>
        /////         Fri, 08 Apr
        /////         2015 03:52:31 GMT
        /////     </example>
        ///// </param>
        ///// <param name='xMSVersion'>
        /////     Required. The version of DocumentDB REST service. The latest
        /////     version is used when the header is not provided use 2015-08-06
        ///// </param>
        ///// <param name='xMSDate'>
        /////     Required. The date of the request The date is expressed in
        /////     Coordinated Universal Time format. example-
        /////     <example>
        /////         Fri, 08 Apr
        /////         2015 03:52:31 GMT
        /////     </example>
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<Permission> ReplacePermissionAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridUser, string ridPerm, Permission request, string authorization, string contentType,
        //    string userAgent, string xMSVersion, string xMSDate,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.ReplacePermissionWithOperationResponseAsync(ridDB, ridUser, ridPerm, request,
        //                authorization, contentType, userAgent, xMSVersion, xMSDate, cancellationToken)
        //                .ConfigureAwait(false);
        //    return result.Body;
        //}
    }
}
