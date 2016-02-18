using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using DocumentDBRestApi.Models;

namespace DocumentDBRestApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class TriggerController : ApiController
    {
        /// <summary>
        ///     Query a Trigger
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
        ///     <c>{ user agentname}/{ version}</c>.
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format.       
        ///     <example>
        ///         Fri,
        ///         08 Apr 2015 03:52:31 GMT
        ///     </example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        public static QueryResponseBody QueryTrigger(IDocumentDbConnector operations, string ridDB, string ridColl,
            string contentType, bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery, QueryRequest request,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).QueryTriggerAsync(ridDB, ridColl, contentType,
                        xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, request, authorization, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Query a Trigger
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
        /////     <c>{ user agentname}/{ version}</c>
        ///// </param>
        ///// <param name='xMSDate'>
        /////     Required. The date of the request The date is expressed in
        /////     Coordinated Universal Time format.
        /////     <example>
        /////         Fri,
        /////         08 Apr 2015 03:52:31 GMT
        /////     </example>
        ///// </param>
        ///// <param name='xMSVersion'>
        /////     Required. The version of DocumentDB REST service. The latest
        /////     version is used when the header is not provided use 2015-08-06
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<QueryResponseBody> QueryTriggerAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridColl, string contentType, bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery,
        //    QueryRequest request, string authorization, string userAgent, string xMSDate, string xMSVersion,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.QueryTriggerWithOperationResponseAsync(ridDB, ridColl, contentType,
        //                xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, request, authorization, userAgent, xMSDate,
        //                xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

    }
}
