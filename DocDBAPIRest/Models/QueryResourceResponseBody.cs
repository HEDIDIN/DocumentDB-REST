using System;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     DocumentDB query executions are stateless at the server side, and can be resumed at any time using the
    ///     x-ms-continuation header. The &lt;c&gt;x-ms-continuation&lt;/c&gt; value uses the last processed document resource
    ///     ID &lt;c&gt;(_rid)&lt;/c&gt; to track progress of execution. Therefore if documents are deleted and re-inserted
    ///     between fetching of pages, then it could potentially be excluded from any of the query batches. &lt;remarks&gt;
    ///     However, the behavior and format of the x-ms-continuation header might change in a future service update.&lt;
    ///     /remarks&gt;
    /// </summary>
   
    public class QueryResourceResponseBody : IEquatable<QueryResourceResponseBody>
    {
        /// <summary>
        ///     The resource id for the collection used within the query
        /// </summary>
        /// <value>The resource id for the collection used within the query</value>
        
        public string Rid { get; set; }


        /// <summary>
        ///     The number of items returned.
        /// </summary>
        /// <value>The number of items returned.</value>
        public int? Count { get; set; }


        /// <summary>
        ///     The array containing the query results.
        /// </summary>
        /// <value>The array containing the query results.</value>
        public string ResourceArray { get; set; }


        /// <summary>
        ///     The date of the request The date is expressed in Coordinated Universal Time format.
        /// </summary>
        /// <value>The date of the request The date is expressed in Coordinated Universal Time format.</value>
        public string Date { get; set; }


        /// <summary>
        ///     The number of item returned by the operation.
        /// </summary>
        /// <value>The number of item returned by the operation.</value>
        public int? XMsItemCount { get; set; }


        /// <summary>
        ///     This is an opaque string returned when the query has potentially more items to be retrieved.
        ///     <para>
        ///         The x-ms-continuation can be included in subsequent requests as a request header to resume execution of the
        ///         query.
        ///     </para>
        ///     <para>
        ///         Clients can fetch subsequent pages of results by echoing the x-ms-continuation header as another request. In
        ///         order to read all results, clients must repeat this process until an empty x-ms-continuation is returned.
        ///     </para>
        /// </summary>
        /// <value>
        ///     This is an opaque string returned when the query has potentially more items to be retrieved.
        ///     <para>
        ///         The x-ms-continuation can be included in subsequent requests as a request header to resume execution of the
        ///         query.
        ///     </para>
        ///     <para>
        ///         Clients can fetch subsequent pages of results by echoing the x-ms-continuation header as another request. In
        ///         order to read all results, clients must repeat this process until an empty x-ms-continuation is returned.
        ///     </para>
        /// </value>
        public string XMsContinuation { get; set; }


        /// <summary>
        ///     This is the number of request units (RU) consumed by the operation
        /// </summary>
        /// <value>This is the number of request units (RU) consumed by the operation</value>
        public int? XMsRequestCharge { get; set; }


        /// <summary>
        ///     This is a unique identifier for the operation. It can be used for tracing execution of DocumentDB requests.
        /// </summary>
        /// <value>This is a unique identifier for the operation. It can be used for tracing execution of DocumentDB requests.</value>
        public string XMsActivityId { get; set; }


        /// <summary>
        ///     The session token to be used for subsequent requests. Used for session consistency
        /// </summary>
        /// <value>The session token to be used for subsequent requests. Used for session consistency</value>
        public string XMsSessionToken { get; set; }

        /// <summary>
        ///     Returns true if QueryResourceResponseBody instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryResourceResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryResourceResponseBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Rid == other.Rid ||
                    Rid != null &&
                    Rid.Equals(other.Rid)
                    ) &&
                (
                    Count == other.Count ||
                    Count != null &&
                    Count.Equals(other.Count)
                    ) &&
                (
                    ResourceArray == other.ResourceArray ||
                    ResourceArray != null &&
                    ResourceArray.Equals(other.ResourceArray)
                    ) &&
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                    ) &&
                (
                    XMsItemCount == other.XMsItemCount ||
                    XMsItemCount != null &&
                    XMsItemCount.Equals(other.XMsItemCount)
                    ) &&
                (
                    XMsContinuation == other.XMsContinuation ||
                    XMsContinuation != null &&
                    XMsContinuation.Equals(other.XMsContinuation)
                    ) &&
                (
                    XMsRequestCharge == other.XMsRequestCharge ||
                    XMsRequestCharge != null &&
                    XMsRequestCharge.Equals(other.XMsRequestCharge)
                    ) &&
                (
                    XMsActivityId == other.XMsActivityId ||
                    XMsActivityId != null &&
                    XMsActivityId.Equals(other.XMsActivityId)
                    ) &&
                (
                    XMsSessionToken == other.XMsSessionToken ||
                    XMsSessionToken != null &&
                    XMsSessionToken.Equals(other.XMsSessionToken)
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryResourceResponseBody {\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  ResourceArray: ").Append(ResourceArray).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  XMsItemCount: ").Append(XMsItemCount).Append("\n");
            sb.Append("  XMsContinuation: ").Append(XMsContinuation).Append("\n");
            sb.Append("  XMsRequestCharge: ").Append(XMsRequestCharge).Append("\n");
            sb.Append("  XMsActivityId: ").Append(XMsActivityId).Append("\n");
            sb.Append("  XMsSessionToken: ").Append(XMsSessionToken).Append("\n");

            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as QueryResourceResponseBody);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)

                if (Rid != null)
                    hash = hash*57 + Rid.GetHashCode();

                if (Count != null)
                    hash = hash*57 + Count.GetHashCode();

                if (ResourceArray != null)
                    hash = hash*57 + ResourceArray.GetHashCode();

                if (Date != null)
                    hash = hash*57 + Date.GetHashCode();

                if (XMsItemCount != null)
                    hash = hash*57 + XMsItemCount.GetHashCode();

                if (XMsContinuation != null)
                    hash = hash*57 + XMsContinuation.GetHashCode();

                if (XMsRequestCharge != null)
                    hash = hash*57 + XMsRequestCharge.GetHashCode();

                if (XMsActivityId != null)
                    hash = hash*57 + XMsActivityId.GetHashCode();

                if (XMsSessionToken != null)
                    hash = hash*57 + XMsSessionToken.GetHashCode();

                return hash;
            }
        }
    }
}