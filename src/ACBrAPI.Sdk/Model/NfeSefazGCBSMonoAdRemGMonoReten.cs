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
    [DataContract(Name = "NfeSefazGCBSMonoAdRem_GMonoReten")]
    public partial class NfeSefazGCBSMonoAdRemGMonoReten : IEquatable<NfeSefazGCBSMonoAdRemGMonoReten>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdRemGMonoReten" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGCBSMonoAdRemGMonoReten() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdRemGMonoReten" /> class.
        /// </summary>
        /// <param name="qBCMonoReten">Quantidade tributada sujeita à retenção na monofasia. (required).</param>
        /// <param name="adRemCBSReten">Alíquota ad rem da CBS sujeita à retenção. (required).</param>
        /// <param name="vCBSMonoReten">Valor da CBS monofásica sujeita à retenção. (required).</param>
        public NfeSefazGCBSMonoAdRemGMonoReten(decimal? qBCMonoReten = default(decimal?), decimal? adRemCBSReten = default(decimal?), decimal? vCBSMonoReten = default(decimal?))
        {
            // to ensure "qBCMonoReten" is required (not null)
            if (qBCMonoReten == null)
            {
                throw new ArgumentNullException("qBCMonoReten is a required property for NfeSefazGCBSMonoAdRemGMonoReten and cannot be null");
            }
            this.qBCMonoReten = qBCMonoReten;
            // to ensure "adRemCBSReten" is required (not null)
            if (adRemCBSReten == null)
            {
                throw new ArgumentNullException("adRemCBSReten is a required property for NfeSefazGCBSMonoAdRemGMonoReten and cannot be null");
            }
            this.adRemCBSReten = adRemCBSReten;
            // to ensure "vCBSMonoReten" is required (not null)
            if (vCBSMonoReten == null)
            {
                throw new ArgumentNullException("vCBSMonoReten is a required property for NfeSefazGCBSMonoAdRemGMonoReten and cannot be null");
            }
            this.vCBSMonoReten = vCBSMonoReten;
        }

        /// <summary>
        /// Quantidade tributada sujeita à retenção na monofasia.
        /// </summary>
        /// <value>Quantidade tributada sujeita à retenção na monofasia.</value>
        [DataMember(Name = "qBCMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qBCMonoReten { get; set; }

        /// <summary>
        /// Alíquota ad rem da CBS sujeita à retenção.
        /// </summary>
        /// <value>Alíquota ad rem da CBS sujeita à retenção.</value>
        [DataMember(Name = "adRemCBSReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? adRemCBSReten { get; set; }

        /// <summary>
        /// Valor da CBS monofásica sujeita à retenção.
        /// </summary>
        /// <value>Valor da CBS monofásica sujeita à retenção.</value>
        [DataMember(Name = "vCBSMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBSMonoReten { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGCBSMonoAdRemGMonoReten {\n");
            sb.Append("  qBCMonoReten: ").Append(qBCMonoReten).Append("\n");
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
            return this.Equals(input as NfeSefazGCBSMonoAdRemGMonoReten);
        }

        /// <summary>
        /// Returns true if NfeSefazGCBSMonoAdRemGMonoReten instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGCBSMonoAdRemGMonoReten to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGCBSMonoAdRemGMonoReten input)
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // qBCMonoReten (decimal?) minimum
            if (this.qBCMonoReten < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qBCMonoReten, must be a value greater than or equal to 0.", new [] { "qBCMonoReten" });
            }

            // adRemCBSReten (decimal?) minimum
            if (this.adRemCBSReten < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for adRemCBSReten, must be a value greater than or equal to 0.", new [] { "adRemCBSReten" });
            }

            // vCBSMonoReten (decimal?) minimum
            if (this.vCBSMonoReten < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vCBSMonoReten, must be a value greater than or equal to 0.", new [] { "vCBSMonoReten" });
            }

            yield break;
        }
    }

}
