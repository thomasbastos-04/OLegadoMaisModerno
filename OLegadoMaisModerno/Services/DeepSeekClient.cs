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

            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new Exception("Token da DeepSeek não encontrado. Configure a variável de ambiente DEEPSEEK_API_KEY.");

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.deepseek.com")
            };

            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", _apiKey);
        }

        public async Task<string> EnviarMensagemAsync(DeepSeekRequest request)
        {
            var json = JsonConvert.SerializeObject(request);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpClient.PostAsync("/chat/completions", content);

            var responseBody = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Erro na DeepSeek: {response.StatusCode} - {responseBody}");

            var deepSeekResponse = JsonConvert.DeserializeObject<DeepSeekResponse>(responseBody);

            return deepSeekResponse?.choices?[0]?.message?.content
                ?? "Não consegui interpretar a resposta da IA.";
        }
    }
}