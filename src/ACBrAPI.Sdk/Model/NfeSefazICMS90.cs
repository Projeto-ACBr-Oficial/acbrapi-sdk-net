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
    /// Tributação pelo ICMS  * 90 - Outras
    /// </summary>
    [DataContract(Name = "NfeSefazICMS90")]
    public partial class NfeSefazICMS90 : IEquatable<NfeSefazICMS90>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS90" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeSefazICMS90() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeSefazICMS90" /> class.
        /// </summary>
        /// <param name="orig">Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%. (required).</param>
        /// <param name="cST">Tributção pelo ICMS  * 90 - Outras (required).</param>
        /// <param name="modBC">Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação.</param>
        /// <param name="vBC">Valor da BC do ICMS..</param>
        /// <param name="pRedBC">Percentual de redução da BC..</param>
        /// <param name="cBenefRBC">Código de Benefício Fiscal na UF aplicado ao item quando houver RBC..</param>
        /// <param name="pICMS">Alíquota do ICMS..</param>
        /// <param name="vICMSOp">Valor do ICMS da Operação..</param>
        /// <param name="pDif">Percentual do diferemento..</param>
        /// <param name="vICMSDif">Valor do ICMS da diferido..</param>
        /// <param name="vICMS">Valor do ICMS..</param>
        /// <param name="vBCFCP">Valor da Base de cálculo do FCP..</param>
        /// <param name="pFCP">Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="vFCP">Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="pFCPDif">Percentual do diferimento do ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="vFCPDif">Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) diferido..</param>
        /// <param name="vFCPEfet">Valor efetivo do ICMS relativo ao Fundo de Combate à Pobreza (FCP)..</param>
        /// <param name="modBCST">Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor)  * 6 - Valor da Operação.</param>
        /// <param name="pMVAST">Percentual da Margem de Valor Adicionado ICMS ST..</param>
        /// <param name="pRedBCST">Percentual de redução da BC ICMS ST..</param>
        /// <param name="vBCST">Valor da BC do ICMS ST..</param>
        /// <param name="pICMSST">Alíquota do ICMS ST..</param>
        /// <param name="vICMSST">Valor do ICMS ST..</param>
        /// <param name="vBCFCPST">Valor da Base de cálculo do FCP..</param>
        /// <param name="pFCPST">Percentual de FCP retido por substituição tributária..</param>
        /// <param name="vFCPST">Valor do FCP retido por substituição tributária..</param>
        /// <param name="vICMSDeson">Valor do ICMS de desoneração..</param>
        /// <param name="motDesICMS">Motivo da desoneração do ICMS:3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário.</param>
        /// <param name="indDeduzDeson">Indica se o valor do ICMS desonerado (vICMSDeson) deduz do valor do item (vProd):  * 0 - Valor do ICMS desonerado (vICMSDeson) não deduz do valor do item (vProd) / total da NF-e  * 1 - Valor do ICMS desonerado (vICMSDeson) deduz do valor do item (vProd) / total da NF-e.</param>
        /// <param name="vICMSSTDeson">Valor do ICMS-ST desonerado..</param>
        /// <param name="motDesICMSST">Motivo da desoneração do ICMS-ST: 3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário.</param>
        public NfeSefazICMS90(int? orig = default(int?), string cST = default(string), int? modBC = default(int?), decimal? vBC = default(decimal?), decimal? pRedBC = default(decimal?), string cBenefRBC = default(string), decimal? pICMS = default(decimal?), decimal? vICMSOp = default(decimal?), decimal? pDif = default(decimal?), decimal? vICMSDif = default(decimal?), decimal? vICMS = default(decimal?), decimal? vBCFCP = default(decimal?), decimal? pFCP = default(decimal?), decimal? vFCP = default(decimal?), decimal? pFCPDif = default(decimal?), decimal? vFCPDif = default(decimal?), decimal? vFCPEfet = default(decimal?), int? modBCST = default(int?), decimal? pMVAST = default(decimal?), decimal? pRedBCST = default(decimal?), decimal? vBCST = default(decimal?), decimal? pICMSST = default(decimal?), decimal? vICMSST = default(decimal?), decimal? vBCFCPST = default(decimal?), decimal? pFCPST = default(decimal?), decimal? vFCPST = default(decimal?), decimal? vICMSDeson = default(decimal?), int? motDesICMS = default(int?), int? indDeduzDeson = default(int?), decimal? vICMSSTDeson = default(decimal?), int? motDesICMSST = default(int?))
        {
            // to ensure "orig" is required (not null)
            if (orig == null)
            {
                throw new ArgumentNullException("orig is a required property for NfeSefazICMS90 and cannot be null");
            }
            this.orig = orig;
            // to ensure "cST" is required (not null)
            if (cST == null)
            {
                throw new ArgumentNullException("cST is a required property for NfeSefazICMS90 and cannot be null");
            }
            this.CST = cST;
            this.modBC = modBC;
            this.vBC = vBC;
            this.pRedBC = pRedBC;
            this.cBenefRBC = cBenefRBC;
            this.pICMS = pICMS;
            this.vICMSOp = vICMSOp;
            this.pDif = pDif;
            this.vICMSDif = vICMSDif;
            this.vICMS = vICMS;
            this.vBCFCP = vBCFCP;
            this.pFCP = pFCP;
            this.vFCP = vFCP;
            this.pFCPDif = pFCPDif;
            this.vFCPDif = vFCPDif;
            this.vFCPEfet = vFCPEfet;
            this.modBCST = modBCST;
            this.pMVAST = pMVAST;
            this.pRedBCST = pRedBCST;
            this.vBCST = vBCST;
            this.pICMSST = pICMSST;
            this.vICMSST = vICMSST;
            this.vBCFCPST = vBCFCPST;
            this.pFCPST = pFCPST;
            this.vFCPST = vFCPST;
            this.vICMSDeson = vICMSDeson;
            this.motDesICMS = motDesICMS;
            this.indDeduzDeson = indDeduzDeson;
            this.vICMSSTDeson = vICMSSTDeson;
            this.motDesICMSST = motDesICMSST;
        }

        /// <summary>
        /// Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.
        /// </summary>
        /// <value>Origem da mercadoria:  * 0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8;  * 1 - Estrangeira - Importação direta, exceto a indicada no código 6;  * 2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7;  * 3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%% e inferior ou igual a 70%%;  * 4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes;  * 5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%%;  * 6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural;  * 7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural;  * 8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%%.</value>
        [DataMember(Name = "orig", IsRequired = true, EmitDefaultValue = true)]
        public int? orig { get; set; }

        /// <summary>
        /// Tributção pelo ICMS  * 90 - Outras
        /// </summary>
        /// <value>Tributção pelo ICMS  * 90 - Outras</value>
        [DataMember(Name = "CST", IsRequired = true, EmitDefaultValue = true)]
        public string CST { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS:  * 0 - Margem Valor Agregado (%%)  * 1 - Pauta (valor)  * 2 - Preço Tabelado Máximo (valor)  * 3 - Valor da Operação</value>
        [DataMember(Name = "modBC", EmitDefaultValue = true)]
        public int? modBC { get; set; }

        /// <summary>
        /// Valor da BC do ICMS.
        /// </summary>
        /// <value>Valor da BC do ICMS.</value>
        [DataMember(Name = "vBC", EmitDefaultValue = true)]
        public decimal? vBC { get; set; }

        /// <summary>
        /// Percentual de redução da BC.
        /// </summary>
        /// <value>Percentual de redução da BC.</value>
        [DataMember(Name = "pRedBC", EmitDefaultValue = true)]
        public decimal? pRedBC { get; set; }

        /// <summary>
        /// Código de Benefício Fiscal na UF aplicado ao item quando houver RBC.
        /// </summary>
        /// <value>Código de Benefício Fiscal na UF aplicado ao item quando houver RBC.</value>
        [DataMember(Name = "cBenefRBC", EmitDefaultValue = true)]
        public string cBenefRBC { get; set; }

        /// <summary>
        /// Alíquota do ICMS.
        /// </summary>
        /// <value>Alíquota do ICMS.</value>
        [DataMember(Name = "pICMS", EmitDefaultValue = true)]
        public decimal? pICMS { get; set; }

        /// <summary>
        /// Valor do ICMS da Operação.
        /// </summary>
        /// <value>Valor do ICMS da Operação.</value>
        [DataMember(Name = "vICMSOp", EmitDefaultValue = true)]
        public decimal? vICMSOp { get; set; }

        /// <summary>
        /// Percentual do diferemento.
        /// </summary>
        /// <value>Percentual do diferemento.</value>
        [DataMember(Name = "pDif", EmitDefaultValue = true)]
        public decimal? pDif { get; set; }

        /// <summary>
        /// Valor do ICMS da diferido.
        /// </summary>
        /// <value>Valor do ICMS da diferido.</value>
        [DataMember(Name = "vICMSDif", EmitDefaultValue = true)]
        public decimal? vICMSDif { get; set; }

        /// <summary>
        /// Valor do ICMS.
        /// </summary>
        /// <value>Valor do ICMS.</value>
        [DataMember(Name = "vICMS", EmitDefaultValue = true)]
        public decimal? vICMS { get; set; }

        /// <summary>
        /// Valor da Base de cálculo do FCP.
        /// </summary>
        /// <value>Valor da Base de cálculo do FCP.</value>
        [DataMember(Name = "vBCFCP", EmitDefaultValue = true)]
        public decimal? vBCFCP { get; set; }

        /// <summary>
        /// Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        /// <value>Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP).</value>
        [DataMember(Name = "pFCP", EmitDefaultValue = true)]
        public decimal? pFCP { get; set; }

        /// <summary>
        /// Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        /// <value>Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP).</value>
        [DataMember(Name = "vFCP", EmitDefaultValue = true)]
        public decimal? vFCP { get; set; }

        /// <summary>
        /// Percentual do diferimento do ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        /// <value>Percentual do diferimento do ICMS relativo ao Fundo de Combate à Pobreza (FCP).</value>
        [DataMember(Name = "pFCPDif", EmitDefaultValue = true)]
        public decimal? pFCPDif { get; set; }

        /// <summary>
        /// Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) diferido.
        /// </summary>
        /// <value>Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) diferido.</value>
        [DataMember(Name = "vFCPDif", EmitDefaultValue = true)]
        public decimal? vFCPDif { get; set; }

        /// <summary>
        /// Valor efetivo do ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        /// <value>Valor efetivo do ICMS relativo ao Fundo de Combate à Pobreza (FCP).</value>
        [DataMember(Name = "vFCPEfet", EmitDefaultValue = true)]
        public decimal? vFCPEfet { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor)  * 6 - Valor da Operação
        /// </summary>
        /// <value>Modalidade de determinação da BC do ICMS ST:  * 0 - Preço tabelado ou máximo  sugerido  * 1 - Lista Negativa (valor)  * 2 - Lista Positiva (valor)  * 3 - Lista Neutra (valor)  * 4 - Margem Valor Agregado (%%)  * 5 - Pauta (valor)  * 6 - Valor da Operação</value>
        [DataMember(Name = "modBCST", EmitDefaultValue = true)]
        public int? modBCST { get; set; }

        /// <summary>
        /// Percentual da Margem de Valor Adicionado ICMS ST.
        /// </summary>
        /// <value>Percentual da Margem de Valor Adicionado ICMS ST.</value>
        [DataMember(Name = "pMVAST", EmitDefaultValue = true)]
        public decimal? pMVAST { get; set; }

        /// <summary>
        /// Percentual de redução da BC ICMS ST.
        /// </summary>
        /// <value>Percentual de redução da BC ICMS ST.</value>
        [DataMember(Name = "pRedBCST", EmitDefaultValue = true)]
        public decimal? pRedBCST { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST.
        /// </summary>
        /// <value>Valor da BC do ICMS ST.</value>
        [DataMember(Name = "vBCST", EmitDefaultValue = true)]
        public decimal? vBCST { get; set; }

        /// <summary>
        /// Alíquota do ICMS ST.
        /// </summary>
        /// <value>Alíquota do ICMS ST.</value>
        [DataMember(Name = "pICMSST", EmitDefaultValue = true)]
        public decimal? pICMSST { get; set; }

        /// <summary>
        /// Valor do ICMS ST.
        /// </summary>
        /// <value>Valor do ICMS ST.</value>
        [DataMember(Name = "vICMSST", EmitDefaultValue = true)]
        public decimal? vICMSST { get; set; }

        /// <summary>
        /// Valor da Base de cálculo do FCP.
        /// </summary>
        /// <value>Valor da Base de cálculo do FCP.</value>
        [DataMember(Name = "vBCFCPST", EmitDefaultValue = true)]
        public decimal? vBCFCPST { get; set; }

        /// <summary>
        /// Percentual de FCP retido por substituição tributária.
        /// </summary>
        /// <value>Percentual de FCP retido por substituição tributária.</value>
        [DataMember(Name = "pFCPST", EmitDefaultValue = true)]
        public decimal? pFCPST { get; set; }

        /// <summary>
        /// Valor do FCP retido por substituição tributária.
        /// </summary>
        /// <value>Valor do FCP retido por substituição tributária.</value>
        [DataMember(Name = "vFCPST", EmitDefaultValue = true)]
        public decimal? vFCPST { get; set; }

        /// <summary>
        /// Valor do ICMS de desoneração.
        /// </summary>
        /// <value>Valor do ICMS de desoneração.</value>
        [DataMember(Name = "vICMSDeson", EmitDefaultValue = true)]
        public decimal? vICMSDeson { get; set; }

        /// <summary>
        /// Motivo da desoneração do ICMS:3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário
        /// </summary>
        /// <value>Motivo da desoneração do ICMS:3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário</value>
        [DataMember(Name = "motDesICMS", EmitDefaultValue = true)]
        public int? motDesICMS { get; set; }

        /// <summary>
        /// Indica se o valor do ICMS desonerado (vICMSDeson) deduz do valor do item (vProd):  * 0 - Valor do ICMS desonerado (vICMSDeson) não deduz do valor do item (vProd) / total da NF-e  * 1 - Valor do ICMS desonerado (vICMSDeson) deduz do valor do item (vProd) / total da NF-e
        /// </summary>
        /// <value>Indica se o valor do ICMS desonerado (vICMSDeson) deduz do valor do item (vProd):  * 0 - Valor do ICMS desonerado (vICMSDeson) não deduz do valor do item (vProd) / total da NF-e  * 1 - Valor do ICMS desonerado (vICMSDeson) deduz do valor do item (vProd) / total da NF-e</value>
        [DataMember(Name = "indDeduzDeson", EmitDefaultValue = true)]
        public int? indDeduzDeson { get; set; }

        /// <summary>
        /// Valor do ICMS-ST desonerado.
        /// </summary>
        /// <value>Valor do ICMS-ST desonerado.</value>
        [DataMember(Name = "vICMSSTDeson", EmitDefaultValue = true)]
        public decimal? vICMSSTDeson { get; set; }

        /// <summary>
        /// Motivo da desoneração do ICMS-ST: 3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário
        /// </summary>
        /// <value>Motivo da desoneração do ICMS-ST: 3-Uso na agropecuária  * 9 - Outros  * 12 - Fomento agropecuário</value>
        [DataMember(Name = "motDesICMSST", EmitDefaultValue = true)]
        public int? motDesICMSST { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NfeSefazICMS90 {\n");
            sb.Append("  orig: ").Append(orig).Append("\n");
            sb.Append("  CST: ").Append(CST).Append("\n");
            sb.Append("  modBC: ").Append(modBC).Append("\n");
            sb.Append("  vBC: ").Append(vBC).Append("\n");
            sb.Append("  pRedBC: ").Append(pRedBC).Append("\n");
            sb.Append("  cBenefRBC: ").Append(cBenefRBC).Append("\n");
            sb.Append("  pICMS: ").Append(pICMS).Append("\n");
            sb.Append("  vICMSOp: ").Append(vICMSOp).Append("\n");
            sb.Append("  pDif: ").Append(pDif).Append("\n");
            sb.Append("  vICMSDif: ").Append(vICMSDif).Append("\n");
            sb.Append("  vICMS: ").Append(vICMS).Append("\n");
            sb.Append("  vBCFCP: ").Append(vBCFCP).Append("\n");
            sb.Append("  pFCP: ").Append(pFCP).Append("\n");
            sb.Append("  vFCP: ").Append(vFCP).Append("\n");
            sb.Append("  pFCPDif: ").Append(pFCPDif).Append("\n");
            sb.Append("  vFCPDif: ").Append(vFCPDif).Append("\n");
            sb.Append("  vFCPEfet: ").Append(vFCPEfet).Append("\n");
            sb.Append("  modBCST: ").Append(modBCST).Append("\n");
            sb.Append("  pMVAST: ").Append(pMVAST).Append("\n");
            sb.Append("  pRedBCST: ").Append(pRedBCST).Append("\n");
            sb.Append("  vBCST: ").Append(vBCST).Append("\n");
            sb.Append("  pICMSST: ").Append(pICMSST).Append("\n");
            sb.Append("  vICMSST: ").Append(vICMSST).Append("\n");
            sb.Append("  vBCFCPST: ").Append(vBCFCPST).Append("\n");
            sb.Append("  pFCPST: ").Append(pFCPST).Append("\n");
            sb.Append("  vFCPST: ").Append(vFCPST).Append("\n");
            sb.Append("  vICMSDeson: ").Append(vICMSDeson).Append("\n");
            sb.Append("  motDesICMS: ").Append(motDesICMS).Append("\n");
            sb.Append("  indDeduzDeson: ").Append(indDeduzDeson).Append("\n");
            sb.Append("  vICMSSTDeson: ").Append(vICMSSTDeson).Append("\n");
            sb.Append("  motDesICMSST: ").Append(motDesICMSST).Append("\n");
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
            return this.Equals(input as NfeSefazICMS90);
        }

        /// <summary>
        /// Returns true if NfeSefazICMS90 instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeSefazICMS90 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeSefazICMS90 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.orig == input.orig ||
                    (this.orig != null &&
                    this.orig.Equals(input.orig))
                ) && 
                (
                    this.CST == input.CST ||
                    (this.CST != null &&
                    this.CST.Equals(input.CST))
                ) && 
                (
                    this.modBC == input.modBC ||
                    (this.modBC != null &&
                    this.modBC.Equals(input.modBC))
                ) && 
                (
                    this.vBC == input.vBC ||
                    (this.vBC != null &&
                    this.vBC.Equals(input.vBC))
                ) && 
                (
                    this.pRedBC == input.pRedBC ||
                    (this.pRedBC != null &&
                    this.pRedBC.Equals(input.pRedBC))
                ) && 
                (
                    this.cBenefRBC == input.cBenefRBC ||
                    (this.cBenefRBC != null &&
                    this.cBenefRBC.Equals(input.cBenefRBC))
                ) && 
                (
                    this.pICMS == input.pICMS ||
                    (this.pICMS != null &&
                    this.pICMS.Equals(input.pICMS))
                ) && 
                (
                    this.vICMSOp == input.vICMSOp ||
                    (this.vICMSOp != null &&
                    this.vICMSOp.Equals(input.vICMSOp))
                ) && 
                (
                    this.pDif == input.pDif ||
                    (this.pDif != null &&
                    this.pDif.Equals(input.pDif))
                ) && 
                (
                    this.vICMSDif == input.vICMSDif ||
                    (this.vICMSDif != null &&
                    this.vICMSDif.Equals(input.vICMSDif))
                ) && 
                (
                    this.vICMS == input.vICMS ||
                    (this.vICMS != null &&
                    this.vICMS.Equals(input.vICMS))
                ) && 
                (
                    this.vBCFCP == input.vBCFCP ||
                    (this.vBCFCP != null &&
                    this.vBCFCP.Equals(input.vBCFCP))
                ) && 
                (
                    this.pFCP == input.pFCP ||
                    (this.pFCP != null &&
                    this.pFCP.Equals(input.pFCP))
                ) && 
                (
                    this.vFCP == input.vFCP ||
                    (this.vFCP != null &&
                    this.vFCP.Equals(input.vFCP))
                ) && 
                (
                    this.pFCPDif == input.pFCPDif ||
                    (this.pFCPDif != null &&
                    this.pFCPDif.Equals(input.pFCPDif))
                ) && 
                (
                    this.vFCPDif == input.vFCPDif ||
                    (this.vFCPDif != null &&
                    this.vFCPDif.Equals(input.vFCPDif))
                ) && 
                (
                    this.vFCPEfet == input.vFCPEfet ||
                    (this.vFCPEfet != null &&
                    this.vFCPEfet.Equals(input.vFCPEfet))
                ) && 
                (
                    this.modBCST == input.modBCST ||
                    (this.modBCST != null &&
                    this.modBCST.Equals(input.modBCST))
                ) && 
                (
                    this.pMVAST == input.pMVAST ||
                    (this.pMVAST != null &&
                    this.pMVAST.Equals(input.pMVAST))
                ) && 
                (
                    this.pRedBCST == input.pRedBCST ||
                    (this.pRedBCST != null &&
                    this.pRedBCST.Equals(input.pRedBCST))
                ) && 
                (
                    this.vBCST == input.vBCST ||
                    (this.vBCST != null &&
                    this.vBCST.Equals(input.vBCST))
                ) && 
                (
                    this.pICMSST == input.pICMSST ||
                    (this.pICMSST != null &&
                    this.pICMSST.Equals(input.pICMSST))
                ) && 
                (
                    this.vICMSST == input.vICMSST ||
                    (this.vICMSST != null &&
                    this.vICMSST.Equals(input.vICMSST))
                ) && 
                (
                    this.vBCFCPST == input.vBCFCPST ||
                    (this.vBCFCPST != null &&
                    this.vBCFCPST.Equals(input.vBCFCPST))
                ) && 
                (
                    this.pFCPST == input.pFCPST ||
                    (this.pFCPST != null &&
                    this.pFCPST.Equals(input.pFCPST))
                ) && 
                (
                    this.vFCPST == input.vFCPST ||
                    (this.vFCPST != null &&
                    this.vFCPST.Equals(input.vFCPST))
                ) && 
                (
                    this.vICMSDeson == input.vICMSDeson ||
                    (this.vICMSDeson != null &&
                    this.vICMSDeson.Equals(input.vICMSDeson))
                ) && 
                (
                    this.motDesICMS == input.motDesICMS ||
                    (this.motDesICMS != null &&
                    this.motDesICMS.Equals(input.motDesICMS))
                ) && 
                (
                    this.indDeduzDeson == input.indDeduzDeson ||
                    (this.indDeduzDeson != null &&
                    this.indDeduzDeson.Equals(input.indDeduzDeson))
                ) && 
                (
                    this.vICMSSTDeson == input.vICMSSTDeson ||
                    (this.vICMSSTDeson != null &&
                    this.vICMSSTDeson.Equals(input.vICMSSTDeson))
                ) && 
                (
                    this.motDesICMSST == input.motDesICMSST ||
                    (this.motDesICMSST != null &&
                    this.motDesICMSST.Equals(input.motDesICMSST))
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
                if (this.orig != null)
                {
                    hashCode = (hashCode * 59) + this.orig.GetHashCode();
                }
                if (this.CST != null)
                {
                    hashCode = (hashCode * 59) + this.CST.GetHashCode();
                }
                if (this.modBC != null)
                {
                    hashCode = (hashCode * 59) + this.modBC.GetHashCode();
                }
                if (this.vBC != null)
                {
                    hashCode = (hashCode * 59) + this.vBC.GetHashCode();
                }
                if (this.pRedBC != null)
                {
                    hashCode = (hashCode * 59) + this.pRedBC.GetHashCode();
                }
                if (this.cBenefRBC != null)
                {
                    hashCode = (hashCode * 59) + this.cBenefRBC.GetHashCode();
                }
                if (this.pICMS != null)
                {
                    hashCode = (hashCode * 59) + this.pICMS.GetHashCode();
                }
                if (this.vICMSOp != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSOp.GetHashCode();
                }
                if (this.pDif != null)
                {
                    hashCode = (hashCode * 59) + this.pDif.GetHashCode();
                }
                if (this.vICMSDif != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSDif.GetHashCode();
                }
                if (this.vICMS != null)
                {
                    hashCode = (hashCode * 59) + this.vICMS.GetHashCode();
                }
                if (this.vBCFCP != null)
                {
                    hashCode = (hashCode * 59) + this.vBCFCP.GetHashCode();
                }
                if (this.pFCP != null)
                {
                    hashCode = (hashCode * 59) + this.pFCP.GetHashCode();
                }
                if (this.vFCP != null)
                {
                    hashCode = (hashCode * 59) + this.vFCP.GetHashCode();
                }
                if (this.pFCPDif != null)
                {
                    hashCode = (hashCode * 59) + this.pFCPDif.GetHashCode();
                }
                if (this.vFCPDif != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPDif.GetHashCode();
                }
                if (this.vFCPEfet != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPEfet.GetHashCode();
                }
                if (this.modBCST != null)
                {
                    hashCode = (hashCode * 59) + this.modBCST.GetHashCode();
                }
                if (this.pMVAST != null)
                {
                    hashCode = (hashCode * 59) + this.pMVAST.GetHashCode();
                }
                if (this.pRedBCST != null)
                {
                    hashCode = (hashCode * 59) + this.pRedBCST.GetHashCode();
                }
                if (this.vBCST != null)
                {
                    hashCode = (hashCode * 59) + this.vBCST.GetHashCode();
                }
                if (this.pICMSST != null)
                {
                    hashCode = (hashCode * 59) + this.pICMSST.GetHashCode();
                }
                if (this.vICMSST != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSST.GetHashCode();
                }
                if (this.vBCFCPST != null)
                {
                    hashCode = (hashCode * 59) + this.vBCFCPST.GetHashCode();
                }
                if (this.pFCPST != null)
                {
                    hashCode = (hashCode * 59) + this.pFCPST.GetHashCode();
                }
                if (this.vFCPST != null)
                {
                    hashCode = (hashCode * 59) + this.vFCPST.GetHashCode();
                }
                if (this.vICMSDeson != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSDeson.GetHashCode();
                }
                if (this.motDesICMS != null)
                {
                    hashCode = (hashCode * 59) + this.motDesICMS.GetHashCode();
                }
                if (this.indDeduzDeson != null)
                {
                    hashCode = (hashCode * 59) + this.indDeduzDeson.GetHashCode();
                }
                if (this.vICMSSTDeson != null)
                {
                    hashCode = (hashCode * 59) + this.vICMSSTDeson.GetHashCode();
                }
                if (this.motDesICMSST != null)
                {
                    hashCode = (hashCode * 59) + this.motDesICMSST.GetHashCode();
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
            // vBC (decimal?) minimum
            if (this.vBC < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBC, must be a value greater than or equal to 0.", new [] { "vBC" });
            }

            // pRedBC (decimal?) minimum
            if (this.pRedBC < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pRedBC, must be a value greater than or equal to 0.", new [] { "pRedBC" });
            }

            // pICMS (decimal?) minimum
            if (this.pICMS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pICMS, must be a value greater than or equal to 0.", new [] { "pICMS" });
            }

            // vICMSOp (decimal?) minimum
            if (this.vICMSOp < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSOp, must be a value greater than or equal to 0.", new [] { "vICMSOp" });
            }

            // pDif (decimal?) maximum
            if (this.pDif > (decimal?)1E+2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pDif, must be a value less than or equal to 1E+2.", new [] { "pDif" });
            }

            // pDif (decimal?) minimum
            if (this.pDif < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pDif, must be a value greater than or equal to 0.", new [] { "pDif" });
            }

            // vICMSDif (decimal?) minimum
            if (this.vICMSDif < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSDif, must be a value greater than or equal to 0.", new [] { "vICMSDif" });
            }

            // vICMS (decimal?) minimum
            if (this.vICMS < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMS, must be a value greater than or equal to 0.", new [] { "vICMS" });
            }

            // vBCFCP (decimal?) minimum
            if (this.vBCFCP < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBCFCP, must be a value greater than or equal to 0.", new [] { "vBCFCP" });
            }

            // pFCP (decimal?) minimum
            if (this.pFCP < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pFCP, must be a value greater than or equal to 0.", new [] { "pFCP" });
            }

            // vFCP (decimal?) minimum
            if (this.vFCP < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFCP, must be a value greater than or equal to 0.", new [] { "vFCP" });
            }

            // pFCPDif (decimal?) minimum
            if (this.pFCPDif < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pFCPDif, must be a value greater than or equal to 0.", new [] { "pFCPDif" });
            }

            // vFCPDif (decimal?) minimum
            if (this.vFCPDif < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFCPDif, must be a value greater than or equal to 0.", new [] { "vFCPDif" });
            }

            // vFCPEfet (decimal?) minimum
            if (this.vFCPEfet < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFCPEfet, must be a value greater than or equal to 0.", new [] { "vFCPEfet" });
            }

            // pMVAST (decimal?) minimum
            if (this.pMVAST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pMVAST, must be a value greater than or equal to 0.", new [] { "pMVAST" });
            }

            // pRedBCST (decimal?) minimum
            if (this.pRedBCST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pRedBCST, must be a value greater than or equal to 0.", new [] { "pRedBCST" });
            }

            // vBCST (decimal?) minimum
            if (this.vBCST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBCST, must be a value greater than or equal to 0.", new [] { "vBCST" });
            }

            // pICMSST (decimal?) minimum
            if (this.pICMSST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pICMSST, must be a value greater than or equal to 0.", new [] { "pICMSST" });
            }

            // vICMSST (decimal?) minimum
            if (this.vICMSST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSST, must be a value greater than or equal to 0.", new [] { "vICMSST" });
            }

            // vBCFCPST (decimal?) minimum
            if (this.vBCFCPST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vBCFCPST, must be a value greater than or equal to 0.", new [] { "vBCFCPST" });
            }

            // pFCPST (decimal?) minimum
            if (this.pFCPST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for pFCPST, must be a value greater than or equal to 0.", new [] { "pFCPST" });
            }

            // vFCPST (decimal?) minimum
            if (this.vFCPST < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vFCPST, must be a value greater than or equal to 0.", new [] { "vFCPST" });
            }

            // vICMSDeson (decimal?) minimum
            if (this.vICMSDeson < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSDeson, must be a value greater than or equal to 0.", new [] { "vICMSDeson" });
            }

            // vICMSSTDeson (decimal?) minimum
            if (this.vICMSSTDeson < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for vICMSSTDeson, must be a value greater than or equal to 0.", new [] { "vICMSSTDeson" });
            }

            yield break;
        }
    }

}
