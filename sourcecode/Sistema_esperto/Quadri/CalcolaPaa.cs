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
    public partial class CalcolaPaa : Form
    {
        //proprieta' che memorizza il valore di paa
        private double _Paa;
        public double Paa
        {
            get { return _Paa; }
            set { _Paa = value; }
        }
        //proprieta' che riceve il valore di ps dalla maschera8
        private double _Ps;
        public double Ps
        {
            get { return _Ps; }
            set { _Ps = value; }
        }
        //booleano che controlla se bisogna passare il valore di ps alla tabella 
        //private double psOk=false;

        //booleano che dice se e' stato scelto un parametro 1 con valore 4 o 5
        private bool _isParam1Ok;
        public bool isParam1Ok
        {
            get { return _isParam1Ok; }
            set { _isParam1Ok = value; }
        }

        //booleano che indica se e' stato precedentemente aperto il quadro6 da passare alla tabella calcola paa
        private bool _isQ6Ok;
        public bool isQ6Ok
        {
            get { return _isQ6Ok; }
            set { _isQ6Ok = value; }
        }
        //il valore massimo di ps calcolato(nel caso non si sia passati dal quadro 6)
        private double _MaxPs;
        public double MaxPs
        {
            get { return _MaxPs; }
            set { _MaxPs = value; }
        }
        //booleano che indica se e' stato aperta la tabella per il calcolo di ps
        private bool _isPsOk;
        public bool isPsOk
        {
            get { return _isPsOk; }
            set { _isPsOk = value; }
        }
        //dati serializzati per riempire la tabella
        private CreazioneDatiPaa crd;
        
        public CalcolaPaa(double newPs,bool isQ6Ok)// eventualmente aggiungere
        {
            InitializeComponent();
            Paa = 0;
            this.Ps = newPs;
            this.isParam1Ok = false;
            //this.psOk=true;
            this.isQ6Ok = isQ6Ok;
            //inizializza valore di psmax
            this.MaxPs = -1;
            //inizializza il parametro che registra l'apertura della tabella ps
            this.isPsOk = false;

            InitializeComponents2();
           
        }

        private void InitializeComponents2()
        {
            //ottieni dati serializzati per riempire la tabella
            crd = new CreazioneDatiPaa();
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
            this.misura52.Text = crd.misurasx52 + " " + crd.misuradx52.ToString();
            this.misura42.Text = crd.misurasx42 + " " + crd.misuradx42.ToString();
            this.misura32.Text = crd.misurasx32 + " " + crd.misuradx32.ToString();
            this.misura22.Text = crd.misurasx22 + " " + crd.misuradx22.ToString();
            this.misura12.Text = crd.misurasx12 + " " + crd.misuradx12.ToString();
            //--------misura parametro 3-----------------
            this.misura53.Text = crd.misura53;
            this.misura33.Text = crd.misura33;
            this.misura23.Text = crd.misura23;
            this.misura13.Text = crd.misura13;

            if (this.isQ6Ok == true)
            {
                if (crd.isPsOk == true)
                {

                    //aggiorna la label con il valore di ps e accendi la label
                    this.textBoxParametro2.Text = this.textBoxParametro2.Text + "calcolato nel quadro 6 " + " Ps= " + this.Ps.ToString();
                    //metti il valore del parametro2 in base al valore di ps

                    checkPs(this.Ps);
                }
            }
            else {
                this.groupBoxCalcoloPs.Visible = true;
            }
        }
        //metti il valore del parametro2 in base al valore di ps
        private void checkPs(double Ps)
        {
            if (Ps >= (double)crd.misuradx52)
            {
                this.misura52.BackColor = Color.Chartreuse;
                this.numericUpDownParametro2.Value = (decimal)5.00;
                calcolaPaa();
            }
            else if (Ps >= (double)crd.misuradx42)
            {
                this.misura42.BackColor = Color.Chartreuse;
                this.numericUpDownParametro2.Value = (decimal)4.00;
                calcolaPaa();
            }
            else if (Ps >= (double)crd.misuradx32)
            {
                this.misura32.BackColor = Color.Chartreuse;
                this.numericUpDownParametro2.Value = (decimal)3.00;
                calcolaPaa();
            }
            else if (Ps >= (double)crd.misuradx22)
            {
                this.misura22.BackColor = Color.Chartreuse;
                this.numericUpDownParametro2.Value = (decimal)2.00;
                calcolaPaa();
            }
            else if (Ps >= (double)crd.misuradx12)
            {
                this.misura12.BackColor = Color.Chartreuse;
                this.numericUpDownParametro2.Value = (decimal)1.00;
                calcolaPaa();
            }
        }
        //mostra la spiegazione di Storie-villa quando l'utente preme l'etichetta
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Spiegazione_Storie_Villa sv = new Spiegazione_Storie_Villa();
            sv.Show();
        }

        private void numericUpDownParametro1_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownParametro1.Value == 4 | this.numericUpDownParametro1.Value == 5)
            {
                this.isParam1Ok = true;
            }
            else {
                this.isParam1Ok = false;
            }
            calcolaPaa();
        }

       

        private void numericUpDownParametro2_ValueChanged(object sender, EventArgs e)
        {
            calcolaPaa();
        }

        private void numericUpDownParametro3_ValueChanged(object sender, EventArgs e)
        {
            calcolaPaa();
        }
        private void calcolaPaa()
        {
            Paa = (double)(5 - (((5 - (this.numericUpDownParametro1.Value) + 1) * (5 - (this.numericUpDownParametro2.Value) + 1) * (5 - (this.numericUpDownParametro3.Value) + 1)) / 25));
            this.textBoxRisultatoPaa.Text = Paa.ToString();
        }

        private void buttonCalcolaPs_Click(object sender, EventArgs e)
        {
            CalcolaPs calcps = new CalcolaPs();

            calcps.ShowDialog();
            if (calcps.DialogResult == DialogResult.OK)
            {
                this.labelPs.Text = "Ps= " + calcps.Ps.ToString();
                this.Ps = calcps.Ps;
                this.isPsOk = true;
                calcps.Dispose();
                // controlla i valori di ps
                checkMax();
                checkPs(this.MaxPs);
            }
            if (calcps.DialogResult == DialogResult.Cancel)
            {
                calcps.Dispose();
            }            
        }
        private void checkMax()
        {
            if (this.Ps > this.MaxPs)
            {
                this.MaxPs = this.Ps;
                this.labelPsMax.Text = "Valore massimo calcolato =" + this.MaxPs.ToString();               
            }
        }

        private void buttonAzzeraPs_Click(object sender, EventArgs e)
        {
            this.labelPsMax.Text = "Valore massimo calcolato = 0";
            this.MaxPs = 0;
            this.numericUpDownParametro2.Value = (decimal)1.00;
            this.misura52.BackColor = SystemColors.Control;
            this.misura42.BackColor = SystemColors.Control;
            this.misura32.BackColor = SystemColors.Control;
            this.misura22.BackColor = SystemColors.Control;
            this.misura12.BackColor = SystemColors.Control;
        }

        private void buttonApriMisure_Click(object sender, EventArgs e)
        {
            MisureConservazione mis = new MisureConservazione();
            mis.ShowDialog();
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