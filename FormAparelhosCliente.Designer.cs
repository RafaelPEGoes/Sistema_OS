namespace Sistema_OS
{
    partial class FormAparelhosCliente
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
            this.txtEspecificacoes = new System.Windows.Forms.TextBox();
            this.lblEspecificacoes = new System.Windows.Forms.Label();
            this.tabelaAparelhos = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAparelhos)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEspecificacoes
            // 
            this.txtEspecificacoes.Location = new System.Drawing.Point(28, 45);
            this.txtEspecificacoes.Name = "txtEspecificacoes";
            this.txtEspecificacoes.Size = new System.Drawing.Size(454, 27);
            this.txtEspecificacoes.TabIndex = 1;
            this.txtEspecificacoes.TextChanged += new System.EventHandler(this.txtEspecificacoes_TextChanged);
            // 
            // lblEspecificacoes
            // 
            this.lblEspecificacoes.AutoSize = true;
            this.lblEspecificacoes.Location = new System.Drawing.Point(28, 22);
            this.lblEspecificacoes.Name = "lblEspecificacoes";
            this.lblEspecificacoes.Size = new System.Drawing.Size(260, 20);
            this.lblEspecificacoes.TabIndex = 0;
            this.lblEspecificacoes.Text = "Especificações do aparelho do cliente";
            // 
            // tabelaAparelhos
            // 
            this.tabelaAparelhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaAparelhos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaAparelhos.Location = new System.Drawing.Point(20, 20);
            this.tabelaAparelhos.Name = "tabelaAparelhos";
            this.tabelaAparelhos.RowHeadersVisible = false;
            this.tabelaAparelhos.RowHeadersWidth = 51;
            this.tabelaAparelhos.RowTemplate.Height = 29;
            this.tabelaAparelhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaAparelhos.Size = new System.Drawing.Size(760, 252);
            this.tabelaAparelhos.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.lblEspecificacoes);
            this.panelSuperior.Controls.Add(this.txtEspecificacoes);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 87);
            this.panelSuperior.TabIndex = 2;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.tabelaAparelhos);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 87);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Padding = new System.Windows.Forms.Padding(20);
            this.panelDataGrid.Size = new System.Drawing.Size(800, 292);
            this.panelDataGrid.TabIndex = 3;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.btnProximo);
            this.panelBotoes.Controls.Add(this.btnEditar);
            this.panelBotoes.Controls.Add(this.btnExcluir);
            this.panelBotoes.Controls.Add(this.btnAdicionar);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotoes.Location = new System.Drawing.Point(0, 385);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(800, 65);
            this.panelBotoes.TabIndex = 4;
            // 
            // btnProximo
            // 
            this.btnProximo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProximo.Location = new System.Drawing.Point(603, 0);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(197, 65);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditar.Location = new System.Drawing.Point(403, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(200, 65);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar Produto";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.Location = new System.Drawing.Point(209, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(194, 65);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir Produto";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdicionar.Location = new System.Drawing.Point(0, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(209, 65);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Novo Produto";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // FormAparelhosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panelSuperior);
            this.Name = "FormAparelhosCliente";
            this.Text = "FormAparelhosCliente";
            this.Load += new System.EventHandler(this.FormAparelhosCliente_Load);
            this.ResizeEnd += new System.EventHandler(this.FormAparelhosCliente_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAparelhos)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtEspecificacoes;
        private Label lblEspecificacoes;
        private DataGridView tabelaAparelhos;
        private Panel panelSuperior;
        private Panel panelDataGrid;
        private Panel panelBotoes;
        private Button btnProximo;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnAdicionar;
        private ToolTip toolTip;
    }
}