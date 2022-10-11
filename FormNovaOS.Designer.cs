namespace Sistema_OS
{
    partial class FormNovaOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovaOS));
            this.tabelaClientes = new System.Windows.Forms.DataGridView();
            this.panelDireito = new System.Windows.Forms.Panel();
            this.lblNovaOS = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTrademark = new System.Windows.Forms.Label();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVisitas = new System.Windows.Forms.Button();
            this.btnNovaOS = new System.Windows.Forms.Button();
            this.btnAnotacoes = new System.Windows.Forms.Button();
            this.panelBotoes = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClientes)).BeginInit();
            this.panelDireito.SuspendLayout();
            this.panelEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelaClientes
            // 
            this.tabelaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaClientes.Location = new System.Drawing.Point(0, 5);
            this.tabelaClientes.Name = "tabelaClientes";
            this.tabelaClientes.RowHeadersVisible = false;
            this.tabelaClientes.RowHeadersWidth = 51;
            this.tabelaClientes.RowTemplate.Height = 29;
            this.tabelaClientes.Size = new System.Drawing.Size(539, 371);
            this.tabelaClientes.TabIndex = 0;
            // 
            // panelDireito
            // 
            this.panelDireito.Controls.Add(this.tabelaClientes);
            this.panelDireito.Location = new System.Drawing.Point(261, 73);
            this.panelDireito.Name = "panelDireito";
            this.panelDireito.Size = new System.Drawing.Size(539, 376);
            this.panelDireito.TabIndex = 1;
            // 
            // lblNovaOS
            // 
            this.lblNovaOS.AutoSize = true;
            this.lblNovaOS.Location = new System.Drawing.Point(96, 10);
            this.lblNovaOS.Name = "lblNovaOS";
            this.lblNovaOS.Size = new System.Drawing.Size(67, 20);
            this.lblNovaOS.TabIndex = 0;
            this.lblNovaOS.Text = "Nova OS";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(3, 53);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(120, 20);
            this.lblNomeCliente.TabIndex = 1;
            this.lblNomeCliente.Text = "Nome do cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(3, 76);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(160, 27);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(169, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTrademark
            // 
            this.lblTrademark.AutoSize = true;
            this.lblTrademark.Location = new System.Drawing.Point(0, 422);
            this.lblTrademark.Name = "lblTrademark";
            this.lblTrademark.Size = new System.Drawing.Size(188, 20);
            this.lblTrademark.TabIndex = 5;
            this.lblTrademark.Text = "SGrande Tecnologia - 2022";
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.Controls.Add(this.lblUsuario);
            this.panelEsquerdo.Controls.Add(this.lblTrademark);
            this.panelEsquerdo.Controls.Add(this.pictureBox1);
            this.panelEsquerdo.Controls.Add(this.btnBuscar);
            this.panelEsquerdo.Controls.Add(this.txtNomeCliente);
            this.panelEsquerdo.Controls.Add(this.lblNomeCliente);
            this.panelEsquerdo.Controls.Add(this.lblNovaOS);
            this.panelEsquerdo.Location = new System.Drawing.Point(1, -1);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(263, 450);
            this.panelEsquerdo.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(5, 171);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 20);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(336, 0);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 70);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVisitas
            // 
            this.btnVisitas.Location = new System.Drawing.Point(196, 0);
            this.btnVisitas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVisitas.Name = "btnVisitas";
            this.btnVisitas.Size = new System.Drawing.Size(140, 70);
            this.btnVisitas.TabIndex = 2;
            this.btnVisitas.Text = "Visitas";
            this.btnVisitas.UseVisualStyleBackColor = true;
            // 
            // btnNovaOS
            // 
            this.btnNovaOS.Location = new System.Drawing.Point(96, 0);
            this.btnNovaOS.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovaOS.Name = "btnNovaOS";
            this.btnNovaOS.Size = new System.Drawing.Size(100, 70);
            this.btnNovaOS.TabIndex = 1;
            this.btnNovaOS.Text = "Nova OS";
            this.btnNovaOS.UseVisualStyleBackColor = true;
            this.btnNovaOS.Click += new System.EventHandler(this.btnNovaOS_Click);
            // 
            // btnAnotacoes
            // 
            this.btnAnotacoes.Location = new System.Drawing.Point(0, 0);
            this.btnAnotacoes.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnotacoes.Name = "btnAnotacoes";
            this.btnAnotacoes.Size = new System.Drawing.Size(96, 70);
            this.btnAnotacoes.TabIndex = 0;
            this.btnAnotacoes.Text = "Anotações";
            this.btnAnotacoes.UseVisualStyleBackColor = true;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.btnAnotacoes);
            this.panelBotoes.Controls.Add(this.btnNovaOS);
            this.panelBotoes.Controls.Add(this.btnVisitas);
            this.panelBotoes.Controls.Add(this.btnEditar);
            this.panelBotoes.Location = new System.Drawing.Point(261, -1);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(539, 73);
            this.panelBotoes.TabIndex = 2;
            // 
            // FormNovaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.panelDireito);
            this.Controls.Add(this.panelEsquerdo);
            this.Name = "FormNovaOS";
            this.Text = "FormNovaOS";
            this.Load += new System.EventHandler(this.FormNovaOS_Load);
            this.ResizeEnd += new System.EventHandler(this.FormNovaOS_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClientes)).EndInit();
            this.panelDireito.ResumeLayout(false);
            this.panelEsquerdo.ResumeLayout(false);
            this.panelEsquerdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView tabelaClientes;
        private Panel panelDireito;
        private Label lblNovaOS;
        private Label lblNomeCliente;
        private TextBox txtNomeCliente;
        private Button btnBuscar;
        private Label lblTrademark;
        private Panel panelEsquerdo;
        private Label lblUsuario;
        private PictureBox pictureBox1;
        private Button btnEditar;
        private Button btnVisitas;
        private Button btnNovaOS;
        private Button btnAnotacoes;
        private FlowLayoutPanel panelBotoes;
    }
}