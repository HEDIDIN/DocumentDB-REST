using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     As documents are added to a collection, DocumentDB by default automatically indexes the documents, thus allowing
    ///     documents to be queried. It is at the collection level that you configure the indexing policy. Since indexing
    ///     policy is set at the collection level, each collection within a database can have different indexing policies.
    /// </summary>
   
    public class IndexingPolicy : IEquatable<IndexingPolicy>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="IndexingPolicy" /> class.
        /// </summary>
        public IndexingPolicy()
        {
            Automatic = true;
        }


        /// <summary>
        ///     True indicates that automatic indexing is on; otherwise, False.\nThe default value is True, thus all documents are
        ///     indexed by default. Documents can be excluded by specifying the x-ms-indexingdirective header value to
        ///     “Exclude”.\nSetting the value to False allows no documents are indexed. Documents can be included by specifying the
        ///     x-ms-indexingdirective header value to “Include”.
        /// </summary>
        /// <value>
        ///     True indicates that automatic indexing is on; otherwise, False.\nThe default value is True, thus all documents
        ///     are indexed by default. Documents can be excluded by specifying the x-ms-indexingdirective header value to
        ///     “Exclude”.\nSetting the value to False allows no documents are indexed. Documents can be included by specifying the
        ///     x-ms-indexingdirective header value to “Include”.
        /// </value>
        public bool? Automatic { get; set; }


        /// <summary>
        ///     By default, the indexing mode is consistent. This means that indexing occurs synchronously during insertion,
        ///     replacement or deletion of documents, and queries are served at the same consistency level as configured in the
        ///     request.\nTo have indexing occur asynchronously, set the indexing mode to lazy. With lazy indexing, the index is
        ///     updated when the collection is operating below its request units per second capacity.
        /// </summary>
        /// <value>
        ///     By default, the indexing mode is consistent. This means that indexing occurs synchronously during insertion,
        ///     replacement or deletion of documents, and queries are served at the same consistency level as configured in the
        ///     request.\nTo have indexing occur asynchronously, set the indexing mode to lazy. With lazy indexing, the index is
        ///     updated when the collection is operating below its request units per second capacity.
        /// </value>
        public List<string> IndexingMode { get; set; }


        /// <summary>
        ///     The array containing the document paths to be indexed. All properties are user settable.
        /// </summary>
        /// <value>The array containing the document paths to be indexed. All properties are user settable.</value>
        public string IncludePaths { get; set; }


        /// <summary>
        ///     The acceptable values are Hash or Range. Hash indexes are useful for equality comparisons while Range indexes are
        ///     useful for range comparison. At the moment, range indexes can only be used for numeric values.  The default value
        ///     is Hash for document paths and Range for a _ts path.
        /// </summary>
        /// <value>
        ///     The acceptable values are Hash or Range. Hash indexes are useful for equality comparisons while Range indexes
        ///     are useful for range comparison. At the moment, range indexes can only be used for numeric values.  The default
        ///     value is Hash for document paths and Range for a _ts path.
        /// </value>
        public string IndexType { get; set; }


        /// <summary>
        ///     The acceptable values are 1 to 7. The default value is 3. This is the byte precision value for numeric values. The
        ///     higher this value is set, the lower the probability of term collision, resulting in a faster and more accurate
        ///     comparison. However, the higher the value the greater the storage overhead.
        /// </summary>
        /// <value>
        ///     The acceptable values are 1 to 7. The default value is 3. This is the byte precision value for numeric values.
        ///     The higher this value is set, the lower the probability of term collision, resulting in a faster and more accurate
        ///     comparison. However, the higher the value the greater the storage overhead.
        /// </value>
        public int? NumericPrecision { get; set; }


        /// <summary>
        ///     The acceptable values are 1 to 7. The default value is 3. This is the byte precision value for strings. The higher
        ///     this value is set, the lower the probability of term collision, resulting in a faster and more accurate comparison.
        ///     However, the higher the value the greater the storage overhead.
        /// </summary>
        /// <value>
        ///     The acceptable values are 1 to 7. The default value is 3. This is the byte precision value for strings. The
        ///     higher this value is set, the lower the probability of term collision, resulting in a faster and more accurate
        ///     comparison. However, the higher the value the greater the storage overhead.
        /// </value>
        public int? StringPrecision { get; set; }


        /// <summary>
        ///     The accepted value is a valid document path including wildcards value of ? and *.
        /// </summary>
        /// <value>The accepted value is a valid document path including wildcards value of ? and *.</value>
        public string Path { get; set; }


        /// <summary>
        ///     The array containing the document paths to be excluded from indexing. All properties are user settable.
        /// </summary>
        /// <value>The array containing the document paths to be excluded from indexing. All properties are user settable.</value>
        public ExcludePaths ExcludePaths { get; set; }

        /// <summary>
        ///     Returns true if IndexingPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of IndexingPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexingPolicy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Automatic == other.Automatic ||
                    Automatic != null &&
                    Automatic.Equals(other.Automatic)
                    ) &&
                (
                    IndexingMode == other.IndexingMode ||
                    IndexingMode != null &&
                    IndexingMode.SequenceEqual(other.IndexingMode)
                    ) &&
                (
                    IncludePaths == other.IncludePaths ||
                    IncludePaths != null &&
                    IncludePaths.Equals(other.IncludePaths)
                    ) &&
                (
                    IndexType == other.IndexType ||
                    IndexType != null &&
                    IndexType.Equals(other.IndexType)
                    ) &&
                (
                    NumericPrecision == other.NumericPrecision ||
                    NumericPrecision != null &&
                    NumericPrecision.Equals(other.NumericPrecision)
                    ) &&
                (
                    StringPrecision == other.StringPrecision ||
                    StringPrecision != null &&
                    StringPrecision.Equals(other.StringPrecision)
                    ) &&
                (
                    Path == other.Path ||
                    Path != null &&
                    Path.Equals(other.Path)
                    ) &&
                (
                    ExcludePaths == other.ExcludePaths ||
                    ExcludePaths != null &&
                    ExcludePaths.Equals(other.ExcludePaths)
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndexingPolicy {\n");
            sb.Append("  Automatic: ").Append(Automatic).Append("\n");
            sb.Append("  IndexingMode: ").Append(IndexingMode).Append("\n");
            sb.Append("  IncludePaths: ").Append(IncludePaths).Append("\n");
            sb.Append("  IndexType: ").Append(IndexType).Append("\n");
            sb.Append("  NumericPrecision: ").Append(NumericPrecision).Append("\n");
            sb.Append("  StringPrecision: ").Append(StringPrecision).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  ExcludePaths: ").Append(ExcludePaths).Append("\n");

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
            return Equals(obj as IndexingPolicy);
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

                if (Automatic != null)
                    hash = hash*57 + Automatic.GetHashCode();

                if (IndexingMode != null)
                    hash = hash*57 + IndexingMode.GetHashCode();

                if (IncludePaths != null)
                    hash = hash*57 + IncludePaths.GetHashCode();

                if (IndexType != null)
                    hash = hash*57 + IndexType.GetHashCode();

                if (NumericPrecision != null)
                    hash = hash*57 + NumericPrecision.GetHashCode();

                if (StringPrecision != null)
                    hash = hash*57 + StringPrecision.GetHashCode();

                if (Path != null)
                    hash = hash*57 + Path.GetHashCode();

                if (ExcludePaths != null)
                    hash = hash*57 + ExcludePaths.GetHashCode();

                return hash;
            }
        }
    }
}