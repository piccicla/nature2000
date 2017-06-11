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
    public partial class Quadro3 : Form
    {
        
        //proprieta' che contengono i valori risultanti di ei e ecs e servono
        //per aggiornare il pannallo di mainchild
        private double _Ei;
        public double Ei
        {
            get { return _Ei; }
            set { _Ei = value; }
        }
        
        private double _Ecs;
        public double Ecs
        {
            get { return _Ecs; }
            set { _Ecs = value; }
        }
        //proprieta' che contengono le im postazioni ottenute dalla deserializzazione
        private double _limiteEi;
        public double limiteEi
        {
            get { return _limiteEi; }
            set { _limiteEi = value; }
        }
        private double _limiteEcs;
        public double limiteEcs
        {
            get { return _limiteEcs; }
            set { _limiteEcs = value; }
        }
        private bool _varOR;

        public bool varOR
        {
            get { return _varOR; }
            set { _varOR = value; }
        }
	

        public Quadro3()
        {
            InitializeComponent();
            //inizializza i valori numerici degli indicatori
            this.Ei = 0;
            this.Ecs = 0;
           
            //deserializza i file di impostazioni
            CreazioneDatiQ3 crd3 = new CreazioneDatiQ3();
            crd3.caricaDati();
            this.limiteEi = crd3.limiteEi;
            this.limiteEcs = crd3.limiteEcs;
            this.varOR = crd3.varOR;

            //scrivi il testo corrispondente alle impostazioni
            this.labelSi.Text = "indicatore Ei >=" + this.limiteEi.ToString();
            if (varOR)
            {
                this.labelSi.Text = this.labelSi.Text + " o ";
            }
            else {
                this.labelSi.Text = this.labelSi.Text + " e ";
            }
            this.labelSi.Text = this.labelSi.Text + "Ecs >=" + this.limiteEcs.ToString();

            this.labelNo.Text = "indicatore Ei <" + this.limiteEi.ToString();
            if (varOR)
            {
                this.labelNo.Text = this.labelNo.Text + " o ";
            }
            else
            {
                this.labelNo.Text = this.labelNo.Text + " e ";
            }
            this.labelNo.Text = this.labelNo.Text + "Ecs <" + this.limiteEcs.ToString();

          

        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* ValutazionePositiva valpos = new ValutazionePositiva();
            valpos.MdiParent = this.ParentForm;
            valpos.Show();
            this.Close();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalcolaEi calcei = new CalcolaEi();

            calcei.ShowDialog();
            if (calcei.DialogResult == DialogResult.OK)
            {
                this.labelEi.Text = "Ei= " + calcei.Ei.ToString();
                this.Ei = calcei.Ei;
                calcei.Dispose();
                checkLimit();
            }
            if (calcei.DialogResult == DialogResult.Cancel)
            {
                calcei.Dispose();
            }
        }
    
        private void buttonCalcolaEcs_Click(object sender, EventArgs e)
        {
            CalcolaEcs calcecs = new CalcolaEcs();
            calcecs.ShowDialog();
            if(calcecs.DialogResult==DialogResult.OK){
                this.labelEcs.Text = "Ecs= "+ calcecs.Ecs.ToString();
                this.Ecs =calcecs.Ecs;
                calcecs.Dispose();
                checkLimit();
            }
            if (calcecs.DialogResult == DialogResult.Cancel) {
                calcecs.Dispose();
            }
        }
        private void checkLimit()
        {
            if (varOR)
            {
                if ((Ei >= limiteEi) | (Ecs >= limiteEcs))
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
            if (varOR == false)
            {
                if ((Ei >= limiteEi) & (Ecs >= limiteEcs))
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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MisureConservazione miscons = new MisureConservazione();
            miscons.ShowDialog();
            if (miscons.DialogResult == DialogResult.Cancel) {
                miscons.Dispose();
            }
        }  
        }   
    }
