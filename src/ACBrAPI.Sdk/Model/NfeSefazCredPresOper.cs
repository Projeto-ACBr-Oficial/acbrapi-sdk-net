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
    /// Crédito Presumido da Operação. Informado conforme indicador no cClassTrib.
    /// </summary>
    [DataContract(Name = "NfeSefazCredPresOper")]
    public partial class NfeSefazCredPresOper : IEquatable<NfeSefazCredPresOper>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCredPresOper" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazCredPresOper() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCredPresOper" /> class.
        /// </summary>
        /// <param name="vBCCredPres">Valor da Base de Cálculo do Crédito Presumido da Operação. (required).</param>
        /// <param name="cCredPres">Código de Classificação do Crédito Presumido do IBS e da CBS. (required).</param>
        /// <param name="gIBSCredPres">gIBSCredPres.</param>
        /// <param name="gCBSCredPres">gCBSCredPres.</param>
        public NfeSefazCredPresOper(decimal? vBCCredPres = default(decimal?), string cCredPres = default(string), NfeSefazCredPres gIBSCredPres = default(NfeSefazCredPres), NfeSefazCredPres gCBSCredPres = default(NfeSefazCredPres))
        {
            // to ensure "vBCCredPres" is required (not null)
            if (vBCCredPres == null)
            {
                throw new ArgumentNullException("vBCCredPres is a required property for NfeSefazCredPresOper and cannot be null");
            }
            this.vBCCredPres = vBCCredPres;
            // to ensure "cCredPres" is required (not null)
            if (cCredPres == null)
            {
                throw new ArgumentNullException("cCredPres is a required property for NfeSefazCredPresOper and cannot be null");
            }
            this.cCredPres = cCredPres;
            this.gIBSCredPres = gIBSCredPres;
            this.gCBSCredPres = gCBSCredPres;
        }

        /// <summary>
        /// Valor da Base de Cálculo do Crédito Presumido da Operação.
        /// </summary>
        /// <value>Valor da Base de Cálculo do Crédito Presumido da Operação.</value>
        [DataMember(Name = "vBCCredPres", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vBCCredPres { get; set; }

        /// <summary>
        /// Código de Classificação do Crédito Presumido do IBS e da CBS.
        /// </summary>
        /// <value>Código de Classificação do Crédito Presumido do IBS e da CBS.</value>
        [DataMember(Name = "cCredPres", IsRequired = true, EmitDefaultValue = true)]
        public string cCredPres { get; set; }

        /// <summary>
        /// Gets or Sets gIBSCredPres
        /// </summary>
        [DataMember(Name = "gIBSCredPres", EmitDefaultValue = false)]
        public NfeSefazCredPres gIBSCredPres { get; set; }

        /// <summary>
        /// Gets or Sets gCBSCredPres
        /// </summary>
        [DataMember(Name = "gCBSCredPres", EmitDefaultValue = false)]
        public NfeSefazCredPres gCBSCredPres { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCredPresOper {\n");
            sb.Append("  vBCCredPres: ").Append(vBCCredPres).Append("\n");
            sb.Append("  cCredPres: ").Append(cCredPres).Append("\n");
            sb.Append("  gIBSCredPres: ").Append(gIBSCredPres).Append("\n");
            sb.Append("  gCBSCredPres: ").Append(gCBSCredPres).Append("\n");
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
            return this.Equals(input as NfeSefazCredPresOper);
        }

        /// <summary>
        /// Returns true if NfeSefazCredPresOper instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCredPresOper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCredPresOper input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBCCredPres == input.vBCCredPres ||
                    (this.vBCCredPres != null &&
                    this.vBCCredPres.Equals(input.vBCCredPres))
                ) && 
                (
                    this.cCredPres == input.cCredPres ||
                    (this.cCredPres != null &&
                    this.cCredPres.Equals(input.cCredPres))
                ) && 
                (
                    this.gIBSCredPres == input.gIBSCredPres ||
                    (this.gIBSCredPres != null &&
                    this.gIBSCredPres.Equals(input.gIBSCredPres))
                ) && 
                (
                    this.gCBSCredPres == input.gCBSCredPres ||
                    (this.gCBSCredPres != null &&
                    this.gCBSCredPres.Equals(input.gCBSCredPres))
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
                if (this.vBCCredPres != null)
                {
                    hashCode = (hashCode * 59) + this.vBCCredPres.GetHashCode();
                }
                if (this.cCredPres != null)
                {
                    hashCode = (hashCode * 59) + this.cCredPres.GetHashCode();
                }
                if (this.gIBSCredPres != null)
                {
                    hashCode = (hashCode * 59) + this.gIBSCredPres.GetHashCode();
                }
                if (this.gCBSCredPres != null)
                {
                    hashCode = (hashCode * 59) + this.gCBSCredPres.GetHashCode();
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
            // vBCCredPres (decimal?) minimum
            if (this.vBCCredPres < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBCCredPres, must be a value greater than or equal to 0.", new [] { "vBCCredPres" });
            }

            yield break;
        }
    }

}
