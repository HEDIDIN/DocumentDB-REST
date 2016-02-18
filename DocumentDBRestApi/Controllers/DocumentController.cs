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
    public class DocumentController : ApiController
    {

        /// <summary>
        ///     Create a new Document
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
        public static Document CreateDocument(IDocumentDbConnector operations, string ridDB, string ridColl,
            CustomBody request, string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).CreateDocumentAsync(ridDB, ridColl, request, authorization,
                        userAgent, xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Create a new Document
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
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<Document> CreateDocumentAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridColl, CustomBody request, string authorization, string userAgent, string xMSDate,
        //    string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.CreateDocumentWithOperationResponseAsync(ridDB, ridColl, request, authorization,
        //                userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}


        /// <summary>
        ///     Delete a Document
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
        /// <param name='ridDoc'>
        ///     Required. The Document Id
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for 
        ///     operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
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
        public static object DeleteDocument(IDocumentDbConnector operations, string ridDB, string ridColl,
            string ridDoc, string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).DeleteDocumentAsync(ridDB, ridColl, ridDoc, authorization,
                        userAgent, xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Delete a Document
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
        ///// <param name='ridDoc'>
        /////     Required. The Document Id
        ///// </param>
        ///// <param name='authorization'>
        /////     Required. The authentication type and signature token. Both master
        /////     key and resource tokens are allowed for 
        /////     operation.<c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
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
        //public static async Task<object> DeleteDocumentAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridColl, string ridDoc, string authorization, string userAgent, string xMSDate, string xMSVersion,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.DeleteDocumentWithOperationResponseAsync(ridDB, ridColl, ridDoc, authorization, userAgent,
        //                xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

        /// <summary>
        ///     Get a Document.
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
        /// <param name='ridDoc'>
        ///     Required. The Document Id
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for  operation.
        ///     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        /// </param>
        /// <param name='userAgent'>
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
        public static Document GetDocumentById(IDocumentDbConnector operations, string ridDB, string ridColl,
            string ridDoc, string authorization, string userAgent, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).GetDocumentByIdAsync(ridDB, ridColl, ridDoc, authorization,
                        userAgent, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Get a Document.
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
        ///// <param name='ridDoc'>
        /////     Required. The Document Id
        ///// </param>
        ///// <param name='authorization'>
        /////     Required. The authentication type and signature token. Both master
        /////     key and resource tokens are allowed for  operation.
        /////     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        ///// </param>
        ///// <param name='userAgent'>
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
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<Document> GetDocumentByIdAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridColl, string ridDoc, string authorization, string userAgent, string xMSVersion,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.GetDocumentByIdWithOperationResponseAsync(ridDB, ridColl, ridDoc, authorization,
        //                userAgent, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}


        /// <summary>
        ///     List Documents
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
        public static IList<Document> ListDocuments(IDocumentDbConnector operations, string ridDB, string ridColl,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).ListDocumentsAsync(ridDB, ridColl, authorization, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     List Documents
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
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<IList<Document>> ListDocumentsAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridColl, string authorization, string userAgent, string xMSDate, string xMSVersion,
        //    CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.ListDocumentsWithOperationResponseAsync(ridDB, ridColl, authorization, userAgent, xMSDate,
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
        public static QueryResourceResponseBody QueryDocumentResource(IDocumentDbConnector operations, string ridDB,
            string ridColl, QueryRequest request, string authorization, string userAgent, string xMSDate,
            string xMSVersion, string contentType, bool xMSDocumentdbIsquery, string xMSMaxItemCount,
            string xMSContinuation, bool? xMSDocumentdbQueryEnableScan, string xMSSessionToken, string accept)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).QueryDocumentResourceAsync(ridDB, ridColl, request,
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
        //public static async Task<QueryResourceResponseBody> QueryDocumentResourceAsync(
        //     IDocumentDbConnector operations, string ridDB, string ridColl, QueryRequest request,
        //    string authorization,
        //    string userAgent, string xMSDate, string xMSVersion, string contentType, bool xMSDocumentdbIsquery,
        //    string xMSMaxItemCount, string xMSContinuation, bool? xMSDocumentdbQueryEnableScan, string xMSSessionToken,
        //    string accept, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.QueryDocumentResourceWithOperationResponseAsync(ridDB, ridColl, request, authorization,
        //                userAgent, xMSDate, xMSVersion, contentType, xMSDocumentdbIsquery, xMSMaxItemCount,
        //                xMSContinuation, xMSDocumentdbQueryEnableScan, xMSSessionToken, accept, cancellationToken)
        //                .ConfigureAwait(false);
        //    return result.Body;
        //}

        /// <summary>
        ///     Replace a Document
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
        /// <param name='ridDoc'>
        ///     Required. The Document Id
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
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='request'>
        ///     Optional.
        /// </param>
        public static Document ReplaceDocument(IDocumentDbConnector operations, string ridDB, string ridColl,
            string ridDoc, string authorization, string userAgent, string xMSDate, string xMSVersion,
            Document request = null)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).ReplaceDocumentAsync(ridDB, ridColl, ridDoc, authorization,
                        userAgent, xMSDate, xMSVersion, request), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Replace a Document
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
        ///// <param name='ridDoc'>
        /////     Required. The Document Id
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
        /////     version is used when the header is not provided use 2015-08-06
        ///// </param>
        ///// <param name='request'>
        /////     Optional.
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<Document> ReplaceDocumentAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridColl, string ridDoc, string authorization, string userAgent, string xMSDate, string xMSVersion,
        //    Document request = null, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.ReplaceDocumentWithOperationResponseAsync(ridDB, ridColl, ridDoc, authorization,
        //                userAgent, xMSDate, xMSVersion, request, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}
    }
}
