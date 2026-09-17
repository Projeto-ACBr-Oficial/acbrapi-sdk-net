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
    /// Configurações do CSC (Código de Segurança do Contribuinte) para emissão  da NFC-e.    Se informado &#x60;id_csc&#x60; e &#x60;csc&#x60;, será utilizada a versão 2 do QR Code da  NFC-e. Para utilizar a versão 3 do QR Code (NT 2025.001), que dispensa o  CSC, envie &#x60;id_csc&#x60; igual a 0 (zero) e &#x60;csc&#x60; como string vazia.    Observação: emitente pessoa física (CPF) utilizar sempre a versão 3 do  QR Code.
    /// </summary>
    [DataContract(Name = "EmpresaConfigNfceSefaz")]
    public partial class EmpresaConfigNfceSefaz : IEquatable<EmpresaConfigNfceSefaz>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpresaConfigNfceSefaz" /> class.
        /// </summary>
        /// <param name="idCsc">Número de identificação do CSC..</param>
        /// <param name="csc">Código do CSC..</param>
        public EmpresaConfigNfceSefaz(int idCsc = default(int), string csc = default(string))
        {
            this.id_csc = idCsc;
            this.csc = csc;
        }

        /// <summary>
        /// Número de identificação do CSC.
        /// </summary>
        /// <value>Número de identificação do CSC.</value>
        [DataMember(Name = "id_csc", EmitDefaultValue = false)]
        public int id_csc { get; set; }

        /// <summary>
        /// Código do CSC.
        /// </summary>
        /// <value>Código do CSC.</value>
        [DataMember(Name = "csc", EmitDefaultValue = false)]
        public string csc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmpresaConfigNfceSefaz {\n");
            sb.Append("  id_csc: ").Append(id_csc).Append("\n");
            sb.Append("  csc: ").Append(csc).Append("\n");
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
            return this.Equals(input as EmpresaConfigNfceSefaz);
        }

        /// <summary>
        /// Returns true if EmpresaConfigNfceSefaz instances are equal
        /// </summary>
        /// <param name="input">Instance of EmpresaConfigNfceSefaz to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmpresaConfigNfceSefaz input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.id_csc == input.id_csc ||
                    this.id_csc.Equals(input.id_csc)
                ) && 
                (
                    this.csc == input.csc ||
                    (this.csc != null &&
                    this.csc.Equals(input.csc))
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
                hashCode = (hashCode * 59) + this.id_csc.GetHashCode();
                if (this.csc != null)
                {
                    hashCode = (hashCode * 59) + this.csc.GetHashCode();
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
            // csc (string) maxLength
            if (this.csc != null && this.csc.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for csc, length must be less than 50.", new [] { "csc" });
            }

            yield break;
        }
    }

}
