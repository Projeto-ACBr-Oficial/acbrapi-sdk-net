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
    /// Grupo de informações das NFe que foram entregues do CTe relacionado.
    /// </summary>
    [DataContract(Name = "MdfeSefazInfNFePrestParcial")]
    public partial class MdfeSefazInfNFePrestParcial : IEquatable<MdfeSefazInfNFePrestParcial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfNFePrestParcial" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MdfeSefazInfNFePrestParcial() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MdfeSefazInfNFePrestParcial" /> class.
        /// </summary>
        /// <param name="chNFe">Nota Fiscal Eletrônica. (required).</param>
        public MdfeSefazInfNFePrestParcial(string chNFe = default(string))
        {
            // to ensure "chNFe" is required (not null)
            if (chNFe == null)
            {
                throw new ArgumentNullException("chNFe is a required property for MdfeSefazInfNFePrestParcial and cannot be null");
            }
            this.chNFe = chNFe;
        }

        /// <summary>
        /// Nota Fiscal Eletrônica.
        /// </summary>
        /// <value>Nota Fiscal Eletrônica.</value>
        [DataMember(Name = "chNFe", IsRequired = true, EmitDefaultValue = true)]
        public string chNFe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MdfeSefazInfNFePrestParcial {\n");
            sb.Append("  chNFe: ").Append(chNFe).Append("\n");
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
            return this.Equals(input as MdfeSefazInfNFePrestParcial);
        }

        /// <summary>
        /// Returns true if MdfeSefazInfNFePrestParcial instances are equal
        /// </summary>
        /// <param name="input">Instance of MdfeSefazInfNFePrestParcial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MdfeSefazInfNFePrestParcial input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chNFe == input.chNFe ||
                    (this.chNFe != null &&
                    this.chNFe.Equals(input.chNFe))
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
                if (this.chNFe != null)
                {
                    hashCode = (hashCode * 59) + this.chNFe.GetHashCode();
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
            // chNFe (string) maxLength
            if (this.chNFe != null && this.chNFe.Length > 44)
            {
                yield return new ValidationResult("Invalid value for chNFe, length must be less than 44.", new [] { "chNFe" });
            }

            yield break;
        }
    }

}
