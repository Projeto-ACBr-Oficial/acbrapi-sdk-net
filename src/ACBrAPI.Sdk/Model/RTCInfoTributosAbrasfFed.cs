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
    /// Grupo de informações relativas aos valores da CBS.
    /// </summary>
    [DataContract(Name = "RTCInfoTributosAbrasfFed")]
    public partial class RTCInfoTributosAbrasfFed : IEquatable<RTCInfoTributosAbrasfFed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosAbrasfFed" /> class.
        /// </summary>
        /// <param name="pCBS">Alíquota da União para CBS..</param>
        /// <param name="pRedAliqCBS">Percentual da redução de alíquota da CBS..</param>
        /// <param name="pAliqEfetCBS">Alíquota efetiva da CBS.  pAliqEfetCBS &#x3D; pCBS x (1 - pRedAliqCBS) x (1 - pRedutor).</param>
        /// <param name="vCBS">Valor da CBS (R$).  vCBS &#x3D; vBC x (pCBS ou pAliqEfetCBS).</param>
        public RTCInfoTributosAbrasfFed(decimal? pCBS = default(decimal?), decimal? pRedAliqCBS = default(decimal?), decimal? pAliqEfetCBS = default(decimal?), decimal? vCBS = default(decimal?))
        {
            this.pCBS = pCBS;
            this.pRedAliqCBS = pRedAliqCBS;
            this.pAliqEfetCBS = pAliqEfetCBS;
            this.vCBS = vCBS;
        }

        /// <summary>
        /// Alíquota da União para CBS.
        /// </summary>
        /// <value>Alíquota da União para CBS.</value>
        [DataMember(Name = "pCBS", EmitDefaultValue = true)]
        public decimal? pCBS { get; set; }

        /// <summary>
        /// Percentual da redução de alíquota da CBS.
        /// </summary>
        /// <value>Percentual da redução de alíquota da CBS.</value>
        [DataMember(Name = "pRedAliqCBS", EmitDefaultValue = true)]
        public decimal? pRedAliqCBS { get; set; }

        /// <summary>
        /// Alíquota efetiva da CBS.  pAliqEfetCBS &#x3D; pCBS x (1 - pRedAliqCBS) x (1 - pRedutor)
        /// </summary>
        /// <value>Alíquota efetiva da CBS.  pAliqEfetCBS &#x3D; pCBS x (1 - pRedAliqCBS) x (1 - pRedutor)</value>
        [DataMember(Name = "pAliqEfetCBS", EmitDefaultValue = true)]
        public decimal? pAliqEfetCBS { get; set; }

        /// <summary>
        /// Valor da CBS (R$).  vCBS &#x3D; vBC x (pCBS ou pAliqEfetCBS)
        /// </summary>
        /// <value>Valor da CBS (R$).  vCBS &#x3D; vBC x (pCBS ou pAliqEfetCBS)</value>
        [DataMember(Name = "vCBS", EmitDefaultValue = true)]
        public decimal? vCBS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCInfoTributosAbrasfFed {\n");
            sb.Append("  pCBS: ").Append(pCBS).Append("\n");
            sb.Append("  pRedAliqCBS: ").Append(pRedAliqCBS).Append("\n");
            sb.Append("  pAliqEfetCBS: ").Append(pAliqEfetCBS).Append("\n");
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
            return this.Equals(input as RTCInfoTributosAbrasfFed);
        }

        /// <summary>
        /// Returns true if RTCInfoTributosAbrasfFed instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCInfoTributosAbrasfFed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCInfoTributosAbrasfFed input)
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
                    this.pRedAliqCBS == input.pRedAliqCBS ||
                    (this.pRedAliqCBS != null &&
                    this.pRedAliqCBS.Equals(input.pRedAliqCBS))
                ) && 
                (
                    this.pAliqEfetCBS == input.pAliqEfetCBS ||
                    (this.pAliqEfetCBS != null &&
                    this.pAliqEfetCBS.Equals(input.pAliqEfetCBS))
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
                if (this.pRedAliqCBS != null)
                {
                    hashCode = (hashCode * 59) + this.pRedAliqCBS.GetHashCode();
                }
                if (this.pAliqEfetCBS != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqEfetCBS.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // pCBS (decimal?) minimum
            if (this.pCBS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pCBS, must be a value greater than or equal to 0.", new [] { "pCBS" });
            }

            // pRedAliqCBS (decimal?) minimum
            if (this.pRedAliqCBS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pRedAliqCBS, must be a value greater than or equal to 0.", new [] { "pRedAliqCBS" });
            }

            // pAliqEfetCBS (decimal?) minimum
            if (this.pAliqEfetCBS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pAliqEfetCBS, must be a value greater than or equal to 0.", new [] { "pAliqEfetCBS" });
            }

            // vCBS (decimal?) minimum
            if (this.vCBS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vCBS, must be a value greater than or equal to 0.", new [] { "vCBS" });
            }

            yield break;
        }
    }

}
