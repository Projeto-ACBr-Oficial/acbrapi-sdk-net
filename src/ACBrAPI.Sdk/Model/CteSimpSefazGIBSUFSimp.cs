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
    /// Grupo de informações do IBS na UF.
    /// </summary>
    [DataContract(Name = "CteSimpSefazGIBSUFSimp")]
    public partial class CteSimpSefazGIBSUFSimp : IEquatable<CteSimpSefazGIBSUFSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazGIBSUFSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazGIBSUFSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazGIBSUFSimp" /> class.
        /// </summary>
        /// <param name="pIBSUF">Aliquota do IBS de competência das UF. (required).</param>
        /// <param name="gDif">gDif.</param>
        /// <param name="gDevTrib">gDevTrib.</param>
        /// <param name="gRed">gRed.</param>
        /// <param name="vIBSUF">Valor do IBS de competência das UF. (required).</param>
        public CteSimpSefazGIBSUFSimp(decimal? pIBSUF = default(decimal?), CteSimpSefazDifSimp gDif = default(CteSimpSefazDifSimp), CteSimpSefazDevTribSimp gDevTrib = default(CteSimpSefazDevTribSimp), CteSimpSefazRedSimp gRed = default(CteSimpSefazRedSimp), decimal? vIBSUF = default(decimal?))
        {
            // to ensure "pIBSUF" is required (not null)
            if (pIBSUF == null)
            {
                throw new ArgumentNullException("pIBSUF is a required property for CteSimpSefazGIBSUFSimp and cannot be null");
            }
            this.pIBSUF = pIBSUF;
            // to ensure "vIBSUF" is required (not null)
            if (vIBSUF == null)
            {
                throw new ArgumentNullException("vIBSUF is a required property for CteSimpSefazGIBSUFSimp and cannot be null");
            }
            this.vIBSUF = vIBSUF;
            this.gDif = gDif;
            this.gDevTrib = gDevTrib;
            this.gRed = gRed;
        }

        /// <summary>
        /// Aliquota do IBS de competência das UF.
        /// </summary>
        /// <value>Aliquota do IBS de competência das UF.</value>
        [DataMember(Name = "pIBSUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pIBSUF { get; set; }

        /// <summary>
        /// Gets or Sets gDif
        /// </summary>
        [DataMember(Name = "gDif", EmitDefaultValue = false)]
        public CteSimpSefazDifSimp gDif { get; set; }

        /// <summary>
        /// Gets or Sets gDevTrib
        /// </summary>
        [DataMember(Name = "gDevTrib", EmitDefaultValue = false)]
        public CteSimpSefazDevTribSimp gDevTrib { get; set; }

        /// <summary>
        /// Gets or Sets gRed
        /// </summary>
        [DataMember(Name = "gRed", EmitDefaultValue = false)]
        public CteSimpSefazRedSimp gRed { get; set; }

        /// <summary>
        /// Valor do IBS de competência das UF.
        /// </summary>
        /// <value>Valor do IBS de competência das UF.</value>
        [DataMember(Name = "vIBSUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSUF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazGIBSUFSimp {\n");
            sb.Append("  pIBSUF: ").Append(pIBSUF).Append("\n");
            sb.Append("  gDif: ").Append(gDif).Append("\n");
            sb.Append("  gDevTrib: ").Append(gDevTrib).Append("\n");
            sb.Append("  gRed: ").Append(gRed).Append("\n");
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
            return this.Equals(input as CteSimpSefazGIBSUFSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazGIBSUFSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazGIBSUFSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazGIBSUFSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pIBSUF == input.pIBSUF ||
                    (this.pIBSUF != null &&
                    this.pIBSUF.Equals(input.pIBSUF))
                ) && 
                (
                    this.gDif == input.gDif ||
                    (this.gDif != null &&
                    this.gDif.Equals(input.gDif))
                ) && 
                (
                    this.gDevTrib == input.gDevTrib ||
                    (this.gDevTrib != null &&
                    this.gDevTrib.Equals(input.gDevTrib))
                ) && 
                (
                    this.gRed == input.gRed ||
                    (this.gRed != null &&
                    this.gRed.Equals(input.gRed))
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
                if (this.pIBSUF != null)
                {
                    hashCode = (hashCode * 59) + this.pIBSUF.GetHashCode();
                }
                if (this.gDif != null)
                {
                    hashCode = (hashCode * 59) + this.gDif.GetHashCode();
                }
                if (this.gDevTrib != null)
                {
                    hashCode = (hashCode * 59) + this.gDevTrib.GetHashCode();
                }
                if (this.gRed != null)
                {
                    hashCode = (hashCode * 59) + this.gRed.GetHashCode();
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
            // pIBSUF (decimal?) minimum
            if (this.pIBSUF < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pIBSUF, must be a value greater than or equal to 0.", new [] { "pIBSUF" });
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
