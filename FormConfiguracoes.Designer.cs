namespace Sistema_OS
{
    partial class FormConfiguracoes
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(112, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(448, 44);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(95, 20);
            this.lblRazaoSocial.TabIndex = 1;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(112, 112);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(76, 20);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Location = new System.Drawing.Point(112, 260);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(81, 20);
            this.lblTel1.TabIndex = 3;
            this.lblTel1.Text = "Telefone 1";
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(307, 260);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(81, 20);
            this.lblTel2.TabIndex = 4;
            this.lblTel2.Text = "Telefone 2";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(506, 262);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 27);
            this.txtNome.TabIndex = 6;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(448, 67);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(291, 27);
            this.txtRazaoSocial.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(112, 135);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(626, 111);
            this.txtDescricao.TabIndex = 8;
            this.txtDescricao.MouseHover += new System.EventHandler(this.txtDescricao_MouseHover);
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(112, 283);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(175, 27);
            this.txtTel1.TabIndex = 9;
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(307, 283);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(175, 27);
            this.txtTel2.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(506, 285);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 27);
            this.txtEmail.TabIndex = 11;
            // 
            // FormConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 518);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel2);
            this.Controls.Add(this.lblTel1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormConfiguracoes";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FormConfiguracoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblRazaoSocial;
        private Label lblDescricao;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNome;
        private TextBox txtRazaoSocial;
        private TextBox txtDescricao;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label lblTel1;
        private Label lblTel2;
        private Label lblEmail;
        private TextBox txtTel1;
        private TextBox txtTel2;
        private TextBox txtEmail;
        private ToolTip toolTip;
    }
}