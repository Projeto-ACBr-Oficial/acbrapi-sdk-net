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
    /// ContaExtratoCredito
    /// </summary>
    [DataContract(Name = "ContaExtratoCredito")]
    public partial class ContaExtratoCredito : IEquatable<ContaExtratoCredito>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaExtratoCredito" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="quotaName">quotaName.</param>
        /// <param name="movementType">movementType.</param>
        /// <param name="credits">credits.</param>
        /// <param name="documentId">documentId.</param>
        /// <param name="arquivoId">arquivoId.</param>
        /// <param name="httpMethod">httpMethod.</param>
        /// <param name="uri">uri.</param>
        public ContaExtratoCredito(string tenantId = default(string), DateTime createdAt = default(DateTime), string quotaName = default(string), string movementType = default(string), decimal credits = default(decimal), string documentId = default(string), string arquivoId = default(string), string httpMethod = default(string), string uri = default(string))
        {
            this.tenant_id = tenantId;
            this.created_at = createdAt;
            this.quota_name = quotaName;
            this.movement_type = movementType;
            this.credits = credits;
            this.document_id = documentId;
            this.arquivo_id = arquivoId;
            this.http_method = httpMethod;
            this.uri = uri;
        }

        /// <summary>
        /// Gets or Sets tenant_id
        /// </summary>
        [DataMember(Name = "tenant_id", EmitDefaultValue = false)]
        public string tenant_id { get; set; }

        /// <summary>
        /// Gets or Sets created_at
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime created_at { get; set; }

        /// <summary>
        /// Gets or Sets quota_name
        /// </summary>
        [DataMember(Name = "quota_name", EmitDefaultValue = false)]
        public string quota_name { get; set; }

        /// <summary>
        /// Gets or Sets movement_type
        /// </summary>
        [DataMember(Name = "movement_type", EmitDefaultValue = false)]
        public string movement_type { get; set; }

        /// <summary>
        /// Gets or Sets credits
        /// </summary>
        [DataMember(Name = "credits", EmitDefaultValue = false)]
        public decimal credits { get; set; }

        /// <summary>
        /// Gets or Sets document_id
        /// </summary>
        [DataMember(Name = "document_id", EmitDefaultValue = false)]
        public string document_id { get; set; }

        /// <summary>
        /// Gets or Sets arquivo_id
        /// </summary>
        [DataMember(Name = "arquivo_id", EmitDefaultValue = false)]
        public string arquivo_id { get; set; }

        /// <summary>
        /// Gets or Sets http_method
        /// </summary>
        [DataMember(Name = "http_method", EmitDefaultValue = false)]
        public string http_method { get; set; }

        /// <summary>
        /// Gets or Sets uri
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContaExtratoCredito {\n");
            sb.Append("  tenant_id: ").Append(tenant_id).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  quota_name: ").Append(quota_name).Append("\n");
            sb.Append("  movement_type: ").Append(movement_type).Append("\n");
            sb.Append("  credits: ").Append(credits).Append("\n");
            sb.Append("  document_id: ").Append(document_id).Append("\n");
            sb.Append("  arquivo_id: ").Append(arquivo_id).Append("\n");
            sb.Append("  http_method: ").Append(http_method).Append("\n");
            sb.Append("  uri: ").Append(uri).Append("\n");
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
            return this.Equals(input as ContaExtratoCredito);
        }

        /// <summary>
        /// Returns true if ContaExtratoCredito instances are equal
        /// </summary>
        /// <param name="input">Instance of ContaExtratoCredito to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaExtratoCredito input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tenant_id == input.tenant_id ||
                    (this.tenant_id != null &&
                    this.tenant_id.Equals(input.tenant_id))
                ) && 
                (
                    this.created_at == input.created_at ||
                    (this.created_at != null &&
                    this.created_at.Equals(input.created_at))
                ) && 
                (
                    this.quota_name == input.quota_name ||
                    (this.quota_name != null &&
                    this.quota_name.Equals(input.quota_name))
                ) && 
                (
                    this.movement_type == input.movement_type ||
                    (this.movement_type != null &&
                    this.movement_type.Equals(input.movement_type))
                ) && 
                (
                    this.credits == input.credits ||
                    this.credits.Equals(input.credits)
                ) && 
                (
                    this.document_id == input.document_id ||
                    (this.document_id != null &&
                    this.document_id.Equals(input.document_id))
                ) && 
                (
                    this.arquivo_id == input.arquivo_id ||
                    (this.arquivo_id != null &&
                    this.arquivo_id.Equals(input.arquivo_id))
                ) && 
                (
                    this.http_method == input.http_method ||
                    (this.http_method != null &&
                    this.http_method.Equals(input.http_method))
                ) && 
                (
                    this.uri == input.uri ||
                    (this.uri != null &&
                    this.uri.Equals(input.uri))
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
                if (this.tenant_id != null)
                {
                    hashCode = (hashCode * 59) + this.tenant_id.GetHashCode();
                }
                if (this.created_at != null)
                {
                    hashCode = (hashCode * 59) + this.created_at.GetHashCode();
                }
                if (this.quota_name != null)
                {
                    hashCode = (hashCode * 59) + this.quota_name.GetHashCode();
                }
                if (this.movement_type != null)
                {
                    hashCode = (hashCode * 59) + this.movement_type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.credits.GetHashCode();
                if (this.document_id != null)
                {
                    hashCode = (hashCode * 59) + this.document_id.GetHashCode();
                }
                if (this.arquivo_id != null)
                {
                    hashCode = (hashCode * 59) + this.arquivo_id.GetHashCode();
                }
                if (this.http_method != null)
                {
                    hashCode = (hashCode * 59) + this.http_method.GetHashCode();
                }
                if (this.uri != null)
                {
                    hashCode = (hashCode * 59) + this.uri.GetHashCode();
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
