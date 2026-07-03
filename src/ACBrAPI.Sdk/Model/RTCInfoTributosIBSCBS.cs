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
    /// Grupo de informações relacionados aos tributos IBS e CBS.
    /// </summary>
    [DataContract(Name = "RTCInfoTributosIBSCBS")]
    public partial class RTCInfoTributosIBSCBS : IEquatable<RTCInfoTributosIBSCBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosIBSCBS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCInfoTributosIBSCBS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosIBSCBS" /> class.
        /// </summary>
        /// <param name="gIBSCBS">gIBSCBS (required).</param>
        public RTCInfoTributosIBSCBS(RTCInfoTributosSitClas gIBSCBS = default(RTCInfoTributosSitClas))
        {
            // to ensure "gIBSCBS" is required (not null)
            if (gIBSCBS == null)
            {
                throw new ArgumentNullException("gIBSCBS is a required property for RTCInfoTributosIBSCBS and cannot be null");
            }
            this.gIBSCBS = gIBSCBS;
        }

        /// <summary>
        /// Gets or Sets gIBSCBS
        /// </summary>
        [DataMember(Name = "gIBSCBS", IsRequired = true, EmitDefaultValue = true)]
        public RTCInfoTributosSitClas gIBSCBS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCInfoTributosIBSCBS {\n");
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
            return this.Equals(input as RTCInfoTributosIBSCBS);
        }

        /// <summary>
        /// Returns true if RTCInfoTributosIBSCBS instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCInfoTributosIBSCBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCInfoTributosIBSCBS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
