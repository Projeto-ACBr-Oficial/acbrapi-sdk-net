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
    /// Informado conforme indicador no cClassTrib.
    /// </summary>
    [DataContract(Name = "CteSefazEstornoCred")]
    public partial class CteSefazEstornoCred : IEquatable<CteSefazEstornoCred>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazEstornoCred" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazEstornoCred() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazEstornoCred" /> class.
        /// </summary>
        /// <param name="vIBSEstCred">Valor do IBS a ser estornado. (required).</param>
        /// <param name="vCBSEstCred">Valor da CBS a ser estornada. (required).</param>
        public CteSefazEstornoCred(decimal? vIBSEstCred = default(decimal?), decimal? vCBSEstCred = default(decimal?))
        {
            // to ensure "vIBSEstCred" is required (not null)
            if (vIBSEstCred == null)
            {
                throw new ArgumentNullException("vIBSEstCred is a required property for CteSefazEstornoCred and cannot be null");
            }
            this.vIBSEstCred = vIBSEstCred;
            // to ensure "vCBSEstCred" is required (not null)
            if (vCBSEstCred == null)
            {
                throw new ArgumentNullException("vCBSEstCred is a required property for CteSefazEstornoCred and cannot be null");
            }
            this.vCBSEstCred = vCBSEstCred;
        }

        /// <summary>
        /// Valor do IBS a ser estornado.
        /// </summary>
        /// <value>Valor do IBS a ser estornado.</value>
        [DataMember(Name = "vIBSEstCred", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vIBSEstCred { get; set; }

        /// <summary>
        /// Valor da CBS a ser estornada.
        /// </summary>
        /// <value>Valor da CBS a ser estornada.</value>
        [DataMember(Name = "vCBSEstCred", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBSEstCred { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazEstornoCred {\n");
            sb.Append("  vIBSEstCred: ").Append(vIBSEstCred).Append("\n");
            sb.Append("  vCBSEstCred: ").Append(vCBSEstCred).Append("\n");
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
            return this.Equals(input as CteSefazEstornoCred);
        }

        /// <summary>
        /// Returns true if CteSefazEstornoCred instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazEstornoCred to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazEstornoCred input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vIBSEstCred == input.vIBSEstCred ||
                    (this.vIBSEstCred != null &&
                    this.vIBSEstCred.Equals(input.vIBSEstCred))
                ) && 
                (
                    this.vCBSEstCred == input.vCBSEstCred ||
                    (this.vCBSEstCred != null &&
                    this.vCBSEstCred.Equals(input.vCBSEstCred))
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
                if (this.vIBSEstCred != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSEstCred.GetHashCode();
                }
                if (this.vCBSEstCred != null)
                {
                    hashCode = (hashCode * 59) + this.vCBSEstCred.GetHashCode();
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
            // vIBSEstCred (decimal?) minimum
            if (this.vIBSEstCred < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vIBSEstCred, must be a value greater than or equal to 0.", new [] { "vIBSEstCred" });
            }

            // vCBSEstCred (decimal?) minimum
            if (this.vCBSEstCred < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vCBSEstCred, must be a value greater than or equal to 0.", new [] { "vCBSEstCred" });
            }

            yield break;
        }
    }

}
