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
    /// Grupo de Tributação da CBS.
    /// </summary>
    [DataContract(Name = "CteSefazGCBS")]
    public partial class CteSefazGCBS : IEquatable<CteSefazGCBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazGCBS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazGCBS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazGCBS" /> class.
        /// </summary>
        /// <param name="pCBS">Aliquota da CBS. (required).</param>
        /// <param name="gDif">gDif.</param>
        /// <param name="gDevTrib">gDevTrib.</param>
        /// <param name="gRed">gRed.</param>
        /// <param name="vCBS">Valor da CBS. (required).</param>
        public CteSefazGCBS(decimal? pCBS = default(decimal?), CteSefazDif gDif = default(CteSefazDif), CteSefazDevTrib gDevTrib = default(CteSefazDevTrib), CteSefazRed gRed = default(CteSefazRed), decimal? vCBS = default(decimal?))
        {
            // to ensure "pCBS" is required (not null)
            if (pCBS == null)
            {
                throw new ArgumentNullException("pCBS is a required property for CteSefazGCBS and cannot be null");
            }
            this.pCBS = pCBS;
            // to ensure "vCBS" is required (not null)
            if (vCBS == null)
            {
                throw new ArgumentNullException("vCBS is a required property for CteSefazGCBS and cannot be null");
            }
            this.vCBS = vCBS;
            this.gDif = gDif;
            this.gDevTrib = gDevTrib;
            this.gRed = gRed;
        }

        /// <summary>
        /// Aliquota da CBS.
        /// </summary>
        /// <value>Aliquota da CBS.</value>
        [DataMember(Name = "pCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pCBS { get; set; }

        /// <summary>
        /// Gets or Sets gDif
        /// </summary>
        [DataMember(Name = "gDif", EmitDefaultValue = false)]
        public CteSefazDif gDif { get; set; }

        /// <summary>
        /// Gets or Sets gDevTrib
        /// </summary>
        [DataMember(Name = "gDevTrib", EmitDefaultValue = false)]
        public CteSefazDevTrib gDevTrib { get; set; }

        /// <summary>
        /// Gets or Sets gRed
        /// </summary>
        [DataMember(Name = "gRed", EmitDefaultValue = false)]
        public CteSefazRed gRed { get; set; }

        /// <summary>
        /// Valor da CBS.
        /// </summary>
        /// <value>Valor da CBS.</value>
        [DataMember(Name = "vCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazGCBS {\n");
            sb.Append("  pCBS: ").Append(pCBS).Append("\n");
            sb.Append("  gDif: ").Append(gDif).Append("\n");
            sb.Append("  gDevTrib: ").Append(gDevTrib).Append("\n");
            sb.Append("  gRed: ").Append(gRed).Append("\n");
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
            return this.Equals(input as CteSefazGCBS);
        }

        /// <summary>
        /// Returns true if CteSefazGCBS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazGCBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazGCBS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pCBS == input.pCBS ||
                    (this.pCBS != null &&
                    this.pCBS.Equals(input.pCBS))
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
                if (this.pCBS != null)
                {
                    hashCode = (hashCode * 59) + this.pCBS.GetHashCode();
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
            // pCBS (decimal?) minimum
            if (this.pCBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pCBS, must be a value greater than or equal to 0.", new [] { "pCBS" });
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
