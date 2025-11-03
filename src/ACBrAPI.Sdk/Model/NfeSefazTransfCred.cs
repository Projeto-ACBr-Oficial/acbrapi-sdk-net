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
    /// Informar essa opção da Choice para o CST 800.
    /// </summary>
    [DataContract(Name = "NfeSefazTransfCred")]
    public partial class NfeSefazTransfCred : IEquatable<NfeSefazTransfCred>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazTransfCred" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazTransfCred() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazTransfCred" /> class.
        /// </summary>
        /// <param name="vIBS">Valor do IBS a ser transferido. (required).</param>
        /// <param name="vCBS">Valor da CBS a ser transferida. (required).</param>
        public NfeSefazTransfCred(decimal? vIBS = default(decimal?), decimal? vCBS = default(decimal?))
        {
            // to ensure "vIBS" is required (not null)
            if (vIBS == null)
            {
                throw new ArgumentNullException("vIBS is a required property for NfeSefazTransfCred and cannot be null");
            }
            this.vIBS = vIBS;
            // to ensure "vCBS" is required (not null)
            if (vCBS == null)
            {
                throw new ArgumentNullException("vCBS is a required property for NfeSefazTransfCred and cannot be null");
            }
            this.vCBS = vCBS;
        }

        /// <summary>
        /// Valor do IBS a ser transferido.
        /// </summary>
        /// <value>Valor do IBS a ser transferido.</value>
        [DataMember(Name = "vIBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBS { get; set; }

        /// <summary>
        /// Valor da CBS a ser transferida.
        /// </summary>
        /// <value>Valor da CBS a ser transferida.</value>
        [DataMember(Name = "vCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazTransfCred {\n");
            sb.Append("  vIBS: ").Append(vIBS).Append("\n");
            sb.Append("  vCBS: ").Append(vCBS).Append("\n");
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
            return this.Equals(input as NfeSefazTransfCred);
        }

        /// <summary>
        /// Returns true if NfeSefazTransfCred instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazTransfCred to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazTransfCred input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vIBS == input.vIBS ||
                    (this.vIBS != null &&
                    this.vIBS.Equals(input.vIBS))
                ) && 
                (
                    this.vCBS == input.vCBS ||
                    (this.vCBS != null &&
                    this.vCBS.Equals(input.vCBS))
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
                if (this.vIBS != null)
                {
                    hashCode = (hashCode * 59) + this.vIBS.GetHashCode();
                }
                if (this.vCBS != null)
                {
                    hashCode = (hashCode * 59) + this.vCBS.GetHashCode();
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
            // vIBS (decimal?) minimum
            if (this.vIBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIBS, must be a value greater than or equal to 0.", new [] { "vIBS" });
            }

            // vCBS (decimal?) minimum
            if (this.vCBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCBS, must be a value greater than or equal to 0.", new [] { "vCBS" });
            }

            yield break;
        }
    }

}
