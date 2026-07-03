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
    /// Grupo de informações do fornecedor do documento referenciado.
    /// </summary>
    [DataContract(Name = "RTCListaDocFornec")]
    public partial class RTCListaDocFornec : IEquatable<RTCListaDocFornec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCListaDocFornec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCListaDocFornec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCListaDocFornec" /> class.
        /// </summary>
        /// <param name="cNPJ">Número da inscrição no Cadastro Nacional de Pessoa Jurídica (CNPJ) do Fornecedor do serviço..</param>
        /// <param name="cPF">Número da inscrição no Cadastro de Pessoa Física (CPF) do Fornecedor do serviço..</param>
        /// <param name="nIF">Este elemento só deverá ser preenchido para fornecedores não residentes no Brasil..</param>
        /// <param name="cNaoNIF">Motivo para não informação do NIF:  * 0 - Não informado na nota de origem  * 1 - Dispensado do NIF  * 2 - Não exigência do NIF.</param>
        /// <param name="xNome">Nome / Razão Social do do Fornecedor do serviço. (required).</param>
        public RTCListaDocFornec(string cNPJ = default(string), string cPF = default(string), string nIF = default(string), int? cNaoNIF = default(int?), string xNome = default(string))
        {
            // to ensure "xNome" is required (not null)
            if (xNome == null)
            {
                throw new ArgumentNullException("xNome is a required property for RTCListaDocFornec and cannot be null");
            }
            this.xNome = xNome;
            this.CNPJ = cNPJ;
            this.CPF = cPF;
            this.NIF = nIF;
            this.cNaoNIF = cNaoNIF;
        }

        /// <summary>
        /// Número da inscrição no Cadastro Nacional de Pessoa Jurídica (CNPJ) do Fornecedor do serviço.
        /// </summary>
        /// <value>Número da inscrição no Cadastro Nacional de Pessoa Jurídica (CNPJ) do Fornecedor do serviço.</value>
        [DataMember(Name = "CNPJ", EmitDefaultValue = true)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Número da inscrição no Cadastro de Pessoa Física (CPF) do Fornecedor do serviço.
        /// </summary>
        /// <value>Número da inscrição no Cadastro de Pessoa Física (CPF) do Fornecedor do serviço.</value>
        [DataMember(Name = "CPF", EmitDefaultValue = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Este elemento só deverá ser preenchido para fornecedores não residentes no Brasil.
        /// </summary>
        /// <value>Este elemento só deverá ser preenchido para fornecedores não residentes no Brasil.</value>
        [DataMember(Name = "NIF", EmitDefaultValue = true)]
        public string NIF { get; set; }

        /// <summary>
        /// Motivo para não informação do NIF:  * 0 - Não informado na nota de origem  * 1 - Dispensado do NIF  * 2 - Não exigência do NIF
        /// </summary>
        /// <value>Motivo para não informação do NIF:  * 0 - Não informado na nota de origem  * 1 - Dispensado do NIF  * 2 - Não exigência do NIF</value>
        [DataMember(Name = "cNaoNIF", EmitDefaultValue = true)]
        public int? cNaoNIF { get; set; }

        /// <summary>
        /// Nome / Razão Social do do Fornecedor do serviço.
        /// </summary>
        /// <value>Nome / Razão Social do do Fornecedor do serviço.</value>
        [DataMember(Name = "xNome", IsRequired = true, EmitDefaultValue = true)]
        public string xNome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCListaDocFornec {\n");
            sb.Append("  CNPJ: ").Append(CNPJ).Append("\n");
            sb.Append("  CPF: ").Append(CPF).Append("\n");
            sb.Append("  NIF: ").Append(NIF).Append("\n");
            sb.Append("  cNaoNIF: ").Append(cNaoNIF).Append("\n");
            sb.Append("  xNome: ").Append(xNome).Append("\n");
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
            return this.Equals(input as RTCListaDocFornec);
        }

        /// <summary>
        /// Returns true if RTCListaDocFornec instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCListaDocFornec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCListaDocFornec input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CNPJ == input.CNPJ ||
                    (this.CNPJ != null &&
                    this.CNPJ.Equals(input.CNPJ))
                ) && 
                (
                    this.CPF == input.CPF ||
                    (this.CPF != null &&
                    this.CPF.Equals(input.CPF))
                ) && 
                (
                    this.NIF == input.NIF ||
                    (this.NIF != null &&
                    this.NIF.Equals(input.NIF))
                ) && 
                (
                    this.cNaoNIF == input.cNaoNIF ||
                    (this.cNaoNIF != null &&
                    this.cNaoNIF.Equals(input.cNaoNIF))
                ) && 
                (
                    this.xNome == input.xNome ||
                    (this.xNome != null &&
                    this.xNome.Equals(input.xNome))
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
                if (this.CNPJ != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJ.GetHashCode();
                }
                if (this.CPF != null)
                {
                    hashCode = (hashCode * 59) + this.CPF.GetHashCode();
                }
                if (this.NIF != null)
                {
                    hashCode = (hashCode * 59) + this.NIF.GetHashCode();
                }
                if (this.cNaoNIF != null)
                {
                    hashCode = (hashCode * 59) + this.cNaoNIF.GetHashCode();
                }
                if (this.xNome != null)
                {
                    hashCode = (hashCode * 59) + this.xNome.GetHashCode();
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
            // CNPJ (string) maxLength
            if (this.CNPJ != null && this.CNPJ.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CNPJ, length must be less than 14.", new [] { "CNPJ" });
            }

            // CPF (string) maxLength
            if (this.CPF != null && this.CPF.Length > 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CPF, length must be less than 11.", new [] { "CPF" });
            }

            // NIF (string) maxLength
            if (this.NIF != null && this.NIF.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NIF, length must be less than 40.", new [] { "NIF" });
            }

            // NIF (string) minLength
            if (this.NIF != null && this.NIF.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NIF, length must be greater than 1.", new [] { "NIF" });
            }

            // xNome (string) maxLength
            if (this.xNome != null && this.xNome.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xNome, length must be less than 150.", new [] { "xNome" });
            }

            // xNome (string) minLength
            if (this.xNome != null && this.xNome.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xNome, length must be greater than 1.", new [] { "xNome" });
            }

            yield break;
        }
    }

}
