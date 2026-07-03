# ACBrAPI.Sdk.Model.CteSimpSefazEmitSimp
Identificação do Emitente do CT-e.

## Propriedades

Nome | Tipo | Descrição | Comentários
------------ | ------------- | ------------- | -------------
**CNPJ** | **string** | CNPJ do emitente.  Informar zeros não significativos.    ***Obrigatório caso o emitente seja pessoa jurídica***. | [optional] 
**CPF** | **string** | CPF do emitente.  Informar zeros não significativos.  Usar com série específica 920-969 para emitente pessoa física com inscrição estadual.    ***Obrigatório caso o emitente seja pessoa física***. | [optional] 
**IE** | **string** | Inscrição Estadual do Emitente.  A IE do emitente somente ficará sem informação para o caso do Regime Especial da NFF (tpEmis&#x3D;3).    *Caso não seja informado, será utilizado o do cadastro da empresa.* | [optional] 
**IEST** | **string** | Inscrição Estadual do Substituto Tributário. | [optional] 
**xNome** | **string** | Razão social ou Nome do emitente.    *Caso não seja informado, será utilizado o do cadastro da empresa.* | [optional] 
**xFant** | **string** | Nome fantasia.    *Caso não seja informado, será utilizado o do cadastro da empresa.* | [optional] 
**enderEmit** | [**CteSimpSefazEndeEmiSimp**](CteSimpSefazEndeEmiSimp.md) |  | [optional] 
**CRT** | **int?** | Código do Regime Tributário. Informar:  * 1 - Simples Nacional;  * 2 - Simples Nacional, excesso sublimite de receita bruta;  * 3 - Regime Normal;  * 4 - Simples Nacional - Microempreendedor Individual (MEI).    *Caso não seja informado, será utilizado o do cadastro da empresa.* | [optional] 
**ISUFEmit** | **string** | Inscrição do emitente da Suframa.  Informar o número do Cadastro do emitente na Suframa. Campo obrigatório nas operações que se beneficiam de incentivos fiscais existentes nas áreas sob controle da SUFRAMA com alíquota zero da CBS referente aos arts. 451 e 466 da LC 214/25. | [optional] 

[[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar à lista de API]](../README.md#documentation-for-api-endpoints) [[Voltar ao README]](../README.md)

