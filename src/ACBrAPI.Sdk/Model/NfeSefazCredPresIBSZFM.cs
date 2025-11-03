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
    /// Classificação de acordo com o art. 450, § 1º, da LC 214/25 para o cálculo do crédito presumido na ZFM.
    /// </summary>
    [DataContract(Name = "NfeSefazCredPresIBSZFM")]
    public partial class NfeSefazCredPresIBSZFM : IEquatable<NfeSefazCredPresIBSZFM>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCredPresIBSZFM" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazCredPresIBSZFM() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazCredPresIBSZFM" /> class.
        /// </summary>
        /// <param name="tpCredPresIBSZFM">Classificação de acordo com o art. 450, § 1º, da LC 214/25 para o cálculo do crédito presumido na ZFM.  * 0 - Sem crédito presumido  * 1 - Bens de consumo final (55%%)  * 2 - Bens de capital (75%%)  * 3 - Bens intermediários (90,25%%)  * 4 - Bens de informática e outros definidos em legislação (100%%)  OBS: Percentuais definidos no art. 450, § 1º, da LC 214/25 para o cálculo do crédito presumido. (required).</param>
        /// <param name="vCredPresIBSZFM">Valor do crédito presumido calculado sobre o saldo devedor apurado..</param>
        public NfeSefazCredPresIBSZFM(int? tpCredPresIBSZFM = default(int?), decimal? vCredPresIBSZFM = default(decimal?))
        {
            // to ensure "tpCredPresIBSZFM" is required (not null)
            if (tpCredPresIBSZFM == null)
            {
                throw new ArgumentNullException("tpCredPresIBSZFM is a required property for NfeSefazCredPresIBSZFM and cannot be null");
            }
            this.tpCredPresIBSZFM = tpCredPresIBSZFM;
            this.vCredPresIBSZFM = vCredPresIBSZFM;
        }

        /// <summary>
        /// Classificação de acordo com o art. 450, § 1º, da LC 214/25 para o cálculo do crédito presumido na ZFM.  * 0 - Sem crédito presumido  * 1 - Bens de consumo final (55%%)  * 2 - Bens de capital (75%%)  * 3 - Bens intermediários (90,25%%)  * 4 - Bens de informática e outros definidos em legislação (100%%)  OBS: Percentuais definidos no art. 450, § 1º, da LC 214/25 para o cálculo do crédito presumido.
        /// </summary>
        /// <value>Classificação de acordo com o art. 450, § 1º, da LC 214/25 para o cálculo do crédito presumido na ZFM.  * 0 - Sem crédito presumido  * 1 - Bens de consumo final (55%%)  * 2 - Bens de capital (75%%)  * 3 - Bens intermediários (90,25%%)  * 4 - Bens de informática e outros definidos em legislação (100%%)  OBS: Percentuais definidos no art. 450, § 1º, da LC 214/25 para o cálculo do crédito presumido.</value>
        [DataMember(Name = "tpCredPresIBSZFM", IsRequired = true, EmitDefaultValue = true)]
        public int? tpCredPresIBSZFM { get; set; }

        /// <summary>
        /// Valor do crédito presumido calculado sobre o saldo devedor apurado.
        /// </summary>
        /// <value>Valor do crédito presumido calculado sobre o saldo devedor apurado.</value>
        [DataMember(Name = "vCredPresIBSZFM", EmitDefaultValue = true)]
        public decimal? vCredPresIBSZFM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazCredPresIBSZFM {\n");
            sb.Append("  tpCredPresIBSZFM: ").Append(tpCredPresIBSZFM).Append("\n");
            sb.Append("  vCredPresIBSZFM: ").Append(vCredPresIBSZFM).Append("\n");
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
            return this.Equals(input as NfeSefazCredPresIBSZFM);
        }

        /// <summary>
        /// Returns true if NfeSefazCredPresIBSZFM instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazCredPresIBSZFM to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazCredPresIBSZFM input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpCredPresIBSZFM == input.tpCredPresIBSZFM ||
                    (this.tpCredPresIBSZFM != null &&
                    this.tpCredPresIBSZFM.Equals(input.tpCredPresIBSZFM))
                ) && 
                (
                    this.vCredPresIBSZFM == input.vCredPresIBSZFM ||
                    (this.vCredPresIBSZFM != null &&
                    this.vCredPresIBSZFM.Equals(input.vCredPresIBSZFM))
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
                if (this.tpCredPresIBSZFM != null)
                {
                    hashCode = (hashCode * 59) + this.tpCredPresIBSZFM.GetHashCode();
                }
                if (this.vCredPresIBSZFM != null)
                {
                    hashCode = (hashCode * 59) + this.vCredPresIBSZFM.GetHashCode();
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
            // vCredPresIBSZFM (decimal?) minimum
            if (this.vCredPresIBSZFM < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCredPresIBSZFM, must be a value greater than or equal to 0.", new [] { "vCredPresIBSZFM" });
            }

            yield break;
        }
    }

}
