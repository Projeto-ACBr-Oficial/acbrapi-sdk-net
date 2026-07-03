# ACBrAPI.Sdk.Api.ContaApi

Todas as URIs relativas a *https://prod.acbr.api.br*

| Método | Endpoint | Descrição |
|--------|--------------|-------------|
| [**ConsultarCotaConta**](ContaApi.md#consultarcotaconta) | **GET** /conta/cotas/{nome} | Consultar o limite de uso e o consumo de uma cota específica. |
| [**ConsultarCotaPrePago**](ContaApi.md#consultarcotaprepago) | **GET** /conta/cotas/prepago | Consultar o resumo da cota de créditos pré-pagos. |
| [**ListarCotasConta**](ContaApi.md#listarcotasconta) | **GET** /conta/cotas | Consultar os limites de uso e consumo das cotas disponíveis, exceto a cota de créditos pré-pagos. |
| [**ListarExtratoCreditosConta**](ContaApi.md#listarextratocreditosconta) | **GET** /conta/extrato | Consultar o extrato de movimentação de créditos do tenant atual. |

<a name="consultarcotaconta"></a>
# **ConsultarCotaConta**
> ContaCota ConsultarCotaConta (string nome)

Consultar o limite de uso e o consumo de uma cota específica.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ACBrAPI.Sdk.Api;
using ACBrAPI.Sdk.Client;
using ACBrAPI.Sdk.Model;

namespace Example
{
    public class ConsultarCotaContaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.acbr.api.br";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ContaApi(httpClient, config, httpClientHandler);
            var nome = "nome_example";  // string | Nome da cota a ser consultada.

            try
            {
                // Consultar o limite de uso e o consumo de uma cota específica.
                ContaCota result = apiInstance.ConsultarCotaConta(nome);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContaApi.ConsultarCotaConta: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCotaContaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar o limite de uso e o consumo de uma cota específica.
    ApiResponse<ContaCota> response = apiInstance.ConsultarCotaContaWithHttpInfo(nome);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar ContaApi.ConsultarCotaContaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **nome** | **string** | Nome da cota a ser consultada. |  |

### Tipo de retorno

[**ContaCota**](ContaCota.md)

### Autorização

[oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="consultarcotaprepago"></a>
# **ConsultarCotaPrePago**
> ContaCotaPrePago ConsultarCotaPrePago ()

Consultar o resumo da cota de créditos pré-pagos.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ACBrAPI.Sdk.Api;
using ACBrAPI.Sdk.Client;
using ACBrAPI.Sdk.Model;

namespace Example
{
    public class ConsultarCotaPrePagoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.acbr.api.br";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ContaApi(httpClient, config, httpClientHandler);

            try
            {
                // Consultar o resumo da cota de créditos pré-pagos.
                ContaCotaPrePago result = apiInstance.ConsultarCotaPrePago();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContaApi.ConsultarCotaPrePago: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ConsultarCotaPrePagoWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar o resumo da cota de créditos pré-pagos.
    ApiResponse<ContaCotaPrePago> response = apiInstance.ConsultarCotaPrePagoWithHttpInfo();
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar ContaApi.ConsultarCotaPrePagoWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros
Este endpoint não recebe nenhum parâmetro.
### Tipo de retorno

[**ContaCotaPrePago**](ContaCotaPrePago.md)

### Autorização

[oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="listarcotasconta"></a>
# **ListarCotasConta**
> ContaCotaListagem ListarCotasConta ()

Consultar os limites de uso e consumo das cotas disponíveis, exceto a cota de créditos pré-pagos.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ACBrAPI.Sdk.Api;
using ACBrAPI.Sdk.Client;
using ACBrAPI.Sdk.Model;

namespace Example
{
    public class ListarCotasContaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.acbr.api.br";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ContaApi(httpClient, config, httpClientHandler);

            try
            {
                // Consultar os limites de uso e consumo das cotas disponíveis, exceto a cota de créditos pré-pagos.
                ContaCotaListagem result = apiInstance.ListarCotasConta();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContaApi.ListarCotasConta: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarCotasContaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar os limites de uso e consumo das cotas disponíveis, exceto a cota de créditos pré-pagos.
    ApiResponse<ContaCotaListagem> response = apiInstance.ListarCotasContaWithHttpInfo();
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar ContaApi.ListarCotasContaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros
Este endpoint não recebe nenhum parâmetro.
### Tipo de retorno

[**ContaCotaListagem**](ContaCotaListagem.md)

### Autorização

[oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

<a name="listarextratocreditosconta"></a>
# **ListarExtratoCreditosConta**
> ContaExtratoCreditoListagem ListarExtratoCreditosConta (string dataInicial = null, string dataFinal = null, int? top = null, int? skip = null, int? limit = null)

Consultar o extrato de movimentação de créditos do tenant atual.

### Exemplo
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ACBrAPI.Sdk.Api;
using ACBrAPI.Sdk.Client;
using ACBrAPI.Sdk.Model;

namespace Example
{
    public class ListarExtratoCreditosContaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://prod.acbr.api.br";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ContaApi(httpClient, config, httpClientHandler);
            var dataInicial = "dataInicial_example";  // string |  (optional) 
            var dataFinal = "dataFinal_example";  // string |  (optional) 
            var top = 56;  // int? |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // Consultar o extrato de movimentação de créditos do tenant atual.
                ContaExtratoCreditoListagem result = apiInstance.ListarExtratoCreditosConta(dataInicial, dataFinal, top, skip, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContaApi.ListarExtratoCreditosConta: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Usando a variante ListarExtratoCreditosContaWithHttpInfo
Esses métodos retornam um objeto ApiResponse que contêm os dados da resposta, o código de status e os headers HTTP.

```csharp
try
{
    // Consultar o extrato de movimentação de créditos do tenant atual.
    ApiResponse<ContaExtratoCreditoListagem> response = apiInstance.ListarExtratoCreditosContaWithHttpInfo(dataInicial, dataFinal, top, skip, limit);
    Debug.Write("Código de status: " + response.StatusCode);
    Debug.Write("Headers da resposta: " + response.Headers);
    Debug.Write("Conteúdo da resposta: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exceção ao chamar ContaApi.ListarExtratoCreditosContaWithHttpInfo: " + e.Message);
    Debug.Print("Código de status: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parâmetros

| Nome | Tipo | Descrição | Comentários |
|------|------|-------------|-------|
| **dataInicial** | **string** |  | [optional]  |
| **dataFinal** | **string** |  | [optional]  |
| **top** | **int?** |  | [optional]  |
| **skip** | **int?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Tipo de retorno

[**ContaExtratoCreditoListagem**](ContaExtratoCreditoListagem.md)

### Autorização

[oauth2](../README.md#oauth2)

### Headers da requisição HTTP

 - **Content-Type**: Não especificado
 - **Accept**: application/json


### Detalhes da resposta HTTP
| Código status | Descrição | Headers da resposta |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Voltar ao topo]](#) [[Voltar à listagem da API]](../README.md#documentation-for-api-endpoints) [[Voltar à lista de DTOs]](../README.md#documentation-for-models) [[Voltar ao README]](../README.md)

