# ACBrAPI.Sdk.Model.CteSefazDuto
Informações do modal Dutoviário.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**vTar** | **decimal?** | Valor da tarifa. | [optional] 
**dIni** | **DateTime?** | Data de Início da prestação do serviço. | 
**dFim** | **DateTime?** | Data de Fim da prestação do serviço. | 
**classDuto** | **int?** | Classificação do Dutoviário.  Informar: 1 - Gasoduto 2 - Mineroduto 3 - Oleoduto. | [optional] 
**tpContratacao** | **int?** | Tipo de contratação do serviço de transporte (apenas para gasoduto).  Informar:  * 0 - Ponta a ponto  * 1 - Capacidade de Entrada  * 2 - Capacidade de Saida | [optional] 
**codPontoEntrada** | **string** | Código do Ponto de Entrada. | [optional] 
**codPontoSaida** | **string** | Código do Ponto de Saída. | [optional] 
**nContrato** | **string** | Número do Contrato de Capacidade. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

