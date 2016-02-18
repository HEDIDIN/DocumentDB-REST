using System.Collections.Generic;

namespace DocDBAPIRest
{
    /// <summary>
    ///     API Response
    /// </summary>
    public class ApiResponse<T>
    {
        /// <summary>
        ///     Initializes a new instance of the <see>
        ///         <cref>ApiResponse</cref>
        ///     </see>
        ///     class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="headers">Error message.</param>
        /// <param name="data">Data (parsed HTTP body)</param>
        public ApiResponse(int statusCode, IDictionary<string, string> headers, T data)
        {
            StatusCode = statusCode;
            Headers = headers;
            Data = data;
        }

        /// <summary>
        ///     Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        public int StatusCode { get; private set; }

        /// <summary>
        ///     Gets or sets the HTTP headers
        /// </summary>
        /// <value>HTTP headers</value>
        public IDictionary<string, string> Headers { get; private set; }

        /// <summary>
        ///     Gets or sets the data (parsed HTTP body)
        /// </summary>
        /// <value>The data.</value>
        public T Data { get; private set; }
    }
}