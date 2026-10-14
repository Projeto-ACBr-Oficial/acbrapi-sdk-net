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
    /// Grupo de informações da Tributação Monofásica Ad Valorem da CBS.
    /// </summary>
    [DataContract(Name = "NfeSefazGCBSMonoAdValorem")]
    public partial class NfeSefazGCBSMonoAdValorem : IEquatable<NfeSefazGCBSMonoAdValorem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazGCBSMonoAdValorem" /> class.
        /// </summary>
        /// <param name="gMonoPadrao">gMonoPadrao.</param>
        /// <param name="gMonoReten">gMonoReten.</param>
        /// <param name="gMonoRet">gMonoRet.</param>
        /// <param name="gpBioDiferenca">gpBioDiferenca.</param>
        public NfeSefazGCBSMonoAdValorem(NfeSefazGCBSMonoAdValoremGMonoPadrao gMonoPadrao = default(NfeSefazGCBSMonoAdValoremGMonoPadrao), NfeSefazGCBSMonoAdValoremGMonoReten gMonoReten = default(NfeSefazGCBSMonoAdValoremGMonoReten), NfeSefazGCBSMonoAdValoremGMonoRet gMonoRet = default(NfeSefazGCBSMonoAdValoremGMonoRet), NfeSefazGCBSMonoAdValoremGpBioDiferenca gpBioDiferenca = default(NfeSefazGCBSMonoAdValoremGpBioDiferenca))
        {
            this.gMonoPadrao = gMonoPadrao;
            this.gMonoReten = gMonoReten;
            this.gMonoRet = gMonoRet;
            this.gpBioDiferenca = gpBioDiferenca;
        }

        /// <summary>
        /// Gets or Sets gMonoPadrao
        /// </summary>
        [DataMember(Name = "gMonoPadrao", EmitDefaultValue = false)]
        public NfeSefazGCBSMonoAdValoremGMonoPadrao gMonoPadrao { get; set; }

        /// <summary>
        /// Gets or Sets gMonoReten
        /// </summary>
        [DataMember(Name = "gMonoReten", EmitDefaultValue = false)]
        public NfeSefazGCBSMonoAdValoremGMonoReten gMonoReten { get; set; }

        /// <summary>
        /// Gets or Sets gMonoRet
        /// </summary>
        [DataMember(Name = "gMonoRet", EmitDefaultValue = false)]
        public NfeSefazGCBSMonoAdValoremGMonoRet gMonoRet { get; set; }

        /// <summary>
        /// Gets or Sets gpBioDiferenca
        /// </summary>
        [DataMember(Name = "gpBioDiferenca", EmitDefaultValue = false)]
        public NfeSefazGCBSMonoAdValoremGpBioDiferenca gpBioDiferenca { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazGCBSMonoAdValorem {\n");
            sb.Append("  gMonoPadrao: ").Append(gMonoPadrao).Append("\n");
            sb.Append("  gMonoReten: ").Append(gMonoReten).Append("\n");
            sb.Append("  gMonoRet: ").Append(gMonoRet).Append("\n");
            sb.Append("  gpBioDiferenca: ").Append(gpBioDiferenca).Append("\n");
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
            return this.Equals(input as NfeSefazGCBSMonoAdValorem);
        }

        /// <summary>
        /// Returns true if NfeSefazGCBSMonoAdValorem instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazGCBSMonoAdValorem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazGCBSMonoAdValorem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.gMonoPadrao == input.gMonoPadrao ||
                    (this.gMonoPadrao != null &&
                    this.gMonoPadrao.Equals(input.gMonoPadrao))
                ) && 
                (
                    this.gMonoReten == input.gMonoReten ||
                    (this.gMonoReten != null &&
                    this.gMonoReten.Equals(input.gMonoReten))
                ) && 
                (
                    this.gMonoRet == input.gMonoRet ||
                    (this.gMonoRet != null &&
                    this.gMonoRet.Equals(input.gMonoRet))
                ) && 
                (
                    this.gpBioDiferenca == input.gpBioDiferenca ||
                    (this.gpBioDiferenca != null &&
                    this.gpBioDiferenca.Equals(input.gpBioDiferenca))
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
                if (this.gMonoPadrao != null)
                {
                    hashCode = (hashCode * 59) + this.gMonoPadrao.GetHashCode();
                }
                if (this.gMonoReten != null)
                {
                    hashCode = (hashCode * 59) + this.gMonoReten.GetHashCode();
                }
                if (this.gMonoRet != null)
                {
                    hashCode = (hashCode * 59) + this.gMonoRet.GetHashCode();
                }
                if (this.gpBioDiferenca != null)
                {
                    hashCode = (hashCode * 59) + this.gpBioDiferenca.GetHashCode();
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
