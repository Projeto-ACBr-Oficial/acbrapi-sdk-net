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
    /// Grupo de informações da Tributação Regular.
    /// </summary>
    [DataContract(Name = "RTCInfoTributosTribRegular")]
    public partial class RTCInfoTributosTribRegular : IEquatable<RTCInfoTributosTribRegular>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosTribRegular" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCInfoTributosTribRegular() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosTribRegular" /> class.
        /// </summary>
        /// <param name="cSTReg">Código de Situação Tributária do IBS e da CBS de tributação regular. (required).</param>
        /// <param name="cClassTribReg">Código da Classificação Tributária do IBS e da CBS de tributação regular. (required).</param>
        public RTCInfoTributosTribRegular(string cSTReg = default(string), string cClassTribReg = default(string))
        {
            // to ensure "cSTReg" is required (not null)
            if (cSTReg == null)
            {
                throw new ArgumentNullException("cSTReg is a required property for RTCInfoTributosTribRegular and cannot be null");
            }
            this.CSTReg = cSTReg;
            // to ensure "cClassTribReg" is required (not null)
            if (cClassTribReg == null)
            {
                throw new ArgumentNullException("cClassTribReg is a required property for RTCInfoTributosTribRegular and cannot be null");
            }
            this.cClassTribReg = cClassTribReg;
        }

        /// <summary>
        /// Código de Situação Tributária do IBS e da CBS de tributação regular.
        /// </summary>
        /// <value>Código de Situação Tributária do IBS e da CBS de tributação regular.</value>
        [DataMember(Name = "CSTReg", IsRequired = true, EmitDefaultValue = true)]
        public string CSTReg { get; set; }

        /// <summary>
        /// Código da Classificação Tributária do IBS e da CBS de tributação regular.
        /// </summary>
        /// <value>Código da Classificação Tributária do IBS e da CBS de tributação regular.</value>
        [DataMember(Name = "cClassTribReg", IsRequired = true, EmitDefaultValue = true)]
        public string cClassTribReg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCInfoTributosTribRegular {\n");
            sb.Append("  CSTReg: ").Append(CSTReg).Append("\n");
            sb.Append("  cClassTribReg: ").Append(cClassTribReg).Append("\n");
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
            return this.Equals(input as RTCInfoTributosTribRegular);
        }

        /// <summary>
        /// Returns true if RTCInfoTributosTribRegular instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCInfoTributosTribRegular to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCInfoTributosTribRegular input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CSTReg == input.CSTReg ||
                    (this.CSTReg != null &&
                    this.CSTReg.Equals(input.CSTReg))
                ) && 
                (
                    this.cClassTribReg == input.cClassTribReg ||
                    (this.cClassTribReg != null &&
                    this.cClassTribReg.Equals(input.cClassTribReg))
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
                if (this.CSTReg != null)
                {
                    hashCode = (hashCode * 59) + this.CSTReg.GetHashCode();
                }
                if (this.cClassTribReg != null)
                {
                    hashCode = (hashCode * 59) + this.cClassTribReg.GetHashCode();
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
            yield break;
        }
    }

}
