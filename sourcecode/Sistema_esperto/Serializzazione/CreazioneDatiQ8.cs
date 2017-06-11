
//SOSTITUIRE DOVE PRESENTE //

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Sistema_esperto.Serializzazione
{

    class CreazioneDatiQ8
    {

        //proprieta' da serializzare
        //proprieta'da passare al costruttore del quadro8        
        private double _areale1;
        public double areale1
        {
            get { return _areale1; }
            set { _areale1 = value; }
        }
        private double _areale2;
        public double areale2
        {
            get { return _areale2; }
            set { _areale2 = value; }
        }
        private double _areale3;
        public double areale3
        {
            get { return _areale3; }
            set { _areale3 = value; }
        }
        private double _areale4;
        public double areale4
        {
            get { return _areale4; }
            set { _areale4 = value; }
        }
        private double _areale5;
        public double areale5
        {
            get { return _areale5; }
            set { _areale5 = value; }
        }
        private double _areale6;
        public double areale6
        {
            get { return _areale6; }
            set { _areale6 = value; }
        }
        private double _areale7;
        public double areale7
        {
            get { return _areale7; }
            set { _areale7 = value; }
        }
        private double _areale8;
        public double areale8
        {
            get { return _areale8; }
            set { _areale8 = value; }
        }
        //valori per limiti di Paa
        private double _limite1;
        public double limite1
        {
            get { return _limite1; }
            set { _limite1 = value; }
        }
        private double _limite2;
        public double limite2
        {
            get { return _limite2; }
            set { _limite2 = value; }
        }
        private double _limite3;
        public double limite3
        {
            get { return _limite3; }
            set { _limite3 = value; }
        }
        private double _limite4;
        public double limite4
        {
            get { return _limite4; }
            set { _limite4 = value; }
        }
        private double _limite5;
        public double limite5
        {
            get { return _limite5; }
            set { _limite5 = value; }
        }
        private double _limite6;
        public double limite6
        {
            get { return _limite6; }
            set { _limite6 = value; }
        }
        private double _limite7;
        public double limite7
        {
            get { return _limite7; }
            set { _limite7 = value; }
        }
        private double _limite8;
        public double limite8
        {
            get { return _limite8; }
            set { _limite8 = value; }
        }

        //stream per la serializzazione in registrazione dati
        FileStream fs;
        //stream per la serializzazione in caricamento dati
        FileStream rd;

        public CreazioneDatiQ8() { }

        public void registraDati()
        {
            //Apertura classe serializzabile e assegnamento dei dati da serializzare
            DatiQuadro8 dq = new DatiQuadro8();
            dq.areale1=this.areale1;
            dq.areale2=this.areale2;
            dq.areale3=this.areale3;
            dq.areale4=this.areale4;
            dq.areale5=this.areale5;
            dq.areale6=this.areale6;
            dq.areale7=this.areale7;
            dq.areale8 = this.areale8;

            dq.limite1=this.limite1;
            dq.limite2 = this.limite2;
            dq.limite3 = this.limite3; 
            dq.limite4 = this.limite4; 
            dq.limite5 = this.limite5; 
            dq.limite6 = this.limite6; 
            dq.limite7 = this.limite7; 

            try
            {
                using(fs = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataq8.vin"), FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter bynfor = new BinaryFormatter();
                    bynfor.Serialize(fs, dq);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il salvataggio dei dati: " + ex.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void caricaDati()
        {
            DatiQuadro8 dq2 = new DatiQuadro8();

            try
            {
                using(rd = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataq8.vin"), FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bynforead = new BinaryFormatter();

                    dq2 = (DatiQuadro8)bynforead.Deserialize(rd);

                    //assegna i valori alle proprieta'
                    this.areale1 = dq2.areale1;
                    this.areale2 = dq2.areale2;
                    this.areale3 = dq2.areale3;
                    this.areale4 = dq2.areale4;
                    this.areale5 = dq2.areale5;
                    this.areale6 = dq2.areale6;
                    this.areale7 = dq2.areale7;
                    this.areale8 = dq2.areale8;

                    this.limite1 = dq2.limite1;
                    this.limite2 = dq2.limite2;
                    this.limite3 = dq2.limite3;
                    this.limite4 = dq2.limite4;
                    this.limite5 = dq2.limite5;
                    this.limite6 = dq2.limite6;
                    this.limite7 = dq2.limite7;
                }

            }
            catch (Exception ex2)
            {
                MessageBox.Show("Errore durante il caricamento dei dati: " + ex2.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Verranno utilizzati i valori di default");
                this.areale1 = 10;
                this.areale2 = 5;
                this.areale3 = 1;
                this.areale4 = 0.5;
                this.areale5 = 0.25;
                this.areale6 = 0.1;
                this.areale7 = 0.05;
                this.areale8 = 0;

                this.limite1 = 1;
                this.limite2 = 2;
                this.limite3 = 2.5;
                this.limite4 = 3.01;
                this.limite5 = 3.5;
                this.limite6 = 3.9;
                this.limite7 = 4;
            }
        }
    }
}
