namespace Sistema_OS
{
    partial class FormConfiguracoes2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracoes2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.container = new System.Windows.Forms.SplitContainer();
            this.btnAlterarCorpoOS = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCorpoOS = new System.Windows.Forms.Label();
            this.btnAlterarFonteInfo = new System.Windows.Forms.Button();
            this.btnAlterarFonteTitulo = new System.Windows.Forms.Button();
            this.txtInfoAdicional = new System.Windows.Forms.TextBox();
            this.lblInfoAdicional = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.fontTituloDialog = new System.Windows.Forms.FontDialog();
            this.fontInfoDialog = new System.Windows.Forms.FontDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.container);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(883, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(3, 3);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.btnAlterarCorpoOS);
            this.container.Panel1.Controls.Add(this.textBox1);
            this.container.Panel1.Controls.Add(this.lblCorpoOS);
            this.container.Panel1.Controls.Add(this.btnAlterarFonteInfo);
            this.container.Panel1.Controls.Add(this.btnAlterarFonteTitulo);
            this.container.Panel1.Controls.Add(this.txtInfoAdicional);
            this.container.Panel1.Controls.Add(this.lblInfoAdicional);
            this.container.Panel1.Controls.Add(this.txtTitulo);
            this.container.Panel1.Controls.Add(this.lblTitulo);
            // 
            // container.Panel2
            // 
            this.container.Panel2.Controls.Add(this.btnSalvar);
            this.container.Panel2.Controls.Add(this.btnVisualizar);
            this.container.Panel2.Controls.Add(this.btnCancelar);
            this.container.Size = new System.Drawing.Size(877, 541);
            this.container.SplitterDistance = 472;
            this.container.TabIndex = 0;
            // 
            // btnAlterarCorpoOS
            // 
            this.btnAlterarCorpoOS.Location = new System.Drawing.Point(695, 266);
            this.btnAlterarCorpoOS.Name = "btnAlterarCorpoOS";
            this.btnAlterarCorpoOS.Size = new System.Drawing.Size(94, 29);
            this.btnAlterarCorpoOS.TabIndex = 8;
            this.btnAlterarCorpoOS.Text = "Alterar";
            this.btnAlterarCorpoOS.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 267);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(588, 127);
            this.textBox1.TabIndex = 7;
            // 
            // lblCorpoOS
            // 
            this.lblCorpoOS.AutoSize = true;
            this.lblCorpoOS.Location = new System.Drawing.Point(85, 243);
            this.lblCorpoOS.Name = "lblCorpoOS";
            this.lblCorpoOS.Size = new System.Drawing.Size(73, 20);
            this.lblCorpoOS.TabIndex = 6;
            this.lblCorpoOS.Text = "Corpo OS";
            // 
            // btnAlterarFonteInfo
            // 
            this.btnAlterarFonteInfo.Location = new System.Drawing.Point(695, 107);
            this.btnAlterarFonteInfo.Name = "btnAlterarFonteInfo";
            this.btnAlterarFonteInfo.Size = new System.Drawing.Size(94, 29);
            this.btnAlterarFonteInfo.TabIndex = 5;
            this.btnAlterarFonteInfo.Text = "Alterar";
            this.btnAlterarFonteInfo.UseVisualStyleBackColor = true;
            this.btnAlterarFonteInfo.Click += new System.EventHandler(this.btnAlterarFonteInfo_Click);
            // 
            // btnAlterarFonteTitulo
            // 
            this.btnAlterarFonteTitulo.Location = new System.Drawing.Point(695, 44);
            this.btnAlterarFonteTitulo.Name = "btnAlterarFonteTitulo";
            this.btnAlterarFonteTitulo.Size = new System.Drawing.Size(94, 29);
            this.btnAlterarFonteTitulo.TabIndex = 4;
            this.btnAlterarFonteTitulo.Text = "Alterar Fonte";
            this.btnAlterarFonteTitulo.UseVisualStyleBackColor = true;
            this.btnAlterarFonteTitulo.Click += new System.EventHandler(this.btnAlterarFonteTitulo_Click);
            // 
            // txtInfoAdicional
            // 
            this.txtInfoAdicional.Location = new System.Drawing.Point(85, 107);
            this.txtInfoAdicional.Multiline = true;
            this.txtInfoAdicional.Name = "txtInfoAdicional";
            this.txtInfoAdicional.Size = new System.Drawing.Size(588, 122);
            this.txtInfoAdicional.TabIndex = 3;
            this.txtInfoAdicional.TextChanged += new System.EventHandler(this.txtInfoAdicional_TextChanged);
            this.txtInfoAdicional.Leave += new System.EventHandler(this.txtInfoAdicional_Leave);
            // 
            // lblInfoAdicional
            // 
            this.lblInfoAdicional.AutoSize = true;
            this.lblInfoAdicional.Location = new System.Drawing.Point(85, 84);
            this.lblInfoAdicional.Name = "lblInfoAdicional";
            this.lblInfoAdicional.Size = new System.Drawing.Size(164, 20);
            this.lblInfoAdicional.TabIndex = 2;
            this.lblInfoAdicional.Text = "Informações Adicionais";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(85, 44);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(588, 27);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(85, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvar.Location = new System.Drawing.Point(581, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(299, 65);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVisualizar.Location = new System.Drawing.Point(282, 0);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(299, 65);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.Text = "Visualizar Impressão";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(282, 65);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(883, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(883, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(883, 547);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(883, 547);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(883, 547);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
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
            // FormConfiguracoes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 580);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormConfiguracoes2";
            this.Text = "FormConfiguracoes2";
            this.Load += new System.EventHandler(this.FormConfiguracoes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel1.PerformLayout();
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer container;
        private Button btnAlterarFonteInfo;
        private Button btnAlterarFonteTitulo;
        private TextBox txtInfoAdicional;
        private Label lblInfoAdicional;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private Button btnSalvar;
        private Button btnVisualizar;
        private Button btnCancelar;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private FontDialog fontTituloDialog;
        private FontDialog fontInfoDialog;
        private Button btnAlterarCorpoOS;
        private TextBox textBox1;
        private Label lblCorpoOS;
    }
}