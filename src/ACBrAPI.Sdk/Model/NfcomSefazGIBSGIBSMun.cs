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
    /// Totalização do IBS de competência Municipal.
    /// </summary>
    [DataContract(Name = "NfcomSefazGIBS_GIBSMun")]
    public partial class NfcomSefazGIBSGIBSMun : IEquatable<NfcomSefazGIBSGIBSMun>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGIBSGIBSMun" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazGIBSGIBSMun() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazGIBSGIBSMun" /> class.
        /// </summary>
        /// <param name="vDif">Total do Diferimento. (required).</param>
        /// <param name="vDevTrib">Total de devoluções de tributos. (required).</param>
        /// <param name="vIBSMun">Valor total do IBS Municipal. (required).</param>
        public NfcomSefazGIBSGIBSMun(decimal? vDif = default(decimal?), decimal? vDevTrib = default(decimal?), decimal? vIBSMun = default(decimal?))
        {
            // to ensure "vDif" is required (not null)
            if (vDif == null)
            {
                throw new ArgumentNullException("vDif is a required property for NfcomSefazGIBSGIBSMun and cannot be null");
            }
            this.vDif = vDif;
            // to ensure "vDevTrib" is required (not null)
            if (vDevTrib == null)
            {
                throw new ArgumentNullException("vDevTrib is a required property for NfcomSefazGIBSGIBSMun and cannot be null");
            }
            this.vDevTrib = vDevTrib;
            // to ensure "vIBSMun" is required (not null)
            if (vIBSMun == null)
            {
                throw new ArgumentNullException("vIBSMun is a required property for NfcomSefazGIBSGIBSMun and cannot be null");
            }
            this.vIBSMun = vIBSMun;
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
        /// Valor total do IBS Municipal.
        /// </summary>
        /// <value>Valor total do IBS Municipal.</value>
        [DataMember(Name = "vIBSMun", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMun { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazGIBSGIBSMun {\n");
            sb.Append("  vDif: ").Append(vDif).Append("\n");
            sb.Append("  vDevTrib: ").Append(vDevTrib).Append("\n");
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
            return this.Equals(input as NfcomSefazGIBSGIBSMun);
        }

        /// <summary>
        /// Returns true if NfcomSefazGIBSGIBSMun instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazGIBSGIBSMun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazGIBSGIBSMun input)
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
                if (this.vDif != null)
                {
                    hashCode = (hashCode * 59) + this.vDif.GetHashCode();
                }
                if (this.vDevTrib != null)
                {
                    hashCode = (hashCode * 59) + this.vDevTrib.GetHashCode();
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

            // vIBSMun (decimal?) minimum
            if (this.vIBSMun < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIBSMun, must be a value greater than or equal to 0.", new [] { "vIBSMun" });
            }

            yield break;
        }
    }

}
