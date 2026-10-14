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
    [DataContract(Name = "NfeSefazGIBSMonoAdValorem_GMonoPadrao")]
    public partial class NfeSefazGIBSMonoAdValoremGMonoPadrao : IEquatable<NfeSefazGIBSMonoAdValoremGMonoPadrao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGIBSMonoAdValoremGMonoPadrao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGIBSMonoAdValoremGMonoPadrao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGIBSMonoAdValoremGMonoPadrao" /> class.
        /// </summary>
        /// <param name="vBCMono">Valor tributado na monofasia. (required).</param>
        /// <param name="pAliqMonoUF">Alíquota ad valorem do IBS Estadual. (required).</param>
        /// <param name="vIBSMonoUF">Valor do IBS monofásico Estadual. (required).</param>
        /// <param name="pAliqMonoMun">Alíquota ad valorem do IBS Municipal. (required).</param>
        /// <param name="vIBSMonoMun">Valor do IBS monofásico do Municipal. (required).</param>
        /// <param name="vIBSMono">Valor do IBS monofásico. (required).</param>
        public NfeSefazGIBSMonoAdValoremGMonoPadrao(decimal? vBCMono = default(decimal?), decimal? pAliqMonoUF = default(decimal?), decimal? vIBSMonoUF = default(decimal?), decimal? pAliqMonoMun = default(decimal?), decimal? vIBSMonoMun = default(decimal?), decimal? vIBSMono = default(decimal?))
        {
            // to ensure "vBCMono" is required (not null)
            if (vBCMono == null)
            {
                throw new ArgumentNullException("vBCMono is a required property for NfeSefazGIBSMonoAdValoremGMonoPadrao and cannot be null");
            }
            this.vBCMono = vBCMono;
            // to ensure "pAliqMonoUF" is required (not null)
            if (pAliqMonoUF == null)
            {
                throw new ArgumentNullException("pAliqMonoUF is a required property for NfeSefazGIBSMonoAdValoremGMonoPadrao and cannot be null");
            }
            this.pAliqMonoUF = pAliqMonoUF;
            // to ensure "vIBSMonoUF" is required (not null)
            if (vIBSMonoUF == null)
            {
                throw new ArgumentNullException("vIBSMonoUF is a required property for NfeSefazGIBSMonoAdValoremGMonoPadrao and cannot be null");
            }
            this.vIBSMonoUF = vIBSMonoUF;
            // to ensure "pAliqMonoMun" is required (not null)
            if (pAliqMonoMun == null)
            {
                throw new ArgumentNullException("pAliqMonoMun is a required property for NfeSefazGIBSMonoAdValoremGMonoPadrao and cannot be null");
            }
            this.pAliqMonoMun = pAliqMonoMun;
            // to ensure "vIBSMonoMun" is required (not null)
            if (vIBSMonoMun == null)
            {
                throw new ArgumentNullException("vIBSMonoMun is a required property for NfeSefazGIBSMonoAdValoremGMonoPadrao and cannot be null");
            }
            this.vIBSMonoMun = vIBSMonoMun;
            // to ensure "vIBSMono" is required (not null)
            if (vIBSMono == null)
            {
                throw new ArgumentNullException("vIBSMono is a required property for NfeSefazGIBSMonoAdValoremGMonoPadrao and cannot be null");
            }
            this.vIBSMono = vIBSMono;
        }

        /// <summary>
        /// Valor tributado na monofasia.
        /// </summary>
        /// <value>Valor tributado na monofasia.</value>
        [DataMember(Name = "vBCMono", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCMono { get; set; }

        /// <summary>
        /// Alíquota ad valorem do IBS Estadual.
        /// </summary>
        /// <value>Alíquota ad valorem do IBS Estadual.</value>
        [DataMember(Name = "pAliqMonoUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pAliqMonoUF { get; set; }

        /// <summary>
        /// Valor do IBS monofásico Estadual.
        /// </summary>
        /// <value>Valor do IBS monofásico Estadual.</value>
        [DataMember(Name = "vIBSMonoUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMonoUF { get; set; }

        /// <summary>
        /// Alíquota ad valorem do IBS Municipal.
        /// </summary>
        /// <value>Alíquota ad valorem do IBS Municipal.</value>
        [DataMember(Name = "pAliqMonoMun", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pAliqMonoMun { get; set; }

        /// <summary>
        /// Valor do IBS monofásico do Municipal.
        /// </summary>
        /// <value>Valor do IBS monofásico do Municipal.</value>
        [DataMember(Name = "vIBSMonoMun", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMonoMun { get; set; }

        /// <summary>
        /// Valor do IBS monofásico.
        /// </summary>
        /// <value>Valor do IBS monofásico.</value>
        [DataMember(Name = "vIBSMono", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMono { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGIBSMonoAdValoremGMonoPadrao {\n");
            sb.Append("  vBCMono: ").Append(vBCMono).Append("\n");
            sb.Append("  pAliqMonoUF: ").Append(pAliqMonoUF).Append("\n");
            sb.Append("  vIBSMonoUF: ").Append(vIBSMonoUF).Append("\n");
            sb.Append("  pAliqMonoMun: ").Append(pAliqMonoMun).Append("\n");
            sb.Append("  vIBSMonoMun: ").Append(vIBSMonoMun).Append("\n");
            sb.Append("  vIBSMono: ").Append(vIBSMono).Append("\n");
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
            return this.Equals(input as NfeSefazGIBSMonoAdValoremGMonoPadrao);
        }

        /// <summary>
        /// Returns true if NfeSefazGIBSMonoAdValoremGMonoPadrao instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGIBSMonoAdValoremGMonoPadrao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGIBSMonoAdValoremGMonoPadrao input)
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
                    this.pAliqMonoUF == input.pAliqMonoUF ||
                    (this.pAliqMonoUF != null &&
                    this.pAliqMonoUF.Equals(input.pAliqMonoUF))
                ) && 
                (
                    this.vIBSMonoUF == input.vIBSMonoUF ||
                    (this.vIBSMonoUF != null &&
                    this.vIBSMonoUF.Equals(input.vIBSMonoUF))
                ) && 
                (
                    this.pAliqMonoMun == input.pAliqMonoMun ||
                    (this.pAliqMonoMun != null &&
                    this.pAliqMonoMun.Equals(input.pAliqMonoMun))
                ) && 
                (
                    this.vIBSMonoMun == input.vIBSMonoMun ||
                    (this.vIBSMonoMun != null &&
                    this.vIBSMonoMun.Equals(input.vIBSMonoMun))
                ) && 
                (
                    this.vIBSMono == input.vIBSMono ||
                    (this.vIBSMono != null &&
                    this.vIBSMono.Equals(input.vIBSMono))
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
                if (this.pAliqMonoUF != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqMonoUF.GetHashCode();
                }
                if (this.vIBSMonoUF != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSMonoUF.GetHashCode();
                }
                if (this.pAliqMonoMun != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqMonoMun.GetHashCode();
                }
                if (this.vIBSMonoMun != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSMonoMun.GetHashCode();
                }
                if (this.vIBSMono != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSMono.GetHashCode();
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

            // pAliqMonoUF (decimal?) minimum
            if (this.pAliqMonoUF < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pAliqMonoUF, must be a value greater than or equal to 0.", new [] { "pAliqMonoUF" });
            }

            // vIBSMonoUF (decimal?) minimum
            if (this.vIBSMonoUF < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vIBSMonoUF, must be a value greater than or equal to 0.", new [] { "vIBSMonoUF" });
            }

            // pAliqMonoMun (decimal?) minimum
            if (this.pAliqMonoMun < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pAliqMonoMun, must be a value greater than or equal to 0.", new [] { "pAliqMonoMun" });
            }

            // vIBSMonoMun (decimal?) minimum
            if (this.vIBSMonoMun < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vIBSMonoMun, must be a value greater than or equal to 0.", new [] { "vIBSMonoMun" });
            }

            // vIBSMono (decimal?) minimum
            if (this.vIBSMono < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vIBSMono, must be a value greater than or equal to 0.", new [] { "vIBSMono" });
            }

            yield break;
        }
    }

}
