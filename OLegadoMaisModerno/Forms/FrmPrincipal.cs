using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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

        private RichTextBox rtbChat;
        private TextBox txtPergunta;
        private Button btnEnviar;
        private Button btnLimpar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

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
            ClientSize = new Size(1180, 760);
            MinimumSize = new Size(980, 620);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "O Legado Mais Moderno";

            // 
            // layoutPrincipal
            // 
            layoutPrincipal.BackColor = Color.FromArgb(8, 12, 22);
            layoutPrincipal.ColumnCount = 2;
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74F));
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            layoutPrincipal.RowCount = 3;
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 118F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
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
            lblSubtitulo.Location = new Point(28, 65);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(455, 19);
            lblSubtitulo.Text = "Agente desktop com IA para criação, organização, estudo e produtividade.";

            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus.BackColor = Color.FromArgb(26, 131, 94);
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(600, 35);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(165, 34);
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
            lblChatTitulo.Size = new Size(146, 21);
            lblChatTitulo.Text = "Conversa com IA";

            // 
            // rtbChat
            // 
            rtbChat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbChat.BackColor = Color.FromArgb(10, 15, 28);
            rtbChat.BorderStyle = BorderStyle.None;
            rtbChat.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            rtbChat.ForeColor = Color.FromArgb(232, 238, 250);
            rtbChat.Location = new Point(22, 52);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(758, 342);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";

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
            txtPergunta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPergunta.BackColor = Color.FromArgb(25, 36, 63);
            txtPergunta.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            txtPergunta.ForeColor = Color.White;
            txtPergunta.Location = new Point(22, 50);
            txtPergunta.Multiline = true;
            txtPergunta.Name = "txtPergunta";
            txtPergunta.ScrollBars = ScrollBars.Vertical;
            txtPergunta.Size = new Size(560, 91);
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
            btnEnviar.Location = new Point(602, 50);
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
            btnLimpar.Location = new Point(602, 99);
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
            // lblSidebarTexto
            // 
            lblSidebarTexto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSidebarTexto.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblSidebarTexto.ForeColor = Color.FromArgb(180, 193, 220);
            lblSidebarTexto.Location = new Point(24, 68);
            lblSidebarTexto.Name = "lblSidebarTexto";
            lblSidebarTexto.Size = new Size(235, 330);
            lblSidebarTexto.Text =
                "Use este agente para:\r\n\r\n" +
                "• Criar textos\r\n" +
                "• Organizar ideias\r\n" +
                "• Estudar assuntos\r\n" +
                "• Gerar planejamentos\r\n" +
                "• Revisar conteúdos\r\n" +
                "• Apoiar projetos\r\n\r\n" +
                "Atalho:\r\n" +
                "CTRL + ENTER para enviar.";

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