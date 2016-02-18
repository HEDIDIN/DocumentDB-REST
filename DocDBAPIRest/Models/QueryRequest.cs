using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace DocDBAPIRest.Models
{
    /// <summary>
    ///     Perform a SQL query on a resource
    /// </summary>
   
    public class QueryRequest : IEquatable<QueryRequest>
    {
        /// <summary>
        ///     The SQL query string for the query
        /// </summary>
        /// <value>The SQL query string for the query</value>
        public string Query { get; set; }


        /// <summary>
        ///     A JSON array of parameters specified as name value pairs. The parameter array can contain from zero to many
        ///     parameters.Each parameter must have the following values:name: the name of the parameter. Parameter names must be
        ///     valid string literals and begin with ‘@’.value: the value of the parameter. Can be any valid JSON value (string,
        ///     number, object, array, Boolean or null).
        /// </summary>
        /// <value>
        ///     A JSON array of parameters specified as name value pairs. The parameter array can contain from zero to many
        ///     parameters.Each parameter must have the following values:name: the name of the parameter. Parameter names must be
        ///     valid string literals and begin with ‘@’.value: the value of the parameter. Can be any valid JSON value (string,
        ///     number, object, array, Boolean or null).
        /// </value>
        public List<string> Parameters { get; set; }

        /// <summary>
        ///     Returns true if QueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    Query == other.Query ||
                    Query != null &&
                    Query.Equals(other.Query)
                    ) &&
                (
                    Parameters == other.Parameters ||
                    Parameters != null &&
                    Parameters.SequenceEqual(other.Parameters)
                    );
        }


        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRequest {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");

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
            return Equals(obj as QueryRequest);
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

                if (Query != null)
                    hash = hash*57 + Query.GetHashCode();

                if (Parameters != null)
                    hash = hash*57 + Parameters.GetHashCode();

                return hash;
            }
        }
    }
}