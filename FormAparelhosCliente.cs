using FirebirdSql.Data.FirebirdClient;

namespace Sistema_OS
{
    public partial class FormAparelhosCliente : Form
    {

        public int formWidth;
        public int formHeight;
        private int maxWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int maxHeight = Screen.PrimaryScreen.WorkingArea.Height;
        public FormClienteDefinitivo formClienteDefinitivo;
        public FormAparelhosCliente()
        {
            InitializeComponent();
            formWidth = this.Width;
            formHeight = this.Height;
            tabelaAparelhos.Columns.Add("APARELHO", "Aparelho");
            tabelaAparelhos.Columns.Add("MARCA", "Marca");
            tabelaAparelhos.Columns.Add("MODELO", "Modelo");
            tabelaAparelhos.Columns.Add("SERIE", "Série");
            formClienteDefinitivo = (FormClienteDefinitivo) Application.OpenForms["FormClienteDefinitivo"];
        }

        public void FormAparelhosCliente_Load(object sender, EventArgs e)
        {
            int columnsWidth = (int)(0.25 * tabelaAparelhos.Width);
            tabelaAparelhos.Columns["APARELHO"].Width = columnsWidth;
            tabelaAparelhos.Columns["MARCA"].Width = columnsWidth;
            tabelaAparelhos.Columns["MODELO"].Width = columnsWidth;
            tabelaAparelhos.Columns["SERIE"].Width = columnsWidth;

            int btnWidth = (int)(panelBotoes.Width / 4);
            btnAdicionar.Width = btnWidth;
            btnEditar.Width = btnWidth;
            btnExcluir.Width = btnWidth;
            btnProximo.Width = btnWidth;

            panelSuperior.Height = (int)(0.15 * formHeight);
            panelDataGrid.Height = (int)(0.65 * formHeight);
            panelBotoes.Height = (int)(0.1 * formHeight);

            lblEspecificacoes.Location = new Point(tabelaAparelhos.Left, (int)((panelSuperior.Height - txtEspecificacoes.Height) / 2));

            txtEspecificacoes.Width = (int)(0.5 * formWidth);
            txtEspecificacoes.Location = new Point(lblEspecificacoes.Left, lblEspecificacoes.Bottom + (int)(0.01 * formHeight));

            RetrieveClientDevices();
        }

        private void FormAparelhosCliente_ResizeEnd(object sender, EventArgs e)
        {
            //caso o resize seja Maximizar a tela, tentar atribuir a
            //formWidth = Screen.PrimaryScreen.WorkingArea.Width
            //formHeight = Screen.PrimaryScreen.WorkingArea.Height

            formWidth = this.Width;
            formHeight = this.Height;
            FormAparelhosCliente_Load(sender, e);
        }

        private void txtEspecificacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

            FormClienteDefinitivo form = (FormClienteDefinitivo)Application.OpenForms["FormClienteDefinitivo"];
            form.LoadFinalForm();
        }

        private void RetrieveClientDevices()
        {
            DbFactory dbf = new();

            using (FbConnection conn = dbf.Connection())
            {
                string query = "SELECT GRUPO.NOME, " +
                    "FABRICANTE.NOME, " +
                    "OS_APARELHO_CLIENTE.DESCRICAO, " +
                    "OS_APARELHO_CLIENTE.NUMERO_SERIE_PRODUTO " +
                    "FROM OS_APARELHO_CLIENTE " +
                    "INNER JOIN GRUPO " +
                    "ON OS_APARELHO_CLIENTE.CODIGO_GRUPO = GRUPO.CODIGO_GRUPO " +
                    "INNER JOIN FABRICANTE " +
                    "ON OS_APARELHO_CLIENTE.CODIGO_FABRICANTE = FABRICANTE.CODIGO_FABRICANTE " +
                    "WHERE OS_APARELHO_CLIENTE.CODIGO_CLIENTE = @CODIGO_CLIENTE";

                using(FbCommand cmd = new(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("CODIGO_CLIENTE", formClienteDefinitivo.codigoCliente);

                    tabelaAparelhos.DataSource = cmd.ExecuteReader();
                }
            }
        }
    }
}
