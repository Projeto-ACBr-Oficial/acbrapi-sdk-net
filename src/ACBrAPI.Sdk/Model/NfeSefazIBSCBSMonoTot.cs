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
    /// Valores totais da NF com IBS / CBS.
    /// </summary>
    [DataContract(Name = "NfeSefazIBSCBSMonoTot")]
    public partial class NfeSefazIBSCBSMonoTot : IEquatable<NfeSefazIBSCBSMonoTot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIBSCBSMonoTot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazIBSCBSMonoTot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIBSCBSMonoTot" /> class.
        /// </summary>
        /// <param name="vBCIBSCBS">Total Base de Calculo. (required).</param>
        /// <param name="gIBS">gIBS.</param>
        /// <param name="gCBS">gCBS.</param>
        /// <param name="gMono">gMono.</param>
        public NfeSefazIBSCBSMonoTot(decimal? vBCIBSCBS = default(decimal?), NfeSefazGIBS gIBS = default(NfeSefazGIBS), NfeSefazIBSCBSMonoTotGCBS gCBS = default(NfeSefazIBSCBSMonoTotGCBS), NfeSefazGMono gMono = default(NfeSefazGMono))
        {
            // to ensure "vBCIBSCBS" is required (not null)
            if (vBCIBSCBS == null)
            {
                throw new ArgumentNullException("vBCIBSCBS is a required property for NfeSefazIBSCBSMonoTot and cannot be null");
            }
            this.vBCIBSCBS = vBCIBSCBS;
            this.gIBS = gIBS;
            this.gCBS = gCBS;
            this.gMono = gMono;
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
        [DataMember(Name = "gIBS", EmitDefaultValue = false)]
        public NfeSefazGIBS gIBS { get; set; }

        /// <summary>
        /// Gets or Sets gCBS
        /// </summary>
        [DataMember(Name = "gCBS", EmitDefaultValue = false)]
        public NfeSefazIBSCBSMonoTotGCBS gCBS { get; set; }

        /// <summary>
        /// Gets or Sets gMono
        /// </summary>
        [DataMember(Name = "gMono", EmitDefaultValue = false)]
        public NfeSefazGMono gMono { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazIBSCBSMonoTot {\n");
            sb.Append("  vBCIBSCBS: ").Append(vBCIBSCBS).Append("\n");
            sb.Append("  gIBS: ").Append(gIBS).Append("\n");
            sb.Append("  gCBS: ").Append(gCBS).Append("\n");
            sb.Append("  gMono: ").Append(gMono).Append("\n");
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
            return this.Equals(input as NfeSefazIBSCBSMonoTot);
        }

        /// <summary>
        /// Returns true if NfeSefazIBSCBSMonoTot instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazIBSCBSMonoTot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazIBSCBSMonoTot input)
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
                ) && 
                (
                    this.gMono == input.gMono ||
                    (this.gMono != null &&
                    this.gMono.Equals(input.gMono))
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
                if (this.gMono != null)
                {
                    hashCode = (hashCode * 59) + this.gMono.GetHashCode();
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
