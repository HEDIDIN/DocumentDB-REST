using System;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    /// </summary>
   
    public class QuerySql : IEquatable<QuerySql>
    {
        /// <summary>
        ///     The value of this property the SQL statement to be executed.
        /// </summary>
        /// <value>The value of this property the SQL statement to be executed.</value>
        public string Query { get; set; }

        /// <summary>
        ///     Returns true if QuerySql instances are equal
        /// </summary>
        /// <param name="other">Instance of QuerySql to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuerySql other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                Query == other.Query ||
                Query != null &&
                Query.Equals(other.Query);
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuerySql {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");

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
            return Equals(obj as QuerySql);
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

                if (Query != null)
                    hash = hash*57 + Query.GetHashCode();

                return hash;
            }
        }
    }
}