using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema_esperto.Quadri;
using System.Diagnostics;

namespace Sistema_esperto
{
    public partial class AiutoQs : Form
    {
        //proprieta' che memorizza il valore di ecs
        private double _Qs;
        public double Qs
        {
            get { return _Qs; }
            set { _Qs = value; }
        }
        public AiutoQs()
        {
            InitializeComponent();
        }

        private void calcolaQs()
        {
            Qs = (double)(5 - (((5 - (this.numericUpDownParametro1.Value) + 1) * (5 - (this.numericUpDownParametro2.Value) + 1) * (5 - (this.numericUpDownParametro3.Value) + 1) * (5 - (this.numericUpDownParametro4.Value) + 1)) / 125));
            this.textBoxRisultatoQs.Text = Qs.ToString();
        }

        private void linkLabelSpegazioneVilla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Spiegazione_Storie_Villa sv = new Spiegazione_Storie_Villa();
            sv.Show();
        }

        private void numericUpDownParametro1_ValueChanged_1(object sender, EventArgs e)
        {
            calcolaQs();
        }

        private void numericUpDownParametro2_ValueChanged(object sender, EventArgs e)
        {
            calcolaQs();
        }

        private void numericUpDownParametro3_ValueChanged(object sender, EventArgs e)
        {
            calcolaQs();
        }

        private void numericUpDownParametro4_ValueChanged(object sender, EventArgs e)
        {
            calcolaQs();
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