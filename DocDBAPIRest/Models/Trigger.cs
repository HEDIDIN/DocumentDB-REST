using System;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     Triggers are pieces of application logic that can executed before (pre-triggers) and after (post-triggers)
    ///     creation, deletion, and replacement of a document. Triggers are written in JavaScript. Both pre and post triggers
    ///     do no take parameters. Like stored procedures, triggers live within the confines of a collection, thus confining
    ///     the application logic to the collection
    /// </summary>
   
    public class Trigger : IEquatable<Trigger>
    {
        /// <summary>
        ///     Gets or Sets Id
        /// </summary>
        
        public string Id { get; set; }


        /// <summary>
        ///     This is a user settable property. This is the body of the Trigger
        /// </summary>
        /// <value>This is a user settable property. This is the body of the Trigger</value>
        
        public string Body { get; set; }


        /// <summary>
        ///     This is the type of operation that will invoke the trigger. The acceptable values are: All, Insert, Replace and
        ///     Delete.
        /// </summary>
        /// <value>
        ///     This is the type of operation that will invoke the trigger. The acceptable values are: All, Insert, Replace and
        ///     Delete.
        /// </value>
       
        public string TriggerOperation { get; set; }


        /// <summary>
        ///     This specifies when the trigger will be fired. The acceptable values are: Pre and Post. Pre triggers fire before an
        ///     operation while Post triggers after an operation.
        /// </summary>
        /// <value>
        ///     This specifies when the trigger will be fired. The acceptable values are: Pre and Post. Pre triggers fire before
        ///     an operation while Post triggers after an operation.
        /// </value>
       
        public string TriggerType { get; set; }


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
        ///     Returns true if Trigger instances are equal
        /// </summary>
        /// <param name="other">Instance of Trigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trigger other)
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
                    TriggerOperation == other.TriggerOperation ||
                    TriggerOperation != null &&
                    TriggerOperation.Equals(other.TriggerOperation)
                    ) &&
                (
                    TriggerType == other.TriggerType ||
                    TriggerType != null &&
                    TriggerType.Equals(other.TriggerType)
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
            sb.Append("class Trigger {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  TriggerOperation: ").Append(TriggerOperation).Append("\n");
            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
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
            return Equals(obj as Trigger);
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

                if (TriggerOperation != null)
                    hash = hash*57 + TriggerOperation.GetHashCode();

                if (TriggerType != null)
                    hash = hash*57 + TriggerType.GetHashCode();

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