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
    /// Grupo de Informações da devolução de tributos.
    /// </summary>
    [DataContract(Name = "NfcomSefazDevTrib")]
    public partial class NfcomSefazDevTrib : IEquatable<NfcomSefazDevTrib>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazDevTrib" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazDevTrib() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazDevTrib" /> class.
        /// </summary>
        /// <param name="pDevTrib">Percentual de devolução do tributo, conforme LC 214/25 art. 118..</param>
        /// <param name="vDevTrib">Valor do tributo devolvido. (“cashback” de desconto na própria Nota Fiscal / Fatura). (required).</param>
        public NfcomSefazDevTrib(decimal? pDevTrib = default(decimal?), decimal? vDevTrib = default(decimal?))
        {
            // to ensure "vDevTrib" is required (not null)
            if (vDevTrib == null)
            {
                throw new ArgumentNullException("vDevTrib is a required property for NfcomSefazDevTrib and cannot be null");
            }
            this.vDevTrib = vDevTrib;
            this.pDevTrib = pDevTrib;
        }

        /// <summary>
        /// Percentual de devolução do tributo, conforme LC 214/25 art. 118.
        /// </summary>
        /// <value>Percentual de devolução do tributo, conforme LC 214/25 art. 118.</value>
        [DataMember(Name = "pDevTrib", EmitDefaultValue = true)]
        public decimal? pDevTrib { get; set; }

        /// <summary>
        /// Valor do tributo devolvido. (“cashback” de desconto na própria Nota Fiscal / Fatura).
        /// </summary>
        /// <value>Valor do tributo devolvido. (“cashback” de desconto na própria Nota Fiscal / Fatura).</value>
        [DataMember(Name = "vDevTrib", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDevTrib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazDevTrib {\n");
            sb.Append("  pDevTrib: ").Append(pDevTrib).Append("\n");
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
            return this.Equals(input as NfcomSefazDevTrib);
        }

        /// <summary>
        /// Returns true if NfcomSefazDevTrib instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazDevTrib to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazDevTrib input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pDevTrib == input.pDevTrib ||
                    (this.pDevTrib != null &&
                    this.pDevTrib.Equals(input.pDevTrib))
                ) && 
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
                if (this.pDevTrib != null)
                {
                    hashCode = (hashCode * 59) + this.pDevTrib.GetHashCode();
                }
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // pDevTrib (decimal?) minimum
            if (this.pDevTrib < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pDevTrib, must be a value greater than or equal to 0.", new [] { "pDevTrib" });
            }

            // vDevTrib (decimal?) minimum
            if (this.vDevTrib < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vDevTrib, must be a value greater than or equal to 0.", new [] { "vDevTrib" });
            }

            yield break;
        }
    }

}
