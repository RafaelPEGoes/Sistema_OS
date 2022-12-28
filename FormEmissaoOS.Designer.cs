namespace Sistema_OS
{
    partial class FormEmissaoOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmissaoOS));
            this.panelDireito = new System.Windows.Forms.Panel();
            this.btnSalvarImprimir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbVoltagem = new System.Windows.Forms.GroupBox();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.rbBivolt = new System.Windows.Forms.RadioButton();
            this.rbBateria12v = new System.Windows.Forms.RadioButton();
            this.rb220 = new System.Windows.Forms.RadioButton();
            this.rb110 = new System.Windows.Forms.RadioButton();
            this.rbNaoDeclarado = new System.Windows.Forms.RadioButton();
            this.gbTipoOS = new System.Windows.Forms.GroupBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtGarantiaDias = new System.Windows.Forms.TextBox();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.rbGarantia = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.gbAparelho = new System.Windows.Forms.GroupBox();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.gbDefeito = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtAcessorios = new System.Windows.Forms.TextBox();
            this.lblAcessórios = new System.Windows.Forms.Label();
            this.txtDefeito = new System.Windows.Forms.TextBox();
            this.lblDefeito = new System.Windows.Forms.Label();
            this.panelDireito.SuspendLayout();
            this.gbVoltagem.SuspendLayout();
            this.gbTipoOS.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbAparelho.SuspendLayout();
            this.gbDefeito.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDireito
            // 
            this.panelDireito.Controls.Add(this.btnSalvarImprimir);
            this.panelDireito.Controls.Add(this.btnSalvar);
            this.panelDireito.Controls.Add(this.btnCancelar);
            this.panelDireito.Controls.Add(this.gbVoltagem);
            this.panelDireito.Controls.Add(this.gbTipoOS);
            this.panelDireito.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDireito.Location = new System.Drawing.Point(726, 0);
            this.panelDireito.Name = "panelDireito";
            this.panelDireito.Size = new System.Drawing.Size(192, 586);
            this.panelDireito.TabIndex = 0;
            // 
            // btnSalvarImprimir
            // 
            this.btnSalvarImprimir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalvarImprimir.Location = new System.Drawing.Point(0, 517);
            this.btnSalvarImprimir.Name = "btnSalvarImprimir";
            this.btnSalvarImprimir.Size = new System.Drawing.Size(192, 59);
            this.btnSalvarImprimir.TabIndex = 4;
            this.btnSalvarImprimir.Text = "Salvar e Imprimir";
            this.btnSalvarImprimir.UseVisualStyleBackColor = true;
            this.btnSalvarImprimir.Click += new System.EventHandler(this.btnSalvarImprimir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalvar.Location = new System.Drawing.Point(0, 451);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(192, 66);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelar.Location = new System.Drawing.Point(0, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(192, 71);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbVoltagem
            // 
            this.gbVoltagem.Controls.Add(this.rbOutro);
            this.gbVoltagem.Controls.Add(this.rbBivolt);
            this.gbVoltagem.Controls.Add(this.rbBateria12v);
            this.gbVoltagem.Controls.Add(this.rb220);
            this.gbVoltagem.Controls.Add(this.rb110);
            this.gbVoltagem.Controls.Add(this.rbNaoDeclarado);
            this.gbVoltagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbVoltagem.Location = new System.Drawing.Point(0, 154);
            this.gbVoltagem.Name = "gbVoltagem";
            this.gbVoltagem.Size = new System.Drawing.Size(192, 226);
            this.gbVoltagem.TabIndex = 1;
            this.gbVoltagem.TabStop = false;
            this.gbVoltagem.Text = "Voltagem";
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.Location = new System.Drawing.Point(19, 185);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(68, 24);
            this.rbOutro.TabIndex = 5;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            // 
            // rbBivolt
            // 
            this.rbBivolt.AutoSize = true;
            this.rbBivolt.Location = new System.Drawing.Point(19, 155);
            this.rbBivolt.Name = "rbBivolt";
            this.rbBivolt.Size = new System.Drawing.Size(68, 24);
            this.rbBivolt.TabIndex = 4;
            this.rbBivolt.TabStop = true;
            this.rbBivolt.Text = "Bivolt";
            this.rbBivolt.UseVisualStyleBackColor = true;
            // 
            // rbBateria12v
            // 
            this.rbBateria12v.AutoSize = true;
            this.rbBateria12v.Location = new System.Drawing.Point(19, 125);
            this.rbBateria12v.Name = "rbBateria12v";
            this.rbBateria12v.Size = new System.Drawing.Size(106, 24);
            this.rbBateria12v.TabIndex = 3;
            this.rbBateria12v.TabStop = true;
            this.rbBateria12v.Text = "Bateria 12V";
            this.rbBateria12v.UseVisualStyleBackColor = true;
            // 
            // rb220
            // 
            this.rb220.AutoSize = true;
            this.rb220.Location = new System.Drawing.Point(19, 95);
            this.rb220.Name = "rb220";
            this.rb220.Size = new System.Drawing.Size(63, 24);
            this.rb220.TabIndex = 2;
            this.rb220.TabStop = true;
            this.rb220.Text = "220V";
            this.rb220.UseVisualStyleBackColor = true;
            // 
            // rb110
            // 
            this.rb110.AutoSize = true;
            this.rb110.Location = new System.Drawing.Point(19, 65);
            this.rb110.Name = "rb110";
            this.rb110.Size = new System.Drawing.Size(63, 24);
            this.rb110.TabIndex = 1;
            this.rb110.TabStop = true;
            this.rb110.Text = "110V";
            this.rb110.UseVisualStyleBackColor = true;
            // 
            // rbNaoDeclarado
            // 
            this.rbNaoDeclarado.AutoSize = true;
            this.rbNaoDeclarado.Location = new System.Drawing.Point(19, 35);
            this.rbNaoDeclarado.Name = "rbNaoDeclarado";
            this.rbNaoDeclarado.Size = new System.Drawing.Size(128, 24);
            this.rbNaoDeclarado.TabIndex = 0;
            this.rbNaoDeclarado.TabStop = true;
            this.rbNaoDeclarado.Text = "Não declarada";
            this.rbNaoDeclarado.UseVisualStyleBackColor = true;
            // 
            // gbTipoOS
            // 
            this.gbTipoOS.Controls.Add(this.lblDias);
            this.gbTipoOS.Controls.Add(this.txtGarantiaDias);
            this.gbTipoOS.Controls.Add(this.lblGarantia);
            this.gbTipoOS.Controls.Add(this.rbGarantia);
            this.gbTipoOS.Controls.Add(this.rbNormal);
            this.gbTipoOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTipoOS.Location = new System.Drawing.Point(0, 0);
            this.gbTipoOS.Name = "gbTipoOS";
            this.gbTipoOS.Size = new System.Drawing.Size(192, 154);
            this.gbTipoOS.TabIndex = 0;
            this.gbTipoOS.TabStop = false;
            this.gbTipoOS.Text = "Tipo OS";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(93, 111);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(39, 20);
            this.lblDias.TabIndex = 4;
            this.lblDias.Text = "dias.";
            // 
            // txtGarantiaDias
            // 
            this.txtGarantiaDias.Enabled = false;
            this.txtGarantiaDias.Location = new System.Drawing.Point(19, 108);
            this.txtGarantiaDias.Name = "txtGarantiaDias";
            this.txtGarantiaDias.Size = new System.Drawing.Size(68, 27);
            this.txtGarantiaDias.TabIndex = 3;
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Location = new System.Drawing.Point(19, 85);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(65, 20);
            this.lblGarantia.TabIndex = 2;
            this.lblGarantia.Text = "Garantia";
            // 
            // rbGarantia
            // 
            this.rbGarantia.AutoSize = true;
            this.rbGarantia.Location = new System.Drawing.Point(19, 58);
            this.rbGarantia.Name = "rbGarantia";
            this.rbGarantia.Size = new System.Drawing.Size(110, 24);
            this.rbGarantia.TabIndex = 1;
            this.rbGarantia.TabStop = true;
            this.rbGarantia.Text = "Em garantia";
            this.rbGarantia.UseVisualStyleBackColor = true;
            this.rbGarantia.CheckedChanged += new System.EventHandler(this.rbGarantia_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(19, 28);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(80, 24);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblEmail);
            this.gbCliente.Controls.Add(this.txtEmail);
            this.gbCliente.Controls.Add(this.txtCEP);
            this.gbCliente.Controls.Add(this.lblCEP);
            this.gbCliente.Controls.Add(this.lblUF);
            this.gbCliente.Controls.Add(this.cbUF);
            this.gbCliente.Controls.Add(this.txtCidade);
            this.gbCliente.Controls.Add(this.lblCidade);
            this.gbCliente.Controls.Add(this.txtBairro);
            this.gbCliente.Controls.Add(this.lblBairro);
            this.gbCliente.Controls.Add(this.txtEndereco);
            this.gbCliente.Controls.Add(this.lblEndereco);
            this.gbCliente.Controls.Add(this.txtTel);
            this.gbCliente.Controls.Add(this.lblTel);
            this.gbCliente.Controls.Add(this.txtNomeCliente);
            this.gbCliente.Controls.Add(this.lblNomeCliente);
            this.gbCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCliente.Location = new System.Drawing.Point(0, 0);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(726, 249);
            this.gbCliente.TabIndex = 1;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Informações do cliente";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 187);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(31, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 27);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtCEP
            // 
            this.txtCEP.Enabled = false;
            this.txtCEP.Location = new System.Drawing.Point(492, 157);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(198, 27);
            this.txtCEP.TabIndex = 13;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(492, 134);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(34, 20);
            this.lblCEP.TabIndex = 12;
            this.lblCEP.Text = "CEP";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(369, 134);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(26, 20);
            this.lblUF.TabIndex = 11;
            this.lblUF.Text = "UF";
            // 
            // cbUF
            // 
            this.cbUF.Enabled = false;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(370, 156);
            this.cbUF.Margin = new System.Windows.Forms.Padding(10);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(97, 28);
            this.cbUF.TabIndex = 10;
            this.cbUF.SelectedIndexChanged += new System.EventHandler(this.cbUF_SelectedIndexChanged);
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(31, 157);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(309, 27);
            this.txtCidade.TabIndex = 9;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(31, 134);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 20);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(370, 104);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(320, 27);
            this.txtBairro.TabIndex = 7;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(370, 82);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(49, 20);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(31, 104);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(309, 27);
            this.txtEndereco.TabIndex = 5;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(31, 81);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(71, 20);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(370, 210);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(320, 27);
            this.txtTel.TabIndex = 3;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(370, 187);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(66, 20);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Telefone";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(31, 51);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(659, 27);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(31, 28);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(55, 20);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Cliente";
            // 
            // gbAparelho
            // 
            this.gbAparelho.Controls.Add(this.dtpDataEntrada);
            this.gbAparelho.Controls.Add(this.lblData);
            this.gbAparelho.Controls.Add(this.txtNumSerie);
            this.gbAparelho.Controls.Add(this.lblNumSerie);
            this.gbAparelho.Controls.Add(this.txtModelo);
            this.gbAparelho.Controls.Add(this.lblModelo);
            this.gbAparelho.Controls.Add(this.txtFabricante);
            this.gbAparelho.Controls.Add(this.lblFabricante);
            this.gbAparelho.Controls.Add(this.txtGrupo);
            this.gbAparelho.Controls.Add(this.lblGrupo);
            this.gbAparelho.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAparelho.Location = new System.Drawing.Point(0, 249);
            this.gbAparelho.Name = "gbAparelho";
            this.gbAparelho.Size = new System.Drawing.Size(726, 145);
            this.gbAparelho.TabIndex = 2;
            this.gbAparelho.TabStop = false;
            this.gbAparelho.Text = "Informações do aparelho";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(564, 104);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(126, 27);
            this.dtpDataEntrada.TabIndex = 9;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(564, 82);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(96, 20);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data Entrada";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Enabled = false;
            this.txtNumSerie.Location = new System.Drawing.Point(382, 104);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(144, 27);
            this.txtNumSerie.TabIndex = 7;
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(382, 81);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(60, 20);
            this.lblNumSerie.TabIndex = 6;
            this.lblNumSerie.Text = "N. Série";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(31, 104);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(309, 27);
            this.txtModelo.TabIndex = 5;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(29, 81);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Enabled = false;
            this.txtFabricante.Location = new System.Drawing.Point(385, 51);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(305, 27);
            this.txtFabricante.TabIndex = 3;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(383, 28);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(77, 20);
            this.lblFabricante.TabIndex = 2;
            this.lblFabricante.Text = "Fabricante";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Enabled = false;
            this.txtGrupo.Location = new System.Drawing.Point(31, 51);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(309, 27);
            this.txtGrupo.TabIndex = 1;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(31, 28);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(50, 20);
            this.lblGrupo.TabIndex = 0;
            this.lblGrupo.Text = "Grupo";
            // 
            // gbDefeito
            // 
            this.gbDefeito.Controls.Add(this.txtObservacoes);
            this.gbDefeito.Controls.Add(this.lblObservacoes);
            this.gbDefeito.Controls.Add(this.txtAcessorios);
            this.gbDefeito.Controls.Add(this.lblAcessórios);
            this.gbDefeito.Controls.Add(this.txtDefeito);
            this.gbDefeito.Controls.Add(this.lblDefeito);
            this.gbDefeito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDefeito.Location = new System.Drawing.Point(0, 394);
            this.gbDefeito.Name = "gbDefeito";
            this.gbDefeito.Size = new System.Drawing.Size(726, 192);
            this.gbDefeito.TabIndex = 3;
            this.gbDefeito.TabStop = false;
            this.gbDefeito.Text = "Defeito, acessórios e observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(34, 155);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(656, 27);
            this.txtObservacoes.TabIndex = 5;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(34, 132);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(93, 20);
            this.lblObservacoes.TabIndex = 4;
            this.lblObservacoes.Text = "Observações";
            // 
            // txtAcessorios
            // 
            this.txtAcessorios.Location = new System.Drawing.Point(34, 102);
            this.txtAcessorios.Name = "txtAcessorios";
            this.txtAcessorios.Size = new System.Drawing.Size(656, 27);
            this.txtAcessorios.TabIndex = 3;
            // 
            // lblAcessórios
            // 
            this.lblAcessórios.AutoSize = true;
            this.lblAcessórios.Location = new System.Drawing.Point(34, 79);
            this.lblAcessórios.Name = "lblAcessórios";
            this.lblAcessórios.Size = new System.Drawing.Size(79, 20);
            this.lblAcessórios.TabIndex = 2;
            this.lblAcessórios.Text = "Acessórios";
            // 
            // txtDefeito
            // 
            this.txtDefeito.Location = new System.Drawing.Point(31, 49);
            this.txtDefeito.Name = "txtDefeito";
            this.txtDefeito.Size = new System.Drawing.Size(659, 27);
            this.txtDefeito.TabIndex = 1;
            // 
            // lblDefeito
            // 
            this.lblDefeito.AutoSize = true;
            this.lblDefeito.Location = new System.Drawing.Point(31, 26);
            this.lblDefeito.Name = "lblDefeito";
            this.lblDefeito.Size = new System.Drawing.Size(59, 20);
            this.lblDefeito.TabIndex = 0;
            this.lblDefeito.Text = "Defeito";
            // 
            // FormEmissaoOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 586);
            this.Controls.Add(this.gbDefeito);
            this.Controls.Add(this.gbAparelho);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.panelDireito);
            this.Name = "FormEmissaoOS";
            this.Text = "FormEmissaoOS";
            this.Load += new System.EventHandler(this.FormEmissaoOS_Load);
            this.Shown += new System.EventHandler(this.FormEmissaoOS_Shown);
            this.ResizeEnd += new System.EventHandler(this.FormEmissaoOS_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormEmissaoOS_Resize);
            this.panelDireito.ResumeLayout(false);
            this.gbVoltagem.ResumeLayout(false);
            this.gbVoltagem.PerformLayout();
            this.gbTipoOS.ResumeLayout(false);
            this.gbTipoOS.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbAparelho.ResumeLayout(false);
            this.gbAparelho.PerformLayout();
            this.gbDefeito.ResumeLayout(false);
            this.gbDefeito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDireito;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private GroupBox gbCliente;
        private GroupBox gbAparelho;
        private GroupBox gbDefeito;
        private GroupBox gbVoltagem;
        private GroupBox gbTipoOS;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtCEP;
        private Label lblCEP;
        private Label lblUF;
        private ComboBox cbUF;
        private TextBox txtCidade;
        private Label lblCidade;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtTel;
        private Label lblTel;
        private TextBox txtNomeCliente;
        private Label lblNomeCliente;
        private DateTimePicker dtpDataEntrada;
        private Label lblData;
        private TextBox txtNumSerie;
        private Label lblNumSerie;
        private TextBox txtModelo;
        private Label lblModelo;
        private TextBox txtFabricante;
        private Label lblFabricante;
        private TextBox txtGrupo;
        private Label lblGrupo;
        private TextBox txtObservacoes;
        private Label lblObservacoes;
        private TextBox txtAcessorios;
        private Label lblAcessórios;
        private TextBox txtDefeito;
        private Label lblDefeito;
        private Button btnSalvar;
        private Button btnCancelar;
        private RadioButton rbOutro;
        private RadioButton rbBivolt;
        private RadioButton rbBateria12v;
        private RadioButton rb220;
        private RadioButton rb110;
        private RadioButton rbNaoDeclarado;
        private RadioButton rbGarantia;
        private RadioButton rbNormal;
        private Button btnSalvarImprimir;
        private Label lblDias;
        private TextBox txtGarantiaDias;
        private Label lblGarantia;
    }
}