/*
 * ACBr API - SDK para .NET
 * https://www.acbrapi.com.br
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using ACBrAPI.Sdk.Client;
using ACBrAPI.Sdk.Model;

namespace ACBrAPI.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEmailApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Consultar e-mail
        /// </summary>
        /// <remarks>
        /// Obtém informações detalhadas sobre o envio de um email. Este endpoint  permite rastrear todos os eventos relacionados ao email, como envio,  entrega, falhas e outros eventos relevantes.    Com este endpoint, é possível ter uma visão completa do ciclo de vida  de um email enviado, permitindo que os usuários acompanhem e analisem  o status e o histórico de eventos do email. Isso é particularmente  útil para identificar problemas de entrega e entender o comportamento  do email ao longo do tempo.
        /// </remarks>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do e-mail.    Esse parâmetro é obtido após o envio do email por qualquer endpoint da  API da Nuvem Fiscal que realize disparos de email.    Exemplos:  * &lt;a href&#x3D;\&quot;#tag/Nfe/operation/EnviarEmailNfe\&quot;&gt;Envio de XML e PDF de NF-e&lt;/a&gt;.  * &lt;a href&#x3D;\&quot;#tag/Nfce/operation/EnviarEmailNfce\&quot;&gt;Envio de XML e PDF de NFC-e&lt;/a&gt;.</param>
        /// <returns>Email</returns>
        Email ConsultarEmail(string id);

        /// <summary>
        /// Consultar e-mail
        /// </summary>
        /// <remarks>
        /// Obtém informações detalhadas sobre o envio de um email. Este endpoint  permite rastrear todos os eventos relacionados ao email, como envio,  entrega, falhas e outros eventos relevantes.    Com este endpoint, é possível ter uma visão completa do ciclo de vida  de um email enviado, permitindo que os usuários acompanhem e analisem  o status e o histórico de eventos do email. Isso é particularmente  útil para identificar problemas de entrega e entender o comportamento  do email ao longo do tempo.
        /// </remarks>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do e-mail.    Esse parâmetro é obtido após o envio do email por qualquer endpoint da  API da Nuvem Fiscal que realize disparos de email.    Exemplos:  * &lt;a href&#x3D;\&quot;#tag/Nfe/operation/EnviarEmailNfe\&quot;&gt;Envio de XML e PDF de NF-e&lt;/a&gt;.  * &lt;a href&#x3D;\&quot;#tag/Nfce/operation/EnviarEmailNfce\&quot;&gt;Envio de XML e PDF de NFC-e&lt;/a&gt;.</param>
        /// <returns>ApiResponse of Email</returns>
        ApiResponse<Email> ConsultarEmailWithHttpInfo(string id);
        /// <summary>
        /// Listar e-mails
        /// </summary>
        /// <remarks>
        /// Retorna a lista dos emails associadas à sua conta. Os e-emails são  retornados ordenados pela data da criação, com os mais recentes  aparecendo primeiro.
        /// </remarks>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtra pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="undelivered">Filtra apenas emails com problemas de entrega. (optional)</param>
        /// <param name="email">Filtra pelo endereço de e-mail do destinatário para qual o email foi enviado. (optional)</param>
        /// <returns>EmailListagem</returns>
        EmailListagem ListarEmails(string cpfCnpj, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), bool? undelivered = default(bool?), string email = default(string));

        /// <summary>
        /// Listar e-mails
        /// </summary>
        /// <remarks>
        /// Retorna a lista dos emails associadas à sua conta. Os e-emails são  retornados ordenados pela data da criação, com os mais recentes  aparecendo primeiro.
        /// </remarks>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtra pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="undelivered">Filtra apenas emails com problemas de entrega. (optional)</param>
        /// <param name="email">Filtra pelo endereço de e-mail do destinatário para qual o email foi enviado. (optional)</param>
        /// <returns>ApiResponse of EmailListagem</returns>
        ApiResponse<EmailListagem> ListarEmailsWithHttpInfo(string cpfCnpj, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), bool? undelivered = default(bool?), string email = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEmailApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Consultar e-mail
        /// </summary>
        /// <remarks>
        /// Obtém informações detalhadas sobre o envio de um email. Este endpoint  permite rastrear todos os eventos relacionados ao email, como envio,  entrega, falhas e outros eventos relevantes.    Com este endpoint, é possível ter uma visão completa do ciclo de vida  de um email enviado, permitindo que os usuários acompanhem e analisem  o status e o histórico de eventos do email. Isso é particularmente  útil para identificar problemas de entrega e entender o comportamento  do email ao longo do tempo.
        /// </remarks>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do e-mail.    Esse parâmetro é obtido após o envio do email por qualquer endpoint da  API da Nuvem Fiscal que realize disparos de email.    Exemplos:  * &lt;a href&#x3D;\&quot;#tag/Nfe/operation/EnviarEmailNfe\&quot;&gt;Envio de XML e PDF de NF-e&lt;/a&gt;.  * &lt;a href&#x3D;\&quot;#tag/Nfce/operation/EnviarEmailNfce\&quot;&gt;Envio de XML e PDF de NFC-e&lt;/a&gt;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Email</returns>
        System.Threading.Tasks.Task<Email> ConsultarEmailAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Consultar e-mail
        /// </summary>
        /// <remarks>
        /// Obtém informações detalhadas sobre o envio de um email. Este endpoint  permite rastrear todos os eventos relacionados ao email, como envio,  entrega, falhas e outros eventos relevantes.    Com este endpoint, é possível ter uma visão completa do ciclo de vida  de um email enviado, permitindo que os usuários acompanhem e analisem  o status e o histórico de eventos do email. Isso é particularmente  útil para identificar problemas de entrega e entender o comportamento  do email ao longo do tempo.
        /// </remarks>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do e-mail.    Esse parâmetro é obtido após o envio do email por qualquer endpoint da  API da Nuvem Fiscal que realize disparos de email.    Exemplos:  * &lt;a href&#x3D;\&quot;#tag/Nfe/operation/EnviarEmailNfe\&quot;&gt;Envio de XML e PDF de NF-e&lt;/a&gt;.  * &lt;a href&#x3D;\&quot;#tag/Nfce/operation/EnviarEmailNfce\&quot;&gt;Envio de XML e PDF de NFC-e&lt;/a&gt;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Email)</returns>
        System.Threading.Tasks.Task<ApiResponse<Email>> ConsultarEmailWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Listar e-mails
        /// </summary>
        /// <remarks>
        /// Retorna a lista dos emails associadas à sua conta. Os e-emails são  retornados ordenados pela data da criação, com os mais recentes  aparecendo primeiro.
        /// </remarks>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtra pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="undelivered">Filtra apenas emails com problemas de entrega. (optional)</param>
        /// <param name="email">Filtra pelo endereço de e-mail do destinatário para qual o email foi enviado. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmailListagem</returns>
        System.Threading.Tasks.Task<EmailListagem> ListarEmailsAsync(string cpfCnpj, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), bool? undelivered = default(bool?), string email = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Listar e-mails
        /// </summary>
        /// <remarks>
        /// Retorna a lista dos emails associadas à sua conta. Os e-emails são  retornados ordenados pela data da criação, com os mais recentes  aparecendo primeiro.
        /// </remarks>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtra pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="undelivered">Filtra apenas emails com problemas de entrega. (optional)</param>
        /// <param name="email">Filtra pelo endereço de e-mail do destinatário para qual o email foi enviado. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmailListagem)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailListagem>> ListarEmailsWithHttpInfoAsync(string cpfCnpj, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), bool? undelivered = default(bool?), string email = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEmailApi : IEmailApiSync, IEmailApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EmailApi : IDisposable, IEmailApi
    {
        private ACBrAPI.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public EmailApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public EmailApi(string basePath)
        {
            this.Configuration = ACBrAPI.Sdk.Client.Configuration.MergeConfigurations(
                ACBrAPI.Sdk.Client.GlobalConfiguration.Instance,
                new ACBrAPI.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new ACBrAPI.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = ACBrAPI.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public EmailApi(ACBrAPI.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ACBrAPI.Sdk.Client.Configuration.MergeConfigurations(
                ACBrAPI.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ACBrAPI.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = ACBrAPI.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public EmailApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public EmailApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = ACBrAPI.Sdk.Client.Configuration.MergeConfigurations(
                ACBrAPI.Sdk.Client.GlobalConfiguration.Instance,
                new ACBrAPI.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new ACBrAPI.Sdk.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = ACBrAPI.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public EmailApi(HttpClient client, ACBrAPI.Sdk.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = ACBrAPI.Sdk.Client.Configuration.MergeConfigurations(
                ACBrAPI.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ACBrAPI.Sdk.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = ACBrAPI.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public EmailApi(ACBrAPI.Sdk.Client.ISynchronousClient client, ACBrAPI.Sdk.Client.IAsynchronousClient asyncClient, ACBrAPI.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ACBrAPI.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public ACBrAPI.Sdk.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ACBrAPI.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ACBrAPI.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ACBrAPI.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ACBrAPI.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Consultar e-mail Obtém informações detalhadas sobre o envio de um email. Este endpoint  permite rastrear todos os eventos relacionados ao email, como envio,  entrega, falhas e outros eventos relevantes.    Com este endpoint, é possível ter uma visão completa do ciclo de vida  de um email enviado, permitindo que os usuários acompanhem e analisem  o status e o histórico de eventos do email. Isso é particularmente  útil para identificar problemas de entrega e entender o comportamento  do email ao longo do tempo.
        /// </summary>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do e-mail.    Esse parâmetro é obtido após o envio do email por qualquer endpoint da  API da Nuvem Fiscal que realize disparos de email.    Exemplos:  * &lt;a href&#x3D;\&quot;#tag/Nfe/operation/EnviarEmailNfe\&quot;&gt;Envio de XML e PDF de NF-e&lt;/a&gt;.  * &lt;a href&#x3D;\&quot;#tag/Nfce/operation/EnviarEmailNfce\&quot;&gt;Envio de XML e PDF de NFC-e&lt;/a&gt;.</param>
        /// <returns>Email</returns>
        public Email ConsultarEmail(string id)
        {
            ACBrAPI.Sdk.Client.ApiResponse<Email> localVarResponse = ConsultarEmailWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar e-mail Obtém informações detalhadas sobre o envio de um email. Este endpoint  permite rastrear todos os eventos relacionados ao email, como envio,  entrega, falhas e outros eventos relevantes.    Com este endpoint, é possível ter uma visão completa do ciclo de vida  de um email enviado, permitindo que os usuários acompanhem e analisem  o status e o histórico de eventos do email. Isso é particularmente  útil para identificar problemas de entrega e entender o comportamento  do email ao longo do tempo.
        /// </summary>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do e-mail.    Esse parâmetro é obtido após o envio do email por qualquer endpoint da  API da Nuvem Fiscal que realize disparos de email.    Exemplos:  * &lt;a href&#x3D;\&quot;#tag/Nfe/operation/EnviarEmailNfe\&quot;&gt;Envio de XML e PDF de NF-e&lt;/a&gt;.  * &lt;a href&#x3D;\&quot;#tag/Nfce/operation/EnviarEmailNfce\&quot;&gt;Envio de XML e PDF de NFC-e&lt;/a&gt;.</param>
        /// <returns>ApiResponse of Email</returns>
        public ACBrAPI.Sdk.Client.ApiResponse<Email> ConsultarEmailWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ACBrAPI.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling EmailApi->ConsultarEmail");

            ACBrAPI.Sdk.Client.RequestOptions localVarRequestOptions = new ACBrAPI.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ACBrAPI.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ACBrAPI.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ACBrAPI.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (jwt) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Email>("/emails/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarEmail", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Consultar e-mail Obtém informações detalhadas sobre o envio de um email. Este endpoint  permite rastrear todos os eventos relacionados ao email, como envio,  entrega, falhas e outros eventos relevantes.    Com este endpoint, é possível ter uma visão completa do ciclo de vida  de um email enviado, permitindo que os usuários acompanhem e analisem  o status e o histórico de eventos do email. Isso é particularmente  útil para identificar problemas de entrega e entender o comportamento  do email ao longo do tempo.
        /// </summary>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do e-mail.    Esse parâmetro é obtido após o envio do email por qualquer endpoint da  API da Nuvem Fiscal que realize disparos de email.    Exemplos:  * &lt;a href&#x3D;\&quot;#tag/Nfe/operation/EnviarEmailNfe\&quot;&gt;Envio de XML e PDF de NF-e&lt;/a&gt;.  * &lt;a href&#x3D;\&quot;#tag/Nfce/operation/EnviarEmailNfce\&quot;&gt;Envio de XML e PDF de NFC-e&lt;/a&gt;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Email</returns>
        public async System.Threading.Tasks.Task<Email> ConsultarEmailAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ACBrAPI.Sdk.Client.ApiResponse<Email> localVarResponse = await ConsultarEmailWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar e-mail Obtém informações detalhadas sobre o envio de um email. Este endpoint  permite rastrear todos os eventos relacionados ao email, como envio,  entrega, falhas e outros eventos relevantes.    Com este endpoint, é possível ter uma visão completa do ciclo de vida  de um email enviado, permitindo que os usuários acompanhem e analisem  o status e o histórico de eventos do email. Isso é particularmente  útil para identificar problemas de entrega e entender o comportamento  do email ao longo do tempo.
        /// </summary>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID único do e-mail.    Esse parâmetro é obtido após o envio do email por qualquer endpoint da  API da Nuvem Fiscal que realize disparos de email.    Exemplos:  * &lt;a href&#x3D;\&quot;#tag/Nfe/operation/EnviarEmailNfe\&quot;&gt;Envio de XML e PDF de NF-e&lt;/a&gt;.  * &lt;a href&#x3D;\&quot;#tag/Nfce/operation/EnviarEmailNfce\&quot;&gt;Envio de XML e PDF de NFC-e&lt;/a&gt;.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Email)</returns>
        public async System.Threading.Tasks.Task<ACBrAPI.Sdk.Client.ApiResponse<Email>> ConsultarEmailWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ACBrAPI.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling EmailApi->ConsultarEmail");


            ACBrAPI.Sdk.Client.RequestOptions localVarRequestOptions = new ACBrAPI.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = ACBrAPI.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ACBrAPI.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ACBrAPI.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (jwt) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Email>("/emails/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConsultarEmail", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar e-mails Retorna a lista dos emails associadas à sua conta. Os e-emails são  retornados ordenados pela data da criação, com os mais recentes  aparecendo primeiro.
        /// </summary>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtra pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="undelivered">Filtra apenas emails com problemas de entrega. (optional)</param>
        /// <param name="email">Filtra pelo endereço de e-mail do destinatário para qual o email foi enviado. (optional)</param>
        /// <returns>EmailListagem</returns>
        public EmailListagem ListarEmails(string cpfCnpj, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), bool? undelivered = default(bool?), string email = default(string))
        {
            ACBrAPI.Sdk.Client.ApiResponse<EmailListagem> localVarResponse = ListarEmailsWithHttpInfo(cpfCnpj, top, skip, inlinecount, undelivered, email);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar e-mails Retorna a lista dos emails associadas à sua conta. Os e-emails são  retornados ordenados pela data da criação, com os mais recentes  aparecendo primeiro.
        /// </summary>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtra pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="undelivered">Filtra apenas emails com problemas de entrega. (optional)</param>
        /// <param name="email">Filtra pelo endereço de e-mail do destinatário para qual o email foi enviado. (optional)</param>
        /// <returns>ApiResponse of EmailListagem</returns>
        public ACBrAPI.Sdk.Client.ApiResponse<EmailListagem> ListarEmailsWithHttpInfo(string cpfCnpj, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), bool? undelivered = default(bool?), string email = default(string))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new ACBrAPI.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmailApi->ListarEmails");

            ACBrAPI.Sdk.Client.RequestOptions localVarRequestOptions = new ACBrAPI.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ACBrAPI.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ACBrAPI.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (top != null)
            {
                localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$top", top));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$skip", skip));
            }
            if (inlinecount != null)
            {
                localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$inlinecount", inlinecount));
            }
            localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
            if (undelivered != null)
            {
                localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "undelivered", undelivered));
            }
            if (email != null)
            {
                localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "email", email));
            }

            // authentication (jwt) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<EmailListagem>("/emails", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarEmails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Listar e-mails Retorna a lista dos emails associadas à sua conta. Os e-emails são  retornados ordenados pela data da criação, com os mais recentes  aparecendo primeiro.
        /// </summary>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtra pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="undelivered">Filtra apenas emails com problemas de entrega. (optional)</param>
        /// <param name="email">Filtra pelo endereço de e-mail do destinatário para qual o email foi enviado. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EmailListagem</returns>
        public async System.Threading.Tasks.Task<EmailListagem> ListarEmailsAsync(string cpfCnpj, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), bool? undelivered = default(bool?), string email = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ACBrAPI.Sdk.Client.ApiResponse<EmailListagem> localVarResponse = await ListarEmailsWithHttpInfoAsync(cpfCnpj, top, skip, inlinecount, undelivered, email, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Listar e-mails Retorna a lista dos emails associadas à sua conta. Os e-emails são  retornados ordenados pela data da criação, com os mais recentes  aparecendo primeiro.
        /// </summary>
        /// <exception cref="ACBrAPI.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cpfCnpj">Filtra pelo CPF ou CNPJ da empresa.    *Utilize o valor sem máscara*.</param>
        /// <param name="top">Limite no número de objetos a serem retornados pela API, entre 1 e 100. (optional, default to 10)</param>
        /// <param name="skip">Quantidade de objetos que serão ignorados antes da lista começar a ser retornada. (optional, default to 0)</param>
        /// <param name="inlinecount">Inclui no JSON de resposta, na propriedade &#x60;@count&#x60;, o número total de registros que o filtro retornaria, independente dos filtros de paginação. (optional, default to false)</param>
        /// <param name="undelivered">Filtra apenas emails com problemas de entrega. (optional)</param>
        /// <param name="email">Filtra pelo endereço de e-mail do destinatário para qual o email foi enviado. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EmailListagem)</returns>
        public async System.Threading.Tasks.Task<ACBrAPI.Sdk.Client.ApiResponse<EmailListagem>> ListarEmailsWithHttpInfoAsync(string cpfCnpj, int? top = default(int?), int? skip = default(int?), bool? inlinecount = default(bool?), bool? undelivered = default(bool?), string email = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cpfCnpj' is set
            if (cpfCnpj == null)
                throw new ACBrAPI.Sdk.Client.ApiException(400, "Missing required parameter 'cpfCnpj' when calling EmailApi->ListarEmails");


            ACBrAPI.Sdk.Client.RequestOptions localVarRequestOptions = new ACBrAPI.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = ACBrAPI.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ACBrAPI.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (top != null)
            {
                localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$top", top));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$skip", skip));
            }
            if (inlinecount != null)
            {
                localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "$inlinecount", inlinecount));
            }
            localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cpf_cnpj", cpfCnpj));
            if (undelivered != null)
            {
                localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "undelivered", undelivered));
            }
            if (email != null)
            {
                localVarRequestOptions.QueryParameters.Add(ACBrAPI.Sdk.Client.ClientUtils.ParameterToMultiMap("", "email", email));
            }

            // authentication (jwt) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmailListagem>("/emails", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListarEmails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
