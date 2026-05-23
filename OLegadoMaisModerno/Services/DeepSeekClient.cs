using Newtonsoft.Json;
using OLegadoMaisModerno.WinForms.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OLegadoMaisModerno.WinForms.Services
{
    public class DeepSeekClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public DeepSeekClient()
        {
            _apiKey = Environment.GetEnvironmentVariable("DEEPSEEK_API_KEY");

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.deepseek.com");

            if (!string.IsNullOrWhiteSpace(_apiKey))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _apiKey);
            }
        }

        public async Task<string> EnviarMensagemAsync(DeepSeekRequest request)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
            {
                throw new Exception("Token da DeepSeek não encontrado. Configure a variável de ambiente DEEPSEEK_API_KEY.");
            }

            string json = JsonConvert.SerializeObject(request);

            StringContent content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await _httpClient.PostAsync("/chat/completions", content);

            string responseBody = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro na DeepSeek: " + response.StatusCode + " - " + responseBody);
            }

            DeepSeekResponse deepSeekResponse =
                JsonConvert.DeserializeObject<DeepSeekResponse>(responseBody);

            if (deepSeekResponse == null ||
                deepSeekResponse.choices == null ||
                deepSeekResponse.choices.Count == 0 ||
                deepSeekResponse.choices[0].message == null ||
                string.IsNullOrWhiteSpace(deepSeekResponse.choices[0].message.content))
            {
                return "Não consegui interpretar a resposta da IA.";
            }

            return deepSeekResponse.choices[0].message.content;
        }
    }
}