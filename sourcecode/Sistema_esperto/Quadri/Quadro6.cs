using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema_esperto.Serializzazione;


namespace Sistema_esperto.Quadri
{
    public partial class Quadro6 : Form
    {
        //proprieta' che contengono i valori risultanti di ps e massimo ps e servono
        //per aggiornare il pannello di mainchild
        //proprieta' per conservare l'ultimo valore di ps calcolato
        private double _Ps;
        public double Ps
        {
            get { return _Ps; }
            set { _Ps = value; }
        }
        //il valore massimo viene ritornato a mainchild
        private double _MaxPs;
        public double MaxPs
        {
            get { return _MaxPs; }
            set { _MaxPs = value; }
        }

        
        //proprieta' che contengono le impostazioni ottenute dalla deserializzazione
        private double _limitePs;
        public double limitePs
        {
            get { return _limitePs; }
            set { _limitePs = value; }
        }
        //booleano che indica se e' stato calcolato ps
        private bool _isPsOk;
        public bool isPsOk
        {
            get { return _isPsOk; }
            set { _isPsOk = value; }
        }

        public Quadro6()
        {
            InitializeComponent();
            this.Ps = 0;
            this.MaxPs = -1;
            this.isPsOk = false;
            
            ////deserializza i file di impostazioni
            CreazioneDatiQ6 crd6 = new CreazioneDatiQ6();
            crd6.caricaDati();
            this.limitePs = crd6.limitePs;

            //scrivi il testo corrispondente alle impostazioni*/
            this.labelSi.Text = "indicatore PS>=" + this.limitePs.ToString();
            this.labelNo.Text = "indicatore PS<" + this.limitePs.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalcolaPs calcps = new CalcolaPs();

            calcps.ShowDialog();
            if (calcps.DialogResult == DialogResult.OK)
            {
                this.labelPs.Text = "Ps= " + calcps.Ps.ToString();
                this.Ps = calcps.Ps;
                this.isPsOk = true;
                calcps.Dispose();
                //visualizza i controlli del valore massimo di ps
                this.labelValoreMassimo.Visible = true;
                this.buttonAnnullaValMax.Visible = true;
                // controlla i valori di ps
                checkMax();
                checkLimit();
            }
            if (calcps.DialogResult == DialogResult.Cancel)
            { 
                calcps.Dispose(); 
            }          
        }
        //controla che il valore di ps non sia il massimo ottenuto
        //se e' vero aggiorna il valore massimo
        private void checkMax()
        {
            if (this.Ps > this.MaxPs) {
                this.MaxPs = this.Ps;
                this.labelValoreMassimo.Text = "Valore massimo calcolato ="+ this.MaxPs.ToString();
     
            }
        }
        //varia lo stato dei bottono
        private void checkLimit() { 
       
                if (this.MaxPs>= limitePs)
                {
                    this.buttonSi.Enabled = true;
                    this.buttonSi.BackColor = Color.Lime;
                    this.buttonNo.Enabled = false;
                    this.buttonNo.BackColor = Color.White;
                }
                else
                {
                    this.buttonSi.Enabled = false;
                    this.buttonSi.BackColor = Color.White;
                    this.buttonNo.Enabled = true;
                    this.buttonNo.BackColor = Color.Lime;
                }
        }

        private void buttonAnnullaValMax_Click(object sender, EventArgs e)
        {
            this.labelValoreMassimo.Text = "Valore massimo calcolato = 0";
            this.MaxPs = 0;
            checkLimit();
        }

    }
}