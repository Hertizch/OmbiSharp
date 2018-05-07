using OmbiSharp.Endpoints.Request;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OmbiSharp
{
    /// <summary>
    /// 
    /// </summary>
    public class OmbiClient
    {
        private WebClient _webClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="OmbiClient"/> class.
        /// </summary>
        public OmbiClient(string host, int port, string apiKey, [Optional] string urlBase, [Optional] bool useSsl)
        {
            // Initialize properties
            Host = host;
            Port = port;
            ApiKey = apiKey;
            UrlBase = urlBase;
            UseSsl = useSsl;

            // Set API URL
            var sb = new StringBuilder();
            sb.Append("http");
            if (UseSsl) sb.Append("s");
            sb.Append($"://{host}:{Port}");
            if (UrlBase != null) sb.Append($"/{UrlBase}");
            sb.Append("/api/v1");
            ApiUrl = sb.ToString();

            // Initialize endpoints
            RequestClient = new RequestClient(this);
        }

        /// <summary>
        /// Gets the host.
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        public string Host { get; private set; }

        /// <summary>
        /// Gets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        public int Port { get; private set; }

        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>
        /// The API key.
        /// </value>
        public string ApiKey { get; private set; }

        /// <summary>
        /// Gets the URL base.
        /// </summary>
        /// <value>
        /// The URL base.
        /// </value>
        public string UrlBase { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [use SSL].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use SSL]; otherwise, <c>false</c>.
        /// </value>
        public bool UseSsl { get; private set; }

        /// <summary>
        /// Gets the API URL.
        /// </summary>
        /// <value>
        /// The API URL.
        /// </value>
        public string ApiUrl { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether [write debug].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [write debug]; otherwise, <c>false</c>.
        /// </value>
        public bool WriteDebug { get; set; }

        /// <summary>
        /// Gets the request client.
        /// </summary>
        /// <value>
        /// The request client.
        /// </value>
        public IRequestClient RequestClient { get; }

        internal async Task<string> ProcessJson(string method, string endpointUrl, [Optional] string data)
        {
            if (WriteDebug)
                Debug.WriteLine($"[OmbiSharp] [ProcessJson] [DEBUG] '{method}': Endpoint URL: '{endpointUrl}', data: '{data}'");

            string response = null;

            using (_webClient = new WebClient
            {
                Headers = Helpers.WebClientHelpers.GetWebHeaderCollection(ApiKey),
                Proxy = null,
                Encoding = Encoding.UTF8
            })
            {
                try
                {
                    if (method == "POST" || method == "PUT")
                        response = await _webClient.UploadStringTaskAsync($"{ApiUrl}{endpointUrl}", method, data);

                    if (method == "GET")
                        response = await _webClient.DownloadStringTaskAsync($"{ApiUrl}{endpointUrl}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[OmbiSharp] [ProcessJson] [ERROR] '{method}': Endpoint URL: '{endpointUrl}', data: '{data}', {ex}");
                }
                finally
                {
                    if (WriteDebug)
                    {
                        Debug.WriteLine($"[OmbiSharp] [ProcessJson] [DEBUG] Response: {response}");
                        var webClientHeaders = _webClient.ResponseHeaders;
                        if (webClientHeaders != null)
                            for (int i = 0; i < webClientHeaders.Count; i++)
                                Debug.WriteLine($"[OmbiSharp] [ProcessJson] [DEBUG] Response header: {webClientHeaders.GetKey(i)}={webClientHeaders.Get(i)}");
                    }
                }
            }

            return response;
        }

        internal async Task Delete(string endpointUrl)
        {
            if (WriteDebug)
                Debug.WriteLine($"[RadarrSharp] [DEBUG] [RadarrClient.Delete] Endpoint URL: '{endpointUrl}'");

            using (var httpClient = new HttpClient { BaseAddress = new Uri(ApiUrl) })
            {
                httpClient.DefaultRequestHeaders.Add("ApiKey", ApiKey);
                httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
                httpClient.DefaultRequestHeaders.Add("User-Agent", $"{Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", ".")}.v{Assembly.GetExecutingAssembly().GetName().Version}");

                try
                {
                    await httpClient.DeleteAsync(endpointUrl);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[RadarrSharp] [ERROR] [RadarrClient.Delete] Endpoint URL: '{endpointUrl}', {ex}");
                }
            }
        }
    }
}
