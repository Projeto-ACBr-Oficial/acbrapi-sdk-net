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
    /// Grupo de informações da Tributação Monofásica sujeita a retenção.
    /// </summary>
    [DataContract(Name = "NfeSefazGMonoReten")]
    public partial class NfeSefazGMonoReten : IEquatable<NfeSefazGMonoReten>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGMonoReten" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGMonoReten() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGMonoReten" /> class.
        /// </summary>
        /// <param name="qBCMonoReten">Quantidade tributada sujeita a retenção. (required).</param>
        /// <param name="adRemIBSReten">Alíquota ad rem do IBS sujeito a retenção. (required).</param>
        /// <param name="vIBSMonoReten">Valor do IBS monofásico sujeito a retenção. (required).</param>
        /// <param name="adRemCBSReten">Alíquota ad rem da CBS sujeita a retenção. (required).</param>
        /// <param name="vCBSMonoReten">Valor da CBS monofásica sujeita a retenção. (required).</param>
        public NfeSefazGMonoReten(decimal? qBCMonoReten = default(decimal?), decimal? adRemIBSReten = default(decimal?), decimal? vIBSMonoReten = default(decimal?), decimal? adRemCBSReten = default(decimal?), decimal? vCBSMonoReten = default(decimal?))
        {
            // to ensure "qBCMonoReten" is required (not null)
            if (qBCMonoReten == null)
            {
                throw new ArgumentNullException("qBCMonoReten is a required property for NfeSefazGMonoReten and cannot be null");
            }
            this.qBCMonoReten = qBCMonoReten;
            // to ensure "adRemIBSReten" is required (not null)
            if (adRemIBSReten == null)
            {
                throw new ArgumentNullException("adRemIBSReten is a required property for NfeSefazGMonoReten and cannot be null");
            }
            this.adRemIBSReten = adRemIBSReten;
            // to ensure "vIBSMonoReten" is required (not null)
            if (vIBSMonoReten == null)
            {
                throw new ArgumentNullException("vIBSMonoReten is a required property for NfeSefazGMonoReten and cannot be null");
            }
            this.vIBSMonoReten = vIBSMonoReten;
            // to ensure "adRemCBSReten" is required (not null)
            if (adRemCBSReten == null)
            {
                throw new ArgumentNullException("adRemCBSReten is a required property for NfeSefazGMonoReten and cannot be null");
            }
            this.adRemCBSReten = adRemCBSReten;
            // to ensure "vCBSMonoReten" is required (not null)
            if (vCBSMonoReten == null)
            {
                throw new ArgumentNullException("vCBSMonoReten is a required property for NfeSefazGMonoReten and cannot be null");
            }
            this.vCBSMonoReten = vCBSMonoReten;
        }

        /// <summary>
        /// Quantidade tributada sujeita a retenção.
        /// </summary>
        /// <value>Quantidade tributada sujeita a retenção.</value>
        [DataMember(Name = "qBCMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qBCMonoReten { get; set; }

        /// <summary>
        /// Alíquota ad rem do IBS sujeito a retenção.
        /// </summary>
        /// <value>Alíquota ad rem do IBS sujeito a retenção.</value>
        [DataMember(Name = "adRemIBSReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? adRemIBSReten { get; set; }

        /// <summary>
        /// Valor do IBS monofásico sujeito a retenção.
        /// </summary>
        /// <value>Valor do IBS monofásico sujeito a retenção.</value>
        [DataMember(Name = "vIBSMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMonoReten { get; set; }

        /// <summary>
        /// Alíquota ad rem da CBS sujeita a retenção.
        /// </summary>
        /// <value>Alíquota ad rem da CBS sujeita a retenção.</value>
        [DataMember(Name = "adRemCBSReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? adRemCBSReten { get; set; }

        /// <summary>
        /// Valor da CBS monofásica sujeita a retenção.
        /// </summary>
        /// <value>Valor da CBS monofásica sujeita a retenção.</value>
        [DataMember(Name = "vCBSMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBSMonoReten { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGMonoReten {\n");
            sb.Append("  qBCMonoReten: ").Append(qBCMonoReten).Append("\n");
            sb.Append("  adRemIBSReten: ").Append(adRemIBSReten).Append("\n");
            sb.Append("  vIBSMonoReten: ").Append(vIBSMonoReten).Append("\n");
            sb.Append("  adRemCBSReten: ").Append(adRemCBSReten).Append("\n");
            sb.Append("  vCBSMonoReten: ").Append(vCBSMonoReten).Append("\n");
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
            return this.Equals(input as NfeSefazGMonoReten);
        }

        /// <summary>
        /// Returns true if NfeSefazGMonoReten instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGMonoReten to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGMonoReten input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qBCMonoReten == input.qBCMonoReten ||
                    (this.qBCMonoReten != null &&
                    this.qBCMonoReten.Equals(input.qBCMonoReten))
                ) && 
                (
                    this.adRemIBSReten == input.adRemIBSReten ||
                    (this.adRemIBSReten != null &&
                    this.adRemIBSReten.Equals(input.adRemIBSReten))
                ) && 
                (
                    this.vIBSMonoReten == input.vIBSMonoReten ||
                    (this.vIBSMonoReten != null &&
                    this.vIBSMonoReten.Equals(input.vIBSMonoReten))
                ) && 
                (
                    this.adRemCBSReten == input.adRemCBSReten ||
                    (this.adRemCBSReten != null &&
                    this.adRemCBSReten.Equals(input.adRemCBSReten))
                ) && 
                (
                    this.vCBSMonoReten == input.vCBSMonoReten ||
                    (this.vCBSMonoReten != null &&
                    this.vCBSMonoReten.Equals(input.vCBSMonoReten))
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
                if (this.qBCMonoReten != null)
                {
                    hashCode = (hashCode * 59) + this.qBCMonoReten.GetHashCode();
                }
                if (this.adRemIBSReten != null)
                {
                    hashCode = (hashCode * 59) + this.adRemIBSReten.GetHashCode();
                }
                if (this.vIBSMonoReten != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSMonoReten.GetHashCode();
                }
                if (this.adRemCBSReten != null)
                {
                    hashCode = (hashCode * 59) + this.adRemCBSReten.GetHashCode();
                }
                if (this.vCBSMonoReten != null)
                {
                    hashCode = (hashCode * 59) + this.vCBSMonoReten.GetHashCode();
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
            // qBCMonoReten (decimal?) minimum
            if (this.qBCMonoReten < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qBCMonoReten, must be a value greater than or equal to 0.", new [] { "qBCMonoReten" });
            }

            // adRemIBSReten (decimal?) minimum
            if (this.adRemIBSReten < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for adRemIBSReten, must be a value greater than or equal to 0.", new [] { "adRemIBSReten" });
            }

            // vIBSMonoReten (decimal?) minimum
            if (this.vIBSMonoReten < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIBSMonoReten, must be a value greater than or equal to 0.", new [] { "vIBSMonoReten" });
            }

            // adRemCBSReten (decimal?) minimum
            if (this.adRemCBSReten < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for adRemCBSReten, must be a value greater than or equal to 0.", new [] { "adRemCBSReten" });
            }

            // vCBSMonoReten (decimal?) minimum
            if (this.vCBSMonoReten < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCBSMonoReten, must be a value greater than or equal to 0.", new [] { "vCBSMonoReten" });
            }

            yield break;
        }
    }

}
