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
    [DataContract(Name = "NfeSefazGCBSMonoAdValorem_GMonoReten")]
    public partial class NfeSefazGCBSMonoAdValoremGMonoReten : IEquatable<NfeSefazGCBSMonoAdValoremGMonoReten>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdValoremGMonoReten" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGCBSMonoAdValoremGMonoReten() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdValoremGMonoReten" /> class.
        /// </summary>
        /// <param name="vBCMonoReten">Valor tributado sujeito à retenção na monofasia. (required).</param>
        /// <param name="pAliqMonoReten">Alíquota ad valorem da CBS sujeita à retenção. (required).</param>
        /// <param name="vCBSMonoReten">Valor da CBS monofásica sujeita à retenção. (required).</param>
        public NfeSefazGCBSMonoAdValoremGMonoReten(decimal? vBCMonoReten = default(decimal?), decimal? pAliqMonoReten = default(decimal?), decimal? vCBSMonoReten = default(decimal?))
        {
            // to ensure "vBCMonoReten" is required (not null)
            if (vBCMonoReten == null)
            {
                throw new ArgumentNullException("vBCMonoReten is a required property for NfeSefazGCBSMonoAdValoremGMonoReten and cannot be null");
            }
            this.vBCMonoReten = vBCMonoReten;
            // to ensure "pAliqMonoReten" is required (not null)
            if (pAliqMonoReten == null)
            {
                throw new ArgumentNullException("pAliqMonoReten is a required property for NfeSefazGCBSMonoAdValoremGMonoReten and cannot be null");
            }
            this.pAliqMonoReten = pAliqMonoReten;
            // to ensure "vCBSMonoReten" is required (not null)
            if (vCBSMonoReten == null)
            {
                throw new ArgumentNullException("vCBSMonoReten is a required property for NfeSefazGCBSMonoAdValoremGMonoReten and cannot be null");
            }
            this.vCBSMonoReten = vCBSMonoReten;
        }

        /// <summary>
        /// Valor tributado sujeito à retenção na monofasia.
        /// </summary>
        /// <value>Valor tributado sujeito à retenção na monofasia.</value>
        [DataMember(Name = "vBCMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCMonoReten { get; set; }

        /// <summary>
        /// Alíquota ad valorem da CBS sujeita à retenção.
        /// </summary>
        /// <value>Alíquota ad valorem da CBS sujeita à retenção.</value>
        [DataMember(Name = "pAliqMonoReten", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pAliqMonoReten { get; set; }

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
            sb.Append("class NfeSefazGCBSMonoAdValoremGMonoReten {\n");
            sb.Append("  vBCMonoReten: ").Append(vBCMonoReten).Append("\n");
            sb.Append("  pAliqMonoReten: ").Append(pAliqMonoReten).Append("\n");
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
            return this.Equals(input as NfeSefazGCBSMonoAdValoremGMonoReten);
        }

        /// <summary>
        /// Returns true if NfeSefazGCBSMonoAdValoremGMonoReten instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGCBSMonoAdValoremGMonoReten to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGCBSMonoAdValoremGMonoReten input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBCMonoReten == input.vBCMonoReten ||
                    (this.vBCMonoReten != null &&
                    this.vBCMonoReten.Equals(input.vBCMonoReten))
                ) && 
                (
                    this.pAliqMonoReten == input.pAliqMonoReten ||
                    (this.pAliqMonoReten != null &&
                    this.pAliqMonoReten.Equals(input.pAliqMonoReten))
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
                if (this.vBCMonoReten != null)
                {
                    hashCode = (hashCode * 59) + this.vBCMonoReten.GetHashCode();
                }
                if (this.pAliqMonoReten != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqMonoReten.GetHashCode();
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
            // vBCMonoReten (decimal?) minimum
            if (this.vBCMonoReten < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBCMonoReten, must be a value greater than or equal to 0.", new [] { "vBCMonoReten" });
            }

            // pAliqMonoReten (decimal?) minimum
            if (this.pAliqMonoReten < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pAliqMonoReten, must be a value greater than or equal to 0.", new [] { "pAliqMonoReten" });
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
