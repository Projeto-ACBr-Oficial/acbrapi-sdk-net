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
    /// Chave Publica no padrão XML RSA Key.
    /// </summary>
    [DataContract(Name = "NfeSefazRSAKeyValueType")]
    public partial class NfeSefazRSAKeyValueType : IEquatable<NfeSefazRSAKeyValueType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazRSAKeyValueType" /> class.
        /// </summary>
        /// <param name="modulus">modulus.</param>
        /// <param name="exponent">exponent.</param>
        public NfeSefazRSAKeyValueType(byte[] modulus = default(byte[]), byte[] exponent = default(byte[]))
        {
            this.Modulus = modulus;
            this.Exponent = exponent;
        }

        /// <summary>
        /// Gets or Sets Modulus
        /// </summary>
        [DataMember(Name = "Modulus", EmitDefaultValue = true)]
        public byte[] Modulus { get; set; }

        /// <summary>
        /// Gets or Sets Exponent
        /// </summary>
        [DataMember(Name = "Exponent", EmitDefaultValue = true)]
        public byte[] Exponent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazRSAKeyValueType {\n");
            sb.Append("  Modulus: ").Append(Modulus).Append("\n");
            sb.Append("  Exponent: ").Append(Exponent).Append("\n");
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
            return this.Equals(input as NfeSefazRSAKeyValueType);
        }

        /// <summary>
        /// Returns true if NfeSefazRSAKeyValueType instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazRSAKeyValueType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazRSAKeyValueType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Modulus == input.Modulus ||
                    (this.Modulus != null &&
                    this.Modulus.Equals(input.Modulus))
                ) && 
                (
                    this.Exponent == input.Exponent ||
                    (this.Exponent != null &&
                    this.Exponent.Equals(input.Exponent))
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
                if (this.Modulus != null)
                {
                    hashCode = (hashCode * 59) + this.Modulus.GetHashCode();
                }
                if (this.Exponent != null)
                {
                    hashCode = (hashCode * 59) + this.Exponent.GetHashCode();
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
