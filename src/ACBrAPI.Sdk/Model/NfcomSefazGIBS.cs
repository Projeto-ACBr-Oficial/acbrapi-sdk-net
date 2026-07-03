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
        public NfcomSefazGIBS(NfcomSefazGIBSGIBSUF gIBSUF = default(NfcomSefazGIBSGIBSUF), NfcomSefazGIBSGIBSMun gIBSMun = default(NfcomSefazGIBSGIBSMun), decimal? vIBS = default(decimal?))
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
            // vIBS (decimal?) minimum
            if (this.vIBS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vIBS, must be a value greater than or equal to 0.", new [] { "vIBS" });
            }

            yield break;
        }
    }

}
