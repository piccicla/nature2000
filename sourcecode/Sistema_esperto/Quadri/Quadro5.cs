using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema_esperto;

namespace Sistema_esperto.Quadri
{
    public partial class Quadro5 : Form
    {
        public Quadro5()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*ValutazionePositiva2 valpos2 = new ValutazionePositiva2();
            valpos2.MdiParent = this.ParentForm;
            valpos2.Show();
            this.Close();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* ValutazionePositiva valpos = new ValutazionePositiva();
            valpos.MdiParent = this.ParentForm;
            valpos.Show();
            this.Close();*/
        }

        private void Quadro5_Shown(object sender, EventArgs e)
        {
            //quando si apre la finestra avviene il collegamento al database per permettere all'utente
            //di scegliere la specie e il relativo valore di qs
            try
            {
                this.specieTableAdapter1.Fill(this.red_listDataSet1.specie);
            }
            catch (Exception err)
            {
                MessageBox.Show("Errore di collegamento al database :" + err.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }     
        }
    }
}