namespace Sistema_OS
{
    partial class FormPesquisaCliente
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
            this.container = new System.Windows.Forms.SplitContainer();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.tabelaCliente = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.btnNovo);
            this.container.Panel1.Controls.Add(this.btnPesquisar);
            this.container.Panel1.Controls.Add(this.txtNomeCliente);
            this.container.Panel1.Controls.Add(this.lblNomeCliente);
            // 
            // container.Panel2
            // 
            this.container.Panel2.Controls.Add(this.tabelaCliente);
            this.container.Size = new System.Drawing.Size(800, 450);
            this.container.SplitterDistance = 96;
            this.container.SplitterWidth = 1;
            this.container.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(286, 46);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(16, 47);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(253, 27);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(12, 9);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome Cliente";
            // 
            // tabelaCliente
            // 
            this.tabelaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCliente.Location = new System.Drawing.Point(0, 0);
            this.tabelaCliente.Name = "tabelaCliente";
            this.tabelaCliente.RowHeadersVisible = false;
            this.tabelaCliente.RowHeadersWidth = 51;
            this.tabelaCliente.RowTemplate.Height = 29;
            this.tabelaCliente.Size = new System.Drawing.Size(800, 352);
            this.tabelaCliente.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(667, 45);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 29);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo Cliente";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // FormPesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.container);
            this.Name = "FormPesquisaCliente";
            this.Text = "Pesquisar Cliente";
            this.Load += new System.EventHandler(this.FormPesquisaCliente_Load);
            this.ResizeEnd += new System.EventHandler(this.FormPesquisaCliente_ResizeEnd);
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel1.PerformLayout();
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer container;
        private TextBox txtNomeCliente;
        private Label lblNomeCliente;
        private DataGridView tabelaCliente;
        private Button btnPesquisar;
        private Button btnNovo;
    }
}