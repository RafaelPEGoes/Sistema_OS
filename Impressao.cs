namespace Sistema_OS.Resources
{
    public partial class Impressao : Form
    {
        private int x;
        private int y;
        private int pageWidth;
        private int pageHeight;
        public Impressao()
        {
            InitializeComponent();
        }

        private void Impressao_Load(object sender, EventArgs e)
        {

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<String> cabecalho = new List<String>(InfoCabecalho());

        }

        private List<String> InfoCabecalho()
        {
            List<String> cabecalho = new List<String>();

            cabecalho.Add("");

            return cabecalho;
        }
    }
}
