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
    /// Informações do modal Dutoviário.
    /// </summary>
    [DataContract(Name = "CteSimpSefazDutoSimp")]
    public partial class CteSimpSefazDutoSimp : IEquatable<CteSimpSefazDutoSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazDutoSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazDutoSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazDutoSimp" /> class.
        /// </summary>
        /// <param name="vTar">Valor da tarifa..</param>
        /// <param name="dIni">Data de Início da prestação do serviço. (required).</param>
        /// <param name="dFim">Data de Fim da prestação do serviço. (required).</param>
        /// <param name="classDuto">Classificação do Dutoviário.  Informar: 1 - Gasoduto 2 - Mineroduto 3 - Oleoduto..</param>
        /// <param name="tpContratacao">Tipo de contratação do serviço de transporte (apenas para gasoduto).  Informar:  * 0 - Ponta a ponto  * 1 - Capacidade de Entrada  * 2 - Capacidade de Saida.</param>
        /// <param name="codPontoEntrada">Código do Ponto de Entrada..</param>
        /// <param name="codPontoSaida">Código do Ponto de Saída..</param>
        /// <param name="nContrato">Número do Contrato de Capacidade..</param>
        public CteSimpSefazDutoSimp(decimal? vTar = default(decimal?), DateTime? dIni = default(DateTime?), DateTime? dFim = default(DateTime?), int? classDuto = default(int?), int? tpContratacao = default(int?), string codPontoEntrada = default(string), string codPontoSaida = default(string), string nContrato = default(string))
        {
            // to ensure "dIni" is required (not null)
            if (dIni == null)
            {
                throw new ArgumentNullException("dIni is a required property for CteSimpSefazDutoSimp and cannot be null");
            }
            this.dIni = dIni;
            // to ensure "dFim" is required (not null)
            if (dFim == null)
            {
                throw new ArgumentNullException("dFim is a required property for CteSimpSefazDutoSimp and cannot be null");
            }
            this.dFim = dFim;
            this.vTar = vTar;
            this.classDuto = classDuto;
            this.tpContratacao = tpContratacao;
            this.codPontoEntrada = codPontoEntrada;
            this.codPontoSaida = codPontoSaida;
            this.nContrato = nContrato;
        }

        /// <summary>
        /// Valor da tarifa.
        /// </summary>
        /// <value>Valor da tarifa.</value>
        [DataMember(Name = "vTar", EmitDefaultValue = true)]
        public decimal? vTar { get; set; }

        /// <summary>
        /// Data de Início da prestação do serviço.
        /// </summary>
        /// <value>Data de Início da prestação do serviço.</value>
        [DataMember(Name = "dIni", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dIni { get; set; }

        /// <summary>
        /// Data de Fim da prestação do serviço.
        /// </summary>
        /// <value>Data de Fim da prestação do serviço.</value>
        [DataMember(Name = "dFim", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dFim { get; set; }

        /// <summary>
        /// Classificação do Dutoviário.  Informar: 1 - Gasoduto 2 - Mineroduto 3 - Oleoduto.
        /// </summary>
        /// <value>Classificação do Dutoviário.  Informar: 1 - Gasoduto 2 - Mineroduto 3 - Oleoduto.</value>
        [DataMember(Name = "classDuto", EmitDefaultValue = true)]
        public int? classDuto { get; set; }

        /// <summary>
        /// Tipo de contratação do serviço de transporte (apenas para gasoduto).  Informar:  * 0 - Ponta a ponto  * 1 - Capacidade de Entrada  * 2 - Capacidade de Saida
        /// </summary>
        /// <value>Tipo de contratação do serviço de transporte (apenas para gasoduto).  Informar:  * 0 - Ponta a ponto  * 1 - Capacidade de Entrada  * 2 - Capacidade de Saida</value>
        [DataMember(Name = "tpContratacao", EmitDefaultValue = true)]
        public int? tpContratacao { get; set; }

        /// <summary>
        /// Código do Ponto de Entrada.
        /// </summary>
        /// <value>Código do Ponto de Entrada.</value>
        [DataMember(Name = "codPontoEntrada", EmitDefaultValue = true)]
        public string codPontoEntrada { get; set; }

        /// <summary>
        /// Código do Ponto de Saída.
        /// </summary>
        /// <value>Código do Ponto de Saída.</value>
        [DataMember(Name = "codPontoSaida", EmitDefaultValue = true)]
        public string codPontoSaida { get; set; }

        /// <summary>
        /// Número do Contrato de Capacidade.
        /// </summary>
        /// <value>Número do Contrato de Capacidade.</value>
        [DataMember(Name = "nContrato", EmitDefaultValue = true)]
        public string nContrato { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazDutoSimp {\n");
            sb.Append("  vTar: ").Append(vTar).Append("\n");
            sb.Append("  dIni: ").Append(dIni).Append("\n");
            sb.Append("  dFim: ").Append(dFim).Append("\n");
            sb.Append("  classDuto: ").Append(classDuto).Append("\n");
            sb.Append("  tpContratacao: ").Append(tpContratacao).Append("\n");
            sb.Append("  codPontoEntrada: ").Append(codPontoEntrada).Append("\n");
            sb.Append("  codPontoSaida: ").Append(codPontoSaida).Append("\n");
            sb.Append("  nContrato: ").Append(nContrato).Append("\n");
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
            return this.Equals(input as CteSimpSefazDutoSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazDutoSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazDutoSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazDutoSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vTar == input.vTar ||
                    (this.vTar != null &&
                    this.vTar.Equals(input.vTar))
                ) && 
                (
                    this.dIni == input.dIni ||
                    (this.dIni != null &&
                    this.dIni.Equals(input.dIni))
                ) && 
                (
                    this.dFim == input.dFim ||
                    (this.dFim != null &&
                    this.dFim.Equals(input.dFim))
                ) && 
                (
                    this.classDuto == input.classDuto ||
                    (this.classDuto != null &&
                    this.classDuto.Equals(input.classDuto))
                ) && 
                (
                    this.tpContratacao == input.tpContratacao ||
                    (this.tpContratacao != null &&
                    this.tpContratacao.Equals(input.tpContratacao))
                ) && 
                (
                    this.codPontoEntrada == input.codPontoEntrada ||
                    (this.codPontoEntrada != null &&
                    this.codPontoEntrada.Equals(input.codPontoEntrada))
                ) && 
                (
                    this.codPontoSaida == input.codPontoSaida ||
                    (this.codPontoSaida != null &&
                    this.codPontoSaida.Equals(input.codPontoSaida))
                ) && 
                (
                    this.nContrato == input.nContrato ||
                    (this.nContrato != null &&
                    this.nContrato.Equals(input.nContrato))
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
                if (this.vTar != null)
                {
                    hashCode = (hashCode * 59) + this.vTar.GetHashCode();
                }
                if (this.dIni != null)
                {
                    hashCode = (hashCode * 59) + this.dIni.GetHashCode();
                }
                if (this.dFim != null)
                {
                    hashCode = (hashCode * 59) + this.dFim.GetHashCode();
                }
                if (this.classDuto != null)
                {
                    hashCode = (hashCode * 59) + this.classDuto.GetHashCode();
                }
                if (this.tpContratacao != null)
                {
                    hashCode = (hashCode * 59) + this.tpContratacao.GetHashCode();
                }
                if (this.codPontoEntrada != null)
                {
                    hashCode = (hashCode * 59) + this.codPontoEntrada.GetHashCode();
                }
                if (this.codPontoSaida != null)
                {
                    hashCode = (hashCode * 59) + this.codPontoSaida.GetHashCode();
                }
                if (this.nContrato != null)
                {
                    hashCode = (hashCode * 59) + this.nContrato.GetHashCode();
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
            // vTar (decimal?) minimum
            if (this.vTar < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for vTar, must be a value greater than or equal to 0.", new [] { "vTar" });
            }

            // codPontoEntrada (string) maxLength
            if (this.codPontoEntrada != null && this.codPontoEntrada.Length > 20)
            {
                yield return new ValidationResult("Invalid value for codPontoEntrada, length must be less than 20.", new [] { "codPontoEntrada" });
            }

            // codPontoEntrada (string) minLength
            if (this.codPontoEntrada != null && this.codPontoEntrada.Length < 2)
            {
                yield return new ValidationResult("Invalid value for codPontoEntrada, length must be greater than 2.", new [] { "codPontoEntrada" });
            }

            // codPontoSaida (string) maxLength
            if (this.codPontoSaida != null && this.codPontoSaida.Length > 20)
            {
                yield return new ValidationResult("Invalid value for codPontoSaida, length must be less than 20.", new [] { "codPontoSaida" });
            }

            // codPontoSaida (string) minLength
            if (this.codPontoSaida != null && this.codPontoSaida.Length < 2)
            {
                yield return new ValidationResult("Invalid value for codPontoSaida, length must be greater than 2.", new [] { "codPontoSaida" });
            }

            // nContrato (string) maxLength
            if (this.nContrato != null && this.nContrato.Length > 20)
            {
                yield return new ValidationResult("Invalid value for nContrato, length must be less than 20.", new [] { "nContrato" });
            }

            // nContrato (string) minLength
            if (this.nContrato != null && this.nContrato.Length < 2)
            {
                yield return new ValidationResult("Invalid value for nContrato, length must be greater than 2.", new [] { "nContrato" });
            }

            yield break;
        }
    }

}
