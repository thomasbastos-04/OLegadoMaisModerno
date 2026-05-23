using System.Drawing;
using System.Windows.Forms;

namespace OLegadoMaisModerno.WinForms.Forms
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel layoutPrincipal;
        private Panel pnlHeader;
        private Panel pnlChat;
        private Panel pnlInput;
        private Panel pnlSidebar;

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblStatus;
        private Label lblChatTitulo;
        private Label lblInputTitulo;
        private Label lblSidebarTitulo;
        private Label lblSidebarTexto;
        private Label lblModuloAtual;

        private RichTextBox rtbChat;
        private TextBox txtPergunta;
        private Button btnEnviar;
        private Button btnLimpar;
        private Button btnModoChat;
        private Button btnModoCodigo;
        private Button btnModoTexto;
        private Button btnModoProjeto;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            layoutPrincipal = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblStatus = new Label();
            pnlChat = new Panel();
            lblChatTitulo = new Label();
            rtbChat = new RichTextBox();
            pnlInput = new Panel();
            lblInputTitulo = new Label();
            txtPergunta = new TextBox();
            btnEnviar = new Button();
            btnLimpar = new Button();
            pnlSidebar = new Panel();
            lblSidebarTitulo = new Label();
            lblSidebarTexto = new Label();
            lblModuloAtual = new Label();
            btnModoChat = new Button();
            btnModoCodigo = new Button();
            btnModoTexto = new Button();
            btnModoProjeto = new Button();

            layoutPrincipal.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlChat.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();

            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 12, 22);
            ClientSize = new Size(1240, 780);
            MinimumSize = new Size(1000, 650);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "O Legado Mais Moderno";

            // 
            // layoutPrincipal
            // 
            layoutPrincipal.BackColor = Color.FromArgb(8, 12, 22);
            layoutPrincipal.ColumnCount = 2;
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            layoutPrincipal.RowCount = 3;
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
            layoutPrincipal.Dock = DockStyle.Fill;
            layoutPrincipal.Padding = new Padding(22);
            layoutPrincipal.Controls.Add(pnlHeader, 0, 0);
            layoutPrincipal.Controls.Add(pnlSidebar, 1, 0);
            layoutPrincipal.Controls.Add(pnlChat, 0, 1);
            layoutPrincipal.Controls.Add(pnlInput, 0, 2);
            layoutPrincipal.SetRowSpan(pnlSidebar, 3);

            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(16, 24, 43);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Margin = new Padding(0, 0, 14, 14);
            pnlHeader.Padding = new Padding(24);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblStatus);

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(382, 42);
            lblTitulo.Text = "O Legado Mais Moderno";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(176, 190, 220);
            lblSubtitulo.Location = new Point(28, 66);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(486, 19);
            lblSubtitulo.Text = "Agente desktop com IA para código, criação, organização e produtividade.";

            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus.BackColor = Color.FromArgb(26, 131, 94);
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(690, 38);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(155, 34);
            lblStatus.Text = "● Pronto";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // pnlChat
            // 
            pnlChat.BackColor = Color.FromArgb(16, 24, 43);
            pnlChat.Dock = DockStyle.Fill;
            pnlChat.Margin = new Padding(0, 0, 14, 14);
            pnlChat.Padding = new Padding(22);
            pnlChat.Controls.Add(lblChatTitulo);
            pnlChat.Controls.Add(rtbChat);

            // 
            // lblChatTitulo
            // 
            lblChatTitulo.AutoSize = true;
            lblChatTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblChatTitulo.ForeColor = Color.White;
            lblChatTitulo.Location = new Point(22, 18);
            lblChatTitulo.Name = "lblChatTitulo";
            lblChatTitulo.Size = new Size(167, 21);
            lblChatTitulo.Text = "Conversa inteligente";

            // 
            // rtbChat
            // 
            rtbChat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbChat.BackColor = Color.FromArgb(7, 11, 21);
            rtbChat.BorderStyle = BorderStyle.None;
            rtbChat.DetectUrls = true;
            rtbChat.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            rtbChat.ForeColor = Color.FromArgb(232, 238, 250);
            rtbChat.HideSelection = false;
            rtbChat.Location = new Point(22, 52);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.ScrollBars = RichTextBoxScrollBars.Both;
            rtbChat.Size = new Size(823, 350);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            rtbChat.WordWrap = false;

            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.FromArgb(16, 24, 43);
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Margin = new Padding(0, 0, 14, 0);
            pnlInput.Padding = new Padding(22);
            pnlInput.Controls.Add(lblInputTitulo);
            pnlInput.Controls.Add(txtPergunta);
            pnlInput.Controls.Add(btnEnviar);
            pnlInput.Controls.Add(btnLimpar);

            // 
            // lblInputTitulo
            // 
            lblInputTitulo.AutoSize = true;
            lblInputTitulo.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblInputTitulo.ForeColor = Color.White;
            lblInputTitulo.Location = new Point(22, 18);
            lblInputTitulo.Name = "lblInputTitulo";
            lblInputTitulo.Size = new Size(119, 20);
            lblInputTitulo.Text = "Sua mensagem";

            // 
            // txtPergunta
            // 
            txtPergunta.AcceptsReturn = true;
            txtPergunta.AcceptsTab = true;
            txtPergunta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPergunta.BackColor = Color.FromArgb(25, 36, 63);
            txtPergunta.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtPergunta.ForeColor = Color.White;
            txtPergunta.Location = new Point(22, 50);
            txtPergunta.Multiline = true;
            txtPergunta.Name = "txtPergunta";
            txtPergunta.ScrollBars = ScrollBars.Vertical;
            txtPergunta.Size = new Size(625, 96);
            txtPergunta.TabIndex = 1;
            txtPergunta.KeyDown += txtPergunta_KeyDown;

            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnviar.BackColor = Color.FromArgb(91, 86, 255);
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(667, 50);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(178, 42);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;

            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpar.BackColor = Color.FromArgb(37, 50, 82);
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(667, 104);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(178, 42);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar conversa";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;

            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(13, 20, 36);
            pnlSidebar.Dock = DockStyle.Fill;
            pnlSidebar.Margin = new Padding(0);
            pnlSidebar.Padding = new Padding(22);
            pnlSidebar.Controls.Add(lblSidebarTitulo);
            pnlSidebar.Controls.Add(lblModuloAtual);
            pnlSidebar.Controls.Add(btnModoChat);
            pnlSidebar.Controls.Add(btnModoCodigo);
            pnlSidebar.Controls.Add(btnModoTexto);
            pnlSidebar.Controls.Add(btnModoProjeto);
            pnlSidebar.Controls.Add(lblSidebarTexto);

            // 
            // lblSidebarTitulo
            // 
            lblSidebarTitulo.AutoSize = true;
            lblSidebarTitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblSidebarTitulo.ForeColor = Color.White;
            lblSidebarTitulo.Location = new Point(22, 24);
            lblSidebarTitulo.Name = "lblSidebarTitulo";
            lblSidebarTitulo.Size = new Size(151, 25);
            lblSidebarTitulo.Text = "Agente Principal";

            // 
            // lblModuloAtual
            // 
            lblModuloAtual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblModuloAtual.BackColor = Color.FromArgb(20, 31, 55);
            lblModuloAtual.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblModuloAtual.ForeColor = Color.FromArgb(170, 210, 255);
            lblModuloAtual.Location = new Point(24, 64);
            lblModuloAtual.Name = "lblModuloAtual";
            lblModuloAtual.Size = new Size(246, 38);
            lblModuloAtual.Text = "Modo atual: Chat Livre";
            lblModuloAtual.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // btnModoChat
            // 
            btnModoChat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnModoChat.BackColor = Color.FromArgb(91, 86, 255);
            btnModoChat.Cursor = Cursors.Hand;
            btnModoChat.FlatAppearance.BorderSize = 0;
            btnModoChat.FlatStyle = FlatStyle.Flat;
            btnModoChat.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnModoChat.ForeColor = Color.White;
            btnModoChat.Location = new Point(24, 125);
            btnModoChat.Name = "btnModoChat";
            btnModoChat.Size = new Size(246, 38);
            btnModoChat.TabIndex = 4;
            btnModoChat.Text = "Chat Livre";
            btnModoChat.UseVisualStyleBackColor = false;

            // 
            // btnModoCodigo
            // 
            btnModoCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnModoCodigo.BackColor = Color.FromArgb(33, 45, 75);
            btnModoCodigo.Cursor = Cursors.Hand;
            btnModoCodigo.FlatAppearance.BorderSize = 0;
            btnModoCodigo.FlatStyle = FlatStyle.Flat;
            btnModoCodigo.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnModoCodigo.ForeColor = Color.White;
            btnModoCodigo.Location = new Point(24, 172);
            btnModoCodigo.Name = "btnModoCodigo";
            btnModoCodigo.Size = new Size(246, 38);
            btnModoCodigo.TabIndex = 5;
            btnModoCodigo.Text = "Código";
            btnModoCodigo.UseVisualStyleBackColor = false;

            // 
            // btnModoTexto
            // 
            btnModoTexto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnModoTexto.BackColor = Color.FromArgb(33, 45, 75);
            btnModoTexto.Cursor = Cursors.Hand;
            btnModoTexto.FlatAppearance.BorderSize = 0;
            btnModoTexto.FlatStyle = FlatStyle.Flat;
            btnModoTexto.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnModoTexto.ForeColor = Color.White;
            btnModoTexto.Location = new Point(24, 219);
            btnModoTexto.Name = "btnModoTexto";
            btnModoTexto.Size = new Size(246, 38);
            btnModoTexto.TabIndex = 6;
            btnModoTexto.Text = "Texto";
            btnModoTexto.UseVisualStyleBackColor = false;

            // 
            // btnModoProjeto
            // 
            btnModoProjeto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnModoProjeto.BackColor = Color.FromArgb(33, 45, 75);
            btnModoProjeto.Cursor = Cursors.Hand;
            btnModoProjeto.FlatAppearance.BorderSize = 0;
            btnModoProjeto.FlatStyle = FlatStyle.Flat;
            btnModoProjeto.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnModoProjeto.ForeColor = Color.White;
            btnModoProjeto.Location = new Point(24, 266);
            btnModoProjeto.Name = "btnModoProjeto";
            btnModoProjeto.Size = new Size(246, 38);
            btnModoProjeto.TabIndex = 7;
            btnModoProjeto.Text = "Projeto";
            btnModoProjeto.UseVisualStyleBackColor = false;

            // 
            // lblSidebarTexto
            // 
            lblSidebarTexto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSidebarTexto.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblSidebarTexto.ForeColor = Color.FromArgb(180, 193, 220);
            lblSidebarTexto.Location = new Point(24, 330);
            lblSidebarTexto.Name = "lblSidebarTexto";
            lblSidebarTexto.Size = new Size(246, 330);
            lblSidebarTexto.Text =
                "Use este agente para:\r\n\r\n" +
                "• Criar textos\r\n" +
                "• Organizar ideias\r\n" +
                "• Gerar códigos\r\n" +
                "• Revisar conteúdos\r\n" +
                "• Planejar projetos\r\n" +
                "• Estudar assuntos\r\n\r\n" +
                "Quando houver código, a resposta será formatada automaticamente.";

            // 
            // Controls
            // 
            Controls.Add(layoutPrincipal);

            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlChat.ResumeLayout(false);
            pnlChat.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            layoutPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}