using FirebirdSql.Data.FirebirdClient;
using MySql.Data.MySqlClient;

namespace Sistema_OS;

public partial class LoginView : Form
{
    private int formWidth;
    private int formHeight;
    private int maxWidth = Screen.PrimaryScreen.Bounds.Width;
    private int maxHeight = Screen.PrimaryScreen.Bounds.Height;
    private string connString = "server = 127.0.0.1; database=Sistema_OS;uid=root;pwd=jujuba99;";
    private bool isLogged;
    private bool isLoaded = false;
    public LoginView()
    {
        InitializeComponent();
        this.MaximumSize = new Size(maxWidth, maxHeight);
        formWidth = Convert.ToInt32(0.4 * maxWidth);
        formHeight = Convert.ToInt32(0.3 * maxHeight);
        isLogged = false;
        

        if(Properties.Settings.Default.salvarUsuarioChecado)
        {
            checkBoxUsuario.Checked = true;
        
        }
    }

    private void LoginView_Load(object sender, EventArgs e)
    {
        //this.MinimumSize = new Size(Convert.ToInt32(0.3* formWidth), Convert.ToInt32(0.2 * formHeight));
        //MessageBox.Show(MinimumSize.ToString());
        lblUsuario.Location = new Point(Convert.ToInt32(0), Convert.ToInt32(0.5 * formHeight));

        //configuracoes de responsividade do campo txtUsuario
        txtUsuario.Width = Convert.ToInt32(0.3 * formWidth);
        txtUsuario.Location = new Point(Convert.ToInt32((formWidth - txtUsuario.Width) / 2), lblUsuario.Bottom + Convert.ToInt32(0.01 * formHeight));

        lblSenha.Location = new Point(txtUsuario.Left, txtUsuario.Bottom + Convert.ToInt32(0.01 * formHeight));

        //configuracoes de responsividade do campo txtSenha
        txtSenha.Width = Convert.ToInt32(0.3 * formWidth);
        txtSenha.Location = new Point(Convert.ToInt32((formWidth - txtSenha.Width) / 2), lblSenha.Bottom + Convert.ToInt32(0.01 * formHeight));

        //configuracoes de responsivdade do btnEntrar
        btnEntrar.Width = Convert.ToInt32(0.1 * formWidth);
        btnEntrar.Location = new Point(txtSenha.Right - Convert.ToInt32(0.33 * txtSenha.Width), txtSenha.Bottom + Convert.ToInt32(0.02 * formHeight));

        //reestabelecendo o local de lblUsuario. Eixo X e inicializado com o valor 0
        //nao ha como definir somente aqui a sua localizacao, tendo em conta que
        //o txtUsuario depende de informacoes desse lbl para ser colocado no form
        lblUsuario.Location = new Point(txtUsuario.Left, Convert.ToInt32(0.5 * formHeight));

        //configuracoes de responsividade para pbLogo(PictureBox), imagem com o icone da SGRANDE no form
        pbLogo.Width = Convert.ToInt32(0.4 * formHeight);
        pbLogo.Height = Convert.ToInt32(0.4 * formHeight);
        pbLogo.Location = new Point(Convert.ToInt32((formWidth - pbLogo.Width) / 2), Convert.ToInt32(0.05 * formHeight));
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void LoginView_Resize(object sender, EventArgs e)
    {
        formWidth = this.Width;
        formHeight = this.Height;

        //mesmas configuracoes do LoginView_Load

        lblUsuario.Location = new Point(Convert.ToInt32(0), Convert.ToInt32(0.5 * formHeight));

        //configuracoes de responsividade do campo txtUsuario
        txtUsuario.Width = Convert.ToInt32(0.3 * formWidth);
        txtUsuario.Location = new Point(Convert.ToInt32((formWidth - txtUsuario.Width) / 2), lblUsuario.Bottom + Convert.ToInt32(0.01 * formHeight));

        lblSenha.Location = new Point(txtUsuario.Left, txtUsuario.Bottom + Convert.ToInt32(0.01 * formHeight));

        //configuracoes de responsividade do campo txtSenha
        txtSenha.Width = Convert.ToInt32(0.3 * formWidth);
        txtSenha.Location = new Point(Convert.ToInt32((formWidth - txtSenha.Width) / 2), lblSenha.Bottom + Convert.ToInt32(0.01 * formHeight));

        //configuracoes de responsivdade do btnEntrar
        btnEntrar.Width = Convert.ToInt32(0.1 * formWidth);
        btnEntrar.Location = new Point(txtSenha.Right - Convert.ToInt32(0.33 * txtSenha.Width), txtSenha.Bottom + Convert.ToInt32(0.02 * formHeight));

        //reestabelecendo o local de lblUsuario. Eixo X e inicializado com o valor 0
        //nao ha como definir somente aqui a sua localizacao, tendo em conta que
        //o txtUsuario depende de informacoes desse lbl para ser colocado no form
        lblUsuario.Location = new Point(txtUsuario.Left, Convert.ToInt32(0.5 * formHeight));

        //configuracoes de responsividade para pbLogo(PictureBox), imagem com o icone da SGRANDE no form
        pbLogo.Width = Convert.ToInt32(0.4 * formHeight);
        pbLogo.Height = Convert.ToInt32(0.4 * formHeight);
        pbLogo.Location = new Point(Convert.ToInt32((formWidth - pbLogo.Width) / 2), Convert.ToInt32(0.05 * formHeight));
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {
        if(this.ValidateChildren())
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    MySqlTransaction transaction;
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    cmd.Connection = conn;
                    cmd.Transaction = transaction;

                    try
                    {
                        cmd.CommandText = "SELECT username, pass FROM usuarios" +
                            " WHERE username = @username AND pass = @pass";
                        cmd.Parameters.AddWithValue("@username", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@pass", txtSenha.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                isLogged = true;
                                FormConfiguracoes configuracoes = new FormConfiguracoes();
                                this.Hide();
                                configuracoes.ShowDialog();
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha inválidos!", "Credenciais inválidas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtUsuario.Focus();
                                txtUsuario.SelectAll();
                                txtSenha.Clear();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }

        } else
        {
            var listOfErrors = this.errorProvider.ContainerControl.Controls.Cast<Control>()
                              .Select(c => this.errorProvider.GetError(c))
                              .Where(s => !string.IsNullOrEmpty(s))
                              .ToList();
            MessageBox.Show("Credenciais fornecidas são inválidas:\n - " +
                string.Join("\n - ", listOfErrors.ToArray()),
                "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //using (FbConnection conn = new FbConnection())
        //{
        //    using(FbTransaction transaction = conn.BeginTransaction())
        //    {
        //        string query = "";
        //        using (FbCommand cmd = new FbCommand(query, conn, transaction))
        //        {
        //            try
        //            {
        //                cmd.Connection.Open();
        //                cmd.ExecuteNonQuery();
        //                transaction.Commit();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //                transaction.Rollback();
        //            }
        //            finally
        //            {
        //                transaction.Dispose();
        //                conn.Close();
        //            }
        //        }
        //    } 

        //}
    }
    private void txtUsuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if(!txtSenha.Focused || !btnEntrar.Focused)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                errorProvider.SetError(txtUsuario, "Campo usuário não pode ser vazio!");

                e.Cancel = true;
            }
        }
        
    }

    private void txtUsuario_Validated(object sender, EventArgs e)
    {
        errorProvider.SetError(txtUsuario, "");
    }

    private void txtSenha_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if(String.IsNullOrEmpty(txtSenha.Text))
        {
            txtSenha.Focus();

            errorProvider.SetError(txtSenha, "Campo senha não pode ser vazio!");

            e.Cancel = true;
        }
    }

