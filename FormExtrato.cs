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
    
    public partial class FormExtrato : Form
    {
        private int formWidth;
        private int formHeight;
        private int maxWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int maxHeight = Screen.PrimaryScreen.WorkingArea.Height;
        private FormClienteDefinitivo formClienteDefinitivo;
        private int pageWidth;
        private int pageHeight;
        public FormExtrato()
        {
            InitializeComponent();
            formClienteDefinitivo = (FormClienteDefinitivo)Application.OpenForms["FormClienteDefinitivo"];
            this.MaximumSize = new Size(maxWidth, maxHeight);
            lblNomeCliente.Text = $"Extrato: {formClienteDefinitivo.nomeCliente}";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormExtrato_Load(object sender, EventArgs e)
        {
            formWidth = this.Width;
            formHeight = this.Height;
            
            splitContainer.SplitterDistance = (int)(0.2 * formHeight);
            lblNomeCliente.Location = new Point((int)(0.05 * formWidth), (int)(splitContainer.Panel1.Height - lblNomeCliente.Height) / 2);

            LoadExtrato();

        }

        private void LoadExtrato()
        {
            DbFactory dbf = new();

            using(FbConnection conn = dbf.Connection())
            {
                conn.Open();
                string str = "SELECT OS_PAGAMENTO.ID_OS, " +
                    "OS.CAMPO_1, " +
                    "OS_PAGAMENTO.ID_FORMA, " +
                    "OS_PAGAMENTO.DATA, " +
                    "OS_PAGAMENTO.VENCIMENTO, " +
                    "FORMA_PAGAMENTO.DESCRICAO, " +
                    "OS_PAGAMENTO.VALOR " +
                    "FROM OS_PAGAMENTO " +
                    "INNER JOIN FORMA_PAGAMENTO ON " +
                    "OS_PAGAMENTO.ID_FORMA = FORMA_PAGAMENTO.ID " +
                    "INNER JOIN OS ON " +
                    "OS.ID = OS_PAGAMENTO.ID " +
                    "WHERE OS.ID_CLIENTE = @ID";
                    
                using (FbCommand cmd = new FbCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", formClienteDefinitivo.codigoCliente);

                    using(FbDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new();
                        dt.Load(reader);
                        tabelaExtrato.DataSource = dt;
                    }
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private List<String> InfoCabecalho(string nomeCliente)
        {
            List<String> lista = new();

            lista.Add("Extrato de cliente");
            lista.Add($"Cliente: {nomeCliente}");
            lista.Add($"Período: de {dtpDataIni.Text} a {dtpDataFim.Text}");

            return lista;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            pageWidth = printDocument.DefaultPageSettings.Bounds.Width;
            pageHeight = printDocument.DefaultPageSettings.Bounds.Height;

            Font fontTitulo = new Font("Consolas", 13, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);
            StringFormat centro = new StringFormat();
            centro.Alignment = StringAlignment.Center;
            List<String> infoCabecalho = InfoCabecalho(formClienteDefinitivo.nomeCliente);
            MessageBox.Show(infoCabecalho.Count.ToString());
            Rectangle retanguloCabecalho = new Rectangle(20, 20, pageWidth - 40, 30);

            foreach(String str in infoCabecalho)
            {
                e.Graphics.DrawString(str, fontTitulo, brush, retanguloCabecalho, centro);
                retanguloCabecalho.Y += 30;
                retanguloCabecalho.Height += 30;
            }
            

            
        }

        private void dtpDataFim_ValueChanged(object sender, EventArgs e)
        {
            if(DateTime.Parse(dtpDataFim.Text) < DateTime.Parse(dtpDataIni.Text))
            {
                MessageBox.Show("Data inicial não pode ser menor que a data final", "Data Inválida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DbFactory dbf = new();

            using (FbConnection conn = dbf.Connection())
            {
                
                using (FbCommand cmd = new FbCommand())
                {
                    string query = "";
                    using (FbDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }
    }
}
