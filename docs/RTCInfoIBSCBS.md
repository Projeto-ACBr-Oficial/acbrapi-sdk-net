# ACBrAPI.Sdk.Model.RTCInfoIBSCBS
Grupo de informações declaradas pelo emitente referentes ao IBS e à CBS.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**finNFSe** | **int?** | Indicador da finalidade da emissão de NFS-e:  * 0 - NFS-e regular. | 
**indFinal** | **int?** | Indica operação de uso ou consumo pessoal (art. 57):  * 0 - Não;  * 1 - Sim. | 
**cIndOp** | **string** | Código indicador da operação de fornecimento, conforme tabela \&quot;código indicador de operação\&quot;. | 
**tpOper** | **int?** | Tipo de Operação com Entes Governamentais ou outros serviços sobre bens imóveis:  * 1 - Fornecimento com pagamento posterior;  * 2 - Recebimento do pagamento com fornecimento já realizado;  * 3 - Fornecimento com pagamento já realizado;  * 4 - Recebimento do pagamento com fornecimento posterior;  * 5 - Fornecimento e recebimento do pagamento concomitantes. | [optional] 
**gRefNFSe** | [**InfoRefNFSe**](InfoRefNFSe.md) |  | [optional] 
**tpEnteGov** | **int?** | Tipo de ente governamental  Para administração pública direta e suas autarquias e fundações:  * 1 - União;  * 2 - Estado;  * 3 - Distrito Federal;  * 4 - Município. | [optional] 
**indDest** | **int?** | A respeito do Destinatário dos serviços:  * 0 - O destinatário - o próprio tomador/adquirente identificado na NFS-e (tomador &#x3D; adquirente &#x3D; destinatário);  * 1 - O destinatário não - o próprio adquirente, podendo ser outra pessoa, física ou jurídica (ou equiparada), ou um estabelecimento diferente do indicado como tomador (tomador &#x3D; adquirente !&#x3D; destinatário). | 
**dest** | [**RTCInfoDest**](RTCInfoDest.md) |  | [optional] 
**imovel** | [**RTCInfoImovel**](RTCInfoImovel.md) |  | [optional] 
**valores** | [**RTCInfoValoresIBSCBS**](RTCInfoValoresIBSCBS.md) |  | 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

