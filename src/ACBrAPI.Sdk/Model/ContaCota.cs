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
    /// ContaCota
    /// </summary>
    [DataContract(Name = "ContaCota")]
    public partial class ContaCota : IEquatable<ContaCota>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaCota" /> class.
        /// </summary>
        /// <param name="nome">nome.</param>
        /// <param name="consumo">consumo.</param>
        /// <param name="limite">limite.</param>
        /// <param name="disponivel">disponivel.</param>
        /// <param name="ultimaAtualizacao">ultimaAtualizacao.</param>
        public ContaCota(string nome = default(string), decimal consumo = default(decimal), decimal? limite = default(decimal?), decimal disponivel = default(decimal), string ultimaAtualizacao = default(string))
        {
            this.nome = nome;
            this.consumo = consumo;
            this.limite = limite;
            this.disponivel = disponivel;
            this.ultima_atualizacao = ultimaAtualizacao;
        }

        /// <summary>
        /// Gets or Sets nome
        /// </summary>
        [DataMember(Name = "nome", EmitDefaultValue = false)]
        public string nome { get; set; }

        /// <summary>
        /// Gets or Sets consumo
        /// </summary>
        [DataMember(Name = "consumo", EmitDefaultValue = false)]
        public decimal consumo { get; set; }

        /// <summary>
        /// Gets or Sets limite
        /// </summary>
        [DataMember(Name = "limite", EmitDefaultValue = true)]
        public decimal? limite { get; set; }

        /// <summary>
        /// Gets or Sets disponivel
        /// </summary>
        [DataMember(Name = "disponivel", EmitDefaultValue = false)]
        public decimal disponivel { get; set; }

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
            sb.Append("class ContaCota {\n");
            sb.Append("  nome: ").Append(nome).Append("\n");
            sb.Append("  consumo: ").Append(consumo).Append("\n");
            sb.Append("  limite: ").Append(limite).Append("\n");
            sb.Append("  disponivel: ").Append(disponivel).Append("\n");
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
            return this.Equals(input as ContaCota);
        }

        /// <summary>
        /// Returns true if ContaCota instances are equal
        /// </summary>
        /// <param name="input">Instance of ContaCota to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaCota input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nome == input.nome ||
                    (this.nome != null &&
                    this.nome.Equals(input.nome))
                ) && 
                (
                    this.consumo == input.consumo ||
                    this.consumo.Equals(input.consumo)
                ) && 
                (
                    this.limite == input.limite ||
                    (this.limite != null &&
                    this.limite.Equals(input.limite))
                ) && 
                (
                    this.disponivel == input.disponivel ||
                    this.disponivel.Equals(input.disponivel)
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
                if (this.nome != null)
                {
                    hashCode = (hashCode * 59) + this.nome.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.consumo.GetHashCode();
                if (this.limite != null)
                {
                    hashCode = (hashCode * 59) + this.limite.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.disponivel.GetHashCode();
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
