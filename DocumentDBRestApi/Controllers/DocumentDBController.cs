using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using DocumentDBRestApi.Models;
using TRex.Metadata;

namespace DocumentDBRestApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentDbController : ApiController
    {
        /// <summary>
        /// Create an Attachment
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridDoc'>
        /// Required. The Document Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}..
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [Metadata("CreateAttachment", "Create an Attachment for document")]
        [HttpPost]
        public static AttachmentResponse CreateAttachement( 
           IDocumentDbConnector operations, string ridDb, string ridColl, string ridDoc, AttachmentRaw request, string authorization, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).CreateAttachementAsync(ridDb, ridColl, ridDoc, request, authorization, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an Attachment
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridDoc'>
        /// Required. The Document Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}..
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [Metadata("CreateAttachment", "Create an Attachment for document")]
        [HttpPost]
        public static async Task<AttachmentResponse> CreateAttachementAsync( IDocumentDbConnector operations, string ridDb, string ridColl, string ridDoc, AttachmentRaw request, string authorization, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.CreateAttachementWithOperationResponseAsync(ridDb, ridColl, ridDoc, request, authorization, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Create a new Collection
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='id'>
        /// Required.  is a user settable property. It is the unique name
        /// that identifies the collection
        /// </param>
        [HttpGet]
        public static Collection CreateCollection( IDocumentDbConnector operations, string ridDb, string authorization, string xMsDate, string xMsVersion, CustomBodyCollection id)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).CreateCollectionAsync(ridDb, authorization, xMsDate, xMsVersion, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new Collection
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='id'>
        /// Required.  is a user settable property. It is the unique name
        /// that identifies the collection
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<Collection> CreateCollectionAsync( IDocumentDbConnector operations, string ridDb, string authorization, string xMsDate, string xMsVersion, CustomBodyCollection id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.CreateCollectionWithOperationResponseAsync(ridDb, authorization, xMsDate, xMsVersion, id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation.
        /// </param>
        /// <param name='contentType'>
        /// Required. For creating a database, the Content-Type header must be
        /// `application/json`.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  `Fri, 08 Apr 2015 03:52:31 GMT`
        /// </param>
        /// <param name='id'>
        /// Required.  is a user settable property. It is the unique name
        /// that identifies the collection
        /// </param>
        [HttpPost]
        public static Database CreateDatabase( IDocumentDbConnector operations, string authorization, string contentType, string xMsDate, CustomBodyCollection id)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).CreateDatabaseAsync(authorization, contentType, xMsDate, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation.
        /// </param>
        /// <param name='contentType'>
        /// Required. For creating a database, the Content-Type header must be
        /// `application/json`.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  `Fri, 08 Apr 2015 03:52:31 GMT`
        /// </param>
        /// <param name='id'>
        /// Required.  is a user settable property. It is the unique name
        /// that identifies the collection
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpPost]
        public static async Task<Database> CreateDatabaseAsync( IDocumentDbConnector operations, string authorization, string contentType, string xMsDate, CustomBodyCollection id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.CreateDatabaseWithOperationResponseAsync(authorization, contentType, xMsDate, id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Create a new Document
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpPost]
        public static Document CreateDocument( IDocumentDbConnector operations, string ridDb, string ridColl, CustomBody request, string authorization, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).CreateDocumentAsync(ridDb, ridColl, request, authorization, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new Document
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpPost]
        public static async Task<Document> CreateDocumentAsync( IDocumentDbConnector operations, string ridDb, string ridColl, CustomBody request, string authorization, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.CreateDocumentWithOperationResponseAsync(ridDb, ridColl, request, authorization, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Create a User
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request..
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpPost]
        public static User CreateUser( IDocumentDbConnector operations, string ridDb, User request, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).CreateUserAsync(ridDb, request, authorization, contentType, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a User
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request..
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpPost]
        public static async Task<User> CreateUserAsync( IDocumentDbConnector operations, string ridDb, User request, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.CreateUserWithOperationResponseAsync(ridDb, request, authorization, contentType, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Delete a Collection
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpDelete]
        public static object DeleteCollection( IDocumentDbConnector operations, string ridDb, string ridColl, string authorization, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).DeleteCollectionAsync(ridDb, ridColl, authorization, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a Collection
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpDelete]
        public static async Task<object> DeleteCollectionAsync( IDocumentDbConnector operations, string ridDb, string ridColl, string authorization, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.DeleteCollectionWithOperationResponseAsync(ridDb, ridColl, authorization, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Delete a Database
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation.
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  Example, Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpDelete]
        public static object DeleteDatabase( IDocumentDbConnector operations, string ridDb, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).DeleteDatabaseAsync(ridDb, authorization, contentType, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a Database
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation.
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. Example, Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpDelete]
        public static async Task<object> DeleteDatabaseAsync( IDocumentDbConnector operations, string ridDb, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.DeleteDatabaseWithOperationResponseAsync(ridDb, authorization, contentType, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Delete a Document
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridDoc'>
        /// Required. The Document Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpDelete]
        public static object DeleteDocument( IDocumentDbConnector operations, string ridDb, string ridColl, string ridDoc, string authorization, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).DeleteDocumentAsync(ridDb, ridColl, ridDoc, authorization, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a Document
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridDoc'>
        /// Required. The Document Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpDelete]
        public static async Task<object> DeleteDocumentAsync( IDocumentDbConnector operations, string ridDb, string ridColl, string ridDoc, string authorization, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.DeleteDocumentWithOperationResponseAsync(ridDb, ridColl, ridDoc, authorization, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// To delete a permission resource, perform a DELETE operation on that
        /// permission resource
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridPerm'>
        /// Required. The Permission Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation.
#pragma warning disable 1570
        /// type={typeoftoken}&ver={tokenversion}&sig={hashsignature}
#pragma warning restore 1570
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpDelete]
        public static object DeletePermission( IDocumentDbConnector operations, string ridDb, string ridPerm, string ridUser, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion) => Task.Factory.StartNew(s => ((IDocumentDbConnector)s).DeletePermissionAsync(ridDb, ridPerm, ridUser, authorization, contentType, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();

        /// <summary>
        /// To delete a permission resource, perform a DELETE operation on that
        /// permission resource
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridPerm'>
        /// Required. The Permission Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation.
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpDelete]
        public static async Task<object> DeletePermissionAsync( IDocumentDbConnector operations, string ridDb, string ridPerm, string ridUser, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.DeletePermissionWithOperationResponseAsync(ridDb, ridPerm, ridUser, authorization, contentType, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation. example:
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpDelete]
        public static object DeleteUser( IDocumentDbConnector operations, string ridDb, string ridUser, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).DeleteUserAsync(ridDb, ridUser, authorization, contentType, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation. example:
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpDelete]
        public static async Task<object> DeleteUserAsync( IDocumentDbConnector operations, string ridDb, string ridUser, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.DeleteUserWithOperationResponseAsync(ridDb, ridUser, authorization, contentType, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Execute a Stored Procedure
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridProc'>
        /// Required. The Procedure Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Required. The Content-Type header must be
        /// application/json.
        /// </param>
        /// <param name='xMsDocumentdbQueryEnableScan'>
        /// Required.
        /// </param>
        /// <param name='xMsDocumentdbIsquery'>
        /// Required.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - : Fri, 08
        /// Apr 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static QueryResponseBody ExecuteStoredProcedure( IDocumentDbConnector operations, string ridDb, string ridColl, string ridProc, QueryRequest request, string authorization, string contentType, bool xMsDocumentdbQueryEnableScan, bool xMsDocumentdbIsquery, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).ExecuteStoredProcedureAsync(ridDb, ridColl, ridProc, request, authorization, contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Execute a Stored Procedure
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridProc'>
        /// Required. The Procedure Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Required. The Content-Type header must be
        /// application/json.
        /// </param>
        /// <param name='xMsDocumentdbQueryEnableScan'>
        /// Required.
        /// </param>
        /// <param name='xMsDocumentdbIsquery'>
        /// Required.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - : Fri, 08
        /// Apr 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<QueryResponseBody> ExecuteStoredProcedureAsync( IDocumentDbConnector operations, string ridDb, string ridColl, string ridProc, QueryRequest request, string authorization, string contentType, bool xMsDocumentdbQueryEnableScan, bool xMsDocumentdbIsquery, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.ExecuteStoredProcedureWithOperationResponseAsync(ridDb, ridColl, ridProc, request, authorization, contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Get an Attachment from document
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridDoc'>
        /// Required. The Document Id
        /// </param>
        /// <param name='ridAttch'>
        /// Required. The Attachment Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}..
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static AttachmentRaw GetAttachement( IDocumentDbConnector operations, string ridDb, string ridColl, string ridDoc, string ridAttch, string authorization, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).GetAttachementAsync(ridDb, ridColl, ridDoc, ridAttch, authorization, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an Attachment from document
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridDoc'>
        /// Required. The Document Id
        /// </param>
        /// <param name='ridAttch'>
        /// Required. The Attachment Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}..
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<AttachmentRaw> GetAttachementAsync( IDocumentDbConnector operations, string ridDb, string ridColl, string ridDoc, string ridAttch, string authorization, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.GetAttachementWithOperationResponseAsync(ridDb, ridColl, ridDoc, ridAttch, authorization, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Get a Collection
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  example - Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static Collection GetCollectionById( IDocumentDbConnector operations, string ridDb, string ridColl, string authorization, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).GetCollectionByIdAsync(ridDb, ridColl, authorization, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a Collection
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  example - Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<Collection> GetCollectionByIdAsync( IDocumentDbConnector operations, string ridDb, string ridColl, string authorization, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.GetCollectionByIdWithOperationResponseAsync(ridDb, ridColl, authorization, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Retrieve a database resource by Id
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be `application/json`.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is `{user agent name}/{version}`.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.`Fri, 08 Apr 2015 03:52:31 GMT`
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use `2015-08-06`
        /// </param>
        /// <param name='xMsGatewayversion'>
        /// Required.
        /// </param>
        [HttpGet]
        public static Database GetDatabaseById( IDocumentDbConnector operations, string ridDb, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, string xMsGatewayversion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).GetDatabaseByIdAsync(ridDb, authorization, contentType, userAgent, xMsDate, xMsVersion, xMsGatewayversion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve a database resource by Id
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be `application/json`.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is `{user agent name}/{version}`.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.`Fri, 08 Apr 2015 03:52:31 GMT`
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use `2015-08-06`
        /// </param>
        /// <param name='xMsGatewayversion'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<Database> GetDatabaseByIdAsync( IDocumentDbConnector operations, string ridDb, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, string xMsGatewayversion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.GetDatabaseByIdWithOperationResponseAsync(ridDb, authorization, contentType, userAgent, xMsDate, xMsVersion, xMsGatewayversion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// List Databases
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is `{user agent name}/{version}`.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  `Fri, 08 Apr 2015 03:52:31 GMT`
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use `2015-08-06`
        /// </param>
        /// <param name='xMsGatewayversion'>
        /// Required. The Microsft Date Gateway version
        /// </param>
        [HttpGet]
        public static IList<DatabaseCollection> GetDatabaseList( IDocumentDbConnector operations, string authorization, string userAgent, string xMsDate, string xMsVersion, string xMsGatewayversion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).GetDatabaseListAsync(authorization, userAgent, xMsDate, xMsVersion, xMsGatewayversion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Databases
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is `{user agent name}/{version}`.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  `Fri, 08 Apr 2015 03:52:31 GMT`
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use `2015-08-06`
        /// </param>
        /// <param name='xMsGatewayversion'>
        /// Required. The Microsft Date Gateway version
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<IList<DatabaseCollection>> GetDatabaseListAsync( IDocumentDbConnector operations, string authorization, string userAgent, string xMsDate, string xMsVersion, string xMsGatewayversion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.GetDatabaseListWithOperationResponseAsync(authorization, userAgent, xMsDate, xMsVersion, xMsGatewayversion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Get a Document.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridDoc'>
        /// Required. The Document Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static Document GetDocumentById( IDocumentDbConnector operations, string ridDb, string ridColl, string ridDoc, string authorization, string userAgent, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).GetDocumentByIdAsync(ridDb, ridColl, ridDoc, authorization, userAgent, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a Document.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridDoc'>
        /// Required. The Document Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<Document> GetDocumentByIdAsync( IDocumentDbConnector operations, string ridDb, string ridColl, string ridDoc, string authorization, string userAgent, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.GetDocumentByIdWithOperationResponseAsync(ridDb, ridColl, ridDoc, authorization, userAgent, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Get a User
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.   example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static User GetUserById( IDocumentDbConnector operations, string ridDb, string ridUser, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).GetIserByIdAsync(ridDb, ridUser, authorization, contentType, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a User
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<User> GetUserByIdAsync( IDocumentDbConnector operations, string ridDb, string ridUser, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.GetUserByIdWithOperationResponseAsync(ridDb, ridUser, authorization, contentType, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='databaseaccount'>
        /// Required. The Database Account Name
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation. example:
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. Fri, 08 Apr 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static IList<Offer> GetListOfOffers( IDocumentDbConnector operations, string databaseaccount, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).GetListOfOffersAsync(databaseaccount, authorization, contentType, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='databaseaccount'>
        /// Required. The Database Account Name
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation. example:
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. Fri, 08 Apr 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<IList<Offer>> GetListOfOffersAsync( IDocumentDbConnector operations, string databaseaccount, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.GetListOfOffersWithOperationResponseAsync(databaseaccount, authorization, contentType, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Get a list of users resource of a particular database
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}..
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example -Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static IList<User> GetListOfUsers( IDocumentDbConnector operations, string ridDb, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).GetListOfUsersAsync(ridDb, authorization, contentType, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of users resource of a particular database
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}..
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example -Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<IList<User>> GetListOfUsersAsync( IDocumentDbConnector operations, string ridDb, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.GetListOfUsersWithOperationResponseAsync(ridDb, authorization, contentType, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridOffer'>
        /// Required. The Offer Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation. example:
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static Offer GetOffer( IDocumentDbConnector operations, string ridOffer, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).GetOfferAsync(ridOffer, authorization, contentType, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridOffer'>
        /// Required. The Offer Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation. example:
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<Offer> GetOfferAsync( IDocumentDbConnector operations, string ridOffer, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.GetOfferWithOperationResponseAsync(ridOffer, authorization, contentType, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Performing a GET operation on a specific permission resource
        /// retrieves the permission properties, including the token, for the
        /// particular permission. A new resource token is created every time
        /// a GET is invoked on the permission resource.  new token has
        /// the default validity period of one hour, unless it is overridden.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='ridPerm'>
        /// Required. The Permission Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation. example:
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example- Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static Permission GetPermission( IDocumentDbConnector operations, string ridDb, string ridUser, string ridPerm, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).GetPermissionAsync(ridDb, ridUser, ridPerm, authorization, contentType, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Performing a GET operation on a specific permission resource
        /// retrieves the permission properties, including the token, for the
        /// particular permission. A new resource token is created every time
        /// a GET is invoked on the permission resource.  new token has
        /// the default validity period of one hour, unless it is overridden.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='ridPerm'>
        /// Required. The Permission Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation. example:
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example- Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<Permission> GetPermissionAsync( IDocumentDbConnector operations, string ridDb, string ridUser, string ridPerm, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.GetPermissionWithOperationResponseAsync(ridDb, ridUser, ridPerm, authorization, contentType, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// List Collections
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example -Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static IList<Collection> ListCollections( IDocumentDbConnector operations, string ridDb, string authorization, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).ListCollectionsAsync(ridDb, authorization, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Collections
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example -Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<IList<Collection>> ListCollectionsAsync( IDocumentDbConnector operations, string ridDb, string authorization, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.ListCollectionsWithOperationResponseAsync(ridDb, authorization, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// List Documents
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static IList<Document> ListDocuments( IDocumentDbConnector operations, string ridDb, string ridColl, string authorization, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).ListDocumentsAsync(ridDb, ridColl, authorization, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Documents
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<IList<Document>> ListDocumentsAsync( IDocumentDbConnector operations, string ridDb, string ridColl, string authorization, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.ListDocumentsWithOperationResponseAsync(ridDb, ridColl, authorization, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='databaseaccount'>
        /// Required. The Database Account Name
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation. example:
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='contentType'>
        /// Required. Required. The Content-Type header must be
        /// application/json.
        /// </param>
        /// <param name='xMsDocumentdbQueryEnableScan'>
        /// Required.
        /// </param>
        /// <param name='xMsDocumentdbIsquery'>
        /// Required.
        /// </param>
        [HttpGet]
        public static QueryResponseBody QueryOffer( IDocumentDbConnector operations, string databaseaccount, QuerySql request, string authorization, string userAgent, string xMsDate, string xMsVersion, string contentType, bool xMsDocumentdbQueryEnableScan, bool xMsDocumentdbIsquery)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).QueryOfferAsync(databaseaccount, request, authorization, userAgent, xMsDate, xMsVersion, contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='databaseaccount'>
        /// Required. The Database Account Name
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation. example:
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='contentType'>
        /// Required. Required. The Content-Type header must be
        /// application/json.
        /// </param>
        /// <param name='xMsDocumentdbQueryEnableScan'>
        /// Required.
        /// </param>
        /// <param name='xMsDocumentdbIsquery'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<QueryResponseBody> QueryOfferAsync( IDocumentDbConnector operations, string databaseaccount, QuerySql request, string authorization, string userAgent, string xMsDate, string xMsVersion, string contentType, bool xMsDocumentdbQueryEnableScan, bool xMsDocumentdbIsquery, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.QueryOfferWithOperationResponseAsync(databaseaccount, request, authorization, userAgent, xMsDate, xMsVersion, contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Query a Permission
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='request'>
        /// Required. The Request Body
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Required. The Content-Type header must be
        /// application/json.
        /// </param>
        /// <param name='xMsDocumentdbQueryEnableScan'>
        /// Required.
        /// </param>
        /// <param name='xMsDocumentdbIsquery'>
        /// Required.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpGet]
        public static QueryResponseBody QueryPermission( IDocumentDbConnector operations, string ridDb, string ridUser, QueryRequest request, string authorization, string contentType, bool xMsDocumentdbQueryEnableScan, bool xMsDocumentdbIsquery, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).QueryPermissionAsync(ridDb, ridUser, request, authorization, contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query a Permission
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='request'>
        /// Required. The Request Body
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Required. The Content-Type header must be
        /// application/json.
        /// </param>
        /// <param name='xMsDocumentdbQueryEnableScan'>
        /// Required.
        /// </param>
        /// <param name='xMsDocumentdbIsquery'>
        /// Required.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpGet]
        public static async Task<QueryResponseBody> QueryPermissionAsync( IDocumentDbConnector operations, string ridDb, string ridUser, QueryRequest request, string authorization, string contentType, bool xMsDocumentdbQueryEnableScan, bool xMsDocumentdbIsquery, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.QueryPermissionWithOperationResponseAsync(ridDb, ridUser, request, authorization, contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Query a Trigger
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='contentType'>
        /// Required. Required. The Content-Type header must be
        /// application/json.
        /// </param>
        /// <param name='xMsDocumentdbQueryEnableScan'>
        /// Required.
        /// </param>
        /// <param name='xMsDocumentdbIsquery'>
        /// Required.
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpPost]
        public static QueryResponseBody QueryTrigger( IDocumentDbConnector operations, string ridDb, string ridColl, string contentType, bool xMsDocumentdbQueryEnableScan, bool xMsDocumentdbIsquery, QueryRequest request, string authorization, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).QueryTriggerAsync(ridDb, ridColl, contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, request, authorization, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query a Trigger
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='contentType'>
        /// Required. Required. The Content-Type header must be
        /// application/json.
        /// </param>
        /// <param name='xMsDocumentdbQueryEnableScan'>
        /// Required.
        /// </param>
        /// <param name='xMsDocumentdbIsquery'>
        /// Required.
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpPost]
        public static async Task<QueryResponseBody> QueryTriggerAsync( IDocumentDbConnector operations, string ridDb, string ridColl, string contentType, bool xMsDocumentdbQueryEnableScan, bool xMsDocumentdbIsquery, QueryRequest request, string authorization, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.QueryTriggerWithOperationResponseAsync(ridDb, ridColl, contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, request, authorization, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Query a UDF
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Required. The Content-Type header must be
        /// application/json.
        /// </param>
        /// <param name='xMsDocumentdbQueryEnableScan'>
        /// Required.
        /// </param>
        /// <param name='xMsDocumentdbIsquery'>
        /// Required.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpPost]
        public static QueryResponseBody QueryUdf( IDocumentDbConnector operations, string ridDb, string ridColl, QueryRequest request, string authorization, string contentType, bool xMsDocumentdbQueryEnableScan, bool xMsDocumentdbIsquery, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).QueryUdfAsync(ridDb, ridColl, request, authorization, contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query a UDF
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Required. The Content-Type header must be
        /// application/json.
        /// </param>
        /// <param name='xMsDocumentdbQueryEnableScan'>
        /// Required.
        /// </param>
        /// <param name='xMsDocumentdbIsquery'>
        /// Required.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpPost]
        public static async Task<QueryResponseBody> QueryUdfAsync( IDocumentDbConnector operations, string ridDb, string ridColl, QueryRequest request, string authorization, string contentType, bool xMsDocumentdbQueryEnableScan, bool xMsDocumentdbIsquery, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.QueryUdfWithOperationResponseAsync(ridDb, ridColl, request, authorization, contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Register a Stored Procedure
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpPost]
        public static StoredProcedure RegisterStoredProcedure( IDocumentDbConnector operations, string ridDb, string ridColl, QueryRequest request, string authorization, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).RegisterStoredProcedureAsync(ridDb, ridColl, request, authorization, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Register a Stored Procedure
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpPost]
        public static async Task<StoredProcedure> RegisterStoredProcedureAsync( IDocumentDbConnector operations, string ridDb, string ridColl, QueryRequest request, string authorization, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.RegisterStoredProcedureWithOperationResponseAsync(ridDb, ridColl, request, authorization, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Replace a Document
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridDoc'>
        /// Required. The Document Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='request'>
        /// Optional.
        /// </param>
        [HttpPut]
        public static Document ReplaceDocument( IDocumentDbConnector operations, string ridDb, string ridColl, string ridDoc, string authorization, string userAgent, string xMsDate, string xMsVersion, Document request = null)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).ReplaceDocumentAsync(ridDb, ridColl, ridDoc, authorization, userAgent, xMsDate, xMsVersion, request), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Replace a Document
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridColl'>
        /// Required. The Collection Id
        /// </param>
        /// <param name='ridDoc'>
        /// Required. The Document Id
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='request'>
        /// Optional.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpPut]
        public static async Task<Document> ReplaceDocumentAsync( IDocumentDbConnector operations, string ridDb, string ridColl, string ridDoc, string authorization, string userAgent, string xMsDate, string xMsVersion, Document request = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.ReplaceDocumentWithOperationResponseAsync(ridDb, ridColl, ridDoc, authorization, userAgent, xMsDate, xMsVersion, request, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridOffer'>
        /// Required. The Offer Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpPut]
        public static Offer ReplaceOffer( IDocumentDbConnector operations, string ridOffer, ReplaceOffer request, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).ReplaceOfferAsync(ridOffer, request, authorization, contentType, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridOffer'>
        /// Required. The Offer Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpPut]
        public static async Task<Offer> ReplaceOfferAsync( IDocumentDbConnector operations, string ridOffer, ReplaceOffer request, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.ReplaceOfferWithOperationResponseAsync(ridOffer, request, authorization, contentType, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Replaces the entire user Permission.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='ridPerm'>
        /// Required. The Permission Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpPut]
        public static Permission ReplacePermission( IDocumentDbConnector operations, string ridDb, string ridUser, string ridPerm, Permission request, string authorization, string contentType, string userAgent, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).ReplacePermissionAsync(ridDb, ridUser, ridPerm, request, authorization, contentType, userAgent, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Replaces the entire user Permission.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='ridPerm'>
        /// Required. The Permission Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format. example: Fri, 08 Apr 2015
        /// 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpPut]
        public static async Task<Permission> ReplacePermissionAsync(IDocumentDbConnector operations, string ridDb, string ridUser, string ridPerm, Permission request, string authorization, string contentType, string userAgent, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.ReplacePermissionWithOperationResponseAsync(ridDb, ridUser, ridPerm, request, authorization, contentType, userAgent, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <summary>
        /// Replace a User
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  example: - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        [HttpPut]
        public static User ReplaceUser(IDocumentDbConnector operations, string ridDb, string ridUser, User request, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion)
        {
            return Task.Factory.StartNew(s => ((IDocumentDbConnector)s).ReplaceUserAsync(ridDb, ridUser, request, authorization, contentType, userAgent, xMsDate, xMsVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Replace a User
        /// </summary>
        /// <param name='operations'>
        /// Reference to the DocumentDBRestApi.IDocumentDbConnector.
        /// </param>
        /// <param name='ridDb'>
        /// Required. The Database Id
        /// </param>
        /// <param name='ridUser'>
        /// Required. The User Id
        /// </param>
        /// <param name='request'>
        /// Required.
        /// </param>
        /// <param name='authorization'>
        /// Required. The authentication type and signature token. Both master
        /// key and resource tokens are allowed for  operation
        /// </param>
        /// <param name='contentType'>
        /// Required. Optional. For creating a database, the Content-Type
        /// header must be application/json.
        /// </param>
        /// <param name='userAgent'>
        /// Required. Optional. The string of client user agent performing the
        /// request. The recommended format is {user agent name}/{version}.
        /// </param>
        /// <param name='xMsDate'>
        /// Required. The date of the request The date is expressed in
        /// Coordinated Universal Time format.  example: - Fri, 08 Apr
        /// 2015 03:52:31 GMT
        /// </param>
        /// <param name='xMsVersion'>
        /// Required. The version of DocumentDB REST service. The latest
        /// version is used when the header is not provided use 2015-08-06
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        [HttpPut]
        public static async Task<User> ReplaceUserAsync(IDocumentDbConnector operations, string ridDb, string ridUser, User request, string authorization, string contentType, string userAgent, string xMsDate, string xMsVersion, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await operations.ReplaceUserWithOperationResponseAsync(ridDb, ridUser, request, authorization, contentType, userAgent, xMsDate, xMsVersion, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }



    }
}
