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
    public partial class FormNovaOS : Form
    {
        private int formWidth;
        private int formHeight;
        private int maxWidth = Screen.PrimaryScreen.Bounds.Width;
        private int maxHeight = Screen.PrimaryScreen.Bounds.Height;

        public FormNovaOS()
        {
            InitializeComponent();
            this.MaximumSize = new Size(maxWidth, maxHeight);
            formWidth = Convert.ToInt32(0.6 * maxWidth);
            formHeight = Convert.ToInt32(0.5 * maxHeight);
            this.Width = formWidth;
            this.Height = formHeight;
            this.StartPosition = FormStartPosition.CenterScreen;
            tabelaClientes.Columns.Add("NOME", "Cliente");
            tabelaClientes.Columns.Add("DATA", "Data");
            tabelaClientes.Columns.Add("CIDADE", "Cidade");
            tabelaClientes.Columns.Add("TELEFONE", "Telefone");
            tabelaClientes.Columns.Add("UF", "UF");

        }

        private void FormNovaOS_Load(object sender, EventArgs e)
        {
            //configuracoes de responsividade do painel esquerdo do form
            panelEsquerdo.Size = new Size(Convert.ToInt32(0.3 * formWidth), formHeight);
            panelEsquerdo.Location = new Point(0, 0);
            panelEsquerdo.BackColor = Color.Orange;

            //configuracoes de responsivdade do painel superior direito do form
            panelBotoes.Anchor = AnchorStyles.Top;
            panelBotoes.Location = new Point(panelEsquerdo.Right, 0);
            panelBotoes.Size = new Size(formWidth - panelEsquerdo.Width, Convert.ToInt32(0.15 * formHeight));
            panelBotoes.BackColor = Color.Red;

            //configuracoes de responsividade do painel inferior direito do form
            panelDireito.Size = new Size(formWidth - panelEsquerdo.Width, formHeight - panelBotoes.Height);
            panelDireito.Location = new Point(panelEsquerdo.Right, panelBotoes.Bottom);
            panelDireito.BackColor = Color.Black;

            //configuracoes de responsividade do datagrid
            tabelaClientes.Size = new Size(Convert.ToInt32(0.95 * panelDireito.Width), Convert.ToInt32(0.85 * panelDireito.Height));
            tabelaClientes.Location = new Point(Convert.ToInt32(0.025 * panelDireito.Height), Convert.ToInt32(0.025 * panelDireito.Height));
            //tabelaClientes.Dock = DockStyle.Fill;
            tabelaClientes.Columns["DATA"].Width = Convert.ToInt32(0.15 * tabelaClientes.Width);
            tabelaClientes.Columns["CIDADE"].Width = Convert.ToInt32(0.2 * tabelaClientes.Width);
            tabelaClientes.Columns["TELEFONE"].Width = Convert.ToInt32(0.2 * tabelaClientes.Width);
            tabelaClientes.Columns["UF"].Width = Convert.ToInt32(0.1 * tabelaClientes.Width);
            tabelaClientes.Columns["NOME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          
            #region responsividade controles do painel esquerdo
          
            lblNovaOS.Font = new Font("Verdana", 25);
            lblNovaOS.Location = new Point(Convert.ToInt32((panelEsquerdo.Width - lblNovaOS.Width) / 2), 0);

            lblNomeCliente.Location = new Point(Convert.ToInt32(0.01 * formWidth), lblNovaOS.Bottom + Convert.ToInt32(0.05 * formWidth));

            txtNomeCliente.Width = Convert.ToInt32(0.65 * panelEsquerdo.Width);
            txtNomeCliente.Location = new Point(Convert.ToInt32(0.01 * formWidth), lblNomeCliente.Bottom + Convert.ToInt32(0.03 * formHeight));

            btnBuscar.Width = Convert.ToInt32(0.25 * panelEsquerdo.Width);
            btnBuscar.Location = new Point(txtNomeCliente.Right + Convert.ToInt32(0.02 * panelEsquerdo.Width), txtNomeCliente.Bounds.Y);

            lblUsuario.Location = new Point(Convert.ToInt32(0.01 * formWidth), txtNomeCliente.Bottom + Convert.ToInt32(0.1 * formHeight));

            lblTrademark.Location = new Point(Convert.ToInt32((panelEsquerdo.Width - lblTrademark.Width) / 2), panelEsquerdo.Bottom - lblTrademark.Height * 4);

            //melhorar a disposicao do picturebox no form
            pictureBox1.Size = new Size(Convert.ToInt32(0.5 * panelEsquerdo.Width), Convert.ToInt32(0.5 * panelEsquerdo.Width));
            pictureBox1.Location = new Point(Convert.ToInt32((panelEsquerdo.Width - pictureBox1.Width) / 2), lblUsuario.Bottom);

            btnAnotacoes.Location = new Point(0, 0);

            #endregion

            #region responsividade botoes panelBotoes
            btnAnotacoes.Size = new Size(Convert.ToInt32(0.24 * panelBotoes.Width), panelBotoes.Height);
            btnAnotacoes.Location = new Point(Convert.ToInt32(0.02 * panelBotoes.Width), 0);
            
            btnNovaOS.Size = new Size(Convert.ToInt32(0.24 * panelBotoes.Width), panelBotoes.Height);
            btnNovaOS.Location = new Point(btnAnotacoes.Right, 0);

            btnVisitas.Size = new Size(Convert.ToInt32(0.24 * panelBotoes.Width), panelBotoes.Height);
            btnVisitas.Location = new Point(btnNovaOS.Right, 0);

            btnEditar.Size = new Size(Convert.ToInt32(0.24 * panelBotoes.Width), panelBotoes.Height);
            btnEditar.Location = new Point(btnVisitas.Right, 0);

            #endregion
        }

        private void FormNovaOS_ResizeEnd(object sender, EventArgs e)
        {
            formWidth = this.Width;
            formHeight = this.Height;
            FormNovaOS_Load(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormPesquisaCliente formPesquisaCliente = new FormPesquisaCliente();
            formPesquisaCliente.ShowDialog();
        }

        private void btnNovaOS_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente();
            form.ShowDialog();
        }
    }
}
