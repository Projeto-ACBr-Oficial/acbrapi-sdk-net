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
    /// Grupo de informações da vínculação com a transação de pagamento.
    /// </summary>
    [DataContract(Name = "CteOsSefazPgtoVincOS")]
    public partial class CteOsSefazPgtoVincOS : IEquatable<CteOsSefazPgtoVincOS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazPgtoVincOS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteOsSefazPgtoVincOS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteOsSefazPgtoVincOS" /> class.
        /// </summary>
        /// <param name="pgto">pgto (required).</param>
        public CteOsSefazPgtoVincOS(List<CteOsSefazPagamentoRTCOS> pgto = default(List<CteOsSefazPagamentoRTCOS>))
        {
            // to ensure "pgto" is required (not null)
            if (pgto == null)
            {
                throw new ArgumentNullException("pgto is a required property for CteOsSefazPgtoVincOS and cannot be null");
            }
            this.pgto = pgto;
        }

        /// <summary>
        /// Gets or Sets pgto
        /// </summary>
        [DataMember(Name = "pgto", IsRequired = true, EmitDefaultValue = true)]
        public List<CteOsSefazPagamentoRTCOS> pgto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteOsSefazPgtoVincOS {\n");
            sb.Append("  pgto: ").Append(pgto).Append("\n");
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
            return this.Equals(input as CteOsSefazPgtoVincOS);
        }

        /// <summary>
        /// Returns true if CteOsSefazPgtoVincOS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteOsSefazPgtoVincOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteOsSefazPgtoVincOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pgto == input.pgto ||
                    this.pgto != null &&
                    input.pgto != null &&
                    this.pgto.SequenceEqual(input.pgto)
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
                if (this.pgto != null)
                {
                    hashCode = (hashCode * 59) + this.pgto.GetHashCode();
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
