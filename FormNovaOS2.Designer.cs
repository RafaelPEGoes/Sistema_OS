namespace Sistema_OS
{
    partial class FormNovaOS2
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
            this.panelDireito = new System.Windows.Forms.Panel();
            this.tabelaClientes = new System.Windows.Forms.DataGridView();
            this.container = new System.Windows.Forms.SplitContainer();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panelDireito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDireito
            // 
            this.panelDireito.Controls.Add(this.tabelaClientes);
            this.panelDireito.Location = new System.Drawing.Point(265, 2);
            this.panelDireito.Name = "panelDireito";
            this.panelDireito.Size = new System.Drawing.Size(535, 448);
            this.panelDireito.TabIndex = 1;
            // 
            // tabelaClientes
            // 
            this.tabelaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaClientes.Location = new System.Drawing.Point(18, 12);
            this.tabelaClientes.MultiSelect = false;
            this.tabelaClientes.Name = "tabelaClientes";
            this.tabelaClientes.RowHeadersVisible = false;
            this.tabelaClientes.RowHeadersWidth = 51;
            this.tabelaClientes.RowTemplate.Height = 29;
            this.tabelaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaClientes.Size = new System.Drawing.Size(505, 424);
            this.tabelaClientes.TabIndex = 0;
            this.tabelaClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaClientes_CellContentDoubleClick);
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(0, 2);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.btnPesquisar);
            this.container.Panel1.Controls.Add(this.lblNome);
            this.container.Panel1.Controls.Add(this.txtCliente);
            // 
            // container.Panel2
            // 
            this.container.Panel2.Controls.Add(this.btnEditar);
            this.container.Panel2.Controls.Add(this.btnNovo);
            this.container.Size = new System.Drawing.Size(268, 448);
            this.container.SplitterDistance = 85;
            this.container.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(165, 33);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(12, 35);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(147, 27);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(0, 71);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(265, 67);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(3, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(265, 65);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo Cliente";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FormNovaOS2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panelDireito);
            this.Name = "FormNovaOS2";
            this.Text = "FormNovaOS2";
            this.Load += new System.EventHandler(this.FormNovaOS2_Load);
            this.ResizeEnd += new System.EventHandler(this.FormNovaOS2_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FormNovaOS2_SizeChanged);
            this.Resize += new System.EventHandler(this.FormNovaOS2_Resize);
            this.panelDireito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClientes)).EndInit();
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel1.PerformLayout();
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDireito;
        private SplitContainer container;
        private Button btnPesquisar;
        private Label lblNome;
        private TextBox textBox1;
        private Button btnEditar;
        private Button btnNovo;
        private DataGridView tabelaClientes;
        private TextBox txtCliente;
    }
}