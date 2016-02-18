using System;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    /// </summary>
   
    public class ReplaceOffer : IEquatable<ReplaceOffer>
    {
        /// <summary>
        ///     This is a user settable property. The valid values are S1, S2 and S3. The value must be capitalized
        /// </summary>
        /// <value>This is a user settable property. The valid values are S1, S2 and S3. The value must be capitalized</value>
       
        public string OfferType { get; set; }


        /// <summary>
        ///     This must be the self-link of the collection associated to the offer resource
        /// </summary>
        /// <value>This must be the self-link of the collection associated to the offer resource</value>
        public string Resource { get; set; }


        /// <summary>
        ///     This must be the resource id of the collection associated to the offer resource. It cannot be changed. The resource
        ///     id must match collection _rid in the resource property.
        /// </summary>
        /// <value>
        ///     This must be the resource id of the collection associated to the offer resource. It cannot be changed. The
        ///     resource id must match collection _rid in the resource property.
        /// </value>
        public string OfferResourceId { get; set; }


        /// <summary>
        ///     The id for the offer resource. It has the same value as the _rid for the offer.
        /// </summary>
        /// <value>The id for the offer resource. It has the same value as the _rid for the offer.</value>
        
        public string Id { get; set; }


        /// <summary>
        ///     This is the resource id of the offer.
        /// </summary>
        /// <value>This is the resource id of the offer.</value>
        
        public string Rid { get; set; }

        /// <summary>
        ///     Returns true if ReplaceOffer instances are equal
        /// </summary>
        /// <param name="other">Instance of ReplaceOffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplaceOffer other)
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
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplaceOffer {\n");
            sb.Append("  OfferType: ").Append(OfferType).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  OfferResourceId: ").Append(OfferResourceId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rid: ").Append(Rid).Append("\n");

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
            return Equals(obj as ReplaceOffer);
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

                return hash;
            }
        }
    }
}