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
    /// Grupo de informações relativas aos valores do IBS municipal.
    /// </summary>
    [DataContract(Name = "RTCInfoTributosAbrasfMun")]
    public partial class RTCInfoTributosAbrasfMun : IEquatable<RTCInfoTributosAbrasfMun>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosAbrasfMun" /> class.
        /// </summary>
        /// <param name="pIBSMun">Alíquota do Município para IBS..</param>
        /// <param name="pRedAliqMun">Percentual de redução de alíquota municipal..</param>
        /// <param name="pAliqEfetMun">Alíquota efetiva do IBS municipal.  pAliqEfetMun &#x3D; pIBSMun x (1 - pRedAliqMun) x (1 - pRedutor).</param>
        /// <param name="vIBSMun">Valor do IBS municipal (R$).  vIBSMun &#x3D; vBC x (pIBSMun ou pAliqEfetMun).</param>
        public RTCInfoTributosAbrasfMun(decimal? pIBSMun = default(decimal?), decimal? pRedAliqMun = default(decimal?), decimal? pAliqEfetMun = default(decimal?), decimal? vIBSMun = default(decimal?))
        {
            this.pIBSMun = pIBSMun;
            this.pRedAliqMun = pRedAliqMun;
            this.pAliqEfetMun = pAliqEfetMun;
            this.vIBSMun = vIBSMun;
        }

        /// <summary>
        /// Alíquota do Município para IBS.
        /// </summary>
        /// <value>Alíquota do Município para IBS.</value>
        [DataMember(Name = "pIBSMun", EmitDefaultValue = true)]
        public decimal? pIBSMun { get; set; }

        /// <summary>
        /// Percentual de redução de alíquota municipal.
        /// </summary>
        /// <value>Percentual de redução de alíquota municipal.</value>
        [DataMember(Name = "pRedAliqMun", EmitDefaultValue = true)]
        public decimal? pRedAliqMun { get; set; }

        /// <summary>
        /// Alíquota efetiva do IBS municipal.  pAliqEfetMun &#x3D; pIBSMun x (1 - pRedAliqMun) x (1 - pRedutor)
        /// </summary>
        /// <value>Alíquota efetiva do IBS municipal.  pAliqEfetMun &#x3D; pIBSMun x (1 - pRedAliqMun) x (1 - pRedutor)</value>
        [DataMember(Name = "pAliqEfetMun", EmitDefaultValue = true)]
        public decimal? pAliqEfetMun { get; set; }

        /// <summary>
        /// Valor do IBS municipal (R$).  vIBSMun &#x3D; vBC x (pIBSMun ou pAliqEfetMun)
        /// </summary>
        /// <value>Valor do IBS municipal (R$).  vIBSMun &#x3D; vBC x (pIBSMun ou pAliqEfetMun)</value>
        [DataMember(Name = "vIBSMun", EmitDefaultValue = true)]
        public decimal? vIBSMun { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCInfoTributosAbrasfMun {\n");
            sb.Append("  pIBSMun: ").Append(pIBSMun).Append("\n");
            sb.Append("  pRedAliqMun: ").Append(pRedAliqMun).Append("\n");
            sb.Append("  pAliqEfetMun: ").Append(pAliqEfetMun).Append("\n");
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
            return this.Equals(input as RTCInfoTributosAbrasfMun);
        }

        /// <summary>
        /// Returns true if RTCInfoTributosAbrasfMun instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCInfoTributosAbrasfMun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCInfoTributosAbrasfMun input)
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
                    this.pRedAliqMun == input.pRedAliqMun ||
                    (this.pRedAliqMun != null &&
                    this.pRedAliqMun.Equals(input.pRedAliqMun))
                ) && 
                (
                    this.pAliqEfetMun == input.pAliqEfetMun ||
                    (this.pAliqEfetMun != null &&
                    this.pAliqEfetMun.Equals(input.pAliqEfetMun))
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
                if (this.pRedAliqMun != null)
                {
                    hashCode = (hashCode * 59) + this.pRedAliqMun.GetHashCode();
                }
                if (this.pAliqEfetMun != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqEfetMun.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // pIBSMun (decimal?) minimum
            if (this.pIBSMun < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pIBSMun, must be a value greater than or equal to 0.", new [] { "pIBSMun" });
            }

            // pRedAliqMun (decimal?) minimum
            if (this.pRedAliqMun < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pRedAliqMun, must be a value greater than or equal to 0.", new [] { "pRedAliqMun" });
            }

            // pAliqEfetMun (decimal?) minimum
            if (this.pAliqEfetMun < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pAliqEfetMun, must be a value greater than or equal to 0.", new [] { "pAliqEfetMun" });
            }

            // vIBSMun (decimal?) minimum
            if (this.vIBSMun < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vIBSMun, must be a value greater than or equal to 0.", new [] { "vIBSMun" });
            }

            yield break;
        }
    }

}
