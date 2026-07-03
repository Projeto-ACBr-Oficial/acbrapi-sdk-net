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
    /// Grupo de informações de documento não fiscal.
    /// </summary>
    [DataContract(Name = "RTCListaDocOutro")]
    public partial class RTCListaDocOutro : IEquatable<RTCListaDocOutro>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCListaDocOutro" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCListaDocOutro() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCListaDocOutro" /> class.
        /// </summary>
        /// <param name="nDoc">Número do documento não fiscal. (required).</param>
        /// <param name="xDoc">Descrição do documento não fiscal. (required).</param>
        public RTCListaDocOutro(string nDoc = default(string), string xDoc = default(string))
        {
            // to ensure "nDoc" is required (not null)
            if (nDoc == null)
            {
                throw new ArgumentNullException("nDoc is a required property for RTCListaDocOutro and cannot be null");
            }
            this.nDoc = nDoc;
            // to ensure "xDoc" is required (not null)
            if (xDoc == null)
            {
                throw new ArgumentNullException("xDoc is a required property for RTCListaDocOutro and cannot be null");
            }
            this.xDoc = xDoc;
        }

        /// <summary>
        /// Número do documento não fiscal.
        /// </summary>
        /// <value>Número do documento não fiscal.</value>
        [DataMember(Name = "nDoc", IsRequired = true, EmitDefaultValue = true)]
        public string nDoc { get; set; }

        /// <summary>
        /// Descrição do documento não fiscal.
        /// </summary>
        /// <value>Descrição do documento não fiscal.</value>
        [DataMember(Name = "xDoc", IsRequired = true, EmitDefaultValue = true)]
        public string xDoc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCListaDocOutro {\n");
            sb.Append("  nDoc: ").Append(nDoc).Append("\n");
            sb.Append("  xDoc: ").Append(xDoc).Append("\n");
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
            return this.Equals(input as RTCListaDocOutro);
        }

        /// <summary>
        /// Returns true if RTCListaDocOutro instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCListaDocOutro to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCListaDocOutro input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nDoc == input.nDoc ||
                    (this.nDoc != null &&
                    this.nDoc.Equals(input.nDoc))
                ) && 
                (
                    this.xDoc == input.xDoc ||
                    (this.xDoc != null &&
                    this.xDoc.Equals(input.xDoc))
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
                if (this.nDoc != null)
                {
                    hashCode = (hashCode * 59) + this.nDoc.GetHashCode();
                }
                if (this.xDoc != null)
                {
                    hashCode = (hashCode * 59) + this.xDoc.GetHashCode();
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
            // nDoc (string) maxLength
            if (this.nDoc != null && this.nDoc.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDoc, length must be less than 255.", new [] { "nDoc" });
            }

            // nDoc (string) minLength
            if (this.nDoc != null && this.nDoc.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for nDoc, length must be greater than 1.", new [] { "nDoc" });
            }

            // xDoc (string) maxLength
            if (this.xDoc != null && this.xDoc.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xDoc, length must be less than 255.", new [] { "xDoc" });
            }

            // xDoc (string) minLength
            if (this.xDoc != null && this.xDoc.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xDoc, length must be greater than 1.", new [] { "xDoc" });
            }

            yield break;
        }
    }

}
