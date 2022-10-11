namespace Sistema_OS
{
    public partial class FormConfiguracoes : Form
    {
        public FormConfiguracoes()
        {
            InitializeComponent();
        }

        private void FormConfiguracoes_Load(object sender, EventArgs e)
        {

        }

        private void txtDescricao_MouseHover(object sender, EventArgs e)
        {
            string str = "Aqui, adicione a descrição do seu negócio: o serviço que você presta, as peças que você fornece assistência, etc. \nEx: " +
                "Peças e Serviços em Eletrodomésticos em Geral - Ferramentas Elétricas - Microondas\n" +
                "Posto Autorizado ARNO - Black & Decker - Dewalt - Layr - Taiff" +
                "Esse texto será exibido no Cabeçalho da sua SO.";
            toolTip.SetToolTip(txtDescricao, str);
            toolTip.ToolTipIcon = ToolTipIcon.Info;

        }
    }
}
