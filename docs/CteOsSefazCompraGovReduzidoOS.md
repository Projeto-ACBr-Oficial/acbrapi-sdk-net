# ACBrAPI.Sdk.Model.CteOsSefazCompraGovReduzidoOS
Grupo de Compras Governamentais.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**tpEnteGov** | **int?** | Para administração pública direta e suas autarquias e fundações:  * 1 - União  * 2 - Estados  * 3 - Distrito Federal  * 4 - Municípios  * 5 - Consórcio Público  * 6 - Comitê Gestor do IBS | 
**pRedutor** | **decimal?** | Percentual de redução de aliquota em compra governamental. | 
**tpOperGov** | **int?** | Tipo da operação com ente governamental:  * 1 - Fornecimento com pagamento posterior  * 2 - Recebimento do pagamento com fornecimento já realizado  * 3 - Fornecimento com pagamento já realizado  * 4 - Recebimento do pagamento com fornecimento posterior | 
**refDFeAnt** | **List&lt;string&gt;** | Chave de acesso do documento fiscal anterior.  Deverá ser informado para tpOperGov 2 e 3 e vedado para os tipos 1 e 4.  No caso do toOperGov 2 aceitará apenas uma chave referenciada, no tipo 3 poderá aceitar múltiplas chaves  Obs: a chave de acesso deverá ser de um emitente com o mesmo CNPJ base. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

