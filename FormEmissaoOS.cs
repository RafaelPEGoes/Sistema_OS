using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Sistema_OS
{
    public partial class FormEmissaoOS : Form
    {
        public int formWidth;
        public int formHeight;
        private int maxWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int maxHeight = Screen.PrimaryScreen.WorkingArea.Height;
        private FormClienteDefinitivo formClienteDefinitivo;
        private bool phoneAdded = false;

        public FormEmissaoOS()
        {
            InitializeComponent();
            formWidth = this.Width;
            formHeight = this.Height;
            formClienteDefinitivo = (FormClienteDefinitivo)Application.OpenForms["FormClienteDefinitivo"];
        }

        public void FormEmissaoOS_Load(object sender, EventArgs e)
        {
            gbCliente.Height = (int)(0.4 * formHeight);
            gbAparelho.Height = (int)(0.25 * formHeight);
            gbDefeito.Height = (int)(0.3 * formHeight);

            lblNomeCliente.Location = new Point((int)(0.05 * gbCliente.Width), (int)(0.1 * gbCliente.Height));
            int pontoInicialX = lblNomeCliente.Left;
            int espacamentoVertical = (int)(0.01 * gbCliente.Height);

            txtNomeCliente.Location = new Point(pontoInicialX, lblNomeCliente.Bottom + espacamentoVertical);
            txtNomeCliente.Width = (int)(0.9 * gbCliente.Width);

            lblEndereco.Location = new Point(pontoInicialX, txtNomeCliente.Bottom + espacamentoVertical);

            txtEndereco.Width = (int)(0.425 * gbCliente.Width);
            txtEndereco.Location = new Point(pontoInicialX, lblEndereco.Bottom + espacamentoVertical);

            lblBairro.Location = new Point(txtEndereco.Right + (int)(0.05 * gbCliente.Width), lblEndereco.Bounds.Y);

            txtBairro.Width = txtEndereco.Width;
            txtBairro.Location = new Point(txtEndereco.Right + (int)(0.05 * gbCliente.Width), txtEndereco.Bounds.Y);

            lblCidade.Location = new Point(pontoInicialX, txtEndereco.Bottom + espacamentoVertical);

            txtCidade.Width = txtBairro.Width;
            txtCidade.Location = new Point(txtCidade.Bounds.X, lblCidade.Bottom + espacamentoVertical);

            lblUF.Location = new Point(lblBairro.Bounds.X, lblCidade.Bounds.Y);

            cbUF.Width = (int)(0.1875 * gbCliente.Width);
            cbUF.Location = new Point(lblUF.Bounds.X, lblUF.Bottom + espacamentoVertical);

            lblCEP.Location = new Point(cbUF.Right + (int)(0.05 * gbCliente.Width), lblUF.Bounds.Y);

            txtCEP.Width = cbUF.Width;
            txtCEP.Location = new Point(lblCEP.Bounds.X, lblCEP.Bottom + espacamentoVertical);

            lblEmail.Location = new Point(pontoInicialX, txtCidade.Bottom + espacamentoVertical);

            txtEmail.Width = txtBairro.Width;
            txtEmail.Location = new Point(pontoInicialX, lblEmail.Bottom + espacamentoVertical);

            lblTel.Location = new Point(lblUF.Bounds.X, cbUF.Bottom + espacamentoVertical);

            txtTel.Width = txtEmail.Width;
            txtTel.Location = new Point(lblTel.Bounds.X, lblTel.Bottom + espacamentoVertical);

            lblGrupo.Location = new Point(pontoInicialX, (int)(0.1 * gbCliente.Height));

            txtGrupo.Width = txtEmail.Width;
            txtGrupo.Location = new Point(pontoInicialX, lblGrupo.Bottom + espacamentoVertical);

            lblFabricante.Location = new Point(txtGrupo.Right + (int)(0.05 * gbAparelho.Width), lblGrupo.Bounds.Y);

            txtFabricante.Width = txtGrupo.Width;
            txtFabricante.Location = new Point(lblFabricante.Bounds.X, lblFabricante.Bottom + espacamentoVertical);

            lblModelo.Location = new Point(pontoInicialX, txtGrupo.Bottom + espacamentoVertical);

            txtModelo.Width = txtGrupo.Width;
            txtModelo.Location = new Point(pontoInicialX, lblModelo.Bottom + espacamentoVertical);

            lblNumSerie.Location = new Point(lblUF.Bounds.X, lblModelo.Bounds.Y);

            txtNumSerie.Width = cbUF.Width;
            txtNumSerie.Location = new Point(lblNumSerie.Bounds.X, lblNumSerie.Bottom + espacamentoVertical);

            lblData.Location = new Point(txtNumSerie.Right + (int)(0.05 * gbCliente.Width), lblNumSerie.Bounds.Y);

            dtpDataEntrada.Width = txtNumSerie.Width;
            dtpDataEntrada.Location = new Point(lblData.Bounds.X, lblData.Bottom + espacamentoVertical);

            lblDefeito.Location = new Point(pontoInicialX, (int)(0.1 * gbCliente.Height));

            txtDefeito.Width = txtNomeCliente.Width;
            txtDefeito.Location = new Point(pontoInicialX, lblDefeito.Bottom + espacamentoVertical);

            lblAcessórios.Location = new Point(pontoInicialX, txtDefeito.Bottom + espacamentoVertical);

            txtAcessorios.Width = txtDefeito.Width;
            txtAcessorios.Location = new Point(pontoInicialX, lblAcessórios.Bottom + espacamentoVertical);

            lblObservacoes.Location = new Point(pontoInicialX, txtAcessorios.Bottom + espacamentoVertical);

            txtObservacoes.Width = txtAcessorios.Width;
            txtObservacoes.Location = new Point(pontoInicialX, lblObservacoes.Bottom + espacamentoVertical);

            btnCancelar.Size = new Size(panelDireito.Width, (panelDireito.Height - gbTipoOS.Height - gbVoltagem.Height) / 3);
            btnSalvar.Size = btnCancelar.Size;
            btnSalvarImprimir.Size = btnCancelar.Size;

            txtNomeCliente.Text = formClienteDefinitivo.cliente.GetNome();
            txtEndereco.Text = formClienteDefinitivo.cliente.GetRuaLogradouro();
            txtBairro.Text = formClienteDefinitivo.cliente.GetBairro();
            txtCidade.Text = formClienteDefinitivo.cliente.GetCidade();
            cbUF.Text = formClienteDefinitivo.cliente.GetUF();
            txtCEP.Text = formClienteDefinitivo.cliente.GetCep();
            txtEmail.Text = formClienteDefinitivo.cliente.GetEmail();

            if (String.IsNullOrEmpty(formClienteDefinitivo.cliente.GetTel1()))
            {
                txtTel.Text = formClienteDefinitivo.cliente.GetTel2();
            } else
            {
                txtTel.Text = formClienteDefinitivo.cliente.GetTel1();
            }
        }

        private void FormEmissaoOS_ResizeEnd(object sender, EventArgs e)
        {
            formWidth = this.Width;
            formHeight = this.Height;
            FormEmissaoOS_Load(sender, e);
        }

        private void FormEmissaoOS_Resize(object sender, EventArgs e)
        {
            formWidth = this.Width;
            formHeight = this.Height;
            FormEmissaoOS_Load(sender, e);
        }

        private void rbGarantia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGarantia.Checked)
            {
                txtGarantiaDias.Enabled = true;
            }
            else
            {
                txtGarantiaDias.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja cancelar a operação?", "Cancelar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            switch (dialog)
            {
                case DialogResult.Yes:
                    FormClienteDefinitivo form = (FormClienteDefinitivo)Application.OpenForms["FormClienteDefinitivo"];
                    form.Close();
                    break;

                case DialogResult.No:
                    break;

                case DialogResult.Cancel:
                    break;
            }
        }

        private void InsertOSData()
        {
            DbFactory dbf = new();

            using (FbConnection conn = dbf.Connection())
            {
                conn.Open();

                using (FbTransaction transaction = conn.BeginTransaction())
                {
                    string query = "INSERT INTO OS()";

                    using (FbCommand cmd = new FbCommand(query, conn, transaction))
                    {

                    }
                }
            }
        }
        private void btnSalvarImprimir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTel.Text))
            {
                MessageBox.Show("Por favor insira um número de telefone válido!", "Campo de contato vazio!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTel.Focus();
                return;
            }

            if (phoneAdded)
            {
                UpdateClientPhone();
            }

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTel.Text))
            {
                MessageBox.Show("Por favor insira um número de telefone válido!", "Campo de contato vazio!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTel.Focus();
                return;
            }

            if (phoneAdded)
            {
                UpdateClientPhone();
            }


        }

        private void UpdateClientPhone()
        {
            DbFactory dbf = new();

            using (FbConnection conn = dbf.Connection())
            {
                conn.Open();

                using (FbTransaction transaction = conn.BeginTransaction())
                {
                    string query = "UPDATE CLIENTE SET " +
                        "TELEFONE1 = @TELEFONE " +
                        "WHERE CODIGO_CLIENTE = @ID_CLIENTE";

                    using (FbCommand cmd = new FbCommand(query, conn, transaction))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@TELEFONE", txtTel.Text);
                            cmd.Parameters.AddWithValue("@ID_CLIENTE", formClienteDefinitivo.cliente.GetCodigo());
                            cmd.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                            conn.Dispose();

                        }
                    }
                }
            }
        }
        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            phoneAdded = true;
        }

        private void FormEmissaoOS_Shown(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTel.Text))
            {
                txtTel.Enabled = true;
            }

            if (txtTel.Enabled)
            {
                txtTel.Focus();

            } else
            {
                txtDefeito.Focus();
            }

        }
    }
}
