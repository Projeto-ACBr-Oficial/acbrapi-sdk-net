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
    /// Grupo relativo aos documentos referenciados nos casos de reembolso, repasse e ressarcimento que serão  considerados na base de cálculo do ISSQN, do IBS e da CBS.
    /// </summary>
    [DataContract(Name = "RTCListaDoc")]
    public partial class RTCListaDoc : IEquatable<RTCListaDoc>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCListaDoc" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCListaDoc() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCListaDoc" /> class.
        /// </summary>
        /// <param name="dFeNacional">dFeNacional.</param>
        /// <param name="docFiscalOutro">docFiscalOutro.</param>
        /// <param name="docOutro">docOutro.</param>
        /// <param name="fornec">fornec.</param>
        /// <param name="dtEmiDoc">Data da emissão do documento dedutível  Ano, mês e dia (AAAA-MM-DD). (required).</param>
        /// <param name="dtCompDoc">Data da competência do documento dedutível  Ano, mês e dia (AAAA-MM-DD). (required).</param>
        /// <param name="tpReeRepRes">Tipo de valor incluído neste documento, recebido por motivo de estarem relacionadas a operações de terceiros,  objeto de reembolso, repasse ou ressarcimento pelo recebedor, já tributados e aqui referenciados. (required).</param>
        /// <param name="xTpReeRepRes">Descrição do reembolso ou ressarcimento quando a opção é  \&quot;99 - Outros reembolsos ou ressarcimentos recebidos por valores pagos relativos a operações por conta e ordem de terceiro\&quot;..</param>
        /// <param name="vlrReeRepRes">Valor monetário (total ou parcial, conforme documento informado) utilizado para não inclusão na base de cálculo  do ISS e do IBS e da CBS da NFS-e que está sendo emitida (R$). (required).</param>
        public RTCListaDoc(RTCListaDocDFe dFeNacional = default(RTCListaDocDFe), RTCListaDocFiscalOutro docFiscalOutro = default(RTCListaDocFiscalOutro), RTCListaDocOutro docOutro = default(RTCListaDocOutro), RTCListaDocFornec fornec = default(RTCListaDocFornec), DateTime? dtEmiDoc = default(DateTime?), DateTime? dtCompDoc = default(DateTime?), string tpReeRepRes = default(string), string xTpReeRepRes = default(string), decimal? vlrReeRepRes = default(decimal?))
        {
            // to ensure "dtEmiDoc" is required (not null)
            if (dtEmiDoc == null)
            {
                throw new ArgumentNullException("dtEmiDoc is a required property for RTCListaDoc and cannot be null");
            }
            this.dtEmiDoc = dtEmiDoc;
            // to ensure "dtCompDoc" is required (not null)
            if (dtCompDoc == null)
            {
                throw new ArgumentNullException("dtCompDoc is a required property for RTCListaDoc and cannot be null");
            }
            this.dtCompDoc = dtCompDoc;
            // to ensure "tpReeRepRes" is required (not null)
            if (tpReeRepRes == null)
            {
                throw new ArgumentNullException("tpReeRepRes is a required property for RTCListaDoc and cannot be null");
            }
            this.tpReeRepRes = tpReeRepRes;
            // to ensure "vlrReeRepRes" is required (not null)
            if (vlrReeRepRes == null)
            {
                throw new ArgumentNullException("vlrReeRepRes is a required property for RTCListaDoc and cannot be null");
            }
            this.vlrReeRepRes = vlrReeRepRes;
            this.dFeNacional = dFeNacional;
            this.docFiscalOutro = docFiscalOutro;
            this.docOutro = docOutro;
            this.fornec = fornec;
            this.xTpReeRepRes = xTpReeRepRes;
        }

        /// <summary>
        /// Gets or Sets dFeNacional
        /// </summary>
        [DataMember(Name = "dFeNacional", EmitDefaultValue = false)]
        public RTCListaDocDFe dFeNacional { get; set; }

        /// <summary>
        /// Gets or Sets docFiscalOutro
        /// </summary>
        [DataMember(Name = "docFiscalOutro", EmitDefaultValue = false)]
        public RTCListaDocFiscalOutro docFiscalOutro { get; set; }

        /// <summary>
        /// Gets or Sets docOutro
        /// </summary>
        [DataMember(Name = "docOutro", EmitDefaultValue = false)]
        public RTCListaDocOutro docOutro { get; set; }

        /// <summary>
        /// Gets or Sets fornec
        /// </summary>
        [DataMember(Name = "fornec", EmitDefaultValue = false)]
        public RTCListaDocFornec fornec { get; set; }

        /// <summary>
        /// Data da emissão do documento dedutível  Ano, mês e dia (AAAA-MM-DD).
        /// </summary>
        /// <value>Data da emissão do documento dedutível  Ano, mês e dia (AAAA-MM-DD).</value>
        [DataMember(Name = "dtEmiDoc", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dtEmiDoc { get; set; }

        /// <summary>
        /// Data da competência do documento dedutível  Ano, mês e dia (AAAA-MM-DD).
        /// </summary>
        /// <value>Data da competência do documento dedutível  Ano, mês e dia (AAAA-MM-DD).</value>
        [DataMember(Name = "dtCompDoc", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? dtCompDoc { get; set; }

        /// <summary>
        /// Tipo de valor incluído neste documento, recebido por motivo de estarem relacionadas a operações de terceiros,  objeto de reembolso, repasse ou ressarcimento pelo recebedor, já tributados e aqui referenciados.
        /// </summary>
        /// <value>Tipo de valor incluído neste documento, recebido por motivo de estarem relacionadas a operações de terceiros,  objeto de reembolso, repasse ou ressarcimento pelo recebedor, já tributados e aqui referenciados.</value>
        [DataMember(Name = "tpReeRepRes", IsRequired = true, EmitDefaultValue = true)]
        public string tpReeRepRes { get; set; }

        /// <summary>
        /// Descrição do reembolso ou ressarcimento quando a opção é  \&quot;99 - Outros reembolsos ou ressarcimentos recebidos por valores pagos relativos a operações por conta e ordem de terceiro\&quot;.
        /// </summary>
        /// <value>Descrição do reembolso ou ressarcimento quando a opção é  \&quot;99 - Outros reembolsos ou ressarcimentos recebidos por valores pagos relativos a operações por conta e ordem de terceiro\&quot;.</value>
        [DataMember(Name = "xTpReeRepRes", EmitDefaultValue = true)]
        public string xTpReeRepRes { get; set; }

        /// <summary>
        /// Valor monetário (total ou parcial, conforme documento informado) utilizado para não inclusão na base de cálculo  do ISS e do IBS e da CBS da NFS-e que está sendo emitida (R$).
        /// </summary>
        /// <value>Valor monetário (total ou parcial, conforme documento informado) utilizado para não inclusão na base de cálculo  do ISS e do IBS e da CBS da NFS-e que está sendo emitida (R$).</value>
        [DataMember(Name = "vlrReeRepRes", IsRequired = true, EmitDefaultValue = true)]
        public decimal? vlrReeRepRes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCListaDoc {\n");
            sb.Append("  dFeNacional: ").Append(dFeNacional).Append("\n");
            sb.Append("  docFiscalOutro: ").Append(docFiscalOutro).Append("\n");
            sb.Append("  docOutro: ").Append(docOutro).Append("\n");
            sb.Append("  fornec: ").Append(fornec).Append("\n");
            sb.Append("  dtEmiDoc: ").Append(dtEmiDoc).Append("\n");
            sb.Append("  dtCompDoc: ").Append(dtCompDoc).Append("\n");
            sb.Append("  tpReeRepRes: ").Append(tpReeRepRes).Append("\n");
            sb.Append("  xTpReeRepRes: ").Append(xTpReeRepRes).Append("\n");
            sb.Append("  vlrReeRepRes: ").Append(vlrReeRepRes).Append("\n");
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
            return this.Equals(input as RTCListaDoc);
        }

        /// <summary>
        /// Returns true if RTCListaDoc instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCListaDoc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCListaDoc input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.dFeNacional == input.dFeNacional ||
                    (this.dFeNacional != null &&
                    this.dFeNacional.Equals(input.dFeNacional))
                ) && 
                (
                    this.docFiscalOutro == input.docFiscalOutro ||
                    (this.docFiscalOutro != null &&
                    this.docFiscalOutro.Equals(input.docFiscalOutro))
                ) && 
                (
                    this.docOutro == input.docOutro ||
                    (this.docOutro != null &&
                    this.docOutro.Equals(input.docOutro))
                ) && 
                (
                    this.fornec == input.fornec ||
                    (this.fornec != null &&
                    this.fornec.Equals(input.fornec))
                ) && 
                (
                    this.dtEmiDoc == input.dtEmiDoc ||
                    (this.dtEmiDoc != null &&
                    this.dtEmiDoc.Equals(input.dtEmiDoc))
                ) && 
                (
                    this.dtCompDoc == input.dtCompDoc ||
                    (this.dtCompDoc != null &&
                    this.dtCompDoc.Equals(input.dtCompDoc))
                ) && 
                (
                    this.tpReeRepRes == input.tpReeRepRes ||
                    (this.tpReeRepRes != null &&
                    this.tpReeRepRes.Equals(input.tpReeRepRes))
                ) && 
                (
                    this.xTpReeRepRes == input.xTpReeRepRes ||
                    (this.xTpReeRepRes != null &&
                    this.xTpReeRepRes.Equals(input.xTpReeRepRes))
                ) && 
                (
                    this.vlrReeRepRes == input.vlrReeRepRes ||
                    (this.vlrReeRepRes != null &&
                    this.vlrReeRepRes.Equals(input.vlrReeRepRes))
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
                if (this.dFeNacional != null)
                {
                    hashCode = (hashCode * 59) + this.dFeNacional.GetHashCode();
                }
                if (this.docFiscalOutro != null)
                {
                    hashCode = (hashCode * 59) + this.docFiscalOutro.GetHashCode();
                }
                if (this.docOutro != null)
                {
                    hashCode = (hashCode * 59) + this.docOutro.GetHashCode();
                }
                if (this.fornec != null)
                {
                    hashCode = (hashCode * 59) + this.fornec.GetHashCode();
                }
                if (this.dtEmiDoc != null)
                {
                    hashCode = (hashCode * 59) + this.dtEmiDoc.GetHashCode();
                }
                if (this.dtCompDoc != null)
                {
                    hashCode = (hashCode * 59) + this.dtCompDoc.GetHashCode();
                }
                if (this.tpReeRepRes != null)
                {
                    hashCode = (hashCode * 59) + this.tpReeRepRes.GetHashCode();
                }
                if (this.xTpReeRepRes != null)
                {
                    hashCode = (hashCode * 59) + this.xTpReeRepRes.GetHashCode();
                }
                if (this.vlrReeRepRes != null)
                {
                    hashCode = (hashCode * 59) + this.vlrReeRepRes.GetHashCode();
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
            // xTpReeRepRes (string) maxLength
            if (this.xTpReeRepRes != null && this.xTpReeRepRes.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xTpReeRepRes, length must be less than 150.", new [] { "xTpReeRepRes" });
            }

            // xTpReeRepRes (string) minLength
            if (this.xTpReeRepRes != null && this.xTpReeRepRes.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for xTpReeRepRes, length must be greater than 1.", new [] { "xTpReeRepRes" });
            }

            // vlrReeRepRes (decimal?) minimum
            if (this.vlrReeRepRes < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vlrReeRepRes, must be a value greater than or equal to 0.", new [] { "vlrReeRepRes" });
            }

            yield break;
        }
    }

}
