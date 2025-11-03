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
    /// Grupo de informações do diferimento da Tributação Monofásica.
    /// </summary>
    [DataContract(Name = "NfeSefazGMonoDif")]
    public partial class NfeSefazGMonoDif : IEquatable<NfeSefazGMonoDif>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGMonoDif" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGMonoDif() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGMonoDif" /> class.
        /// </summary>
        /// <param name="pDifIBS">Percentual do diferimento do imposto monofásico. (required).</param>
        /// <param name="vIBSMonoDif">Valor do IBS monofásico diferido. (required).</param>
        /// <param name="pDifCBS">Percentual do diferimento do imposto monofásico. (required).</param>
        /// <param name="vCBSMonoDif">Valor da CBS monofásica diferida. (required).</param>
        public NfeSefazGMonoDif(decimal? pDifIBS = default(decimal?), decimal? vIBSMonoDif = default(decimal?), decimal? pDifCBS = default(decimal?), decimal? vCBSMonoDif = default(decimal?))
        {
            // to ensure "pDifIBS" is required (not null)
            if (pDifIBS == null)
            {
                throw new ArgumentNullException("pDifIBS is a required property for NfeSefazGMonoDif and cannot be null");
            }
            this.pDifIBS = pDifIBS;
            // to ensure "vIBSMonoDif" is required (not null)
            if (vIBSMonoDif == null)
            {
                throw new ArgumentNullException("vIBSMonoDif is a required property for NfeSefazGMonoDif and cannot be null");
            }
            this.vIBSMonoDif = vIBSMonoDif;
            // to ensure "pDifCBS" is required (not null)
            if (pDifCBS == null)
            {
                throw new ArgumentNullException("pDifCBS is a required property for NfeSefazGMonoDif and cannot be null");
            }
            this.pDifCBS = pDifCBS;
            // to ensure "vCBSMonoDif" is required (not null)
            if (vCBSMonoDif == null)
            {
                throw new ArgumentNullException("vCBSMonoDif is a required property for NfeSefazGMonoDif and cannot be null");
            }
            this.vCBSMonoDif = vCBSMonoDif;
        }

        /// <summary>
        /// Percentual do diferimento do imposto monofásico.
        /// </summary>
        /// <value>Percentual do diferimento do imposto monofásico.</value>
        [DataMember(Name = "pDifIBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pDifIBS { get; set; }

        /// <summary>
        /// Valor do IBS monofásico diferido.
        /// </summary>
        /// <value>Valor do IBS monofásico diferido.</value>
        [DataMember(Name = "vIBSMonoDif", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMonoDif { get; set; }

        /// <summary>
        /// Percentual do diferimento do imposto monofásico.
        /// </summary>
        /// <value>Percentual do diferimento do imposto monofásico.</value>
        [DataMember(Name = "pDifCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pDifCBS { get; set; }

        /// <summary>
        /// Valor da CBS monofásica diferida.
        /// </summary>
        /// <value>Valor da CBS monofásica diferida.</value>
        [DataMember(Name = "vCBSMonoDif", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBSMonoDif { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGMonoDif {\n");
            sb.Append("  pDifIBS: ").Append(pDifIBS).Append("\n");
            sb.Append("  vIBSMonoDif: ").Append(vIBSMonoDif).Append("\n");
            sb.Append("  pDifCBS: ").Append(pDifCBS).Append("\n");
            sb.Append("  vCBSMonoDif: ").Append(vCBSMonoDif).Append("\n");
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
            return this.Equals(input as NfeSefazGMonoDif);
        }

        /// <summary>
        /// Returns true if NfeSefazGMonoDif instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGMonoDif to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGMonoDif input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pDifIBS == input.pDifIBS ||
                    (this.pDifIBS != null &&
                    this.pDifIBS.Equals(input.pDifIBS))
                ) && 
                (
                    this.vIBSMonoDif == input.vIBSMonoDif ||
                    (this.vIBSMonoDif != null &&
                    this.vIBSMonoDif.Equals(input.vIBSMonoDif))
                ) && 
                (
                    this.pDifCBS == input.pDifCBS ||
                    (this.pDifCBS != null &&
                    this.pDifCBS.Equals(input.pDifCBS))
                ) && 
                (
                    this.vCBSMonoDif == input.vCBSMonoDif ||
                    (this.vCBSMonoDif != null &&
                    this.vCBSMonoDif.Equals(input.vCBSMonoDif))
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
                if (this.pDifIBS != null)
                {
                    hashCode = (hashCode * 59) + this.pDifIBS.GetHashCode();
                }
                if (this.vIBSMonoDif != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSMonoDif.GetHashCode();
                }
                if (this.pDifCBS != null)
                {
                    hashCode = (hashCode * 59) + this.pDifCBS.GetHashCode();
                }
                if (this.vCBSMonoDif != null)
                {
                    hashCode = (hashCode * 59) + this.vCBSMonoDif.GetHashCode();
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
            // pDifIBS (decimal?) minimum
            if (this.pDifIBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pDifIBS, must be a value greater than or equal to 0.", new [] { "pDifIBS" });
            }

            // vIBSMonoDif (decimal?) minimum
            if (this.vIBSMonoDif < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIBSMonoDif, must be a value greater than or equal to 0.", new [] { "vIBSMonoDif" });
            }

            // pDifCBS (decimal?) minimum
            if (this.pDifCBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pDifCBS, must be a value greater than or equal to 0.", new [] { "pDifCBS" });
            }

            // vCBSMonoDif (decimal?) minimum
            if (this.vCBSMonoDif < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCBSMonoDif, must be a value greater than or equal to 0.", new [] { "vCBSMonoDif" });
            }

            yield break;
        }
    }

}
