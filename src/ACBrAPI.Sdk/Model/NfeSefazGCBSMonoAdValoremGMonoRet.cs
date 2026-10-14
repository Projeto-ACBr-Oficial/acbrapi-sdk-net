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
    /// Grupo de informações da Tributação Monofásica Retida Anteriormente.
    /// </summary>
    [DataContract(Name = "NfeSefazGCBSMonoAdValorem_GMonoRet")]
    public partial class NfeSefazGCBSMonoAdValoremGMonoRet : IEquatable<NfeSefazGCBSMonoAdValoremGMonoRet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdValoremGMonoRet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGCBSMonoAdValoremGMonoRet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdValoremGMonoRet" /> class.
        /// </summary>
        /// <param name="vCBSMonoRet">Valor da CBS retida anteriormente. (required).</param>
        public NfeSefazGCBSMonoAdValoremGMonoRet(decimal? vCBSMonoRet = default(decimal?))
        {
            // to ensure "vCBSMonoRet" is required (not null)
            if (vCBSMonoRet == null)
            {
                throw new ArgumentNullException("vCBSMonoRet is a required property for NfeSefazGCBSMonoAdValoremGMonoRet and cannot be null");
            }
            this.vCBSMonoRet = vCBSMonoRet;
        }

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
            sb.Append("class NfeSefazGCBSMonoAdValoremGMonoRet {\n");
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
            return this.Equals(input as NfeSefazGCBSMonoAdValoremGMonoRet);
        }

        /// <summary>
        /// Returns true if NfeSefazGCBSMonoAdValoremGMonoRet instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGCBSMonoAdValoremGMonoRet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGCBSMonoAdValoremGMonoRet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // vCBSMonoRet (decimal?) minimum
            if (this.vCBSMonoRet < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vCBSMonoRet, must be a value greater than or equal to 0.", new [] { "vCBSMonoRet" });
            }

            yield break;
        }
    }

}
