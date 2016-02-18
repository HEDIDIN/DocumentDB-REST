using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     The document resource is represented by docs in the DocumentDB resource model. A document consists of user-defined
    ///     content in JSON format. Aside from the required id property, users can define any arbitrary elements, structures,
    ///     and hierarchies for the content. The id element is a unique string that is user-settable and must not exceed 255
    ///     characters.
    /// </summary>
   
    public class Document : IEquatable<Document>
    {
        /// <summary>
        ///     This is a user settable property. It is the unique name that identifies the document, i.e. no two documents will
        ///     share the same id within a database. The id must not exceed 255 characters.
        /// </summary>
        /// <value>
        ///     This is a user settable property. It is the unique name that identifies the document, i.e. no two documents will
        ///     share the same id within a database. The id must not exceed 255 characters.
        /// </value>
        
        public string Id { get; set; }


        /// <summary>
        ///     This is a system generated property. The resource ID (_rid) is a unique identifier that is also hierarchical per
        ///     the resource stack on the resource model. It is used internally for placement and navigation of the document
        ///     resource.
        /// </summary>
        /// <value>
        ///     This is a system generated property. The resource ID (_rid) is a unique identifier that is also hierarchical per
        ///     the resource stack on the resource model. It is used internally for placement and navigation of the document
        ///     resource.
        /// </value>
        
        public string Rid { get; set; }


        /// <summary>
        ///     This is a system generated property. It specifies the last updated timestamp of the resource. The value is a
        ///     timestamp.
        /// </summary>
        /// <value>
        ///     This is a system generated property. It specifies the last updated timestamp of the resource. The value is a
        ///     timestamp.
        /// </value>
      
        public int? Ts { get; set; }


        /// <summary>
        ///     This is a system generated property. It is the unique addressable URI for the resource.
        /// </summary>
        /// <value>This is a system generated property. It is the unique addressable URI for the resource.</value>
       
        public string Self { get; set; }


        /// <summary>
        ///     This is a system generated property that specifies the resource etag required for optimistic concurrency control.
        /// </summary>
        /// <value>
        ///     This is a system generated property that specifies the resource etag required for optimistic concurrency
        ///     control.
        /// </value>
       
        public string Etag { get; set; }


        /// <summary>
        ///     This is a system generated property that specifies the addressable path for the attachments resource.
        /// </summary>
        /// <value>This is a system generated property that specifies the addressable path for the attachments resource.</value>
        public string Attachments { get; set; }

        /// <summary>
        ///     Returns true if Document instances are equal
        /// </summary>
        /// <param name="other">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document other)
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
                    ) &&
                (
                    Attachments == other.Attachments ||
                    Attachments != null &&
                    Attachments.Equals(other.Attachments)
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");

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
            return Equals(obj as Document);
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

                if (Rid != null)
                    hash = hash*57 + Rid.GetHashCode();

                if (Ts != null)
                    hash = hash*57 + Ts.GetHashCode();

                if (Self != null)
                    hash = hash*57 + Self.GetHashCode();

                if (Etag != null)
                    hash = hash*57 + Etag.GetHashCode();

                if (Attachments != null)
                    hash = hash*57 + Attachments.GetHashCode();

                return hash;
            }
        }
    }
}