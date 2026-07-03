# ACBrAPI.Sdk.Model.RTCInfoDest
Grupo de informações relativas ao Destinatário.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | Número da inscrição no Cadastro Nacional de Pessoa Jurídica (CNPJ) do Destinatário do serviço. | [optional] 
**CPF** | **string** | Número da inscrição no Cadastro de Pessoa Física (CPF) do Destinatário do serviço. | [optional] 
**NIF** | **string** | Número de Identificação Fiscal fornecido por órgão de administração tributária no exterior. | [optional] 
**cNaoNIF** | **int?** | Motivo para não informação do NIF:  * 0 - Não informado na nota de origem  * 1 - Dispensado do NIF  * 2 - Não exigência do NIF | [optional] 
**xNome** | **string** | Nome / Nome Empresarial do do Destinatário do serviço. | 
**end** | [**Endereco**](Endereco.md) |  | [optional] 
**fone** | **string** | Número do telefone do Destinatário do serviço  (Preencher com o Código DDD + número do telefone. Nas operações com exterior é permitido informar o  código do país + código da localidade + número do telefone). | [optional] 
**email** | **string** | * E-mail do Destinatário do serviço | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

