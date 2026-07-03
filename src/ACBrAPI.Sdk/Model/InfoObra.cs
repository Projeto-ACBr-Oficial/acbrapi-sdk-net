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
    /// Grupo de informações do DPS relativas à serviço de obra.
    /// </summary>
    [DataContract(Name = "InfoObra")]
    public partial class InfoObra : IEquatable<InfoObra>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoObra" /> class.
        /// </summary>
        /// <param name="inscImobFisc">Inscrição imobiliária fiscal (código fornecido pela Prefeitura Municipal para a identificação da obra ou para fins de recolhimento do IPTU)..</param>
        /// <param name="cObra">Número de identificação da obra.  Cadastro Nacional de Obras (CNO) ou Cadastro Específico do INSS (CEI)..</param>
        /// <param name="cCIB">Código do Cadastro Imobiliário Brasileiro - CIB..</param>
        /// <param name="end">end.</param>
        public InfoObra(string inscImobFisc = default(string), string cObra = default(string), string cCIB = default(string), EnderObraEvento end = default(EnderObraEvento))
        {
            this.inscImobFisc = inscImobFisc;
            this.cObra = cObra;
            this.cCIB = cCIB;
            this.end = end;
        }

        /// <summary>
        /// Inscrição imobiliária fiscal (código fornecido pela Prefeitura Municipal para a identificação da obra ou para fins de recolhimento do IPTU).
        /// </summary>
        /// <value>Inscrição imobiliária fiscal (código fornecido pela Prefeitura Municipal para a identificação da obra ou para fins de recolhimento do IPTU).</value>
        [DataMember(Name = "inscImobFisc", EmitDefaultValue = true)]
        public string inscImobFisc { get; set; }

        /// <summary>
        /// Número de identificação da obra.  Cadastro Nacional de Obras (CNO) ou Cadastro Específico do INSS (CEI).
        /// </summary>
        /// <value>Número de identificação da obra.  Cadastro Nacional de Obras (CNO) ou Cadastro Específico do INSS (CEI).</value>
        [DataMember(Name = "cObra", EmitDefaultValue = true)]
        public string cObra { get; set; }

        /// <summary>
        /// Código do Cadastro Imobiliário Brasileiro - CIB.
        /// </summary>
        /// <value>Código do Cadastro Imobiliário Brasileiro - CIB.</value>
        [DataMember(Name = "cCIB", EmitDefaultValue = true)]
        public string cCIB { get; set; }

        /// <summary>
        /// Gets or Sets end
        /// </summary>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        public EnderObraEvento end { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoObra {\n");
            sb.Append("  inscImobFisc: ").Append(inscImobFisc).Append("\n");
            sb.Append("  cObra: ").Append(cObra).Append("\n");
            sb.Append("  cCIB: ").Append(cCIB).Append("\n");
            sb.Append("  end: ").Append(end).Append("\n");
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
            return this.Equals(input as InfoObra);
        }

        /// <summary>
        /// Returns true if InfoObra instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoObra to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoObra input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.inscImobFisc == input.inscImobFisc ||
                    (this.inscImobFisc != null &&
                    this.inscImobFisc.Equals(input.inscImobFisc))
                ) && 
                (
                    this.cObra == input.cObra ||
                    (this.cObra != null &&
                    this.cObra.Equals(input.cObra))
                ) && 
                (
                    this.cCIB == input.cCIB ||
                    (this.cCIB != null &&
                    this.cCIB.Equals(input.cCIB))
                ) && 
                (
                    this.end == input.end ||
                    (this.end != null &&
                    this.end.Equals(input.end))
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
                if (this.inscImobFisc != null)
                {
                    hashCode = (hashCode * 59) + this.inscImobFisc.GetHashCode();
                }
                if (this.cObra != null)
                {
                    hashCode = (hashCode * 59) + this.cObra.GetHashCode();
                }
                if (this.cCIB != null)
                {
                    hashCode = (hashCode * 59) + this.cCIB.GetHashCode();
                }
                if (this.end != null)
                {
                    hashCode = (hashCode * 59) + this.end.GetHashCode();
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
            // inscImobFisc (string) maxLength
            if (this.inscImobFisc != null && this.inscImobFisc.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for inscImobFisc, length must be less than 30.", new [] { "inscImobFisc" });
            }

            // inscImobFisc (string) minLength
            if (this.inscImobFisc != null && this.inscImobFisc.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for inscImobFisc, length must be greater than 1.", new [] { "inscImobFisc" });
            }

            // cObra (string) maxLength
            if (this.cObra != null && this.cObra.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cObra, length must be less than 30.", new [] { "cObra" });
            }

            // cObra (string) minLength
            if (this.cObra != null && this.cObra.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cObra, length must be greater than 1.", new [] { "cObra" });
            }

            // cCIB (string) maxLength
            if (this.cCIB != null && this.cCIB.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for cCIB, length must be less than 8.", new [] { "cCIB" });
            }

            yield break;
        }
    }

}
