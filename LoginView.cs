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
        formWidth = (int)(0.4 * maxWidth);
        formHeight = (int)(0.3 * maxHeight);
        isLogged = false;


        if (Properties.Settings.Default.salvarUsuarioChecado)
        {
            checkBoxUsuario.Checked = true;

        }
    }

    private void LoginView_Load(object sender, EventArgs e)
    {
        //this.MinimumSize = new Size((int)(0.3* formWidth), (int)(0.2 * formHeight));
        lblUsuario.Location = new Point((int)(0), (int)(0.5 * formHeight));

        //configuracoes de responsividade do campo txtUsuario
        txtUsuario.Width = (int)(0.3 * formWidth);
        txtUsuario.Location = new Point((int)((formWidth - txtUsuario.Width) / 2), lblUsuario.Bottom + (int)(0.02 * formHeight));

        lblSenha.Location = new Point(txtUsuario.Left, txtUsuario.Bottom + (int)(0.02 * formHeight));

        //configuracoes de responsividade do campo txtSenha
        txtSenha.Width = (int)(0.3 * formWidth);
        txtSenha.Location = new Point((int)((formWidth - txtSenha.Width) / 2), lblSenha.Bottom + (int)(0.02 * formHeight));

        //configuracoes de responsivdade do btnEntrar
        btnEntrar.Width = (int)(0.1 * formWidth);
        btnEntrar.Location = new Point(txtSenha.Right - (int)(0.33 * txtSenha.Width), txtSenha.Bottom + (int)(0.04 * formHeight));

        //reestabelecendo o local de lblUsuario. Eixo X e inicializado com o valor 0
        //nao ha como definir somente aqui a sua localizacao, tendo em conta que
        //o txtUsuario depende de informacoes desse lbl para ser colocado no form
        lblUsuario.Location = new Point(txtUsuario.Left, (int)(0.5 * formHeight));

        //configuracoes de responsividade para pbLogo(PictureBox), imagem com o icone da SGRANDE no form
        pbLogo.Width = (int)(0.4 * formHeight);
        pbLogo.Height = (int)(0.4 * formHeight);
        pbLogo.Location = new Point((int)((formWidth - pbLogo.Width) / 2), (int)(0.05 * formHeight));
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;

        //configuracoes de responsividade de checkBoxUsuario
        checkBoxUsuario.Location = new Point(txtUsuario.Right + (int)(0.01 * formWidth), txtUsuario.Bounds.Y);

        //linka a lista de usuários validos que já acessaram o sistema e os coloca na
        //opcao de autocomplete do textbox.
        txtUsuario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        txtUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
        txtUsuario.AutoCompleteCustomSource = listaUsuariosValidos();

    }

    private void LoginView_Resize(object sender, EventArgs e)
    {
        //formWidth = this.Width;
        //formHeight = this.Height;

        ////mesmas configuracoes do LoginView_Load

        //lblUsuario.Location = new Point((int)(0), (int)(0.5 * formHeight));

        ////configuracoes de responsividade do campo txtUsuario
        //txtUsuario.Width = (int)(0.3 * formWidth);
        //txtUsuario.Location = new Point((int)((formWidth - txtUsuario.Width) / 2), lblUsuario.Bottom + (int)(0.01 * formHeight));

        //lblSenha.Location = new Point(txtUsuario.Left, txtUsuario.Bottom + (int)(0.01 * formHeight));

        ////configuracoes de responsividade do campo txtSenha
        //txtSenha.Width = (int)(0.3 * formWidth);
        //txtSenha.Location = new Point((int)((formWidth - txtSenha.Width) / 2), lblSenha.Bottom + (int)(0.01 * formHeight));

        ////configuracoes de responsivdade do btnEntrar
        //btnEntrar.Width = (int)(0.1 * formWidth);
        //btnEntrar.Location = new Point(txtSenha.Right - (int)(0.33 * txtSenha.Width), txtSenha.Bottom + (int)(0.02 * formHeight));

        ////reestabelecendo o local de lblUsuario. Eixo X e inicializado com o valor 0
        ////nao ha como definir somente aqui a sua localizacao, tendo em conta que
        ////o txtUsuario depende de informacoes desse lbl para ser colocado no form
        //lblUsuario.Location = new Point(txtUsuario.Left, (int)(0.5 * formHeight));

        //checkBoxUsuario.Location = new Point(txtUsuario.Right + (int)(0.01 * formWidth), txtUsuario.Bounds.Y);

        ////configuracoes de responsividade para pbLogo(PictureBox), imagem com o icone da SGRANDE no form
        //pbLogo.Width = (int)(0.4 * formHeight);
        //pbLogo.Height = (int)(0.4 * formHeight);
        //pbLogo.Location = new Point((int)((formWidth - pbLogo.Width) / 2), (int)(0.05 * formHeight));
        //pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private AutoCompleteStringCollection listaUsuariosValidos()
    {
        AutoCompleteStringCollection listaUsuariosValidos = new AutoCompleteStringCollection();

        if (Properties.Settings.Default.listaUsuariosValidosSalvos is not null)
        {
            foreach (String usuario in Properties.Settings.Default.listaUsuariosValidosSalvos)
            {
                listaUsuariosValidos.Add(usuario);
            }
        }

        return listaUsuariosValidos;
    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {
        if (this.ValidateChildren())
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
                                FormPrincipal formPrincipal = new FormPrincipal();
                                Properties.Settings.Default.listaUsuariosValidosSalvos.Add(txtUsuario.Text);
                                Properties.Settings.Default.Save();
                                this.Hide();
                                formPrincipal.ShowDialog();
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
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        transaction.Rollback();
                    }

                }
            }

        }
        else
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
        if (!txtSenha.Focused || !btnEntrar.Focused)
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
        if (String.IsNullOrEmpty(txtSenha.Text))
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
        if (!isLogged)
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
        if (checkBoxUsuario.Checked)
        {
            Properties.Settings.Default.salvarUsuarioChecado = true;
            if (isLoaded)
            {
                Properties.Settings.Default.usuarioPadrao = txtUsuario.Text;
                MessageBox.Show("Usuário salvo como padrão! Para desfazer, desmarque a caixa de seleção.", "Usuário padrão salvo com saucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        else
        {
            MessageBox.Show("Usuário padrão removido com sucesso!", "Usuário padrão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Properties.Settings.Default.usuarioPadrao = String.Empty;
            Properties.Settings.Default.salvarUsuarioChecado = false;

        }

        Properties.Settings.Default.Save();
    }

    private void LoginView_Shown(object sender, EventArgs e)
    {
        txtUsuario.Text = Properties.Settings.Default.usuarioPadrao;
        isLoaded = true;
    }

    private void LoginView_ResizeEnd(object sender, EventArgs e)
    {
        //formWidth = this.Width;
        //formHeight = this.Height;

        ////mesmas configuracoes do LoginView_Load

        //lblUsuario.Location = new Point((int)(0), (int)(0.5 * formHeight));

        ////configuracoes de responsividade do campo txtUsuario
        //txtUsuario.Width = (int)(0.3 * formWidth);
        //txtUsuario.Location = new Point((int)((formWidth - txtUsuario.Width) / 2), lblUsuario.Bottom + (int)(0.01 * formHeight));

        //lblSenha.Location = new Point(txtUsuario.Left, txtUsuario.Bottom + (int)(0.01 * formHeight));

        ////configuracoes de responsividade do campo txtSenha
        //txtSenha.Width = (int)(0.3 * formWidth);
        //txtSenha.Location = new Point((int)((formWidth - txtSenha.Width) / 2), lblSenha.Bottom + (int)(0.01 * formHeight));

        ////configuracoes de responsivdade do btnEntrar
        //btnEntrar.Width = (int)(0.1 * formWidth);
        //btnEntrar.Location = new Point(txtSenha.Right - (int)(0.33 * txtSenha.Width), txtSenha.Bottom + (int)(0.02 * formHeight));

        ////reestabelecendo o local de lblUsuario. Eixo X e inicializado com o valor 0
        ////nao ha como definir somente aqui a sua localizacao, tendo em conta que
        ////o txtUsuario depende de informacoes desse lbl para ser colocado no form
        //lblUsuario.Location = new Point(txtUsuario.Left, (int)(0.5 * formHeight));

        //checkBoxUsuario.Location = new Point(txtUsuario.Right + (int)(0.01 * formWidth), txtUsuario.Bounds.Y);

        ////configuracoes de responsividade para pbLogo(PictureBox), imagem com o icone da SGRANDE no form
        //pbLogo.Width = (int)(0.4 * formHeight);
        //pbLogo.Height = (int)(0.4 * formHeight);
        //pbLogo.Location = new Point((int)((formWidth - pbLogo.Width) / 2), (int)(0.05 * formHeight));
        //pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void LoginView_SizeChanged(object sender, EventArgs e)
    {
        formWidth = this.Width;
        formHeight = this.Height;

        //mesmas configuracoes do LoginView_Load

        lblUsuario.Location = new Point((int)(0), (int)(0.5 * formHeight));

        //configuracoes de responsividade do campo txtUsuario
        txtUsuario.Width = (int)(0.3 * formWidth);
        txtUsuario.Location = new Point((int)((formWidth - txtUsuario.Width) / 2), lblUsuario.Bottom + (int)(0.01 * formHeight));

        lblSenha.Location = new Point(txtUsuario.Left, txtUsuario.Bottom + (int)(0.01 * formHeight));

        //configuracoes de responsividade do campo txtSenha
        txtSenha.Width = (int)(0.3 * formWidth);
        txtSenha.Location = new Point((int)((formWidth - txtSenha.Width) / 2), lblSenha.Bottom + (int)(0.01 * formHeight));

        //configuracoes de responsivdade do btnEntrar
        btnEntrar.Width = (int)(0.1 * formWidth);
        btnEntrar.Location = new Point(txtSenha.Right - (int)(0.33 * txtSenha.Width), txtSenha.Bottom + (int)(0.02 * formHeight));

        //reestabelecendo o local de lblUsuario. Eixo X e inicializado com o valor 0
        //nao ha como definir somente aqui a sua localizacao, tendo em conta que
        //o txtUsuario depende de informacoes desse lbl para ser colocado no form
        lblUsuario.Location = new Point(txtUsuario.Left, (int)(0.5 * formHeight));

        checkBoxUsuario.Location = new Point(txtUsuario.Right + (int)(0.01 * formWidth), txtUsuario.Bounds.Y);

        //configuracoes de responsividade para pbLogo(PictureBox), imagem com o icone da SGRANDE no form
        pbLogo.Width = (int)(0.4 * formHeight);
        pbLogo.Height = (int)(0.4 * formHeight);
        pbLogo.Location = new Point((int)((formWidth - pbLogo.Width) / 2), (int)(0.05 * formHeight));
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
    }
}