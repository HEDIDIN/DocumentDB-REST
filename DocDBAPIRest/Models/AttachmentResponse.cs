using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     Attachments are special documents that contain references and associated metadata with an external blob or media
    ///     file.
    /// </summary>
   
    public class AttachmentResponse : IEquatable<AttachmentResponse>
    {
        /// <summary>
        ///     This is a user settable property. It is the unique name that identifies the attachment, i.e. no two attachments
        ///     share the same id. The id must not exceed 255 characters. The value set in Slug is recorded here
        /// </summary>
        /// <value>
        ///     This is a user settable property. It is the unique name that identifies the attachment, i.e. no two attachments
        ///     share the same id. The id must not exceed 255 characters. The value set in Slug is recorded here
        /// </value>
        
        public string Id { get; set; }


        /// <summary>
        ///     This is a user settable property. It specifies the content type of th  attachment.
        /// </summary>
        /// <value>This is a user settable property. It specifies the content type of th  attachment.</value>
        public string ContentType { get; set; }


        /// <summary>
        ///     This is the URL link or file path where the attachment resides.
        /// </summary>
        /// <value>This is the URL link or file path where the attachment resides.</value>
        public string Media { get; set; }


        /// <summary>
        ///     Gets or Sets Rid
        /// </summary>
        
        public string Rid { get; set; }


        /// <summary>
        ///     Gets or Sets Ts
        /// </summary>
      
        public string Ts { get; set; }


        /// <summary>
        ///     Gets or Sets Self
        /// </summary>
       
        public string Self { get; set; }


        /// <summary>
        ///     Gets or Sets Etag
        /// </summary>
       
        public string Etag { get; set; }

        /// <summary>
        ///     Returns true if AttachmentResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AttachmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentResponse other)
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
                    ContentType == other.ContentType ||
                    ContentType != null &&
                    ContentType.Equals(other.ContentType)
                    ) &&
                (
                    Media == other.Media ||
                    Media != null &&
                    Media.Equals(other.Media)
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
            sb.Append("class AttachmentResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
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
            return Equals(obj as AttachmentResponse);
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

                if (ContentType != null)
                    hash = hash*57 + ContentType.GetHashCode();

                if (Media != null)
                    hash = hash*57 + Media.GetHashCode();

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