    private void txtSenha_Validated(object sender, EventArgs e)
    {
        errorProvider.SetError(txtSenha, "");
    }

    private void LoginView_FormClosing(object sender, FormClosingEventArgs e)
    {
        if(!isLogged)
        {
            DialogResult dialog = MessageBox.Show("Deseja encerrar a aplicação?", "Fechar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                this.FormClosing -= LoginView_FormClosing;
                this.Close();
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
        
    }

    private void checkBoxUsuario_CheckedChanged(object sender, EventArgs e)
    {
        if(checkBoxUsuario.Checked)
        {
            Properties.Settings.Default.salvarUsuarioChecado = true;
            if(isLoaded)
            {
                Properties.Settings.Default.usuarioPadrao = txtUsuario.Text;
                MessageBox.Show("Foi Salvo");
            }
            
        } else
        {
            MessageBox.Show("Passou por aqui");
            Properties.Settings.Default.usuarioPadrao = String.Empty;
        }

        Properties.Settings.Default.Save();
        MessageBox.Show(Properties.Settings.Default.usuarioPadrao.ToString());
        MessageBox.Show(Properties.Settings.Default.salvarUsuarioChecado.ToString());
    }

    private void LoginView_Shown(object sender, EventArgs e)
    {
        txtUsuario.Text = Properties.Settings.Default.usuarioPadrao;
        isLoaded = true;
    }
}