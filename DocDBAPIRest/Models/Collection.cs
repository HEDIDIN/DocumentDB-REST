using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     A collection is a container of JSON documents and associated JavaScript application logic, i.e. stored procedures,
    ///     triggers and user-defined functions
    /// </summary>
   
    public class Collection : IEquatable<Collection>
    {
        /// <summary>
        ///     This is a user settable property. It is the unique name that identifies a collection, i.e. no two collections share
        ///     the same id. The id must not exceed 255 characters.
        /// </summary>
        /// <value>
        ///     This is a user settable property. It is the unique name that identifies a collection, i.e. no two collections
        ///     share the same id. The id must not exceed 255 characters.
        /// </value>
        
        public string Id { get; set; }


        /// <summary>
        ///     This is a system generated property. The resource ID (_rid) is a unique identifier that is also hierarchical per
        ///     the resource stack on the resource model. It is used internally for placement and navigation of the collection
        ///     resource.
        /// </summary>
        /// <value>
        ///     This is a system generated property. The resource ID (_rid) is a unique identifier that is also hierarchical per
        ///     the resource stack on the resource model. It is used internally for placement and navigation of the collection
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
      
        public string Ts { get; set; }


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
        ///     This is a system generated property that specifies the addressable path of the documents resource.
        /// </summary>
        /// <value>This is a system generated property that specifies the addressable path of the documents resource.</value>
        public string Doc { get; set; }


        /// <summary>
        ///     This is a system generated property that specifies the addressable path of the stored procedures (sprocs) resource.
        /// </summary>
        /// <value>
        ///     This is a system generated property that specifies the addressable path of the stored procedures (sprocs)
        ///     resource.
        /// </value>
        public string Sprocs { get; set; }


        /// <summary>
        ///     This is a system generated property that specifies the addressable path of the triggers resource
        /// </summary>
        /// <value>This is a system generated property that specifies the addressable path of the triggers resource</value>
        public string Triggers { get; set; }


        /// <summary>
        ///     This is a system generated property that specifies the addressable path of the user-defined functions (udfs)
        ///     resource.
        /// </summary>
        /// <value>
        ///     This is a system generated property that specifies the addressable path of the user-defined functions (udfs)
        ///     resource.
        /// </value>
        public string Udfs { get; set; }


        /// <summary>
        ///     This is a system generated property that specifies the addressable path of the conflicts resource. During an
        ///     operation on a resource within a collection, if a conflict occurs, users can inspect the conflicting resources by
        ///     performing a GET on the conflicts URI path.
        /// </summary>
        /// <value>
        ///     This is a system generated property that specifies the addressable path of the conflicts resource. During an
        ///     operation on a resource within a collection, if a conflict occurs, users can inspect the conflicting resources by
        ///     performing a GET on the conflicts URI path.
        /// </value>
        public string Conflicts { get; set; }


        /// <summary>
        ///     This is the indexing policy setting for the collection. All properties in the indexingPolicy are user settable.
        /// </summary>
        /// <value>This is the indexing policy setting for the collection. All properties in the indexingPolicy are user settable.</value>
        public IndexingPolicy IndexingPolicy { get; set; }

        /// <summary>
        ///     Returns true if Collection instances are equal
        /// </summary>
        /// <param name="other">Instance of Collection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Collection other)
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
                    Doc == other.Doc ||
                    Doc != null &&
                    Doc.Equals(other.Doc)
                    ) &&
                (
                    Sprocs == other.Sprocs ||
                    Sprocs != null &&
                    Sprocs.Equals(other.Sprocs)
                    ) &&
                (
                    Triggers == other.Triggers ||
                    Triggers != null &&
                    Triggers.Equals(other.Triggers)
                    ) &&
                (
                    Udfs == other.Udfs ||
                    Udfs != null &&
                    Udfs.Equals(other.Udfs)
                    ) &&
                (
                    Conflicts == other.Conflicts ||
                    Conflicts != null &&
                    Conflicts.Equals(other.Conflicts)
                    ) &&
                (
                    IndexingPolicy == other.IndexingPolicy ||
                    IndexingPolicy != null &&
                    IndexingPolicy.Equals(other.IndexingPolicy)
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Collection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Doc: ").Append(Doc).Append("\n");
            sb.Append("  Sprocs: ").Append(Sprocs).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  Udfs: ").Append(Udfs).Append("\n");
            sb.Append("  Conflicts: ").Append(Conflicts).Append("\n");
            sb.Append("  IndexingPolicy: ").Append(IndexingPolicy).Append("\n");

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
            return Equals(obj as Collection);
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

                if (Doc != null)
                    hash = hash*57 + Doc.GetHashCode();

                if (Sprocs != null)
                    hash = hash*57 + Sprocs.GetHashCode();

                if (Triggers != null)
                    hash = hash*57 + Triggers.GetHashCode();

                if (Udfs != null)
                    hash = hash*57 + Udfs.GetHashCode();

                if (Conflicts != null)
                    hash = hash*57 + Conflicts.GetHashCode();

                if (IndexingPolicy != null)
                    hash = hash*57 + IndexingPolicy.GetHashCode();

                return hash;
            }
        }
    }
}