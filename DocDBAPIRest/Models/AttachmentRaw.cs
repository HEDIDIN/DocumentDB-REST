using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     POST the raw media in the body payload to store it in the provided attachment storage under your DocumentDB
    ///     account.  To create this type of attachment, developers include the raw attachment (video, audio, file, blob, etc.)
    ///     as the body of the POST. Two headers must be set: `Content-Type` and `Slug`. The Content-Type header is set to the
    ///     MIME type of the attachment while the Slug header is set to the name of the attachment.
    /// </summary>
   
    public class AttachmentRaw : IEquatable<AttachmentRaw>
    {
        /// <summary>
        ///     The content type of the attachment.
        /// </summary>
        /// <value>The content type of the attachment.</value>
        public string ContentType { get; set; }


        /// <summary>
        ///     The name of the attachment
        /// </summary>
        /// <value>The name of the attachment</value>
        public string Slug { get; set; }


        /// <summary>
        ///     The client user agent performing the request
        /// </summary>
        /// <value>The client user agent performing the request</value>
        public string UserAgent { get; set; }


        /// <summary>
        ///     This is the attachment name and type.
        /// </summary>
        /// <value>This is the attachment name and type.</value>
        
        public string Id { get; set; }


        /// <summary>
        ///     This is a system generated property.
        /// </summary>
        /// <value>This is a system generated property.</value>
        
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
        ///     This is a system generated property denoting the addressable path of the feed of permissions resource.
        /// </summary>
        /// <value>This is a system generated property denoting the addressable path of the feed of permissions resource.</value>
        
        public string Permissions { get; set; }

        /// <summary>
        ///     Returns true if AttachmentRaw instances are equal
        /// </summary>
        /// <param name="other">Instance of AttachmentRaw to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentRaw other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    ContentType == other.ContentType ||
                    ContentType != null &&
                    ContentType.Equals(other.ContentType)
                    ) &&
                (
                    Slug == other.Slug ||
                    Slug != null &&
                    Slug.Equals(other.Slug)
                    ) &&
                (
                    UserAgent == other.UserAgent ||
                    UserAgent != null &&
                    UserAgent.Equals(other.UserAgent)
                    ) &&
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
                    Permissions == other.Permissions ||
                    Permissions != null &&
                    Permissions.Equals(other.Permissions)
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentRaw {\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");

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
            return Equals(obj as AttachmentRaw);
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

                if (ContentType != null)
                    hash = hash*57 + ContentType.GetHashCode();

                if (Slug != null)
                    hash = hash*57 + Slug.GetHashCode();

                if (UserAgent != null)
                    hash = hash*57 + UserAgent.GetHashCode();

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

                if (Permissions != null)
                    hash = hash*57 + Permissions.GetHashCode();

                return hash;
            }
        }
    }
}