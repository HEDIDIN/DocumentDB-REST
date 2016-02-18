using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using DocumentDBRestApi.Models;

namespace DocumentDBRestApi.Controllers
{
    /// <summary>
    /// Database Controller
    /// </summary>
    public class DatabaseController : ApiController
    {
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for  operation.
        ///     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        /// </param>
        /// <param name='contentType'>
        ///     Required. For creating a database, the Content-Type header must be
        ///     `<c>application/json</c>`.
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format.
        ///     <example>
        ///         Fri, 08 Apr 2015
        ///         03:52:31 GMT
        ///     </example>
        /// </param>
        /// <param name='id'>
        ///     Required.  is a user settable property. It is the unique name
        ///     that identifies the collection
        /// </param>
        public static Database CreateDatabase(IDocumentDbConnector operations, string authorization,
            string contentType, string xMSDate, CustomBodyCollection id)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).CreateDatabaseAsync(authorization, contentType, xMSDate, id),
                    operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='authorization'>
        /////     Required. The authentication type and signature token. Both master
        /////     key and resource tokens are allowed for  operation.
        /////     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        ///// </param>
        ///// <param name='contentType'>
        /////     Required. For creating a database, the Content-Type header must be
        /////     `<c>application/json</c>`.
        ///// </param>
        ///// <param name='xMSDate'>
        /////     Required. The date of the request The date is expressed in
        /////     Coordinated Universal Time format.
        /////     <example>
        /////         Fri, 08 Apr 2015
        /////         03:52:31 GMT
        /////     </example>
        ///// </param>
        ///// <param name='id'>
        /////     Required.  is a user settable property. It is the unique name
        /////     that identifies the collection
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<Database> CreateDatabaseAsync(IDocumentDbConnector operations,
        //    string authorization,
        //    string contentType, string xMSDate, CustomBodyCollection id,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.CreateDatabaseWithOperationResponseAsync(authorization, contentType, xMSDate, id,
        //                cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

        /// <summary>
        ///     Delete a Database
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
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
        ///     Optional. The string of client user agent performing the
        ///     request.
        ///     <c>{ user agentname}/{ version}</c>
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format.
        ///     <example>
        ///         Fri, 08 Apr 2015 03:52:31 GMT
        ///     </example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use
        ///     <c>2015-08-06</c>
        /// </param>
        public static object DeleteDatabase(IDocumentDbConnector operations, string ridDB, string authorization,
            string contentType, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).DeleteDatabaseAsync(ridDB, authorization, contentType, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Delete a Database
        ///// </summary>
        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='ridDB'>
        /////     Required. The Database Id
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
        /////     Coordinated Universal Time format.
        /////     <example>
        /////         Fri, 08 Apr 2015 03:52:31 GMT
        /////     </example>
        ///// </param>
        ///// <param name='xMSVersion'>
        /////     Required. The version of DocumentDB REST service. The latest
        /////     version is used when the header is not provided use
        /////     <c>2015-08-06</c>
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<object> DeleteDatabaseAsync(IDocumentDbConnector operations, string ridDB,
        //    string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.DeleteDatabaseWithOperationResponseAsync(ridDB, authorization, contentType, userAgent,
        //                xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

        /// <summary>
        ///     Retrieve a database resource by Id
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for  operation.
        ///     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        /// </param>
        /// <param name='contentType'>
        ///     Required. Optional. For creating a database, the Content-Type
        ///     header must be `application/json`.
        /// </param>
        /// <param name='userAgent'>
        ///     Required. Optional. The string of client user agent performing the
        ///     request. The recommended format is
        ///     <c>
        ///         {user agent
        ///         name}/{version}
        ///     </c>
        ///     .
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format.
        ///     <example>
        ///         Fri, 08 Apr 2015
        ///         03:52:31 GMT
        ///     </example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use
        ///     <c>2015-08-06</c>
        /// </param>
        /// <param name='xMSGatewayversion'>
        ///     Required.
        /// </param>
        public static Database GetDatabaseById(IDocumentDbConnector operations, string ridDB, string authorization,
            string contentType, string userAgent, string xMSDate, string xMSVersion, string xMSGatewayversion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).GetDatabaseByIdAsync(ridDB, authorization, contentType,
                        userAgent, xMSDate, xMSVersion, xMSGatewayversion), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Retrieve a database resource by Id
        ///// </summary>
        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='ridDB'>
        /////     Required. The Database Id
        ///// </param>
        ///// <param name='authorization'>
        /////     Required. The authentication type and signature token. Both master
        /////     key and resource tokens are allowed for  operation.
        /////     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        ///// </param>
        ///// <param name='contentType'>
        /////     Required. Optional. For creating a database, the Content-Type
        /////     header must be `application/json`.
        ///// </param>
        ///// <param name='userAgent'>
        /////     Required. Optional. The string of client user agent performing the
        /////     request. The recommended format is
        /////     <c>
        /////         {user agent
        /////         name}/{version}
        /////     </c>
        /////     .
        ///// </param>
        ///// <param name='xMSDate'>
        /////     Required. The date of the request The date is expressed in
        /////     Coordinated Universal Time format.
        /////     <example>
        /////         Fri, 08 Apr 2015
        /////         03:52:31 GMT
        /////     </example>
        ///// </param>
        ///// <param name='xMSVersion'>
        /////     Required. The version of DocumentDB REST service. The latest
        /////     version is used when the header is not provided use
        /////     <c>2015-08-06</c>
        ///// </param>
        ///// <param name='xMSGatewayversion'>
        /////     Required.
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<Database> GetDatabaseByIdAsync(IDocumentDbConnector operations, string ridDB,
        //    string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion,
        //    string xMSGatewayversion, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.GetDatabaseByIdWithOperationResponseAsync(ridDB, authorization, contentType, userAgent,
        //                xMSDate, xMSVersion, xMSGatewayversion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}


        /// <summary>
        ///     List Databases
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for  operation.
        ///     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        /// </param>
        /// <param name='userAgent'>
        ///     Required. Optional. The string of client user agent performing the
        ///     request. The recommended format is `
        ///     <c>
        ///         >{user agent
        ///         name}/{version}
        ///     </c>
        ///     `.
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format.  `Fri, 08 Apr 2015 03:52:31 GMT`
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use
        ///     <c>2015-08-06</c>
        /// </param>
        /// <param name='xMSGatewayversion'>
        ///     Required. The Microsft Date Gateway version
        /// </param>
        public static IList<DatabaseCollection> GetDatabaseList(IDocumentDbConnector operations,
            string authorization,
            string userAgent, string xMSDate, string xMSVersion, string xMSGatewayversion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).GetDatabaseListAsync(authorization, userAgent, xMSDate,
                        xMSVersion, xMSGatewayversion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     List Databases
        ///// </summary>
        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='authorization'>
        /////     Required. The authentication type and signature token. Both master
        /////     key and resource tokens are allowed for  operation.
        /////     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        ///// </param>
        ///// <param name='userAgent'>
        /////     Required. Optional. The string of client user agent performing the
        /////     request. The recommended format is `
        /////     <c>
        /////         >{user agent
        /////         name}/{version}
        /////     </c>
        /////     `.
        ///// </param>
        ///// <param name='xMSDate'>
        /////     Required. The date of the request The date is expressed in
        /////     Coordinated Universal Time format.  `Fri, 08 Apr 2015 03:52:31 GMT`
        ///// </param>
        ///// <param name='xMSVersion'>
        /////     Required. The version of DocumentDB REST service. The latest
        /////     version is used when the header is not provided use
        /////     <c>2015-08-06</c>
        ///// </param>
        ///// <param name='xMSGatewayversion'>
        /////     Required. The Microsft Date Gateway version
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<IList<DatabaseCollection>> GetDatabaseListAsync(IDocumentDbConnector operations,
        //    string authorization, string userAgent, string xMSDate, string xMSVersion, string xMSGatewayversion,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.GetDatabaseListWithOperationResponseAsync(authorization, userAgent, xMSDate, xMSVersion,
        //                xMSGatewayversion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}
    }
}
