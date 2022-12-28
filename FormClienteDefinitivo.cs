using System.Data;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Net.Mail;
using RestSharp;
using System.Text.RegularExpressions;
using System.Text.Json;
using Newtonsoft.Json;
namespace Sistema_OS
{
    public partial class FormClienteDefinitivo : Form
    {
        private int formWidth;
        private int formHeight;
        private FormAparelhosCliente formAparelhosCliente;
        private FormEmissaoOS formEmissaoOS;
        public bool isAddingClient;
        public int codigoCliente;
        public string nomeCliente;
        public Cliente cliente;
        public bool clientInfoModified;
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

            panelBotoes.Width = (int)(0.15 * formWidth);
            panelSuperior.Width = (int)(0.8 * formWidth);

            if (this.Controls.Contains(panelInferior))
            {
                panelInferior.Height = (int)(0.1 * formHeight);
                panelSuperior.Height = (int)(0.85 * formHeight);
            }
            else
            {
                panelSuperior.Dock = DockStyle.Fill;
            }

            switch(isAddingClient)
            {
                case true:
                    btnSalvarProsseguir.Text = "Salvar";
                    txtNomeCliente.ReadOnly = false;
                    txtCpfCnpj.ReadOnly = false;
                    txtRgInscricao.ReadOnly = false;
                    break;

                    case false:
                    txtNomeCliente.ReadOnly = true;
                    txtCpfCnpj.ReadOnly = true;
                    txtRgInscricao.ReadOnly = true;
                    break;

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

            }
            else if (panelSuperior.Controls.Contains(formEmissaoOS))
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

