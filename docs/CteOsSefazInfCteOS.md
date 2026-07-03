# ACBrAPI.Sdk.Model.CteOsSefazInfCteOS
Informações do CT-e Outros Serviços.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**versao** | **string** | Versão do leiaute.  Ex: \&quot;4.00\&quot;. | 
**Id** | **string** | Identificador da tag a ser assinada.  Informar a chave de acesso do CT-e OS e precedida do literal \&quot;CTe\&quot;.    *Geramos automaticamente quando nenhum valor é informado.* | [optional] 
**ide** | [**CteOsSefazIdeOS**](CteOsSefazIdeOS.md) |  | 
**compl** | [**CteOsSefazComplOS**](CteOsSefazComplOS.md) |  | [optional] 
**emit** | [**CteOsSefazEmitOS**](CteOsSefazEmitOS.md) |  | 
**toma** | [**CteOsSefazTomaOS**](CteOsSefazTomaOS.md) |  | [optional] 
**vPrest** | [**CteOsSefazVPrestOS**](CteOsSefazVPrestOS.md) |  | 
**imp** | [**CteOsSefazInfCteImpOS**](CteOsSefazInfCteImpOS.md) |  | 
**pgtoVinc** | [**CteOsSefazPgtoVincOS**](CteOsSefazPgtoVincOS.md) |  | [optional] 
**infCTeNorm** | [**CteOsSefazInfCTeNormOS**](CteOsSefazInfCTeNormOS.md) |  | [optional] 
**infCteComp** | [**List&lt;CteOsSefazInfCteCompOS&gt;**](CteOsSefazInfCteCompOS.md) |  | [optional] 
**autXML** | [**List&lt;CteOsSefazAutXMLOS&gt;**](CteOsSefazAutXMLOS.md) |  | [optional] 
**infRespTec** | [**CteOsSefazRespTecOS**](CteOsSefazRespTecOS.md) |  | [optional] 
**tpPagAnt** | **int?** | Tipo Pagamento ou Pagamento Antecipado.  Informar:  * 1 - Pagamento Antecipado  * 3 - Fornecimento com pagamento realizado anteriormente  Este campo é opcional e apenas deve ser informado quando pagamento que ocorre antes da prestação do serviço e na DFe de fornecimento associada a esses pagamentos, demais hipóteses de prestação de serviço sem antecipação não devem preencher. | [optional] 
**gPagAntecipado** | [**CteOsSefazGPagAntecipadoOS**](CteOsSefazGPagAntecipadoOS.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

