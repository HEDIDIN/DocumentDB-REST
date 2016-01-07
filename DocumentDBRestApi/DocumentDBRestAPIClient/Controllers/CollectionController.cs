using System.Collections.Generic;
using System.Web.Http;
using DocumentDBRestAPIClient.Models;

namespace DocumentDBRestAPIClient.Controllers
{
    [Authorize]
    public class CollectionController : ApiController
    {
        /// <summary>
        ///     List Collections
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbRestApi.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for this operation.
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
        ///     Coordinated Universal Time format. example -
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
        public IList<Collection> ListCollections(IDocumentDbRestApi operations, string ridDB,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
            => operations.ListCollections(ridDB, authorization, userAgent, xMSDate, xMSVersion);

        /// <summary>
        ///     Get a Collection
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbRestApi.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        ///     Required. The Collection Id
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for this operation.
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
        ///     Coordinated Universal Time format.  example -
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
        [HttpGet]
        public Collection GetCollectionById(IDocumentDbRestApi operations, string ridDB, string ridColl,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
            => operations.GetCollectionById(ridDB, ridColl, authorization, userAgent, xMSDate, xMSVersion);

        /// <summary>
        ///     Create a new Collection
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbRestApi.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for this operation.
        ///     <c>type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}</c>
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format. example -
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
        ///     Required. This is a user settable property. It is the unique name
        ///     that identifies the collection
        /// </param>
        [HttpPost]
        public Collection CreateCollection(IDocumentDbRestApi operations, string ridDB, string authorization,
            string xMSDate, string xMSVersion, CustomBodyCollection id)
            => operations.CreateCollection(ridDB, authorization, xMSDate, xMSVersion,
                id);


        /// <summary>
        ///     Delete a Collection
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbRestApi.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        ///     Required. The Collection Id
        /// </param>
        /// <param name='authorization'>
        ///     Required. The authentication type and signature token. Both master
        ///     key and resource tokens are allowed for this operation.
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
        [HttpDelete]
        public object DeleteCollection(IDocumentDbRestApi operations, string ridDB, string ridColl,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
            => operations.DeleteCollection(ridDB, ridColl, authorization, userAgent, xMSDate, xMSVersion);
    }
}