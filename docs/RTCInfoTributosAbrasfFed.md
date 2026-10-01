# ACBrAPI.Sdk.Model.RTCInfoTributosAbrasfFed
Grupo de informações relativas aos valores da CBS.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**pCBS** | **decimal?** | Alíquota da União para CBS. | [optional] 
**pRedAliqCBS** | **decimal?** | Percentual da redução de alíquota da CBS. | [optional] 
**pAliqEfetCBS** | **decimal?** | Alíquota efetiva da CBS.  pAliqEfetCBS &#x3D; pCBS x (1 - pRedAliqCBS) x (1 - pRedutor) | [optional] 
**vCBS** | **decimal?** | Valor da CBS (R$).  vCBS &#x3D; vBC x (pCBS ou pAliqEfetCBS) | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

