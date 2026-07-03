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
    /// Grupo de operações em áreas incentivadas (ALC/ZFM) - CBS (alíquota zero).  Grupo de informações para identificação de operações em áreas incentivadas (ALC/ZFM) com alíquota zero da CBS, conforme arts. 451 e 466 da LC 214/2025, quando fornecedor e destinatário estiverem nessas áreas, distinguindo a existência de processo aprovado na Suframa.
    /// </summary>
    [DataContract(Name = "CteSefazALCZFMCBS")]
    public partial class CteSefazALCZFMCBS : IEquatable<CteSefazALCZFMCBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazALCZFMCBS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSefazALCZFMCBS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSefazALCZFMCBS" /> class.
        /// </summary>
        /// <param name="pAliqEfetRegCBS">Percentual efetivo sem a redução.  Alíquota efetiva de referência da CBS aplicável à operação fora de áreas ou regimes incentivados. (required).</param>
        /// <param name="vTribRegCBS">Valor efetivo sem a redução.  Valor da CBS calculado para a operação fora de áreas ou regimes incentivado. (required).</param>
        public CteSefazALCZFMCBS(decimal? pAliqEfetRegCBS = default(decimal?), decimal? vTribRegCBS = default(decimal?))
        {
            // to ensure "pAliqEfetRegCBS" is required (not null)
            if (pAliqEfetRegCBS == null)
            {
                throw new ArgumentNullException("pAliqEfetRegCBS is a required property for CteSefazALCZFMCBS and cannot be null");
            }
            this.pAliqEfetRegCBS = pAliqEfetRegCBS;
            // to ensure "vTribRegCBS" is required (not null)
            if (vTribRegCBS == null)
            {
                throw new ArgumentNullException("vTribRegCBS is a required property for CteSefazALCZFMCBS and cannot be null");
            }
            this.vTribRegCBS = vTribRegCBS;
        }

        /// <summary>
        /// Percentual efetivo sem a redução.  Alíquota efetiva de referência da CBS aplicável à operação fora de áreas ou regimes incentivados.
        /// </summary>
        /// <value>Percentual efetivo sem a redução.  Alíquota efetiva de referência da CBS aplicável à operação fora de áreas ou regimes incentivados.</value>
        [DataMember(Name = "pAliqEfetRegCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pAliqEfetRegCBS { get; set; }

        /// <summary>
        /// Valor efetivo sem a redução.  Valor da CBS calculado para a operação fora de áreas ou regimes incentivado.
        /// </summary>
        /// <value>Valor efetivo sem a redução.  Valor da CBS calculado para a operação fora de áreas ou regimes incentivado.</value>
        [DataMember(Name = "vTribRegCBS", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vTribRegCBS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSefazALCZFMCBS {\n");
            sb.Append("  pAliqEfetRegCBS: ").Append(pAliqEfetRegCBS).Append("\n");
            sb.Append("  vTribRegCBS: ").Append(vTribRegCBS).Append("\n");
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
            return this.Equals(input as CteSefazALCZFMCBS);
        }

        /// <summary>
        /// Returns true if CteSefazALCZFMCBS instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSefazALCZFMCBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSefazALCZFMCBS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pAliqEfetRegCBS == input.pAliqEfetRegCBS ||
                    (this.pAliqEfetRegCBS != null &&
                    this.pAliqEfetRegCBS.Equals(input.pAliqEfetRegCBS))
                ) && 
                (
                    this.vTribRegCBS == input.vTribRegCBS ||
                    (this.vTribRegCBS != null &&
                    this.vTribRegCBS.Equals(input.vTribRegCBS))
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
                if (this.pAliqEfetRegCBS != null)
                {
                    hashCode = (hashCode * 59) + this.pAliqEfetRegCBS.GetHashCode();
                }
                if (this.vTribRegCBS != null)
                {
                    hashCode = (hashCode * 59) + this.vTribRegCBS.GetHashCode();
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
            // pAliqEfetRegCBS (decimal?) minimum
            if (this.pAliqEfetRegCBS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pAliqEfetRegCBS, must be a value greater than or equal to 0.", new [] { "pAliqEfetRegCBS" });
            }

            // vTribRegCBS (decimal?) minimum
            if (this.vTribRegCBS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vTribRegCBS, must be a value greater than or equal to 0.", new [] { "vTribRegCBS" });
            }

            yield break;
        }
    }

}
