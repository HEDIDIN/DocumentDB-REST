using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    /// </summary>
   
    public class CustomBody : IEquatable<CustomBody>
    {
        /// <summary>
        ///     A JSON array of parameters specified as name value pairs.
        /// </summary>
        /// <value>A JSON array of parameters specified as name value pairs.</value>
        public string Custom { get; set; }

        /// <summary>
        ///     Returns true if CustomBody instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                Custom == other.Custom ||
                Custom != null &&
                Custom.Equals(other.Custom);
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomBody {\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");

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
            return Equals(obj as CustomBody);
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

                if (Custom != null)
                    hash = hash*57 + Custom.GetHashCode();

                return hash;
            }
        }
    }
}