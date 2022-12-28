using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace Sistema_OS
{
    public partial class FormBuscarOS : Form
    {
        private int formWidth;
        private int formHeight;
        private int maxWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int maxHeight = Screen.PrimaryScreen.WorkingArea.Height;
        private string query;
        private List<Control> controlList; 
        public FormBuscarOS()
        {
            InitializeComponent();
            this.MaximumSize = new Size(maxWidth, maxHeight);
            this.StartPosition = FormStartPosition.CenterScreen;
            controlList = new();

            foreach (Control ctrl in tpTodas.Controls)
            {
                controlList.Add(ctrl);
            }
        }

        private void FormBuscarOS_Load(object sender, EventArgs e)
        {
            formWidth = this.Width;
            formHeight = this.Height;

            container.SplitterDistance = (int)(0.15 * formHeight);
            container.Panel1.BackColor = Color.Aqua;

            //tabelaOS.Columns.Add("NUM_OS", "OS Nº");
            //tabelaOS.Columns.Add("NOME", "Nome Cliente");
            //tabelaOS.Columns.Add("APARELHO", "Aparelho");
            //tabelaOS.Columns.Add("MODELO", "Modelo");
            //tabelaOS.Columns.Add("DATA_ENTRADA", "Data Entrada");
        }

        private void txtNumeroOS_TextChanged(object sender, EventArgs e)
        {
            tabelaOS.DataSource = null;
            tabelaOS.Rows.Clear();
            txtNomeCliente.Clear();

            RegexValidacao(txtNumeroOS.Text);

            if (String.IsNullOrEmpty(txtNumeroOS.Text))
            {
                query = string.Empty;
                return;
            }

            foreach (Char c in txtNumeroOS.Text)
            {
                if (!Char.IsDigit(c))
                {
                    return;
                }
            }

            
            DbFactory dbf = new();

            using (FbConnection conn = dbf.Connection())
            {
                string str = "SELECT " +
                   "OS.ID AS \"OS Nº\", " +
                   "CLIENTE.NOME AS \"Nome Cliente\", " +
                   "OS.DATA_LANC AS \"Data Entrada\" " +
                   "FROM OS " +
                   "INNER JOIN CLIENTE ON OS.ID_CLIENTE = CLIENTE.CODIGO_CLIENTE " +
                   "WHERE OS.ID = @ID";

                using (FbCommand cmd = new FbCommand(str, conn))
                {
                    cmd.Connection.Open();
                    cmd.Parameters.Add("@ID", RegexValidacao(txtNumeroOS.Text));
                    try
                    {
                        using (FbDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new();
                            dt.Load(reader);
                            tabelaOS.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro: contacte o administrador do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        conn.Close();
                        conn.Dispose();
                    }

                }
            }


        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

            tabelaOS.DataSource = null;
            tabelaOS.Rows.Clear();

            if (String.IsNullOrEmpty(txtNomeCliente.Text))
            {
                query = string.Empty;
                return;
            }

            DbFactory dbf = new();

            using (FbConnection conn = dbf.Connection())
            {
                string str = String.IsNullOrEmpty(query) ? "SELECT " +
                   "OS.ID, " +
                   "CLIENTE.NOME, " +
                   "OS.DATA_LANC " +
                   "FROM OS " +
                   "INNER JOIN CLIENTE ON OS.ID_CLIENTE = CLIENTE.CODIGO_CLIENTE " +
                   "WHERE " +
                   "ID_CLIENTE IN (SELECT CODIGO_CLIENTE FROM CLIENTE " +
                   "WHERE NOME CONTAINING @NOME)" : query + " AND ID_CLIENTE IN " +
                   "(SELECT CODIGO_CLIENTE FROM CLIENTE WHERE NOME CONTAINING @NOME)";


                using (FbCommand cmd = new FbCommand(str, conn))
                {
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@NOME", RegexValidacao(txtNomeCliente.Text));
                    cmd.Parameters.AddWithValue("@DATA_INICIO", dtpDataInicio.Text.Replace("//", "."));
                    cmd.Parameters.AddWithValue("@DATA_FIM", dtpDataFim.Text.Replace("//", "."));
                    using (FbDataReader adapter = cmd.ExecuteReader())
                    {
                        DataTable dt = new();
                        dt.Load(adapter);
                        tabelaOS.DataSource = dt;
                    }
                }
            }
        }

        private void tabelaOS_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tabelaOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtNumeroOS_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            foreach (Char c in txtNumeroOS.Text)
            {
                if (!Char.IsDigit(c))
                {
                    txtNumeroOS.Text.Remove(c);

                }
            }
        }

        private DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NUMERO_OS", typeof(int));
            dt.Columns.Add("NOME_CLIENTE", typeof(string));
            dt.Columns.Add("APARELHO", typeof(string));
            dt.Columns.Add("MARCA", typeof(string));
            dt.Columns.Add("DATA_ENTRADA", typeof(DateOnly));

            return dt;
        }

        private string RegexValidacao(string str)
        {
            return Regex.Replace(str, "[^0-9a-zA-Z ]+", "");
            return Regex.Replace(str, "[^0-9a-zA-Z ]+", "", RegexOptions.IgnorePatternWhitespace);
        }

        private void dtpDataInicio_ValueChanged(object sender, EventArgs e)
        {
            tabelaOS.DataSource = null;
            tabelaOS.Rows.Clear();

            DbFactory dbf = new();
            using (FbConnection conn = dbf.Connection())
            {
                string str;
                bool myBool = string.IsNullOrEmpty(query) ? true : false;

                str = string.IsNullOrEmpty(query) ? "SELECT " +
                   "OS.ID AS \"OS Nº\", " +
                   "CLIENTE.NOME AS \"Nome Cliente\", " +
                   "OS.DATA_LANC AS \"Data Entrada\" " +
                   "FROM OS " +
                   "INNER JOIN CLIENTE ON OS.ID_CLIENTE = CLIENTE.CODIGO_CLIENTE " +
                   "WHERE DATA_LANC >= @DATA_INICIO" : query + " AND DATA_LANC >= @DATA_INICIO;";


                using (FbCommand cmd = new FbCommand(str, conn))
                {
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@DATA_INICIO", dtpDataInicio.Text.Replace("//", "."));
                    cmd.Parameters.AddWithValue("@NOME", RegexValidacao(txtNomeCliente.Text));
                    using (FbDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new();
                        dt.Load(reader);
                        tabelaOS.DataSource = dt;

                        
                    }
                }

            }


        }

        private void dtpDataFim_ValueChanged(object sender, EventArgs e)
        {

            if(DateTime.Parse(dtpDataFim.Text) < DateTime.Parse(dtpDataInicio.Text))
            {
                MessageBox.Show("Data Final é menor que a Data Inicial!", "Período inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDataFim.Text = DateTime.Now.ToString("dd-MM-yyyy");


                return;
            }

            tabelaOS.DataSource = null;
            tabelaOS.Rows.Clear();

            DbFactory dbf = new();
            using (FbConnection conn = dbf.Connection())
            {
                string str = string.IsNullOrEmpty(query) ? "SELECT " +
                    "OS.ID AS \"OS Nº\", " +
                    "CLIENTE.NOME AS \"Nome Cliente\", " +
                    "OS.DATA_LANC AS \"Data Entrada\" " +
                    "FROM OS " +
                    "INNER JOIN CLIENTE ON OS.ID_CLIENTE = CLIENTE.CODIGO_CLIENTE " +
                    "WHERE DATA_LANC BETWEEN @DATA_INICIO AND @DATA_FIM;"
                    : query + " AND DATA_LANC BETWEEN @DATA_INICIO AND @DATA_FIM;";

                using (FbCommand cmd = new FbCommand(str, conn))
                {
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@NOME", RegexValidacao(txtNomeCliente.Text));
                    cmd.Parameters.AddWithValue("@DATA_INICIO", dtpDataInicio.Text.Replace("//", "."));
                    cmd.Parameters.AddWithValue("@DATA_FIM", dtpDataFim.Text.Replace("//", "."));

                    using (FbDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new();
                        dt.Load(reader);
                        tabelaOS.DataSource = dt;
                    }
                }

            }
        }

        private void txtNomeCliente_Leave(object sender, EventArgs e)
        {
            query = "SELECT " +
                   "OS.ID, " +
                   "CLIENTE.NOME, " +
                   "OS.DATA_LANC " +
                   "FROM OS " +
                   "INNER JOIN CLIENTE ON OS.ID_CLIENTE = CLIENTE.CODIGO_CLIENTE " +
                   "WHERE " +
                   "ID_CLIENTE IN (SELECT CODIGO_CLIENTE FROM CLIENTE " +
                   "WHERE NOME CONTAINING @NOME)";
        }

        private void dtpDataInicio_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNomeCliente.Text))
            {

                query = "SELECT " +
                       "OS.ID AS \"OS Nº\", " +
                       "CLIENTE.NOME AS \"Nome Cliente\", " +
                       "OS.DATA_LANC AS \"Data Entrada\" " +
                       "FROM OS " +
                       "INNER JOIN CLIENTE ON OS.ID_CLIENTE = CLIENTE.CODIGO_CLIENTE " +
                       "WHERE DATA_LANC >= @DATA_INICIO";

                //usar essa estrutura para dar append na query
                //no caso de todas, não adicionará nada
                //caso esteja em aberto, adicionar, por exemplo, WHERE ID_SITUACAO = 1
                //no banco só há uma id, 'em andamento' na tabela OS_SITUACAO
                //criar as outras necessarias
                //concluidas
                //em andamento
                //em aberto
                switch(tabControl.SelectedTab.Name)
                {
                    case "tpEmAberto":
                        query += "AND STATUS = 1";
                        break;

                    default:
                        break;
                }
            }
        }

        private void dtpDataFim_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNomeCliente.Text))
            {
                query = "SELECT " +
                        "OS.ID AS \"OS Nº\", " +
                        "CLIENTE.NOME AS \"Nome Cliente\", " +
                        "OS.DATA_LANC AS \"Data Entrada\" " +
                        "FROM OS " +
                        "INNER JOIN CLIENTE ON OS.ID_CLIENTE = CLIENTE.CODIGO_CLIENTE " +
                        "WHERE DATA_LANC BETWEEN @DATA_INICIO AND @DATA_FIM;";
            }

        }
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            foreach (Control ctrl in controlList)
            {
                tabControl.SelectedTab.Controls.Add(ctrl);
            }
        }
    }
}
