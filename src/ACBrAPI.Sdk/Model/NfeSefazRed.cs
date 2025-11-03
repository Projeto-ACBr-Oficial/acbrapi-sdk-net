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
    /// Grupo de campos da redução de aliquota.
    /// </summary>
    [DataContract(Name = "NfeSefazRed")]
    public partial class NfeSefazRed : IEquatable<NfeSefazRed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazRed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRed" /> class.
        /// </summary>
        /// <param name="pRedAliq">Percentual de redução de aliquota do cClassTrib. (required).</param>
        /// <param name="pAliqEfet">Aliquota Efetiva que será aplicada a Base de Calculo. (required).</param>
        public NfeSefazRed(decimal? pRedAliq = default(decimal?), decimal? pAliqEfet = default(decimal?))
        {
            // to ensure "pRedAliq" is required (not null)
            if (pRedAliq == null)
            {
                throw new ArgumentNullException("pRedAliq is a required property for NfeSefazRed and cannot be null");
            }
            this.pRedAliq = pRedAliq;
            // to ensure "pAliqEfet" is required (not null)
            if (pAliqEfet == null)
            {
                throw new ArgumentNullException("pAliqEfet is a required property for NfeSefazRed and cannot be null");
            }
            this.pAliqEfet = pAliqEfet;
        }

        /// <summary>
        /// Percentual de redução de aliquota do cClassTrib.
        /// </summary>
        /// <value>Percentual de redução de aliquota do cClassTrib.</value>
        [DataMember(Name = "pRedAliq", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pRedAliq { get; set; }

        /// <summary>
        /// Aliquota Efetiva que será aplicada a Base de Calculo.
        /// </summary>
        /// <value>Aliquota Efetiva que será aplicada a Base de Calculo.</value>
        [DataMember(Name = "pAliqEfet", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pAliqEfet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazRed {\n");
            sb.Append("  pRedAliq: ").Append(pRedAliq).Append("\n");
            sb.Append("  pAliqEfet: ").Append(pAliqEfet).Append("\n");
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
            return this.Equals(input as NfeSefazRed);
        }

        /// <summary>
        /// Returns true if NfeSefazRed instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazRed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazRed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pRedAliq == input.pRedAliq ||
                    (this.pRedAliq != null &&
                    this.pRedAliq.Equals(input.pRedAliq))
                ) && 
                (
                    this.pAliqEfet == input.pAliqEfet ||
                    (this.pAliqEfet != null &&
                    this.pAliqEfet.Equals(input.pAliqEfet))
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
                if (this.pRedAliq != null)
                {
                    hashCode = (hashCode * 59) + this.pRedAliq.GetHashCode();
                }
                if (this.pAliqEfet != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqEfet.GetHashCode();
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
            // pRedAliq (decimal?) minimum
            if (this.pRedAliq < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pRedAliq, must be a value greater than or equal to 0.", new [] { "pRedAliq" });
            }

            // pAliqEfet (decimal?) minimum
            if (this.pAliqEfet < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pAliqEfet, must be a value greater than or equal to 0.", new [] { "pAliqEfet" });
            }

            yield break;
        }
    }

}
