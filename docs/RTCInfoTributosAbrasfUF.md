# ACBrAPI.Sdk.Model.RTCInfoTributosAbrasfUF
Grupo de informações relativas aos valores do IBS estadual.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**pIBSUF** | **decimal?** | Alíquota da UF para IBS. | [optional] 
**pRedAliqUF** | **decimal?** | Percentual de redução de alíquota estadual. | [optional] 
**pAliqEfetUF** | **decimal?** | Alíquota efetiva do IBS estadual.  pAliqEfetUF &#x3D; pIBSUF x (1 - pRedAliqUF) x (1 - pRedutor) | [optional] 
**vIBSUF** | **decimal?** | Valor do IBS estadual (R$).  vIBSUF &#x3D; vBC x (pIBSUF ou pAliqEfetUF) | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

