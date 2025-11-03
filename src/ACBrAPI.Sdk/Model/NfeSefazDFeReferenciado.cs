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
    /// Referenciamento de item de outros DFe.
    /// </summary>
    [DataContract(Name = "NfeSefazDFeReferenciado")]
    public partial class NfeSefazDFeReferenciado : IEquatable<NfeSefazDFeReferenciado>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDFeReferenciado" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazDFeReferenciado() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazDFeReferenciado" /> class.
        /// </summary>
        /// <param name="chaveAcesso">Chave de Acesso do DFe referenciado. (required).</param>
        /// <param name="nItem">Número do item do documento referenciado. Corresponde ao atributo nItem do elemento det do documento original..</param>
        public NfeSefazDFeReferenciado(string chaveAcesso = default(string), int? nItem = default(int?))
        {
            // to ensure "chaveAcesso" is required (not null)
            if (chaveAcesso == null)
            {
                throw new ArgumentNullException("chaveAcesso is a required property for NfeSefazDFeReferenciado and cannot be null");
            }
            this.chaveAcesso = chaveAcesso;
            this.nItem = nItem;
        }

        /// <summary>
        /// Chave de Acesso do DFe referenciado.
        /// </summary>
        /// <value>Chave de Acesso do DFe referenciado.</value>
        [DataMember(Name = "chaveAcesso", IsRequired = true, EmitDefaultValue = true)]
        public string chaveAcesso { get; set; }

        /// <summary>
        /// Número do item do documento referenciado. Corresponde ao atributo nItem do elemento det do documento original.
        /// </summary>
        /// <value>Número do item do documento referenciado. Corresponde ao atributo nItem do elemento det do documento original.</value>
        [DataMember(Name = "nItem", EmitDefaultValue = true)]
        public int? nItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazDFeReferenciado {\n");
            sb.Append("  chaveAcesso: ").Append(chaveAcesso).Append("\n");
            sb.Append("  nItem: ").Append(nItem).Append("\n");
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
            return this.Equals(input as NfeSefazDFeReferenciado);
        }

        /// <summary>
        /// Returns true if NfeSefazDFeReferenciado instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazDFeReferenciado to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazDFeReferenciado input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chaveAcesso == input.chaveAcesso ||
                    (this.chaveAcesso != null &&
                    this.chaveAcesso.Equals(input.chaveAcesso))
                ) && 
                (
                    this.nItem == input.nItem ||
                    (this.nItem != null &&
                    this.nItem.Equals(input.nItem))
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
                if (this.chaveAcesso != null)
                {
                    hashCode = (hashCode * 59) + this.chaveAcesso.GetHashCode();
                }
                if (this.nItem != null)
                {
                    hashCode = (hashCode * 59) + this.nItem.GetHashCode();
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
            // chaveAcesso (string) maxLength
            if (this.chaveAcesso != null && this.chaveAcesso.Length > 44)
            {
                yield return new ValidationResult("Invalid value for chaveAcesso, length must be less than 44.", new [] { "chaveAcesso" });
            }

            // nItem (int?) maximum
            if (this.nItem > (int?)990)
            {
                yield return new ValidationResult("Invalid value for nItem, must be a value less than or equal to 990.", new [] { "nItem" });
            }

            // nItem (int?) minimum
            if (this.nItem < (int?)1)
            {
                yield return new ValidationResult("Invalid value for nItem, must be a value greater than or equal to 1.", new [] { "nItem" });
            }

            yield break;
        }
    }

}
