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
    /// Totais da Monofasia.  Só deverá ser utilizado para DFe modelos 55 e 65.
    /// </summary>
    [DataContract(Name = "NfeSefazGMono")]
    public partial class NfeSefazGMono : IEquatable<NfeSefazGMono>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGMono" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGMono() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGMono" /> class.
        /// </summary>
        /// <param name="vIBSMono">Valor total do IBS monofásico. (required).</param>
        /// <param name="vCBSMono">Valor total da CBS monofásica. (required).</param>
        /// <param name="vIBSMonoReten">Valor total do IBS monofásico sujeito a retenção. (required).</param>
        /// <param name="vCBSMonoReten">Valor total da CBS monofásica sujeita a retenção. (required).</param>
        /// <param name="vIBSMonoRet">Valor do IBS monofásico retido anteriormente. (required).</param>
        /// <param name="vCBSMonoRet">Valor da CBS monofásica retida anteriormente. (required).</param>
        public NfeSefazGMono(decimal? vIBSMono = default(decimal?), decimal? vCBSMono = default(decimal?), decimal? vIBSMonoReten = default(decimal?), decimal? vCBSMonoReten = default(decimal?), decimal? vIBSMonoRet = default(decimal?), decimal? vCBSMonoRet = default(decimal?))
        {
            // to ensure "vIBSMono" is required (not null)
            if (vIBSMono == null)
            {
                throw new ArgumentNullException("vIBSMono is a required property for NfeSefazGMono and cannot be null");
            }
            this.vIBSMono = vIBSMono;
            // to ensure "vCBSMono" is required (not null)
            if (vCBSMono == null)
            {
                throw new ArgumentNullException("vCBSMono is a required property for NfeSefazGMono and cannot be null");
            }
            this.vCBSMono = vCBSMono;
            // to ensure "vIBSMonoReten" is required (not null)
            if (vIBSMonoReten == null)
            {
                throw new ArgumentNullException("vIBSMonoReten is a required property for NfeSefazGMono and cannot be null");
            }
            this.vIBSMonoReten = vIBSMonoReten;
            // to ensure "vCBSMonoReten" is required (not null)
            if (vCBSMonoReten == null)
            {
                throw new ArgumentNullException("vCBSMonoReten is a required property for NfeSefazGMono and cannot be null");
            }
            this.vCBSMonoReten = vCBSMonoReten;
            // to ensure "vIBSMonoRet" is required (not null)
            if (vIBSMonoRet == null)
            {
                throw new ArgumentNullException("vIBSMonoRet is a required property for NfeSefazGMono and cannot be null");
            }
            this.vIBSMonoRet = vIBSMonoRet;
            // to ensure "vCBSMonoRet" is required (not null)
            if (vCBSMonoRet == null)
            {
                throw new ArgumentNullException("vCBSMonoRet is a required property for NfeSefazGMono and cannot be null");
            }
            this.vCBSMonoRet = vCBSMonoRet;
        }

        /// <summary>
        /// Valor total do IBS monofásico.
        /// </summary>
        /// <value>Valor total do IBS monofásico.</value>
        [DataMember(Name = "vIBSMono", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMono { get; set; }

        /// <summary>
        /// Valor total da CBS monofásica.
        /// </summary>
        /// <value>Valor total da CBS monofásica.</value>
        [DataMember(Name = "vCBSMono", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBSMono { get; set; }

        /// <summary>
        /// Valor total do IBS monofásico sujeito a retenção.
        /// </summary>
        /// <value>Valor total do IBS monofásico sujeito a retenção.</value>
        [DataMember(Name = "vIBSMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMonoReten { get; set; }

        /// <summary>
        /// Valor total da CBS monofásica sujeita a retenção.
        /// </summary>
        /// <value>Valor total da CBS monofásica sujeita a retenção.</value>
        [DataMember(Name = "vCBSMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBSMonoReten { get; set; }

        /// <summary>
        /// Valor do IBS monofásico retido anteriormente.
        /// </summary>
        /// <value>Valor do IBS monofásico retido anteriormente.</value>
        [DataMember(Name = "vIBSMonoRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMonoRet { get; set; }

        /// <summary>
        /// Valor da CBS monofásica retida anteriormente.
        /// </summary>
        /// <value>Valor da CBS monofásica retida anteriormente.</value>
        [DataMember(Name = "vCBSMonoRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBSMonoRet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGMono {\n");
            sb.Append("  vIBSMono: ").Append(vIBSMono).Append("\n");
            sb.Append("  vCBSMono: ").Append(vCBSMono).Append("\n");
            sb.Append("  vIBSMonoReten: ").Append(vIBSMonoReten).Append("\n");
            sb.Append("  vCBSMonoReten: ").Append(vCBSMonoReten).Append("\n");
            sb.Append("  vIBSMonoRet: ").Append(vIBSMonoRet).Append("\n");
            sb.Append("  vCBSMonoRet: ").Append(vCBSMonoRet).Append("\n");
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
            return this.Equals(input as NfeSefazGMono);
        }

        /// <summary>
        /// Returns true if NfeSefazGMono instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGMono to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGMono input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vIBSMono == input.vIBSMono ||
                    (this.vIBSMono != null &&
                    this.vIBSMono.Equals(input.vIBSMono))
                ) && 
                (
                    this.vCBSMono == input.vCBSMono ||
                    (this.vCBSMono != null &&
                    this.vCBSMono.Equals(input.vCBSMono))
                ) && 
                (
                    this.vIBSMonoReten == input.vIBSMonoReten ||
                    (this.vIBSMonoReten != null &&
                    this.vIBSMonoReten.Equals(input.vIBSMonoReten))
                ) && 
                (
                    this.vCBSMonoReten == input.vCBSMonoReten ||
                    (this.vCBSMonoReten != null &&
                    this.vCBSMonoReten.Equals(input.vCBSMonoReten))
                ) && 
                (
                    this.vIBSMonoRet == input.vIBSMonoRet ||
                    (this.vIBSMonoRet != null &&
                    this.vIBSMonoRet.Equals(input.vIBSMonoRet))
                ) && 
                (
                    this.vCBSMonoRet == input.vCBSMonoRet ||
                    (this.vCBSMonoRet != null &&
                    this.vCBSMonoRet.Equals(input.vCBSMonoRet))
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
                if (this.vIBSMono != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSMono.GetHashCode();
                }
                if (this.vCBSMono != null)
                {
                    hashCode = (hashCode * 59) + this.vCBSMono.GetHashCode();
                }
                if (this.vIBSMonoReten != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSMonoReten.GetHashCode();
                }
                if (this.vCBSMonoReten != null)
                {
                    hashCode = (hashCode * 59) + this.vCBSMonoReten.GetHashCode();
                }
                if (this.vIBSMonoRet != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSMonoRet.GetHashCode();
                }
                if (this.vCBSMonoRet != null)
                {
                    hashCode = (hashCode * 59) + this.vCBSMonoRet.GetHashCode();
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
            // vIBSMono (decimal?) minimum
            if (this.vIBSMono < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIBSMono, must be a value greater than or equal to 0.", new [] { "vIBSMono" });
            }

            // vCBSMono (decimal?) minimum
            if (this.vCBSMono < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCBSMono, must be a value greater than or equal to 0.", new [] { "vCBSMono" });
            }

            // vIBSMonoReten (decimal?) minimum
            if (this.vIBSMonoReten < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIBSMonoReten, must be a value greater than or equal to 0.", new [] { "vIBSMonoReten" });
            }

            // vCBSMonoReten (decimal?) minimum
            if (this.vCBSMonoReten < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCBSMonoReten, must be a value greater than or equal to 0.", new [] { "vCBSMonoReten" });
            }

            // vIBSMonoRet (decimal?) minimum
            if (this.vIBSMonoRet < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIBSMonoRet, must be a value greater than or equal to 0.", new [] { "vIBSMonoRet" });
            }

            // vCBSMonoRet (decimal?) minimum
            if (this.vCBSMonoRet < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCBSMonoRet, must be a value greater than or equal to 0.", new [] { "vCBSMonoRet" });
            }

            yield break;
        }
    }

}