        private void CreateNewObjectClient()
        {
            cliente = new();
            this.cliente.SetNome(txtNomeCliente.Text);
            cliente.SetEmail(txtEmail.Text);
            cliente.SetCpfCnpj(txtCpfCnpj.Text);
            cliente.SetRgInscricaoEst(txtRgInscricao.Text);
            cliente.SetTel1(new string(txtTel1.Text.Where(Char.IsDigit).ToArray()));
            cliente.SetTel2(new string(txtTel2.Text.Where(Char.IsDigit).ToArray()));
            cliente.SetCep(txtCep.Text);
            cliente.SetUF(cbUF.Text);
            cliente.SetCidade(txtCidade.Text);
            cliente.SetBairro(txtBairro.Text);
            cliente.SetRuaLogradouro(txtRuaLogradouro.Text);
            cliente.SetComplemento(txtComplemento.Text);
            cliente.SetNumero(txtNum.Text);
            cliente.SetCodigo(codigoCliente.ToString());

        }
        private void btnSalvarProsseguir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNomeCliente.Text))
            {
                MessageBox.Show("Campo nome do cliente não pode ser vazio!", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCliente.Focus();
                return;
            }

            if(String.IsNullOrEmpty(txtCpfCnpj.Text))
            {
                MessageBox.Show("Campo CPF/CNPJ não pode ser vazio!", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpfCnpj.Focus();
                return;
            }

            if(String.IsNullOrEmpty(txtCep.Text))
            {
                MessageBox.Show("Campo CEP não pode ser vazio!", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Focus();
                return;
            }
            
            if(String.IsNullOrEmpty(cbUF.Text))
            {
                MessageBox.Show("Campo UF não pode ser vazio!", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbUF.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtRuaLogradouro.Text))
            {
                MessageBox.Show("Campo Rua/Logradouro não pode ser vazio!", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRuaLogradouro.Focus();
                return;
            }
            
            if (String.IsNullOrEmpty(txtNum.Text))
            {
                MessageBox.Show("Campo número do endereço não pode ser vazio!", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum.Focus();
                return;
            }
            
            if (String.IsNullOrEmpty(txtTel1.Text))
            {
                MessageBox.Show("Campo telefone 1 não pode ser vazio, forneça ao menos um número!", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTel1.Focus();
                return;
            }

            if (isAddingClient)
            {
                if (InsertNewClient())
                {
                    DialogResult dialog = MessageBox.Show("Cliente adicionado com sucesso! Deseja criar uma nova OS neste nome?",
                    "Salvo com sucesso!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    switch (dialog)
                    {
                        case DialogResult.Yes:
                            CreateNewObjectClient();
                            LoadAparelhoClienteForm(sender, e);
                            break;

                        case DialogResult.No:
                            this.Close();
                            break;
                    }
                }



            }
            else
            {
                DialogResult dialog;
                if (clientInfoModified)
                {
                    dialog = MessageBox.Show("Deseja salvar as alterações efetuadas nas informações do cliente?",
                        "Salvar alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (dialog)
                    {
                        case DialogResult.Yes:
                            CreateNewObjectClient();
                            UpdateClientInfo();
                            break;

                        case DialogResult.No:
                            LoadClientInfo();
                            break;
                    }

                }
                else
                {
                    dialog = MessageBox.Show("Confirma as informações do cliente? Não será possível alterá-las posteriormente.",
                    "Confira as informações do cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (dialog)
                    {
                        case DialogResult.Yes:
                            break;

                        case DialogResult.No:
                            txtEmail.Focus();
                            return;

                    }
                }

                LoadAparelhoClienteForm(sender, e);
            }

        }

        private void UpdateClientInfo()
        {
            DbFactory dbf = new();

            using (FbConnection conn = dbf.Connection())
            {
                conn.Open();

                using (FbTransaction transaction = conn.BeginTransaction())
                {

                    string query = "UPDATE CLIENTE SET " +
                        "NOME = @NOME, " +
                        "EMAIL = @EMAIL, " +
                        "CNPJ_CPF = @CNPJ_CPF, " +
                        "INSCEST_IDEN = @RGINSCRICAO, " +
                        "TELEFONE1 = @TEL1, " +
                        "TELEFONE2 = @TEL2, " +
                        "CEP1 = @CEP, " +
                        "UF1 = @UF, " +
                        "CIDADE1 = @CIDADE, " +
                        "BAIRRO1 = @BAIRRO, " +
                        "ENDERECO1 = @RUALOGRADOURO, " +
                        "NUMERO_ENDERECO1 = @NUM, " +
                        "COMPLEMENTO1 = @COMPLEMENTO " +
                        "WHERE CODIGO_CLIENTE = @ID_CLIENTE;";

                    using (FbCommand cmd = new(query, conn, transaction))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@NOME", txtNomeCliente.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@CNPJ_CPF", txtCpfCnpj.Text);
                            cmd.Parameters.AddWithValue("@RGINSCRICAO", txtRgInscricao.Text);
                            cmd.Parameters.AddWithValue("@TEL1", txtTel1.Text);
                            cmd.Parameters.AddWithValue("@TEL2", txtTel2.Text);
                            cmd.Parameters.AddWithValue("@CEP", txtCep.Text);
                            cmd.Parameters.AddWithValue("@UF", cbUF.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@CIDADE", txtCidade.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@BAIRRO", txtBairro.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@RUALOGRADOURO", txtRuaLogradouro.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@NUM", txtNum.Text);
                            cmd.Parameters.AddWithValue("@COMPLEMENTO", txtComplemento.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@ID_CLIENTE", cliente.GetCodigo());
                            
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Informações do cliente alteradas com sucesso!", "Informações salvas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            transaction.Commit();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            transaction.Rollback();

                        }
                        finally
                        {
                            conn.Close();
                            transaction.Dispose();
                            conn.Dispose();
                        }


                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (panelSuperior.Controls.Contains(formAparelhosCliente))
            {
                this.Controls.Clear();
                this.InitializeComponent();
                RetrieveClientInfo();
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
            if(!isAddingClient)
            {
                this.cliente = new Cliente();
                LoadClientInfo();
                RetrieveClientInfo();
                clientInfoModified = false;
            } else
            {
                txtNomeCliente.Focus();
            }

            if (String.IsNullOrEmpty(txtCpfCnpj.Text))
            {
                txtCpfCnpj.ReadOnly = false;
            }

            if (String.IsNullOrEmpty(txtRgInscricao.Text))
            {
                txtRgInscricao.ReadOnly = false;
            }


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

        private bool EmptyTextBoxes()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    MessageBox.Show(ctrl.Name.ToString());
                    if (!(ctrl.Name == "txtTel2") && !(ctrl.Name == "txtEmail"))
                    {
                        if (String.IsNullOrEmpty(ctrl.Text))
                        {
                            MessageBox.Show("Campo não pode ser nulo!", "Campos vazios!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            ctrl.Focus();
                            return true;
                        }
                    }
                }

            }

            return false;
        }

        private bool InsertNewClient()
        {

            DbFactory dbf = new();

            using (FbConnection conn = dbf.Connection())
            {
                conn.Open();
                using (FbTransaction transaction = conn.BeginTransaction())
                {
                    string query = "INSERT INTO CLIENTE (NOME, EMAIL, CNPJ_CPF, INSCEST_IDEN," +
                        "TELEFONE1, TELEFONE2, CEP1, UF1, CIDADE1, BAIRRO1, ENDERECO1, " +
                        "COMPLEMENTO1, NUMERO_ENDERECO1, CODIGO_ATIVIDADE) " +
                        "VALUES ( " +
                        "@NOME, " +
                        "@EMAIL, " +
                        "@CNPJ_CPF, " +
                        "@INSCEST_IDEN, " +
                        "@TELEFONE1, " +
                        "@TELEFONE2, " +
                        "@CEP1, " +
                        "@UF1, " +
                        "@CIDADE1, " +
                        "@BAIRRO1, " +
                        "@ENDERECO1, " +
                        "@COMPLEMENTO1, " +
                        "@NUMERO_ENDERECO1, " +
                        "@CODIGO_ATIVIDADE);";

                    using (FbCommand cmd = new FbCommand(query, conn, transaction))
                    {

                        try
                        {

                            cmd.Parameters.AddWithValue("@NOME", txtNomeCliente.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@CNPJ_CPF", txtCpfCnpj.Text);
                            cmd.Parameters.AddWithValue("@INSCEST_IDEN", txtRgInscricao.Text);
                            cmd.Parameters.AddWithValue("@TELEFONE1", txtTel1.Text);
                            cmd.Parameters.AddWithValue("@TELEFONE2", txtTel2.Text);
                            cmd.Parameters.AddWithValue("@CEP1", txtCep.Text);
                            cmd.Parameters.AddWithValue("@UF1", cbUF.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@CIDADE1", txtCidade.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@BAIRRO1", txtBairro.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@ENDERECO1", txtRuaLogradouro.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@COMPLEMENTO1", txtComplemento.Text);
                            cmd.Parameters.AddWithValue("@NUMERO_ENDERECO1", txtNum.Text);
                            cmd.Parameters.AddWithValue("@CODIGO_ATIVIDADE", 1);
                            cmd.ExecuteNonQuery();
                            transaction.Commit();
                            return true;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            transaction.Rollback();
                            return false;
                        }
                        finally
                        {
                            conn.Close();
                            transaction.Dispose();
                            conn.Dispose();
                        }

                    }
                }
            }



        }

        private void ValidarCPFCNPJ(string cpfCnpj)
        {
            if (String.IsNullOrEmpty(cpfCnpj))
            {
                MessageBox.Show("Campo CPF/CNPJ vazio!", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCpfCnpj.Focus();
                return;
            }

            if (cpfCnpj.Length < 9)
            {
                MessageBox.Show("Por favor insira um CPF ou CNPJ válido!", "CPF/CNPJ inválido!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCpfCnpj.Focus();
            }

        }

        private void RetrieveClientInfo()
        {

            txtNomeCliente.Text = cliente.GetNome();
            txtEmail.Text = cliente.GetEmail();
            txtCpfCnpj.Text = cliente.GetCpfCnpj();
            txtRgInscricao.Text = cliente.GetRgInscricaoEst();
            txtTel1.Text = cliente.GetTel1();
            txtTel2.Text = cliente.GetTel2();
            txtCep.Text = cliente.GetCep();
            cbUF.Text = cliente.GetUF();
            txtCidade.Text = cliente.GetCidade();
            txtBairro.Text = cliente.GetBairro();
            txtRuaLogradouro.Text = cliente.GetRuaLogradouro();
            txtComplemento.Text = cliente.GetComplemento();
            txtNum.Text = cliente.GetNumero();
            comboBox1.Text = cliente.GetTipoPessoa();

        }
        private void LoadClientInfo()
        {

            if (!String.IsNullOrEmpty(codigoCliente.ToString()))
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
                        "NUMERO_ENDERECO1," +
                        "CODIGO_CLIENTE, " +
                        "TIPO_PESSOA FROM CLIENTE WHERE CODIGO_CLIENTE = @CODIGO";

                    using (FbCommand cmd = new FbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CODIGO", codigoCliente);
                        cmd.Connection.Open();

                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            try
                            {
                                while (reader.Read())
                                {

                                    this.cliente.SetNome(reader.GetString(0));
                                    cliente.SetEmail(reader.GetString(1));
                                    cliente.SetCpfCnpj(reader.GetString(2));
                                    cliente.SetRgInscricaoEst(reader.GetString(3));
                                    cliente.SetTel1(new String(reader.GetString(4).Where(Char.IsDigit).ToArray()));
                                    cliente.SetTel2(new String(reader.GetString(5).Where(Char.IsDigit).ToArray()));
                                    cliente.SetCep(reader.GetString(6));
                                    cliente.SetUF(reader.GetString(7));
                                    cliente.SetCidade(reader.GetString(8));
                                    cliente.SetBairro(reader.GetString(9));
                                    cliente.SetRuaLogradouro(reader.GetString(10));
                                    cliente.SetComplemento(reader.GetString(11));
                                    cliente.SetNumero(reader.GetString(12));
                                    cliente.SetCodigo(reader.GetString(13));
                                    
                                    switch(reader.GetString(14))
                                    {
                                        case "F":
                                            cliente.SetTipoPessoa("Física");
                                            break;

                                        case "J":
                                            cliente.SetTipoPessoa("Jurídica");
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
                                reader.Close();
                                conn.Close();
                                conn.Dispose();
                            }
                        }
                    }

                }
            }

        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            FormExtrato frm = new FormExtrato();
            frm.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            clientInfoModified = true;
        }

        private void txtTel1_TextChanged(object sender, EventArgs e)
        {
            clientInfoModified = true;

            if (!txtTel1.MaskFull)
            {
                errorProvider.SetError(txtTel1, "Número inválido!");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtTel2_TextChanged(object sender, EventArgs e)
        {
            clientInfoModified = true;

            if (!txtTel2.MaskFull)
            {
                errorProvider.SetError(txtTel1, "Número inválido!");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            clientInfoModified = true;

            if(!txtCep.MaskFull)
            {
                errorProvider.SetError(txtCep, "CEP inválido!");
            } else
            {
                errorProvider.Clear();
            }
        }

        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientInfoModified = true;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            clientInfoModified = true;
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            clientInfoModified = true;
        }

        private void txtRuaLogradouro_TextChanged(object sender, EventArgs e)
        {
            clientInfoModified = true;
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            clientInfoModified = true;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            clientInfoModified = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isAddingClient || (String.IsNullOrEmpty(txtCpfCnpj.Text) && String.IsNullOrEmpty(txtRgInscricao.Text)))
            {
                switch (comboBox1.Text)
                {
                    case "Física":
                        txtCpfCnpj.Mask = "999,999,999-99";
                        txtRgInscricao.Mask = "99,999,999-99";
                        break;

                    case "Jurídica":
                        txtCpfCnpj.Mask = "99,999,999/9999-99";
                        txtRgInscricao.Mask = "999,999,999,999";
                        break;
                }
            }
            
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            if(!txtCep.MaskFull)
            {
                return;
            }

            using (RestClient client = new RestClient(String.Format("https://viacep.com.br/ws", txtCep.Text)))
            {
                RestRequest request = new RestRequest("{cep}/json/", Method.Get).AddUrlSegment("cep", $"{txtCep.Text}");

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Houve um problema na requisição, contacte o administrador do sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    try
                    {
                        Endereco endereco = JsonConvert.DeserializeObject<Endereco>(response.Content);

                        txtBairro.Text = endereco.GetBairro();
                        MessageBox.Show(endereco.GetBairro());
                        
                    } catch(Exception ex)
                    {
                        MessageBox.Show($"Erro na requisição: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }


            }
         
        }
    }
}
