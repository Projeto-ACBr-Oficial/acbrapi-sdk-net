/*
 * ACBr API - SDK para .NET
 * https://www.acbr.api.br
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = ACBrAPI.Sdk.Client.FileParameter;
using OpenAPIDateConverter = ACBrAPI.Sdk.Client.OpenAPIDateConverter;

namespace ACBrAPI.Sdk.Model
{
    /// <summary>
    /// Grupo de informações relacionadas ao diferimento para IBS e CBS.
    /// </summary>
    [DataContract(Name = "RTCInfoTributosDif")]
    public partial class RTCInfoTributosDif : IEquatable<RTCInfoTributosDif>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosDif" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCInfoTributosDif() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosDif" /> class.
        /// </summary>
        /// <param name="pDifUF">Percentual de diferimento para o IBS estadual. (required).</param>
        /// <param name="pDifMun">Percentual de diferimento para o IBS municipal. (required).</param>
        /// <param name="pDifCBS">Percentual de diferimento para a CBS. (required).</param>
        public RTCInfoTributosDif(decimal? pDifUF = default(decimal?), decimal? pDifMun = default(decimal?), decimal? pDifCBS = default(decimal?))
        {
            // to ensure "pDifUF" is required (not null)
            if (pDifUF == null)
            {
                throw new ArgumentNullException("pDifUF is a required property for RTCInfoTributosDif and cannot be null");
            }
            this.pDifUF = pDifUF;
            // to ensure "pDifMun" is required (not null)
            if (pDifMun == null)
            {
                throw new ArgumentNullException("pDifMun is a required property for RTCInfoTributosDif and cannot be null");
            }
            this.pDifMun = pDifMun;
            // to ensure "pDifCBS" is required (not null)
            if (pDifCBS == null)
            {
                throw new ArgumentNullException("pDifCBS is a required property for RTCInfoTributosDif and cannot be null");
            }
            this.pDifCBS = pDifCBS;
        }

        /// <summary>
        /// Percentual de diferimento para o IBS estadual.
        /// </summary>
        /// <value>Percentual de diferimento para o IBS estadual.</value>
        [DataMember(Name = "pDifUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pDifUF { get; set; }

        /// <summary>
        /// Percentual de diferimento para o IBS municipal.
        /// </summary>
        /// <value>Percentual de diferimento para o IBS municipal.</value>
        [DataMember(Name = "pDifMun", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pDifMun { get; set; }

        /// <summary>
        /// Percentual de diferimento para a CBS.
        /// </summary>
        /// <value>Percentual de diferimento para a CBS.</value>
        [DataMember(Name = "pDifCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pDifCBS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCInfoTributosDif {\n");
            sb.Append("  pDifUF: ").Append(pDifUF).Append("\n");
            sb.Append("  pDifMun: ").Append(pDifMun).Append("\n");
            sb.Append("  pDifCBS: ").Append(pDifCBS).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RTCInfoTributosDif);
        }

        /// <summary>
        /// Returns true if RTCInfoTributosDif instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCInfoTributosDif to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCInfoTributosDif input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pDifUF == input.pDifUF ||
                    (this.pDifUF != null &&
                    this.pDifUF.Equals(input.pDifUF))
                ) && 
                (
                    this.pDifMun == input.pDifMun ||
                    (this.pDifMun != null &&
                    this.pDifMun.Equals(input.pDifMun))
                ) && 
                (
                    this.pDifCBS == input.pDifCBS ||
                    (this.pDifCBS != null &&
                    this.pDifCBS.Equals(input.pDifCBS))
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
                if (this.pDifUF != null)
                {
                    hashCode = (hashCode * 59) + this.pDifUF.GetHashCode();
                }
                if (this.pDifMun != null)
                {
                    hashCode = (hashCode * 59) + this.pDifMun.GetHashCode();
                }
                if (this.pDifCBS != null)
                {
                    hashCode = (hashCode * 59) + this.pDifCBS.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // pDifUF (decimal?) minimum
            if (this.pDifUF < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pDifUF, must be a value greater than or equal to 0.", new [] { "pDifUF" });
            }

            // pDifMun (decimal?) minimum
            if (this.pDifMun < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pDifMun, must be a value greater than or equal to 0.", new [] { "pDifMun" });
            }

            // pDifCBS (decimal?) minimum
            if (this.pDifCBS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pDifCBS, must be a value greater than or equal to 0.", new [] { "pDifCBS" });
            }

            yield break;
        }
    }

}
