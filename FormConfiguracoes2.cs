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
    public partial class FormConfiguracoes2 : Form
    {
        private int formWidth;
        private int formHeight;
        private int maxWidth = Screen.PrimaryScreen.WorkingArea.Width;
        private int maxHeight = Screen.PrimaryScreen.WorkingArea.Height;
        private int pageWidth;
        private int pageHeight;
        private StreamWriter tempFile;
        private bool infoModified = false;
        private Font fontTitulo;
        private Font fontCabecalho;
        public FormConfiguracoes2()
        {
            InitializeComponent();
            this.MaximumSize = new Size(maxWidth, maxHeight);
            tempFile = File.CreateText("tempTxtFile.txt");
            tempFile.Close();

            if (Properties.Settings.Default.fontTitulo is not null)
            {
                fontTitulo = Properties.Settings.Default.fontTitulo;
                txtTitulo.Font = fontTitulo;
            }

            if (Properties.Settings.Default.fontCabecalho is not null)
            {
                fontCabecalho = Properties.Settings.Default.fontCabecalho;
                txtInfoAdicional.Font = fontCabecalho;
            }

            MessageBox.Show(Properties.Settings.Default.fontCabecalho.ToString());
            MessageBox.Show(Properties.Settings.Default.fontTitulo.ToString());
        }

        private void FormConfiguracoes_Load(object sender, EventArgs e)
        {
            formWidth = this.Width;
            formHeight = this.Height;

            container.SplitterDistance = (int)(0.8 * formHeight);

            RetrieveHeaderData();
            WriteToTempFile();
        }

        private void RetrieveHeaderData()
        {
            if (File.Exists("cabecalho_OS.txt"))
            {
                try
                {
                    using (StreamReader reader = new("cabecalho_OS.txt"))
                    {
                        string line = string.Empty;

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("Titulo: "))
                            {
                                txtTitulo.Text = line.Replace("Titulo: ", "");
                                break;
                            }
                        }

                        line = reader.ReadToEnd().Replace("Info_adicional: ", "");
                        txtInfoAdicional.Text = line;

                        reader.Close();
                        reader.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void SaveOrCreateFile()
        {
            if (!File.Exists("cabecalho_OS.txt"))
            {
                try
                {
                    using (StreamWriter writer = File.CreateText("cabecalho_OS.txt")) ;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            StringBuilder builder = new();

            builder.AppendLine($"Titulo: {txtTitulo.Text}");
            builder.AppendLine($"Info_adicional: {txtInfoAdicional.Text}");

            File.WriteAllText("cabecalho_OS.txt", builder.ToString());


        }

        private void WriteToTempFile()
        {
            StringBuilder builder = new();

            builder.AppendLine($"Titulo: {txtTitulo.Text}");
            builder.AppendLine($"Info_adicional: {txtInfoAdicional.Text}");

            File.WriteAllText("tempTxtFile.txt", builder.ToString());
        }
        private void txtDescricao_MouseHover(object sender, EventArgs e)
        {
            string str = "Aqui, adicione a descrição do seu negócio: o serviço que você presta, as peças que você fornece assistência, etc. \nEx: " +
                "Peças e Serviços em Eletrodomésticos em Geral - Ferramentas Elétricas - Microondas\n" +
                "Posto Autorizado ARNO - Black & Decker - Dewalt - Layr - Taiff" +
                "Esse texto será exibido no Cabeçalho da sua SO.";
            //toolTip.SetToolTip(txtDescricao, str);
            //toolTip.ToolTipIcon = ToolTipIcon.Info;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveOrCreateFile();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            pageWidth = printDocument.DefaultPageSettings.Bounds.Width;
            pageHeight = printDocument.DefaultPageSettings.Bounds.Height;


            Rectangle retOS = new(0, 0, pageWidth, (int)(pageHeight / 2));
            Rectangle retCabecalho = new(0, 0, pageWidth, (int)(0.3 * retOS.Height));

            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), retOS);
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), retCabecalho);

            StringFormat sf = new();
            sf.Alignment = StringAlignment.Center;
            retCabecalho.Y += 15;

            using (StreamReader reader = new("tempTxtFile.txt"))
            {
                string line = string.Empty;
                Font font = new Font("Consolas", 20, FontStyle.Bold);

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("Titulo: "))
                    {

                        font = fontTitulo;
                        e.Graphics.DrawString(line.Replace("Titulo: ", ""), font,
                            new SolidBrush(Color.Black), retCabecalho, sf);

                        break;
                    }
                }

                SizeF strSize = new(e.Graphics.MeasureString(line, font));
                retCabecalho.Y += (int)(strSize.Height + 35);

                line = reader.ReadToEnd().Replace("Info_adicional: ", "");
                font = fontCabecalho;
                e.Graphics.DrawString(line, font,
                    new SolidBrush(Color.Black), retCabecalho, sf);
            }
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            infoModified = true;
        }

        private void txtInfoAdicional_TextChanged(object sender, EventArgs e)
        {
            infoModified = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (infoModified)
            {
                DialogResult dialog = MessageBox.Show("Deseja salvar as alterações?", "Salvar Alterações",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (dialog)
                {
                    case DialogResult.Yes:
                        SaveOrCreateFile();
                        this.Close();
                        break;

                    case DialogResult.No:
                        break;
                }
            }

        }

        private void FormConfiguracoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete("tempTxtFile.txt");
        }
        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja alterar as propriedades de fonte do título da OS? Selecione não para manter a fonte padrão (Consolas 15).", "Alterar Fonte",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (dialog)
            {
                case DialogResult.Yes:
                    fontTituloDialog.ShowDialog();
                    break;
            }

            txtTitulo.Font = fontTituloDialog.Font;
        }
        private void btnAlterarFonteInfo_Click(object sender, EventArgs e)
        {
            DialogResult dialog = fontInfoDialog.ShowDialog();

            if (dialog != DialogResult.Cancel)
            {
                fontCabecalho = fontInfoDialog.Font;
                txtInfoAdicional.Font = fontCabecalho;
                Properties.Settings.Default.fontCabecalho = this.fontCabecalho;
                Properties.Settings.Default.Save();

            }


        }

        private void btnAlterarFonteTitulo_Click(object sender, EventArgs e)
        {
            DialogResult dialog = fontTituloDialog.ShowDialog();

            if (dialog != DialogResult.Cancel)
            {
                fontTitulo = fontTituloDialog.Font;
                txtTitulo.Font = fontTitulo;
                Properties.Settings.Default.fontTitulo = this.fontTitulo;
                Properties.Settings.Default.Save();


            }
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtTitulo.Text))
            {
                WriteToTempFile();
            }
        }

        private void txtInfoAdicional_Leave(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtInfoAdicional.Text))
            {
                WriteToTempFile();
            }
        }
    }
}