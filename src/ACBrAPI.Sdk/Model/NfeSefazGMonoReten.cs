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
    /// Grupo de informações da Tributação Monofásica Sujeita à Retenção.
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
        /// <param name="qBCMonoReten">Quantidade tributada sujeita à retenção na monofasia. (required).</param>
        /// <param name="adRemIBSReten">Alíquota ad rem do IBS sujeito à retenção. (required).</param>
        /// <param name="vIBSMonoReten">Valor do IBS monofásico sujeito à retenção. (required).</param>
        public NfeSefazGMonoReten(decimal? qBCMonoReten = default(decimal?), decimal? adRemIBSReten = default(decimal?), decimal? vIBSMonoReten = default(decimal?))
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
        }

        /// <summary>
        /// Quantidade tributada sujeita à retenção na monofasia.
        /// </summary>
        /// <value>Quantidade tributada sujeita à retenção na monofasia.</value>
        [DataMember(Name = "qBCMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qBCMonoReten { get; set; }

        /// <summary>
        /// Alíquota ad rem do IBS sujeito à retenção.
        /// </summary>
        /// <value>Alíquota ad rem do IBS sujeito à retenção.</value>
        [DataMember(Name = "adRemIBSReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? adRemIBSReten { get; set; }

        /// <summary>
        /// Valor do IBS monofásico sujeito à retenção.
        /// </summary>
        /// <value>Valor do IBS monofásico sujeito à retenção.</value>
        [DataMember(Name = "vIBSMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMonoReten { get; set; }

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
            // qBCMonoReten (decimal?) minimum
            if (this.qBCMonoReten < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qBCMonoReten, must be a value greater than or equal to 0.", new [] { "qBCMonoReten" });
            }

            // adRemIBSReten (decimal?) minimum
            if (this.adRemIBSReten < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for adRemIBSReten, must be a value greater than or equal to 0.", new [] { "adRemIBSReten" });
            }

            // vIBSMonoReten (decimal?) minimum
            if (this.vIBSMonoReten < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vIBSMonoReten, must be a value greater than or equal to 0.", new [] { "vIBSMonoReten" });
            }

            yield break;
        }
    }

}
