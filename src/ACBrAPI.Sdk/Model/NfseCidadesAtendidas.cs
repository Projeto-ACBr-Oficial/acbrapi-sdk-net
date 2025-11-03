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
    /// NfseCidadesAtendidas
    /// </summary>
    [DataContract(Name = "NfseCidadesAtendidas")]
    public partial class NfseCidadesAtendidas : IEquatable<NfseCidadesAtendidas>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfseCidadesAtendidas" /> class.
        /// </summary>
        /// <param name="count">Quantidade de cidades atendidas pela API..</param>
        /// <param name="data">Lista com os códigos IBGE das cidades atendidas pela API..</param>
        public NfseCidadesAtendidas(int count = default(int), List<string> data = default(List<string>))
        {
            this.count = count;
            this.data = data;
        }

        /// <summary>
        /// Quantidade de cidades atendidas pela API.
        /// </summary>
        /// <value>Quantidade de cidades atendidas pela API.</value>
        [DataMember(Name = "@count", EmitDefaultValue = false)]
        public int count { get; set; }

        /// <summary>
        /// Lista com os códigos IBGE das cidades atendidas pela API.
        /// </summary>
        /// <value>Lista com os códigos IBGE das cidades atendidas pela API.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<string> data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfseCidadesAtendidas {\n");
            sb.Append("  count: ").Append(count).Append("\n");
            sb.Append("  data: ").Append(data).Append("\n");
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
            return this.Equals(input as NfseCidadesAtendidas);
        }

        /// <summary>
        /// Returns true if NfseCidadesAtendidas instances are equal
        /// </summary>
        /// <param name="input">Instance of NfseCidadesAtendidas to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfseCidadesAtendidas input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.count == input.count ||
                    this.count.Equals(input.count)
                ) && 
                (
                    this.data == input.data ||
                    this.data != null &&
                    input.data != null &&
                    this.data.SequenceEqual(input.data)
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
                hashCode = (hashCode * 59) + this.count.GetHashCode();
                if (this.data != null)
                {
                    hashCode = (hashCode * 59) + this.data.GetHashCode();
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
            yield break;
        }
    }

}
