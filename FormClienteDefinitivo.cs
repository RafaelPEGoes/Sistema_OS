using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace Sistema_OS
{
    public partial class FormClienteDefinitivo : Form
    {
        private int formWidth;
        private int formHeight;
        private FormAparelhosCliente formAparelhosCliente;
        private FormEmissaoOS formEmissaoOS;
        public bool isAddingClient;
        public string nomeCliente;
        public FormClienteDefinitivo()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1050, 650);
            formWidth = this.MinimumSize.Width;
            formHeight = this.MinimumSize.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormOS3_Load(object sender, EventArgs e)
        {

            //esse vai ser o form cliente definitivo
            //os outros forms serão instanciados no panelSuperior
            panelBotoes.Width = Convert.ToInt32(0.15 * formWidth);
            panelSuperior.Width = Convert.ToInt32(0.8 * formWidth);

            if (this.Controls.Contains(panelInferior))
            {
                panelInferior.Height = Convert.ToInt32(0.1 * formHeight);
                panelSuperior.Height = Convert.ToInt32(0.85 * formHeight);
            }
            else
            {
                panelSuperior.Dock = DockStyle.Fill;
            }


            btnCancelar.Height = panelInferior.Height;
            btnCancelar.Width = panelInferior.Width / 2;

            btnSalvarProsseguir.Height = panelInferior.Height;
            btnSalvarProsseguir.Width = panelInferior.Width / 2;

        }
        public void LoadFinalForm()
        {
            panelSuperior.Controls.Clear();

            formEmissaoOS = new();
            formEmissaoOS.Width = panelSuperior.Width;
            formEmissaoOS.Height = panelSuperior.Height;
            formEmissaoOS.Dock = DockStyle.Fill;
            formEmissaoOS.TopLevel = false;
            formEmissaoOS.Visible = true;
            formEmissaoOS.FormBorderStyle = FormBorderStyle.None;

            panelSuperior.Controls.Add(formEmissaoOS);

        }

        private void FormOS3_ResizeEnd(object sender, EventArgs e)
        {
            formWidth = this.Width;
            formHeight = this.Height;

            if (panelSuperior.Controls.Contains(formAparelhosCliente))
            {
                formAparelhosCliente.formWidth = panelSuperior.Width;
                formAparelhosCliente.formHeight = panelSuperior.Height;
                formAparelhosCliente.FormAparelhosCliente_Load(sender, e);

            } else if(panelSuperior.Controls.Contains(formEmissaoOS))
            {
                formEmissaoOS.formWidth = panelSuperior.Width;
                formEmissaoOS.formHeight = panelSuperior.Height;
                formEmissaoOS.FormEmissaoOS_Load(sender, e);
            }

            FormOS3_Load(sender, e);
        }
        private void btnAparelhos_Click(object sender, EventArgs e)
        {
            LoadAparelhoClienteForm(sender, e);
        }
        private void btnSalvarProsseguir_Click(object sender, EventArgs e)
        {
            LoadAparelhoClienteForm(sender, e);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (panelSuperior.Controls.Contains(formAparelhosCliente))
            {
                this.Controls.Clear();
                this.InitializeComponent();
                LoadClientInfo();
                FormOS3_Load(sender, e);
            }
            else if (panelSuperior.Controls.Contains(formEmissaoOS))
            {
                this.panelSuperior.Controls.Clear();
                LoadAparelhoClienteForm(sender, e);
                this.panelSuperior.Controls.Add(formAparelhosCliente);
            }
        }
        private void FormClienteDefinitivo_Shown(object sender, EventArgs e)
        {
            LoadClientInfo();
        }

        private void LoadAparelhoClienteForm(object sender, EventArgs e)
        {
            this.Controls.Remove(panelInferior);
            panelSuperior.Controls.Clear();
            panelSuperior.Dock = DockStyle.Fill;
            panelSuperior.Padding = new Padding(0);

            bool isFormOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "FormAparelhoCliente")
                {
                    isFormOpen = true;
                    break;
                }
            }

            if (!isFormOpen)
            {
                formAparelhosCliente = new();
                formAparelhosCliente.FormBorderStyle = FormBorderStyle.None;
                formAparelhosCliente.TopLevel = false;
                formAparelhosCliente.Visible = true;

            }

            formAparelhosCliente.formWidth = panelSuperior.Width;
            formAparelhosCliente.formHeight = panelSuperior.Height;
            formAparelhosCliente.Dock = DockStyle.Fill;

            panelSuperior.Controls.Add(formAparelhosCliente);

            formAparelhosCliente.FormAparelhosCliente_Load(sender, e);

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

    }
}
