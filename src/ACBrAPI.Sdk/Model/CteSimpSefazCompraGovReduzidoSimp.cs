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
    /// Grupo de Compras Governamentais.
    /// </summary>
    [DataContract(Name = "CteSimpSefazCompraGovReduzidoSimp")]
    public partial class CteSimpSefazCompraGovReduzidoSimp : IEquatable<CteSimpSefazCompraGovReduzidoSimp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazCompraGovReduzidoSimp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CteSimpSefazCompraGovReduzidoSimp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CteSimpSefazCompraGovReduzidoSimp" /> class.
        /// </summary>
        /// <param name="tpEnteGov">Para administração pública direta e suas autarquias e fundações:  * 1 - União  * 2 - Estados  * 3 - Distrito Federal  * 4 - Municípios (required).</param>
        /// <param name="pRedutor">Percentual de redução de aliquota em compra goverrnamental. (required).</param>
        public CteSimpSefazCompraGovReduzidoSimp(int? tpEnteGov = default(int?), decimal? pRedutor = default(decimal?))
        {
            // to ensure "tpEnteGov" is required (not null)
            if (tpEnteGov == null)
            {
                throw new ArgumentNullException("tpEnteGov is a required property for CteSimpSefazCompraGovReduzidoSimp and cannot be null");
            }
            this.tpEnteGov = tpEnteGov;
            // to ensure "pRedutor" is required (not null)
            if (pRedutor == null)
            {
                throw new ArgumentNullException("pRedutor is a required property for CteSimpSefazCompraGovReduzidoSimp and cannot be null");
            }
            this.pRedutor = pRedutor;
        }

        /// <summary>
        /// Para administração pública direta e suas autarquias e fundações:  * 1 - União  * 2 - Estados  * 3 - Distrito Federal  * 4 - Municípios
        /// </summary>
        /// <value>Para administração pública direta e suas autarquias e fundações:  * 1 - União  * 2 - Estados  * 3 - Distrito Federal  * 4 - Municípios</value>
        [DataMember(Name = "tpEnteGov", IsRequired = true, EmitDefaultValue = true)]
        public int? tpEnteGov { get; set; }

        /// <summary>
        /// Percentual de redução de aliquota em compra goverrnamental.
        /// </summary>
        /// <value>Percentual de redução de aliquota em compra goverrnamental.</value>
        [DataMember(Name = "pRedutor", IsRequired = true, EmitDefaultValue = true)]
        public decimal? pRedutor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CteSimpSefazCompraGovReduzidoSimp {\n");
            sb.Append("  tpEnteGov: ").Append(tpEnteGov).Append("\n");
            sb.Append("  pRedutor: ").Append(pRedutor).Append("\n");
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
            return this.Equals(input as CteSimpSefazCompraGovReduzidoSimp);
        }

        /// <summary>
        /// Returns true if CteSimpSefazCompraGovReduzidoSimp instances are equal
        /// </summary>
        /// <param name="input">Instance of CteSimpSefazCompraGovReduzidoSimp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CteSimpSefazCompraGovReduzidoSimp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tpEnteGov == input.tpEnteGov ||
                    (this.tpEnteGov != null &&
                    this.tpEnteGov.Equals(input.tpEnteGov))
                ) && 
                (
                    this.pRedutor == input.pRedutor ||
                    (this.pRedutor != null &&
                    this.pRedutor.Equals(input.pRedutor))
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
                if (this.tpEnteGov != null)
                {
                    hashCode = (hashCode * 59) + this.tpEnteGov.GetHashCode();
                }
                if (this.pRedutor != null)
                {
                    hashCode = (hashCode * 59) + this.pRedutor.GetHashCode();
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
            // pRedutor (decimal?) minimum
            if (this.pRedutor < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for pRedutor, must be a value greater than or equal to 0.", new [] { "pRedutor" });
            }

            yield break;
        }
    }

}
