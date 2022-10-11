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

    public partial class FormOS : Form
    {

        private int formWidth;
        private int formHeight;
        private int maxWidth = Screen.PrimaryScreen.Bounds.Width;
        private int maxHeight = Screen.PrimaryScreen.Bounds.Height;

        public FormOS()
        {
            InitializeComponent();
            this.MaximumSize = new Size(maxWidth, maxHeight);
            formWidth = Convert.ToInt32(0.5 * maxWidth);
            formHeight = Convert.ToInt32(0.4 * maxHeight);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormOS_Load(object sender, EventArgs e)
        {
            lblNomeCliente.Location = new Point(0, 0);

            splitContainer1.Panel1.Width = Convert.ToInt32(0.3 * formWidth);
            splitContainer1.Panel2.Width = Convert.ToInt32(formWidth - splitContainer1.Panel1.Width);

            txtNomeCliente.Width = Convert.ToInt32(0.8 * this.splitContainer1.Panel1.Width);
            txtNomeCliente.Location = new Point(Convert.ToInt32(0.01 * formWidth), lblNomeCliente.Bottom + Convert.ToInt32(0.01 * formHeight));

        }
    }
}
