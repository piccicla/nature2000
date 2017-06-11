using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Sistema_esperto.Serializzazione
{
    
    class CreazioneDatiQ1
    {
        
        //proprieta' da serializzare
        private double _Qs1;
        public double Qs1
        {
            get { return _Qs1; }
            set { _Qs1 = value; }
        }

        private int _numQs1;
        public int numQs1
        {
            get { return _numQs1; }
            set { _numQs1 = value; }
        }
	

        private double _Qs2;
        public double Qs2
        {
            get { return _Qs2; }
            set { _Qs2 = value; }
        }

        private int _numQs2;
        public int numQs2
        {
            get { return _numQs2; }
            set { _numQs2 = value; }
        }
        
        private bool _sup;
        public bool sup
        {
            get { return _sup; }
            set { _sup = value; }
        }

        private int _raggio;
        public int raggio
        {
            get { return _raggio; }
            set { _raggio = value; }
        }

        private bool _qsOk;
        public bool qsOk
        {
            get { return _qsOk; }
            set { _qsOk = value; }
        }
        //stream per la serializzazione in registrazione dati
        FileStream fs;
        //stream per la serializzazione in caricamento dati
        FileStream rd;



        public CreazioneDatiQ1() {}

        public void registraDati()
        {
            DatiQuadro1 dq = new DatiQuadro1();
            dq.Qs1=this.Qs1;
            dq.numQs1 = this.numQs1;
            dq.Qs2 = this.Qs2;
            dq.numQs2 = this.numQs2;
            dq.sup = this.sup;
            dq.raggio = this.raggio;
            dq.qsOk = this.qsOk;
            try
            {
                using (fs = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataq1.vin"), FileMode.Create, FileAccess.Write))
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
             DatiQuadro1 dq2 = new DatiQuadro1();

             try
             {
                 using (rd = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataq1.vin"), FileMode.Open, FileAccess.Read))
                 {

                     BinaryFormatter bynforead = new BinaryFormatter();

                     dq2 = (DatiQuadro1)bynforead.Deserialize(rd);

                     //assegna i valori alle proprieta'
                     Qs1 = dq2.Qs1;
                     numQs1 = dq2.numQs1;
                     Qs2 = dq2.Qs2;
                     numQs2 = dq2.numQs2;
                     sup = dq2.sup;
                     raggio = dq2.raggio;
                     qsOk = dq2.qsOk;
                 }
             }
             catch (Exception ex2) {
                 MessageBox.Show("Errore durante il caricamento dei dati del Quadro 1: " + ex2.ToString(),"Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 MessageBox.Show("Verranno utilizzati i valori di default per il Quadro 1");
                 Qs1 = 4.8;
                 numQs1 = 3;
                 Qs2 = 4.5;
                 numQs2 = 4;
                 sup = false;
                 raggio = 300;
                 qsOk = false;
                          
             }
        }
    }
}
