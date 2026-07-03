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
    /// Grupo de informações declaradas pelo emitente referentes ao IBS e à CBS.
    /// </summary>
    [DataContract(Name = "RTCInfoIBSCBS")]
    public partial class RTCInfoIBSCBS : IEquatable<RTCInfoIBSCBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoIBSCBS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RTCInfoIBSCBS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RTCInfoIBSCBS" /> class.
        /// </summary>
        /// <param name="finNFSe">Indicador da finalidade da emissão de NFS-e:  * 0 - NFS-e regular. (required).</param>
        /// <param name="indFinal">Indica operação de uso ou consumo pessoal (art. 57):  * 0 - Não;  * 1 - Sim. (required).</param>
        /// <param name="cIndOp">Código indicador da operação de fornecimento, conforme tabela \&quot;código indicador de operação\&quot;. (required).</param>
        /// <param name="tpOper">Tipo de Operação com Entes Governamentais ou outros serviços sobre bens imóveis:  * 1 - Fornecimento com pagamento posterior;  * 2 - Recebimento do pagamento com fornecimento já realizado;  * 3 - Fornecimento com pagamento já realizado;  * 4 - Recebimento do pagamento com fornecimento posterior;  * 5 - Fornecimento e recebimento do pagamento concomitantes..</param>
        /// <param name="gRefNFSe">gRefNFSe.</param>
        /// <param name="tpEnteGov">Tipo de ente governamental  Para administração pública direta e suas autarquias e fundações:  * 1 - União;  * 2 - Estado;  * 3 - Distrito Federal;  * 4 - Município..</param>
        /// <param name="indDest">A respeito do Destinatário dos serviços:  * 0 - O destinatário - o próprio tomador/adquirente identificado na NFS-e (tomador &#x3D; adquirente &#x3D; destinatário);  * 1 - O destinatário não - o próprio adquirente, podendo ser outra pessoa, física ou jurídica (ou equiparada), ou um estabelecimento diferente do indicado como tomador (tomador &#x3D; adquirente !&#x3D; destinatário). (required).</param>
        /// <param name="dest">dest.</param>
        /// <param name="imovel">imovel.</param>
        /// <param name="valores">valores (required).</param>
        public RTCInfoIBSCBS(int? finNFSe = default(int?), int? indFinal = default(int?), string cIndOp = default(string), int? tpOper = default(int?), InfoRefNFSe gRefNFSe = default(InfoRefNFSe), int? tpEnteGov = default(int?), int? indDest = default(int?), RTCInfoDest dest = default(RTCInfoDest), RTCInfoImovel imovel = default(RTCInfoImovel), RTCInfoValoresIBSCBS valores = default(RTCInfoValoresIBSCBS))
        {
            // to ensure "finNFSe" is required (not null)
            if (finNFSe == null)
            {
                throw new ArgumentNullException("finNFSe is a required property for RTCInfoIBSCBS and cannot be null");
            }
            this.finNFSe = finNFSe;
            // to ensure "indFinal" is required (not null)
            if (indFinal == null)
            {
                throw new ArgumentNullException("indFinal is a required property for RTCInfoIBSCBS and cannot be null");
            }
            this.indFinal = indFinal;
            // to ensure "cIndOp" is required (not null)
            if (cIndOp == null)
            {
                throw new ArgumentNullException("cIndOp is a required property for RTCInfoIBSCBS and cannot be null");
            }
            this.cIndOp = cIndOp;
            // to ensure "indDest" is required (not null)
            if (indDest == null)
            {
                throw new ArgumentNullException("indDest is a required property for RTCInfoIBSCBS and cannot be null");
            }
            this.indDest = indDest;
            // to ensure "valores" is required (not null)
            if (valores == null)
            {
                throw new ArgumentNullException("valores is a required property for RTCInfoIBSCBS and cannot be null");
            }
            this.valores = valores;
            this.tpOper = tpOper;
            this.gRefNFSe = gRefNFSe;
            this.tpEnteGov = tpEnteGov;
            this.dest = dest;
            this.imovel = imovel;
        }

        /// <summary>
        /// Indicador da finalidade da emissão de NFS-e:  * 0 - NFS-e regular.
        /// </summary>
        /// <value>Indicador da finalidade da emissão de NFS-e:  * 0 - NFS-e regular.</value>
        [DataMember(Name = "finNFSe", IsRequired = true, EmitDefaultValue = true)]
        public int? finNFSe { get; set; }

        /// <summary>
        /// Indica operação de uso ou consumo pessoal (art. 57):  * 0 - Não;  * 1 - Sim.
        /// </summary>
        /// <value>Indica operação de uso ou consumo pessoal (art. 57):  * 0 - Não;  * 1 - Sim.</value>
        [DataMember(Name = "indFinal", IsRequired = true, EmitDefaultValue = true)]
        public int? indFinal { get; set; }

        /// <summary>
        /// Código indicador da operação de fornecimento, conforme tabela \&quot;código indicador de operação\&quot;.
        /// </summary>
        /// <value>Código indicador da operação de fornecimento, conforme tabela \&quot;código indicador de operação\&quot;.</value>
        [DataMember(Name = "cIndOp", IsRequired = true, EmitDefaultValue = true)]
        public string cIndOp { get; set; }

        /// <summary>
        /// Tipo de Operação com Entes Governamentais ou outros serviços sobre bens imóveis:  * 1 - Fornecimento com pagamento posterior;  * 2 - Recebimento do pagamento com fornecimento já realizado;  * 3 - Fornecimento com pagamento já realizado;  * 4 - Recebimento do pagamento com fornecimento posterior;  * 5 - Fornecimento e recebimento do pagamento concomitantes.
        /// </summary>
        /// <value>Tipo de Operação com Entes Governamentais ou outros serviços sobre bens imóveis:  * 1 - Fornecimento com pagamento posterior;  * 2 - Recebimento do pagamento com fornecimento já realizado;  * 3 - Fornecimento com pagamento já realizado;  * 4 - Recebimento do pagamento com fornecimento posterior;  * 5 - Fornecimento e recebimento do pagamento concomitantes.</value>
        [DataMember(Name = "tpOper", EmitDefaultValue = true)]
        public int? tpOper { get; set; }

        /// <summary>
        /// Gets or Sets gRefNFSe
        /// </summary>
        [DataMember(Name = "gRefNFSe", EmitDefaultValue = false)]
        public InfoRefNFSe gRefNFSe { get; set; }

        /// <summary>
        /// Tipo de ente governamental  Para administração pública direta e suas autarquias e fundações:  * 1 - União;  * 2 - Estado;  * 3 - Distrito Federal;  * 4 - Município.
        /// </summary>
        /// <value>Tipo de ente governamental  Para administração pública direta e suas autarquias e fundações:  * 1 - União;  * 2 - Estado;  * 3 - Distrito Federal;  * 4 - Município.</value>
        [DataMember(Name = "tpEnteGov", EmitDefaultValue = true)]
        public int? tpEnteGov { get; set; }

        /// <summary>
        /// A respeito do Destinatário dos serviços:  * 0 - O destinatário - o próprio tomador/adquirente identificado na NFS-e (tomador &#x3D; adquirente &#x3D; destinatário);  * 1 - O destinatário não - o próprio adquirente, podendo ser outra pessoa, física ou jurídica (ou equiparada), ou um estabelecimento diferente do indicado como tomador (tomador &#x3D; adquirente !&#x3D; destinatário).
        /// </summary>
        /// <value>A respeito do Destinatário dos serviços:  * 0 - O destinatário - o próprio tomador/adquirente identificado na NFS-e (tomador &#x3D; adquirente &#x3D; destinatário);  * 1 - O destinatário não - o próprio adquirente, podendo ser outra pessoa, física ou jurídica (ou equiparada), ou um estabelecimento diferente do indicado como tomador (tomador &#x3D; adquirente !&#x3D; destinatário).</value>
        [DataMember(Name = "indDest", IsRequired = true, EmitDefaultValue = true)]
        public int? indDest { get; set; }

        /// <summary>
        /// Gets or Sets dest
        /// </summary>
        [DataMember(Name = "dest", EmitDefaultValue = false)]
        public RTCInfoDest dest { get; set; }

        /// <summary>
        /// Gets or Sets imovel
        /// </summary>
        [DataMember(Name = "imovel", EmitDefaultValue = false)]
        public RTCInfoImovel imovel { get; set; }

        /// <summary>
        /// Gets or Sets valores
        /// </summary>
        [DataMember(Name = "valores", IsRequired = true, EmitDefaultValue = true)]
        public RTCInfoValoresIBSCBS valores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RTCInfoIBSCBS {\n");
            sb.Append("  finNFSe: ").Append(finNFSe).Append("\n");
            sb.Append("  indFinal: ").Append(indFinal).Append("\n");
            sb.Append("  cIndOp: ").Append(cIndOp).Append("\n");
            sb.Append("  tpOper: ").Append(tpOper).Append("\n");
            sb.Append("  gRefNFSe: ").Append(gRefNFSe).Append("\n");
            sb.Append("  tpEnteGov: ").Append(tpEnteGov).Append("\n");
            sb.Append("  indDest: ").Append(indDest).Append("\n");
            sb.Append("  dest: ").Append(dest).Append("\n");
            sb.Append("  imovel: ").Append(imovel).Append("\n");
            sb.Append("  valores: ").Append(valores).Append("\n");
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
            return this.Equals(input as RTCInfoIBSCBS);
        }

        /// <summary>
        /// Returns true if RTCInfoIBSCBS instances are equal
        /// </summary>
        /// <param name="input">Instance of RTCInfoIBSCBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RTCInfoIBSCBS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.finNFSe == input.finNFSe ||
                    (this.finNFSe != null &&
                    this.finNFSe.Equals(input.finNFSe))
                ) && 
                (
                    this.indFinal == input.indFinal ||
                    (this.indFinal != null &&
                    this.indFinal.Equals(input.indFinal))
                ) && 
                (
                    this.cIndOp == input.cIndOp ||
                    (this.cIndOp != null &&
                    this.cIndOp.Equals(input.cIndOp))
                ) && 
                (
                    this.tpOper == input.tpOper ||
                    (this.tpOper != null &&
                    this.tpOper.Equals(input.tpOper))
                ) && 
                (
                    this.gRefNFSe == input.gRefNFSe ||
                    (this.gRefNFSe != null &&
                    this.gRefNFSe.Equals(input.gRefNFSe))
                ) && 
                (
                    this.tpEnteGov == input.tpEnteGov ||
                    (this.tpEnteGov != null &&
                    this.tpEnteGov.Equals(input.tpEnteGov))
                ) && 
                (
                    this.indDest == input.indDest ||
                    (this.indDest != null &&
                    this.indDest.Equals(input.indDest))
                ) && 
                (
                    this.dest == input.dest ||
                    (this.dest != null &&
                    this.dest.Equals(input.dest))
                ) && 
                (
                    this.imovel == input.imovel ||
                    (this.imovel != null &&
                    this.imovel.Equals(input.imovel))
                ) && 
                (
                    this.valores == input.valores ||
                    (this.valores != null &&
                    this.valores.Equals(input.valores))
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
                if (this.finNFSe != null)
                {
                    hashCode = (hashCode * 59) + this.finNFSe.GetHashCode();
                }
                if (this.indFinal != null)
                {
                    hashCode = (hashCode * 59) + this.indFinal.GetHashCode();
                }
                if (this.cIndOp != null)
                {
                    hashCode = (hashCode * 59) + this.cIndOp.GetHashCode();
                }
                if (this.tpOper != null)
                {
                    hashCode = (hashCode * 59) + this.tpOper.GetHashCode();
                }
                if (this.gRefNFSe != null)
                {
                    hashCode = (hashCode * 59) + this.gRefNFSe.GetHashCode();
                }
                if (this.tpEnteGov != null)
                {
                    hashCode = (hashCode * 59) + this.tpEnteGov.GetHashCode();
                }
                if (this.indDest != null)
                {
                    hashCode = (hashCode * 59) + this.indDest.GetHashCode();
                }
                if (this.dest != null)
                {
                    hashCode = (hashCode * 59) + this.dest.GetHashCode();
                }
                if (this.imovel != null)
                {
                    hashCode = (hashCode * 59) + this.imovel.GetHashCode();
                }
                if (this.valores != null)
                {
                    hashCode = (hashCode * 59) + this.valores.GetHashCode();
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
