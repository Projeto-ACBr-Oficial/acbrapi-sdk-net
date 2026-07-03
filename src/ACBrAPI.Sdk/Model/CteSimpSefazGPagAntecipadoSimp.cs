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
    /// Grupo de antecipação de pagamento  Permite informar apenas quando tpPagAnt&#x3D;3.  Informado para abater as parcelas de antecipação de  pagamento, conforme Art. 10. § 4º.
    /// </summary>
    [DataContract(Name = "CteSimpSefazGPagAntecipadoSimp")]
    public partial class CteSimpSefazGPagAntecipadoSimp : IEquatable<CteSimpSefazGPagAntecipadoSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazGPagAntecipadoSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazGPagAntecipadoSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazGPagAntecipadoSimp" /> class.
        /// </summary>
        /// <param name="chDFePagAnt">Chave de acesso do DFe de antecipação de pagamento (com tpPagAnt&#x3D;1).  Referência a CTe emitido anteriormente, referente a pagamento antecipado. (required).</param>
        public CteSimpSefazGPagAntecipadoSimp(string chDFePagAnt = default(string))
        {
            // to ensure "chDFePagAnt" is required (not null)
            if (chDFePagAnt == null)
            {
                throw new ArgumentNullException("chDFePagAnt is a required property for CteSimpSefazGPagAntecipadoSimp and cannot be null");
            }
            this.chDFePagAnt = chDFePagAnt;
        }

        /// <summary>
        /// Chave de acesso do DFe de antecipação de pagamento (com tpPagAnt&#x3D;1).  Referência a CTe emitido anteriormente, referente a pagamento antecipado.
        /// </summary>
        /// <value>Chave de acesso do DFe de antecipação de pagamento (com tpPagAnt&#x3D;1).  Referência a CTe emitido anteriormente, referente a pagamento antecipado.</value>
        [DataMember(Name = "chDFePagAnt", IsRequired = true, EmitDefaultValue = true)]
        public string chDFePagAnt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazGPagAntecipadoSimp {\n");
            sb.Append("  chDFePagAnt: ").Append(chDFePagAnt).Append("\n");
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
            return this.Equals(input as CteSimpSefazGPagAntecipadoSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazGPagAntecipadoSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazGPagAntecipadoSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazGPagAntecipadoSimp input)
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

            yield break;
        }
    }

}
