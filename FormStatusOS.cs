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
    public partial class FormStatusOS : Form
    {
        private int formWidth;
        private int formHeight;
        private int maxWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int maxHeight = Screen.PrimaryScreen.WorkingArea.Height;
        private int idOS;
        public FormStatusOS()
        {
            InitializeComponent();
            this.MaximumSize = new Size(maxWidth, maxHeight);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormStatusOS_Load(object sender, EventArgs e)
        {
            formWidth = this.Width;
            formHeight = this.Height;

            int gbOSWidth = gbOS.Width - gbVoltagem.Width;
            int startingPointX = (int) (0.05 * gbOSWidth);

            lblCliente.Location = new Point(startingPointX, (int) (0.1 * gbOS.Height));

            txtCliente.Width = (int)(0.425 * gbOSWidth);
            txtCliente.Location = new Point(startingPointX, lblCliente.Bottom);

            lblTel.Location = new Point(txtCliente.Right + (int)(0.05 * gbOSWidth), lblCliente.Bounds.Y);
            
            txtTel.Location = new Point(lblTel.Left, lblCliente.Bottom);
            txtTel.Width = (int)(0.425 * gbOSWidth);

            lblAparelho.Location = new Point(startingPointX, txtCliente.Bottom + (int)(0.01 * gbOS.Height));
            txtAparelho.Width = (int)(0.75 * gbOSWidth);
            txtAparelho.Location = new Point(startingPointX, lblAparelho.Bottom);

            btnAlterarAparelho.Location = new Point(txtAparelho.Right + (int)(0.05 * gbOSWidth), lblAparelho.Bottom);
            btnAlterarAparelho.Width = (int)(0.1 * gbOSWidth);

            lblDefeito.Location = new Point(startingPointX, txtAparelho.Bottom + (int)(0.01 * gbOS.Height));

            txtDefeito.Width = (int)(0.9 * gbOSWidth);
            txtDefeito.Location = new Point(startingPointX, lblDefeito.Bottom);

            lblAcessorios.Location = new Point(startingPointX, txtDefeito.Bottom + (int)(0.01 * gbOS.Height));

            txtAcessorios.Width = txtDefeito.Width;
            txtAcessorios.Location = new Point(startingPointX, lblAcessorios.Bottom);

            lblObservacoes.Location = new Point(startingPointX, txtAcessorios.Bottom + (int)(0.01 * gbOS.Height));

            txtObservacoes.Width = txtAcessorios.Width;
            txtObservacoes.Location = new Point(startingPointX, lblObservacoes.Bottom);

            gbPecas.Width = (int)(0.7 * formWidth);
            gbValores.Width = formWidth - gbPecas.Width;

            gbTipoOS.Width = (int)(0.15 * formWidth);
            gbOrcamento.Width = (int)(0.15 * formWidth);
            gbServico.Width = (int)(0.3 * formWidth);
            gbSituacaoOrcamento.Width = (int)(0.4 * formWidth);
            
            panel2.Width = formWidth;

            txtDescricaoServico.Width = (int)(0.95 * panel2.Width);
            txtDescricaoServico.Location = new Point(panel2.Left + (int)(0.025 * panel2.Width), (int)((panel2.Height - txtDescricaoServico.Height) / 2));

            lblDescricaoServico.Location = new Point(txtDescricaoServico.Left, txtDescricaoServico.Bounds.Top);
        }

        private void FormStatusOS_ResizeEnd(object sender, EventArgs e)
        {
            FormStatusOS_Load(sender, e);
        }

        private void ReadBlob()
        {
            DbFactory dbf = new();

            using (FbConnection conn = dbf.Connection())
            {
                string query = "SELECT OBS_ENTRADA FROM OS " +
                    "WHERE ID_OS = 446";

                using (FbCommand cmd = new FbCommand(query, conn))
                {
                    using(FbDataReader reader = cmd.ExecuteReader())
                    {
                        byte[] userBlob = Encoding.ASCII.GetBytes(reader.GetString(0));

                        foreach(byte b in userBlob)
                        {
                            string blob = "";
                            
                        }
                    }
                }
            }
        }
        private void RetrieveOSInfo()
        {
            DbFactory dbf = new();
            using (FbConnection conn = dbf.Connection())
            {
                string query = "";
                
                using(FbCommand cmd = new FbCommand(query, conn))
                {
                    using (FbDataReader reader = cmd.ExecuteReader())
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT OS_ITENS.DATA_HORA, " +
                            "PRODUTO.DESCRICAO, " +
                            "OS_ITENS.VALOR, " +
                            "OS_ITENS.QTD, " +
                            "OS_ITENS.VALOR_TOTAL " +
                            "FROM OS_ITENS " +
                            "INNER JOIN PRODUTO ON OS_ITENS.ID_PRODUTO = PRODUTO.CODIGO_PRODUTO " +
                            "WHERE OS_ITENS.ID_OS = @ID_OS";

                        cmd.Parameters.AddWithValue("@ID_OS", idOS);
                    }
                }
            }
        }
    }
}
