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
    /// Grupo de Informações da devolução de tributos.
    /// </summary>
    [DataContract(Name = "CteOsSefazDevTribOS")]
    public partial class CteOsSefazDevTribOS : IEquatable<CteOsSefazDevTribOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazDevTribOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazDevTribOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazDevTribOS" /> class.
        /// </summary>
        /// <param name="vDevTrib">Valor do tributo devolvido. No fornecimento de energia elétrica, água, esgoto e  gás natural e em outras hipóteses definidas no regulamento. (required).</param>
        public CteOsSefazDevTribOS(decimal? vDevTrib = default(decimal?))
        {
            // to ensure "vDevTrib" is required (not null)
            if (vDevTrib == null)
            {
                throw new ArgumentNullException("vDevTrib is a required property for CteOsSefazDevTribOS and cannot be null");
            }
            this.vDevTrib = vDevTrib;
        }

        /// <summary>
        /// Valor do tributo devolvido. No fornecimento de energia elétrica, água, esgoto e  gás natural e em outras hipóteses definidas no regulamento.
        /// </summary>
        /// <value>Valor do tributo devolvido. No fornecimento de energia elétrica, água, esgoto e  gás natural e em outras hipóteses definidas no regulamento.</value>
        [DataMember(Name = "vDevTrib", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDevTrib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazDevTribOS {\n");
            sb.Append("  vDevTrib: ").Append(vDevTrib).Append("\n");
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
            return this.Equals(input as CteOsSefazDevTribOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazDevTribOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazDevTribOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazDevTribOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vDevTrib == input.vDevTrib ||
                    (this.vDevTrib != null &&
                    this.vDevTrib.Equals(input.vDevTrib))
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
                if (this.vDevTrib != null)
                {
                    hashCode = (hashCode * 59) + this.vDevTrib.GetHashCode();
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
            // vDevTrib (decimal?) minimum
            if (this.vDevTrib < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDevTrib, must be a value greater than or equal to 0.", new [] { "vDevTrib" });
            }

            yield break;
        }
    }

}
