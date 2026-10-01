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
    /// Grupo de informações relativas aos valores do IBS estadual.
    /// </summary>
    [DataContract(Name = "RTCInfoTributosAbrasfUF")]
    public partial class RTCInfoTributosAbrasfUF : IEquatable<RTCInfoTributosAbrasfUF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosAbrasfUF" /> class.
        /// </summary>
        /// <param name="pIBSUF">Alíquota da UF para IBS..</param>
        /// <param name="pRedAliqUF">Percentual de redução de alíquota estadual..</param>
        /// <param name="pAliqEfetUF">Alíquota efetiva do IBS estadual.  pAliqEfetUF &#x3D; pIBSUF x (1 - pRedAliqUF) x (1 - pRedutor).</param>
        /// <param name="vIBSUF">Valor do IBS estadual (R$).  vIBSUF &#x3D; vBC x (pIBSUF ou pAliqEfetUF).</param>
        public RTCInfoTributosAbrasfUF(decimal? pIBSUF = default(decimal?), decimal? pRedAliqUF = default(decimal?), decimal? pAliqEfetUF = default(decimal?), decimal? vIBSUF = default(decimal?))
        {
            this.pIBSUF = pIBSUF;
            this.pRedAliqUF = pRedAliqUF;
            this.pAliqEfetUF = pAliqEfetUF;
            this.vIBSUF = vIBSUF;
        }

        /// <summary>
        /// Alíquota da UF para IBS.
        /// </summary>
        /// <value>Alíquota da UF para IBS.</value>
        [DataMember(Name = "pIBSUF", EmitDefaultValue = true)]
        public decimal? pIBSUF { get; set; }

        /// <summary>
        /// Percentual de redução de alíquota estadual.
        /// </summary>
        /// <value>Percentual de redução de alíquota estadual.</value>
        [DataMember(Name = "pRedAliqUF", EmitDefaultValue = true)]
        public decimal? pRedAliqUF { get; set; }

        /// <summary>
        /// Alíquota efetiva do IBS estadual.  pAliqEfetUF &#x3D; pIBSUF x (1 - pRedAliqUF) x (1 - pRedutor)
        /// </summary>
        /// <value>Alíquota efetiva do IBS estadual.  pAliqEfetUF &#x3D; pIBSUF x (1 - pRedAliqUF) x (1 - pRedutor)</value>
        [DataMember(Name = "pAliqEfetUF", EmitDefaultValue = true)]
        public decimal? pAliqEfetUF { get; set; }

        /// <summary>
        /// Valor do IBS estadual (R$).  vIBSUF &#x3D; vBC x (pIBSUF ou pAliqEfetUF)
        /// </summary>
        /// <value>Valor do IBS estadual (R$).  vIBSUF &#x3D; vBC x (pIBSUF ou pAliqEfetUF)</value>
        [DataMember(Name = "vIBSUF", EmitDefaultValue = true)]
        public decimal? vIBSUF { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCInfoTributosAbrasfUF {\n");
            sb.Append("  pIBSUF: ").Append(pIBSUF).Append("\n");
            sb.Append("  pRedAliqUF: ").Append(pRedAliqUF).Append("\n");
            sb.Append("  pAliqEfetUF: ").Append(pAliqEfetUF).Append("\n");
            sb.Append("  vIBSUF: ").Append(vIBSUF).Append("\n");
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
            return this.Equals(input as RTCInfoTributosAbrasfUF);
        }

        /// <summary>
        /// Returns true if RTCInfoTributosAbrasfUF instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCInfoTributosAbrasfUF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCInfoTributosAbrasfUF input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pIBSUF == input.pIBSUF ||
                    (this.pIBSUF != null &&
                    this.pIBSUF.Equals(input.pIBSUF))
                ) && 
                (
                    this.pRedAliqUF == input.pRedAliqUF ||
                    (this.pRedAliqUF != null &&
                    this.pRedAliqUF.Equals(input.pRedAliqUF))
                ) && 
                (
                    this.pAliqEfetUF == input.pAliqEfetUF ||
                    (this.pAliqEfetUF != null &&
                    this.pAliqEfetUF.Equals(input.pAliqEfetUF))
                ) && 
                (
                    this.vIBSUF == input.vIBSUF ||
                    (this.vIBSUF != null &&
                    this.vIBSUF.Equals(input.vIBSUF))
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
                if (this.pIBSUF != null)
                {
                    hashCode = (hashCode * 59) + this.pIBSUF.GetHashCode();
                }
                if (this.pRedAliqUF != null)
                {
                    hashCode = (hashCode * 59) + this.pRedAliqUF.GetHashCode();
                }
                if (this.pAliqEfetUF != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqEfetUF.GetHashCode();
                }
                if (this.vIBSUF != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSUF.GetHashCode();
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
            // pIBSUF (decimal?) minimum
            if (this.pIBSUF < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pIBSUF, must be a value greater than or equal to 0.", new [] { "pIBSUF" });
            }

            // pRedAliqUF (decimal?) minimum
            if (this.pRedAliqUF < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pRedAliqUF, must be a value greater than or equal to 0.", new [] { "pRedAliqUF" });
            }

            // pAliqEfetUF (decimal?) minimum
            if (this.pAliqEfetUF < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pAliqEfetUF, must be a value greater than or equal to 0.", new [] { "pAliqEfetUF" });
            }

            // vIBSUF (decimal?) minimum
            if (this.vIBSUF < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vIBSUF, must be a value greater than or equal to 0.", new [] { "vIBSUF" });
            }

            yield break;
        }
    }

}
