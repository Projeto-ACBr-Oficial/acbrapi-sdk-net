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
    /// Totalização da CBS.
    /// </summary>
    [DataContract(Name = "NfcomSefazIBSCBSTot_GCBS")]
    public partial class NfcomSefazIBSCBSTotGCBS : IEquatable<NfcomSefazIBSCBSTotGCBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazIBSCBSTotGCBS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazIBSCBSTotGCBS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazIBSCBSTotGCBS" /> class.
        /// </summary>
        /// <param name="vDif">Total do Diferimento. (required).</param>
        /// <param name="vDevTrib">Total de devoluções de tributos. (required).</param>
        /// <param name="vCBS">Valor total da CBS. (required).</param>
        /// <param name="vCredPres">Total do Crédito Presumido. (required).</param>
        /// <param name="vCredPresCondSus">Total do Crédito Presumido Condição Suspensiva. (required).</param>
        public NfcomSefazIBSCBSTotGCBS(decimal? vDif = default(decimal?), decimal? vDevTrib = default(decimal?), decimal? vCBS = default(decimal?), decimal? vCredPres = default(decimal?), decimal? vCredPresCondSus = default(decimal?))
        {
            // to ensure "vDif" is required (not null)
            if (vDif == null)
            {
                throw new ArgumentNullException("vDif is a required property for NfcomSefazIBSCBSTotGCBS and cannot be null");
            }
            this.vDif = vDif;
            // to ensure "vDevTrib" is required (not null)
            if (vDevTrib == null)
            {
                throw new ArgumentNullException("vDevTrib is a required property for NfcomSefazIBSCBSTotGCBS and cannot be null");
            }
            this.vDevTrib = vDevTrib;
            // to ensure "vCBS" is required (not null)
            if (vCBS == null)
            {
                throw new ArgumentNullException("vCBS is a required property for NfcomSefazIBSCBSTotGCBS and cannot be null");
            }
            this.vCBS = vCBS;
            // to ensure "vCredPres" is required (not null)
            if (vCredPres == null)
            {
                throw new ArgumentNullException("vCredPres is a required property for NfcomSefazIBSCBSTotGCBS and cannot be null");
            }
            this.vCredPres = vCredPres;
            // to ensure "vCredPresCondSus" is required (not null)
            if (vCredPresCondSus == null)
            {
                throw new ArgumentNullException("vCredPresCondSus is a required property for NfcomSefazIBSCBSTotGCBS and cannot be null");
            }
            this.vCredPresCondSus = vCredPresCondSus;
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
        /// Valor total da CBS.
        /// </summary>
        /// <value>Valor total da CBS.</value>
        [DataMember(Name = "vCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBS { get; set; }

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
            sb.Append("class NfcomSefazIBSCBSTotGCBS {\n");
            sb.Append("  vDif: ").Append(vDif).Append("\n");
            sb.Append("  vDevTrib: ").Append(vDevTrib).Append("\n");
            sb.Append("  vCBS: ").Append(vCBS).Append("\n");
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
            return this.Equals(input as NfcomSefazIBSCBSTotGCBS);
        }

        /// <summary>
        /// Returns true if NfcomSefazIBSCBSTotGCBS instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazIBSCBSTotGCBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazIBSCBSTotGCBS input)
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
                    this.vCBS == input.vCBS ||
                    (this.vCBS != null &&
                    this.vCBS.Equals(input.vCBS))
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
                if (this.vDif != null)
                {
                    hashCode = (hashCode * 59) + this.vDif.GetHashCode();
                }
                if (this.vDevTrib != null)
                {
                    hashCode = (hashCode * 59) + this.vDevTrib.GetHashCode();
                }
                if (this.vCBS != null)
                {
                    hashCode = (hashCode * 59) + this.vCBS.GetHashCode();
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

            // vCBS (decimal?) minimum
            if (this.vCBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCBS, must be a value greater than or equal to 0.", new [] { "vCBS" });
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
