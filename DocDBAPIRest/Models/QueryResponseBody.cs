using System;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     The response body for the query operation consists of the _rid of the parent resource of the resource being
    ///     queried, and the resource array containing the resource properties for the projection and selection
    /// </summary>
   
    public class QueryResponseBody : IEquatable<QueryResponseBody>
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
        ///     Returns true if QueryResponseBody instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryResponseBody other)
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
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryResponseBody {\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  ResourceArray: ").Append(ResourceArray).Append("\n");

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
            return Equals(obj as QueryResponseBody);
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

                return hash;
            }
        }
    }
}