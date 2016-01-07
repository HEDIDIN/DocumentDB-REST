using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using DocumentDBRestApi.Models;

namespace DocumentDBRestApi.Controllers
{
    /// <summary>
    /// </summary>
    public class DocumentDbController : ApiController
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
        public static AttachmentResponse CreateAttachement( IDocumentDbConnector operations, string ridDB,
            string ridColl, string ridDoc, AttachmentRaw request, string authorization, string userAgent, string xMSDate,
            string xMSVersion)
        {
            var resp = DocumentDbConnectorExtensions.CreateAttachement(operations, ridDB, ridColl, request, authorization,
                userAgent, xMSDate, xMSVersion);


            //Task.Factory.StartNew(
            //    s =>
            //        ((IDocumentDbConnector) s).CreateAttachementAsync(ridDB, ridColl, ridDoc, request, authorization,
            //            userAgent, xMSDate, xMSVersion), operations, CancellationToken.None,
            //    TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<AttachmentResponse> CreateAttachementAsync( IDocumentDbConnector operations,
            string ridDB, string ridColl, string ridDoc, AttachmentRaw request, string authorization, string userAgent,
            string xMSDate, string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.CreateAttachementWithOperationResponseAsync(ridDB, ridColl, ridDoc, request,
                        authorization, userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static Collection CreateCollection( IDocumentDbConnector operations, string ridDB,
            string authorization,
            string xMSDate, string xMSVersion, CustomBodyCollection id)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).CreateCollectionAsync(ridDB, authorization, xMSDate, xMSVersion,
                        id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<Collection> CreateCollectionAsync( IDocumentDbConnector operations, string ridDB,
            string authorization, string xMSDate, string xMSVersion, CustomBodyCollection id,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.CreateCollectionWithOperationResponseAsync(ridDB, authorization, xMSDate, xMSVersion, id,
                        cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static Database CreateDatabase( IDocumentDbConnector operations, string authorization,
            string contentType, string xMSDate, CustomBodyCollection id)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).CreateDatabaseAsync(authorization, contentType, xMSDate, id),
                    operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<Database> CreateDatabaseAsync( IDocumentDbConnector operations,
            string authorization,
            string contentType, string xMSDate, CustomBodyCollection id,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.CreateDatabaseWithOperationResponseAsync(authorization, contentType, xMSDate, id,
                        cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static Document CreateDocument( IDocumentDbConnector operations, string ridDB, string ridColl,
            CustomBody request, string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).CreateDocumentAsync(ridDB, ridColl, request, authorization,
                        userAgent, xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<Document> CreateDocumentAsync( IDocumentDbConnector operations, string ridDB,
            string ridColl, CustomBody request, string authorization, string userAgent, string xMSDate,
            string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.CreateDocumentWithOperationResponseAsync(ridDB, ridColl, request, authorization,
                        userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        ///     Create a User
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
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
        ///     request..
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
        public static User CreateUser( IDocumentDbConnector operations, string ridDB, User request,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).CreateUserAsync(ridDB, request, authorization, contentType,
                        userAgent, xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        /// <summary>
        ///     Create a User
        /// </summary>
        /// <param name='operations'>
        ///     Reference to the DocumentDBRestAPIClient.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDB'>
        ///     Required. The Database Id
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
        ///     request..
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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<User> CreateUserAsync( IDocumentDbConnector operations, string ridDB, User request,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.CreateUserWithOperationResponseAsync(ridDB, request, authorization, contentType,
                        userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static object DeleteCollection( IDocumentDbConnector operations, string ridDB, string ridColl,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).DeleteCollectionAsync(ridDB, ridColl, authorization, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        ///     .
        /// </param>
        /// <param name='xMSDate'>
        ///     Required. The date of the request The date is expressed in
        ///     Coordinated Universal Time format.
        ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use
        ///     <c>2015-08-06</c>
        /// </param>
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<object> DeleteCollectionAsync( IDocumentDbConnector operations, string ridDB,
            string ridColl, string authorization, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.DeleteCollectionWithOperationResponseAsync(ridDB, ridColl, authorization, userAgent,
                        xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static object DeleteDatabase( IDocumentDbConnector operations, string ridDB, string authorization,
            string contentType, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).DeleteDatabaseAsync(ridDB, authorization, contentType, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        ///     Required. Optional. The string of client user agent performing the
        ///     request. The recommended format is
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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<object> DeleteDatabaseAsync( IDocumentDbConnector operations, string ridDB,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.DeleteDatabaseWithOperationResponseAsync(ridDB, authorization, contentType, userAgent,
                        xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static object DeleteDocument( IDocumentDbConnector operations, string ridDB, string ridColl,
            string ridDoc, string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).DeleteDocumentAsync(ridDB, ridColl, ridDoc, authorization,
                        userAgent, xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<object> DeleteDocumentAsync( IDocumentDbConnector operations, string ridDB,
            string ridColl, string ridDoc, string authorization, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.DeleteDocumentWithOperationResponseAsync(ridDB, ridColl, ridDoc, authorization, userAgent,
                        xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static object DeletePermission( IDocumentDbConnector operations, string ridDB, string ridPerm,
            string ridUser, string authorization, string contentType, string userAgent, string xMSDate,
            string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).DeletePermissionAsync(ridDB, ridPerm, ridUser, authorization,
                        contentType, userAgent, xMSDate, xMSVersion), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<object> DeletePermissionAsync( IDocumentDbConnector operations, string ridDB,
            string ridPerm, string ridUser, string authorization, string contentType, string userAgent, string xMSDate,
            string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.DeletePermissionWithOperationResponseAsync(ridDB, ridPerm, ridUser, authorization,
                        contentType, userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        ///     Delete a User
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
        ///     <c>{ user agentname}/{ version}</c>.
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
        public static object DeleteUser( IDocumentDbConnector operations, string ridDB, string ridUser,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).DeleteUserAsync(ridDB, ridUser, authorization, contentType,
                        userAgent, xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        /// <summary>
        ///     Delete a User
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
        ///     Coordinated Universal Time format.          
        ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<object> DeleteUserAsync( IDocumentDbConnector operations, string ridDB,
            string ridUser, string authorization, string contentType, string userAgent, string xMSDate,
            string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.DeleteUserWithOperationResponseAsync(ridDB, ridUser, authorization, contentType,
                        userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static QueryResponseBody ExecuteStoredProcedure( IDocumentDbConnector operations, string ridDB,
            string ridColl, string ridProc, QueryRequest request, string authorization, string contentType,
            bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery, string userAgent, string xMSDate,
            string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).ExecuteStoredProcedureAsync(ridDB, ridColl, ridProc, request,
                        authorization, contentType, xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        ///     Coordinated Universal Time format.           :
        ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<QueryResponseBody> ExecuteStoredProcedureAsync( IDocumentDbConnector operations,
            string ridDB, string ridColl, string ridProc, QueryRequest request, string authorization, string contentType,
            bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery, string userAgent, string xMSDate,
            string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.ExecuteStoredProcedureWithOperationResponseAsync(ridDB, ridColl, ridProc, request,
                        authorization, contentType, xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, userAgent,
                        xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static AttachmentRaw GetAttachement( IDocumentDbConnector operations, string ridDB, string ridColl,
            string ridDoc, string ridAttch, string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).GetAttachementAsync(ridDB, ridColl, ridDoc, ridAttch,
                        authorization, userAgent, xMSDate, xMSVersion), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<AttachmentRaw> GetAttachementAsync( IDocumentDbConnector operations, string ridDB,
            string ridColl, string ridDoc, string ridAttch, string authorization, string userAgent, string xMSDate,
            string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.GetAttachementWithOperationResponseAsync(ridDB, ridColl, ridDoc, ridAttch, authorization,
                        userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static Collection GetCollectionById( IDocumentDbConnector operations, string ridDB, string ridColl,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).GetCollectionByIdAsync(ridDB, ridColl, authorization, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<Collection> GetCollectionByIdAsync( IDocumentDbConnector operations, string ridDB,
            string ridColl, string authorization, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.GetCollectionByIdWithOperationResponseAsync(ridDB, ridColl, authorization, userAgent,
                        xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static Database GetDatabaseById( IDocumentDbConnector operations, string ridDB, string authorization,
            string contentType, string userAgent, string xMSDate, string xMSVersion, string xMSGatewayversion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).GetDatabaseByIdAsync(ridDB, authorization, contentType,
                        userAgent, xMSDate, xMSVersion, xMSGatewayversion), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<Database> GetDatabaseByIdAsync( IDocumentDbConnector operations, string ridDB,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion,
            string xMSGatewayversion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.GetDatabaseByIdWithOperationResponseAsync(ridDB, authorization, contentType, userAgent,
                        xMSDate, xMSVersion, xMSGatewayversion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static IList<DatabaseCollection> GetDatabaseList( IDocumentDbConnector operations,
            string authorization,
            string userAgent, string xMSDate, string xMSVersion, string xMSGatewayversion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).GetDatabaseListAsync(authorization, userAgent, xMSDate,
                        xMSVersion, xMSGatewayversion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<IList<DatabaseCollection>> GetDatabaseListAsync( IDocumentDbConnector operations,
            string authorization, string userAgent, string xMSDate, string xMSVersion, string xMSGatewayversion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.GetDatabaseListWithOperationResponseAsync(authorization, userAgent, xMSDate, xMSVersion,
                        xMSGatewayversion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static Document GetDocumentById( IDocumentDbConnector operations, string ridDB, string ridColl,
            string ridDoc, string authorization, string userAgent, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).GetDocumentByIdAsync(ridDB, ridColl, ridDoc, authorization,
                        userAgent, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<Document> GetDocumentByIdAsync( IDocumentDbConnector operations, string ridDB,
            string ridColl, string ridDoc, string authorization, string userAgent, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.GetDocumentByIdWithOperationResponseAsync(ridDB, ridColl, ridDoc, authorization,
                        userAgent, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static IList<Offer> GetListOfOffers( IDocumentDbConnector operations, string databaseaccount,
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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<IList<Offer>> GetListOfOffersAsync( IDocumentDbConnector operations,
            string databaseaccount, string authorization, string contentType, string userAgent, string xMSDate,
            string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.GetListOfOffersWithOperationResponseAsync(databaseaccount, authorization, contentType,
                        userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        ///     Get a list of users resource of a particular database
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
        ///     Required. Optional. The string of client user agent performing the
        ///     request. The recommended format is
        ///     <c>{ user agentname}/{ version}</c>
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
        public static IList<User> GetListOfUsers( IDocumentDbConnector operations, string ridDB,
            string authorization,
            string contentType, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).GetListOfUsersAsync(ridDB, authorization, contentType, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        /// <summary>
        ///     Get a list of users resource of a particular database
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
        ///     Required. Optional. The string of client user agent performing the
        ///     request. The recommended format is
        ///     <c>{ user agentname}/{ version}</c>
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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<IList<User>> GetListOfUsersAsync( IDocumentDbConnector operations, string ridDB,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.GetListOfUsersWithOperationResponseAsync(ridDB, authorization, contentType, userAgent,
                        xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static Offer GetOffer( IDocumentDbConnector operations, string ridOffer, string authorization,
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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<Offer> GetOfferAsync( IDocumentDbConnector operations, string ridOffer,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.GetOfferWithOperationResponseAsync(ridOffer, authorization, contentType, userAgent,
                        xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static Permission GetPermission( IDocumentDbConnector operations, string ridDB, string ridUser,
            string ridPerm, string authorization, string contentType, string userAgent, string xMSDate,
            string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).GetPermissionAsync(ridDB, ridUser, ridPerm, authorization,
                        contentType, userAgent, xMSDate, xMSVersion), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<Permission> GetPermissionAsync( IDocumentDbConnector operations, string ridDB,
            string ridUser, string ridPerm, string authorization, string contentType, string userAgent, string xMSDate,
            string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.GetPermissionWithOperationResponseAsync(ridDB, ridUser, ridPerm, authorization,
                        contentType, userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        ///     Get a User
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
        ///     Coordinated Universal Time format.          
        ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        public static User GetUserById( IDocumentDbConnector operations, string ridDB, string ridUser,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).GetUserByIdAsync(ridDB, ridUser, authorization, contentType,
                        userAgent, xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        /// <summary>
        ///     Get a User
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
        ///     Coordinated Universal Time format.          
        ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<User> GetUserByIdAsync( IDocumentDbConnector operations, string ridDB,
            string ridUser,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.GetUserByIdWithOperationResponseAsync(ridDB, ridUser, authorization, contentType,
                        userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static IList<Collection> ListCollections( IDocumentDbConnector operations, string ridDB,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).ListCollectionsAsync(ridDB, authorization, userAgent, xMSDate,
                        xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<IList<Collection>> ListCollectionsAsync( IDocumentDbConnector operations,
            string ridDB, string authorization, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.ListCollectionsWithOperationResponseAsync(ridDB, authorization, userAgent, xMSDate,
                        xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static IList<Document> ListDocuments( IDocumentDbConnector operations, string ridDB, string ridColl,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).ListDocumentsAsync(ridDB, ridColl, authorization, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<IList<Document>> ListDocumentsAsync( IDocumentDbConnector operations, string ridDB,
            string ridColl, string authorization, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.ListDocumentsWithOperationResponseAsync(ridDB, ridColl, authorization, userAgent, xMSDate,
                        xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static QueryResourceResponseBody QueryCollectionResource( IDocumentDbConnector operations,
            string ridDB,
            string ridColl, QueryRequest request, string authorization, string userAgent, string xMSDate,
            string xMSVersion, string contentType, bool xMSDocumentdbIsquery, string xMSMaxItemCount,
            string xMSContinuation, bool? xMSDocumentdbQueryEnableScan, string xMSSessionToken, string accept)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).QueryCollectionResourceAsync(ridDB, ridColl, request,
                        authorization, userAgent, xMSDate, xMSVersion, contentType, xMSDocumentdbIsquery,
                        xMSMaxItemCount, xMSContinuation, xMSDocumentdbQueryEnableScan, xMSSessionToken, accept),
                    operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<QueryResourceResponseBody> QueryCollectionResourceAsync(
             IDocumentDbConnector operations, string ridDB, string ridColl, QueryRequest request,
            string authorization,
            string userAgent, string xMSDate, string xMSVersion, string contentType, bool xMSDocumentdbIsquery,
            string xMSMaxItemCount, string xMSContinuation, bool? xMSDocumentdbQueryEnableScan, string xMSSessionToken,
            string accept, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.QueryCollectionResourceWithOperationResponseAsync(ridDB, ridColl, request, authorization,
                        userAgent, xMSDate, xMSVersion, contentType, xMSDocumentdbIsquery, xMSMaxItemCount,
                        xMSContinuation, xMSDocumentdbQueryEnableScan, xMSSessionToken, accept, cancellationToken)
                        .ConfigureAwait(false);
            return result.Body;
        }

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
        public static QueryResourceResponseBody QueryDocumentResource( IDocumentDbConnector operations, string ridDB,
            string ridColl, QueryRequest request, string authorization, string userAgent, string xMSDate,
            string xMSVersion, string contentType, bool xMSDocumentdbIsquery, string xMSMaxItemCount,
            string xMSContinuation, bool? xMSDocumentdbQueryEnableScan, string xMSSessionToken, string accept)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).QueryDocumentResourceAsync(ridDB, ridColl, request,
                        authorization, userAgent, xMSDate, xMSVersion, contentType, xMSDocumentdbIsquery,
                        xMSMaxItemCount, xMSContinuation, xMSDocumentdbQueryEnableScan, xMSSessionToken, accept),
                    operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<QueryResourceResponseBody> QueryDocumentResourceAsync(
             IDocumentDbConnector operations, string ridDB, string ridColl, QueryRequest request,
            string authorization,
            string userAgent, string xMSDate, string xMSVersion, string contentType, bool xMSDocumentdbIsquery,
            string xMSMaxItemCount, string xMSContinuation, bool? xMSDocumentdbQueryEnableScan, string xMSSessionToken,
            string accept, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.QueryDocumentResourceWithOperationResponseAsync(ridDB, ridColl, request, authorization,
                        userAgent, xMSDate, xMSVersion, contentType, xMSDocumentdbIsquery, xMSMaxItemCount,
                        xMSContinuation, xMSDocumentdbQueryEnableScan, xMSSessionToken, accept, cancellationToken)
                        .ConfigureAwait(false);
            return result.Body;
        }

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
        public static QueryResponseBody QueryOffer( IDocumentDbConnector operations, string databaseaccount,
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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<QueryResponseBody> QueryOfferAsync( IDocumentDbConnector operations,
            string databaseaccount, QuerySql request, string authorization, string userAgent, string xMSDate,
            string xMSVersion, string contentType, bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.QueryOfferWithOperationResponseAsync(databaseaccount, request, authorization, userAgent,
                        xMSDate, xMSVersion, contentType, xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery,
                        cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static QueryResponseBody QueryPermission( IDocumentDbConnector operations, string ridDB,
            string ridUser,
            QueryRequest request, string authorization, string contentType, bool xMSDocumentdbQueryEnableScan,
            bool xMSDocumentdbIsquery, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).QueryPermissionAsync(ridDB, ridUser, request, authorization,
                        contentType, xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, xMSDate, xMSVersion),
                    operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<QueryResponseBody> QueryPermissionAsync( IDocumentDbConnector operations,
            string ridDB, string ridUser, QueryRequest request, string authorization, string contentType,
            bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.QueryPermissionWithOperationResponseAsync(ridDB, ridUser, request, authorization,
                        contentType, xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, xMSDate, xMSVersion,
                        cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static QueryResponseBody QueryTrigger( IDocumentDbConnector operations, string ridDB, string ridColl,
            string contentType, bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery, QueryRequest request,
            string authorization, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).QueryTriggerAsync(ridDB, ridColl, contentType,
                        xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, request, authorization, userAgent,
                        xMSDate, xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        ///     <c>{ user agentname}/{ version}</c>
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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<QueryResponseBody> QueryTriggerAsync( IDocumentDbConnector operations, string ridDB,
            string ridColl, string contentType, bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery,
            QueryRequest request, string authorization, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.QueryTriggerWithOperationResponseAsync(ridDB, ridColl, contentType,
                        xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, request, authorization, userAgent, xMSDate,
                        xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        ///     Query a UDF
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
        public static QueryResponseBody QueryUdf( IDocumentDbConnector operations, string ridDB, string ridColl,
            QueryRequest request, string authorization, string contentType, bool xMSDocumentdbQueryEnableScan,
            bool xMSDocumentdbIsquery, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).QueryUdfAsync(ridDB, ridColl, request, authorization,
                        contentType, xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, userAgent, xMSDate,
                        xMSVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        /// <summary>
        ///     Query a UDF
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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<QueryResponseBody> QueryUdfAsync( IDocumentDbConnector operations, string ridDB,
            string ridColl, QueryRequest request, string authorization, string contentType,
            bool xMSDocumentdbQueryEnableScan, bool xMSDocumentdbIsquery, string userAgent, string xMSDate,
            string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.QueryUdfWithOperationResponseAsync(ridDB, ridColl, request, authorization, contentType,
                        xMSDocumentdbQueryEnableScan, xMSDocumentdbIsquery, userAgent, xMSDate, xMSVersion,
                        cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static StoredProcedure RegisterStoredProcedure( IDocumentDbConnector operations, string ridDB,
            string ridColl, QueryRequest request, string authorization, string userAgent, string xMSDate,
            string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).RegisterStoredProcedureAsync(ridDB, ridColl, request,
                        authorization, userAgent, xMSDate, xMSVersion), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<StoredProcedure> RegisterStoredProcedureAsync( IDocumentDbConnector operations,
            string ridDB, string ridColl, QueryRequest request, string authorization, string userAgent, string xMSDate,
            string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.RegisterStoredProcedureWithOperationResponseAsync(ridDB, ridColl, request, authorization,
                        userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static Document ReplaceDocument( IDocumentDbConnector operations, string ridDB, string ridColl,
            string ridDoc, string authorization, string userAgent, string xMSDate, string xMSVersion,
            Document request = null)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).ReplaceDocumentAsync(ridDB, ridColl, ridDoc, authorization,
                        userAgent, xMSDate, xMSVersion, request), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<Document> ReplaceDocumentAsync( IDocumentDbConnector operations, string ridDB,
            string ridColl, string ridDoc, string authorization, string userAgent, string xMSDate, string xMSVersion,
            Document request = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.ReplaceDocumentWithOperationResponseAsync(ridDB, ridColl, ridDoc, authorization,
                        userAgent, xMSDate, xMSVersion, request, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static Offer ReplaceOffer( IDocumentDbConnector operations, string ridOffer, ReplaceOffer request,
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
        ///     <c>{ user agentname}/{ version}</c>.
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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<Offer> ReplaceOfferAsync( IDocumentDbConnector operations, string ridOffer,
            ReplaceOffer request, string authorization, string contentType, string userAgent, string xMSDate,
            string xMSVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.ReplaceOfferWithOperationResponseAsync(ridOffer, request, authorization, contentType,
                        userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

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
        public static Permission ReplacePermission( IDocumentDbConnector operations, string ridDB, string ridUser,
            string ridPerm, Permission request, string authorization, string contentType, string userAgent,
            string xMSVersion, string xMSDate)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).ReplacePermissionAsync(ridDB, ridUser, ridPerm, request,
                        authorization, contentType, userAgent, xMSVersion, xMSDate), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

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
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<Permission> ReplacePermissionAsync( IDocumentDbConnector operations, string ridDB,
            string ridUser, string ridPerm, Permission request, string authorization, string contentType,
            string userAgent, string xMSVersion, string xMSDate,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.ReplacePermissionWithOperationResponseAsync(ridDB, ridUser, ridPerm, request,
                        authorization, contentType, userAgent, xMSVersion, xMSDate, cancellationToken)
                        .ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        ///     Replace a User
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
        ///     Coordinated Universal Time format.
        ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        public static User ReplaceUser( IDocumentDbConnector operations, string ridDB, string ridUser, User request,
            string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion)
        {
            return
                Task.Factory.StartNew(
                    s => ((IDocumentDbConnector) s).ReplaceUserAsync(ridDB, ridUser, request, authorization,
                        contentType, userAgent, xMSDate, xMSVersion), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        /// <summary>
        ///     Replace a User
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
        ///     Coordinated Universal Time format.          example: -
        ///     <example>Fri, 08 Apr 2015 03:52:31 GMT</example>
        /// </param>
        /// <param name='xMSVersion'>
        ///     Required. The version of DocumentDB REST service. The latest
        ///     version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        ///     Cancellation token.
        /// </param>
        public static async Task<User> ReplaceUserAsync( IDocumentDbConnector operations, string ridDB,
            string ridUser,
            User request, string authorization, string contentType, string userAgent, string xMSDate, string xMSVersion,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var result =
                await
                    operations.ReplaceUserWithOperationResponseAsync(ridDB, ridUser, request, authorization, contentType,
                        userAgent, xMSDate, xMSVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}