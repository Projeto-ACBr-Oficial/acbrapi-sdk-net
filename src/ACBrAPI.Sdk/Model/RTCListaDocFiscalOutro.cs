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
    /// Grupo de informações de documento fiscais, eletrônicos ou não, que não se encontram no repositório nacional.
    /// </summary>
    [DataContract(Name = "RTCListaDocFiscalOutro")]
    public partial class RTCListaDocFiscalOutro : IEquatable<RTCListaDocFiscalOutro>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCListaDocFiscalOutro" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCListaDocFiscalOutro() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCListaDocFiscalOutro" /> class.
        /// </summary>
        /// <param name="cMunDocFiscal">Código do município emissor do documento fiscal que não se encontra no repositório nacional. (required).</param>
        /// <param name="nDocFiscal">Número do documento fiscal que não se encontra no repositório nacional. (required).</param>
        /// <param name="xDocFiscal">Descrição do documento fiscal. (required).</param>
        public RTCListaDocFiscalOutro(int? cMunDocFiscal = default(int?), string nDocFiscal = default(string), string xDocFiscal = default(string))
        {
            // to ensure "cMunDocFiscal" is required (not null)
            if (cMunDocFiscal == null)
            {
                throw new ArgumentNullException("cMunDocFiscal is a required property for RTCListaDocFiscalOutro and cannot be null");
            }
            this.cMunDocFiscal = cMunDocFiscal;
            // to ensure "nDocFiscal" is required (not null)
            if (nDocFiscal == null)
            {
                throw new ArgumentNullException("nDocFiscal is a required property for RTCListaDocFiscalOutro and cannot be null");
            }
            this.nDocFiscal = nDocFiscal;
            // to ensure "xDocFiscal" is required (not null)
            if (xDocFiscal == null)
            {
                throw new ArgumentNullException("xDocFiscal is a required property for RTCListaDocFiscalOutro and cannot be null");
            }
            this.xDocFiscal = xDocFiscal;
        }

        /// <summary>
        /// Código do município emissor do documento fiscal que não se encontra no repositório nacional.
        /// </summary>
        /// <value>Código do município emissor do documento fiscal que não se encontra no repositório nacional.</value>
        [DataMember(Name = "cMunDocFiscal", IsRequired = true, EmitDefaultValue = true)]
        public int? cMunDocFiscal { get; set; }

        /// <summary>
        /// Número do documento fiscal que não se encontra no repositório nacional.
        /// </summary>
        /// <value>Número do documento fiscal que não se encontra no repositório nacional.</value>
        [DataMember(Name = "nDocFiscal", IsRequired = true, EmitDefaultValue = true)]
        public string nDocFiscal { get; set; }

        /// <summary>
        /// Descrição do documento fiscal.
        /// </summary>
        /// <value>Descrição do documento fiscal.</value>
        [DataMember(Name = "xDocFiscal", IsRequired = true, EmitDefaultValue = true)]
        public string xDocFiscal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCListaDocFiscalOutro {\n");
            sb.Append("  cMunDocFiscal: ").Append(cMunDocFiscal).Append("\n");
            sb.Append("  nDocFiscal: ").Append(nDocFiscal).Append("\n");
            sb.Append("  xDocFiscal: ").Append(xDocFiscal).Append("\n");
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
            return this.Equals(input as RTCListaDocFiscalOutro);
        }

        /// <summary>
        /// Returns true if RTCListaDocFiscalOutro instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCListaDocFiscalOutro to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCListaDocFiscalOutro input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cMunDocFiscal == input.cMunDocFiscal ||
                    (this.cMunDocFiscal != null &&
                    this.cMunDocFiscal.Equals(input.cMunDocFiscal))
                ) && 
                (
                    this.nDocFiscal == input.nDocFiscal ||
                    (this.nDocFiscal != null &&
                    this.nDocFiscal.Equals(input.nDocFiscal))
                ) && 
                (
                    this.xDocFiscal == input.xDocFiscal ||
                    (this.xDocFiscal != null &&
                    this.xDocFiscal.Equals(input.xDocFiscal))
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
                if (this.cMunDocFiscal != null)
                {
                    hashCode = (hashCode * 59) + this.cMunDocFiscal.GetHashCode();
                }
                if (this.nDocFiscal != null)
                {
                    hashCode = (hashCode * 59) + this.nDocFiscal.GetHashCode();
                }
                if (this.xDocFiscal != null)
                {
                    hashCode = (hashCode * 59) + this.xDocFiscal.GetHashCode();
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
            // cMunDocFiscal (int?) maximum
            if (this.cMunDocFiscal > (int?)9999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cMunDocFiscal, must be a value less than or equal to 9999999.", new [] { "cMunDocFiscal" });
            }

            // cMunDocFiscal (int?) minimum
            if (this.cMunDocFiscal < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cMunDocFiscal, must be a value greater than or equal to 0.", new [] { "cMunDocFiscal" });
            }

            // nDocFiscal (string) maxLength
            if (this.nDocFiscal != null && this.nDocFiscal.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDocFiscal, length must be less than 255.", new [] { "nDocFiscal" });
            }

            // nDocFiscal (string) minLength
            if (this.nDocFiscal != null && this.nDocFiscal.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDocFiscal, length must be greater than 1.", new [] { "nDocFiscal" });
            }

            // xDocFiscal (string) maxLength
            if (this.xDocFiscal != null && this.xDocFiscal.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xDocFiscal, length must be less than 255.", new [] { "xDocFiscal" });
            }

            // xDocFiscal (string) minLength
            if (this.xDocFiscal != null && this.xDocFiscal.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xDocFiscal, length must be greater than 1.", new [] { "xDocFiscal" });
            }

            yield break;
        }
    }

}
