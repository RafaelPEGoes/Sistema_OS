using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_OS
{
    public partial class FormEmissaoOS : Form
    {
        public int formWidth;
        public int formHeight;
        private int maxWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int maxHeight = Screen.PrimaryScreen.WorkingArea.Height;
        public FormEmissaoOS()
        {
            InitializeComponent();
            formWidth = this.Width;
            formHeight = this.Height;
        }

        public void FormEmissaoOS_Load(object sender, EventArgs e)
        {
            gbCliente.Height = Convert.ToInt32(0.4 * formHeight);
            gbAparelho.Height = Convert.ToInt32(0.25 * formHeight);
            gbDefeito.Height = Convert.ToInt32(0.3 * formHeight);

            lblNomeCliente.Location = new Point(Convert.ToInt32(0.05 * gbCliente.Width), Convert.ToInt32(0.1 * gbCliente.Height));
            int pontoInicialX = lblNomeCliente.Left;
            int espacamentoVertical = Convert.ToInt32(0.01 * gbCliente.Height);

            txtNomeCliente.Location = new Point(pontoInicialX, lblNomeCliente.Bottom + espacamentoVertical);
            txtNomeCliente.Width = Convert.ToInt32(0.9 * gbCliente.Width);

            lblEndereco.Location = new Point(pontoInicialX, txtNomeCliente.Bottom + espacamentoVertical);

            txtEndereco.Width = Convert.ToInt32(0.425 * gbCliente.Width);
            txtEndereco.Location = new Point(pontoInicialX, lblEndereco.Bottom + espacamentoVertical);

            lblBairro.Location = new Point(txtEndereco.Right + Convert.ToInt32(0.05 * gbCliente.Width), lblEndereco.Bounds.Y);

            txtBairro.Width = txtEndereco.Width;
            txtBairro.Location = new Point(txtEndereco.Right + Convert.ToInt32(0.05 * gbCliente.Width), txtEndereco.Bounds.Y);

            lblCidade.Location = new Point(pontoInicialX, txtEndereco.Bottom + espacamentoVertical);

            txtCidade.Width = txtBairro.Width;
            txtCidade.Location = new Point(txtCidade.Bounds.X, lblCidade.Bottom + espacamentoVertical);

            lblUF.Location = new Point(lblBairro.Bounds.X, lblCidade.Bounds.Y);

            cbUF.Width = Convert.ToInt32(0.1875 * gbCliente.Width);
            cbUF.Location = new Point(lblUF.Bounds.X, lblUF.Bottom + espacamentoVertical);

            lblCEP.Location = new Point(cbUF.Right + Convert.ToInt32(0.05 * gbCliente.Width), lblUF.Bounds.Y);

            txtCEP.Width = cbUF.Width;
            txtCEP.Location = new Point(lblCEP.Bounds.X, lblCEP.Bottom + espacamentoVertical);

            lblEmail.Location = new Point(pontoInicialX, txtCidade.Bottom + espacamentoVertical);

            txtEmail.Width = txtBairro.Width;
            txtEmail.Location = new Point(pontoInicialX, lblEmail.Bottom + espacamentoVertical);

            lblTel.Location = new Point(lblUF.Bounds.X, cbUF.Bottom + espacamentoVertical);

            txtTel.Width = txtEmail.Width;
            txtTel.Location = new Point(lblTel.Bounds.X, lblTel.Bottom + espacamentoVertical);

            lblGrupo.Location = new Point(pontoInicialX, Convert.ToInt32(0.1 * gbCliente.Height));
            
            txtGrupo.Width = txtEmail.Width;
            txtGrupo.Location = new Point(pontoInicialX, lblGrupo.Bottom + espacamentoVertical);

            lblFabricante.Location = new Point(txtGrupo.Right + Convert.ToInt32(0.05 * gbAparelho.Width), lblGrupo.Bounds.Y);

            txtFabricante.Width = txtGrupo.Width;
            txtFabricante.Location = new Point(lblFabricante.Bounds.X, lblFabricante.Bottom + espacamentoVertical);

            lblModelo.Location = new Point(pontoInicialX, txtGrupo.Bottom + espacamentoVertical);

            txtModelo.Width = txtGrupo.Width;
            txtModelo.Location = new Point(pontoInicialX, lblModelo.Bottom + espacamentoVertical);

            lblNumSerie.Location = new Point(lblUF.Bounds.X, lblModelo.Bounds.Y);

            txtNumSerie.Width = cbUF.Width;
            txtNumSerie.Location = new Point(lblNumSerie.Bounds.X, lblNumSerie.Bottom + espacamentoVertical);

            lblData.Location = new Point(txtNumSerie.Right + Convert.ToInt32(0.05 * gbCliente.Width), lblNumSerie.Bounds.Y);

            dtpDataEntrada.Width = txtNumSerie.Width;
            dtpDataEntrada.Location = new Point(lblData.Bounds.X, lblData.Bottom + espacamentoVertical);

            lblDefeito.Location = new Point(pontoInicialX, Convert.ToInt32(0.1 * gbCliente.Height));

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
            if(rbGarantia.Checked)
            {
                txtGarantiaDias.Enabled = true;
            } else
            {
                txtGarantiaDias.Enabled = false;
            }
        }
    }
}
