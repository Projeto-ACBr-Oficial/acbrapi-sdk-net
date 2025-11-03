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
    /// Grupo de informações dos tributos IBS, CBS e Imposto Seletivo.
    /// </summary>
    [DataContract(Name = "NfeSefazTribNFe")]
    public partial class NfeSefazTribNFe : IEquatable<NfeSefazTribNFe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazTribNFe" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazTribNFe() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazTribNFe" /> class.
        /// </summary>
        /// <param name="cST">Código Situação Tributária do IBS/CBS. (required).</param>
        /// <param name="cClassTrib">cClassTrib.</param>
        /// <param name="gIBSCBS">gIBSCBS.</param>
        /// <param name="gIBSCBSMono">gIBSCBSMono.</param>
        /// <param name="gTransfCred">gTransfCred.</param>
        /// <param name="gCredPresIBSZFM">gCredPresIBSZFM.</param>
        public NfeSefazTribNFe(string cST = default(string), string cClassTrib = default(string), NfeSefazCIBS gIBSCBS = default(NfeSefazCIBS), NfeSefazMonofasia gIBSCBSMono = default(NfeSefazMonofasia), NfeSefazTransfCred gTransfCred = default(NfeSefazTransfCred), NfeSefazCredPresIBSZFM gCredPresIBSZFM = default(NfeSefazCredPresIBSZFM))
        {
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazTribNFe and cannot be null");
            }
            this.CST = cST;
            this.cClassTrib = cClassTrib;
            this.gIBSCBS = gIBSCBS;
            this.gIBSCBSMono = gIBSCBSMono;
            this.gTransfCred = gTransfCred;
            this.gCredPresIBSZFM = gCredPresIBSZFM;
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
        public NfeSefazCIBS gIBSCBS { get; set; }

        /// <summary>
        /// Gets or Sets gIBSCBSMono
        /// </summary>
        [DataMember(Name = "gIBSCBSMono", EmitDefaultValue = false)]
        public NfeSefazMonofasia gIBSCBSMono { get; set; }

        /// <summary>
        /// Gets or Sets gTransfCred
        /// </summary>
        [DataMember(Name = "gTransfCred", EmitDefaultValue = false)]
        public NfeSefazTransfCred gTransfCred { get; set; }

        /// <summary>
        /// Gets or Sets gCredPresIBSZFM
        /// </summary>
        [DataMember(Name = "gCredPresIBSZFM", EmitDefaultValue = false)]
        public NfeSefazCredPresIBSZFM gCredPresIBSZFM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazTribNFe {\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  cClassTrib: ").Append(cClassTrib).Append("\n");
            sb.Append("  gIBSCBS: ").Append(gIBSCBS).Append("\n");
            sb.Append("  gIBSCBSMono: ").Append(gIBSCBSMono).Append("\n");
            sb.Append("  gTransfCred: ").Append(gTransfCred).Append("\n");
            sb.Append("  gCredPresIBSZFM: ").Append(gCredPresIBSZFM).Append("\n");
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
            return this.Equals(input as NfeSefazTribNFe);
        }

        /// <summary>
        /// Returns true if NfeSefazTribNFe instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazTribNFe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazTribNFe input)
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
                ) && 
                (
                    this.gIBSCBSMono == input.gIBSCBSMono ||
                    (this.gIBSCBSMono != null &&
                    this.gIBSCBSMono.Equals(input.gIBSCBSMono))
                ) && 
                (
                    this.gTransfCred == input.gTransfCred ||
                    (this.gTransfCred != null &&
                    this.gTransfCred.Equals(input.gTransfCred))
                ) && 
                (
                    this.gCredPresIBSZFM == input.gCredPresIBSZFM ||
                    (this.gCredPresIBSZFM != null &&
                    this.gCredPresIBSZFM.Equals(input.gCredPresIBSZFM))
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
                if (this.gIBSCBSMono != null)
                {
                    hashCode = (hashCode * 59) + this.gIBSCBSMono.GetHashCode();
                }
                if (this.gTransfCred != null)
                {
                    hashCode = (hashCode * 59) + this.gTransfCred.GetHashCode();
                }
                if (this.gCredPresIBSZFM != null)
                {
                    hashCode = (hashCode * 59) + this.gCredPresIBSZFM.GetHashCode();
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
