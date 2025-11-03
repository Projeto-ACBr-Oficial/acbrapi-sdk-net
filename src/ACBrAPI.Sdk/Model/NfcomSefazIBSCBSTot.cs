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
    /// Totais de IBS e CBS.
    /// </summary>
    [DataContract(Name = "NfcomSefazIBSCBSTot")]
    public partial class NfcomSefazIBSCBSTot : IEquatable<NfcomSefazIBSCBSTot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazIBSCBSTot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazIBSCBSTot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazIBSCBSTot" /> class.
        /// </summary>
        /// <param name="vBCIBSCBS">Total Base de Calculo. (required).</param>
        /// <param name="gIBS">gIBS (required).</param>
        /// <param name="gCBS">gCBS (required).</param>
        public NfcomSefazIBSCBSTot(decimal? vBCIBSCBS = default(decimal?), NfcomSefazGIBS gIBS = default(NfcomSefazGIBS), NfcomSefazIBSCBSTotGCBS gCBS = default(NfcomSefazIBSCBSTotGCBS))
        {
            // to ensure "vBCIBSCBS" is required (not null)
            if (vBCIBSCBS == null)
            {
                throw new ArgumentNullException("vBCIBSCBS is a required property for NfcomSefazIBSCBSTot and cannot be null");
            }
            this.vBCIBSCBS = vBCIBSCBS;
            // to ensure "gIBS" is required (not null)
            if (gIBS == null)
            {
                throw new ArgumentNullException("gIBS is a required property for NfcomSefazIBSCBSTot and cannot be null");
            }
            this.gIBS = gIBS;
            // to ensure "gCBS" is required (not null)
            if (gCBS == null)
            {
                throw new ArgumentNullException("gCBS is a required property for NfcomSefazIBSCBSTot and cannot be null");
            }
            this.gCBS = gCBS;
        }

        /// <summary>
        /// Total Base de Calculo.
        /// </summary>
        /// <value>Total Base de Calculo.</value>
        [DataMember(Name = "vBCIBSCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCIBSCBS { get; set; }

        /// <summary>
        /// Gets or Sets gIBS
        /// </summary>
        [DataMember(Name = "gIBS", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazGIBS gIBS { get; set; }

        /// <summary>
        /// Gets or Sets gCBS
        /// </summary>
        [DataMember(Name = "gCBS", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazIBSCBSTotGCBS gCBS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazIBSCBSTot {\n");
            sb.Append("  vBCIBSCBS: ").Append(vBCIBSCBS).Append("\n");
            sb.Append("  gIBS: ").Append(gIBS).Append("\n");
            sb.Append("  gCBS: ").Append(gCBS).Append("\n");
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
            return this.Equals(input as NfcomSefazIBSCBSTot);
        }

        /// <summary>
        /// Returns true if NfcomSefazIBSCBSTot instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazIBSCBSTot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazIBSCBSTot input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBCIBSCBS == input.vBCIBSCBS ||
                    (this.vBCIBSCBS != null &&
                    this.vBCIBSCBS.Equals(input.vBCIBSCBS))
                ) && 
                (
                    this.gIBS == input.gIBS ||
                    (this.gIBS != null &&
                    this.gIBS.Equals(input.gIBS))
                ) && 
                (
                    this.gCBS == input.gCBS ||
                    (this.gCBS != null &&
                    this.gCBS.Equals(input.gCBS))
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
                if (this.vBCIBSCBS != null)
                {
                    hashCode = (hashCode * 59) + this.vBCIBSCBS.GetHashCode();
                }
                if (this.gIBS != null)
                {
                    hashCode = (hashCode * 59) + this.gIBS.GetHashCode();
                }
                if (this.gCBS != null)
                {
                    hashCode = (hashCode * 59) + this.gCBS.GetHashCode();
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
            // vBCIBSCBS (decimal?) minimum
            if (this.vBCIBSCBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBCIBSCBS, must be a value greater than or equal to 0.", new [] { "vBCIBSCBS" });
            }

            yield break;
        }
    }

}
