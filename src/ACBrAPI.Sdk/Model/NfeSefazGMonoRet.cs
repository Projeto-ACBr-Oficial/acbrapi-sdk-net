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
    /// Grupo de informações da Tributação Monofásica retida anteriormente.
    /// </summary>
    [DataContract(Name = "NfeSefazGMonoRet")]
    public partial class NfeSefazGMonoRet : IEquatable<NfeSefazGMonoRet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGMonoRet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGMonoRet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGMonoRet" /> class.
        /// </summary>
        /// <param name="qBCMonoRet">Quantidade tributada retida anteriormente. (required).</param>
        /// <param name="adRemIBSRet">Alíquota ad rem do IBS retido anteriormente. (required).</param>
        /// <param name="vIBSMonoRet">Valor do IBS retido anteriormente. (required).</param>
        /// <param name="adRemCBSRet">Alíquota ad rem da CBS retida anteriormente. (required).</param>
        /// <param name="vCBSMonoRet">Valor da CBS retida anteriormente. (required).</param>
        public NfeSefazGMonoRet(decimal? qBCMonoRet = default(decimal?), decimal? adRemIBSRet = default(decimal?), decimal? vIBSMonoRet = default(decimal?), decimal? adRemCBSRet = default(decimal?), decimal? vCBSMonoRet = default(decimal?))
        {
            // to ensure "qBCMonoRet" is required (not null)
            if (qBCMonoRet == null)
            {
                throw new ArgumentNullException("qBCMonoRet is a required property for NfeSefazGMonoRet and cannot be null");
            }
            this.qBCMonoRet = qBCMonoRet;
            // to ensure "adRemIBSRet" is required (not null)
            if (adRemIBSRet == null)
            {
                throw new ArgumentNullException("adRemIBSRet is a required property for NfeSefazGMonoRet and cannot be null");
            }
            this.adRemIBSRet = adRemIBSRet;
            // to ensure "vIBSMonoRet" is required (not null)
            if (vIBSMonoRet == null)
            {
                throw new ArgumentNullException("vIBSMonoRet is a required property for NfeSefazGMonoRet and cannot be null");
            }
            this.vIBSMonoRet = vIBSMonoRet;
            // to ensure "adRemCBSRet" is required (not null)
            if (adRemCBSRet == null)
            {
                throw new ArgumentNullException("adRemCBSRet is a required property for NfeSefazGMonoRet and cannot be null");
            }
            this.adRemCBSRet = adRemCBSRet;
            // to ensure "vCBSMonoRet" is required (not null)
            if (vCBSMonoRet == null)
            {
                throw new ArgumentNullException("vCBSMonoRet is a required property for NfeSefazGMonoRet and cannot be null");
            }
            this.vCBSMonoRet = vCBSMonoRet;
        }

        /// <summary>
        /// Quantidade tributada retida anteriormente.
        /// </summary>
        /// <value>Quantidade tributada retida anteriormente.</value>
        [DataMember(Name = "qBCMonoRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qBCMonoRet { get; set; }

        /// <summary>
        /// Alíquota ad rem do IBS retido anteriormente.
        /// </summary>
        /// <value>Alíquota ad rem do IBS retido anteriormente.</value>
        [DataMember(Name = "adRemIBSRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal? adRemIBSRet { get; set; }

        /// <summary>
        /// Valor do IBS retido anteriormente.
        /// </summary>
        /// <value>Valor do IBS retido anteriormente.</value>
        [DataMember(Name = "vIBSMonoRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMonoRet { get; set; }

        /// <summary>
        /// Alíquota ad rem da CBS retida anteriormente.
        /// </summary>
        /// <value>Alíquota ad rem da CBS retida anteriormente.</value>
        [DataMember(Name = "adRemCBSRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal? adRemCBSRet { get; set; }

        /// <summary>
        /// Valor da CBS retida anteriormente.
        /// </summary>
        /// <value>Valor da CBS retida anteriormente.</value>
        [DataMember(Name = "vCBSMonoRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBSMonoRet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGMonoRet {\n");
            sb.Append("  qBCMonoRet: ").Append(qBCMonoRet).Append("\n");
            sb.Append("  adRemIBSRet: ").Append(adRemIBSRet).Append("\n");
            sb.Append("  vIBSMonoRet: ").Append(vIBSMonoRet).Append("\n");
            sb.Append("  adRemCBSRet: ").Append(adRemCBSRet).Append("\n");
            sb.Append("  vCBSMonoRet: ").Append(vCBSMonoRet).Append("\n");
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
            return this.Equals(input as NfeSefazGMonoRet);
        }

        /// <summary>
        /// Returns true if NfeSefazGMonoRet instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGMonoRet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGMonoRet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qBCMonoRet == input.qBCMonoRet ||
                    (this.qBCMonoRet != null &&
                    this.qBCMonoRet.Equals(input.qBCMonoRet))
                ) && 
                (
                    this.adRemIBSRet == input.adRemIBSRet ||
                    (this.adRemIBSRet != null &&
                    this.adRemIBSRet.Equals(input.adRemIBSRet))
                ) && 
                (
                    this.vIBSMonoRet == input.vIBSMonoRet ||
                    (this.vIBSMonoRet != null &&
                    this.vIBSMonoRet.Equals(input.vIBSMonoRet))
                ) && 
                (
                    this.adRemCBSRet == input.adRemCBSRet ||
                    (this.adRemCBSRet != null &&
                    this.adRemCBSRet.Equals(input.adRemCBSRet))
                ) && 
                (
                    this.vCBSMonoRet == input.vCBSMonoRet ||
                    (this.vCBSMonoRet != null &&
                    this.vCBSMonoRet.Equals(input.vCBSMonoRet))
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
                if (this.qBCMonoRet != null)
                {
                    hashCode = (hashCode * 59) + this.qBCMonoRet.GetHashCode();
                }
                if (this.adRemIBSRet != null)
                {
                    hashCode = (hashCode * 59) + this.adRemIBSRet.GetHashCode();
                }
                if (this.vIBSMonoRet != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSMonoRet.GetHashCode();
                }
                if (this.adRemCBSRet != null)
                {
                    hashCode = (hashCode * 59) + this.adRemCBSRet.GetHashCode();
                }
                if (this.vCBSMonoRet != null)
                {
                    hashCode = (hashCode * 59) + this.vCBSMonoRet.GetHashCode();
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
            // qBCMonoRet (decimal?) minimum
            if (this.qBCMonoRet < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qBCMonoRet, must be a value greater than or equal to 0.", new [] { "qBCMonoRet" });
            }

            // adRemIBSRet (decimal?) minimum
            if (this.adRemIBSRet < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for adRemIBSRet, must be a value greater than or equal to 0.", new [] { "adRemIBSRet" });
            }

            // vIBSMonoRet (decimal?) minimum
            if (this.vIBSMonoRet < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIBSMonoRet, must be a value greater than or equal to 0.", new [] { "vIBSMonoRet" });
            }

            // adRemCBSRet (decimal?) minimum
            if (this.adRemCBSRet < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for adRemCBSRet, must be a value greater than or equal to 0.", new [] { "adRemCBSRet" });
            }

            // vCBSMonoRet (decimal?) minimum
            if (this.vCBSMonoRet < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCBSMonoRet, must be a value greater than or equal to 0.", new [] { "vCBSMonoRet" });
            }

            yield break;
        }
    }

}
