using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using DocumentDBRestApi.Models;

namespace DocumentDBRestApi.Controllers
{
    /// <summary>
    /// </summary>
    public class OfferController : ApiController
    {
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='databaseaccount'>
        ///     Required. The Database Account Name
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
        ///     request.
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
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        public static IList<Offer> GetListOfOffers(IDocumentDbConnector operations, string databaseaccount,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).GetListOfOffersAsync(databaseaccount, authorization, contentType,
                        userAgent, xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='databaseaccount'>
        /////     Required. The Database Account Name
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
        /////     request.
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
        /////     version is used when the header is not provided use 2015-08-06
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<IList<Offer>> GetListOfOffersAsync(IDocumentDbConnector operations,
        //    string databaseaccount, string authorization, string contentType, string userAgent, string xMSDate,
        //    string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.GetListOfOffersWithOperationResponseAsync(databaseaccount, authorization, contentType,
        //                userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}


        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridOffer'>
        ///     Required. The Offer Id
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
        public static Offer GetOffer(IDocumentDbConnector operations, string ridOffer, string authorization,
            string contentType, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).GetOfferAsync(ridOffer, authorization, contentType, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='ridOffer'>
        /////     Required. The Offer Id
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
        //public static async Task<Offer> GetOfferAsync(IDocumentDbConnector operations, string ridOffer,
        //    string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.GetOfferWithOperationResponseAsync(ridOffer, authorization, contentType, userAgent,
        //                xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}


        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='databaseaccount'>
        ///     Required. The Database Account Name
        /// </param>
        /// <param name='request'>
        ///     Required.
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for  operation. example:
        ///     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
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
        public static QueryResponseBody QueryOffer(IDocumentDbConnector operations, string databaseaccount,
            QuerySql request, string authorization, string userAgent, string xMSDate, string xMSVersion,
            string contentType, bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).QueryOfferAsync(databaseaccount, request, authorization,
                        userAgent, xMSDate, xMSVersion, contentType, xMSDocumentdbQueryEnableScan,
                        xMSDocumentdbIsquery), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='databaseaccount'>
        /////     Required. The Database Account Name
        ///// </param>
        ///// <param name='request'>
        /////     Required.
        ///// </param>
        ///// <param name='authorization'>
        /////     Required. The authentication type and signature token. Both master
        /////     key and resource tokens are allowed for  operation. example:
        /////     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
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
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<QueryResponseBody> QueryOfferAsync(IDocumentDbConnector operations,
        //    string databaseaccount, QuerySql request, string authorization, string userAgent, string xMSDate,
        //    string xMSVersion, string contentType, bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.QueryOfferWithOperationResponseAsync(databaseaccount, request, authorization, userAgent,
        //                xMSDate, xMSVersion, contentType, xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery,
        //                cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}


        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridOffer'>
        ///     Required. The Offer Id
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
        public static Offer ReplaceOffer(IDocumentDbConnector operations, string ridOffer, ReplaceOffer request,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).ReplaceOfferAsync(ridOffer, request, authorization, contentType,
                        userAgent, xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <param name='operations'>
        /////     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        ///// </param>
        ///// <param name='ridOffer'>
        /////     Required. The Offer Id
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
        /////     Required. Optional. The string of client user agent performing the
        /////     request. The recommended format is
        /////     <c>{ user agentname}/{ version}</c>.
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
        //public static async Task<Offer> ReplaceOfferAsync(IDocumentDbConnector operations, string ridOffer,
        //    ReplaceOffer request, string authorization, string contentType, string userAgent, string xMSDate,
        //    string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.ReplaceOfferWithOperationResponseAsync(ridOffer, request, authorization, contentType,
        //                userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}
    }
}