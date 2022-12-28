namespace Sistema_OS
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFabricanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoGrupoDeAparelhosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.btnBuscarOS = new System.Windows.Forms.Button();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.btnNovaOS = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.clienteOSToolStripMenuItem,
            this.utilitáriosToolStripMenuItem,
            this.visitasToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.opçõesToolStripMenuItem.Text = "Opções";
            this.opçõesToolStripMenuItem.Click += new System.EventHandler(this.opçõesToolStripMenuItem_Click);
            // 
            // clienteOSToolStripMenuItem
            // 
            this.clienteOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordemDeServiçoToolStripMenuItem});
            this.clienteOSToolStripMenuItem.Name = "clienteOSToolStripMenuItem";
            this.clienteOSToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.clienteOSToolStripMenuItem.Text = "Cliente/O.S";
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordem de Serviço";
            this.ordemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.ordemDeServiçoToolStripMenuItem_Click);
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.novoProdutoToolStripMenuItem,
            this.novoServiçoToolStripMenuItem,
            this.novoFabricanteToolStripMenuItem,
            this.novoGrupoDeAparelhosToolStripMenuItem});
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.utilitáriosToolStripMenuItem.Text = "Cadastros";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // novoProdutoToolStripMenuItem
            // 
            this.novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            this.novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.novoProdutoToolStripMenuItem.Text = "Novo Produto";
            // 
            // novoServiçoToolStripMenuItem
            // 
            this.novoServiçoToolStripMenuItem.Name = "novoServiçoToolStripMenuItem";
            this.novoServiçoToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.novoServiçoToolStripMenuItem.Text = "Novo Serviço";
            // 
            // novoFabricanteToolStripMenuItem
            // 
            this.novoFabricanteToolStripMenuItem.Name = "novoFabricanteToolStripMenuItem";
            this.novoFabricanteToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.novoFabricanteToolStripMenuItem.Text = "Novo Fabricante";
            // 
            // novoGrupoDeAparelhosToolStripMenuItem
            // 
            this.novoGrupoDeAparelhosToolStripMenuItem.Name = "novoGrupoDeAparelhosToolStripMenuItem";
            this.novoGrupoDeAparelhosToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.novoGrupoDeAparelhosToolStripMenuItem.Text = "Novo Grupo de Aparelhos";
            // 
            // visitasToolStripMenuItem
            // 
            this.visitasToolStripMenuItem.Name = "visitasToolStripMenuItem";
            this.visitasToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.visitasToolStripMenuItem.Text = "Visitas";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.Controls.Add(this.btnBuscarOS);
            this.panelEsquerdo.Controls.Add(this.btnPesquisaCliente);
            this.panelEsquerdo.Controls.Add(this.btnNovaOS);
            this.panelEsquerdo.Controls.Add(this.btnNovoCliente);
            this.panelEsquerdo.Controls.Add(this.pbLogo);
            this.panelEsquerdo.Location = new System.Drawing.Point(0, 31);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(250, 417);
            this.panelEsquerdo.TabIndex = 1;
            // 
            // btnBuscarOS
            // 
            this.btnBuscarOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarOS.Location = new System.Drawing.Point(4, 278);
            this.btnBuscarOS.Name = "btnBuscarOS";
            this.btnBuscarOS.Size = new System.Drawing.Size(243, 29);
            this.btnBuscarOS.TabIndex = 4;
            this.btnBuscarOS.Text = "Buscar OS";
            this.btnBuscarOS.UseVisualStyleBackColor = true;
            this.btnBuscarOS.Click += new System.EventHandler(this.btnBuscarOS_Click);
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisaCliente.Location = new System.Drawing.Point(3, 246);
            this.btnPesquisaCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(244, 29);
            this.btnPesquisaCliente.TabIndex = 3;
            this.btnPesquisaCliente.Text = "Pesquisar Cliente";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // btnNovaOS
            // 
            this.btnNovaOS.FlatAppearance.BorderSize = 0;
            this.btnNovaOS.Location = new System.Drawing.Point(4, 212);
            this.btnNovaOS.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovaOS.Name = "btnNovaOS";
            this.btnNovaOS.Size = new System.Drawing.Size(243, 29);
            this.btnNovaOS.TabIndex = 2;
            this.btnNovaOS.Text = "Nova OS";
            this.btnNovaOS.UseVisualStyleBackColor = true;
            this.btnNovaOS.Click += new System.EventHandler(this.btnNovaOS_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.FlatAppearance.BorderSize = 0;
            this.btnNovoCliente.Location = new System.Drawing.Point(4, 177);
            this.btnNovoCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(246, 29);
            this.btnNovoCliente.TabIndex = 1;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Sistema_OS.Properties.Resources.SGrande;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(250, 174);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEsquerdo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPrincipal";
            this.Text = "Sistema OS";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelEsquerdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem clienteOSToolStripMenuItem;
        private ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private ToolStripMenuItem utilitáriosToolStripMenuItem;
        private ToolStripMenuItem visitasToolStripMenuItem;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem novoClienteToolStripMenuItem;
        private ToolStripMenuItem novoProdutoToolStripMenuItem;
        private ToolStripMenuItem novoServiçoToolStripMenuItem;
        private ToolStripMenuItem novoFabricanteToolStripMenuItem;
        private ToolStripMenuItem novoGrupoDeAparelhosToolStripMenuItem;
        private Panel panelEsquerdo;
        private PictureBox pbLogo;
        private Button btnPesquisaCliente;
        private Button btnNovaOS;
        private Button btnNovoCliente;
        private Button btnBuscarOS;
    }
}