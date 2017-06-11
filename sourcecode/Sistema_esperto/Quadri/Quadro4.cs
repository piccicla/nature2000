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
    public partial class Quadro4 : Form
    {
        public Quadro4()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Quadro6 quadro6 = new Quadro6();
            quadro6.MdiParent = this.ParentForm;
            quadro6.Show();
            this.Close();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* Quadro5 quadro5 = new Quadro5();
            quadro5.MdiParent = this.ParentForm;
            quadro5.Show();
            this.Close();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //inizia un processo per l'apertura di un file esterno
            try
            {
                using (Process myProcess = new Process())
                {
                    //prendi il nome del file e aprilo
                    myProcess.StartInfo.FileName = Application.StartupPath + @"\incidenza\incidenza.doc";
                    myProcess.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

        private void buttonMisure_Click(object sender, EventArgs e)
        {
            MisureConservazione miscons = new MisureConservazione();
            miscons.ShowDialog();
            if (miscons.DialogResult == DialogResult.Cancel)
            {
                miscons.Dispose();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}