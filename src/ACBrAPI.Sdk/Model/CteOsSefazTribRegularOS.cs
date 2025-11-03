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
    /// Grupo de informações da Tributação Regular. Informar como seria a tributação caso não cumprida a condição resolutória/suspensiva. Exemplo 1: Art. 442, §4. Operações com ZFM e ALC. Exemplo 2: Operações com suspensão do tributo.
    /// </summary>
    [DataContract(Name = "CteOsSefazTribRegularOS")]
    public partial class CteOsSefazTribRegularOS : IEquatable<CteOsSefazTribRegularOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazTribRegularOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazTribRegularOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazTribRegularOS" /> class.
        /// </summary>
        /// <param name="cSTReg">Código da Situação Tributária do IBS e CBS.  Informar qual seria o CST caso não cumprida a condição resolutória/suspensiva. (required).</param>
        /// <param name="cClassTribReg">Informar qual seria o cClassTrib caso não cumprida a condição resolutória/suspensiva. (required).</param>
        /// <param name="pAliqEfetRegIBSUF">Alíquota do IBS da UF.  Informar como seria a Alíquota caso não cumprida a condição resolutória/suspensiva. (required).</param>
        /// <param name="vTribRegIBSUF">Valor do IBS da UF.  Informar como seria o valor do Tributo caso não cumprida a condição resolutória/suspensiva. (required).</param>
        /// <param name="pAliqEfetRegIBSMun">Alíquota do IBS do Município.  Informar como seria a Alíquota caso não cumprida a condição resolutória/suspensiva. (required).</param>
        /// <param name="vTribRegIBSMun">Valor do IBS do Município.  Informar como seria o valor do Tributo caso não cumprida a condição resolutória/suspensiva. (required).</param>
        /// <param name="pAliqEfetRegCBS">Alíquota da CBS.  Informar como seria a Alíquota caso não cumprida a condição resolutória/suspensiva. (required).</param>
        /// <param name="vTribRegCBS">Valor da CBS.  Informar como seria o valor do Tributo caso não cumprida a condição resolutória/suspensiva. (required).</param>
        public CteOsSefazTribRegularOS(string cSTReg = default(string), string cClassTribReg = default(string), decimal? pAliqEfetRegIBSUF = default(decimal?), decimal? vTribRegIBSUF = default(decimal?), decimal? pAliqEfetRegIBSMun = default(decimal?), decimal? vTribRegIBSMun = default(decimal?), decimal? pAliqEfetRegCBS = default(decimal?), decimal? vTribRegCBS = default(decimal?))
        {
            // to ensure "cSTReg" is required (not null)
            if (cSTReg == null)
            {
                throw new ArgumentNullException("cSTReg is a required property for CteOsSefazTribRegularOS and cannot be null");
            }
            this.CSTReg = cSTReg;
            // to ensure "cClassTribReg" is required (not null)
            if (cClassTribReg == null)
            {
                throw new ArgumentNullException("cClassTribReg is a required property for CteOsSefazTribRegularOS and cannot be null");
            }
            this.cClassTribReg = cClassTribReg;
            // to ensure "pAliqEfetRegIBSUF" is required (not null)
            if (pAliqEfetRegIBSUF == null)
            {
                throw new ArgumentNullException("pAliqEfetRegIBSUF is a required property for CteOsSefazTribRegularOS and cannot be null");
            }
            this.pAliqEfetRegIBSUF = pAliqEfetRegIBSUF;
            // to ensure "vTribRegIBSUF" is required (not null)
            if (vTribRegIBSUF == null)
            {
                throw new ArgumentNullException("vTribRegIBSUF is a required property for CteOsSefazTribRegularOS and cannot be null");
            }
            this.vTribRegIBSUF = vTribRegIBSUF;
            // to ensure "pAliqEfetRegIBSMun" is required (not null)
            if (pAliqEfetRegIBSMun == null)
            {
                throw new ArgumentNullException("pAliqEfetRegIBSMun is a required property for CteOsSefazTribRegularOS and cannot be null");
            }
            this.pAliqEfetRegIBSMun = pAliqEfetRegIBSMun;
            // to ensure "vTribRegIBSMun" is required (not null)
            if (vTribRegIBSMun == null)
            {
                throw new ArgumentNullException("vTribRegIBSMun is a required property for CteOsSefazTribRegularOS and cannot be null");
            }
            this.vTribRegIBSMun = vTribRegIBSMun;
            // to ensure "pAliqEfetRegCBS" is required (not null)
            if (pAliqEfetRegCBS == null)
            {
                throw new ArgumentNullException("pAliqEfetRegCBS is a required property for CteOsSefazTribRegularOS and cannot be null");
            }
            this.pAliqEfetRegCBS = pAliqEfetRegCBS;
            // to ensure "vTribRegCBS" is required (not null)
            if (vTribRegCBS == null)
            {
                throw new ArgumentNullException("vTribRegCBS is a required property for CteOsSefazTribRegularOS and cannot be null");
            }
            this.vTribRegCBS = vTribRegCBS;
        }

        /// <summary>
        /// Código da Situação Tributária do IBS e CBS.  Informar qual seria o CST caso não cumprida a condição resolutória/suspensiva.
        /// </summary>
        /// <value>Código da Situação Tributária do IBS e CBS.  Informar qual seria o CST caso não cumprida a condição resolutória/suspensiva.</value>
        [DataMember(Name = "CSTReg", IsRequired = true, EmitDefaultValue = true)]
        public string CSTReg { get; set; }

        /// <summary>
        /// Informar qual seria o cClassTrib caso não cumprida a condição resolutória/suspensiva.
        /// </summary>
        /// <value>Informar qual seria o cClassTrib caso não cumprida a condição resolutória/suspensiva.</value>
        [DataMember(Name = "cClassTribReg", IsRequired = true, EmitDefaultValue = true)]
        public string cClassTribReg { get; set; }

        /// <summary>
        /// Alíquota do IBS da UF.  Informar como seria a Alíquota caso não cumprida a condição resolutória/suspensiva.
        /// </summary>
        /// <value>Alíquota do IBS da UF.  Informar como seria a Alíquota caso não cumprida a condição resolutória/suspensiva.</value>
        [DataMember(Name = "pAliqEfetRegIBSUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pAliqEfetRegIBSUF { get; set; }

        /// <summary>
        /// Valor do IBS da UF.  Informar como seria o valor do Tributo caso não cumprida a condição resolutória/suspensiva.
        /// </summary>
        /// <value>Valor do IBS da UF.  Informar como seria o valor do Tributo caso não cumprida a condição resolutória/suspensiva.</value>
        [DataMember(Name = "vTribRegIBSUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTribRegIBSUF { get; set; }

        /// <summary>
        /// Alíquota do IBS do Município.  Informar como seria a Alíquota caso não cumprida a condição resolutória/suspensiva.
        /// </summary>
        /// <value>Alíquota do IBS do Município.  Informar como seria a Alíquota caso não cumprida a condição resolutória/suspensiva.</value>
        [DataMember(Name = "pAliqEfetRegIBSMun", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pAliqEfetRegIBSMun { get; set; }

        /// <summary>
        /// Valor do IBS do Município.  Informar como seria o valor do Tributo caso não cumprida a condição resolutória/suspensiva.
        /// </summary>
        /// <value>Valor do IBS do Município.  Informar como seria o valor do Tributo caso não cumprida a condição resolutória/suspensiva.</value>
        [DataMember(Name = "vTribRegIBSMun", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTribRegIBSMun { get; set; }

        /// <summary>
        /// Alíquota da CBS.  Informar como seria a Alíquota caso não cumprida a condição resolutória/suspensiva.
        /// </summary>
        /// <value>Alíquota da CBS.  Informar como seria a Alíquota caso não cumprida a condição resolutória/suspensiva.</value>
        [DataMember(Name = "pAliqEfetRegCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pAliqEfetRegCBS { get; set; }

        /// <summary>
        /// Valor da CBS.  Informar como seria o valor do Tributo caso não cumprida a condição resolutória/suspensiva.
        /// </summary>
        /// <value>Valor da CBS.  Informar como seria o valor do Tributo caso não cumprida a condição resolutória/suspensiva.</value>
        [DataMember(Name = "vTribRegCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTribRegCBS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazTribRegularOS {\n");
            sb.Append("  CSTReg: ").Append(CSTReg).Append("\n");
            sb.Append("  cClassTribReg: ").Append(cClassTribReg).Append("\n");
            sb.Append("  pAliqEfetRegIBSUF: ").Append(pAliqEfetRegIBSUF).Append("\n");
            sb.Append("  vTribRegIBSUF: ").Append(vTribRegIBSUF).Append("\n");
            sb.Append("  pAliqEfetRegIBSMun: ").Append(pAliqEfetRegIBSMun).Append("\n");
            sb.Append("  vTribRegIBSMun: ").Append(vTribRegIBSMun).Append("\n");
            sb.Append("  pAliqEfetRegCBS: ").Append(pAliqEfetRegCBS).Append("\n");
            sb.Append("  vTribRegCBS: ").Append(vTribRegCBS).Append("\n");
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
            return this.Equals(input as CteOsSefazTribRegularOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazTribRegularOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazTribRegularOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazTribRegularOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CSTReg == input.CSTReg ||
                    (this.CSTReg != null &&
                    this.CSTReg.Equals(input.CSTReg))
                ) && 
                (
                    this.cClassTribReg == input.cClassTribReg ||
                    (this.cClassTribReg != null &&
                    this.cClassTribReg.Equals(input.cClassTribReg))
                ) && 
                (
                    this.pAliqEfetRegIBSUF == input.pAliqEfetRegIBSUF ||
                    (this.pAliqEfetRegIBSUF != null &&
                    this.pAliqEfetRegIBSUF.Equals(input.pAliqEfetRegIBSUF))
                ) && 
                (
                    this.vTribRegIBSUF == input.vTribRegIBSUF ||
                    (this.vTribRegIBSUF != null &&
                    this.vTribRegIBSUF.Equals(input.vTribRegIBSUF))
                ) && 
                (
                    this.pAliqEfetRegIBSMun == input.pAliqEfetRegIBSMun ||
                    (this.pAliqEfetRegIBSMun != null &&
                    this.pAliqEfetRegIBSMun.Equals(input.pAliqEfetRegIBSMun))
                ) && 
                (
                    this.vTribRegIBSMun == input.vTribRegIBSMun ||
                    (this.vTribRegIBSMun != null &&
                    this.vTribRegIBSMun.Equals(input.vTribRegIBSMun))
                ) && 
                (
                    this.pAliqEfetRegCBS == input.pAliqEfetRegCBS ||
                    (this.pAliqEfetRegCBS != null &&
                    this.pAliqEfetRegCBS.Equals(input.pAliqEfetRegCBS))
                ) && 
                (
                    this.vTribRegCBS == input.vTribRegCBS ||
                    (this.vTribRegCBS != null &&
                    this.vTribRegCBS.Equals(input.vTribRegCBS))
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
                if (this.CSTReg != null)
                {
                    hashCode = (hashCode * 59) + this.CSTReg.GetHashCode();
                }
                if (this.cClassTribReg != null)
                {
                    hashCode = (hashCode * 59) + this.cClassTribReg.GetHashCode();
                }
                if (this.pAliqEfetRegIBSUF != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqEfetRegIBSUF.GetHashCode();
                }
                if (this.vTribRegIBSUF != null)
                {
                    hashCode = (hashCode * 59) + this.vTribRegIBSUF.GetHashCode();
                }
                if (this.pAliqEfetRegIBSMun != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqEfetRegIBSMun.GetHashCode();
                }
                if (this.vTribRegIBSMun != null)
                {
                    hashCode = (hashCode * 59) + this.vTribRegIBSMun.GetHashCode();
                }
                if (this.pAliqEfetRegCBS != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqEfetRegCBS.GetHashCode();
                }
                if (this.vTribRegCBS != null)
                {
                    hashCode = (hashCode * 59) + this.vTribRegCBS.GetHashCode();
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
            // pAliqEfetRegIBSUF (decimal?) minimum
            if (this.pAliqEfetRegIBSUF < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pAliqEfetRegIBSUF, must be a value greater than or equal to 0.", new [] { "pAliqEfetRegIBSUF" });
            }

            // vTribRegIBSUF (decimal?) minimum
            if (this.vTribRegIBSUF < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTribRegIBSUF, must be a value greater than or equal to 0.", new [] { "vTribRegIBSUF" });
            }

            // pAliqEfetRegIBSMun (decimal?) minimum
            if (this.pAliqEfetRegIBSMun < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pAliqEfetRegIBSMun, must be a value greater than or equal to 0.", new [] { "pAliqEfetRegIBSMun" });
            }

            // vTribRegIBSMun (decimal?) minimum
            if (this.vTribRegIBSMun < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTribRegIBSMun, must be a value greater than or equal to 0.", new [] { "vTribRegIBSMun" });
            }

            // pAliqEfetRegCBS (decimal?) minimum
            if (this.pAliqEfetRegCBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pAliqEfetRegCBS, must be a value greater than or equal to 0.", new [] { "pAliqEfetRegCBS" });
            }

            // vTribRegCBS (decimal?) minimum
            if (this.vTribRegCBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTribRegCBS, must be a value greater than or equal to 0.", new [] { "vTribRegCBS" });
            }

            yield break;
        }
    }

}
