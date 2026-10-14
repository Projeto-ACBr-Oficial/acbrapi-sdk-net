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
    /// Grupo de Informações do IBS e CBS em operações com imposto monofásico (CST 620).
    /// </summary>
    [DataContract(Name = "NfeSefazMonofasia")]
    public partial class NfeSefazMonofasia : IEquatable<NfeSefazMonofasia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazMonofasia" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazMonofasia() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazMonofasia" /> class.
        /// </summary>
        /// <param name="gIBSMonoAdRem">gIBSMonoAdRem.</param>
        /// <param name="gIBSMonoAdValorem">gIBSMonoAdValorem.</param>
        /// <param name="gCBSMonoAdRem">gCBSMonoAdRem.</param>
        /// <param name="gCBSMonoAdValorem">gCBSMonoAdValorem.</param>
        /// <param name="vTotIBSMonoItem">Total de IBS Monofásico. (required).</param>
        /// <param name="vTotCBSMonoItem">Total da CBS Monofásica. (required).</param>
        public NfeSefazMonofasia(NfeSefazGIBSMonoAdRem gIBSMonoAdRem = default(NfeSefazGIBSMonoAdRem), NfeSefazGIBSMonoAdValorem gIBSMonoAdValorem = default(NfeSefazGIBSMonoAdValorem), NfeSefazGCBSMonoAdRem gCBSMonoAdRem = default(NfeSefazGCBSMonoAdRem), NfeSefazGCBSMonoAdValorem gCBSMonoAdValorem = default(NfeSefazGCBSMonoAdValorem), decimal? vTotIBSMonoItem = default(decimal?), decimal? vTotCBSMonoItem = default(decimal?))
        {
            // to ensure "vTotIBSMonoItem" is required (not null)
            if (vTotIBSMonoItem == null)
            {
                throw new ArgumentNullException("vTotIBSMonoItem is a required property for NfeSefazMonofasia and cannot be null");
            }
            this.vTotIBSMonoItem = vTotIBSMonoItem;
            // to ensure "vTotCBSMonoItem" is required (not null)
            if (vTotCBSMonoItem == null)
            {
                throw new ArgumentNullException("vTotCBSMonoItem is a required property for NfeSefazMonofasia and cannot be null");
            }
            this.vTotCBSMonoItem = vTotCBSMonoItem;
            this.gIBSMonoAdRem = gIBSMonoAdRem;
            this.gIBSMonoAdValorem = gIBSMonoAdValorem;
            this.gCBSMonoAdRem = gCBSMonoAdRem;
            this.gCBSMonoAdValorem = gCBSMonoAdValorem;
        }

        /// <summary>
        /// Gets or Sets gIBSMonoAdRem
        /// </summary>
        [DataMember(Name = "gIBSMonoAdRem", EmitDefaultValue = false)]
        public NfeSefazGIBSMonoAdRem gIBSMonoAdRem { get; set; }

        /// <summary>
        /// Gets or Sets gIBSMonoAdValorem
        /// </summary>
        [DataMember(Name = "gIBSMonoAdValorem", EmitDefaultValue = false)]
        public NfeSefazGIBSMonoAdValorem gIBSMonoAdValorem { get; set; }

        /// <summary>
        /// Gets or Sets gCBSMonoAdRem
        /// </summary>
        [DataMember(Name = "gCBSMonoAdRem", EmitDefaultValue = false)]
        public NfeSefazGCBSMonoAdRem gCBSMonoAdRem { get; set; }

        /// <summary>
        /// Gets or Sets gCBSMonoAdValorem
        /// </summary>
        [DataMember(Name = "gCBSMonoAdValorem", EmitDefaultValue = false)]
        public NfeSefazGCBSMonoAdValorem gCBSMonoAdValorem { get; set; }

        /// <summary>
        /// Total de IBS Monofásico.
        /// </summary>
        /// <value>Total de IBS Monofásico.</value>
        [DataMember(Name = "vTotIBSMonoItem", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTotIBSMonoItem { get; set; }

        /// <summary>
        /// Total da CBS Monofásica.
        /// </summary>
        /// <value>Total da CBS Monofásica.</value>
        [DataMember(Name = "vTotCBSMonoItem", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTotCBSMonoItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazMonofasia {\n");
            sb.Append("  gIBSMonoAdRem: ").Append(gIBSMonoAdRem).Append("\n");
            sb.Append("  gIBSMonoAdValorem: ").Append(gIBSMonoAdValorem).Append("\n");
            sb.Append("  gCBSMonoAdRem: ").Append(gCBSMonoAdRem).Append("\n");
            sb.Append("  gCBSMonoAdValorem: ").Append(gCBSMonoAdValorem).Append("\n");
            sb.Append("  vTotIBSMonoItem: ").Append(vTotIBSMonoItem).Append("\n");
            sb.Append("  vTotCBSMonoItem: ").Append(vTotCBSMonoItem).Append("\n");
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
            return this.Equals(input as NfeSefazMonofasia);
        }

        /// <summary>
        /// Returns true if NfeSefazMonofasia instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazMonofasia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazMonofasia input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.gIBSMonoAdRem == input.gIBSMonoAdRem ||
                    (this.gIBSMonoAdRem != null &&
                    this.gIBSMonoAdRem.Equals(input.gIBSMonoAdRem))
                ) && 
                (
                    this.gIBSMonoAdValorem == input.gIBSMonoAdValorem ||
                    (this.gIBSMonoAdValorem != null &&
                    this.gIBSMonoAdValorem.Equals(input.gIBSMonoAdValorem))
                ) && 
                (
                    this.gCBSMonoAdRem == input.gCBSMonoAdRem ||
                    (this.gCBSMonoAdRem != null &&
                    this.gCBSMonoAdRem.Equals(input.gCBSMonoAdRem))
                ) && 
                (
                    this.gCBSMonoAdValorem == input.gCBSMonoAdValorem ||
                    (this.gCBSMonoAdValorem != null &&
                    this.gCBSMonoAdValorem.Equals(input.gCBSMonoAdValorem))
                ) && 
                (
                    this.vTotIBSMonoItem == input.vTotIBSMonoItem ||
                    (this.vTotIBSMonoItem != null &&
                    this.vTotIBSMonoItem.Equals(input.vTotIBSMonoItem))
                ) && 
                (
                    this.vTotCBSMonoItem == input.vTotCBSMonoItem ||
                    (this.vTotCBSMonoItem != null &&
                    this.vTotCBSMonoItem.Equals(input.vTotCBSMonoItem))
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
                if (this.gIBSMonoAdRem != null)
                {
                    hashCode = (hashCode * 59) + this.gIBSMonoAdRem.GetHashCode();
                }
                if (this.gIBSMonoAdValorem != null)
                {
                    hashCode = (hashCode * 59) + this.gIBSMonoAdValorem.GetHashCode();
                }
                if (this.gCBSMonoAdRem != null)
                {
                    hashCode = (hashCode * 59) + this.gCBSMonoAdRem.GetHashCode();
                }
                if (this.gCBSMonoAdValorem != null)
                {
                    hashCode = (hashCode * 59) + this.gCBSMonoAdValorem.GetHashCode();
                }
                if (this.vTotIBSMonoItem != null)
                {
                    hashCode = (hashCode * 59) + this.vTotIBSMonoItem.GetHashCode();
                }
                if (this.vTotCBSMonoItem != null)
                {
                    hashCode = (hashCode * 59) + this.vTotCBSMonoItem.GetHashCode();
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
            // vTotIBSMonoItem (decimal?) minimum
            if (this.vTotIBSMonoItem < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vTotIBSMonoItem, must be a value greater than or equal to 0.", new [] { "vTotIBSMonoItem" });
            }

            // vTotCBSMonoItem (decimal?) minimum
            if (this.vTotCBSMonoItem < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vTotCBSMonoItem, must be a value greater than or equal to 0.", new [] { "vTotCBSMonoItem" });
            }

            yield break;
        }
    }

}
