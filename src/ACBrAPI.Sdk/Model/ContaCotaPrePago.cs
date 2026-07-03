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
    /// ContaCotaPrePago
    /// </summary>
    [DataContract(Name = "ContaCotaPrePago")]
    public partial class ContaCotaPrePago : IEquatable<ContaCotaPrePago>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaCotaPrePago" /> class.
        /// </summary>
        /// <param name="percentualDisponivel">percentualDisponivel.</param>
        /// <param name="creditosDisponiveis">creditosDisponiveis.</param>
        /// <param name="ultimaAtualizacao">ultimaAtualizacao.</param>
        public ContaCotaPrePago(decimal percentualDisponivel = default(decimal), decimal creditosDisponiveis = default(decimal), string ultimaAtualizacao = default(string))
        {
            this.percentual_disponivel = percentualDisponivel;
            this.creditos_disponiveis = creditosDisponiveis;
            this.ultima_atualizacao = ultimaAtualizacao;
        }

        /// <summary>
        /// Gets or Sets percentual_disponivel
        /// </summary>
        [DataMember(Name = "percentual_disponivel", EmitDefaultValue = false)]
        public decimal percentual_disponivel { get; set; }

        /// <summary>
        /// Gets or Sets creditos_disponiveis
        /// </summary>
        [DataMember(Name = "creditos_disponiveis", EmitDefaultValue = false)]
        public decimal creditos_disponiveis { get; set; }

        /// <summary>
        /// Gets or Sets ultima_atualizacao
        /// </summary>
        [DataMember(Name = "ultima_atualizacao", EmitDefaultValue = false)]
        public string ultima_atualizacao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContaCotaPrePago {\n");
            sb.Append("  percentual_disponivel: ").Append(percentual_disponivel).Append("\n");
            sb.Append("  creditos_disponiveis: ").Append(creditos_disponiveis).Append("\n");
            sb.Append("  ultima_atualizacao: ").Append(ultima_atualizacao).Append("\n");
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
            return this.Equals(input as ContaCotaPrePago);
        }

        /// <summary>
        /// Returns true if ContaCotaPrePago instances are equal
        /// </summary>
        /// <param name="input">Instance of ContaCotaPrePago to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaCotaPrePago input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.percentual_disponivel == input.percentual_disponivel ||
                    this.percentual_disponivel.Equals(input.percentual_disponivel)
                ) && 
                (
                    this.creditos_disponiveis == input.creditos_disponiveis ||
                    this.creditos_disponiveis.Equals(input.creditos_disponiveis)
                ) && 
                (
                    this.ultima_atualizacao == input.ultima_atualizacao ||
                    (this.ultima_atualizacao != null &&
                    this.ultima_atualizacao.Equals(input.ultima_atualizacao))
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
                hashCode = (hashCode * 59) + this.percentual_disponivel.GetHashCode();
                hashCode = (hashCode * 59) + this.creditos_disponiveis.GetHashCode();
                if (this.ultima_atualizacao != null)
                {
                    hashCode = (hashCode * 59) + this.ultima_atualizacao.GetHashCode();
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
