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
    /// Grupo de informações de documentos fiscais eletrônicos que se encontram no repositório nacional.
    /// </summary>
    [DataContract(Name = "RTCListaDocDFe")]
    public partial class RTCListaDocDFe : IEquatable<RTCListaDocDFe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCListaDocDFe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCListaDocDFe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCListaDocDFe" /> class.
        /// </summary>
        /// <param name="tipoChaveDFe">Documento fiscal a que se refere a chaveDfe que seja um dos documentos do Repositório Nacional. (required).</param>
        /// <param name="xTipoChaveDFe">Descrição da DF-e a que se refere a chaveDfe que seja um dos documentos do Repositório Nacional  Deve ser preenchido apenas quando \&quot;tipoChaveDFe &#x3D; 9 (Outro)\&quot;..</param>
        /// <param name="chaveDFe">Chave do Documento Fiscal eletrônico do repositório nacional referenciado para os casos de operações já tributadas. (required).</param>
        public RTCListaDocDFe(int? tipoChaveDFe = default(int?), string xTipoChaveDFe = default(string), string chaveDFe = default(string))
        {
            // to ensure "tipoChaveDFe" is required (not null)
            if (tipoChaveDFe == null)
            {
                throw new ArgumentNullException("tipoChaveDFe is a required property for RTCListaDocDFe and cannot be null");
            }
            this.tipoChaveDFe = tipoChaveDFe;
            // to ensure "chaveDFe" is required (not null)
            if (chaveDFe == null)
            {
                throw new ArgumentNullException("chaveDFe is a required property for RTCListaDocDFe and cannot be null");
            }
            this.chaveDFe = chaveDFe;
            this.xTipoChaveDFe = xTipoChaveDFe;
        }

        /// <summary>
        /// Documento fiscal a que se refere a chaveDfe que seja um dos documentos do Repositório Nacional.
        /// </summary>
        /// <value>Documento fiscal a que se refere a chaveDfe que seja um dos documentos do Repositório Nacional.</value>
        [DataMember(Name = "tipoChaveDFe", IsRequired = true, EmitDefaultValue = true)]
        public int? tipoChaveDFe { get; set; }

        /// <summary>
        /// Descrição da DF-e a que se refere a chaveDfe que seja um dos documentos do Repositório Nacional  Deve ser preenchido apenas quando \&quot;tipoChaveDFe &#x3D; 9 (Outro)\&quot;.
        /// </summary>
        /// <value>Descrição da DF-e a que se refere a chaveDfe que seja um dos documentos do Repositório Nacional  Deve ser preenchido apenas quando \&quot;tipoChaveDFe &#x3D; 9 (Outro)\&quot;.</value>
        [DataMember(Name = "xTipoChaveDFe", EmitDefaultValue = true)]
        public string xTipoChaveDFe { get; set; }

        /// <summary>
        /// Chave do Documento Fiscal eletrônico do repositório nacional referenciado para os casos de operações já tributadas.
        /// </summary>
        /// <value>Chave do Documento Fiscal eletrônico do repositório nacional referenciado para os casos de operações já tributadas.</value>
        [DataMember(Name = "chaveDFe", IsRequired = true, EmitDefaultValue = true)]
        public string chaveDFe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCListaDocDFe {\n");
            sb.Append("  tipoChaveDFe: ").Append(tipoChaveDFe).Append("\n");
            sb.Append("  xTipoChaveDFe: ").Append(xTipoChaveDFe).Append("\n");
            sb.Append("  chaveDFe: ").Append(chaveDFe).Append("\n");
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
            return this.Equals(input as RTCListaDocDFe);
        }

        /// <summary>
        /// Returns true if RTCListaDocDFe instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCListaDocDFe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCListaDocDFe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tipoChaveDFe == input.tipoChaveDFe ||
                    (this.tipoChaveDFe != null &&
                    this.tipoChaveDFe.Equals(input.tipoChaveDFe))
                ) && 
                (
                    this.xTipoChaveDFe == input.xTipoChaveDFe ||
                    (this.xTipoChaveDFe != null &&
                    this.xTipoChaveDFe.Equals(input.xTipoChaveDFe))
                ) && 
                (
                    this.chaveDFe == input.chaveDFe ||
                    (this.chaveDFe != null &&
                    this.chaveDFe.Equals(input.chaveDFe))
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
                if (this.tipoChaveDFe != null)
                {
                    hashCode = (hashCode * 59) + this.tipoChaveDFe.GetHashCode();
                }
                if (this.xTipoChaveDFe != null)
                {
                    hashCode = (hashCode * 59) + this.xTipoChaveDFe.GetHashCode();
                }
                if (this.chaveDFe != null)
                {
                    hashCode = (hashCode * 59) + this.chaveDFe.GetHashCode();
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
            // xTipoChaveDFe (string) maxLength
            if (this.xTipoChaveDFe != null && this.xTipoChaveDFe.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xTipoChaveDFe, length must be less than 255.", new [] { "xTipoChaveDFe" });
            }

            // xTipoChaveDFe (string) minLength
            if (this.xTipoChaveDFe != null && this.xTipoChaveDFe.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xTipoChaveDFe, length must be greater than 1.", new [] { "xTipoChaveDFe" });
            }

            // chaveDFe (string) maxLength
            if (this.chaveDFe != null && this.chaveDFe.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for chaveDFe, length must be less than 50.", new [] { "chaveDFe" });
            }

            // chaveDFe (string) minLength
            if (this.chaveDFe != null && this.chaveDFe.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for chaveDFe, length must be greater than 1.", new [] { "chaveDFe" });
            }

            yield break;
        }
    }

}
