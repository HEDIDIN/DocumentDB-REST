using System.Collections.Generic;
using System.Threading.Tasks;
using DocDBAPIRest.Models;

namespace DocDBAPIRest.Controllers
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocumentApi
    {
        /// <summary>
        ///     List Documents
        /// </summary>
        /// <remarks>
        ///     List Documents
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>List of Documents</returns>
        List<Document> ListDocuments(string ridDb, string ridColl, string authorization, string xMsDate,
            string xMsVersion, string userAgent = null);

        /// <summary>
        ///     List Documents
        /// </summary>
        /// <remarks>
        ///     List Documents
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>ApiResponse of List&lt;Document&gt;</returns>
        ApiResponse<List<Document>> ListDocumentsWithHttpInfo(string ridDb, string ridColl, string authorization,
            string xMsDate, string xMsVersion, string userAgent = null);

        /// <summary>
        ///     List Documents
        /// </summary>
        /// <remarks>
        ///     List Documents
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>Task of List&lt;Document&gt;</returns>
        Task<List<Document>> ListDocumentsAsync(string ridDb, string ridColl, string authorization, string xMsDate,
            string xMsVersion, string userAgent = null);

        /// <summary>
        ///     List Documents
        /// </summary>
        /// <remarks>
        ///     List Documents
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Document&gt;)</returns>
        Task<ApiResponse<List<Document>>> ListDocumentsAsyncWithHttpInfo(string ridDb, string ridColl,
            string authorization, string xMsDate, string xMsVersion, string userAgent = null);

        /// <summary>
        ///     Create a Document
        /// </summary>
        /// <remarks>
        ///     Create a new Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="request"></param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>Document</returns>
        Document CreateDocument(string ridDb, string ridColl, CustomBody request, string authorization,
            string xMsDate, string xMsVersion, string userAgent = null);

        /// <summary>
        ///     Create a Document
        /// </summary>
        /// <remarks>
        ///     Create a new Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="request"></param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> CreateDocumentWithHttpInfo(string ridDb, string ridColl, CustomBody request,
            string authorization, string xMsDate, string xMsVersion, string userAgent = null);

        /// <summary>
        ///     Create a Document
        /// </summary>
        /// <remarks>
        ///     Create a new Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="request"></param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>Task of Document</returns>
        Task<Document> CreateDocumentAsync(string ridDb, string ridColl, CustomBody request, string authorization,
            string xMsDate, string xMsVersion, string userAgent = null);

        /// <summary>
        ///     Create a Document
        /// </summary>
        /// <remarks>
        ///     Create a new Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="request"></param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        Task<ApiResponse<Document>> CreateDocumentAsyncWithHttpInfo(string ridDb, string ridColl, CustomBody request,
            string authorization, string xMsDate, string xMsVersion, string userAgent = null);

        /// <summary>
        ///     Get a Document.
        /// </summary>
        /// <remarks>
        ///     Get a Document.
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="userAgent">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <returns>Document</returns>
        Document GetDocumentById(string ridDb, string ridColl, string ridDoc, string authorization, string userAgent,
            string xMsVersion);

        /// <summary>
        ///     Get a Document.
        /// </summary>
        /// <remarks>
        ///     Get a Document.
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="userAgent">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> GetDocumentByIdWithHttpInfo(string ridDb, string ridColl, string ridDoc,
            string authorization, string userAgent, string xMsVersion);

        /// <summary>
        ///     Get a Document.
        /// </summary>
        /// <remarks>
        ///     Get a Document.
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="userAgent">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <returns>Task of Document</returns>
        Task<Document> GetDocumentByIdAsync(string ridDb, string ridColl, string ridDoc, string authorization,
            string userAgent, string xMsVersion);

        /// <summary>
        ///     Get a Document.
        /// </summary>
        /// <remarks>
        ///     Get a Document.
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="userAgent">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 
        /// </param>
        /// <returns>Task of ApiResponse (Document)</returns>
        Task<ApiResponse<Document>> GetDocumentByIdAsyncWithHttpInfo(string ridDb, string ridColl, string ridDoc,
            string authorization, string userAgent, string xMsVersion);

        /// <summary>
        ///     Replace a Document
        /// </summary>
        /// <remarks>
        ///     Replace a Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 2015-08-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>Document</returns>
        Document ReplaceDocument(string ridDb, string ridColl, string ridDoc, string authorization, string xMsDate,
            string xMsVersion, Document request = null, string userAgent = null);

        /// <summary>
        ///     Replace a Document
        /// </summary>
        /// <remarks>
        ///     Replace a Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 2015-08-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>ApiResponse of Document</returns>
        ApiResponse<Document> ReplaceDocumentWithHttpInfo(string ridDb, string ridColl, string ridDoc,
            string authorization, string xMsDate, string xMsVersion, Document request = null,
            string userAgent = null);

        /// <summary>
        ///     Replace a Document
        /// </summary>
        /// <remarks>
        ///     Replace a Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 2015-08-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>Task of Document</returns>
        Task<Document> ReplaceDocumentAsync(string ridDb, string ridColl, string ridDoc, string authorization,
            string xMsDate, string xMsVersion, Document request = null, string userAgent = null);

        /// <summary>
        ///     Replace a Document
        /// </summary>
        /// <remarks>
        ///     Replace a Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 2015-08-06
        /// </param>
        /// <param name="request"></param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>Task of ApiResponse (Document)</returns>
        Task<ApiResponse<Document>> ReplaceDocumentAsyncWithHttpInfo(string ridDb, string ridColl, string ridDoc,
            string authorization, string xMsDate, string xMsVersion, Document request = null,
            string userAgent = null);

        /// <summary>
        ///     Delete a Document
        /// </summary>
        /// <remarks>
        ///     Delete a Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.&lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c&gt;
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 2015-08-06
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns></returns>
        void DeleteDocument(string ridDb, string ridColl, string ridDoc, string authorization, string xMsDate,
            string xMsVersion, string userAgent = null);

        /// <summary>
        ///     Delete a Document
        /// </summary>
        /// <remarks>
        ///     Delete a Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.&lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c&gt;
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 2015-08-06
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> DeleteDocumentWithHttpInfo(string ridDb, string ridColl, string ridDoc,
            string authorization, string xMsDate, string xMsVersion, string userAgent = null);

        /// <summary>
        ///     Delete a Document
        /// </summary>
        /// <remarks>
        ///     Delete a Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.&lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c&gt;
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 2015-08-06
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>Task of void</returns>
        Task DeleteDocumentAsync(string ridDb, string ridColl, string ridDoc, string authorization, string xMsDate,
            string xMsVersion, string userAgent = null);

        /// <summary>
        ///     Delete a Document
        /// </summary>
        /// <remarks>
        ///     Delete a Document
        /// </remarks>
        /// <param name="ridDb">The Database Id</param>
        /// <param name="ridColl">The Collection ID</param>
        /// <param name="ridDoc">The Document ID</param>
        /// <param name="authorization">
        ///     The authentication type and signature token. Both master key and resource tokens are
        ///     allowed for this operation.&lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c&gt;
        /// </param>
        /// <param name="xMsDate">
        ///     The date of the request The date is expressed in Coordinated Universal Time format. 
        ///    
        /// </param>
        /// <param name="xMsVersion">
        ///     The version of DocumentDB REST service. The latest version is used when the header is not
        ///     provided use 2015-08-06
        /// </param>
        /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> DeleteDocumentAsyncWithHttpInfo(string ridDb, string ridColl, string ridDoc,
            string authorization, string xMsDate, string xMsVersion, string userAgent = null);
    }

}