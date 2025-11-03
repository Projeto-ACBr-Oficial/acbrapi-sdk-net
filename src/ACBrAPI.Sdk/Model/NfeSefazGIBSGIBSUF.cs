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
    /// Totalização do IBS de competência da UF.
    /// </summary>
    [DataContract(Name = "NfeSefazGIBS_GIBSUF")]
    public partial class NfeSefazGIBSGIBSUF : IEquatable<NfeSefazGIBSGIBSUF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGIBSGIBSUF" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGIBSGIBSUF() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGIBSGIBSUF" /> class.
        /// </summary>
        /// <param name="vDif">Total do Diferimento. (required).</param>
        /// <param name="vDevTrib">Total de devoluções de tributos. (required).</param>
        /// <param name="vIBSUF">Valor total do IBS Estadual. (required).</param>
        public NfeSefazGIBSGIBSUF(decimal? vDif = default(decimal?), decimal? vDevTrib = default(decimal?), decimal? vIBSUF = default(decimal?))
        {
            // to ensure "vDif" is required (not null)
            if (vDif == null)
            {
                throw new ArgumentNullException("vDif is a required property for NfeSefazGIBSGIBSUF and cannot be null");
            }
            this.vDif = vDif;
            // to ensure "vDevTrib" is required (not null)
            if (vDevTrib == null)
            {
                throw new ArgumentNullException("vDevTrib is a required property for NfeSefazGIBSGIBSUF and cannot be null");
            }
            this.vDevTrib = vDevTrib;
            // to ensure "vIBSUF" is required (not null)
            if (vIBSUF == null)
            {
                throw new ArgumentNullException("vIBSUF is a required property for NfeSefazGIBSGIBSUF and cannot be null");
            }
            this.vIBSUF = vIBSUF;
        }

        /// <summary>
        /// Total do Diferimento.
        /// </summary>
        /// <value>Total do Diferimento.</value>
        [DataMember(Name = "vDif", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDif { get; set; }

        /// <summary>
        /// Total de devoluções de tributos.
        /// </summary>
        /// <value>Total de devoluções de tributos.</value>
        [DataMember(Name = "vDevTrib", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vDevTrib { get; set; }

        /// <summary>
        /// Valor total do IBS Estadual.
        /// </summary>
        /// <value>Valor total do IBS Estadual.</value>
        [DataMember(Name = "vIBSUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSUF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGIBSGIBSUF {\n");
            sb.Append("  vDif: ").Append(vDif).Append("\n");
            sb.Append("  vDevTrib: ").Append(vDevTrib).Append("\n");
            sb.Append("  vIBSUF: ").Append(vIBSUF).Append("\n");
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
            return this.Equals(input as NfeSefazGIBSGIBSUF);
        }

        /// <summary>
        /// Returns true if NfeSefazGIBSGIBSUF instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGIBSGIBSUF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGIBSGIBSUF input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vDif == input.vDif ||
                    (this.vDif != null &&
                    this.vDif.Equals(input.vDif))
                ) && 
                (
                    this.vDevTrib == input.vDevTrib ||
                    (this.vDevTrib != null &&
                    this.vDevTrib.Equals(input.vDevTrib))
                ) && 
                (
                    this.vIBSUF == input.vIBSUF ||
                    (this.vIBSUF != null &&
                    this.vIBSUF.Equals(input.vIBSUF))
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
                if (this.vDif != null)
                {
                    hashCode = (hashCode * 59) + this.vDif.GetHashCode();
                }
                if (this.vDevTrib != null)
                {
                    hashCode = (hashCode * 59) + this.vDevTrib.GetHashCode();
                }
                if (this.vIBSUF != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSUF.GetHashCode();
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
            // vDif (decimal?) minimum
            if (this.vDif < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDif, must be a value greater than or equal to 0.", new [] { "vDif" });
            }

            // vDevTrib (decimal?) minimum
            if (this.vDevTrib < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vDevTrib, must be a value greater than or equal to 0.", new [] { "vDevTrib" });
            }

            // vIBSUF (decimal?) minimum
            if (this.vIBSUF < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIBSUF, must be a value greater than or equal to 0.", new [] { "vIBSUF" });
            }

            yield break;
        }
    }

}
