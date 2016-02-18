using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using DocDBAPIRest.Models;
using RestSharp;

namespace DocDBAPIRest.Controllers
{
    public class OfferController : ApiController
    {
        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public interface IOfferApi
        {
            /// <summary>
            ///     GetOfferById
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Offer</returns>
            Offer GetOffer(string ridOffer, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null);

            /// <summary>
            ///     GetOfferById
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>ApiResponse of Offer</returns>
            ApiResponse<Offer> GetOfferWithHttpInfo(string ridOffer, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     GetOfferById
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Task of Offer</returns>
            Task<Offer> GetOfferAsync(string ridOffer, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null);

            /// <summary>
            ///     GetOfferById
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Task of ApiResponse (Offer)</returns>
            Task<ApiResponse<Offer>> GetOfferAsyncWithHttpInfo(string ridOffer, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Replace an Offer
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Offer</returns>
            Offer ReplaceOffer(string ridOffer, ReplaceOffer request, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Replace an Offer
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>ApiResponse of Offer</returns>
            ApiResponse<Offer> ReplaceOfferWithHttpInfo(string ridOffer, ReplaceOffer request, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Replace an Offer
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Task of Offer</returns>
            Task<Offer> ReplaceOfferAsync(string ridOffer, ReplaceOffer request, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Replace an Offer
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Task of ApiResponse (Offer)</returns>
            Task<ApiResponse<Offer>> ReplaceOfferAsyncWithHttpInfo(string ridOffer, ReplaceOffer request,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null);

            /// <summary>
            ///     Get List of Offers
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>List&lt;Offer&gt;</returns>
            List<Offer> GetListOfOffers(string databaseaccount, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null);

            /// <summary>
            ///     Get List of Offers
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>ApiResponse of List&lt;Offer&gt;</returns>
            ApiResponse<List<Offer>> GetListOfOffersWithHttpInfo(string databaseaccount, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Get List of Offers
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of List&lt;Offer&gt;</returns>
            Task<List<Offer>> GetListOfOffersAsync(string databaseaccount, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Get List of Offers
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of ApiResponse (List&lt;Offer&gt;)</returns>
            Task<ApiResponse<List<Offer>>> GetListOfOffersAsyncWithHttpInfo(string databaseaccount, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null);

            /// <summary>
            ///     Query an Offer
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>QueryResponseBody</returns>
            QueryResponseBody QueryOffer(string databaseaccount, QuerySql request, string authorization, string xMsDate,
                string xMsVersion, string contentType, bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery,
                string userAgent = null);

            /// <summary>
            ///     Query an Offer
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of QueryResponseBody</returns>
            ApiResponse<QueryResponseBody> QueryOfferWithHttpInfo(string databaseaccount, QuerySql request,
                string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string userAgent = null);

            /// <summary>
            ///     Query an Offer
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of QueryResponseBody</returns>
            Task<QueryResponseBody> QueryOfferAsync(string databaseaccount, QuerySql request, string authorization,
                string xMsDate, string xMsVersion, string contentType, bool? xMsDocumentdbQueryEnableScan,
                bool? xMsDocumentdbIsquery, string userAgent = null);

            /// <summary>
            ///     Query an Offer
            /// </summary>
            /// <remarks>
            /// </remarks>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (QueryResponseBody)</returns>
            Task<ApiResponse<QueryResponseBody>> QueryOfferAsyncWithHttpInfo(string databaseaccount, QuerySql request,
                string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string userAgent = null);
        }

        /// <summary>
        ///     Represents a collection of functions to interact with the API endpoints
        /// </summary>
        public class OfferApi : IOfferApi
        {
            /// <summary>
            ///     Initializes a new instance of the <see cref="OfferApi" /> class.
            /// </summary>
            /// <returns></returns>
            public OfferApi(string basePath)
            {
                Configuration = new Configuration(new ApiClient(basePath));
            }

            /// <summary>
            ///     Initializes a new instance of the <see cref="OfferApi" /> class
            ///     using Configuration object
            /// </summary>
            /// <param name="configuration">An instance of Configuration</param>
            /// <returns></returns>
            public OfferApi(Configuration configuration = null)
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
            ///     GetOfferById
            /// </summary>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Offer</returns>
            public Offer GetOffer(string ridOffer, string authorization, string xMsDate, string xMsVersion,
                string contentType = null, string userAgent = null)
            {
                var response = GetOfferWithHttpInfo(ridOffer, authorization, xMsDate, xMsVersion, contentType, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     GetOfferById
            /// </summary>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>ApiResponse of Offer</returns>
            public ApiResponse<Offer> GetOfferWithHttpInfo(string ridOffer, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                // verify the required parameter 'ridOffer' is set
                if (ridOffer == null)
                    throw new ApiException(400, "Missing required parameter 'ridOffer' when calling GetOffer");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetOffer");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetOffer");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetOffer");


                var path = "/offers/{rid-offer}";

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
                if (ridOffer != null)
                    pathParams.Add("rid-offer", Configuration.ApiClient.ParameterToString(ridOffer)); // path parameter


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
                    throw new ApiException(statusCode, "Error calling GetOffer: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetOffer: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Offer>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Offer) Configuration.ApiClient.Deserialize(response, typeof (Offer)));
            }

            /// <summary>
            ///     GetOfferById
            /// </summary>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Task of Offer</returns>
            public async Task<Offer> GetOfferAsync(string ridOffer, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response =
                    await
                        GetOfferAsyncWithHttpInfo(ridOffer, authorization, xMsDate, xMsVersion, contentType, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     GetOfferById
            /// </summary>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Task of ApiResponse (Offer)</returns>
            public async Task<ApiResponse<Offer>> GetOfferAsyncWithHttpInfo(string ridOffer, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                // verify the required parameter 'ridOffer' is set
                if (ridOffer == null)
                    throw new ApiException(400, "Missing required parameter 'ridOffer' when calling GetOffer");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling GetOffer");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetOffer");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetOffer");


                var path = "/offers/{rid-offer}";

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
                if (ridOffer != null)
                    pathParams.Add("rid-offer", Configuration.ApiClient.ParameterToString(ridOffer)); // path parameter


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
                    throw new ApiException(statusCode, "Error calling GetOffer: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetOffer: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Offer>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Offer) Configuration.ApiClient.Deserialize(response, typeof (Offer)));
            }

            /// <summary>
            ///     Replace an Offer
            /// </summary>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Offer</returns>
            public Offer ReplaceOffer(string ridOffer, ReplaceOffer request, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response = ReplaceOfferWithHttpInfo(ridOffer, request, authorization, xMsDate, xMsVersion,
                    contentType, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Replace an Offer
            /// </summary>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>ApiResponse of Offer</returns>
            public ApiResponse<Offer> ReplaceOfferWithHttpInfo(string ridOffer, ReplaceOffer request,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridOffer' is set
                if (ridOffer == null)
                    throw new ApiException(400, "Missing required parameter 'ridOffer' when calling ReplaceOffer");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling ReplaceOffer");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling ReplaceOffer");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ReplaceOffer");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ReplaceOffer");


                var path = "/offers/{rid-offer}";

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
                if (ridOffer != null)
                    pathParams.Add("rid-offer", Configuration.ApiClient.ParameterToString(ridOffer)); // path parameter


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
                    throw new ApiException(statusCode, "Error calling ReplaceOffer: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ReplaceOffer: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Offer>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Offer) Configuration.ApiClient.Deserialize(response, typeof (Offer)));
            }

            /// <summary>
            ///     Replace an Offer
            /// </summary>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Task of Offer</returns>
            public async Task<Offer> ReplaceOfferAsync(string ridOffer, ReplaceOffer request, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response =
                    await
                        ReplaceOfferAsyncWithHttpInfo(ridOffer, request, authorization, xMsDate, xMsVersion, contentType,
                            userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Replace an Offer
            /// </summary>
            /// <param name="ridOffer">The Offer Id</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation.
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
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
            /// <returns>Task of ApiResponse (Offer)</returns>
            public async Task<ApiResponse<Offer>> ReplaceOfferAsyncWithHttpInfo(string ridOffer, ReplaceOffer request,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'ridOffer' is set
                if (ridOffer == null)
                    throw new ApiException(400, "Missing required parameter 'ridOffer' when calling ReplaceOffer");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling ReplaceOffer");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling ReplaceOffer");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling ReplaceOffer");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling ReplaceOffer");


                var path = "/offers/{rid-offer}";

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
                if (ridOffer != null)
                    pathParams.Add("rid-offer", Configuration.ApiClient.ParameterToString(ridOffer)); // path parameter


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
                    throw new ApiException(statusCode, "Error calling ReplaceOffer: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling ReplaceOffer: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<Offer>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (Offer) Configuration.ApiClient.Deserialize(response, typeof (Offer)));
            }

            /// <summary>
            ///     Get List of Offers
            /// </summary>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>List&lt;Offer&gt;</returns>
            public List<Offer> GetListOfOffers(string databaseaccount, string authorization, string xMsDate,
                string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response = GetListOfOffersWithHttpInfo(databaseaccount, authorization, xMsDate, xMsVersion,
                    contentType, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get List of Offers
            /// </summary>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>ApiResponse of List&lt;Offer&gt;</returns>
            public ApiResponse<List<Offer>> GetListOfOffersWithHttpInfo(string databaseaccount, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                // verify the required parameter 'databaseaccount' is set
                if (databaseaccount == null)
                    throw new ApiException(400,
                        "Missing required parameter 'databaseaccount' when calling GetListOfOffers");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling GetListOfOffers");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetListOfOffers");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetListOfOffers");


                var path = "/{databaseaccount}.documents.azure.com/offers";

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
                if (databaseaccount != null)
                    pathParams.Add("databaseaccount", Configuration.ApiClient.ParameterToString(databaseaccount));
                        // path parameter


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
                    throw new ApiException(statusCode, "Error calling GetListOfOffers: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetListOfOffers: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<Offer>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<Offer>) Configuration.ApiClient.Deserialize(response, typeof (List<Offer>)));
            }

            /// <summary>
            ///     Get List of Offers
            /// </summary>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of List&lt;Offer&gt;</returns>
            public async Task<List<Offer>> GetListOfOffersAsync(string databaseaccount, string authorization,
                string xMsDate, string xMsVersion, string contentType = null, string userAgent = null)
            {
                var response =
                    await
                        GetListOfOffersAsyncWithHttpInfo(databaseaccount, authorization, xMsDate, xMsVersion,
                            contentType, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Get List of Offers
            /// </summary>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
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
            /// <param name="userAgent">Optional. The string of client user agent performing the request.</param>
            /// <returns>Task of ApiResponse (List&lt;Offer&gt;)</returns>
            public async Task<ApiResponse<List<Offer>>> GetListOfOffersAsyncWithHttpInfo(string databaseaccount,
                string authorization, string xMsDate, string xMsVersion, string contentType = null,
                string userAgent = null)
            {
                // verify the required parameter 'databaseaccount' is set
                if (databaseaccount == null)
                    throw new ApiException(400,
                        "Missing required parameter 'databaseaccount' when calling GetListOfOffers");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400,
                        "Missing required parameter 'authorization' when calling GetListOfOffers");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling GetListOfOffers");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling GetListOfOffers");


                var path = "/{databaseaccount}.documents.azure.com/offers";

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
                if (databaseaccount != null)
                    pathParams.Add("databaseaccount", Configuration.ApiClient.ParameterToString(databaseaccount));
                        // path parameter


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
                    throw new ApiException(statusCode, "Error calling GetListOfOffers: " + response.Content,
                        response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling GetListOfOffers: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<List<Offer>>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (List<Offer>) Configuration.ApiClient.Deserialize(response, typeof (List<Offer>)));
            }

            /// <summary>
            ///     Query an Offer
            /// </summary>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>QueryResponseBody</returns>
            public QueryResponseBody QueryOffer(string databaseaccount, QuerySql request, string authorization,
                string xMsDate, string xMsVersion, string contentType, bool? xMsDocumentdbQueryEnableScan,
                bool? xMsDocumentdbIsquery, string userAgent = null)
            {
                var response = QueryOfferWithHttpInfo(databaseaccount, request, authorization, xMsDate, xMsVersion,
                    contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Query an Offer
            /// </summary>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>ApiResponse of QueryResponseBody</returns>
            public ApiResponse<QueryResponseBody> QueryOfferWithHttpInfo(string databaseaccount, QuerySql request,
                string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string userAgent = null)
            {
                // verify the required parameter 'databaseaccount' is set
                if (databaseaccount == null)
                    throw new ApiException(400, "Missing required parameter 'databaseaccount' when calling QueryOffer");

                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling QueryOffer");

                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling QueryOffer");

                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling QueryOffer");

                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling QueryOffer");

                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400, "Missing required parameter 'contentType' when calling QueryOffer");

                // verify the required parameter 'xMsDocumentdbQueryEnableScan' is set
                if (xMsDocumentdbQueryEnableScan == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbQueryEnableScan' when calling QueryOffer");

                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryOffer");


                var path = "/{databaseaccount}.documents.azure.com/offers";

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
                if (databaseaccount != null)
                    pathParams.Add("databaseaccount", Configuration.ApiClient.ParameterToString(databaseaccount));
                        // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
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
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (xMsDocumentdbQueryEnableScan != null)
                    headerParams.Add("x-ms-documentdb-query-enable-scan",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbQueryEnableScan)); // header parameter
                if (xMsDocumentdbIsquery != null)
                    headerParams.Add("x-ms-documentdb-isquery",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbIsquery)); // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        Configuration.ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams,
                            formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling QueryOffer: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryOffer: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResponseBody) Configuration.ApiClient.Deserialize(response, typeof (QueryResponseBody)));
            }

            /// <summary>
            ///     Query an Offer
            /// </summary>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of QueryResponseBody</returns>
            public async Task<QueryResponseBody> QueryOfferAsync(string databaseaccount, QuerySql request,
                string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string userAgent = null)
            {
                var response =
                    await
                        QueryOfferAsyncWithHttpInfo(databaseaccount, request, authorization, xMsDate, xMsVersion,
                            contentType, xMsDocumentdbQueryEnableScan, xMsDocumentdbIsquery, userAgent);
                return response.Data;
            }

            /// <summary>
            ///     Query an Offer
            /// </summary>
            /// <param name="databaseaccount">The Database Account Name</param>
            /// <param name="request"></param>
            /// <param name="authorization">
            ///     The authentication type and signature token. Both master key and resource tokens are
            ///     allowed for this operation. example: &lt;c&gt;type={typeoftoken}%26ver={tokenversion}%26sig={hashsignature}&lt;/c
            ///     &gt;
            /// </param>
            /// <param name="xMsDate">
            ///     The date of the request The date is expressed in Coordinated Universal Time format. example: &lt;
            ///     example&gt;Fri, 08 Apr 2015 03:52:31 GMT&lt;/example&gt;
            /// </param>
            /// <param name="xMsVersion">
            ///     The version of DocumentDB REST service. The latest version is used when the header is not
            ///     provided use 2015-08-06
            /// </param>
            /// <param name="contentType">Required. The Content-Type header must be application/json.</param>
            /// <param name="xMsDocumentdbQueryEnableScan"></param>
            /// <param name="xMsDocumentdbIsquery"></param>
            /// <param name="userAgent">
            ///     Optional. The string of client user agent performing the request. The recommended format is
            ///     &lt;code{user agent name}/{version}&lt;/c&gt;.
            /// </param>
            /// <returns>Task of ApiResponse (QueryResponseBody)</returns>
            public async Task<ApiResponse<QueryResponseBody>> QueryOfferAsyncWithHttpInfo(string databaseaccount,
                QuerySql request, string authorization, string xMsDate, string xMsVersion, string contentType,
                bool? xMsDocumentdbQueryEnableScan, bool? xMsDocumentdbIsquery, string userAgent = null)
            {
                // verify the required parameter 'databaseaccount' is set
                if (databaseaccount == null)
                    throw new ApiException(400, "Missing required parameter 'databaseaccount' when calling QueryOffer");
                // verify the required parameter 'request' is set
                if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling QueryOffer");
                // verify the required parameter 'authorization' is set
                if (authorization == null)
                    throw new ApiException(400, "Missing required parameter 'authorization' when calling QueryOffer");
                // verify the required parameter 'xMsDate' is set
                if (xMsDate == null)
                    throw new ApiException(400, "Missing required parameter 'xMsDate' when calling QueryOffer");
                // verify the required parameter 'xMsVersion' is set
                if (xMsVersion == null)
                    throw new ApiException(400, "Missing required parameter 'xMsVersion' when calling QueryOffer");
                // verify the required parameter 'contentType' is set
                if (contentType == null)
                    throw new ApiException(400, "Missing required parameter 'contentType' when calling QueryOffer");
                // verify the required parameter 'xMsDocumentdbQueryEnableScan' is set
                if (xMsDocumentdbQueryEnableScan == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbQueryEnableScan' when calling QueryOffer");
                // verify the required parameter 'xMsDocumentdbIsquery' is set
                if (xMsDocumentdbIsquery == null)
                    throw new ApiException(400,
                        "Missing required parameter 'xMsDocumentdbIsquery' when calling QueryOffer");


                var path = "/{databaseaccount}.documents.azure.com/offers";

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
                if (databaseaccount != null)
                    pathParams.Add("databaseaccount", Configuration.ApiClient.ParameterToString(databaseaccount));
                        // path parameter


                if (authorization != null)
                    headerParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization));
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
                if (contentType != null)
                    headerParams.Add("Content-Type", Configuration.ApiClient.ParameterToString(contentType));
                        // header parameter
                if (xMsDocumentdbQueryEnableScan != null)
                    headerParams.Add("x-ms-documentdb-query-enable-scan",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbQueryEnableScan)); // header parameter
                if (xMsDocumentdbIsquery != null)
                    headerParams.Add("x-ms-documentdb-isquery",
                        Configuration.ApiClient.ParameterToString(xMsDocumentdbIsquery)); // header parameter


                postBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter


                // make the HTTP request
                var response =
                    (IRestResponse)
                        await
                            Configuration.ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams,
                                formParams, fileParams, pathParams);

                var statusCode = (int) response.StatusCode;

                if (statusCode >= 400)
                    throw new ApiException(statusCode, "Error calling QueryOffer: " + response.Content, response.Content);
                if (statusCode == 0)
                    throw new ApiException(statusCode, "Error calling QueryOffer: " + response.ErrorMessage,
                        response.ErrorMessage);

                return new ApiResponse<QueryResponseBody>(statusCode,
                    response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (QueryResponseBody) Configuration.ApiClient.Deserialize(response, typeof (QueryResponseBody)));
            }

            /// <summary>
            ///     Gets the base path of the API client.
            /// </summary>
            /// <value>The base path</value>
            public string GetBasePath()
            {
                return Configuration.ApiClient.RestClient.BaseUrl.ToString();
            }

        }
    }
}