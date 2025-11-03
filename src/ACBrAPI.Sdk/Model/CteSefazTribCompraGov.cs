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
    /// Grupo de informações da composição do valor do IBS e da CBS em compras governamental.
    /// </summary>
    [DataContract(Name = "CteSefazTribCompraGov")]
    public partial class CteSefazTribCompraGov : IEquatable<CteSefazTribCompraGov>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazTribCompraGov" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazTribCompraGov() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazTribCompraGov" /> class.
        /// </summary>
        /// <param name="pAliqIBSUF">pAliqIBSUF.</param>
        /// <param name="vTribIBSUF">Valor que seria devido a UF, sem aplicação do Art. 473. da LC 214/2025. (required).</param>
        /// <param name="pAliqIBSMun">pAliqIBSMun.</param>
        /// <param name="vTribIBSMun">Valor que seria devido ao município, sem aplicação do Art. 473. da LC 214/2025. (required).</param>
        /// <param name="pAliqCBS">pAliqCBS.</param>
        /// <param name="vTribCBS">Valor que seria devido a CBS, sem aplicação do Art. 473. da LC 214/2025. (required).</param>
        public CteSefazTribCompraGov(decimal? pAliqIBSUF = default(decimal?), decimal? vTribIBSUF = default(decimal?), decimal? pAliqIBSMun = default(decimal?), decimal? vTribIBSMun = default(decimal?), decimal? pAliqCBS = default(decimal?), decimal? vTribCBS = default(decimal?))
        {
            // to ensure "vTribIBSUF" is required (not null)
            if (vTribIBSUF == null)
            {
                throw new ArgumentNullException("vTribIBSUF is a required property for CteSefazTribCompraGov and cannot be null");
            }
            this.vTribIBSUF = vTribIBSUF;
            // to ensure "vTribIBSMun" is required (not null)
            if (vTribIBSMun == null)
            {
                throw new ArgumentNullException("vTribIBSMun is a required property for CteSefazTribCompraGov and cannot be null");
            }
            this.vTribIBSMun = vTribIBSMun;
            // to ensure "vTribCBS" is required (not null)
            if (vTribCBS == null)
            {
                throw new ArgumentNullException("vTribCBS is a required property for CteSefazTribCompraGov and cannot be null");
            }
            this.vTribCBS = vTribCBS;
            this.pAliqIBSUF = pAliqIBSUF;
            this.pAliqIBSMun = pAliqIBSMun;
            this.pAliqCBS = pAliqCBS;
        }

        /// <summary>
        /// Gets or Sets pAliqIBSUF
        /// </summary>
        [DataMember(Name = "pAliqIBSUF", EmitDefaultValue = true)]
        public decimal? pAliqIBSUF { get; set; }

        /// <summary>
        /// Valor que seria devido a UF, sem aplicação do Art. 473. da LC 214/2025.
        /// </summary>
        /// <value>Valor que seria devido a UF, sem aplicação do Art. 473. da LC 214/2025.</value>
        [DataMember(Name = "vTribIBSUF", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTribIBSUF { get; set; }

        /// <summary>
        /// Gets or Sets pAliqIBSMun
        /// </summary>
        [DataMember(Name = "pAliqIBSMun", EmitDefaultValue = true)]
        public decimal? pAliqIBSMun { get; set; }

        /// <summary>
        /// Valor que seria devido ao município, sem aplicação do Art. 473. da LC 214/2025.
        /// </summary>
        /// <value>Valor que seria devido ao município, sem aplicação do Art. 473. da LC 214/2025.</value>
        [DataMember(Name = "vTribIBSMun", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTribIBSMun { get; set; }

        /// <summary>
        /// Gets or Sets pAliqCBS
        /// </summary>
        [DataMember(Name = "pAliqCBS", EmitDefaultValue = true)]
        public decimal? pAliqCBS { get; set; }

        /// <summary>
        /// Valor que seria devido a CBS, sem aplicação do Art. 473. da LC 214/2025.
        /// </summary>
        /// <value>Valor que seria devido a CBS, sem aplicação do Art. 473. da LC 214/2025.</value>
        [DataMember(Name = "vTribCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTribCBS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazTribCompraGov {\n");
            sb.Append("  pAliqIBSUF: ").Append(pAliqIBSUF).Append("\n");
            sb.Append("  vTribIBSUF: ").Append(vTribIBSUF).Append("\n");
            sb.Append("  pAliqIBSMun: ").Append(pAliqIBSMun).Append("\n");
            sb.Append("  vTribIBSMun: ").Append(vTribIBSMun).Append("\n");
            sb.Append("  pAliqCBS: ").Append(pAliqCBS).Append("\n");
            sb.Append("  vTribCBS: ").Append(vTribCBS).Append("\n");
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
            return this.Equals(input as CteSefazTribCompraGov);
        }

        /// <summary>
        /// Returns true if CteSefazTribCompraGov instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazTribCompraGov to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazTribCompraGov input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pAliqIBSUF == input.pAliqIBSUF ||
                    (this.pAliqIBSUF != null &&
                    this.pAliqIBSUF.Equals(input.pAliqIBSUF))
                ) && 
                (
                    this.vTribIBSUF == input.vTribIBSUF ||
                    (this.vTribIBSUF != null &&
                    this.vTribIBSUF.Equals(input.vTribIBSUF))
                ) && 
                (
                    this.pAliqIBSMun == input.pAliqIBSMun ||
                    (this.pAliqIBSMun != null &&
                    this.pAliqIBSMun.Equals(input.pAliqIBSMun))
                ) && 
                (
                    this.vTribIBSMun == input.vTribIBSMun ||
                    (this.vTribIBSMun != null &&
                    this.vTribIBSMun.Equals(input.vTribIBSMun))
                ) && 
                (
                    this.pAliqCBS == input.pAliqCBS ||
                    (this.pAliqCBS != null &&
                    this.pAliqCBS.Equals(input.pAliqCBS))
                ) && 
                (
                    this.vTribCBS == input.vTribCBS ||
                    (this.vTribCBS != null &&
                    this.vTribCBS.Equals(input.vTribCBS))
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
                if (this.pAliqIBSUF != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqIBSUF.GetHashCode();
                }
                if (this.vTribIBSUF != null)
                {
                    hashCode = (hashCode * 59) + this.vTribIBSUF.GetHashCode();
                }
                if (this.pAliqIBSMun != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqIBSMun.GetHashCode();
                }
                if (this.vTribIBSMun != null)
                {
                    hashCode = (hashCode * 59) + this.vTribIBSMun.GetHashCode();
                }
                if (this.pAliqCBS != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqCBS.GetHashCode();
                }
                if (this.vTribCBS != null)
                {
                    hashCode = (hashCode * 59) + this.vTribCBS.GetHashCode();
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
            // pAliqIBSUF (decimal?) minimum
            if (this.pAliqIBSUF < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pAliqIBSUF, must be a value greater than or equal to 0.", new [] { "pAliqIBSUF" });
            }

            // vTribIBSUF (decimal?) minimum
            if (this.vTribIBSUF < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTribIBSUF, must be a value greater than or equal to 0.", new [] { "vTribIBSUF" });
            }

            // pAliqIBSMun (decimal?) minimum
            if (this.pAliqIBSMun < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pAliqIBSMun, must be a value greater than or equal to 0.", new [] { "pAliqIBSMun" });
            }

            // vTribIBSMun (decimal?) minimum
            if (this.vTribIBSMun < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTribIBSMun, must be a value greater than or equal to 0.", new [] { "vTribIBSMun" });
            }

            // pAliqCBS (decimal?) minimum
            if (this.pAliqCBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pAliqCBS, must be a value greater than or equal to 0.", new [] { "pAliqCBS" });
            }

            // vTribCBS (decimal?) minimum
            if (this.vTribCBS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTribCBS, must be a value greater than or equal to 0.", new [] { "vTribCBS" });
            }

            yield break;
        }
    }

}
