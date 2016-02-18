using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DocDBAPIRest.Models;
using RestSharp;

namespace DocDBAPIRest.Controllers
{
    public class UserController : ApiController
    {
        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public interface IUserApi
        {
            /// <summary>
            ///     Get a list of users resource of a particular database
            /// </summary>
            /// <remarks>
            ///     Get a list of users resource of a particular database
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>List&lt;User&gt;</returns>
            List<User> GetListOfUsers(string ridDb, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null);

            /// <summary>
            ///     Get a list of users resource of a particular database
            /// </summary>
            /// <remarks>
            ///     Get a list of users resource of a particular database
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of List&lt;User&gt;</returns>
            ApiResponse<List<User>> GetListOfUsersWithHttpInfo(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Get a list of users resource of a particular database
            /// </summary>
            /// <remarks>
            ///     Get a list of users resource of a particular database
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of List&lt;User&gt;</returns>
            Task<List<User>> GetListOfUsersAsync(string ridDb, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null);

            /// <summary>
            ///     Get a list of users resource of a particular database
            /// </summary>
            /// <remarks>
            ///     Get a list of users resource of a particular database
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (List&lt;User&gt;)</returns>
            Task<ApiResponse<List<User>>> GetListOfUsersAsyncWithHttpInfo(string ridDb, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Create a User
            /// </summary>
            /// <remarks>
            ///     Create a User
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request..</param>
            /// <returns>User</returns>
            User CreateUser(string ridDb, User request, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null);

            /// <summary>
            ///     Create a User
            /// </summary>
            /// <remarks>
            ///     Create a User
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request..</param>
            /// <returns>ApiResponse of User</returns>
            ApiResponse<User> CreateUserWithHttpInfo(string ridDb, User request, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Create a User
            /// </summary>
            /// <remarks>
            ///     Create a User
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request..</param>
            /// <returns>Task of User</returns>
            Task<User> CreateUserAsync(string ridDb, User request, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Create a User
            /// </summary>
            /// <remarks>
            ///     Create a User
            /// </remarks>
            /// <param name="ridDb">The Database Id</param>
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
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request..</param>
            /// <returns>Task of ApiResponse (User)</returns>
            Task<ApiResponse<User>> CreateUserAsyncWithHttpInfo(string ridDb, User request, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Get a User
            /// </summary>
            /// <remarks>
            ///     Get a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>User</returns>
            User GetUserById(string ridDb, string ridUser, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null);

            /// <summary>
            ///     Get a User
            /// </summary>
            /// <remarks>
            ///     Get a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of User</returns>
            ApiResponse<User> GetUserByIdWithHttpInfo(string ridDb, string ridUser, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Get a User
            /// </summary>
            /// <remarks>
            ///     Get a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of User</returns>
            Task<User> GetUserByIdAsync(string ridDb, string ridUser, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Get a User
            /// </summary>
            /// <remarks>
            ///     Get a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (User)</returns>
            Task<ApiResponse<User>> GetUserByIdAsyncWithHttpInfo(string ridDb, string ridUser, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Replace a User
            /// </summary>
            /// <remarks>
            ///     Replace a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example: -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>User</returns>
            User ReplaceUser(string ridDb, string ridUser, User request, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Replace a User
            /// </summary>
            /// <remarks>
            ///     Replace a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example: -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of User</returns>
            ApiResponse<User> ReplaceUserWithHttpInfo(string ridDb, string ridUser, User request, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Replace a User
            /// </summary>
            /// <remarks>
            ///     Replace a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example: -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of User</returns>
            Task<User> ReplaceUserAsync(string ridDb, string ridUser, User request, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Replace a User
            /// </summary>
            /// <remarks>
            ///     Replace a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example: -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (User)</returns>
            Task<ApiResponse<User>> ReplaceUserAsyncWithHttpInfo(string ridDb, string ridUser, User request,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null);

            /// <summary>
            ///     Delete a User
            /// </summary>
            /// <remarks>
            ///     Delete a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns></returns>
            void DeleteUser(string ridDb, string ridUser, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null);

            /// <summary>
            ///     Delete a User
            /// </summary>
            /// <remarks>
            ///     Delete a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of Object(void)</returns>
            ApiResponse<object> DeleteUserWithHttpInfo(string ridDb, string ridUser, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Delete a User
            /// </summary>
            /// <remarks>
            ///     Delete a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of void</returns>
            Task DeleteUserAsync(string ridDb, string ridUser, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null);

            /// <summary>
            ///     Delete a User
            /// </summary>
            /// <remarks>
            ///     Delete a User
            /// </remarks>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse</returns>
            Task<ApiResponse<object>> DeleteUserAsyncWithHttpInfo(string ridDb, string ridUser, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null);
        }

        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public class UserApi : IUserApi
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="UserApi" /> class.
            /// </summary>
            /// <returns></returns>
            public UserApi(string basePath)
            {
                Configuration = new Configuration(new ApiClient(basePath));
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="UserApi" /> class
            ///     using Configuration object
            /// </summary>
            /// <param name="configuration">An instance of Configuration</param>
            /// <returns></returns>
            public UserApi(Configuration configuration = null)
            {
                if (configuration == null) // use the default one in Configuration
                    Configuration = Configuration.Default;
                else
                    Configuration = configuration;
            }

            /// <summary>
            ///     Gets or sets the configuration object
            /// </summary>
            /// <value>An instance of the Configuration</value>
            public Configuration Configuration { get; set; }


            /// <summary>
            ///     Get a list of users resource of a particular database Get a list of users resource of a particular database
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>List&lt;User&gt;</returns>
            public List<User> GetListOfUsers(string ridDb, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null)
            {
                var response = GetListOfUsersWithHttpInfo(ridDb, authorization, xMsDate, xMsVersion, contentType,
                    userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get a list of users resource of a particular database Get a list of users resource of a particular database
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of List&lt;User&gt;</returns>
            public ApiResponse<List<User>> GetListOfUsersWithHttpInfo(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetListOfUsers");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetListOfUsers");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetListOfUsers");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetListOfUsers");


                var path = "/{rid-db}/users";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetListOfUsers: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetListOfUsers: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<User>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<User>) Configuration.ApiClient.Deserialize(response, typeof (List<User>)));
            }

            /// <summary>
            ///     Get a list of users resource of a particular database Get a list of users resource of a particular database
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of List&lt;User&gt;</returns>
            public async Task<List<User>> GetListOfUsersAsync(string ridDb, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response =
                    await
                        GetListOfUsersAsyncWithHttpInfo(ridDb, authorization, xMsDate, xMsVersion, contentType,
                            userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get a list of users resource of a particular database Get a list of users resource of a particular database
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (List&lt;User&gt;)</returns>
            public async Task<ApiResponse<List<User>>> GetListOfUsersAsyncWithHttpInfo(string ridDb,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetListOfUsers");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetListOfUsers");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetListOfUsers");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetListOfUsers");


                var path = "/{rid-db}/users";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetListOfUsers: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetListOfUsers: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<User>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<User>) Configuration.ApiClient.Deserialize(response, typeof (List<User>)));
            }

            /// <summary>
            ///     Create a User Create a User
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request..</param>
            /// <returns>User</returns>
            public User CreateUser(string ridDb, User request, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null)
            {
                var response = CreateUserWithHttpInfo(ridDb, request, authorization, xMsDate, xMsVersion, contentType,
                    userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Create a User Create a User
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request..</param>
            /// <returns>ApiResponse of User</returns>
            public ApiResponse<User> CreateUserWithHttpInfo(string ridDb, User request, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling CreateUser");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling CreateUser");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling CreateUser");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling CreateUser");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling CreateUser");


                var path = "/{rid-db}/users";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling CreateUser: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling CreateUser: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<User>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (User) Configuration.ApiClient.Deserialize(response, typeof (User)));
            }

            /// <summary>
            ///     Create a User Create a User
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request..</param>
            /// <returns>Task of User</returns>
            public async Task<User> CreateUserAsync(string ridDb, User request, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response =
                    await
                        CreateUserAsyncWithHttpInfo(ridDb, request, authorization, xMsDate, xMsVersion, contentType,
                            userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Create a User Create a User
            /// </summary>
            /// <param name="ridDb">The Database Id</param>
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
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">Optional. The string of client user agent performing the request..</param>
            /// <returns>Task of ApiResponse (User)</returns>
            public async Task<ApiResponse<User>> CreateUserAsyncWithHttpInfo(string ridDb, User request,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling CreateUser");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling CreateUser");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling CreateUser");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling CreateUser");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling CreateUser");


                var path = "/{rid-db}/users";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling CreateUser: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling CreateUser: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<User>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (User) Configuration.ApiClient.Deserialize(response, typeof (User)));
            }

            /// <summary>
            ///     Get a User Get a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>User</returns>
            public User GetUserById(string ridDb, string ridUser, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response = GetUserByIdWithHttpInfo(ridDb, ridUser, authorization, xMsDate, xMsVersion, contentType,
                    userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get a User Get a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of User</returns>
            public ApiResponse<User> GetUserByIdWithHttpInfo(string ridDb, string ridUser, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetUserById");

                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling GetUserById");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetUserById");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetUserById");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetUserById");


                var path = "/{rid-db}/users/{rid-user}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetUserById: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetUserById: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<User>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (User) Configuration.ApiClient.Deserialize(response, typeof (User)));
            }

            /// <summary>
            ///     Get a User Get a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of User</returns>
            public async Task<User> GetUserByIdAsync(string ridDb, string ridUser, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response =
                    await
                        GetUserByIdAsyncWithHttpInfo(ridDb, ridUser, authorization, xMsDate, xMsVersion, contentType,
                            userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get a User Get a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User ID</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (User)</returns>
            public async Task<ApiResponse<User>> GetUserByIdAsyncWithHttpInfo(string ridDb, string ridUser,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling GetUserById");
                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling GetUserById");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetUserById");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetUserById");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetUserById");


                var path = "/{rid-db}/users/{rid-user}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling GetUserById: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetUserById: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<User>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (User) Configuration.ApiClient.Deserialize(response, typeof (User)));
            }

            /// <summary>
            ///     Replace a User Replace a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example: -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>User</returns>
            public User ReplaceUser(string ridDb, string ridUser, User request, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response = ReplaceUserWithHttpInfo(ridDb, ridUser, request, authorization, xMsDate, xMsVersion,
                    contentType, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Replace a User Replace a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example: -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of User</returns>
            public ApiResponse<User> ReplaceUserWithHttpInfo(string ridDb, string ridUser, User request,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ReplaceUser");

                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling ReplaceUser");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling ReplaceUser");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling ReplaceUser");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ReplaceUser");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ReplaceUser");


                var path = "/{rid-db}/users/{rid-user}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling ReplaceUser: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ReplaceUser: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<User>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (User) Configuration.ApiClient.Deserialize(response, typeof (User)));
            }

            /// <summary>
            ///     Replace a User Replace a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example: -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of User</returns>
            public async Task<User> ReplaceUserAsync(string ridDb, string ridUser, User request, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response =
                    await
                        ReplaceUserAsyncWithHttpInfo(ridDb, ridUser, request, authorization, xMsDate, xMsVersion,
                            contentType, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Replace a User Replace a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example: -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (User)</returns>
            public async Task<ApiResponse<User>> ReplaceUserAsyncWithHttpInfo(string ridDb, string ridUser, User request,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling ReplaceUser");
                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling ReplaceUser");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling ReplaceUser");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling ReplaceUser");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ReplaceUser");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ReplaceUser");


                var path = "/{rid-db}/users/{rid-user}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.PUT, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling ReplaceUser: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ReplaceUser: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<User>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (User) Configuration.ApiClient.Deserialize(response, typeof (User)));
            }

            /// <summary>
            ///     Delete a User Delete a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns></returns>
            public void DeleteUser(string ridDb, string ridUser, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null)
            {
                DeleteUserWithHttpInfo(ridDb, ridUser, authorization, xMsDate, xMsVersion, contentType, userAgent);
            }

            /// <summary>
            ///     Delete a User Delete a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of Object(void)</returns>
            public ApiResponse<object> DeleteUserWithHttpInfo(string ridDb, string ridUser, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling DeleteUser");

                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling DeleteUser");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling DeleteUser");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling DeleteUser");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling DeleteUser");


                var path = "/{rid-db}/users/{rid-user}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>(Configuration.DefaultHeader);
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling DeleteUser: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling DeleteUser: " + response.ErrorMessage,
                        response.ErrorMessage);


                return new ApiResponse<object>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    null);
            }

            /// <summary>
            ///     Delete a User Delete a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of void</returns>
            public async Task DeleteUserAsync(string ridDb, string ridUser, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                await
                    DeleteUserAsyncWithHttpInfo(ridDb, ridUser, authorization, xMsDate, xMsVersion, contentType,
                        userAgent);
            }

            /// <summary>
            ///     Delete a User Delete a User
            /// </summary>
            /// <param name="ridDb">The Database ID</param>
            /// <param name="ridUser">The User Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format.
            ///     example -
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Optional. For creating a database, the Content-Type header must be application/json.</param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse</returns>
            public async Task<ApiResponse<object>> DeleteUserAsyncWithHttpInfo(string ridDb, string ridUser,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridDb' is set
                if (ridDb == null)
                    throw new ApiException(400, "Missing required parameter 'ridDb' when calling DeleteUser");
                // verify the required parameter 'ridUser' is set
                if (ridUser == null)
                    throw new ApiException(400, "Missing required parameter 'ridUser' when calling DeleteUser");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling DeleteUser");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling DeleteUser");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling DeleteUser");


                var path = "/{rid-db}/users/{rid-user}";

                var pathParams = new Dictionary<string, string>();
                var queryParams = new Dictionary<string, string>();
                var headerParams = new Dictionary<string, string>();
                var formParams = new Dictionary<string, string>();
                var fileParams = new Dictionary<string, FileParameter>();
                string postBody = null;

                // to determine the Accept header
                string[] httpHeaderAccepts =
                {
                    "application/json"
                };
                var httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
                if (httpHeaderAccept != null)
                    headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts));

                // set "format" to json by default
                // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
                pathParams.Add("format", "json");
                if (ridDb != null)
                    pathParams.Add("rid-db", Configuration.ApiClient.ParameterToString(ridDb)); // path parameter
                if (ridUser != null)
                    pathParams.Add("rid-user", Configuration.ApiClient.ParameterToString(ridUser)); // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
                        // header parameter
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (userAgent != null)
                    headerParams.Add("User-Agent", Configuration.ApiClient.ParameterToString(userAgent));
                        // header parameter
                if (xMsDate != null)
                    headerParams.Add("x-ms-date", Configuration.ApiClient.ParameterToString(xMsDate));
                        // header parameter
                if (xMsVersion != null)
                    headerParams.Add("x-ms-version", Configuration.ApiClient.ParameterToString(xMsVersion));
                        // header parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody,
                                headerParams, formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling DeleteUser: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling DeleteUser: " + response.ErrorMessage,
                        response.ErrorMessage);


                return new ApiResponse<object>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    null);
            }

            /// <summary>
            ///     Gets the base path of the API client.
            /// </summary>
            /// <value>The base path</value>
            public string GetBasePath()
            {
                return Configuration.ApiClient.RestClient.BaseUrl.ToString();
            }

            /// <summary>
            ///     Sets the base path of the API client.
            /// </summary>
            /// <value>The base path</value>
            [Obsolete(
                "SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead."
                )]
            public void SetBasePath(string basePath)
            {
                // do nothing
            }

            /// <summary>
            ///     Gets the default header.
            /// </summary>
            /// <returns>Dictionary of HTTP header</returns>
            [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
            public Dictionary<string, string> DefaultHeader()
            {
                return Configuration.DefaultHeader;
            }

            /// <summary>
            ///     Add default header.
            /// </summary>
            /// <param name="key">Header field name.</param>
            /// <param name="value">Header field value.</param>
            /// <returns></returns>
            [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
            public void AddDefaultHeader(string key, string value)
            {
                Configuration.AddDefaultHeader(key, value);
            }
        }
    }
}