# ACBrAPI.Sdk.Model.RTCInfoTributosAbrasfMun
Grupo de informações relativas aos valores do IBS municipal.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**pIBSMun** | **decimal?** | Alíquota do Município para IBS. | [optional] 
**pRedAliqMun** | **decimal?** | Percentual de redução de alíquota municipal. | [optional] 
**pAliqEfetMun** | **decimal?** | Alíquota efetiva do IBS municipal.  pAliqEfetMun &#x3D; pIBSMun x (1 - pRedAliqMun) x (1 - pRedutor) | [optional] 
**vIBSMun** | **decimal?** | Valor do IBS municipal (R$).  vIBSMun &#x3D; vBC x (pIBSMun ou pAliqEfetMun) | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

