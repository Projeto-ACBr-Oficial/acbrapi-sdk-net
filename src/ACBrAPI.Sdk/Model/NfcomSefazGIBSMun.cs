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
    /// Grupo de Informações do IBS no Município.
    /// </summary>
    [DataContract(Name = "NfcomSefazGIBSMun")]
    public partial class NfcomSefazGIBSMun : IEquatable<NfcomSefazGIBSMun>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGIBSMun" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGIBSMun() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGIBSMun" /> class.
        /// </summary>
        /// <param name="pIBSMun">Aliquota do IBS Municipal. (required).</param>
        /// <param name="gDif">gDif.</param>
        /// <param name="gDevTrib">gDevTrib.</param>
        /// <param name="gRed">gRed.</param>
        /// <param name="vIBSMun">Valor do IBS Municipal. (required).</param>
        public NfcomSefazGIBSMun(decimal? pIBSMun = default(decimal?), NfcomSefazDif gDif = default(NfcomSefazDif), NfcomSefazDevTrib gDevTrib = default(NfcomSefazDevTrib), NfcomSefazRed gRed = default(NfcomSefazRed), decimal? vIBSMun = default(decimal?))
        {
            // to ensure "pIBSMun" is required (not null)
            if (pIBSMun == null)
            {
                throw new ArgumentNullException("pIBSMun is a required property for NfcomSefazGIBSMun and cannot be null");
            }
            this.pIBSMun = pIBSMun;
            // to ensure "vIBSMun" is required (not null)
            if (vIBSMun == null)
            {
                throw new ArgumentNullException("vIBSMun is a required property for NfcomSefazGIBSMun and cannot be null");
            }
            this.vIBSMun = vIBSMun;
            this.gDif = gDif;
            this.gDevTrib = gDevTrib;
            this.gRed = gRed;
        }

        /// <summary>
        /// Aliquota do IBS Municipal.
        /// </summary>
        /// <value>Aliquota do IBS Municipal.</value>
        [DataMember(Name = "pIBSMun", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pIBSMun { get; set; }

        /// <summary>
        /// Gets or Sets gDif
        /// </summary>
        [DataMember(Name = "gDif", EmitDefaultValue = false)]
        public NfcomSefazDif gDif { get; set; }

        /// <summary>
        /// Gets or Sets gDevTrib
        /// </summary>
        [DataMember(Name = "gDevTrib", EmitDefaultValue = false)]
        public NfcomSefazDevTrib gDevTrib { get; set; }

        /// <summary>
        /// Gets or Sets gRed
        /// </summary>
        [DataMember(Name = "gRed", EmitDefaultValue = false)]
        public NfcomSefazRed gRed { get; set; }

        /// <summary>
        /// Valor do IBS Municipal.
        /// </summary>
        /// <value>Valor do IBS Municipal.</value>
        [DataMember(Name = "vIBSMun", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMun { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGIBSMun {\n");
            sb.Append("  pIBSMun: ").Append(pIBSMun).Append("\n");
            sb.Append("  gDif: ").Append(gDif).Append("\n");
            sb.Append("  gDevTrib: ").Append(gDevTrib).Append("\n");
            sb.Append("  gRed: ").Append(gRed).Append("\n");
            sb.Append("  vIBSMun: ").Append(vIBSMun).Append("\n");
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
            return this.Equals(input as NfcomSefazGIBSMun);
        }

        /// <summary>
        /// Returns true if NfcomSefazGIBSMun instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGIBSMun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGIBSMun input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pIBSMun == input.pIBSMun ||
                    (this.pIBSMun != null &&
                    this.pIBSMun.Equals(input.pIBSMun))
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
                    this.vIBSMun == input.vIBSMun ||
                    (this.vIBSMun != null &&
                    this.vIBSMun.Equals(input.vIBSMun))
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
                if (this.pIBSMun != null)
                {
                    hashCode = (hashCode * 59) + this.pIBSMun.GetHashCode();
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
                if (this.vIBSMun != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSMun.GetHashCode();
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
            // pIBSMun (decimal?) minimum
            if (this.pIBSMun < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pIBSMun, must be a value greater than or equal to 0.", new [] { "pIBSMun" });
            }

            // vIBSMun (decimal?) minimum
            if (this.vIBSMun < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIBSMun, must be a value greater than or equal to 0.", new [] { "vIBSMun" });
            }

            yield break;
        }
    }

}
