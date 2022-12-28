namespace Sistema_OS
{
    public partial class FormPrincipal : Form
    {

        private int formWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int formHeight = Screen.PrimaryScreen.WorkingArea.Height;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(formWidth, formHeight);
            this.WindowState = FormWindowState.Maximized;
            
            panelEsquerdo.Size = new Size((int)(0.2 * formWidth), formHeight - menuStrip1.Height);
            panelEsquerdo.Location = new Point(0, menuStrip1.Bottom);

            pbLogo.Size = new Size(panelEsquerdo.Width, panelEsquerdo.Width);
            pbLogo.Dock = DockStyle.Top;

            btnNovoCliente.Size = new Size(panelEsquerdo.Width, (int)(0.1 * panelEsquerdo.Height));
            btnNovoCliente.Dock = DockStyle.Top;

            btnNovaOS.Size = new Size(panelEsquerdo.Width, (int)(0.1 * panelEsquerdo.Height));
            btnNovaOS.Dock = DockStyle.Top;

            btnPesquisaCliente.Size = new Size(panelEsquerdo.Width, (int)(0.1 * panelEsquerdo.Height));
            btnPesquisaCliente.Dock = DockStyle.Top;

            btnBuscarOS.Size = new Size(panelEsquerdo.Width, (int) (0.1 * panelEsquerdo.Height));
            btnBuscarOS.Dock = DockStyle.Top;
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovaOS2 formOS = new FormNovaOS2();
            formOS.ShowDialog();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formCadastroCliente = new FormCliente();
            formCadastroCliente.ShowDialog();   
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FormClienteDefinitivo formClienteDefinitivo = new();
            formClienteDefinitivo.isAddingClient = true;
            formClienteDefinitivo.ShowDialog();
        }

        private void btnNovaOS_Click(object sender, EventArgs e)
        {
            FormNovaOS2 formNovaOS = new FormNovaOS2();
            formNovaOS.ShowDialog();
        }

        private void btnBuscarOS_Click(object sender, EventArgs e)
        {
            FormBuscarOS formBuscarOS = new();
            formBuscarOS.ShowDialog();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            FormNovaOS2 formNovaOS = new();
            formNovaOS.Show();
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguracoes2 conf = new();
            conf.Show();
        }
    }
}
