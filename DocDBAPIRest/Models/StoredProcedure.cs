using System;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     A stored procedure is a piece of application logic written in JavaScript that is registered and executed against a
    ///     collection as a single transaction.
    /// </summary>
   
    public class StoredProcedure : IEquatable<StoredProcedure>
    {
        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        
        public string Id { get; set; }


        /// <summary>
        ///     This is the body of the stored procedure.
        /// </summary>
        /// <value>This is the body of the stored procedure.</value>
        
        public string Body { get; set; }


        /// <summary>
        ///     Gets or Sets Rid
        /// </summary>
        
        public string Rid { get; set; }


        /// <summary>
        ///     This is a system generated property. It specifies the last updated timestamp of the resource. The value is a
        ///     timestamp.
        /// </summary>
        /// <value>
        ///     This is a system generated property. It specifies the last updated timestamp of the resource. The value is a
        ///     timestamp.
        /// </value>
      
        public string Ts { get; set; }


        /// <summary>
        ///     This is a system generated property.
        /// </summary>
        /// <value>This is a system generated property.</value>
       
        public string Self { get; set; }


        /// <summary>
        ///     This is a system generated property representing the resource etag required for optimistic concurrency control.
        /// </summary>
        /// <value>This is a system generated property representing the resource etag required for optimistic concurrency control.</value>
       
        public string Etag { get; set; }

        /// <summary>
        ///     Returns true if StoredProcedure instances are equal
        /// </summary>
        /// <param name="other">Instance of StoredProcedure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredProcedure other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                    ) &&
                (
                    Body == other.Body ||
                    Body != null &&
                    Body.Equals(other.Body)
                    ) &&
                (
                    Rid == other.Rid ||
                    Rid != null &&
                    Rid.Equals(other.Rid)
                    ) &&
                (
                    Ts == other.Ts ||
                    Ts != null &&
                    Ts.Equals(other.Ts)
                    ) &&
                (
                    Self == other.Self ||
                    Self != null &&
                    Self.Equals(other.Self)
                    ) &&
                (
                    Etag == other.Etag ||
                    Etag != null &&
                    Etag.Equals(other.Etag)
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoredProcedure {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");

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
            return Equals(obj as StoredProcedure);
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

                if (Body != null)
                    hash = hash*57 + Body.GetHashCode();

                if (Rid != null)
                    hash = hash*57 + Rid.GetHashCode();

                if (Ts != null)
                    hash = hash*57 + Ts.GetHashCode();

                if (Self != null)
                    hash = hash*57 + Self.GetHashCode();

                if (Etag != null)
                    hash = hash*57 + Etag.GetHashCode();

                return hash;
            }
        }
    }
}