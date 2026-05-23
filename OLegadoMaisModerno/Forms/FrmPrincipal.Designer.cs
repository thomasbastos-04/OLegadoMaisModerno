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
                "Olá! Eu sou o agente do projeto O Legado Mais Moderno.\n" +
                "Digite uma mensagem abaixo para começarmos."
            );

            txtPergunta.Focus();
        }

        private IAService ObterIAService()
        {
            if (_iaService == null)
                _iaService = new IAService();

            return _iaService;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            await EnviarMensagemAsync();
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
                AdicionarMensagemSistema("Erro ao consultar a IA:\n" + ex.Message);

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
                AlterarEstadoCarregando(false);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (_iaService != null)
                _iaService.LimparHistorico();

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

        private void AdicionarMensagemUsuario(string mensagem)
        {
            AdicionarBloco("VOCÊ", mensagem, Color.FromArgb(130, 170, 255));
        }

        private void AdicionarMensagemIA(string mensagem)
        {
            AdicionarBloco("IA", mensagem, Color.FromArgb(130, 230, 190));
        }

        private void AdicionarMensagemSistema(string mensagem)
        {
            AdicionarBloco("SISTEMA", mensagem, Color.FromArgb(230, 200, 120));
        }

        private void AdicionarBloco(string autor, string mensagem, Color corAutor)
        {
            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionLength = 0;

            rtbChat.SelectionColor = corAutor;
            rtbChat.SelectionFont = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            rtbChat.AppendText(autor + ":" + Environment.NewLine);

            rtbChat.SelectionColor = Color.FromArgb(232, 238, 250);
            rtbChat.SelectionFont = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            rtbChat.AppendText(mensagem + Environment.NewLine + Environment.NewLine);

            rtbChat.SelectionColor = Color.FromArgb(80, 92, 120);
            rtbChat.AppendText("────────────────────────────────────────" + Environment.NewLine + Environment.NewLine);

            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.ScrollToCaret();
        }
    }
}