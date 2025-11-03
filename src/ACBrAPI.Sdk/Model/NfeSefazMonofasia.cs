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
    /// Informar essa opção da Choice para Monofasia.
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
        /// <param name="gMonoPadrao">gMonoPadrao.</param>
        /// <param name="gMonoReten">gMonoReten.</param>
        /// <param name="gMonoRet">gMonoRet.</param>
        /// <param name="gMonoDif">gMonoDif.</param>
        /// <param name="vTotIBSMonoItem">Total de IBS monofásico do item. (required).</param>
        /// <param name="vTotCBSMonoItem">Total da CBS monofásica do item. (required).</param>
        public NfeSefazMonofasia(NfeSefazGMonoPadrao gMonoPadrao = default(NfeSefazGMonoPadrao), NfeSefazGMonoReten gMonoReten = default(NfeSefazGMonoReten), NfeSefazGMonoRet gMonoRet = default(NfeSefazGMonoRet), NfeSefazGMonoDif gMonoDif = default(NfeSefazGMonoDif), decimal? vTotIBSMonoItem = default(decimal?), decimal? vTotCBSMonoItem = default(decimal?))
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
            this.gMonoPadrao = gMonoPadrao;
            this.gMonoReten = gMonoReten;
            this.gMonoRet = gMonoRet;
            this.gMonoDif = gMonoDif;
        }

        /// <summary>
        /// Gets or Sets gMonoPadrao
        /// </summary>
        [DataMember(Name = "gMonoPadrao", EmitDefaultValue = false)]
        public NfeSefazGMonoPadrao gMonoPadrao { get; set; }

        /// <summary>
        /// Gets or Sets gMonoReten
        /// </summary>
        [DataMember(Name = "gMonoReten", EmitDefaultValue = false)]
        public NfeSefazGMonoReten gMonoReten { get; set; }

        /// <summary>
        /// Gets or Sets gMonoRet
        /// </summary>
        [DataMember(Name = "gMonoRet", EmitDefaultValue = false)]
        public NfeSefazGMonoRet gMonoRet { get; set; }

        /// <summary>
        /// Gets or Sets gMonoDif
        /// </summary>
        [DataMember(Name = "gMonoDif", EmitDefaultValue = false)]
        public NfeSefazGMonoDif gMonoDif { get; set; }

        /// <summary>
        /// Total de IBS monofásico do item.
        /// </summary>
        /// <value>Total de IBS monofásico do item.</value>
        [DataMember(Name = "vTotIBSMonoItem", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTotIBSMonoItem { get; set; }

        /// <summary>
        /// Total da CBS monofásica do item.
        /// </summary>
        /// <value>Total da CBS monofásica do item.</value>
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
            sb.Append("  gMonoPadrao: ").Append(gMonoPadrao).Append("\n");
            sb.Append("  gMonoReten: ").Append(gMonoReten).Append("\n");
            sb.Append("  gMonoRet: ").Append(gMonoRet).Append("\n");
            sb.Append("  gMonoDif: ").Append(gMonoDif).Append("\n");
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
                    this.gMonoPadrao == input.gMonoPadrao ||
                    (this.gMonoPadrao != null &&
                    this.gMonoPadrao.Equals(input.gMonoPadrao))
                ) && 
                (
                    this.gMonoReten == input.gMonoReten ||
                    (this.gMonoReten != null &&
                    this.gMonoReten.Equals(input.gMonoReten))
                ) && 
                (
                    this.gMonoRet == input.gMonoRet ||
                    (this.gMonoRet != null &&
                    this.gMonoRet.Equals(input.gMonoRet))
                ) && 
                (
                    this.gMonoDif == input.gMonoDif ||
                    (this.gMonoDif != null &&
                    this.gMonoDif.Equals(input.gMonoDif))
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
                if (this.gMonoPadrao != null)
                {
                    hashCode = (hashCode * 59) + this.gMonoPadrao.GetHashCode();
                }
                if (this.gMonoReten != null)
                {
                    hashCode = (hashCode * 59) + this.gMonoReten.GetHashCode();
                }
                if (this.gMonoRet != null)
                {
                    hashCode = (hashCode * 59) + this.gMonoRet.GetHashCode();
                }
                if (this.gMonoDif != null)
                {
                    hashCode = (hashCode * 59) + this.gMonoDif.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // vTotIBSMonoItem (decimal?) minimum
            if (this.vTotIBSMonoItem < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTotIBSMonoItem, must be a value greater than or equal to 0.", new [] { "vTotIBSMonoItem" });
            }

            // vTotCBSMonoItem (decimal?) minimum
            if (this.vTotCBSMonoItem < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTotCBSMonoItem, must be a value greater than or equal to 0.", new [] { "vTotCBSMonoItem" });
            }

            yield break;
        }
    }

}
