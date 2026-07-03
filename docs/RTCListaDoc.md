# ACBrAPI.Sdk.Model.RTCListaDoc
Grupo relativo aos documentos referenciados nos casos de reembolso, repasse e ressarcimento que serão  considerados na base de cálculo do ISSQN, do IBS e da CBS.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**dFeNacional** | [**RTCListaDocDFe**](RTCListaDocDFe.md) |  | [optional] 
**docFiscalOutro** | [**RTCListaDocFiscalOutro**](RTCListaDocFiscalOutro.md) |  | [optional] 
**docOutro** | [**RTCListaDocOutro**](RTCListaDocOutro.md) |  | [optional] 
**fornec** | [**RTCListaDocFornec**](RTCListaDocFornec.md) |  | [optional] 
**dtEmiDoc** | **DateTime?** | Data da emissão do documento dedutível  Ano, mês e dia (AAAA-MM-DD). | 
**dtCompDoc** | **DateTime?** | Data da competência do documento dedutível  Ano, mês e dia (AAAA-MM-DD). | 
**tpReeRepRes** | **string** | Tipo de valor incluído neste documento, recebido por motivo de estarem relacionadas a operações de terceiros,  objeto de reembolso, repasse ou ressarcimento pelo recebedor, já tributados e aqui referenciados. | 
**xTpReeRepRes** | **string** | Descrição do reembolso ou ressarcimento quando a opção é  \&quot;99 - Outros reembolsos ou ressarcimentos recebidos por valores pagos relativos a operações por conta e ordem de terceiro\&quot;. | [optional] 
**vlrReeRepRes** | **decimal?** | Valor monetário (total ou parcial, conforme documento informado) utilizado para não inclusão na base de cálculo  do ISS e do IBS e da CBS da NFS-e que está sendo emitida (R$). | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

