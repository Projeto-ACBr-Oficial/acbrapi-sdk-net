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
    /// Totalização do IBS.
    /// </summary>
    [DataContract(Name = "NfcomSefazGIBS")]
    public partial class NfcomSefazGIBS : IEquatable<NfcomSefazGIBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGIBS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGIBS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGIBS" /> class.
        /// </summary>
        /// <param name="gIBSUF">gIBSUF (required).</param>
        /// <param name="gIBSMun">gIBSMun (required).</param>
        /// <param name="vIBS">Valor total do IBS. (required).</param>
        /// <param name="vCredPres">Total do Crédito Presumido. (required).</param>
        /// <param name="vCredPresCondSus">Total do Crédito Presumido Condição Suspensiva. (required).</param>
        public NfcomSefazGIBS(NfcomSefazGIBSGIBSUF gIBSUF = default(NfcomSefazGIBSGIBSUF), NfcomSefazGIBSGIBSMun gIBSMun = default(NfcomSefazGIBSGIBSMun), decimal? vIBS = default(decimal?), decimal? vCredPres = default(decimal?), decimal? vCredPresCondSus = default(decimal?))
        {
            // to ensure "gIBSUF" is required (not null)
            if (gIBSUF == null)
            {
                throw new ArgumentNullException("gIBSUF is a required property for NfcomSefazGIBS and cannot be null");
            }
            this.gIBSUF = gIBSUF;
            // to ensure "gIBSMun" is required (not null)
            if (gIBSMun == null)
            {
                throw new ArgumentNullException("gIBSMun is a required property for NfcomSefazGIBS and cannot be null");
            }
            this.gIBSMun = gIBSMun;
            // to ensure "vIBS" is required (not null)
            if (vIBS == null)
            {
                throw new ArgumentNullException("vIBS is a required property for NfcomSefazGIBS and cannot be null");
            }
            this.vIBS = vIBS;
            // to ensure "vCredPres" is required (not null)
            if (vCredPres == null)
            {
                throw new ArgumentNullException("vCredPres is a required property for NfcomSefazGIBS and cannot be null");
            }
            this.vCredPres = vCredPres;
            // to ensure "vCredPresCondSus" is required (not null)
            if (vCredPresCondSus == null)
            {
                throw new ArgumentNullException("vCredPresCondSus is a required property for NfcomSefazGIBS and cannot be null");
            }
            this.vCredPresCondSus = vCredPresCondSus;
        }

        /// <summary>
        /// Gets or Sets gIBSUF
        /// </summary>
        [DataMember(Name = "gIBSUF", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazGIBSGIBSUF gIBSUF { get; set; }

        /// <summary>
        /// Gets or Sets gIBSMun
        /// </summary>
        [DataMember(Name = "gIBSMun", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazGIBSGIBSMun gIBSMun { get; set; }

        /// <summary>
        /// Valor total do IBS.
        /// </summary>
        /// <value>Valor total do IBS.</value>
        [DataMember(Name = "vIBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBS { get; set; }

        /// <summary>
        /// Total do Crédito Presumido.
        /// </summary>
        /// <value>Total do Crédito Presumido.</value>
        [DataMember(Name = "vCredPres", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCredPres { get; set; }

        /// <summary>
        /// Total do Crédito Presumido Condição Suspensiva.
        /// </summary>
        /// <value>Total do Crédito Presumido Condição Suspensiva.</value>
        [DataMember(Name = "vCredPresCondSus", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCredPresCondSus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGIBS {\n");
            sb.Append("  gIBSUF: ").Append(gIBSUF).Append("\n");
            sb.Append("  gIBSMun: ").Append(gIBSMun).Append("\n");
            sb.Append("  vIBS: ").Append(vIBS).Append("\n");
            sb.Append("  vCredPres: ").Append(vCredPres).Append("\n");
            sb.Append("  vCredPresCondSus: ").Append(vCredPresCondSus).Append("\n");
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
            return this.Equals(input as NfcomSefazGIBS);
        }

        /// <summary>
        /// Returns true if NfcomSefazGIBS instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGIBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGIBS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.gIBSUF == input.gIBSUF ||
                    (this.gIBSUF != null &&
                    this.gIBSUF.Equals(input.gIBSUF))
                ) && 
                (
                    this.gIBSMun == input.gIBSMun ||
                    (this.gIBSMun != null &&
                    this.gIBSMun.Equals(input.gIBSMun))
                ) && 
                (
                    this.vIBS == input.vIBS ||
                    (this.vIBS != null &&
                    this.vIBS.Equals(input.vIBS))
                ) && 
                (
                    this.vCredPres == input.vCredPres ||
                    (this.vCredPres != null &&
                    this.vCredPres.Equals(input.vCredPres))
                ) && 
                (
                    this.vCredPresCondSus == input.vCredPresCondSus ||
                    (this.vCredPresCondSus != null &&
                    this.vCredPresCondSus.Equals(input.vCredPresCondSus))
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
                if (this.gIBSUF != null)
                {
                    hashCode = (hashCode * 59) + this.gIBSUF.GetHashCode();
                }
                if (this.gIBSMun != null)
                {
                    hashCode = (hashCode * 59) + this.gIBSMun.GetHashCode();
                }
                if (this.vIBS != null)
                {
                    hashCode = (hashCode * 59) + this.vIBS.GetHashCode();
                }
                if (this.vCredPres != null)
                {
                    hashCode = (hashCode * 59) + this.vCredPres.GetHashCode();
                }
                if (this.vCredPresCondSus != null)
                {
                    hashCode = (hashCode * 59) + this.vCredPresCondSus.GetHashCode();
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

            // vCredPres (decimal?) minimum
            if (this.vCredPres < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCredPres, must be a value greater than or equal to 0.", new [] { "vCredPres" });
            }

            // vCredPresCondSus (decimal?) minimum
            if (this.vCredPresCondSus < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCredPresCondSus, must be a value greater than or equal to 0.", new [] { "vCredPresCondSus" });
            }

            yield break;
        }
    }

}
