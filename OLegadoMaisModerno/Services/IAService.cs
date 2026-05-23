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
            _historico = new List<ChatMessage>();

            AdicionarPromptSistema();
        }

        public async Task<string> PerguntarAsync(string pergunta)
        {
            _historico.Add(new ChatMessage("user", pergunta));

            DeepSeekRequest request = new DeepSeekRequest();
            request.model = "deepseek-chat";
            request.messages = _historico;
            request.stream = false;

            string resposta = await _client.EnviarMensagemAsync(request);

            _historico.Add(new ChatMessage("assistant", resposta));

            return resposta;
        }

        public void LimparHistorico()
        {
            _historico.Clear();
            AdicionarPromptSistema();
        }

        private void AdicionarPromptSistema()
        {
            _historico.Add(new ChatMessage(
                "system",
                "Você é O Legado, o agente principal do projeto O Legado Mais Moderno. " +
                "Responda sempre em português do Brasil, com linguagem jovem formal, objetiva e natural. " +
                "Você ajuda com código, textos, organização, estudos, produtividade e planejamento de projetos. " +
                "Quando retornar código, sempre use blocos markdown com três crases e informe a linguagem, por exemplo ```csharp. " +
                "Quando o usuário pedir código completo, entregue o código completo, organizado e pronto para colar. " +
                "Explique o mínimo necessário antes do código. " +
                "Evite respostas longas demais quando o usuário pedir algo direto. " +
                "Quando houver passos técnicos, organize em etapas claras. " +
                "Se o usuário estiver programando em C# antigo ou WinForms clássico, evite recursos modernos como target-typed new, records e ApplicationConfiguration."
            ));
        }
    }
}