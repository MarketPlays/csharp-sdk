

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Intrinio.SDK.Client.SwaggerDateConverter;

namespace Intrinio.SDK.Model
{
    /// <summary>
    /// ApiResponseETFHoldings
    /// </summary>
    [DataContract]
    public partial class ApiResponseETFHoldings :  IEquatable<ApiResponseETFHoldings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseETFHoldings" /> class.
        /// </summary>
        /// <param name="Holdings">Holdings.</param>
        /// <param name="Etf">Etf.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseETFHoldings(List<ETFHolding> Holdings = default(List<ETFHolding>), ETFSummary Etf = default(ETFSummary), string NextPage = default(string))
        {
            this.Holdings = Holdings;
            this.Etf = Etf;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets Holdings
        /// </summary>
        [DataMember(Name="holdings", EmitDefaultValue=false)]
        public List<ETFHolding> Holdings { get; set; }

        /// <summary>
        /// Gets or Sets Etf
        /// </summary>
        [DataMember(Name="etf", EmitDefaultValue=false)]
        public ETFSummary Etf { get; set; }

        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseETFHoldings {\n");
            sb.Append("  Holdings: ").Append(Holdings).Append("\n");
            sb.Append("  Etf: ").Append(Etf).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApiResponseETFHoldings);
        }

        /// <summary>
        /// Returns true if ApiResponseETFHoldings instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseETFHoldings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseETFHoldings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Holdings == input.Holdings ||
                    this.Holdings != null &&
                    this.Holdings.SequenceEqual(input.Holdings)
                ) && 
                (
                    this.Etf == input.Etf ||
                    (this.Etf != null &&
                    this.Etf.Equals(input.Etf))
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Holdings != null)
                    hashCode = hashCode * 59 + this.Holdings.GetHashCode();
                if (this.Etf != null)
                    hashCode = hashCode * 59 + this.Etf.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
