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
    /// Grupo de informações relacionadas ao IBS e à CBS.
    /// </summary>
    [DataContract(Name = "RTCInfoTributosSitClas")]
    public partial class RTCInfoTributosSitClas : IEquatable<RTCInfoTributosSitClas>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosSitClas" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCInfoTributosSitClas() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosSitClas" /> class.
        /// </summary>
        /// <param name="cST">Código de Situação Tributária do IBS e da CBS. (required).</param>
        /// <param name="cClassTrib">Código de Classificação Tributária do IBS e da CBS. (required).</param>
        /// <param name="cCredPres">Código e Classificação do Crédito Presumido: IBS e CBS..</param>
        /// <param name="gTribRegular">gTribRegular.</param>
        /// <param name="gDif">gDif.</param>
        public RTCInfoTributosSitClas(string cST = default(string), string cClassTrib = default(string), string cCredPres = default(string), RTCInfoTributosTribRegular gTribRegular = default(RTCInfoTributosTribRegular), RTCInfoTributosDif gDif = default(RTCInfoTributosDif))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for RTCInfoTributosSitClas and cannot be null");
            }
            this.CST = cST;
            // to ensure "cClassTrib" is required (not null)
            if (cClassTrib == null)
            {
                throw new ArgumentNullException("cClassTrib is a required property for RTCInfoTributosSitClas and cannot be null");
            }
            this.cClassTrib = cClassTrib;
            this.cCredPres = cCredPres;
            this.gTribRegular = gTribRegular;
            this.gDif = gDif;
        }

        /// <summary>
        /// Código de Situação Tributária do IBS e da CBS.
        /// </summary>
        /// <value>Código de Situação Tributária do IBS e da CBS.</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Código de Classificação Tributária do IBS e da CBS.
        /// </summary>
        /// <value>Código de Classificação Tributária do IBS e da CBS.</value>
        [DataMember(Name = "cClassTrib", IsRequired = true, EmitDefaultValue = true)]
        public string cClassTrib { get; set; }

        /// <summary>
        /// Código e Classificação do Crédito Presumido: IBS e CBS.
        /// </summary>
        /// <value>Código e Classificação do Crédito Presumido: IBS e CBS.</value>
        [DataMember(Name = "cCredPres", EmitDefaultValue = true)]
        public string cCredPres { get; set; }

        /// <summary>
        /// Gets or Sets gTribRegular
        /// </summary>
        [DataMember(Name = "gTribRegular", EmitDefaultValue = false)]
        public RTCInfoTributosTribRegular gTribRegular { get; set; }

        /// <summary>
        /// Gets or Sets gDif
        /// </summary>
        [DataMember(Name = "gDif", EmitDefaultValue = false)]
        public RTCInfoTributosDif gDif { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCInfoTributosSitClas {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  cClassTrib: ").Append(cClassTrib).Append("\n");
            sb.Append("  cCredPres: ").Append(cCredPres).Append("\n");
            sb.Append("  gTribRegular: ").Append(gTribRegular).Append("\n");
            sb.Append("  gDif: ").Append(gDif).Append("\n");
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
            return this.Equals(input as RTCInfoTributosSitClas);
        }

        /// <summary>
        /// Returns true if RTCInfoTributosSitClas instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCInfoTributosSitClas to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCInfoTributosSitClas input)
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
                    this.cCredPres == input.cCredPres ||
                    (this.cCredPres != null &&
                    this.cCredPres.Equals(input.cCredPres))
                ) && 
                (
                    this.gTribRegular == input.gTribRegular ||
                    (this.gTribRegular != null &&
                    this.gTribRegular.Equals(input.gTribRegular))
                ) && 
                (
                    this.gDif == input.gDif ||
                    (this.gDif != null &&
                    this.gDif.Equals(input.gDif))
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
                if (this.cCredPres != null)
                {
                    hashCode = (hashCode * 59) + this.cCredPres.GetHashCode();
                }
                if (this.gTribRegular != null)
                {
                    hashCode = (hashCode * 59) + this.gTribRegular.GetHashCode();
                }
                if (this.gDif != null)
                {
                    hashCode = (hashCode * 59) + this.gDif.GetHashCode();
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
