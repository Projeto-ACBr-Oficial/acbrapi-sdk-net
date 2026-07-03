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
    /// Grupo de informações relativas a valores incluídos neste documento e recebidos por motivo de estarem relacionadas  a operações de terceiros, objeto de reembolso, repasse ou ressarcimento pelo recebedor, já tributados e aqui referenciados.
    /// </summary>
    [DataContract(Name = "RTCInfoReeRepRes")]
    public partial class RTCInfoReeRepRes : IEquatable<RTCInfoReeRepRes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoReeRepRes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCInfoReeRepRes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoReeRepRes" /> class.
        /// </summary>
        /// <param name="documentos">documentos (required).</param>
        public RTCInfoReeRepRes(List<RTCListaDoc> documentos = default(List<RTCListaDoc>))
        {
            // to ensure "documentos" is required (not null)
            if (documentos == null)
            {
                throw new ArgumentNullException("documentos is a required property for RTCInfoReeRepRes and cannot be null");
            }
            this.documentos = documentos;
        }

        /// <summary>
        /// Gets or Sets documentos
        /// </summary>
        [DataMember(Name = "documentos", IsRequired = true, EmitDefaultValue = true)]
        public List<RTCListaDoc> documentos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCInfoReeRepRes {\n");
            sb.Append("  documentos: ").Append(documentos).Append("\n");
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
            return this.Equals(input as RTCInfoReeRepRes);
        }

        /// <summary>
        /// Returns true if RTCInfoReeRepRes instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCInfoReeRepRes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCInfoReeRepRes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.documentos == input.documentos ||
                    this.documentos != null &&
                    input.documentos != null &&
                    this.documentos.SequenceEqual(input.documentos)
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
                if (this.documentos != null)
                {
                    hashCode = (hashCode * 59) + this.documentos.GetHashCode();
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
