using System.Drawing;
using System.Windows.Forms;

namespace OLegadoMaisModerno.WinForms.Forms
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlPrincipal;
        private Panel pnlTopo;
        private Panel pnlChat;
        private Panel pnlPergunta;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblChat;
        private Label lblPergunta;
        private TextBox txtResposta;
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
            pnlPrincipal = new Panel();
            pnlChat = new Panel();
            txtResposta = new TextBox();
            lblChat = new Label();
            pnlPergunta = new Panel();
            btnLimpar = new Button();
            btnEnviar = new Button();
            txtPergunta = new TextBox();
            lblPergunta = new Label();
            pnlTopo = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();

            pnlPrincipal.SuspendLayout();
            pnlChat.SuspendLayout();
            pnlPergunta.SuspendLayout();
            pnlTopo.SuspendLayout();
            SuspendLayout();

            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 13, 24);
            ClientSize = new Size(1100, 720);
            MinimumSize = new Size(900, 600);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "O Legado Mais Moderno";

            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.FromArgb(9, 13, 24);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Padding = new Padding(24);
            pnlPrincipal.Controls.Add(pnlChat);
            pnlPrincipal.Controls.Add(pnlPergunta);
            pnlPrincipal.Controls.Add(pnlTopo);

            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(18, 26, 46);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Height = 105;
            pnlTopo.Padding = new Padding(24);
            pnlTopo.Controls.Add(lblSubtitulo);
            pnlTopo.Controls.Add(lblTitulo);

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(367, 41);
            lblTitulo.Text = "O Legado Mais Moderno";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(180, 190, 215);
            lblSubtitulo.Location = new Point(27, 64);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(379, 19);
            lblSubtitulo.Text = "Agente de IA com DeepSeek para criação, estudo e produtividade.";

            // 
            // pnlPergunta
            // 
            pnlPergunta.BackColor = Color.FromArgb(18, 26, 46);
            pnlPergunta.Dock = DockStyle.Bottom;
            pnlPergunta.Height = 175;
            pnlPergunta.Padding = new Padding(24);
            pnlPergunta.Controls.Add(btnLimpar);
            pnlPergunta.Controls.Add(btnEnviar);
            pnlPergunta.Controls.Add(txtPergunta);
            pnlPergunta.Controls.Add(lblPergunta);

            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPergunta.ForeColor = Color.White;
            lblPergunta.Location = new Point(24, 18);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(139, 20);
            lblPergunta.Text = "Sua mensagem";

            // 
            // txtPergunta
            // 
            txtPergunta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPergunta.BackColor = Color.FromArgb(26, 37, 64);
            txtPergunta.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            txtPergunta.ForeColor = Color.White;
            txtPergunta.Location = new Point(24, 48);
            txtPergunta.Multiline = true;
            txtPergunta.Name = "txtPergunta";
            txtPergunta.ScrollBars = ScrollBars.Vertical;
            txtPergunta.Size = new Size(806, 95);
            txtPergunta.TabIndex = 0;

            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnviar.BackColor = Color.FromArgb(89, 86, 255);
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(850, 48);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(178, 42);
            btnEnviar.TabIndex = 1;
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
            btnLimpar.Location = new Point(850, 101);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(178, 42);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;

            // 
            // pnlChat
            // 
            pnlChat.BackColor = Color.FromArgb(18, 26, 46);
            pnlChat.Dock = DockStyle.Fill;
            pnlChat.Padding = new Padding(24);
            pnlChat.Controls.Add(txtResposta);
            pnlChat.Controls.Add(lblChat);

            // 
            // lblChat
            // 
            lblChat.AutoSize = true;
            lblChat.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblChat.ForeColor = Color.White;
            lblChat.Location = new Point(24, 18);
            lblChat.Name = "lblChat";
            lblChat.Size = new Size(176, 20);
            lblChat.Text = "Conversa com a IA";

            // 
            // txtResposta
            // 
            txtResposta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResposta.BackColor = Color.FromArgb(11, 17, 31);
            txtResposta.BorderStyle = BorderStyle.FixedSingle;
            txtResposta.Font = new Font("Consolas", 10F, FontStyle.Regular);
            txtResposta.ForeColor = Color.FromArgb(230, 235, 245);
            txtResposta.Location = new Point(24, 50);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.ReadOnly = true;
            txtResposta.ScrollBars = ScrollBars.Vertical;
            txtResposta.Size = new Size(1004, 342);
            txtResposta.TabIndex = 3;

            // 
            // Controls
            // 
            Controls.Add(pnlPrincipal);

            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            pnlPergunta.ResumeLayout(false);
            pnlPergunta.PerformLayout();
            pnlChat.ResumeLayout(false);
            pnlChat.PerformLayout();
            pnlPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}