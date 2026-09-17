# ACBrAPI.Sdk.Model.EmpresaConfigNfceSefaz
Configurações do CSC (Código de Segurança do Contribuinte) para emissão  da NFC-e.    Se informado `id_csc` e `csc`, será utilizada a versão 2 do QR Code da  NFC-e. Para utilizar a versão 3 do QR Code (NT 2025.001), que dispensa o  CSC, envie `id_csc` igual a 0 (zero) e `csc` como string vazia.    Observação: emitente pessoa física (CPF) utilizar sempre a versão 3 do  QR Code.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**id_csc** | **int** | Número de identificação do CSC. | [optional] 
**csc** | **string** | Código do CSC. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

