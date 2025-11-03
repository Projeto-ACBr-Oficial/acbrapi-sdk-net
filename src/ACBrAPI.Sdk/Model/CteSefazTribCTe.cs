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
    /// Grupo de informações do IBS e CBS.
    /// </summary>
    [DataContract(Name = "CteSefazTribCTe")]
    public partial class CteSefazTribCTe : IEquatable<CteSefazTribCTe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazTribCTe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazTribCTe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazTribCTe" /> class.
        /// </summary>
        /// <param name="cST">Código Situação Tributária do IBS/CBS. (required).</param>
        /// <param name="cClassTrib">cClassTrib.</param>
        /// <param name="gIBSCBS">gIBSCBS.</param>
        public CteSefazTribCTe(string cST = default(string), string cClassTrib = default(string), CteSefazCIBS gIBSCBS = default(CteSefazCIBS))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for CteSefazTribCTe and cannot be null");
            }
            this.CST = cST;
            this.cClassTrib = cClassTrib;
            this.gIBSCBS = gIBSCBS;
        }

        /// <summary>
        /// Código Situação Tributária do IBS/CBS.
        /// </summary>
        /// <value>Código Situação Tributária do IBS/CBS.</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Gets or Sets cClassTrib
        /// </summary>
        [DataMember(Name = "cClassTrib", EmitDefaultValue = true)]
        public string cClassTrib { get; set; }

        /// <summary>
        /// Gets or Sets gIBSCBS
        /// </summary>
        [DataMember(Name = "gIBSCBS", EmitDefaultValue = false)]
        public CteSefazCIBS gIBSCBS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazTribCTe {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  cClassTrib: ").Append(cClassTrib).Append("\n");
            sb.Append("  gIBSCBS: ").Append(gIBSCBS).Append("\n");
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
            return this.Equals(input as CteSefazTribCTe);
        }

        /// <summary>
        /// Returns true if CteSefazTribCTe instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazTribCTe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazTribCTe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.cClassTrib == input.cClassTrib ||
                    (this.cClassTrib != null &&
                    this.cClassTrib.Equals(input.cClassTrib))
                ) && 
                (
                    this.gIBSCBS == input.gIBSCBS ||
                    (this.gIBSCBS != null &&
                    this.gIBSCBS.Equals(input.gIBSCBS))
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
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                if (this.cClassTrib != null)
                {
                    hashCode = (hashCode * 59) + this.cClassTrib.GetHashCode();
                }
                if (this.gIBSCBS != null)
                {
                    hashCode = (hashCode * 59) + this.gIBSCBS.GetHashCode();
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
            yield break;
        }
    }

}
