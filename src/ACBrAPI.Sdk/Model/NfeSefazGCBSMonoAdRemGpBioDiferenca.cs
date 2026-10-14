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
    /// Grupo de informações sobre mistura de EAC com gasolina A em percentual inferior ou superior ao obrigatório.
    /// </summary>
    [DataContract(Name = "NfeSefazGCBSMonoAdRem_GpBioDiferenca")]
    public partial class NfeSefazGCBSMonoAdRemGpBioDiferenca : IEquatable<NfeSefazGCBSMonoAdRemGpBioDiferenca>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdRemGpBioDiferenca" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazGCBSMonoAdRemGpBioDiferenca() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdRemGpBioDiferenca" /> class.
        /// </summary>
        /// <param name="qBCBioComb">Quantidade de Biocombustível (EAC) a recolher ou a ressarcir. (required).</param>
        /// <param name="vCBSDiferenca">Valor da CBS correspondente a diferença em relação ao pBioObrigatorio. (required).</param>
        public NfeSefazGCBSMonoAdRemGpBioDiferenca(decimal? qBCBioComb = default(decimal?), decimal? vCBSDiferenca = default(decimal?))
        {
            // to ensure "qBCBioComb" is required (not null)
            if (qBCBioComb == null)
            {
                throw new ArgumentNullException("qBCBioComb is a required property for NfeSefazGCBSMonoAdRemGpBioDiferenca and cannot be null");
            }
            this.qBCBioComb = qBCBioComb;
            // to ensure "vCBSDiferenca" is required (not null)
            if (vCBSDiferenca == null)
            {
                throw new ArgumentNullException("vCBSDiferenca is a required property for NfeSefazGCBSMonoAdRemGpBioDiferenca and cannot be null");
            }
            this.vCBSDiferenca = vCBSDiferenca;
        }

        /// <summary>
        /// Quantidade de Biocombustível (EAC) a recolher ou a ressarcir.
        /// </summary>
        /// <value>Quantidade de Biocombustível (EAC) a recolher ou a ressarcir.</value>
        [DataMember(Name = "qBCBioComb", IsRequired = true, EmitDefaultValue = true)]
        public decimal? qBCBioComb { get; set; }

        /// <summary>
        /// Valor da CBS correspondente a diferença em relação ao pBioObrigatorio.
        /// </summary>
        /// <value>Valor da CBS correspondente a diferença em relação ao pBioObrigatorio.</value>
        [DataMember(Name = "vCBSDiferenca", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vCBSDiferenca { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGCBSMonoAdRemGpBioDiferenca {\n");
            sb.Append("  qBCBioComb: ").Append(qBCBioComb).Append("\n");
            sb.Append("  vCBSDiferenca: ").Append(vCBSDiferenca).Append("\n");
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
            return this.Equals(input as NfeSefazGCBSMonoAdRemGpBioDiferenca);
        }

        /// <summary>
        /// Returns true if NfeSefazGCBSMonoAdRemGpBioDiferenca instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGCBSMonoAdRemGpBioDiferenca to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGCBSMonoAdRemGpBioDiferenca input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.qBCBioComb == input.qBCBioComb ||
                    (this.qBCBioComb != null &&
                    this.qBCBioComb.Equals(input.qBCBioComb))
                ) && 
                (
                    this.vCBSDiferenca == input.vCBSDiferenca ||
                    (this.vCBSDiferenca != null &&
                    this.vCBSDiferenca.Equals(input.vCBSDiferenca))
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
                if (this.qBCBioComb != null)
                {
                    hashCode = (hashCode * 59) + this.qBCBioComb.GetHashCode();
                }
                if (this.vCBSDiferenca != null)
                {
                    hashCode = (hashCode * 59) + this.vCBSDiferenca.GetHashCode();
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
            // qBCBioComb (decimal?) minimum
            if (this.qBCBioComb < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for qBCBioComb, must be a value greater than or equal to 0.", new [] { "qBCBioComb" });
            }

            // vCBSDiferenca (decimal?) minimum
            if (this.vCBSDiferenca < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vCBSDiferenca, must be a value greater than or equal to 0.", new [] { "vCBSDiferenca" });
            }

            yield break;
        }
    }

}
