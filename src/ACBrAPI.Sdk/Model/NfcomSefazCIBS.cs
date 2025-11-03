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
    /// NfcomSefazCIBS
    /// </summary>
    [DataContract(Name = "NfcomSefazCIBS")]
    public partial class NfcomSefazCIBS : IEquatable<NfcomSefazCIBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazCIBS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazCIBS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazCIBS" /> class.
        /// </summary>
        /// <param name="vBC">Valor do BC. (required).</param>
        /// <param name="gIBSUF">gIBSUF (required).</param>
        /// <param name="gIBSMun">gIBSMun (required).</param>
        /// <param name="vIBS">Valor do IBS (soma de vIBSUF e vIBSMun). (required).</param>
        /// <param name="gCBS">gCBS (required).</param>
        /// <param name="gTribRegular">gTribRegular.</param>
        /// <param name="gIBSCredPres">gIBSCredPres.</param>
        /// <param name="gCBSCredPres">gCBSCredPres.</param>
        /// <param name="gTribCompraGov">gTribCompraGov.</param>
        public NfcomSefazCIBS(decimal? vBC = default(decimal?), NfcomSefazGIBSUF gIBSUF = default(NfcomSefazGIBSUF), NfcomSefazGIBSMun gIBSMun = default(NfcomSefazGIBSMun), decimal? vIBS = default(decimal?), NfcomSefazGCBS gCBS = default(NfcomSefazGCBS), NfcomSefazTribRegular gTribRegular = default(NfcomSefazTribRegular), NfcomSefazCredPres gIBSCredPres = default(NfcomSefazCredPres), NfcomSefazCredPres gCBSCredPres = default(NfcomSefazCredPres), NfcomSefazTribCompraGov gTribCompraGov = default(NfcomSefazTribCompraGov))
        {
            // to ensure "vBC" is required (not null)
            if (vBC == null)
            {
                throw new ArgumentNullException("vBC is a required property for NfcomSefazCIBS and cannot be null");
            }
            this.vBC = vBC;
            // to ensure "gIBSUF" is required (not null)
            if (gIBSUF == null)
            {
                throw new ArgumentNullException("gIBSUF is a required property for NfcomSefazCIBS and cannot be null");
            }
            this.gIBSUF = gIBSUF;
            // to ensure "gIBSMun" is required (not null)
            if (gIBSMun == null)
            {
                throw new ArgumentNullException("gIBSMun is a required property for NfcomSefazCIBS and cannot be null");
            }
            this.gIBSMun = gIBSMun;
            // to ensure "vIBS" is required (not null)
            if (vIBS == null)
            {
                throw new ArgumentNullException("vIBS is a required property for NfcomSefazCIBS and cannot be null");
            }
            this.vIBS = vIBS;
            // to ensure "gCBS" is required (not null)
            if (gCBS == null)
            {
                throw new ArgumentNullException("gCBS is a required property for NfcomSefazCIBS and cannot be null");
            }
            this.gCBS = gCBS;
            this.gTribRegular = gTribRegular;
            this.gIBSCredPres = gIBSCredPres;
            this.gCBSCredPres = gCBSCredPres;
            this.gTribCompraGov = gTribCompraGov;
        }

        /// <summary>
        /// Valor do BC.
        /// </summary>
        /// <value>Valor do BC.</value>
        [DataMember(Name = "vBC", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Gets or Sets gIBSUF
        /// </summary>
        [DataMember(Name = "gIBSUF", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazGIBSUF gIBSUF { get; set; }

        /// <summary>
        /// Gets or Sets gIBSMun
        /// </summary>
        [DataMember(Name = "gIBSMun", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazGIBSMun gIBSMun { get; set; }

        /// <summary>
        /// Valor do IBS (soma de vIBSUF e vIBSMun).
        /// </summary>
        /// <value>Valor do IBS (soma de vIBSUF e vIBSMun).</value>
        [DataMember(Name = "vIBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBS { get; set; }

        /// <summary>
        /// Gets or Sets gCBS
        /// </summary>
        [DataMember(Name = "gCBS", IsRequired = true, EmitDefaultValue = true)]
        public NfcomSefazGCBS gCBS { get; set; }

        /// <summary>
        /// Gets or Sets gTribRegular
        /// </summary>
        [DataMember(Name = "gTribRegular", EmitDefaultValue = false)]
        public NfcomSefazTribRegular gTribRegular { get; set; }

        /// <summary>
        /// Gets or Sets gIBSCredPres
        /// </summary>
        [DataMember(Name = "gIBSCredPres", EmitDefaultValue = false)]
        public NfcomSefazCredPres gIBSCredPres { get; set; }

        /// <summary>
        /// Gets or Sets gCBSCredPres
        /// </summary>
        [DataMember(Name = "gCBSCredPres", EmitDefaultValue = false)]
        public NfcomSefazCredPres gCBSCredPres { get; set; }

        /// <summary>
        /// Gets or Sets gTribCompraGov
        /// </summary>
        [DataMember(Name = "gTribCompraGov", EmitDefaultValue = false)]
        public NfcomSefazTribCompraGov gTribCompraGov { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazCIBS {\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  gIBSUF: ").Append(gIBSUF).Append("\n");
            sb.Append("  gIBSMun: ").Append(gIBSMun).Append("\n");
            sb.Append("  vIBS: ").Append(vIBS).Append("\n");
            sb.Append("  gCBS: ").Append(gCBS).Append("\n");
            sb.Append("  gTribRegular: ").Append(gTribRegular).Append("\n");
            sb.Append("  gIBSCredPres: ").Append(gIBSCredPres).Append("\n");
            sb.Append("  gCBSCredPres: ").Append(gCBSCredPres).Append("\n");
            sb.Append("  gTribCompraGov: ").Append(gTribCompraGov).Append("\n");
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
            return this.Equals(input as NfcomSefazCIBS);
        }

        /// <summary>
        /// Returns true if NfcomSefazCIBS instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazCIBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazCIBS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
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
                    this.gCBS == input.gCBS ||
                    (this.gCBS != null &&
                    this.gCBS.Equals(input.gCBS))
                ) && 
                (
                    this.gTribRegular == input.gTribRegular ||
                    (this.gTribRegular != null &&
                    this.gTribRegular.Equals(input.gTribRegular))
                ) && 
                (
                    this.gIBSCredPres == input.gIBSCredPres ||
                    (this.gIBSCredPres != null &&
                    this.gIBSCredPres.Equals(input.gIBSCredPres))
                ) && 
                (
                    this.gCBSCredPres == input.gCBSCredPres ||
                    (this.gCBSCredPres != null &&
                    this.gCBSCredPres.Equals(input.gCBSCredPres))
                ) && 
                (
                    this.gTribCompraGov == input.gTribCompraGov ||
                    (this.gTribCompraGov != null &&
                    this.gTribCompraGov.Equals(input.gTribCompraGov))
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
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
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
                if (this.gCBS != null)
                {
                    hashCode = (hashCode * 59) + this.gCBS.GetHashCode();
                }
                if (this.gTribRegular != null)
                {
                    hashCode = (hashCode * 59) + this.gTribRegular.GetHashCode();
                }
                if (this.gIBSCredPres != null)
                {
                    hashCode = (hashCode * 59) + this.gIBSCredPres.GetHashCode();
                }
                if (this.gCBSCredPres != null)
                {
                    hashCode = (hashCode * 59) + this.gCBSCredPres.GetHashCode();
                }
                if (this.gTribCompraGov != null)
                {
                    hashCode = (hashCode * 59) + this.gTribCompraGov.GetHashCode();
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
            // vBC (decimal?) minimum
            if (this.vBC < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBC, must be a value greater than or equal to 0.", new [] { "vBC" });
            }

            // vIBS (decimal?) minimum
            if (this.vIBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIBS, must be a value greater than or equal to 0.", new [] { "vIBS" });
            }

            yield break;
        }
    }

}
