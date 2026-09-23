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
    /// NfcePedidoCancelamento
    /// </summary>
    [DataContract(Name = "NfcePedidoCancelamento")]
    public partial class NfcePedidoCancelamento : IEquatable<NfcePedidoCancelamento>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfcePedidoCancelamento" /> class.
        /// </summary>
        /// <param name="chaveSubstituta">Chave de acesso da NFC-e substituta.  Quando informada, o cancelamento é enviado à SEFAZ como evento de  \&quot;Cancelamento por substituição\&quot; (110112), no lugar do cancelamento  comum (110111). A NFC-e substituta precisa constar na API, pertencer  à mesma empresa, ter sido emitida no mesmo ambiente e estar autorizada..</param>
        /// <param name="justificativa">Justificativa para o cancelamento. Preencheremos automaticamente, caso esteja em branco..</param>
        public NfcePedidoCancelamento(string chaveSubstituta = default(string), string justificativa = default(string))
        {
            this.chave_substituta = chaveSubstituta;
            this.justificativa = justificativa;
        }

        /// <summary>
        /// Chave de acesso da NFC-e substituta.  Quando informada, o cancelamento é enviado à SEFAZ como evento de  \&quot;Cancelamento por substituição\&quot; (110112), no lugar do cancelamento  comum (110111). A NFC-e substituta precisa constar na API, pertencer  à mesma empresa, ter sido emitida no mesmo ambiente e estar autorizada.
        /// </summary>
        /// <value>Chave de acesso da NFC-e substituta.  Quando informada, o cancelamento é enviado à SEFAZ como evento de  \&quot;Cancelamento por substituição\&quot; (110112), no lugar do cancelamento  comum (110111). A NFC-e substituta precisa constar na API, pertencer  à mesma empresa, ter sido emitida no mesmo ambiente e estar autorizada.</value>
        [DataMember(Name = "chave_substituta", EmitDefaultValue = false)]
        public string chave_substituta { get; set; }

        /// <summary>
        /// Justificativa para o cancelamento. Preencheremos automaticamente, caso esteja em branco.
        /// </summary>
        /// <value>Justificativa para o cancelamento. Preencheremos automaticamente, caso esteja em branco.</value>
        [DataMember(Name = "justificativa", EmitDefaultValue = false)]
        public string justificativa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfcePedidoCancelamento {\n");
            sb.Append("  chave_substituta: ").Append(chave_substituta).Append("\n");
            sb.Append("  justificativa: ").Append(justificativa).Append("\n");
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
            return this.Equals(input as NfcePedidoCancelamento);
        }

        /// <summary>
        /// Returns true if NfcePedidoCancelamento instances are equal
        /// </summary>
        /// <param name="input">Instance of NfcePedidoCancelamento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfcePedidoCancelamento input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.chave_substituta == input.chave_substituta ||
                    (this.chave_substituta != null &&
                    this.chave_substituta.Equals(input.chave_substituta))
                ) && 
                (
                    this.justificativa == input.justificativa ||
                    (this.justificativa != null &&
                    this.justificativa.Equals(input.justificativa))
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
                if (this.chave_substituta != null)
                {
                    hashCode = (hashCode * 59) + this.chave_substituta.GetHashCode();
                }
                if (this.justificativa != null)
                {
                    hashCode = (hashCode * 59) + this.justificativa.GetHashCode();
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
