using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using DocumentDBRestApi.Models;

namespace DocumentDBRestApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class CollectionController : ApiController
    {

        /// <summary>
        ///     Create a new Collection
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
        ///     version is used when the header is not provided use
        ///     <c>2015-08-06</c>
        /// </param>
        /// <param name='id'>
        ///     Required.  is a user settable property. It is the unique name
        ///     that identifies the collection
        /// </param>
        public static Collection CreateCollection(IDocumentDbConnector operations, string ridDB,
            string authorization,
            string xMSDate, string xMSVersion, CustomBodyCollection id)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).CreateCollectionAsync(ridDB, authorization, xMSDate, xMSVersion,
                        id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Create a new Collection
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
        /////     version is used when the header is not provided use
        /////     <c>2015-08-06</c>
        ///// </param>
        ///// <param name='id'>
        /////     Required.  is a user settable property. It is the unique name
        /////     that identifies the collection
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<Collection> CreateCollectionAsync(IDocumentDbConnector operations, string ridDB,
        //    string authorization, string xMSDate, string xMSVersion, CustomBodyCollection id,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.CreateCollectionWithOperationResponseAsync(ridDB, authorization, xMSDate, xMSVersion, id,
        //                cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

        /// <summary>
        ///     Delete a Collection
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
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format.          -
        ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use
        ///     <c>2015-08-06</c>
        /// </param>
        public static object DeleteCollection(IDocumentDbConnector operations, string ridDB, string ridColl,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).DeleteCollectionAsync(ridDB, ridColl, authorization, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Delete a Collection
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
        /////     .
        ///// </param>
        ///// <param name='xMSDate'>
        /////     Required. The date of the request The date is expressed in
        /////     Coordinated Universal Time format.
        /////     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        ///// </param>
        ///// <param name='xMSVersion'>
        /////     Required. The version of DocumentDB REST service. The latest
        /////     version is used when the header is not provided use
        /////     <c>2015-08-06</c>
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<object> DeleteCollectionAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridColl, string authorization, string userAgent, string xMSDate, string xMSVersion,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.DeleteCollectionWithOperationResponseAsync(ridDB, ridColl, authorization, userAgent,
        //                xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

        /// <summary>
        ///     Get a Collection
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
        ///     <example>
        ///         Fri, 08 Apr
        ///         2015 03:52:31 GMT
        ///     </example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use
        ///     <c>2015-08-06</c>
        /// </param>
        public static Collection GetCollectionById(IDocumentDbConnector operations, string ridDB, string ridColl,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).GetCollectionByIdAsync(ridDB, ridColl, authorization, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Get a Collection
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
        /////     .
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
        /////     version is used when the header is not provided use
        /////     <c>2015-08-06</c>
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<Collection> GetCollectionByIdAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridColl, string authorization, string userAgent, string xMSDate, string xMSVersion,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.GetCollectionByIdWithOperationResponseAsync(ridDB, ridColl, authorization, userAgent,
        //                xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

        /// <summary>
        ///     List Collections
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
        ///         Fri, 08 Apr
        ///         2015 03:52:31 GMT
        ///     </example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use
        ///     <c>2015-08-06</c>
        /// </param>
        public static IList<Collection> ListCollections(IDocumentDbConnector operations, string ridDB,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).ListCollectionsAsync(ridDB, authorization, userAgent, xMSDate,
                        xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     List Collections
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
        /////         Fri, 08 Apr
        /////         2015 03:52:31 GMT
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
        //public static async Task<IList<Collection>> ListCollectionsAsync(IDocumentDbConnector operations,
        //    string ridDB, string authorization, string userAgent, string xMSDate, string xMSVersion,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.ListCollectionsWithOperationResponseAsync(ridDB, authorization, userAgent, xMSDate,
        //                xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

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
        ///     version is used when the header is not provided use
        ///     <c>2015-08-06</c>
        /// </param>
        /// <param name='contentType'>
        ///     Required. Must be set to application/query+json
        /// </param>
        /// <param name='xMSDocumentdbIsquery'>
        ///     Required. Required.  property must be set to true
        /// </param>
        /// <param name='xMSMaxItemCount'>
        ///     Required. To page through a result set, set  header to the
        ///     maximum number for items to be returned back in a single page.
        ///     <remarks>Range 1 - 1000 Default value = 100</remarks>
        /// </param>
        /// <param name='xMSContinuation'>
        ///     Required. To navigate to the next page of items, set  header to
        ///     the continuation token for the next page.
        /// </param>
        /// <param name='xMSDocumentdbQueryEnableScan'>
        ///     Required. Use an index scan to process the query if the right index
        ///     path of type is not available.
        /// </param>
        /// <param name='xMSSessionToken'>
        ///     Required. The session token for the request. Used for session
        ///     consistency
        /// </param>
        /// <param name='accept'>
        ///     Required. Optional. At the moment, DocumentDB always returns the
        ///     response payload in standard JSON format. The client must be able
        ///     to accept the response body in standard JSON format
        /// </param>
        public static QueryResourceResponseBody QueryCollectionResource(IDocumentDbConnector operations,
            string ridDB,
            string ridColl, QueryRequest request, string authorization, string userAgent, string xMSDate,
            string xMSVersion, string contentType, bool xMSDocumentdbIsquery, string xMSMaxItemCount,
            string xMSContinuation, bool? xMSDocumentdbQueryEnableScan, string xMSSessionToken, string accept)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).QueryCollectionResourceAsync(ridDB, ridColl, request,
                        authorization, userAgent, xMSDate, xMSVersion, contentType, xMSDocumentdbIsquery,
                        xMSMaxItemCount, xMSContinuation, xMSDocumentdbQueryEnableScan, xMSSessionToken, accept),
                    operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /////     version is used when the header is not provided use
        /////     <c>2015-08-06</c>
        ///// </param>
        ///// <param name='contentType'>
        /////     Required. Must be set to application/query+json
        ///// </param>
        ///// <param name='xMSDocumentdbIsquery'>
        /////     Required. Required.  property must be set to true
        ///// </param>
        ///// <param name='xMSMaxItemCount'>
        /////     Required. To page through a result set, set  header to the
        /////     maximum number for items to be returned back in a single page.
        /////     <remarks>Range 1 - 1000 Default value = 100</remarks>
        ///// </param>
        ///// <param name='xMSContinuation'>
        /////     Required. To navigate to the next page of items, set  header to
        /////     the continuation token for the next page.
        ///// </param>
        ///// <param name='xMSDocumentdbQueryEnableScan'>
        /////     Required. Use an index scan to process the query if the right index
        /////     path of type is not available.
        ///// </param>
        ///// <param name='xMSSessionToken'>
        /////     Required. The session token for the request. Used for session
        /////     consistency
        ///// </param>
        ///// <param name='accept'>
        /////     Required. Optional. At the moment, DocumentDB always returns the
        /////     response payload in standard JSON format. The client must be able
        /////     to accept the response body in standard JSON format
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<QueryResourceResponseBody> QueryCollectionResourceAsync(
        //     IDocumentDbConnector operations, string ridDB, string ridColl, QueryRequest request,
        //    string authorization,
        //    string userAgent, string xMSDate, string xMSVersion, string contentType, bool xMSDocumentdbIsquery,
        //    string xMSMaxItemCount, string xMSContinuation, bool? xMSDocumentdbQueryEnableScan, string xMSSessionToken,
        //    string accept, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.QueryCollectionResourceWithOperationResponseAsync(ridDB, ridColl, request, authorization,
        //                userAgent, xMSDate, xMSVersion, contentType, xMSDocumentdbIsquery, xMSMaxItemCount,
        //                xMSContinuation, xMSDocumentdbQueryEnableScan, xMSSessionToken, accept, cancellationToken)
        //                .ConfigureAwait(false);
        //    return result.Body;
        //}
    }
}
