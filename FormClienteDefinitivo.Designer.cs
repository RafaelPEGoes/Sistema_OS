namespace Sistema_OS
{
    partial class FormClienteDefinitivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.btnOSCliente = new System.Windows.Forms.Button();
            this.btnAparelhos = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtRgInscricao = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtRuaLogradouro = new System.Windows.Forms.TextBox();
            this.lblRuaLogradouro = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.btnPesquisarCep = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblRgInscricao = new System.Windows.Forms.Label();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnSalvarProsseguir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBotoes.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotoes
            // 
            this.panelBotoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotoes.Controls.Add(this.btnExtrato);
            this.panelBotoes.Controls.Add(this.btnOSCliente);
            this.panelBotoes.Controls.Add(this.btnAparelhos);
            this.panelBotoes.Controls.Add(this.btnVoltar);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotoes.Location = new System.Drawing.Point(0, 0);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(193, 568);
            this.panelBotoes.TabIndex = 0;
            // 
            // btnExtrato
            // 
            this.btnExtrato.BackColor = System.Drawing.Color.Orange;
            this.btnExtrato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtrato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnExtrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtrato.Location = new System.Drawing.Point(0, 204);
            this.btnExtrato.Margin = new System.Windows.Forms.Padding(0);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(191, 71);
            this.btnExtrato.TabIndex = 8;
            this.btnExtrato.Text = "Extrato do Cliente";
            this.btnExtrato.UseVisualStyleBackColor = false;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // btnOSCliente
            // 
            this.btnOSCliente.BackColor = System.Drawing.Color.Orange;
            this.btnOSCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOSCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnOSCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOSCliente.Location = new System.Drawing.Point(0, 133);
            this.btnOSCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnOSCliente.Name = "btnOSCliente";
            this.btnOSCliente.Size = new System.Drawing.Size(191, 71);
            this.btnOSCliente.TabIndex = 7;
            this.btnOSCliente.Text = "O.S do Cliente";
            this.btnOSCliente.UseVisualStyleBackColor = false;
            // 
            // btnAparelhos
            // 
            this.btnAparelhos.BackColor = System.Drawing.Color.Orange;
            this.btnAparelhos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAparelhos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnAparelhos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAparelhos.Location = new System.Drawing.Point(0, 62);
            this.btnAparelhos.Margin = new System.Windows.Forms.Padding(0);
            this.btnAparelhos.Name = "btnAparelhos";
            this.btnAparelhos.Size = new System.Drawing.Size(191, 71);
            this.btnAparelhos.TabIndex = 6;
            this.btnAparelhos.Text = "Aparelhos";
            this.btnAparelhos.UseVisualStyleBackColor = false;
            this.btnAparelhos.Click += new System.EventHandler(this.btnAparelhos_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Orange;
            this.btnVoltar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(191, 62);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSuperior.Controls.Add(this.txtCep);
            this.panelSuperior.Controls.Add(this.txtRgInscricao);
            this.panelSuperior.Controls.Add(this.txtCpfCnpj);
            this.panelSuperior.Controls.Add(this.comboBox1);
            this.panelSuperior.Controls.Add(this.lblTipoPessoa);
            this.panelSuperior.Controls.Add(this.txtTel2);
            this.panelSuperior.Controls.Add(this.txtTel1);
            this.panelSuperior.Controls.Add(this.txtNum);
            this.panelSuperior.Controls.Add(this.lblNum);
            this.panelSuperior.Controls.Add(this.txtComplemento);
            this.panelSuperior.Controls.Add(this.lblComplemento);
            this.panelSuperior.Controls.Add(this.txtRuaLogradouro);
            this.panelSuperior.Controls.Add(this.lblRuaLogradouro);
            this.panelSuperior.Controls.Add(this.txtEmail);
            this.panelSuperior.Controls.Add(this.lblEmail);
            this.panelSuperior.Controls.Add(this.cbUF);
            this.panelSuperior.Controls.Add(this.lblUF);
            this.panelSuperior.Controls.Add(this.txtBairro);
            this.panelSuperior.Controls.Add(this.lblBairro);
            this.panelSuperior.Controls.Add(this.txtCidade);
            this.panelSuperior.Controls.Add(this.lblCidade);
            this.panelSuperior.Controls.Add(this.btnPesquisarCep);
            this.panelSuperior.Controls.Add(this.lblCep);
            this.panelSuperior.Controls.Add(this.lblRgInscricao);
            this.panelSuperior.Controls.Add(this.lblTel2);
            this.panelSuperior.Controls.Add(this.lblTel1);
            this.panelSuperior.Controls.Add(this.lblCpfCnpj);
            this.panelSuperior.Controls.Add(this.lblNome);
            this.panelSuperior.Controls.Add(this.txtNomeCliente);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(193, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelSuperior.Size = new System.Drawing.Size(817, 492);
            this.panelSuperior.TabIndex = 1;
            // 
            // txtCep
            // 
            this.txtCep.HidePromptOnLeave = true;
            this.txtCep.Location = new System.Drawing.Point(136, 292);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(223, 27);
            this.txtCep.TabIndex = 60;
            // 
            // txtRgInscricao
            // 
            this.txtRgInscricao.Location = new System.Drawing.Point(392, 162);
            this.txtRgInscricao.Name = "txtRgInscricao";
            this.txtRgInscricao.Size = new System.Drawing.Size(241, 27);
            this.txtRgInscricao.TabIndex = 59;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(136, 159);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(223, 27);
            this.txtCpfCnpj.TabIndex = 58;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.comboBox1.Location = new System.Drawing.Point(495, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 57;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.Location = new System.Drawing.Point(495, 77);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(87, 20);
            this.lblTipoPessoa.TabIndex = 56;
            this.lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(390, 226);
            this.txtTel2.Mask = "(99)99999-9999";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(243, 27);
            this.txtTel2.TabIndex = 55;
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(136, 226);
            this.txtTel1.Mask = "(99)99999-9999";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(223, 27);
            this.txtTel1.TabIndex = 54;
            this.txtTel1.TextChanged += new System.EventHandler(this.txtTel1_TextChanged);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(539, 435);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(94, 27);
            this.txtNum.TabIndex = 53;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(539, 412);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(63, 20);
            this.lblNum.TabIndex = 52;
            this.lblNum.Text = "Número";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(385, 435);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(136, 27);
            this.txtComplemento.TabIndex = 51;
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(385, 412);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(104, 20);
            this.lblComplemento.TabIndex = 50;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtRuaLogradouro
            // 
            this.txtRuaLogradouro.Location = new System.Drawing.Point(136, 434);
            this.txtRuaLogradouro.Name = "txtRuaLogradouro";
            this.txtRuaLogradouro.Size = new System.Drawing.Size(223, 27);
            this.txtRuaLogradouro.TabIndex = 49;
            this.txtRuaLogradouro.TextChanged += new System.EventHandler(this.txtRuaLogradouro_TextChanged);
            // 
            // lblRuaLogradouro
            // 
            this.lblRuaLogradouro.AutoSize = true;
            this.lblRuaLogradouro.Location = new System.Drawing.Point(136, 403);
            this.lblRuaLogradouro.Name = "lblRuaLogradouro";
            this.lblRuaLogradouro.Size = new System.Drawing.Size(118, 20);
            this.lblRuaLogradouro.TabIndex = 48;
            this.lblRuaLogradouro.Text = "Rua/Logradouro";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 27);
            this.txtEmail.TabIndex = 47;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(136, 77);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "Email";
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(495, 291);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(138, 28);
            this.cbUF.TabIndex = 45;
            this.cbUF.SelectedIndexChanged += new System.EventHandler(this.cbUF_SelectedIndexChanged);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(495, 268);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(26, 20);
            this.lblUF.TabIndex = 44;
            this.lblUF.Text = "UF";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(385, 364);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(248, 27);
            this.txtBairro.TabIndex = 43;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(385, 341);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(49, 20);
            this.lblBairro.TabIndex = 42;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(136, 364);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(223, 27);
            this.txtCidade.TabIndex = 41;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(136, 341);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 20);
            this.lblCidade.TabIndex = 40;
            this.lblCidade.Text = "Cidade";
            // 
            // btnPesquisarCep
            // 
            this.btnPesquisarCep.Location = new System.Drawing.Point(385, 290);
            this.btnPesquisarCep.Name = "btnPesquisarCep";
            this.btnPesquisarCep.Size = new System.Drawing.Size(94, 29);
            this.btnPesquisarCep.TabIndex = 39;
            this.btnPesquisarCep.Text = "Pesquisar";
            this.btnPesquisarCep.UseVisualStyleBackColor = true;
            this.btnPesquisarCep.Click += new System.EventHandler(this.btnPesquisarCep_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(136, 264);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 20);
            this.lblCep.TabIndex = 37;
            this.lblCep.Text = "CEP";
            // 
            // lblRgInscricao
            // 
            this.lblRgInscricao.AutoSize = true;
            this.lblRgInscricao.Location = new System.Drawing.Point(385, 136);
            this.lblRgInscricao.Name = "lblRgInscricao";
            this.lblRgInscricao.Size = new System.Drawing.Size(152, 20);
            this.lblRgInscricao.TabIndex = 35;
            this.lblRgInscricao.Text = "RG/Inscrição Estadual";
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(385, 199);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(36, 20);
            this.lblTel2.TabIndex = 33;
            this.lblTel2.Text = "Tel2";
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Location = new System.Drawing.Point(136, 199);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(36, 20);
            this.lblTel1.TabIndex = 31;
            this.lblTel1.Text = "Tel1";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(136, 136);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(71, 20);
            this.lblCpfCnpj.TabIndex = 29;
            this.lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(136, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Nome";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(136, 47);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(497, 27);
            this.txtNomeCliente.TabIndex = 28;
            // 
            // panelInferior
            // 
            this.panelInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInferior.Controls.Add(this.btnSalvarProsseguir);
            this.panelInferior.Controls.Add(this.btnCancelar);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(193, 494);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(817, 74);
            this.panelInferior.TabIndex = 2;
            // 
            // btnSalvarProsseguir
            // 
            this.btnSalvarProsseguir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvarProsseguir.Location = new System.Drawing.Point(421, 0);
            this.btnSalvarProsseguir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvarProsseguir.Name = "btnSalvarProsseguir";
            this.btnSalvarProsseguir.Size = new System.Drawing.Size(395, 72);
            this.btnSalvarProsseguir.TabIndex = 1;
            this.btnSalvarProsseguir.Text = "Salvar e Prosseguir";
            this.btnSalvarProsseguir.UseVisualStyleBackColor = true;
            this.btnSalvarProsseguir.Click += new System.EventHandler(this.btnSalvarProsseguir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(421, 72);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormClienteDefinitivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 568);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelBotoes);
            this.Name = "FormClienteDefinitivo";
            this.Text = "FormOS3";
            this.Load += new System.EventHandler(this.FormOS3_Load);
            this.Shown += new System.EventHandler(this.FormClienteDefinitivo_Shown);
            this.ResizeEnd += new System.EventHandler(this.FormOS3_ResizeEnd);
            this.panelBotoes.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBotoes;
        private Panel panelSuperior;
        private Panel panelInferior;
        private Button btnSalvarProsseguir;
        private Button btnCancelar;
        private TextBox txtNum;
        private Label lblNum;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private TextBox txtRuaLogradouro;
        private Label lblRuaLogradouro;
        private TextBox txtEmail;
        private Label lblEmail;
        private ComboBox cbUF;
        private Label lblUF;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtCidade;
        private Label lblCidade;
        private Button btnPesquisarCep;
        private Label lblCep;
        private Label lblRgInscricao;
        private Label lblTel2;
        private Label lblTel1;
        private Label lblCpfCnpj;
        private Label lblNome;
        private TextBox txtNomeCliente;
        private Button btnExtrato;
        private Button btnOSCliente;
        private Button btnAparelhos;
        private Button btnVoltar;
        private ErrorProvider errorProvider;
        private MaskedTextBox txtTel2;
        private MaskedTextBox txtTel1;
        private MaskedTextBox txtRgInscricao;
        private MaskedTextBox txtCpfCnpj;
        private ComboBox comboBox1;
        private Label lblTipoPessoa;
        private MaskedTextBox txtCep;
    }
}