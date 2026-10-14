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
    /// Grupo de informações da Tributação Monofásica Padrão.
    /// </summary>
    [DataContract(Name = "NfeSefazGCBSMonoAdRem_GMonoPadrao")]
    public partial class NfeSefazGCBSMonoAdRemGMonoPadrao : IEquatable<NfeSefazGCBSMonoAdRemGMonoPadrao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdRemGMonoPadrao" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGCBSMonoAdRemGMonoPadrao() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdRemGMonoPadrao" /> class.
        /// </summary>
        /// <param name="qBCMono">Quantidade tributada na monofasia. (required).</param>
        /// <param name="adRemCBS">Alíquota ad rem da CBS. (required).</param>
        /// <param name="vCBSMono">Valor da CBS monofásica. (required).</param>
        public NfeSefazGCBSMonoAdRemGMonoPadrao(decimal? qBCMono = default(decimal?), decimal? adRemCBS = default(decimal?), decimal? vCBSMono = default(decimal?))
        {
            // to ensure "qBCMono" is required (not null)
            if (qBCMono == null)
            {
                throw new ArgumentNullException("qBCMono is a required property for NfeSefazGCBSMonoAdRemGMonoPadrao and cannot be null");
            }
            this.qBCMono = qBCMono;
            // to ensure "adRemCBS" is required (not null)
            if (adRemCBS == null)
            {
                throw new ArgumentNullException("adRemCBS is a required property for NfeSefazGCBSMonoAdRemGMonoPadrao and cannot be null");
            }
            this.adRemCBS = adRemCBS;
            // to ensure "vCBSMono" is required (not null)
            if (vCBSMono == null)
            {
                throw new ArgumentNullException("vCBSMono is a required property for NfeSefazGCBSMonoAdRemGMonoPadrao and cannot be null");
            }
            this.vCBSMono = vCBSMono;
        }

        /// <summary>
        /// Quantidade tributada na monofasia.
        /// </summary>
        /// <value>Quantidade tributada na monofasia.</value>
        [DataMember(Name = "qBCMono", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qBCMono { get; set; }

        /// <summary>
        /// Alíquota ad rem da CBS.
        /// </summary>
        /// <value>Alíquota ad rem da CBS.</value>
        [DataMember(Name = "adRemCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? adRemCBS { get; set; }

        /// <summary>
        /// Valor da CBS monofásica.
        /// </summary>
        /// <value>Valor da CBS monofásica.</value>
        [DataMember(Name = "vCBSMono", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBSMono { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGCBSMonoAdRemGMonoPadrao {\n");
            sb.Append("  qBCMono: ").Append(qBCMono).Append("\n");
            sb.Append("  adRemCBS: ").Append(adRemCBS).Append("\n");
            sb.Append("  vCBSMono: ").Append(vCBSMono).Append("\n");
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
            return this.Equals(input as NfeSefazGCBSMonoAdRemGMonoPadrao);
        }

        /// <summary>
        /// Returns true if NfeSefazGCBSMonoAdRemGMonoPadrao instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGCBSMonoAdRemGMonoPadrao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGCBSMonoAdRemGMonoPadrao input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qBCMono == input.qBCMono ||
                    (this.qBCMono != null &&
                    this.qBCMono.Equals(input.qBCMono))
                ) && 
                (
                    this.adRemCBS == input.adRemCBS ||
                    (this.adRemCBS != null &&
                    this.adRemCBS.Equals(input.adRemCBS))
                ) && 
                (
                    this.vCBSMono == input.vCBSMono ||
                    (this.vCBSMono != null &&
                    this.vCBSMono.Equals(input.vCBSMono))
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
                if (this.qBCMono != null)
                {
                    hashCode = (hashCode * 59) + this.qBCMono.GetHashCode();
                }
                if (this.adRemCBS != null)
                {
                    hashCode = (hashCode * 59) + this.adRemCBS.GetHashCode();
                }
                if (this.vCBSMono != null)
                {
                    hashCode = (hashCode * 59) + this.vCBSMono.GetHashCode();
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
            // qBCMono (decimal?) minimum
            if (this.qBCMono < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qBCMono, must be a value greater than or equal to 0.", new [] { "qBCMono" });
            }

            // adRemCBS (decimal?) minimum
            if (this.adRemCBS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for adRemCBS, must be a value greater than or equal to 0.", new [] { "adRemCBS" });
            }

            // vCBSMono (decimal?) minimum
            if (this.vCBSMono < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vCBSMono, must be a value greater than or equal to 0.", new [] { "vCBSMono" });
            }

            yield break;
        }
    }

}
