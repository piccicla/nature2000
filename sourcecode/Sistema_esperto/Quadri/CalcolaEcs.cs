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
    public partial class CalcolaEcs : Form
    {
       //proprieta' che memorizza il valore di ecs
        private double _Ecs;
        public double Ecs
        {
            get { return _Ecs; }
            set { _Ecs = value; }
        }
	
        public CalcolaEcs()
        {
            InitializeComponent();
            Ecs = 0;
            //ottieni dati serializzati per riempire la tabella
            CreazioneDatiEcs crd = new CreazioneDatiEcs();
            crd.caricaDati();
            //assegna dati ai componenti della tabella
            //testo parametri
            this.textBoxParametro1.Text = crd.testoParametro1;
            this.textBoxParametro2.Text = crd.testoParametro2;
            this.textBoxParametro3.Text = crd.testoParametro3;
            //--------misura parametro 1-----------------
            this.misura51.Text = crd.misura51;
            this.misura41.Text = crd.misura41;
            this.misura31.Text = crd.misura31;
            this.misura21.Text = crd.misura21;
            this.misura11.Text = crd.misura11;
            //--------misura parametro 2-----------------
            this.misura52.Text = crd.misura52;
            this.misura42.Text = crd.misura42;
            this.misura32.Text = crd.misura32;
            this.misura22.Text = crd.misura22;
            this.misura12.Text = crd.misura12;
            //--------misura parametro 3-----------------
            this.misura53.Text = crd.misura53;
            this.misura43.Text = crd.misura43;
            this.misura33.Text = crd.misura33;
            this.misura23.Text = crd.misura23;
            this.misura13.Text = crd.misura13;
            //----------avvertimenti--------------------
            this.textBoxAvvertimento1.Text = crd.avvertimento1;
            this.textBoxAvvertimento2.Text = crd.avvertimento2;
            this.textBoxAvvertimento3.Text = crd.avvertimento3;

           
        }
       

        private void calcolaEcs()
        {
            Ecs = (double)(5 - (((5 - (this.numericUpDownParametro1.Value) + 1) * (5 - (this.numericUpDownParametro2.Value) + 1) * (5 - (this.numericUpDownParametro3.Value) + 1)) / 25));
            this.textBoxRisultatoEcs.Text = Ecs.ToString();
        }
     
        private void numericUpDownParametro1_ValueChanged(object sender, EventArgs e)
        {
            calcolaEcs();
        }

        private void numericUpDownParametro2_ValueChanged(object sender, EventArgs e)
        {
            calcolaEcs();
        }

        private void numericUpDownParametro3_ValueChanged(object sender, EventArgs e)
        {
            calcolaEcs();
        }
        
        //mostra la speigazione di Storie-villa quando l'utente preme l'etichetta 
        private void linkLabelSpegazioneVilla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Spiegazione_Storie_Villa sv = new Spiegazione_Storie_Villa();
            sv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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