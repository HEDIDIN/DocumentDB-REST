using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     The array containing the document paths to be excluded from indexing.
    /// </summary>
   
    public class ExcludePaths : IEquatable<ExcludePaths>
    {
        /// <summary>
        ///     The accepted value is a valid document path including wildcards values of ? and *.
        /// </summary>
        /// <value>The accepted value is a valid document path including wildcards values of ? and *.</value>
        public string Path { get; set; }

        /// <summary>
        ///     Returns true if ExcludePaths instances are equal
        /// </summary>
        /// <param name="other">Instance of ExcludePaths to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExcludePaths other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                Path == other.Path ||
                Path != null &&
                Path.Equals(other.Path);
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExcludePaths {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");

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
            return Equals(obj as ExcludePaths);
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

                if (Path != null)
                    hash = hash*57 + Path.GetHashCode();

                return hash;
            }
        }
    }
}