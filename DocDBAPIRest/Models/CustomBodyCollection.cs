using System;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    /// </summary>
   
    public class CustomBodyCollection : IEquatable<CustomBodyCollection>
    {
        /// <summary>
        ///     A JSON array of parameters specified as name value pairs.
        /// </summary>
        /// <value>A JSON array of parameters specified as name value pairs.</value>
        
        public string Id { get; set; }

        /// <summary>
        ///     Returns true if CustomBodyCollection instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomBodyCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomBodyCollection other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id);
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomBodyCollection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");

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
            return Equals(obj as CustomBodyCollection);
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

                if (Id != null)
                    hash = hash*57 + Id.GetHashCode();

                return hash;
            }
        }
    }
}