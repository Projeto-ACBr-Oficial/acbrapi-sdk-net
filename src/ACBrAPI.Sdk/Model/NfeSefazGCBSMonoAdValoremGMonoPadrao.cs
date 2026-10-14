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
    /// Grupo de informações da Tributação Monofásica Padrão.
    /// </summary>
    [DataContract(Name = "NfeSefazGCBSMonoAdValorem_GMonoPadrao")]
    public partial class NfeSefazGCBSMonoAdValoremGMonoPadrao : IEquatable<NfeSefazGCBSMonoAdValoremGMonoPadrao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdValoremGMonoPadrao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGCBSMonoAdValoremGMonoPadrao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdValoremGMonoPadrao" /> class.
        /// </summary>
        /// <param name="vBCMono">Valor tributado na monofasia. (required).</param>
        /// <param name="pAliqMonoCBS">Alíquota ad valorem da CBS. (required).</param>
        /// <param name="vCBSMono">Valor da CBS monofásica. (required).</param>
        public NfeSefazGCBSMonoAdValoremGMonoPadrao(decimal? vBCMono = default(decimal?), decimal? pAliqMonoCBS = default(decimal?), decimal? vCBSMono = default(decimal?))
        {
            // to ensure "vBCMono" is required (not null)
            if (vBCMono == null)
            {
                throw new ArgumentNullException("vBCMono is a required property for NfeSefazGCBSMonoAdValoremGMonoPadrao and cannot be null");
            }
            this.vBCMono = vBCMono;
            // to ensure "pAliqMonoCBS" is required (not null)
            if (pAliqMonoCBS == null)
            {
                throw new ArgumentNullException("pAliqMonoCBS is a required property for NfeSefazGCBSMonoAdValoremGMonoPadrao and cannot be null");
            }
            this.pAliqMonoCBS = pAliqMonoCBS;
            // to ensure "vCBSMono" is required (not null)
            if (vCBSMono == null)
            {
                throw new ArgumentNullException("vCBSMono is a required property for NfeSefazGCBSMonoAdValoremGMonoPadrao and cannot be null");
            }
            this.vCBSMono = vCBSMono;
        }

        /// <summary>
        /// Valor tributado na monofasia.
        /// </summary>
        /// <value>Valor tributado na monofasia.</value>
        [DataMember(Name = "vBCMono", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCMono { get; set; }

        /// <summary>
        /// Alíquota ad valorem da CBS.
        /// </summary>
        /// <value>Alíquota ad valorem da CBS.</value>
        [DataMember(Name = "pAliqMonoCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pAliqMonoCBS { get; set; }

        /// <summary>
        /// Valor da CBS monofásica.
        /// </summary>
        /// <value>Valor da CBS monofásica.</value>
        [DataMember(Name = "vCBSMono", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBSMono { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGCBSMonoAdValoremGMonoPadrao {\n");
            sb.Append("  vBCMono: ").Append(vBCMono).Append("\n");
            sb.Append("  pAliqMonoCBS: ").Append(pAliqMonoCBS).Append("\n");
            sb.Append("  vCBSMono: ").Append(vCBSMono).Append("\n");
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
            return this.Equals(input as NfeSefazGCBSMonoAdValoremGMonoPadrao);
        }

        /// <summary>
        /// Returns true if NfeSefazGCBSMonoAdValoremGMonoPadrao instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGCBSMonoAdValoremGMonoPadrao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGCBSMonoAdValoremGMonoPadrao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBCMono == input.vBCMono ||
                    (this.vBCMono != null &&
                    this.vBCMono.Equals(input.vBCMono))
                ) && 
                (
                    this.pAliqMonoCBS == input.pAliqMonoCBS ||
                    (this.pAliqMonoCBS != null &&
                    this.pAliqMonoCBS.Equals(input.pAliqMonoCBS))
                ) && 
                (
                    this.vCBSMono == input.vCBSMono ||
                    (this.vCBSMono != null &&
                    this.vCBSMono.Equals(input.vCBSMono))
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
                if (this.vBCMono != null)
                {
                    hashCode = (hashCode * 59) + this.vBCMono.GetHashCode();
                }
                if (this.pAliqMonoCBS != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqMonoCBS.GetHashCode();
                }
                if (this.vCBSMono != null)
                {
                    hashCode = (hashCode * 59) + this.vCBSMono.GetHashCode();
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
            // vBCMono (decimal?) minimum
            if (this.vBCMono < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBCMono, must be a value greater than or equal to 0.", new [] { "vBCMono" });
            }

            // pAliqMonoCBS (decimal?) minimum
            if (this.pAliqMonoCBS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pAliqMonoCBS, must be a value greater than or equal to 0.", new [] { "pAliqMonoCBS" });
            }

            // vCBSMono (decimal?) minimum
            if (this.vCBSMono < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vCBSMono, must be a value greater than or equal to 0.", new [] { "vCBSMono" });
            }

            yield break;
        }
    }

}
