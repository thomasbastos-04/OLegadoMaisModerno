using OLegadoMaisModerno.WinForms.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OLegadoMaisModerno.WinForms.Services
{
    public class IAService
    {
        private readonly DeepSeekClient _client;
        private readonly List<ChatMessage> _historico;

        public IAService()
        {
            _client = new DeepSeekClient();

            _historico = new List<ChatMessage>
            {
                new ChatMessage("system",
                    "Você é o agente principal do projeto O Legado Mais Moderno. " +
                    "Responda em português do Brasil, com clareza, estratégia e objetividade. " +
                    "Ajude o usuário com ideias, textos, organização, tecnologia, estudos e produtividade.")
            };
        }

        public async Task<string> PerguntarAsync(string pergunta)
        {
            _historico.Add(new ChatMessage("user", pergunta));

            var request = new DeepSeekRequest
            {
                model = "deepseek-chat",
                messages = _historico,
                stream = false
            };

            var resposta = await _client.EnviarMensagemAsync(request);

            _historico.Add(new ChatMessage("assistant", resposta));

            return resposta;
        }

        public void LimparHistorico()
        {
            _historico.Clear();

            _historico.Add(new ChatMessage("system",
                "Você é o agente principal do projeto O Legado Mais Moderno. " +
                "Responda em português do Brasil, com clareza, estratégia e objetividade."));
        }
    }
}