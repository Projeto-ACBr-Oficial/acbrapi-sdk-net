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
    /// Grupo de NFS-e referenciadas.
    /// </summary>
    [DataContract(Name = "InfoRefNFSe")]
    public partial class InfoRefNFSe : IEquatable<InfoRefNFSe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoRefNFSe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoRefNFSe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoRefNFSe" /> class.
        /// </summary>
        /// <param name="refNFSe">Chave da NFS-e referenciada. (required).</param>
        public InfoRefNFSe(List<string> refNFSe = default(List<string>))
        {
            // to ensure "refNFSe" is required (not null)
            if (refNFSe == null)
            {
                throw new ArgumentNullException("refNFSe is a required property for InfoRefNFSe and cannot be null");
            }
            this.refNFSe = refNFSe;
        }

        /// <summary>
        /// Chave da NFS-e referenciada.
        /// </summary>
        /// <value>Chave da NFS-e referenciada.</value>
        [DataMember(Name = "refNFSe", IsRequired = true, EmitDefaultValue = true)]
        public List<string> refNFSe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoRefNFSe {\n");
            sb.Append("  refNFSe: ").Append(refNFSe).Append("\n");
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
            return this.Equals(input as InfoRefNFSe);
        }

        /// <summary>
        /// Returns true if InfoRefNFSe instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoRefNFSe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoRefNFSe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.refNFSe == input.refNFSe ||
                    this.refNFSe != null &&
                    input.refNFSe != null &&
                    this.refNFSe.SequenceEqual(input.refNFSe)
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
                if (this.refNFSe != null)
                {
                    hashCode = (hashCode * 59) + this.refNFSe.GetHashCode();
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
