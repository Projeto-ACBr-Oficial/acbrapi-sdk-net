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
    [DataContract(Name = "NfeSefazGIBSMonoAdValorem_GMonoRet")]
    public partial class NfeSefazGIBSMonoAdValoremGMonoRet : IEquatable<NfeSefazGIBSMonoAdValoremGMonoRet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGIBSMonoAdValoremGMonoRet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGIBSMonoAdValoremGMonoRet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGIBSMonoAdValoremGMonoRet" /> class.
        /// </summary>
        /// <param name="vIBSMonoRet">Valor do IBS retido anteriormente. (required).</param>
        public NfeSefazGIBSMonoAdValoremGMonoRet(decimal? vIBSMonoRet = default(decimal?))
        {
            // to ensure "vIBSMonoRet" is required (not null)
            if (vIBSMonoRet == null)
            {
                throw new ArgumentNullException("vIBSMonoRet is a required property for NfeSefazGIBSMonoAdValoremGMonoRet and cannot be null");
            }
            this.vIBSMonoRet = vIBSMonoRet;
        }

        /// <summary>
        /// Valor do IBS retido anteriormente.
        /// </summary>
        /// <value>Valor do IBS retido anteriormente.</value>
        [DataMember(Name = "vIBSMonoRet", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSMonoRet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGIBSMonoAdValoremGMonoRet {\n");
            sb.Append("  vIBSMonoRet: ").Append(vIBSMonoRet).Append("\n");
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
            return this.Equals(input as NfeSefazGIBSMonoAdValoremGMonoRet);
        }

        /// <summary>
        /// Returns true if NfeSefazGIBSMonoAdValoremGMonoRet instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGIBSMonoAdValoremGMonoRet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGIBSMonoAdValoremGMonoRet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vIBSMonoRet == input.vIBSMonoRet ||
                    (this.vIBSMonoRet != null &&
                    this.vIBSMonoRet.Equals(input.vIBSMonoRet))
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
                if (this.vIBSMonoRet != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSMonoRet.GetHashCode();
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
            // vIBSMonoRet (decimal?) minimum
            if (this.vIBSMonoRet < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vIBSMonoRet, must be a value greater than or equal to 0.", new [] { "vIBSMonoRet" });
            }

            yield break;
        }
    }

}
