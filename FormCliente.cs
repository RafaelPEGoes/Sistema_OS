using FirebirdSql.Data.FirebirdClient;

namespace Sistema_OS
{
    public partial class FormCliente : Form
    {
        private int formWidth;
        private int formHeight;
        private int maxWidth = Screen.PrimaryScreen.Bounds.Width;
        private int maxHeight = Screen.PrimaryScreen.Bounds.Height;
        public bool isAddingClient;
        public string nomeCliente;

        public FormCliente()
        {
            InitializeComponent();
            this.MaximumSize = new Size(maxWidth, maxHeight);
            this.formWidth = this.Width;
            this.formHeight = this.Height;

        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            panelBotoes.Size = new Size(Convert.ToInt32(0.15 * formWidth), formHeight);
            panelBotoes.Dock = DockStyle.Left;

            panelCampos.Size = new Size(formWidth - panelBotoes.Width, formHeight);
            panelCampos.Dock = DockStyle.Right;

            int espacamentoVertical = Convert.ToInt32(0.01 * panelCampos.Height);

            lblNome.Location = new Point(Convert.ToInt32(0.1 * panelCampos.Width), Convert.ToInt32(0.05 * panelCampos.Height));

            int pontoInicialX = lblNome.Left;

            txtNomeCliente.Width = Convert.ToInt32(0.8 * panelCampos.Width);
            txtNomeCliente.Location = new Point(pontoInicialX, lblNome.Bottom + espacamentoVertical);

            lblEmail.Location = new Point(pontoInicialX, txtNomeCliente.Bottom + espacamentoVertical);

            txtEmail.Width = txtNomeCliente.Width;
            txtEmail.Location = new Point(pontoInicialX, lblEmail.Bottom + espacamentoVertical);

            lblCpfCnpj.Location = new Point(pontoInicialX, txtEmail.Bottom + espacamentoVertical);

            txtCpfCnpj.Width = Convert.ToInt32(0.375 * panelCampos.Width);
            txtCpfCnpj.Location = new Point(pontoInicialX, lblCpfCnpj.Bottom + espacamentoVertical);

            lblRgInscricao.Location = new Point(pontoInicialX + Convert.ToInt32(0.425 * panelCampos.Width), lblCpfCnpj.Bounds.Y);

            int pontoSecudarioX = lblRgInscricao.Left;

            txtRgInscricao.Width = txtCpfCnpj.Width;
            txtRgInscricao.Location = new Point(pontoSecudarioX, lblRgInscricao.Bottom + espacamentoVertical);

            lblTel1.Location = new Point(pontoInicialX, txtRgInscricao.Bottom + espacamentoVertical);

            txtTel1.Width = txtRgInscricao.Width;
            txtTel1.Location = new Point(pontoInicialX, lblTel1.Bottom + espacamentoVertical);

            lblTel2.Location = new Point(pontoSecudarioX, lblTel1.Bounds.Y);

            txtTel2.Width = txtTel1.Width;
            txtTel2.Location = new Point(pontoSecudarioX, lblTel2.Bottom + espacamentoVertical);

            lblCep.Location = new Point(pontoInicialX, txtTel2.Bottom + espacamentoVertical);

            txtCep.Width = txtTel2.Width;
            txtCep.Location = new Point(pontoInicialX, lblCep.Bottom + espacamentoVertical);

            btnPesquisarCep.Location = new Point(pontoSecudarioX, txtCep.Bounds.Y);

            int pontoXlblUF = pontoInicialX + txtCep.Width + Convert.ToInt32(0.05 * panelCampos.Width) + btnPesquisarCep.Width + Convert.ToInt32(0.05 * panelCampos.Width);
            lblUF.Location = new Point(pontoXlblUF, lblCep.Bounds.Y);

            //arrumar a width para preencher até os limites definidos nos outros campos

            cbUF.Width = Convert.ToInt32(txtNomeCliente.Width - pontoXlblUF);
            cbUF.Location = new Point(lblUF.Left, lblUF.Bottom + espacamentoVertical);

            lblCidade.Location = new Point(pontoInicialX, cbUF.Bottom + espacamentoVertical);

            txtCidade.Width = txtTel1.Width;
            txtCidade.Location = new Point(pontoInicialX, lblCidade.Bottom + espacamentoVertical);

            lblBairro.Location = new Point(pontoSecudarioX, lblCidade.Bounds.Y);

            txtBairro.Width = txtCidade.Width;
            txtBairro.Location = new Point(pontoSecudarioX, lblBairro.Bottom + espacamentoVertical);

            lblRuaLogradouro.Location = new Point(pontoInicialX, txtBairro.Bottom + espacamentoVertical);

            txtRuaLogradouro.Width = txtBairro.Width;
            txtRuaLogradouro.Location = new Point(pontoInicialX, lblRuaLogradouro.Bottom + espacamentoVertical);

            lblComplemento.Location = new Point(pontoSecudarioX, lblRuaLogradouro.Bounds.Y);

            txtComplemento.Location = new Point(pontoSecudarioX, lblComplemento.Bottom + espacamentoVertical);

            lblNum.Location = new Point(pontoInicialX + txtRuaLogradouro.Width + Convert.ToInt32(0.05 * panelCampos.Width) + txtComplemento.Width + Convert.ToInt32(0.05 * panelCampos.Width), lblRuaLogradouro.Bounds.Y);

            txtNum.Location = new Point(lblNum.Left, lblNum.Bottom + espacamentoVertical);

            btnCancelar.Size = new Size(Convert.ToInt32(panelCampos.Width / 2), Convert.ToInt32(0.1 * panelCampos.Height));
            btnCancelar.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;

            btnSalvar.Size = new Size(panelCampos.Width / 2, Convert.ToInt32(0.1 * panelCampos.Height));
            btnSalvar.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;

            int btnWidth = panelBotoes.Width;
            int btnHeight = Convert.ToInt32(0.12 * panelBotoes.Height);

            btnVoltar.Size = new Size(btnWidth, btnHeight);
            btnVoltar.Dock = DockStyle.Top;

            btnAparelhos.Size = new Size(btnWidth, btnHeight);
            btnAparelhos.Dock = DockStyle.Top;

            btnOSCliente.Size = new Size(btnWidth, btnHeight);
            btnOSCliente.Dock = DockStyle.Top;

            btnExtrato.Size = new Size(btnWidth, btnHeight);
            btnExtrato.Dock = DockStyle.Top;

            LoadClientInfo();

        }

