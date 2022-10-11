using FirebirdSql.Data.FirebirdClient;

namespace Sistema_OS
{
    public partial class FormAparelhosCliente : Form
    {

        public int formWidth;
        public int formHeight;
        private int maxWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int maxHeight = Screen.PrimaryScreen.WorkingArea.Height;
        public FormAparelhosCliente()
        {
            InitializeComponent();
            formWidth = this.Width;
            formHeight = this.Height;
            tabelaAparelhos.Columns.Add("APARELHO", "Aparelho");
            tabelaAparelhos.Columns.Add("MARCA", "Marca");
            tabelaAparelhos.Columns.Add("MODELO", "Modelo");
            tabelaAparelhos.Columns.Add("SERIE", "Série");
            
        }

        public void FormAparelhosCliente_Load(object sender, EventArgs e)
        {
            int columnsWidth = Convert.ToInt32(0.25 * tabelaAparelhos.Width);
            tabelaAparelhos.Columns["APARELHO"].Width = columnsWidth;
            tabelaAparelhos.Columns["MARCA"].Width = columnsWidth;
            tabelaAparelhos.Columns["MODELO"].Width = columnsWidth;
            tabelaAparelhos.Columns["SERIE"].Width = columnsWidth;

            int btnWidth = Convert.ToInt32(panelBotoes.Width / 4);
            btnAdicionar.Width = btnWidth;
            btnEditar.Width = btnWidth;
            btnExcluir.Width = btnWidth;
            btnProximo.Width = btnWidth;

            panelSuperior.Height = Convert.ToInt32(0.15 * formHeight);
            panelDataGrid.Height = Convert.ToInt32(0.65 * formHeight);
            panelBotoes.Height = Convert.ToInt32(0.1 * formHeight);

            lblEspecificacoes.Location = new Point(tabelaAparelhos.Left, Convert.ToInt32((panelSuperior.Height - txtEspecificacoes.Height) / 2));

            txtEspecificacoes.Width = Convert.ToInt32(0.5 * formWidth);
            txtEspecificacoes.Location = new Point(lblEspecificacoes.Left, lblEspecificacoes.Bottom + Convert.ToInt32(0.01 * formHeight));
            
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
    }
}
