using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema_esperto.Serializzazione;
using System.Diagnostics;


namespace Sistema_esperto.Quadri
{
    public partial class CalcolaPs : Form
    {
        //proprieta' che memorizza il valore di ps
        private double _Ps;
        public double Ps
        {
            get { return _Ps; }
            set { _Ps = value; }
        }

        public CalcolaPs()
        {
            InitializeComponent();
            Ps = 0;
            
            //ottieni dati serializzati per riempire la tabella
            CreazioneDatiPs crd = new CreazioneDatiPs();
            crd.caricaDati();
            //assegna dati ai componenti della tabella
            //TABELLA 1
            this.textBoxParametro11.Text = crd.testoParametro11;
            this.textBoxParametro21.Text = crd.testoParametro21;
            this.textBoxParametro31.Text = crd.testoParametro31;
            //--------misura caso 1-----------------
            this.misura51Ps1.Text = crd.misura51Ps1;
            this.misura41Ps1.Text = crd.misura41Ps1;
            this.misura31Ps1.Text = crd.misura31Ps1;
            this.misura21Ps1.Text = crd.misura21Ps1;
            this.misura11Ps1.Text = crd.misura11Ps1;
            //--------misura caso 2-----------------
            this.misura52Ps1.Text = crd.misura52Ps1;
            this.misura42Ps1.Text = crd.misura42Ps1;
            this.misura32Ps1.Text = crd.misura32Ps1;
            this.misura22Ps1.Text = crd.misura22Ps1;
            this.misura12Ps1.Text = crd.misura12Ps1;
            //--------misura caso 3-----------------
            this.misura53Ps1.Text = crd.misura53Ps1;
            this.misura43Ps1.Text = crd.misura43Ps1;
            this.misura33Ps1.Text = crd.misura33Ps1;
            this.misura23Ps1.Text = crd.misura23Ps1;
            this.misura13Ps1.Text = crd.misura13Ps1;
            //TABELLA 2
            this.textBoxParametro12.Text = crd.testoParametro12;
            this.textBoxParametro22.Text = crd.testoParametro22;
            this.textBoxParametro32.Text = crd.testoParametro32;
            //--------misura caso 1-----------------
            this.misura51Ps2.Text = crd.misura51Ps2;
            this.misura41Ps2.Text = crd.misura41Ps2;
            this.misura31Ps2.Text = crd.misura31Ps2;
            this.misura21Ps2.Text = crd.misura21Ps2;
            this.misura11Ps2.Text = crd.misura11Ps2;
            //--------misura caso 2-----------------
            this.misura52Ps2.Text = crd.misura52Ps2;
            this.misura42Ps2.Text = crd.misura42Ps2;
            this.misura32Ps2.Text = crd.misura32Ps2;
            this.misura22Ps2.Text = crd.misura22Ps2;
            this.misura12Ps2.Text = crd.misura12Ps2;
            //--------misura caso 3-----------------
            this.misura53Ps2.Text = crd.misura53Ps2;
            this.misura43Ps2.Text = crd.misura43Ps2;
            this.misura33Ps2.Text = crd.misura33Ps2;
            this.misura23Ps2.Text = crd.misura23Ps2;
            this.misura13Ps2.Text = crd.misura13Ps2;
            //TABELLA 3
            this.textBoxParametro13.Text = crd.testoParametro13;
            //--------misura caso 1-----------------
            this.misura51Ps3.Text = crd.misura51Ps3;
            this.misura41Ps3.Text = crd.misura41Ps3;
            this.misura31Ps3.Text = crd.misura31Ps3;
            this.misura21Ps3.Text = crd.misura21Ps3;
            this.misura11Ps3.Text = crd.misura11Ps3;
           

        }
        private void calcolaPs()
        {
            Ps = (double)(5 - (((5 - (this.numericUpDownParametro1.Value) + 1) * (5 - (this.numericUpDownParametro2.Value) + 1) * (5 - (this.numericUpDownParametro3.Value) + 1)) / 25));
            this.textBoxRisultatoPs.Text = Ps.ToString();
        }
        
        //mostra la speigazione di Storie-villa quando l'utente preme l'etichetta 
        private void linkLabelSpegazioneVilla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Spiegazione_Storie_Villa sv = new Spiegazione_Storie_Villa();
            sv.Show();
        }

        private void numericUpDownParametro1_ValueChanged(object sender, EventArgs e)
        {
            calcolaPs();
        }

        private void numericUpDownParametro2_ValueChanged(object sender, EventArgs e)
        {
            calcolaPs();
        }

        private void numericUpDownParametro3_ValueChanged(object sender, EventArgs e)
        {
            calcolaPs();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
            try
            {
                string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
                Process.Start(iePath, Application.StartupPath + @"\help\quadri\calcolo indicatori.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }
      
    }
}