using System.Drawing;
using System.Windows.Forms;

namespace OLegadoMaisModerno.WinForms.Forms
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel layoutRoot;
        private TableLayoutPanel layoutContent;
        private TableLayoutPanel layoutLeft;

        private Panel pnlHeader;
        private Panel pnlChat;
        private Panel pnlInput;
        private Panel pnlSidebar;

        private Panel pnlSidebarHero;
        private Panel pnlSidebarMission;
        private Panel pnlSidebarRules;
        private Panel pnlSidebarTips;

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblStatus;

        private Label lblChatTitulo;
        private Label lblChatSubtitulo;

        private RichTextBox rtbChat;

        private Label lblInputTitulo;
        private Label lblInputAjuda;
        private TextBox txtPergunta;
        private Button btnEnviar;
        private Button btnLimpar;

        private Label lblSidebarLogo;
        private Label lblSidebarTitulo;
        private Label lblSidebarDescricao;

        private Label lblMissionTitulo;
        private Label lblMissionTexto;

        private Label lblRulesTitulo;
        private Label lblRulesTexto;

        private Label lblTipsTitulo;
        private Label lblTipsTexto;

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
            layoutRoot = new TableLayoutPanel();
            layoutContent = new TableLayoutPanel();
            layoutLeft = new TableLayoutPanel();

            pnlHeader = new Panel();
            pnlChat = new Panel();
            pnlInput = new Panel();
            pnlSidebar = new Panel();

            pnlSidebarHero = new Panel();
            pnlSidebarMission = new Panel();
            pnlSidebarRules = new Panel();
            pnlSidebarTips = new Panel();

            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblStatus = new Label();

            lblChatTitulo = new Label();
            lblChatSubtitulo = new Label();
            rtbChat = new RichTextBox();

            lblInputTitulo = new Label();
            lblInputAjuda = new Label();
            txtPergunta = new TextBox();
            btnEnviar = new Button();
            btnLimpar = new Button();

            lblSidebarLogo = new Label();
            lblSidebarTitulo = new Label();
            lblSidebarDescricao = new Label();

            lblMissionTitulo = new Label();
            lblMissionTexto = new Label();

            lblRulesTitulo = new Label();
            lblRulesTexto = new Label();

            lblTipsTitulo = new Label();
            lblTipsTexto = new Label();

            layoutRoot.SuspendLayout();
            layoutContent.SuspendLayout();
            layoutLeft.SuspendLayout();

            pnlHeader.SuspendLayout();
            pnlChat.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlSidebar.SuspendLayout();

            pnlSidebarHero.SuspendLayout();
            pnlSidebarMission.SuspendLayout();
            pnlSidebarRules.SuspendLayout();
            pnlSidebarTips.SuspendLayout();

            SuspendLayout();

            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 8, 16);
            ClientSize = new Size(1280, 800);
            MinimumSize = new Size(1050, 680);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "O Legado Mais Moderno";

            // 
            // layoutRoot
            // 
            layoutRoot.BackColor = Color.FromArgb(5, 8, 16);
            layoutRoot.ColumnCount = 1;
            layoutRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutRoot.RowCount = 1;
            layoutRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutRoot.Dock = DockStyle.Fill;
            layoutRoot.Padding = new Padding(22);
            layoutRoot.Controls.Add(layoutContent, 0, 0);

            // 
            // layoutContent
            // 
            layoutContent.BackColor = Color.FromArgb(5, 8, 16);
            layoutContent.ColumnCount = 2;
            layoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73F));
            layoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            layoutContent.RowCount = 1;
            layoutContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutContent.Dock = DockStyle.Fill;
            layoutContent.Controls.Add(layoutLeft, 0, 0);
            layoutContent.Controls.Add(pnlSidebar, 1, 0);

            // 
            // layoutLeft
            // 
            layoutLeft.BackColor = Color.FromArgb(5, 8, 16);
            layoutLeft.ColumnCount = 1;
            layoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutLeft.RowCount = 3;
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 178F));
            layoutLeft.Dock = DockStyle.Fill;
            layoutLeft.Padding = new Padding(0, 0, 16, 0);
            layoutLeft.Controls.Add(pnlHeader, 0, 0);
            layoutLeft.Controls.Add(pnlChat, 0, 1);
            layoutLeft.Controls.Add(pnlInput, 0, 2);

            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(13, 20, 38);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Margin = new Padding(0, 0, 0, 14);
            pnlHeader.Padding = new Padding(28, 18, 28, 18);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblStatus);

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(28, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(392, 45);
            lblTitulo.Text = "O Legado Mais Moderno";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(165, 181, 215);
            lblSubtitulo.Location = new Point(32, 66);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(521, 19);
            lblSubtitulo.Text = "Um agente desktop de IA para código, criação, estratégia, estudo e produtividade.";

            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus.BackColor = Color.FromArgb(24, 128, 92);
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(725, 37);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(145, 34);
            lblStatus.Text = "● Pronto";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // pnlChat
            // 
            pnlChat.BackColor = Color.FromArgb(10, 15, 29);
            pnlChat.Dock = DockStyle.Fill;
            pnlChat.Margin = new Padding(0, 0, 0, 14);
            pnlChat.Padding = new Padding(24);
            pnlChat.Controls.Add(lblChatTitulo);
            pnlChat.Controls.Add(lblChatSubtitulo);
            pnlChat.Controls.Add(rtbChat);

            // 
            // lblChatTitulo
            // 
            lblChatTitulo.AutoSize = true;
            lblChatTitulo.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblChatTitulo.ForeColor = Color.White;
            lblChatTitulo.Location = new Point(24, 20);
            lblChatTitulo.Name = "lblChatTitulo";
            lblChatTitulo.Size = new Size(183, 25);
            lblChatTitulo.Text = "Conversa inteligente";

            // 
            // lblChatSubtitulo
            // 
            lblChatSubtitulo.AutoSize = true;
            lblChatSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblChatSubtitulo.ForeColor = Color.FromArgb(130, 146, 180);
            lblChatSubtitulo.Location = new Point(27, 48);
            lblChatSubtitulo.Name = "lblChatSubtitulo";
            lblChatSubtitulo.Size = new Size(420, 15);
            lblChatSubtitulo.Text = "As respostas com código são detectadas e formatadas automaticamente.";

            // 
            // rtbChat
            // 
            rtbChat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbChat.BackColor = Color.FromArgb(6, 10, 20);
            rtbChat.BorderStyle = BorderStyle.None;
            rtbChat.DetectUrls = true;
            rtbChat.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            rtbChat.ForeColor = Color.FromArgb(230, 237, 250);
            rtbChat.HideSelection = false;
            rtbChat.Location = new Point(24, 78);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.ScrollBars = RichTextBoxScrollBars.Both;
            rtbChat.Size = new Size(846, 354);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            rtbChat.WordWrap = false;

            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.FromArgb(13, 20, 38);
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Margin = new Padding(0);
            pnlInput.Padding = new Padding(24);
            pnlInput.Controls.Add(lblInputTitulo);
            pnlInput.Controls.Add(lblInputAjuda);
            pnlInput.Controls.Add(txtPergunta);
            pnlInput.Controls.Add(btnEnviar);
            pnlInput.Controls.Add(btnLimpar);

            // 
            // lblInputTitulo
            // 
            lblInputTitulo.AutoSize = true;
            lblInputTitulo.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblInputTitulo.ForeColor = Color.White;
            lblInputTitulo.Location = new Point(24, 18);
            lblInputTitulo.Name = "lblInputTitulo";
            lblInputTitulo.Size = new Size(119, 20);
            lblInputTitulo.Text = "Sua mensagem";

            // 
            // lblInputAjuda
            // 
            lblInputAjuda.AutoSize = true;
            lblInputAjuda.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            lblInputAjuda.ForeColor = Color.FromArgb(130, 146, 180);
            lblInputAjuda.Location = new Point(27, 42);
            lblInputAjuda.Name = "lblInputAjuda";
            lblInputAjuda.Size = new Size(201, 15);
            lblInputAjuda.Text = "Use CTRL + ENTER para enviar rápido.";

            // 
            // txtPergunta
            // 
            txtPergunta.AcceptsReturn = true;
            txtPergunta.AcceptsTab = true;
            txtPergunta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPergunta.BackColor = Color.FromArgb(20, 30, 55);
            txtPergunta.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtPergunta.ForeColor = Color.White;
            txtPergunta.Location = new Point(24, 66);
            txtPergunta.Multiline = true;
            txtPergunta.Name = "txtPergunta";
            txtPergunta.ScrollBars = ScrollBars.Vertical;
            txtPergunta.Size = new Size(646, 82);
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
            btnEnviar.Location = new Point(692, 66);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(178, 40);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;

            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpar.BackColor = Color.FromArgb(31, 44, 74);
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(692, 112);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(178, 36);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar conversa";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;

            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(10, 15, 29);
            pnlSidebar.Dock = DockStyle.Fill;
            pnlSidebar.Margin = new Padding(0);
            pnlSidebar.Padding = new Padding(18);
            pnlSidebar.Controls.Add(pnlSidebarHero);
            pnlSidebar.Controls.Add(pnlSidebarMission);
            pnlSidebar.Controls.Add(pnlSidebarRules);
            pnlSidebar.Controls.Add(pnlSidebarTips);

            // 
            // pnlSidebarHero
            // 
            pnlSidebarHero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSidebarHero.BackColor = Color.FromArgb(15, 23, 42);
            pnlSidebarHero.Location = new Point(18, 18);
            pnlSidebarHero.Name = "pnlSidebarHero";
            pnlSidebarHero.Size = new Size(310, 168);
            pnlSidebarHero.Controls.Add(lblSidebarLogo);
            pnlSidebarHero.Controls.Add(lblSidebarTitulo);
            pnlSidebarHero.Controls.Add(lblSidebarDescricao);

            // 
            // lblSidebarLogo
            // 
            lblSidebarLogo.BackColor = Color.FromArgb(91, 86, 255);
            lblSidebarLogo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblSidebarLogo.ForeColor = Color.White;
            lblSidebarLogo.Location = new Point(18, 18);
            lblSidebarLogo.Name = "lblSidebarLogo";
            lblSidebarLogo.Size = new Size(52, 52);
            lblSidebarLogo.Text = "L";
            lblSidebarLogo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // lblSidebarTitulo
            // 
            lblSidebarTitulo.AutoSize = true;
            lblSidebarTitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblSidebarTitulo.ForeColor = Color.White;
            lblSidebarTitulo.Location = new Point(84, 19);
            lblSidebarTitulo.Name = "lblSidebarTitulo";
            lblSidebarTitulo.Size = new Size(97, 25);
            lblSidebarTitulo.Text = "O Legado";

            // 
            // lblSidebarDescricao
            // 
            lblSidebarDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSidebarDescricao.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblSidebarDescricao.ForeColor = Color.FromArgb(178, 191, 222);
            lblSidebarDescricao.Location = new Point(85, 49);
            lblSidebarDescricao.Name = "lblSidebarDescricao";
            lblSidebarDescricao.Size = new Size(200, 96);
            lblSidebarDescricao.Text =
                "Agente de IA focado em transformar ideias em execução, com apoio para código, texto, estudo e estratégia.";

            // 
            // pnlSidebarMission
            // 
            pnlSidebarMission.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSidebarMission.BackColor = Color.FromArgb(13, 20, 38);
            pnlSidebarMission.Location = new Point(18, 202);
            pnlSidebarMission.Name = "pnlSidebarMission";
            pnlSidebarMission.Size = new Size(310, 140);
            pnlSidebarMission.Controls.Add(lblMissionTitulo);
            pnlSidebarMission.Controls.Add(lblMissionTexto);

            // 
            // lblMissionTitulo
            // 
            lblMissionTitulo.AutoSize = true;
            lblMissionTitulo.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblMissionTitulo.ForeColor = Color.White;
            lblMissionTitulo.Location = new Point(18, 16);
            lblMissionTitulo.Name = "lblMissionTitulo";
            lblMissionTitulo.Size = new Size(126, 20);
            lblMissionTitulo.Text = "Definição da IA";

            // 
            // lblMissionTexto
            // 
            lblMissionTexto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMissionTexto.Font = new Font("Segoe UI", 9.3F, FontStyle.Regular);
            lblMissionTexto.ForeColor = Color.FromArgb(175, 190, 222);
            lblMissionTexto.Location = new Point(18, 46);
            lblMissionTexto.Name = "lblMissionTexto";
            lblMissionTexto.Size = new Size(270, 82);
            lblMissionTexto.Text =
                "Clara, objetiva e estratégica. Responde em português do Brasil e prioriza soluções prontas para uso.";

            // 
            // pnlSidebarRules
            // 
            pnlSidebarRules.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSidebarRules.BackColor = Color.FromArgb(13, 20, 38);
            pnlSidebarRules.Location = new Point(18, 358);
            pnlSidebarRules.Name = "pnlSidebarRules";
            pnlSidebarRules.Size = new Size(310, 176);
            pnlSidebarRules.Controls.Add(lblRulesTitulo);
            pnlSidebarRules.Controls.Add(lblRulesTexto);

            // 
            // lblRulesTitulo
            // 
            lblRulesTitulo.AutoSize = true;
            lblRulesTitulo.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRulesTitulo.ForeColor = Color.White;
            lblRulesTitulo.Location = new Point(18, 16);
            lblRulesTitulo.Name = "lblRulesTitulo";
            lblRulesTitulo.Size = new Size(108, 20);
            lblRulesTitulo.Text = "Como usar";

            // 
            // lblRulesTexto
            // 
            lblRulesTexto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRulesTexto.Font = new Font("Segoe UI", 9.3F, FontStyle.Regular);
            lblRulesTexto.ForeColor = Color.FromArgb(175, 190, 222);
            lblRulesTexto.Location = new Point(18, 46);
            lblRulesTexto.Name = "lblRulesTexto";
            lblRulesTexto.Size = new Size(270, 118);
            lblRulesTexto.Text =
                "• Peça código completo quando quiser colar direto.\r\n" +
                "• Envie contexto para respostas melhores.\r\n" +
                "• Use CTRL + ENTER para enviar.\r\n" +
                "• Código é formatado automaticamente.";

            // 
            // pnlSidebarTips
            // 
            pnlSidebarTips.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSidebarTips.BackColor = Color.FromArgb(13, 20, 38);
            pnlSidebarTips.Location = new Point(18, 550);
            pnlSidebarTips.Name = "pnlSidebarTips";
            pnlSidebarTips.Size = new Size(310, 170);
            pnlSidebarTips.Controls.Add(lblTipsTitulo);
            pnlSidebarTips.Controls.Add(lblTipsTexto);

            // 
            // lblTipsTitulo
            // 
            lblTipsTitulo.AutoSize = true;
            lblTipsTitulo.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTipsTitulo.ForeColor = Color.White;
            lblTipsTitulo.Location = new Point(18, 16);
            lblTipsTitulo.Name = "lblTipsTitulo";
            lblTipsTitulo.Size = new Size(132, 20);
            lblTipsTitulo.Text = "Prompt ideal";

            // 
            // lblTipsTexto
            // 
            lblTipsTexto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTipsTexto.Font = new Font("Segoe UI", 9.3F, FontStyle.Regular);
            lblTipsTexto.ForeColor = Color.FromArgb(175, 190, 222);
            lblTipsTexto.Location = new Point(18, 46);
            lblTipsTexto.Name = "lblTipsTexto";
            lblTipsTexto.Size = new Size(270, 110);
            lblTipsTexto.Text =
                "\"Refatore esse código completo, mantendo compatibilidade com C# 7.3 e explique só o necessário.\"";

            // 
            // Controls
            // 
            Controls.Add(layoutRoot);

            pnlSidebarTips.ResumeLayout(false);
            pnlSidebarTips.PerformLayout();

            pnlSidebarRules.ResumeLayout(false);
            pnlSidebarRules.PerformLayout();

            pnlSidebarMission.ResumeLayout(false);
            pnlSidebarMission.PerformLayout();

            pnlSidebarHero.ResumeLayout(false);
            pnlSidebarHero.PerformLayout();

            pnlSidebar.ResumeLayout(false);

            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();

            pnlChat.ResumeLayout(false);
            pnlChat.PerformLayout();

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();

            layoutLeft.ResumeLayout(false);
            layoutContent.ResumeLayout(false);
            layoutRoot.ResumeLayout(false);

            ResumeLayout(false);
        }
    }
}