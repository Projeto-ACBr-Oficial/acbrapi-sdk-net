/*
 * ACBr API - SDK para .NET
 * https://www.acbrapi.com.br
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
    /// Grupo de campos do Diferimento.
    /// </summary>
    [DataContract(Name = "CteOsSefazDifOS")]
    public partial class CteOsSefazDifOS : IEquatable<CteOsSefazDifOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazDifOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazDifOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazDifOS" /> class.
        /// </summary>
        /// <param name="pDif">Percentual do diferimento. (required).</param>
        /// <param name="vDif">Valor do diferimento. (required).</param>
        public CteOsSefazDifOS(decimal? pDif = default(decimal?), decimal? vDif = default(decimal?))
        {
            // to ensure "pDif" is required (not null)
            if (pDif == null)
            {
                throw new ArgumentNullException("pDif is a required property for CteOsSefazDifOS and cannot be null");
            }
            this.pDif = pDif;
            // to ensure "vDif" is required (not null)
            if (vDif == null)
            {
                throw new ArgumentNullException("vDif is a required property for CteOsSefazDifOS and cannot be null");
            }
            this.vDif = vDif;
        }

        /// <summary>
        /// Percentual do diferimento.
        /// </summary>
        /// <value>Percentual do diferimento.</value>
        [DataMember(Name = "pDif", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pDif { get; set; }

        /// <summary>
        /// Valor do diferimento.
        /// </summary>
        /// <value>Valor do diferimento.</value>
        [DataMember(Name = "vDif", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDif { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazDifOS {\n");
            sb.Append("  pDif: ").Append(pDif).Append("\n");
            sb.Append("  vDif: ").Append(vDif).Append("\n");
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
            return this.Equals(input as CteOsSefazDifOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazDifOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazDifOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazDifOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pDif == input.pDif ||
                    (this.pDif != null &&
                    this.pDif.Equals(input.pDif))
                ) && 
                (
                    this.vDif == input.vDif ||
                    (this.vDif != null &&
                    this.vDif.Equals(input.vDif))
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
                if (this.pDif != null)
                {
                    hashCode = (hashCode * 59) + this.pDif.GetHashCode();
                }
                if (this.vDif != null)
                {
                    hashCode = (hashCode * 59) + this.vDif.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // pDif (decimal?) minimum
            if (this.pDif < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pDif, must be a value greater than or equal to 0.", new [] { "pDif" });
            }

            // vDif (decimal?) minimum
            if (this.vDif < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDif, must be a value greater than or equal to 0.", new [] { "vDif" });
            }

            yield break;
        }
    }

}
