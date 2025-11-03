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
    /// Informado para abater as parcelas de antecipação de pagamento, conforme Art. 10. § 4º.
    /// </summary>
    [DataContract(Name = "NfeSefazGPagAntecipado")]
    public partial class NfeSefazGPagAntecipado : IEquatable<NfeSefazGPagAntecipado>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGPagAntecipado" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGPagAntecipado() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGPagAntecipado" /> class.
        /// </summary>
        /// <param name="refNFe">Chave de acesso da NF-e de antecipação de pagamento. (required).</param>
        public NfeSefazGPagAntecipado(List<string> refNFe = default(List<string>))
        {
            // to ensure "refNFe" is required (not null)
            if (refNFe == null)
            {
                throw new ArgumentNullException("refNFe is a required property for NfeSefazGPagAntecipado and cannot be null");
            }
            this.refNFe = refNFe;
        }

        /// <summary>
        /// Chave de acesso da NF-e de antecipação de pagamento.
        /// </summary>
        /// <value>Chave de acesso da NF-e de antecipação de pagamento.</value>
        [DataMember(Name = "refNFe", IsRequired = true, EmitDefaultValue = true)]
        public List<string> refNFe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGPagAntecipado {\n");
            sb.Append("  refNFe: ").Append(refNFe).Append("\n");
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
            return this.Equals(input as NfeSefazGPagAntecipado);
        }

        /// <summary>
        /// Returns true if NfeSefazGPagAntecipado instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGPagAntecipado to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGPagAntecipado input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.refNFe == input.refNFe ||
                    this.refNFe != null &&
                    input.refNFe != null &&
                    this.refNFe.SequenceEqual(input.refNFe)
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
                if (this.refNFe != null)
                {
                    hashCode = (hashCode * 59) + this.refNFe.GetHashCode();
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
            yield break;
        }
    }

}
