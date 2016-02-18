using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     A permission is an authorization token associated with a user for authorized access to a specific resource.
    /// </summary>
   
    public class Permission : IEquatable<Permission>
    {
        /// <summary>
        ///     This is a user settable property. It is the unique name that identifies the permission, i.e. no two permissions
        ///     will share the same id within a user. The id must not exceed 255 characters.
        /// </summary>
        /// <value>
        ///     This is a user settable property. It is the unique name that identifies the permission, i.e. no two permissions
        ///     will share the same id within a user. The id must not exceed 255 characters.
        /// </value>
        
        public string Id { get; set; }


        /// <summary>
        ///     The access mode on the resource for the user: All or Read. All provides read, write, and delete access to a
        ///     resource. Read restricts the user to read access on the resource.
        /// </summary>
        /// <value>
        ///     The access mode on the resource for the user: All or Read. All provides read, write, and delete access to a
        ///     resource. Read restricts the user to read access on the resource.
        /// </value>
        public List<string> PermissionMode { get; set; }


        /// <summary>
        ///     The full addressable path of the resource associated with the permission. For example,
        ///     dbs/ruJjAA==/colls/ruJjAM9UnAA=/.
        /// </summary>
        /// <value>
        ///     The full addressable path of the resource associated with the permission. For example,
        ///     dbs/ruJjAA==/colls/ruJjAM9UnAA=/.
        /// </value>
        public string Resource { get; set; }


        /// <summary>
        ///     This is a system generated property.
        /// </summary>
        /// <value>This is a system generated property.</value>
        
        public string Rid { get; set; }


        /// <summary>
        ///     This is a system generated property. It specifies the last updated timestamp of the resource. The value is a
        ///     timestamp
        /// </summary>
        /// <value>
        ///     This is a system generated property. It specifies the last updated timestamp of the resource. The value is a
        ///     timestamp
        /// </value>
      
        public string Ts { get; set; }


        /// <summary>
        ///     This is a system generated property.
        /// </summary>
        /// <value>This is a system generated property.</value>
       
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
        ///     This is a system generated resource token for the particular resource and user.
        /// </summary>
        /// <value>This is a system generated resource token for the particular resource and user.</value>
        public string Token { get; set; }

        /// <summary>
        ///     Returns true if Permission instances are equal
        /// </summary>
        /// <param name="other">Instance of Permission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permission other)
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
                    PermissionMode == other.PermissionMode ||
                    PermissionMode != null &&
                    PermissionMode.SequenceEqual(other.PermissionMode)
                    ) &&
                (
                    Resource == other.Resource ||
                    Resource != null &&
                    Resource.Equals(other.Resource)
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
                    Token == other.Token ||
                    Token != null &&
                    Token.Equals(other.Token)
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Permission {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PermissionMode: ").Append(PermissionMode).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");

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
            return Equals(obj as Permission);
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

                if (PermissionMode != null)
                    hash = hash*57 + PermissionMode.GetHashCode();

                if (Resource != null)
                    hash = hash*57 + Resource.GetHashCode();

                if (Rid != null)
                    hash = hash*57 + Rid.GetHashCode();

                if (Ts != null)
                    hash = hash*57 + Ts.GetHashCode();

                if (Self != null)
                    hash = hash*57 + Self.GetHashCode();

                if (Etag != null)
                    hash = hash*57 + Etag.GetHashCode();

                if (Token != null)
                    hash = hash*57 + Token.GetHashCode();

                return hash;
            }
        }
    }
}