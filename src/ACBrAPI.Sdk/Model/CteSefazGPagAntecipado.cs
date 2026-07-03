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
    /// Grupo de antecipação de pagamento.  Informado para abater as parcelas de antecipação de  pagamento, conforme Art. 10. § 4º.
    /// </summary>
    [DataContract(Name = "CteSefazGPagAntecipado")]
    public partial class CteSefazGPagAntecipado : IEquatable<CteSefazGPagAntecipado>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazGPagAntecipado" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazGPagAntecipado() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazGPagAntecipado" /> class.
        /// </summary>
        /// <param name="chCTePagAnt">Chave de acesso do CTe de antecipação de pagamento.  Referência a CTe emitido anteriormente, referente a pagamento antecipado. (required).</param>
        public CteSefazGPagAntecipado(string chCTePagAnt = default(string))
        {
            // to ensure "chCTePagAnt" is required (not null)
            if (chCTePagAnt == null)
            {
                throw new ArgumentNullException("chCTePagAnt is a required property for CteSefazGPagAntecipado and cannot be null");
            }
            this.chCTePagAnt = chCTePagAnt;
        }

        /// <summary>
        /// Chave de acesso do CTe de antecipação de pagamento.  Referência a CTe emitido anteriormente, referente a pagamento antecipado.
        /// </summary>
        /// <value>Chave de acesso do CTe de antecipação de pagamento.  Referência a CTe emitido anteriormente, referente a pagamento antecipado.</value>
        [DataMember(Name = "chCTePagAnt", IsRequired = true, EmitDefaultValue = true)]
        public string chCTePagAnt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazGPagAntecipado {\n");
            sb.Append("  chCTePagAnt: ").Append(chCTePagAnt).Append("\n");
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
            return this.Equals(input as CteSefazGPagAntecipado);
        }

        /// <summary>
        /// Returns true if CteSefazGPagAntecipado instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazGPagAntecipado to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazGPagAntecipado input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chCTePagAnt == input.chCTePagAnt ||
                    (this.chCTePagAnt != null &&
                    this.chCTePagAnt.Equals(input.chCTePagAnt))
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
                if (this.chCTePagAnt != null)
                {
                    hashCode = (hashCode * 59) + this.chCTePagAnt.GetHashCode();
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
            // chCTePagAnt (string) maxLength
            if (this.chCTePagAnt != null && this.chCTePagAnt.Length > 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for chCTePagAnt, length must be less than 44.", new [] { "chCTePagAnt" });
            }

            yield break;
        }
    }

}
