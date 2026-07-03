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
    /// Grupo de antecipação de pagamento  Permite informar apenas quando tpPagAnt&#x3D;3.  Informado para abater as parcelas de antecipação de  pagamento.
    /// </summary>
    [DataContract(Name = "NfcomSefazGPagAntecipado")]
    public partial class NfcomSefazGPagAntecipado : IEquatable<NfcomSefazGPagAntecipado>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGPagAntecipado" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGPagAntecipado() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGPagAntecipado" /> class.
        /// </summary>
        /// <param name="chDFePagAnt">Chave de acesso da nota de antecipação de pagamento (com tpPagAnt&#x3D;1 ou 2).  Referência a DFe emitido anteriormente, referente a pagamento antecipado. (required).</param>
        /// <param name="nItemPagAnt">Número do item do DFe de antecipação para referência direta a um item..</param>
        public NfcomSefazGPagAntecipado(string chDFePagAnt = default(string), string nItemPagAnt = default(string))
        {
            // to ensure "chDFePagAnt" is required (not null)
            if (chDFePagAnt == null)
            {
                throw new ArgumentNullException("chDFePagAnt is a required property for NfcomSefazGPagAntecipado and cannot be null");
            }
            this.chDFePagAnt = chDFePagAnt;
            this.nItemPagAnt = nItemPagAnt;
        }

        /// <summary>
        /// Chave de acesso da nota de antecipação de pagamento (com tpPagAnt&#x3D;1 ou 2).  Referência a DFe emitido anteriormente, referente a pagamento antecipado.
        /// </summary>
        /// <value>Chave de acesso da nota de antecipação de pagamento (com tpPagAnt&#x3D;1 ou 2).  Referência a DFe emitido anteriormente, referente a pagamento antecipado.</value>
        [DataMember(Name = "chDFePagAnt", IsRequired = true, EmitDefaultValue = true)]
        public string chDFePagAnt { get; set; }

        /// <summary>
        /// Número do item do DFe de antecipação para referência direta a um item.
        /// </summary>
        /// <value>Número do item do DFe de antecipação para referência direta a um item.</value>
        [DataMember(Name = "nItemPagAnt", EmitDefaultValue = true)]
        public string nItemPagAnt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGPagAntecipado {\n");
            sb.Append("  chDFePagAnt: ").Append(chDFePagAnt).Append("\n");
            sb.Append("  nItemPagAnt: ").Append(nItemPagAnt).Append("\n");
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
            return this.Equals(input as NfcomSefazGPagAntecipado);
        }

        /// <summary>
        /// Returns true if NfcomSefazGPagAntecipado instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGPagAntecipado to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGPagAntecipado input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chDFePagAnt == input.chDFePagAnt ||
                    (this.chDFePagAnt != null &&
                    this.chDFePagAnt.Equals(input.chDFePagAnt))
                ) && 
                (
                    this.nItemPagAnt == input.nItemPagAnt ||
                    (this.nItemPagAnt != null &&
                    this.nItemPagAnt.Equals(input.nItemPagAnt))
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
                if (this.chDFePagAnt != null)
                {
                    hashCode = (hashCode * 59) + this.chDFePagAnt.GetHashCode();
                }
                if (this.nItemPagAnt != null)
                {
                    hashCode = (hashCode * 59) + this.nItemPagAnt.GetHashCode();
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
            // chDFePagAnt (string) maxLength
            if (this.chDFePagAnt != null && this.chDFePagAnt.Length > 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for chDFePagAnt, length must be less than 44.", new [] { "chDFePagAnt" });
            }

            // nItemPagAnt (string) maxLength
            if (this.nItemPagAnt != null && this.nItemPagAnt.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nItemPagAnt, length must be less than 3.", new [] { "nItemPagAnt" });
            }

            // nItemPagAnt (string) minLength
            if (this.nItemPagAnt != null && this.nItemPagAnt.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nItemPagAnt, length must be greater than 1.", new [] { "nItemPagAnt" });
            }

            yield break;
        }
    }

}
