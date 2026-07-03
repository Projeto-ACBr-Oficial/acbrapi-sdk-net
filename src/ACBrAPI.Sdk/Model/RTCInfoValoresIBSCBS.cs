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
    /// Grupo de informações relativas aos valores do serviço prestado para IBS e CBS.
    /// </summary>
    [DataContract(Name = "RTCInfoValoresIBSCBS")]
    public partial class RTCInfoValoresIBSCBS : IEquatable<RTCInfoValoresIBSCBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoValoresIBSCBS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCInfoValoresIBSCBS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoValoresIBSCBS" /> class.
        /// </summary>
        /// <param name="gReeRepRes">gReeRepRes.</param>
        /// <param name="trib">trib (required).</param>
        public RTCInfoValoresIBSCBS(RTCInfoReeRepRes gReeRepRes = default(RTCInfoReeRepRes), RTCInfoTributosIBSCBS trib = default(RTCInfoTributosIBSCBS))
        {
            // to ensure "trib" is required (not null)
            if (trib == null)
            {
                throw new ArgumentNullException("trib is a required property for RTCInfoValoresIBSCBS and cannot be null");
            }
            this.trib = trib;
            this.gReeRepRes = gReeRepRes;
        }

        /// <summary>
        /// Gets or Sets gReeRepRes
        /// </summary>
        [DataMember(Name = "gReeRepRes", EmitDefaultValue = false)]
        public RTCInfoReeRepRes gReeRepRes { get; set; }

        /// <summary>
        /// Gets or Sets trib
        /// </summary>
        [DataMember(Name = "trib", IsRequired = true, EmitDefaultValue = true)]
        public RTCInfoTributosIBSCBS trib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCInfoValoresIBSCBS {\n");
            sb.Append("  gReeRepRes: ").Append(gReeRepRes).Append("\n");
            sb.Append("  trib: ").Append(trib).Append("\n");
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
            return this.Equals(input as RTCInfoValoresIBSCBS);
        }

        /// <summary>
        /// Returns true if RTCInfoValoresIBSCBS instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCInfoValoresIBSCBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCInfoValoresIBSCBS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.gReeRepRes == input.gReeRepRes ||
                    (this.gReeRepRes != null &&
                    this.gReeRepRes.Equals(input.gReeRepRes))
                ) && 
                (
                    this.trib == input.trib ||
                    (this.trib != null &&
                    this.trib.Equals(input.trib))
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
                if (this.gReeRepRes != null)
                {
                    hashCode = (hashCode * 59) + this.gReeRepRes.GetHashCode();
                }
                if (this.trib != null)
                {
                    hashCode = (hashCode * 59) + this.trib.GetHashCode();
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
