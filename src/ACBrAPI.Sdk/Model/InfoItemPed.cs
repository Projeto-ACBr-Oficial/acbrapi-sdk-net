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
    /// Grupo de itens do pedido/ordem de compra/ordem de serviço/projeto.
    /// </summary>
    [DataContract(Name = "InfoItemPed")]
    public partial class InfoItemPed : IEquatable<InfoItemPed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoItemPed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoItemPed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoItemPed" /> class.
        /// </summary>
        /// <param name="xItemPed">Número do item do  pedido/ordem de compra/ordem de serviço/projeto - Identificação do número do item do pedido ou ordem de compra destacado e xPed. (required).</param>
        public InfoItemPed(List<string> xItemPed = default(List<string>))
        {
            // to ensure "xItemPed" is required (not null)
            if (xItemPed == null)
            {
                throw new ArgumentNullException("xItemPed is a required property for InfoItemPed and cannot be null");
            }
            this.xItemPed = xItemPed;
        }

        /// <summary>
        /// Número do item do  pedido/ordem de compra/ordem de serviço/projeto - Identificação do número do item do pedido ou ordem de compra destacado e xPed.
        /// </summary>
        /// <value>Número do item do  pedido/ordem de compra/ordem de serviço/projeto - Identificação do número do item do pedido ou ordem de compra destacado e xPed.</value>
        [DataMember(Name = "xItemPed", IsRequired = true, EmitDefaultValue = true)]
        public List<string> xItemPed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoItemPed {\n");
            sb.Append("  xItemPed: ").Append(xItemPed).Append("\n");
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
            return this.Equals(input as InfoItemPed);
        }

        /// <summary>
        /// Returns true if InfoItemPed instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoItemPed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoItemPed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.xItemPed == input.xItemPed ||
                    this.xItemPed != null &&
                    input.xItemPed != null &&
                    this.xItemPed.SequenceEqual(input.xItemPed)
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
                if (this.xItemPed != null)
                {
                    hashCode = (hashCode * 59) + this.xItemPed.GetHashCode();
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
