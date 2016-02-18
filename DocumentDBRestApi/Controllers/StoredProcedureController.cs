using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using DocumentDBRestApi.Models;

namespace DocumentDBRestApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class StoredProcedureController : ApiController
    {

        /// <summary>
        ///     Execute a Stored Procedure
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        ///     Required. The Collection Id
        /// </param>
        /// <param name='ridProc'>
        ///     Required. The Procedure Id
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
        ///     Required. Required. The Content-Type header must be
        ///     application/json.
        /// </param>
        /// <param name='xMSDocumentdbQueryEnableScan'>
        ///     Required.
        /// </param>
        /// <param name='xMSDocumentdbIsquery'>
        ///     Required.
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
        ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        public static QueryResponseBody ExecuteStoredProcedure(IDocumentDbConnector operations, string ridDB,
            string ridColl, string ridProc, QueryRequest request, string authorization, string contentType,
            bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery, string userAgent, string xMSDate,
            string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).ExecuteStoredProcedureAsync(ridDB, ridColl, ridProc, request,
                        authorization, contentType, xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Execute a Stored Procedure
        ///// </summary>
        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='ridDB'>
        /////     Required. The Database Id
        ///// </param>
        ///// <param name='ridColl'>
        /////     Required. The Collection Id
        ///// </param>
        ///// <param name='ridProc'>
        /////     Required. The Procedure Id
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
        /////     Required. Required. The Content-Type header must be
        /////     application/json.
        ///// </param>
        ///// <param name='xMSDocumentdbQueryEnableScan'>
        /////     Required.
        ///// </param>
        ///// <param name='xMSDocumentdbIsquery'>
        /////     Required.
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
        /////     Coordinated Universal Time format.           :
        /////     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        ///// </param>
        ///// <param name='xMSVersion'>
        /////     Required. The version of DocumentDB REST service. The latest
        /////     version is used when the header is not provided use 2015-08-06
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<QueryResponseBody> ExecuteStoredProcedureAsync(IDocumentDbConnector operations,
        //    string ridDB, string ridColl, string ridProc, QueryRequest request, string authorization, string contentType,
        //    bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery, string userAgent, string xMSDate,
        //    string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.ExecuteStoredProcedureWithOperationResponseAsync(ridDB, ridColl, ridProc, request,
        //                authorization, contentType, xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, userAgent,
        //                xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

        /// <summary>
        ///     Register a Stored Procedure
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        ///     Required. The Collection Id
        /// </param>
        /// <param name='request'>
        ///     Required.
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for  operation.
        ///     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
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
        ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        public static StoredProcedure RegisterStoredProcedure(IDocumentDbConnector operations, string ridDB,
            string ridColl, QueryRequest request, string authorization, string userAgent, string xMSDate,
            string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).RegisterStoredProcedureAsync(ridDB, ridColl, request,
                        authorization, userAgent, xMSDate, xMSVersion), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Register a Stored Procedure
        ///// </summary>
        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='ridDB'>
        /////     Required. The Database Id
        ///// </param>
        ///// <param name='ridColl'>
        /////     Required. The Collection Id
        ///// </param>
        ///// <param name='request'>
        /////     Required.
        ///// </param>
        ///// <param name='authorization'>
        /////     Required. The authentication type and signature token. Both master
        /////     key and resource tokens are allowed for  operation.
        /////     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        ///// </param>
        ///// <param name='userAgent'>
        /////     Required. Optional. The string of client user agent performing the
        /////     request. The recommended format is
        /////     <c>
        /////         {user agent
        /////         name}/{version}
        /////     </c>
        ///// </param>
        ///// <param name='xMSDate'>
        /////     Required. The date of the request The date is expressed in
        /////     Coordinated Universal Time format.          
        /////     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        ///// </param>
        ///// <param name='xMSVersion'>
        /////     Required. The version of DocumentDB REST service. The latest
        /////     version is used when the header is not provided use 2015-08-06
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<StoredProcedure> RegisterStoredProcedureAsync(IDocumentDbConnector operations,
        //    string ridDB, string ridColl, QueryRequest request, string authorization, string userAgent, string xMSDate,
        //    string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.RegisterStoredProcedureWithOperationResponseAsync(ridDB, ridColl, request, authorization,
        //                userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

    }
}
