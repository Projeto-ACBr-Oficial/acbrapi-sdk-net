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
    /// Informações das DCe.
    /// </summary>
    [DataContract(Name = "CteSefazInfDCe")]
    public partial class CteSefazInfDCe : IEquatable<CteSefazInfDCe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfDCe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazInfDCe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazInfDCe" /> class.
        /// </summary>
        /// <param name="chave">Chave de acesso da DCe. (required).</param>
        public CteSefazInfDCe(string chave = default(string))
        {
            // to ensure "chave" is required (not null)
            if (chave == null)
            {
                throw new ArgumentNullException("chave is a required property for CteSefazInfDCe and cannot be null");
            }
            this.chave = chave;
        }

        /// <summary>
        /// Chave de acesso da DCe.
        /// </summary>
        /// <value>Chave de acesso da DCe.</value>
        [DataMember(Name = "chave", IsRequired = true, EmitDefaultValue = true)]
        public string chave { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazInfDCe {\n");
            sb.Append("  chave: ").Append(chave).Append("\n");
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
            return this.Equals(input as CteSefazInfDCe);
        }

        /// <summary>
        /// Returns true if CteSefazInfDCe instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazInfDCe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazInfDCe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chave == input.chave ||
                    (this.chave != null &&
                    this.chave.Equals(input.chave))
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
                if (this.chave != null)
                {
                    hashCode = (hashCode * 59) + this.chave.GetHashCode();
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
            // chave (string) maxLength
            if (this.chave != null && this.chave.Length > 44)
            {
                yield return new ValidationResult("Invalid value for chave, length must be less than 44.", new [] { "chave" });
            }

            yield break;
        }
    }

}
