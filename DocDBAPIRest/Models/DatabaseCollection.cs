using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    /// </summary>
   
    public class DatabaseCollection : IEquatable<DatabaseCollection>
    {
        /// <summary>
        ///     The user generated unique name for the database. This is a string that must not be more than 255 characters.
        /// </summary>
        /// <value>The user generated unique name for the database. This is a string that must not be more than 255 characters.</value>
        
        public string Id { get; set; }


        /// <summary>
        ///     This is a system generated property. The resource id (_rid) is a unique identifier that is also hierarchical per
        ///     the resource stack on the resource model. It is used internally for placement of and navigation to the database
        ///     resource.
        /// </summary>
        /// <value>
        ///     This is a system generated property. The resource id (_rid) is a unique identifier that is also hierarchical per
        ///     the resource stack on the resource model. It is used internally for placement of and navigation to the database
        ///     resource.
        /// </value>
        
        public string Rid { get; set; }


        /// <summary>
        ///     This the array containing the databases returned as part of the list operation.
        /// </summary>
        /// <value>This the array containing the databases returned as part of the list operation.</value>
        public List<Database> Databases { get; set; }


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
        ///     This is a system generated property. It is the unique addressable URI for the resource.
        /// </summary>
        /// <value>This is a system generated property. It is the unique addressable URI for the resource.</value>
       
        public string Self { get; set; }


        /// <summary>
        ///     This is a system generated property representing the resource etag required for optimistic concurrency control.
        /// </summary>
        /// <value>This is a system generated property representing the resource etag required for optimistic concurrency control.</value>
       
        public string Etag { get; set; }


        /// <summary>
        ///     This is a system generated property that specifies the addressable path of the collections resource.
        /// </summary>
        /// <value>This is a system generated property that specifies the addressable path of the collections resource.</value>
        public string Colls { get; set; }


        /// <summary>
        ///     This is a system generated property that specifies the addressable path of the users resource.
        /// </summary>
        /// <value>This is a system generated property that specifies the addressable path of the users resource.</value>
        public string Users { get; set; }

        /// <summary>
        ///     Returns true if DatabaseCollection instances are equal
        /// </summary>
        /// <param name="other">Instance of DatabaseCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseCollection other)
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
                    Databases == other.Databases ||
                    Databases != null &&
                    Databases.SequenceEqual(other.Databases)
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
                    Colls == other.Colls ||
                    Colls != null &&
                    Colls.Equals(other.Colls)
                    ) &&
                (
                    Users == other.Users ||
                    Users != null &&
                    Users.Equals(other.Users)
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseCollection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");
            sb.Append("  Databases: ").Append(Databases).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Colls: ").Append(Colls).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");

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
            return Equals(obj as DatabaseCollection);
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

                if (Databases != null)
                    hash = hash*57 + Databases.GetHashCode();

                if (Ts != null)
                    hash = hash*57 + Ts.GetHashCode();

                if (Self != null)
                    hash = hash*57 + Self.GetHashCode();

                if (Etag != null)
                    hash = hash*57 + Etag.GetHashCode();

                if (Colls != null)
                    hash = hash*57 + Colls.GetHashCode();

                if (Users != null)
                    hash = hash*57 + Users.GetHashCode();

                return hash;
            }
        }
    }
}