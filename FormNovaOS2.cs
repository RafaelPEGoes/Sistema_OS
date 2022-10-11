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
    public partial class FormNovaOS2 : Form
    {
        private int maxWidth = Screen.PrimaryScreen.Bounds.Width;
        private int maxHeight = Screen.PrimaryScreen.Bounds.Height;
        private int formWidth;
        private int formHeight;
        private int currentRow;
        public FormNovaOS2()
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

        private void FormNovaOS2_Load(object sender, EventArgs e)
        {
            container.SplitterDistance = Convert.ToInt32(0.15 * formHeight);
            container.Size = new Size(Convert.ToInt32(0.30 * formWidth), formHeight);
            container.Panel1.BackColor = Color.BlueViolet;
            container.Panel2.BackColor = Color.PaleVioletRed;

            panelDireito.Size = new Size(formWidth - container.Width, formHeight);
            panelDireito.BackColor = Color.Red;
            panelDireito.Location = new Point(container.Right, 0);

            btnNovo.Dock = DockStyle.Top;
            btnNovo.Size = new Size(container.Width, Convert.ToInt32(0.1 * formHeight));

            btnEditar.Size = new Size(container.Width, Convert.ToInt32(0.1 * formHeight));
            btnEditar.Dock = DockStyle.Top;

            lblNome.Location = new Point(0, Convert.ToInt32(0.1 * container.Panel1.Height));

            txtCliente.Location = new Point(0, lblNome.Bottom + Convert.ToInt32(0.05 * container.Panel1.Height));
            txtCliente.Width = Convert.ToInt32(0.6 * container.Width);

            btnPesquisar.Location = new Point(txtCliente.Right + Convert.ToInt32(0.05 * container.Width), txtCliente.Top);

            txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCliente.AutoCompleteCustomSource = GetClientes();

            //configuracoes de responsividade da tabela clientes
            tabelaClientes.Location = new Point(Convert.ToInt32(0.02 * panelDireito.Width), Convert.ToInt32(0.02 * formHeight));
            tabelaClientes.Size = new Size(Convert.ToInt32(0.95 * panelDireito.Width), Convert.ToInt32(0.88 * panelDireito.Height));
            tabelaClientes.Columns["DATA"].Width = Convert.ToInt32(0.2 * tabelaClientes.Width);
            tabelaClientes.Columns["CIDADE"].Width = Convert.ToInt32(0.2 * tabelaClientes.Width);
            tabelaClientes.Columns["TELEFONE"].Width = Convert.ToInt32(0.2 * tabelaClientes.Width);
            tabelaClientes.Columns["UF"].Width = Convert.ToInt32(0.1 * tabelaClientes.Width);
            tabelaClientes.Columns["NOME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tabelaClientes.Columns["DATA"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }
        private void FormNovaOS2_ResizeEnd(object sender, EventArgs e)
        {
            formWidth = this.Width;
            formHeight = this.Height;

            FormNovaOS2_Load(sender, e);
        }

        private void FormNovaOS2_SizeChanged(object sender, EventArgs e)
        {

        }

        private void FormNovaOS2_Resize(object sender, EventArgs e)
        {

            //FormNovaOS2_Load(sender, e);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.isAddingClient = true;
            cliente.ShowDialog();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            tabelaClientes.Rows.Clear();
            tabelaClientes.DataSource = null;
            
            DbFactory dbf = new DbFactory();

            using (FbConnection conn = dbf.Connection())
            {
                string query = "SELECT NOME, DATA_CADASTRO, CIDADE1, TELEFONE1, UF1 FROM CLIENTE WHERE NOME CONTAINING @NOME";

                using (FbCommand cmd = new FbCommand(query, conn))
                {
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@NOME", txtCliente.Text.ToUpper());

                    using (FbDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                int rowIndex = tabelaClientes.Rows.Add();

                                tabelaClientes.Rows[rowIndex].Cells["NOME"].Value = reader.GetString(0);
                                tabelaClientes.Rows[rowIndex].Cells["DATA"].Value = reader.GetString(1);
                                tabelaClientes.Rows[rowIndex].Cells["CIDADE"].Value = reader.GetString(2);
                                tabelaClientes.Rows[rowIndex].Cells["TELEFONE"].Value = reader.GetString(3);
                                tabelaClientes.Rows[rowIndex].Cells["UF"].Value = reader.GetString(4);

                                rowIndex++;

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
                        }
                    }
                }
            }
        }
        private AutoCompleteStringCollection GetClientes()
        {
            DbFactory dbf = new DbFactory();
            AutoCompleteStringCollection collection = new();

            using (FbConnection conn = dbf.Connection())
            {
                string query = "SELECT NOME FROM CLIENTE";

                using (FbCommand cmd = new FbCommand(query, conn))
                {
                    cmd.Connection.Open();

                    using (FbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            collection.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return collection;
        }

        private void tabelaClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormClienteDefinitivo cliente = new();
            cliente.nomeCliente = tabelaClientes.CurrentRow.Cells["NOME"].Value.ToString();
            cliente.ShowDialog();
        }
    }
}
