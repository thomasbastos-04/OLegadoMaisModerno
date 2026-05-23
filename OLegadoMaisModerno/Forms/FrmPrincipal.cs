using OLegadoMaisModerno.WinForms.Services;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLegadoMaisModerno.WinForms.Forms
{
    public partial class FrmPrincipal : Form
    {
        private IAService _iaService;

        public FrmPrincipal()
        {
            InitializeComponent();
            ConfigurarTelaInicial();
        }

        private void ConfigurarTelaInicial()
        {
            lblStatus.Text = "● Pronto";
            lblStatus.BackColor = Color.FromArgb(26, 131, 94);

            rtbChat.Clear();

            AdicionarMensagemSistema(
                "Olá! Eu sou O Legado, o agente do projeto O Legado Mais Moderno.\n" +
                "Digite uma mensagem abaixo para começarmos.\n\n" +
                "Dica: use CTRL + ENTER para enviar."
            );

            txtPergunta.Focus();
        }

        private IAService ObterIAService()
        {
            if (_iaService == null)
            {
                _iaService = new IAService();
            }

            return _iaService;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            await EnviarMensagemAsync();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparConversa();
        }

        private async void txtPergunta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await EnviarMensagemAsync();
            }
        }

        private async Task EnviarMensagemAsync()
        {
            string pergunta = txtPergunta.Text.Trim();

            if (string.IsNullOrWhiteSpace(pergunta))
            {
                MessageBox.Show(
                    "Digite uma mensagem antes de enviar.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPergunta.Focus();
                return;
            }

            try
            {
                AlterarEstadoCarregando(true);

                AdicionarMensagemUsuario(pergunta);

                txtPergunta.Clear();
                txtPergunta.Focus();

                IAService service = ObterIAService();

                string resposta = await service.PerguntarAsync(pergunta);

                AdicionarMensagemIA(resposta);
            }
            catch (Exception ex)
            {
                string mensagemErro = TratarMensagemErro(ex);

                AdicionarMensagemSistema("Erro ao consultar a IA:\n" + mensagemErro);

                MessageBox.Show(
                    mensagemErro,
                    "Erro ao consultar a IA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                AlterarEstadoCarregando(false);
            }
        }

        private void LimparConversa()
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja limpar a conversa atual?",
                "Limpar conversa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            if (_iaService != null)
            {
                _iaService.LimparHistorico();
            }

            rtbChat.Clear();

            AdicionarMensagemSistema("Conversa limpa. Pode mandar uma nova mensagem.");

            txtPergunta.Clear();
            txtPergunta.Focus();
        }

        private void AlterarEstadoCarregando(bool carregando)
        {
            btnEnviar.Enabled = !carregando;
            btnLimpar.Enabled = !carregando;
            txtPergunta.Enabled = !carregando;

            btnEnviar.Text = carregando ? "Pensando..." : "Enviar";

            lblStatus.Text = carregando ? "● Processando" : "● Pronto";
            lblStatus.BackColor = carregando
                ? Color.FromArgb(178, 119, 32)
                : Color.FromArgb(26, 131, 94);

            Cursor = carregando ? Cursors.WaitCursor : Cursors.Default;
        }

        private string TratarMensagemErro(Exception ex)
        {
            string mensagem = ex.Message;

            if (mensagem.IndexOf("DEEPSEEK_API_KEY", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return
                    "Token da DeepSeek não encontrado.\n\n" +
                    "Configure a variável de ambiente DEEPSEEK_API_KEY no Windows ou adicione sua chave temporariamente no DeepSeekClient.";
            }

            if (mensagem.IndexOf("401", StringComparison.OrdinalIgnoreCase) >= 0 ||
                mensagem.IndexOf("Unauthorized", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return
                    "Token inválido ou não autorizado.\n\n" +
                    "Verifique se sua chave da DeepSeek está correta.";
            }

            if (mensagem.IndexOf("429", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return
                    "A API retornou limite de uso ou muitas requisições.\n\n" +
                    "Tente novamente em alguns instantes.";
            }

            return mensagem;
        }

        private void AdicionarMensagemUsuario(string mensagem)
        {
            AdicionarCabecalhoMensagem("VOCÊ", Color.FromArgb(130, 170, 255));
            AdicionarTextoNormal(mensagem);
            AdicionarSeparador();
        }

        private void AdicionarMensagemIA(string mensagem)
        {
            AdicionarCabecalhoMensagem("O LEGADO", Color.FromArgb(130, 230, 190));
            RenderizarRespostaIA(mensagem);
            AdicionarSeparador();
        }

        private void AdicionarMensagemSistema(string mensagem)
        {
            AdicionarCabecalhoMensagem("SISTEMA", Color.FromArgb(230, 200, 120));
            AdicionarTextoNormal(mensagem);
            AdicionarSeparador();
        }

        private void AdicionarCabecalhoMensagem(string autor, Color cor)
        {
            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionLength = 0;

            rtbChat.SelectionFont = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            rtbChat.SelectionColor = cor;
            rtbChat.SelectionBackColor = rtbChat.BackColor;

            rtbChat.AppendText(autor + ":" + Environment.NewLine + Environment.NewLine);
        }

        private void AdicionarTextoNormal(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return;
            }

            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionLength = 0;

            rtbChat.SelectionFont = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            rtbChat.SelectionColor = Color.FromArgb(232, 238, 250);
            rtbChat.SelectionBackColor = rtbChat.BackColor;

            rtbChat.AppendText(texto);
            rtbChat.AppendText(Environment.NewLine + Environment.NewLine);

            RolarChatParaBaixo();
        }

        private void AdicionarTextoNormalSemEspacoExtra(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return;
            }

            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionLength = 0;

            rtbChat.SelectionFont = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            rtbChat.SelectionColor = Color.FromArgb(232, 238, 250);
            rtbChat.SelectionBackColor = rtbChat.BackColor;

            rtbChat.AppendText(texto);
            rtbChat.AppendText(Environment.NewLine + Environment.NewLine);

            RolarChatParaBaixo();
        }

        private void RenderizarRespostaIA(string mensagem)
        {
            if (string.IsNullOrWhiteSpace(mensagem))
            {
                AdicionarTextoNormal("A IA não retornou conteúdo.");
                return;
            }

            string[] linhas = mensagem.Replace("\r\n", "\n").Split('\n');

            bool dentroCodigo = false;
            string linguagemCodigo = "";
            string blocoCodigo = "";
            string textoNormal = "";

            for (int i = 0; i < linhas.Length; i++)
            {
                string linha = linhas[i];

                if (linha.TrimStart().StartsWith("```"))
                {
                    if (!dentroCodigo)
                    {
                        if (!string.IsNullOrWhiteSpace(textoNormal))
                        {
                            AdicionarTextoNormalSemEspacoExtra(textoNormal.TrimEnd());
                            textoNormal = "";
                        }

                        dentroCodigo = true;

                        linguagemCodigo = linha.Trim().Replace("```", "").Trim();

                        if (string.IsNullOrWhiteSpace(linguagemCodigo))
                        {
                            linguagemCodigo = "código";
                        }

                        blocoCodigo = "";
                    }
                    else
                    {
                        dentroCodigo = false;

                        AdicionarBlocoCodigo(linguagemCodigo, blocoCodigo.TrimEnd());

                        linguagemCodigo = "";
                        blocoCodigo = "";
                    }
                }
                else
                {
                    if (dentroCodigo)
                    {
                        blocoCodigo += linha + Environment.NewLine;
                    }
                    else
                    {
                        textoNormal += linha + Environment.NewLine;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(textoNormal))
            {
                AdicionarTextoNormalSemEspacoExtra(textoNormal.TrimEnd());
            }

            if (!string.IsNullOrWhiteSpace(blocoCodigo))
            {
                string linguagemFinal = string.IsNullOrWhiteSpace(linguagemCodigo)
                    ? "código"
                    : linguagemCodigo;

                AdicionarBlocoCodigo(linguagemFinal, blocoCodigo.TrimEnd());
            }

            rtbChat.AppendText(Environment.NewLine);
            RolarChatParaBaixo();
        }

        private void AdicionarBlocoCodigo(string linguagem, string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                return;
            }

            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionLength = 0;

            rtbChat.SelectionFont = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            rtbChat.SelectionColor = Color.FromArgb(160, 190, 255);
            rtbChat.SelectionBackColor = Color.FromArgb(18, 28, 50);

            rtbChat.AppendText("  " + linguagem.ToUpper() + "  ");
            rtbChat.AppendText(Environment.NewLine);

            string[] linhasCodigo = codigo.Replace("\r\n", "\n").Split('\n');

            for (int i = 0; i < linhasCodigo.Length; i++)
            {
                string numeroLinha = (i + 1).ToString().PadLeft(3, ' ');

                rtbChat.SelectionFont = new Font("Consolas", 10F, FontStyle.Regular);

                rtbChat.SelectionColor = Color.FromArgb(105, 125, 160);
                rtbChat.SelectionBackColor = Color.FromArgb(12, 18, 32);
                rtbChat.AppendText(numeroLinha + "  ");

                rtbChat.SelectionColor = Color.FromArgb(225, 235, 245);
                rtbChat.SelectionBackColor = Color.FromArgb(12, 18, 32);
                rtbChat.AppendText(linhasCodigo[i]);

                rtbChat.AppendText(Environment.NewLine);
            }

            rtbChat.SelectionBackColor = rtbChat.BackColor;
            rtbChat.SelectionColor = Color.FromArgb(232, 238, 250);
            rtbChat.AppendText(Environment.NewLine);

            RolarChatParaBaixo();
        }

        private void AdicionarSeparador()
        {
            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionLength = 0;

            rtbChat.SelectionFont = new Font("Segoe UI", 9F, FontStyle.Regular);
            rtbChat.SelectionColor = Color.FromArgb(70, 82, 110);
            rtbChat.SelectionBackColor = rtbChat.BackColor;

            rtbChat.AppendText("────────────────────────────────────────────");
            rtbChat.AppendText(Environment.NewLine + Environment.NewLine);

            RolarChatParaBaixo();
        }

        private void RolarChatParaBaixo()
        {
            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.ScrollToCaret();
        }
    }
}