        private void FormCliente_ResizeEnd(object sender, EventArgs e)
        {
            formWidth = this.Width;
            formHeight = this.Height;
            FormCadastroCliente_Load(sender, e);
        }

        private void FormCliente_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
            {
                formWidth = this.Width;
                formHeight = this.Height;
                FormCadastroCliente_Load(sender, e);
            }
        }
        private void FormCliente_Enter(object sender, EventArgs e)
        {
            LoadClientInfo();
        }
        private void LoadClientInfo()
        {

            if (!String.IsNullOrEmpty(nomeCliente))
            {
                DbFactory dbf = new();

                using (FbConnection conn = dbf.Connection())
                {
                    string query = "SELECT NOME, " +
                        "EMAIL, " +
                        "CNPJ_CPF, " +
                        "INSCEST_IDEN, " +
                        "TELEFONE1, " +
                        "TELEFONE2, " +
                        "CEP1, " +
                        "UF1, " +
                        "CIDADE1, " +
                        "BAIRRO1, " +
                        "ENDERECO1, " +
                        "COMPLEMENTO1, " +
                        "NUMERO_ENDERECO1 FROM CLIENTE WHERE NOME = @NOME";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NOME", nomeCliente);
                        cmd.Connection.Open();

                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            try
                            {
                                while (reader.Read())
                                {
                                    txtNomeCliente.Text = reader.GetString(0);
                                    txtEmail.Text = reader.GetString(1);
                                    txtCpfCnpj.Text = reader.GetString(2);
                                    txtRgInscricao.Text = reader.GetString(3);
                                    txtTel1.Text = reader.GetString(4);
                                    txtTel2.Text = reader.GetString(5);
                                    txtCep.Text = reader.GetString(6);
                                    cbUF.Text = reader.GetString(7);
                                    txtCidade.Text = reader.GetString(8);
                                    txtBairro.Text = reader.GetString(9);
                                    txtRuaLogradouro.Text = reader.GetString(10);
                                    txtComplemento.Text = reader.GetString(11);
                                    txtNum.Text = reader.GetString(12);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                reader.Close();
                                conn.Close();
                                conn.Dispose();
                            }
                        }
                    }

                }
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DbFactory dbf = new DbFactory();

            if (isAddingClient)
            {
                using (FbConnection conn = dbf.Connection())
                {
                    string query = "INSERT INTO CLIENTE BLABLABLA";
                    conn.Open();

                    using (FbTransaction transaction = conn.BeginTransaction())
                    {
                        using (FbCommand cmd = new FbCommand(query, conn, transaction))
                        {

                            try
                            {
                                cmd.ExecuteNonQuery();

                                if (isAddingClient)
                                {
                                    DialogResult dialog = MessageBox.Show("Cliente adicionado com sucesso! Deseja emitir nova O.S neste nome?", "Sucesso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    switch (dialog)
                                    {
                                        case DialogResult.Yes:
                                            FormAparelhosCliente formAparelhosCliente = new FormAparelhosCliente();
                                            formAparelhosCliente.Show();
                                            break;

                                        case DialogResult.No:
                                            break;
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }
                            finally
                            {
                                transaction.Rollback();
                                conn.Close();
                                transaction.Dispose();
                                conn.Dispose();
                            }
                        }
                    }
                }
            } else
            {
                FormAparelhosCliente aparelhosCliente = new FormAparelhosCliente();
                aparelhosCliente.Show();
            }


        }

    }
}
