using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     Each collection must be associated to an offer resource that dictates the performance level and storage preserved
    ///     for the collection. When a creating a collection, the header x-ms-offer-type can be used to set the offer type for
    ///     the collection, e.g. S1, S2 and S3. If the header is not set, S1 will be the default offer.
    /// </summary>
   
    public class Offer : IEquatable<Offer>
    {
        /// <summary>
        ///     This is a user settable property. The valid values are S1, S2 and S3. The value must be capitalized. For more
        ///     information on performance levels, please see DocumentDB performance levels.
        /// </summary>
        /// <value>
        ///     This is a user settable property. The valid values are S1, S2 and S3. The value must be capitalized. For more
        ///     information on performance levels, please see DocumentDB performance levels.
        /// </value>
        public string OfferType { get; set; }


        /// <summary>
        ///     . During creation of a collection, this property is automatically associated to the self link of collection
        ///     associated to the offer resource, i.e. dbs/pLJdAA==/colls/pLJdAOlEdgA=/.
        /// </summary>
        /// <value>
        ///     . During creation of a collection, this property is automatically associated to the self link of collection
        ///     associated to the offer resource, i.e. dbs/pLJdAA==/colls/pLJdAOlEdgA=/.
        /// </value>
        public string Resource { get; set; }


        /// <summary>
        ///     During creation of a collection, this property is automatically associated to the resource id, i.e. _rid of
        ///     collection associated to the offer resource. The resource id must match collection _rid in the resource property.
        ///     In the example above, the _rid for the collection is pLJdAOlEdgA=.
        /// </summary>
        /// <value>
        ///     During creation of a collection, this property is automatically associated to the resource id, i.e. _rid of
        ///     collection associated to the offer resource. The resource id must match collection _rid in the resource property.
        ///     In the example above, the _rid for the collection is pLJdAOlEdgA=.
        /// </value>
        public string OfferResourceId { get; set; }


        /// <summary>
        ///     This is a system generated property. The id for the offer resource is automatically generated when it is created.
        ///     It has the same value as the _rid for the offer.
        /// </summary>
        /// <value>
        ///     This is a system generated property. The id for the offer resource is automatically generated when it is
        ///     created. It has the same value as the _rid for the offer.
        /// </value>
        
        public string Id { get; set; }


        /// <summary>
        ///     This is a system generated property. The resource ID (_rid) is a unique identifier that is also hierarchical per
        ///     the resource stack on the resource model. It is used internally for placement and navigation of the offer
        /// </summary>
        /// <value>
        ///     This is a system generated property. The resource ID (_rid) is a unique identifier that is also hierarchical per
        ///     the resource stack on the resource model. It is used internally for placement and navigation of the offer
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
        ///     Returns true if Offer instances are equal
        /// </summary>
        /// <param name="other">Instance of Offer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Offer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    OfferType == other.OfferType ||
                    OfferType != null &&
                    OfferType.Equals(other.OfferType)
                    ) &&
                (
                    Resource == other.Resource ||
                    Resource != null &&
                    Resource.Equals(other.Resource)
                    ) &&
                (
                    OfferResourceId == other.OfferResourceId ||
                    OfferResourceId != null &&
                    OfferResourceId.Equals(other.OfferResourceId)
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
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Offer {\n");
            sb.Append("  OfferType: ").Append(OfferType).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  OfferResourceId: ").Append(OfferResourceId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return Equals(obj as Offer);
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

                if (OfferType != null)
                    hash = hash*57 + OfferType.GetHashCode();

                if (Resource != null)
                    hash = hash*57 + Resource.GetHashCode();

                if (OfferResourceId != null)
                    hash = hash*57 + OfferResourceId.GetHashCode();

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

                return hash;
            }
        }
    }
}