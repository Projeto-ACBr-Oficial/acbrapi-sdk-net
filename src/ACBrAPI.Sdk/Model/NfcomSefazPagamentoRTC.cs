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
    /// Dados de cada pagamento previsto.
    /// </summary>
    [DataContract(Name = "NfcomSefazPagamentoRTC")]
    public partial class NfcomSefazPagamentoRTC : IEquatable<NfcomSefazPagamentoRTC>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazPagamentoRTC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazPagamentoRTC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazPagamentoRTC" /> class.
        /// </summary>
        /// <param name="nPag">Número sequencial do pagamento. (required).</param>
        /// <param name="idTransacao">ID específico da transação financeira conforme o meio de pagamento. (required).</param>
        /// <param name="tpMeioPgto">(Meio de pagamento utilizado (ver IT DFe 2026.001). (required).</param>
        /// <param name="cNPJReceb">CNPJ do recebedor do pagamento.  Informar zeros não significativos. (required).</param>
        /// <param name="cNPJBasePSP">CNPJ base da instituição financeira.  Informar zeros não significativos. (required).</param>
        public NfcomSefazPagamentoRTC(string nPag = default(string), string idTransacao = default(string), string tpMeioPgto = default(string), string cNPJReceb = default(string), string cNPJBasePSP = default(string))
        {
            // to ensure "nPag" is required (not null)
            if (nPag == null)
            {
                throw new ArgumentNullException("nPag is a required property for NfcomSefazPagamentoRTC and cannot be null");
            }
            this.nPag = nPag;
            // to ensure "idTransacao" is required (not null)
            if (idTransacao == null)
            {
                throw new ArgumentNullException("idTransacao is a required property for NfcomSefazPagamentoRTC and cannot be null");
            }
            this.idTransacao = idTransacao;
            // to ensure "tpMeioPgto" is required (not null)
            if (tpMeioPgto == null)
            {
                throw new ArgumentNullException("tpMeioPgto is a required property for NfcomSefazPagamentoRTC and cannot be null");
            }
            this.tpMeioPgto = tpMeioPgto;
            // to ensure "cNPJReceb" is required (not null)
            if (cNPJReceb == null)
            {
                throw new ArgumentNullException("cNPJReceb is a required property for NfcomSefazPagamentoRTC and cannot be null");
            }
            this.CNPJReceb = cNPJReceb;
            // to ensure "cNPJBasePSP" is required (not null)
            if (cNPJBasePSP == null)
            {
                throw new ArgumentNullException("cNPJBasePSP is a required property for NfcomSefazPagamentoRTC and cannot be null");
            }
            this.CNPJBasePSP = cNPJBasePSP;
        }

        /// <summary>
        /// Número sequencial do pagamento.
        /// </summary>
        /// <value>Número sequencial do pagamento.</value>
        [DataMember(Name = "nPag", IsRequired = true, EmitDefaultValue = true)]
        public string nPag { get; set; }

        /// <summary>
        /// ID específico da transação financeira conforme o meio de pagamento.
        /// </summary>
        /// <value>ID específico da transação financeira conforme o meio de pagamento.</value>
        [DataMember(Name = "idTransacao", IsRequired = true, EmitDefaultValue = true)]
        public string idTransacao { get; set; }

        /// <summary>
        /// (Meio de pagamento utilizado (ver IT DFe 2026.001).
        /// </summary>
        /// <value>(Meio de pagamento utilizado (ver IT DFe 2026.001).</value>
        [DataMember(Name = "tpMeioPgto", IsRequired = true, EmitDefaultValue = true)]
        public string tpMeioPgto { get; set; }

        /// <summary>
        /// CNPJ do recebedor do pagamento.  Informar zeros não significativos.
        /// </summary>
        /// <value>CNPJ do recebedor do pagamento.  Informar zeros não significativos.</value>
        [DataMember(Name = "CNPJReceb", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJReceb { get; set; }

        /// <summary>
        /// CNPJ base da instituição financeira.  Informar zeros não significativos.
        /// </summary>
        /// <value>CNPJ base da instituição financeira.  Informar zeros não significativos.</value>
        [DataMember(Name = "CNPJBasePSP", IsRequired = true, EmitDefaultValue = true)]
        public string CNPJBasePSP { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazPagamentoRTC {\n");
            sb.Append("  nPag: ").Append(nPag).Append("\n");
            sb.Append("  idTransacao: ").Append(idTransacao).Append("\n");
            sb.Append("  tpMeioPgto: ").Append(tpMeioPgto).Append("\n");
            sb.Append("  CNPJReceb: ").Append(CNPJReceb).Append("\n");
            sb.Append("  CNPJBasePSP: ").Append(CNPJBasePSP).Append("\n");
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
            return this.Equals(input as NfcomSefazPagamentoRTC);
        }

        /// <summary>
        /// Returns true if NfcomSefazPagamentoRTC instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazPagamentoRTC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazPagamentoRTC input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nPag == input.nPag ||
                    (this.nPag != null &&
                    this.nPag.Equals(input.nPag))
                ) && 
                (
                    this.idTransacao == input.idTransacao ||
                    (this.idTransacao != null &&
                    this.idTransacao.Equals(input.idTransacao))
                ) && 
                (
                    this.tpMeioPgto == input.tpMeioPgto ||
                    (this.tpMeioPgto != null &&
                    this.tpMeioPgto.Equals(input.tpMeioPgto))
                ) && 
                (
                    this.CNPJReceb == input.CNPJReceb ||
                    (this.CNPJReceb != null &&
                    this.CNPJReceb.Equals(input.CNPJReceb))
                ) && 
                (
                    this.CNPJBasePSP == input.CNPJBasePSP ||
                    (this.CNPJBasePSP != null &&
                    this.CNPJBasePSP.Equals(input.CNPJBasePSP))
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
                if (this.nPag != null)
                {
                    hashCode = (hashCode * 59) + this.nPag.GetHashCode();
                }
                if (this.idTransacao != null)
                {
                    hashCode = (hashCode * 59) + this.idTransacao.GetHashCode();
                }
                if (this.tpMeioPgto != null)
                {
                    hashCode = (hashCode * 59) + this.tpMeioPgto.GetHashCode();
                }
                if (this.CNPJReceb != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJReceb.GetHashCode();
                }
                if (this.CNPJBasePSP != null)
                {
                    hashCode = (hashCode * 59) + this.CNPJBasePSP.GetHashCode();
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
            // idTransacao (string) maxLength
            if (this.idTransacao != null && this.idTransacao.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for idTransacao, length must be less than 35.", new [] { "idTransacao" });
            }

            // idTransacao (string) minLength
            if (this.idTransacao != null && this.idTransacao.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for idTransacao, length must be greater than 2.", new [] { "idTransacao" });
            }

            yield break;
        }
    }

}
