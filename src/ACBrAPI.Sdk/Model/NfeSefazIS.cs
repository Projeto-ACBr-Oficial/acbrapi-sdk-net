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
    /// Grupo de informações do Imposto Seletivo.
    /// </summary>
    [DataContract(Name = "NfeSefazIS")]
    public partial class NfeSefazIS : IEquatable<NfeSefazIS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazIS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazIS" /> class.
        /// </summary>
        /// <param name="cSTIS">Código Situação Tributária do Imposto Seletivo. (required).</param>
        /// <param name="cClassTribIS">cClassTribIS.</param>
        /// <param name="vBCIS">Valor do BC..</param>
        /// <param name="pIS">Alíquota do Imposto Seletivo (percentual)..</param>
        /// <param name="pISEspec">Alíquota do Imposto Seletivo (por valor)..</param>
        /// <param name="uTrib">Unidade de medida apropriada especificada em Lei Ordinaria para fins de apuração do Imposto Seletivo..</param>
        /// <param name="qTrib">Quantidade com abse no campo uTrib informado..</param>
        /// <param name="vIS">Valor do Imposto Seletivo calculado..</param>
        public NfeSefazIS(string cSTIS = default(string), string cClassTribIS = default(string), decimal? vBCIS = default(decimal?), decimal? pIS = default(decimal?), decimal? pISEspec = default(decimal?), string uTrib = default(string), decimal? qTrib = default(decimal?), decimal? vIS = default(decimal?))
        {
            // to ensure "cSTIS" is required (not null)
            if (cSTIS == null)
            {
                throw new ArgumentNullException("cSTIS is a required property for NfeSefazIS and cannot be null");
            }
            this.CSTIS = cSTIS;
            this.cClassTribIS = cClassTribIS;
            this.vBCIS = vBCIS;
            this.pIS = pIS;
            this.pISEspec = pISEspec;
            this.uTrib = uTrib;
            this.qTrib = qTrib;
            this.vIS = vIS;
        }

        /// <summary>
        /// Código Situação Tributária do Imposto Seletivo.
        /// </summary>
        /// <value>Código Situação Tributária do Imposto Seletivo.</value>
        [DataMember(Name = "CSTIS", IsRequired = true, EmitDefaultValue = true)]
        public string CSTIS { get; set; }

        /// <summary>
        /// Gets or Sets cClassTribIS
        /// </summary>
        [DataMember(Name = "cClassTribIS", EmitDefaultValue = true)]
        public string cClassTribIS { get; set; }

        /// <summary>
        /// Valor do BC.
        /// </summary>
        /// <value>Valor do BC.</value>
        [DataMember(Name = "vBCIS", EmitDefaultValue = true)]
        public decimal? vBCIS { get; set; }

        /// <summary>
        /// Alíquota do Imposto Seletivo (percentual).
        /// </summary>
        /// <value>Alíquota do Imposto Seletivo (percentual).</value>
        [DataMember(Name = "pIS", EmitDefaultValue = true)]
        public decimal? pIS { get; set; }

        /// <summary>
        /// Alíquota do Imposto Seletivo (por valor).
        /// </summary>
        /// <value>Alíquota do Imposto Seletivo (por valor).</value>
        [DataMember(Name = "pISEspec", EmitDefaultValue = true)]
        public decimal? pISEspec { get; set; }

        /// <summary>
        /// Unidade de medida apropriada especificada em Lei Ordinaria para fins de apuração do Imposto Seletivo.
        /// </summary>
        /// <value>Unidade de medida apropriada especificada em Lei Ordinaria para fins de apuração do Imposto Seletivo.</value>
        [DataMember(Name = "uTrib", EmitDefaultValue = true)]
        public string uTrib { get; set; }

        /// <summary>
        /// Quantidade com abse no campo uTrib informado.
        /// </summary>
        /// <value>Quantidade com abse no campo uTrib informado.</value>
        [DataMember(Name = "qTrib", EmitDefaultValue = true)]
        public decimal? qTrib { get; set; }

        /// <summary>
        /// Valor do Imposto Seletivo calculado.
        /// </summary>
        /// <value>Valor do Imposto Seletivo calculado.</value>
        [DataMember(Name = "vIS", EmitDefaultValue = true)]
        public decimal? vIS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazIS {\n");
            sb.Append("  CSTIS: ").Append(CSTIS).Append("\n");
            sb.Append("  cClassTribIS: ").Append(cClassTribIS).Append("\n");
            sb.Append("  vBCIS: ").Append(vBCIS).Append("\n");
            sb.Append("  pIS: ").Append(pIS).Append("\n");
            sb.Append("  pISEspec: ").Append(pISEspec).Append("\n");
            sb.Append("  uTrib: ").Append(uTrib).Append("\n");
            sb.Append("  qTrib: ").Append(qTrib).Append("\n");
            sb.Append("  vIS: ").Append(vIS).Append("\n");
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
            return this.Equals(input as NfeSefazIS);
        }

        /// <summary>
        /// Returns true if NfeSefazIS instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazIS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazIS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CSTIS == input.CSTIS ||
                    (this.CSTIS != null &&
                    this.CSTIS.Equals(input.CSTIS))
                ) && 
                (
                    this.cClassTribIS == input.cClassTribIS ||
                    (this.cClassTribIS != null &&
                    this.cClassTribIS.Equals(input.cClassTribIS))
                ) && 
                (
                    this.vBCIS == input.vBCIS ||
                    (this.vBCIS != null &&
                    this.vBCIS.Equals(input.vBCIS))
                ) && 
                (
                    this.pIS == input.pIS ||
                    (this.pIS != null &&
                    this.pIS.Equals(input.pIS))
                ) && 
                (
                    this.pISEspec == input.pISEspec ||
                    (this.pISEspec != null &&
                    this.pISEspec.Equals(input.pISEspec))
                ) && 
                (
                    this.uTrib == input.uTrib ||
                    (this.uTrib != null &&
                    this.uTrib.Equals(input.uTrib))
                ) && 
                (
                    this.qTrib == input.qTrib ||
                    (this.qTrib != null &&
                    this.qTrib.Equals(input.qTrib))
                ) && 
                (
                    this.vIS == input.vIS ||
                    (this.vIS != null &&
                    this.vIS.Equals(input.vIS))
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
                if (this.CSTIS != null)
                {
                    hashCode = (hashCode * 59) + this.CSTIS.GetHashCode();
                }
                if (this.cClassTribIS != null)
                {
                    hashCode = (hashCode * 59) + this.cClassTribIS.GetHashCode();
                }
                if (this.vBCIS != null)
                {
                    hashCode = (hashCode * 59) + this.vBCIS.GetHashCode();
                }
                if (this.pIS != null)
                {
                    hashCode = (hashCode * 59) + this.pIS.GetHashCode();
                }
                if (this.pISEspec != null)
                {
                    hashCode = (hashCode * 59) + this.pISEspec.GetHashCode();
                }
                if (this.uTrib != null)
                {
                    hashCode = (hashCode * 59) + this.uTrib.GetHashCode();
                }
                if (this.qTrib != null)
                {
                    hashCode = (hashCode * 59) + this.qTrib.GetHashCode();
                }
                if (this.vIS != null)
                {
                    hashCode = (hashCode * 59) + this.vIS.GetHashCode();
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
            // vBCIS (decimal?) minimum
            if (this.vBCIS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vBCIS, must be a value greater than or equal to 0.", new [] { "vBCIS" });
            }

            // pIS (decimal?) minimum
            if (this.pIS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pIS, must be a value greater than or equal to 0.", new [] { "pIS" });
            }

            // pISEspec (decimal?) minimum
            if (this.pISEspec < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pISEspec, must be a value greater than or equal to 0.", new [] { "pISEspec" });
            }

            // uTrib (string) maxLength
            if (this.uTrib != null && this.uTrib.Length > 6)
            {
                yield return new ValidationResult("Invalid value for uTrib, length must be less than 6.", new [] { "uTrib" });
            }

            // uTrib (string) minLength
            if (this.uTrib != null && this.uTrib.Length < 1)
            {
                yield return new ValidationResult("Invalid value for uTrib, length must be greater than 1.", new [] { "uTrib" });
            }

            // qTrib (decimal?) minimum
            if (this.qTrib < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for qTrib, must be a value greater than or equal to 0.", new [] { "qTrib" });
            }

            // vIS (decimal?) minimum
            if (this.vIS < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vIS, must be a value greater than or equal to 0.", new [] { "vIS" });
            }

            yield break;
        }
    }

}
