# ACBrAPI.Sdk.Model.NfcePedidoCancelamento

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**chave_substituta** | **string** | Chave de acesso da NFC-e substituta.  Quando informada, o cancelamento é enviado à SEFAZ como evento de  \&quot;Cancelamento por substituição\&quot; (110112), no lugar do cancelamento  comum (110111). A NFC-e substituta precisa constar na API, pertencer  à mesma empresa, ter sido emitida no mesmo ambiente e estar autorizada. | [optional] 
**justificativa** | **string** | Justificativa para o cancelamento. Preencheremos automaticamente, caso esteja em branco. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

