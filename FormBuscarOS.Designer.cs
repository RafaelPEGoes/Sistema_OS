namespace Sistema_OS
{
    partial class FormBuscarOS
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpTodas = new System.Windows.Forms.TabPage();
            this.container = new System.Windows.Forms.SplitContainer();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.txtNumeroOS = new System.Windows.Forms.TextBox();
            this.lblNumeroOS = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.tabelaOS = new System.Windows.Forms.DataGridView();
            this.tpEmAberto = new System.Windows.Forms.TabPage();
            this.tpEmAndamento = new System.Windows.Forms.TabPage();
            this.tpConcluidas = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tpTodas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpTodas);
            this.tabControl.Controls.Add(this.tpEmAberto);
            this.tabControl.Controls.Add(this.tpEmAndamento);
            this.tabControl.Controls.Add(this.tpConcluidas);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1100, 560);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tpTodas
            // 
            this.tpTodas.Controls.Add(this.container);
            this.tpTodas.Location = new System.Drawing.Point(4, 29);
            this.tpTodas.Name = "tpTodas";
            this.tpTodas.Padding = new System.Windows.Forms.Padding(3);
            this.tpTodas.Size = new System.Drawing.Size(1092, 527);
            this.tpTodas.TabIndex = 0;
            this.tpTodas.Text = "Todas";
            this.tpTodas.UseVisualStyleBackColor = true;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.IsSplitterFixed = true;
            this.container.Location = new System.Drawing.Point(3, 3);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.lblDataFim);
            this.container.Panel1.Controls.Add(this.dtpDataFim);
            this.container.Panel1.Controls.Add(this.dtpDataInicio);
            this.container.Panel1.Controls.Add(this.lblDataInicio);
            this.container.Panel1.Controls.Add(this.txtNumeroOS);
            this.container.Panel1.Controls.Add(this.lblNumeroOS);
            this.container.Panel1.Controls.Add(this.btnPesquisar);
            this.container.Panel1.Controls.Add(this.textBox2);
            this.container.Panel1.Controls.Add(this.label1);
            this.container.Panel1.Controls.Add(this.txtNomeCliente);
            this.container.Panel1.Controls.Add(this.lblNomeCliente);
            // 
            // container.Panel2
            // 
            this.container.Panel2.Controls.Add(this.tabelaOS);
            this.container.Panel2.Padding = new System.Windows.Forms.Padding(30);
            this.container.Size = new System.Drawing.Size(1086, 521);
            this.container.SplitterDistance = 122;
            this.container.TabIndex = 0;
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(818, 12);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(32, 20);
            this.lblDataFim.TabIndex = 10;
            this.lblDataFim.Text = "Até";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(818, 35);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(125, 27);
            this.dtpDataFim.TabIndex = 9;
            this.dtpDataFim.ValueChanged += new System.EventHandler(this.dtpDataFim_ValueChanged);
            this.dtpDataFim.Leave += new System.EventHandler(this.dtpDataFim_Leave);
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(670, 35);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(125, 27);
            this.dtpDataInicio.TabIndex = 8;
            this.dtpDataInicio.ValueChanged += new System.EventHandler(this.dtpDataInicio_ValueChanged);
            this.dtpDataInicio.Leave += new System.EventHandler(this.dtpDataInicio_Leave);
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(670, 12);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(28, 20);
            this.lblDataInicio.TabIndex = 7;
            this.lblDataInicio.Text = "De";
            // 
            // txtNumeroOS
            // 
            this.txtNumeroOS.Location = new System.Drawing.Point(30, 38);
            this.txtNumeroOS.Name = "txtNumeroOS";
            this.txtNumeroOS.Size = new System.Drawing.Size(80, 27);
            this.txtNumeroOS.TabIndex = 6;
            this.txtNumeroOS.TextChanged += new System.EventHandler(this.txtNumeroOS_TextChanged);
            this.txtNumeroOS.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumeroOS_Validating);
            // 
            // lblNumeroOS
            // 
            this.lblNumeroOS.AutoSize = true;
            this.lblNumeroOS.Location = new System.Drawing.Point(30, 14);
            this.lblNumeroOS.Name = "lblNumeroOS";
            this.lblNumeroOS.Size = new System.Drawing.Size(49, 20);
            this.lblNumeroOS.TabIndex = 5;
            this.lblNumeroOS.Text = "Nº OS";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(962, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 29);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(425, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca, Aparelho ou Nº de Série";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(144, 38);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(252, 27);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            this.txtNomeCliente.Leave += new System.EventHandler(this.txtNomeCliente_Leave);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(144, 14);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome Cliente";
            // 
            // tabelaOS
            // 
            this.tabelaOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaOS.Location = new System.Drawing.Point(30, 30);
            this.tabelaOS.Name = "tabelaOS";
            this.tabelaOS.RowHeadersVisible = false;
            this.tabelaOS.RowHeadersWidth = 51;
            this.tabelaOS.RowTemplate.Height = 29;
            this.tabelaOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaOS.Size = new System.Drawing.Size(1026, 335);
            this.tabelaOS.TabIndex = 0;
            this.tabelaOS.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tabelaOS_DataBindingComplete);
            // 
            // tpEmAberto
            // 
            this.tpEmAberto.Location = new System.Drawing.Point(4, 29);
            this.tpEmAberto.Name = "tpEmAberto";
            this.tpEmAberto.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmAberto.Size = new System.Drawing.Size(1092, 527);
            this.tpEmAberto.TabIndex = 1;
            this.tpEmAberto.Text = "Em Aberto";
            this.tpEmAberto.UseVisualStyleBackColor = true;
            // 
            // tpEmAndamento
            // 
            this.tpEmAndamento.Location = new System.Drawing.Point(4, 29);
            this.tpEmAndamento.Name = "tpEmAndamento";
            this.tpEmAndamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmAndamento.Size = new System.Drawing.Size(1092, 527);
            this.tpEmAndamento.TabIndex = 2;
            this.tpEmAndamento.Text = "Em Andamento";
            this.tpEmAndamento.UseVisualStyleBackColor = true;
            // 
            // tpConcluidas
            // 
            this.tpConcluidas.Location = new System.Drawing.Point(4, 29);
            this.tpConcluidas.Name = "tpConcluidas";
            this.tpConcluidas.Padding = new System.Windows.Forms.Padding(3);
            this.tpConcluidas.Size = new System.Drawing.Size(1092, 527);
            this.tpConcluidas.TabIndex = 3;
            this.tpConcluidas.Text = "Concluídas";
            this.tpConcluidas.UseVisualStyleBackColor = true;
            // 
            // FormBuscarOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 560);
            this.Controls.Add(this.tabControl);
            this.Name = "FormBuscarOS";
            this.Text = "FormBuscarOS";
            this.Load += new System.EventHandler(this.FormBuscarOS_Load);
            this.tabControl.ResumeLayout(false);
            this.tpTodas.ResumeLayout(false);
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel1.PerformLayout();
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tpTodas;
        private TabPage tpEmAberto;
        private TabPage tpEmAndamento;
        private TabPage tpConcluidas;
        private SplitContainer container;
        private Button btnPesquisar;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label lblNomeCliente;
        private DataGridView tabelaOS;
        private Label lblDataFim;
        private DateTimePicker dtpDataFim;
        private DateTimePicker dtpDataInicio;
        private Label lblDataInicio;
        private TextBox txtNumeroOS;
        private Label lblNumeroOS;
        private TextBox txtNomeCliente;
    }
}