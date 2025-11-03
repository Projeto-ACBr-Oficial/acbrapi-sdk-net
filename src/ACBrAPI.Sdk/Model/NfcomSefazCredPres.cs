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
    /// Grupo de Informações do Crédito Presumido referente ao IBS, quando aproveitado pelo emitente do documento.
    /// </summary>
    [DataContract(Name = "NfcomSefazCredPres")]
    public partial class NfcomSefazCredPres : IEquatable<NfcomSefazCredPres>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazCredPres" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfcomSefazCredPres() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcomSefazCredPres" /> class.
        /// </summary>
        /// <param name="cCredPres">Usar tabela Cred Presumido, para o emitente da nota. (required).</param>
        /// <param name="pCredPres">Percentual do Crédito Presumido. (required).</param>
        /// <param name="vCredPres">Valor do Crédito Presumido..</param>
        /// <param name="vCredPresCondSus">Valor do Crédito Presumido Condição Suspensiva, preencher apenas para cCredPres que possui indicação de Condição Suspensiva..</param>
        public NfcomSefazCredPres(string cCredPres = default(string), decimal? pCredPres = default(decimal?), decimal? vCredPres = default(decimal?), decimal? vCredPresCondSus = default(decimal?))
        {
            // to ensure "cCredPres" is required (not null)
            if (cCredPres == null)
            {
                throw new ArgumentNullException("cCredPres is a required property for NfcomSefazCredPres and cannot be null");
            }
            this.cCredPres = cCredPres;
            // to ensure "pCredPres" is required (not null)
            if (pCredPres == null)
            {
                throw new ArgumentNullException("pCredPres is a required property for NfcomSefazCredPres and cannot be null");
            }
            this.pCredPres = pCredPres;
            this.vCredPres = vCredPres;
            this.vCredPresCondSus = vCredPresCondSus;
        }

        /// <summary>
        /// Usar tabela Cred Presumido, para o emitente da nota.
        /// </summary>
        /// <value>Usar tabela Cred Presumido, para o emitente da nota.</value>
        [DataMember(Name = "cCredPres", IsRequired = true, EmitDefaultValue = true)]
        public string cCredPres { get; set; }

        /// <summary>
        /// Percentual do Crédito Presumido.
        /// </summary>
        /// <value>Percentual do Crédito Presumido.</value>
        [DataMember(Name = "pCredPres", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pCredPres { get; set; }

        /// <summary>
        /// Valor do Crédito Presumido.
        /// </summary>
        /// <value>Valor do Crédito Presumido.</value>
        [DataMember(Name = "vCredPres", EmitDefaultValue = true)]
        public decimal? vCredPres { get; set; }

        /// <summary>
        /// Valor do Crédito Presumido Condição Suspensiva, preencher apenas para cCredPres que possui indicação de Condição Suspensiva.
        /// </summary>
        /// <value>Valor do Crédito Presumido Condição Suspensiva, preencher apenas para cCredPres que possui indicação de Condição Suspensiva.</value>
        [DataMember(Name = "vCredPresCondSus", EmitDefaultValue = true)]
        public decimal? vCredPresCondSus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcomSefazCredPres {\n");
            sb.Append("  cCredPres: ").Append(cCredPres).Append("\n");
            sb.Append("  pCredPres: ").Append(pCredPres).Append("\n");
            sb.Append("  vCredPres: ").Append(vCredPres).Append("\n");
            sb.Append("  vCredPresCondSus: ").Append(vCredPresCondSus).Append("\n");
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
            return this.Equals(input as NfcomSefazCredPres);
        }

        /// <summary>
        /// Returns true if NfcomSefazCredPres instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcomSefazCredPres to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcomSefazCredPres input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cCredPres == input.cCredPres ||
                    (this.cCredPres != null &&
                    this.cCredPres.Equals(input.cCredPres))
                ) && 
                (
                    this.pCredPres == input.pCredPres ||
                    (this.pCredPres != null &&
                    this.pCredPres.Equals(input.pCredPres))
                ) && 
                (
                    this.vCredPres == input.vCredPres ||
                    (this.vCredPres != null &&
                    this.vCredPres.Equals(input.vCredPres))
                ) && 
                (
                    this.vCredPresCondSus == input.vCredPresCondSus ||
                    (this.vCredPresCondSus != null &&
                    this.vCredPresCondSus.Equals(input.vCredPresCondSus))
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
                if (this.cCredPres != null)
                {
                    hashCode = (hashCode * 59) + this.cCredPres.GetHashCode();
                }
                if (this.pCredPres != null)
                {
                    hashCode = (hashCode * 59) + this.pCredPres.GetHashCode();
                }
                if (this.vCredPres != null)
                {
                    hashCode = (hashCode * 59) + this.vCredPres.GetHashCode();
                }
                if (this.vCredPresCondSus != null)
                {
                    hashCode = (hashCode * 59) + this.vCredPresCondSus.GetHashCode();
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
            // pCredPres (decimal?) minimum
            if (this.pCredPres < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pCredPres, must be a value greater than or equal to 0.", new [] { "pCredPres" });
            }

            // vCredPres (decimal?) minimum
            if (this.vCredPres < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCredPres, must be a value greater than or equal to 0.", new [] { "vCredPres" });
            }

            // vCredPresCondSus (decimal?) minimum
            if (this.vCredPresCondSus < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vCredPresCondSus, must be a value greater than or equal to 0.", new [] { "vCredPresCondSus" });
            }

            yield break;
        }
    }

}
