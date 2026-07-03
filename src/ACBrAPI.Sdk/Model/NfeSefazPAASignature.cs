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
    /// Assinatura RSA do Emitente para DFe gerados por PAA.
    /// </summary>
    [DataContract(Name = "NfeSefazPAASignature")]
    public partial class NfeSefazPAASignature : IEquatable<NfeSefazPAASignature>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazPAASignature" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazPAASignature() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazPAASignature" /> class.
        /// </summary>
        /// <param name="signatureValue">Assinatura digital padrão RSA.  Converter o atributo Id do DFe para array de bytes e assinar com a chave privada do RSA com algoritmo SHA1 gerando um valor no formato base64. (required).</param>
        /// <param name="rSAKeyValue">rSAKeyValue (required).</param>
        public NfeSefazPAASignature(byte[] signatureValue = default(byte[]), NfeSefazRSAKeyValueType rSAKeyValue = default(NfeSefazRSAKeyValueType))
        {
            // to ensure "signatureValue" is required (not null)
            if (signatureValue == null)
            {
                throw new ArgumentNullException("signatureValue is a required property for NfeSefazPAASignature and cannot be null");
            }
            this.SignatureValue = signatureValue;
            // to ensure "rSAKeyValue" is required (not null)
            if (rSAKeyValue == null)
            {
                throw new ArgumentNullException("rSAKeyValue is a required property for NfeSefazPAASignature and cannot be null");
            }
            this.RSAKeyValue = rSAKeyValue;
        }

        /// <summary>
        /// Assinatura digital padrão RSA.  Converter o atributo Id do DFe para array de bytes e assinar com a chave privada do RSA com algoritmo SHA1 gerando um valor no formato base64.
        /// </summary>
        /// <value>Assinatura digital padrão RSA.  Converter o atributo Id do DFe para array de bytes e assinar com a chave privada do RSA com algoritmo SHA1 gerando um valor no formato base64.</value>
        [DataMember(Name = "SignatureValue", IsRequired = true, EmitDefaultValue = true)]
        public byte[] SignatureValue { get; set; }

        /// <summary>
        /// Gets or Sets RSAKeyValue
        /// </summary>
        [DataMember(Name = "RSAKeyValue", IsRequired = true, EmitDefaultValue = true)]
        public NfeSefazRSAKeyValueType RSAKeyValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazPAASignature {\n");
            sb.Append("  SignatureValue: ").Append(SignatureValue).Append("\n");
            sb.Append("  RSAKeyValue: ").Append(RSAKeyValue).Append("\n");
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
            return this.Equals(input as NfeSefazPAASignature);
        }

        /// <summary>
        /// Returns true if NfeSefazPAASignature instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazPAASignature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazPAASignature input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignatureValue == input.SignatureValue ||
                    (this.SignatureValue != null &&
                    this.SignatureValue.Equals(input.SignatureValue))
                ) && 
                (
                    this.RSAKeyValue == input.RSAKeyValue ||
                    (this.RSAKeyValue != null &&
                    this.RSAKeyValue.Equals(input.RSAKeyValue))
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
                if (this.SignatureValue != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureValue.GetHashCode();
                }
                if (this.RSAKeyValue != null)
                {
                    hashCode = (hashCode * 59) + this.RSAKeyValue.GetHashCode();
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
