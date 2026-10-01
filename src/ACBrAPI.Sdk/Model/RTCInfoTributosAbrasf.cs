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
    /// Grupo de informações dos valores do IBS e da CBS utilizado pelos provedores municipais.    **Atenção**: Para emissões pelo Sistema Nacional NFS-e, esse campo é ignorado.
    /// </summary>
    [DataContract(Name = "RTCInfoTributosAbrasf")]
    public partial class RTCInfoTributosAbrasf : IEquatable<RTCInfoTributosAbrasf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoTributosAbrasf" /> class.
        /// </summary>
        /// <param name="vBC">Valor da base de cálculo (BC) do IBS/CBS (R$)..</param>
        /// <param name="fed">fed.</param>
        /// <param name="uf">uf.</param>
        /// <param name="mun">mun.</param>
        public RTCInfoTributosAbrasf(decimal? vBC = default(decimal?), RTCInfoTributosAbrasfFed fed = default(RTCInfoTributosAbrasfFed), RTCInfoTributosAbrasfUF uf = default(RTCInfoTributosAbrasfUF), RTCInfoTributosAbrasfMun mun = default(RTCInfoTributosAbrasfMun))
        {
            this.vBC = vBC;
            this.fed = fed;
            this.uf = uf;
            this.mun = mun;
        }

        /// <summary>
        /// Valor da base de cálculo (BC) do IBS/CBS (R$).
        /// </summary>
        /// <value>Valor da base de cálculo (BC) do IBS/CBS (R$).</value>
        [DataMember(Name = "vBC", EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Gets or Sets fed
        /// </summary>
        [DataMember(Name = "fed", EmitDefaultValue = false)]
        public RTCInfoTributosAbrasfFed fed { get; set; }

        /// <summary>
        /// Gets or Sets uf
        /// </summary>
        [DataMember(Name = "uf", EmitDefaultValue = false)]
        public RTCInfoTributosAbrasfUF uf { get; set; }

        /// <summary>
        /// Gets or Sets mun
        /// </summary>
        [DataMember(Name = "mun", EmitDefaultValue = false)]
        public RTCInfoTributosAbrasfMun mun { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCInfoTributosAbrasf {\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  fed: ").Append(fed).Append("\n");
            sb.Append("  uf: ").Append(uf).Append("\n");
            sb.Append("  mun: ").Append(mun).Append("\n");
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
            return this.Equals(input as RTCInfoTributosAbrasf);
        }

        /// <summary>
        /// Returns true if RTCInfoTributosAbrasf instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCInfoTributosAbrasf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCInfoTributosAbrasf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.fed == input.fed ||
                    (this.fed != null &&
                    this.fed.Equals(input.fed))
                ) && 
                (
                    this.uf == input.uf ||
                    (this.uf != null &&
                    this.uf.Equals(input.uf))
                ) && 
                (
                    this.mun == input.mun ||
                    (this.mun != null &&
                    this.mun.Equals(input.mun))
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
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.fed != null)
                {
                    hashCode = (hashCode * 59) + this.fed.GetHashCode();
                }
                if (this.uf != null)
                {
                    hashCode = (hashCode * 59) + this.uf.GetHashCode();
                }
                if (this.mun != null)
                {
                    hashCode = (hashCode * 59) + this.mun.GetHashCode();
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
            // vBC (decimal?) minimum
            if (this.vBC < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBC, must be a value greater than or equal to 0.", new [] { "vBC" });
            }

            yield break;
        }
    }

}
