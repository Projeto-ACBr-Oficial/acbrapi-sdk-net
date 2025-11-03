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
    /// Valores totais da NF com Imposto Seletivo.
    /// </summary>
    [DataContract(Name = "NfeSefazISTot")]
    public partial class NfeSefazISTot : IEquatable<NfeSefazISTot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazISTot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazISTot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazISTot" /> class.
        /// </summary>
        /// <param name="vIS">Valor Total do Imposto Seletivo. (required).</param>
        public NfeSefazISTot(decimal? vIS = default(decimal?))
        {
            // to ensure "vIS" is required (not null)
            if (vIS == null)
            {
                throw new ArgumentNullException("vIS is a required property for NfeSefazISTot and cannot be null");
            }
            this.vIS = vIS;
        }

        /// <summary>
        /// Valor Total do Imposto Seletivo.
        /// </summary>
        /// <value>Valor Total do Imposto Seletivo.</value>
        [DataMember(Name = "vIS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazISTot {\n");
            sb.Append("  vIS: ").Append(vIS).Append("\n");
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
            return this.Equals(input as NfeSefazISTot);
        }

        /// <summary>
        /// Returns true if NfeSefazISTot instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazISTot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazISTot input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vIS == input.vIS ||
                    (this.vIS != null &&
                    this.vIS.Equals(input.vIS))
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
                if (this.vIS != null)
                {
                    hashCode = (hashCode * 59) + this.vIS.GetHashCode();
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
            // vIS (decimal?) minimum
            if (this.vIS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIS, must be a value greater than or equal to 0.", new [] { "vIS" });
            }

            yield break;
        }
    }

}
