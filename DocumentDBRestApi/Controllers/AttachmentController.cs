using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using DocumentDBRestApi.Models;

namespace DocumentDBRestApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class AttachmentController : ApiController
    {


        /// <summary>
        ///     Create an Attachment
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
        public static AttachmentResponse CreateAttachement(IDocumentDbConnector operations, string ridDB,
            string ridColl, string ridDoc, AttachmentRaw request, string authorization, string userAgent, string xMSDate,
            string xMSVersion)
        {
           

           return Task.Factory.StartNew(
                s =>
                    ((IDocumentDbConnector)s).CreateAttachementAsync(ridDB, ridColl, ridDoc, request, authorization,
                        userAgent, xMSDate, xMSVersion), operations, CancellationToken.None,
                TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();

        }

        ///// <summary>
        /////     Create an Attachment
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
        //public static async Task<AttachmentResponse> CreateAttachementAsync(IDocumentDbConnector operations,
        //    string ridDB, string ridColl, string ridDoc, AttachmentRaw request, string authorization, string userAgent,
        //    string xMSDate, string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.CreateAttachementWithOperationResponseAsync(ridDB, ridColl, ridDoc, request,
        //                authorization, userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}

        /// <summary>
        ///     Get an Attachment from document
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
        /// <param name='ridAttch'>
        ///     Required. The Attachment Id
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
        public static AttachmentRaw GetAttachement(IDocumentDbConnector operations, string ridDB, string ridColl,
            string ridDoc, string ridAttch, string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector)s).GetAttachementAsync(ridDB, ridColl, ridDoc, ridAttch,
                        authorization, userAgent, xMSDate, xMSVersion), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        ///// <summary>
        /////     Get an Attachment from document
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
        ///// <param name='ridAttch'>
        /////     Required. The Attachment Id
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
        /////     version is used when the header is not provided use 2015-08-06
        ///// </param>
        ///// <param name='cancellationToken'>
        /////     Cancellation token.
        ///// </param>
        //public static async Task<AttachmentRaw> GetAttachementAsync(IDocumentDbConnector operations, string ridDB,
        //    string ridColl, string ridDoc, string ridAttch, string authorization, string userAgent, string xMSDate,
        //    string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var result =
        //        await
        //            operations.GetAttachementWithOperationResponseAsync(ridDB, ridColl, ridDoc, ridAttch, authorization,
        //                userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
        //    return result.Body;
        //}
    }
}
