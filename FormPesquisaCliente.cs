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
    public partial class FormPesquisaCliente : Form
    {
        private int formWidth;
        private int formHeight;
        private int maxWidth;
        private int maxHeight;
        public FormPesquisaCliente()
        {
            InitializeComponent();
            maxWidth = Screen.PrimaryScreen.WorkingArea.Width;
            maxHeight = Screen.PrimaryScreen.WorkingArea.Height;
            formWidth = Convert.ToInt32(0.5 * maxWidth);
            formHeight = Convert.ToInt32(0.4 * maxHeight);
            this.Width = formWidth;
            this.Height = formHeight;
            this.MaximumSize = new Size(maxWidth, maxHeight);

            tabelaCliente.Columns.Add("NOME", "Cliente");
            tabelaCliente.Columns.Add("DATA", "Data");
            tabelaCliente.Columns.Add("CIDADE", "Cidade");
            tabelaCliente.Columns.Add("TELEFONE", "Telefone");
            tabelaCliente.Columns.Add("UF", "UF");

        }

        private void FormPesquisaCliente_Load(object sender, EventArgs e)
        {
            this.container.SplitterDistance = Convert.ToInt32(0.2 * formHeight);
            this.container.Panel1.BackColor = Color.Orange;
            tabelaCliente.Size = new Size(Convert.ToInt32(0.98 * container.Panel2.Width), Convert.ToInt32(0.95 * container.Panel2.Height));
            tabelaCliente.Location = new Point(Convert.ToInt32(0.025 * container.Panel2.Height), Convert.ToInt32(0.025 * container.Panel2.Height));

            txtNomeCliente.Width = Convert.ToInt32(0.5 * container.Panel1.Width);
            txtNomeCliente.Location = new Point(Convert.ToInt32(0.05 * container.Panel1.Width), Convert.ToInt32((container.Panel1.Height - txtNomeCliente.Height) / 2));
            lblNomeCliente.Location = new Point(Convert.ToInt32(0.05 * container.Panel1.Width), txtNomeCliente.Top);



            tabelaCliente.Columns["DATA"].Width = Convert.ToInt32(0.15 * tabelaCliente.Width);
            tabelaCliente.Columns["CIDADE"].Width = Convert.ToInt32(0.2 * tabelaCliente.Width);
            tabelaCliente.Columns["TELEFONE"].Width = Convert.ToInt32(0.2 * tabelaCliente.Width);
            tabelaCliente.Columns["UF"].Width = Convert.ToInt32(0.1 * tabelaCliente.Width);
            tabelaCliente.Columns["NOME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void FormPesquisaCliente_ResizeEnd(object sender, EventArgs e)
        {
            FormPesquisaCliente_Load(sender, e);
        }
    }
}
