# ACBrAPI.Sdk.Model.NfeSefazDet
Dados dos detalhes da NF-e.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**nItem** | **int?** | Número do item do NF. | 
**prod** | [**NfeSefazProd**](NfeSefazProd.md) |  | 
**imposto** | [**NfeSefazImposto**](NfeSefazImposto.md) |  | 
**impostoDevol** | [**NfeSefazImpostoDevol**](NfeSefazImpostoDevol.md) |  | [optional] 
**infAdProd** | **string** | Informações adicionais do produto (norma referenciada, informações complementares, etc). | [optional] 
**obsItem** | [**NfeSefazObsItem**](NfeSefazObsItem.md) |  | [optional] 
**vItem** | **decimal?** | Valor total do Item, correspondente à sua participação no total da nota. A soma dos itens deverá corresponder ao total da nota. | [optional] 
**DFeReferenciado** | [**NfeSefazDFeReferenciado**](NfeSefazDFeReferenciado.md) |  | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

