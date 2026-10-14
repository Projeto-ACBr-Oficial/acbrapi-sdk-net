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
    [DataContract(Name = "NfeSefazGIBSMonoAdValorem_GpBioDiferenca")]
    public partial class NfeSefazGIBSMonoAdValoremGpBioDiferenca : IEquatable<NfeSefazGIBSMonoAdValoremGpBioDiferenca>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGIBSMonoAdValoremGpBioDiferenca" /> class.
        /// </summary>
        /// <param name="qBCBioComb">qBCBioComb.</param>
        /// <param name="vIBSDiferenca">vIBSDiferenca.</param>
        public NfeSefazGIBSMonoAdValoremGpBioDiferenca(decimal? qBCBioComb = default(decimal?), decimal? vIBSDiferenca = default(decimal?))
        {
            this.qBCBioComb = qBCBioComb;
            this.vIBSDiferenca = vIBSDiferenca;
        }

        /// <summary>
        /// Gets or Sets qBCBioComb
        /// </summary>
        [DataMember(Name = "qBCBioComb", EmitDefaultValue = true)]
        public decimal? qBCBioComb { get; set; }

        /// <summary>
        /// Gets or Sets vIBSDiferenca
        /// </summary>
        [DataMember(Name = "vIBSDiferenca", EmitDefaultValue = true)]
        public decimal? vIBSDiferenca { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGIBSMonoAdValoremGpBioDiferenca {\n");
            sb.Append("  qBCBioComb: ").Append(qBCBioComb).Append("\n");
            sb.Append("  vIBSDiferenca: ").Append(vIBSDiferenca).Append("\n");
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
            return this.Equals(input as NfeSefazGIBSMonoAdValoremGpBioDiferenca);
        }

        /// <summary>
        /// Returns true if NfeSefazGIBSMonoAdValoremGpBioDiferenca instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGIBSMonoAdValoremGpBioDiferenca to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGIBSMonoAdValoremGpBioDiferenca input)
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
                    this.vIBSDiferenca == input.vIBSDiferenca ||
                    (this.vIBSDiferenca != null &&
                    this.vIBSDiferenca.Equals(input.vIBSDiferenca))
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
                if (this.vIBSDiferenca != null)
                {
                    hashCode = (hashCode * 59) + this.vIBSDiferenca.GetHashCode();
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

            // vIBSDiferenca (decimal?) minimum
            if (this.vIBSDiferenca < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vIBSDiferenca, must be a value greater than or equal to 0.", new [] { "vIBSDiferenca" });
            }

            yield break;
        }
    }

}
