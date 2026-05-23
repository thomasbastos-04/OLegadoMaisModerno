using OLegadoMaisModerno.WinForms.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLegadoMaisModerno.WinForms.Forms
{
    public partial class FrmPrincipal : Form
    {
        private readonly IAService _iaService;

        public FrmPrincipal()
        {
            InitializeComponent();

            _iaService = new IAService();

            ConfigurarTelaInicial();
        }

        private void ConfigurarTelaInicial()
        {
            txtResposta.Text =
                "IA: Olá! Eu sou o agente do projeto O Legado Mais Moderno." +
                Environment.NewLine +
                "Digite uma mensagem abaixo para começarmos." +
                Environment.NewLine +
                Environment.NewLine;

            txtPergunta.Focus();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            await EnviarMensagemAsync();
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

                return;
            }

            try
            {
                BloquearTela(true);

                AdicionarNoChat("VOCÊ", pergunta);

                txtPergunta.Clear();

                string resposta = await _iaService.PerguntarAsync(pergunta);

                AdicionarNoChat("IA", resposta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao consultar a IA:" +
                    Environment.NewLine +
                    Environment.NewLine +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                BloquearTela(false);
                txtPergunta.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            _iaService.LimparHistorico();

            txtResposta.Clear();

            txtResposta.Text =
                "IA: Conversa limpa. Pode mandar uma nova mensagem." +
                Environment.NewLine +
                Environment.NewLine;

            txtPergunta.Clear();
            txtPergunta.Focus();
        }

        private void AdicionarNoChat(string autor, string mensagem)
        {
            txtResposta.AppendText(autor + ":");
            txtResposta.AppendText(Environment.NewLine);
            txtResposta.AppendText(mensagem);
            txtResposta.AppendText(Environment.NewLine);
            txtResposta.AppendText(Environment.NewLine);
            txtResposta.AppendText("----------------------------------------");
            txtResposta.AppendText(Environment.NewLine);
            txtResposta.AppendText(Environment.NewLine);

            txtResposta.SelectionStart = txtResposta.Text.Length;
            txtResposta.ScrollToCaret();
        }

        private void BloquearTela(bool bloqueado)
        {
            btnEnviar.Enabled = !bloqueado;
            btnLimpar.Enabled = !bloqueado;
            txtPergunta.Enabled = !bloqueado;

            btnEnviar.Text = bloqueado ? "Pensando..." : "Enviar";
        }
    }
}