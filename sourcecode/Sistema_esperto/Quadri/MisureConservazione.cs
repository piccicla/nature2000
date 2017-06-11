using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace Sistema_esperto.Quadri
{
    public partial class MisureConservazione : Form
    {
        public MisureConservazione()
        {
            InitializeComponent();
        }

        private void MisureConservazione_Load(object sender, EventArgs e)
        {
            try
            {
                this.misureTableAdapter.Fill(this.misureDataSet.misure);
            }
            catch (Exception err)
            {
                MessageBox.Show("Errore di collegamento al database :" + err.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonApriSigla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxSigle.SelectedValue.ToString());
        }

        private void buttonApriNome_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
            try
            {
                using (Process myProcess = new Process())
                {
                    //prendi il nome del file e aprilo
                    myProcess.StartInfo.FileName = Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc";
                    myProcess.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //inizia un processo per l'apertura di un file esterno
            try
            {
                using (Process myProcess = new Process())
                {
                    //prendi il nome del file e aprilo
                    myProcess.StartInfo.FileName = Application.StartupPath + @"\misureconservazione\testo introduttivo.doc";
                    myProcess.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
         try
            {
                string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
                Process.Start(iePath, Application.StartupPath + @"\help\quadri\misure di conservazione.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
                    
        }
    }
}