using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Sistema_esperto.Serializzazione
{
    class CreazioneDatiQ3
    {
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
        //stream per la serializzazione in registrazione dati
        FileStream fs;
        //stream per la serializzazione in caricamento dati
        FileStream rd;

        

        public CreazioneDatiQ3() {}

        public void registraDati()
        {
            DatiQuadro3 dq = new DatiQuadro3();
            dq.limiteEi=this.limiteEi;
            dq.limiteEcs = this.limiteEcs;
            dq.varOR = this.varOR;
                      
                try
                 {
                     using (fs = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataq3.vin"), FileMode.Create, FileAccess.Write))
                     {
                         BinaryFormatter bynfor = new BinaryFormatter();
                         bynfor.Serialize(fs, dq);
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Errore durante il salvataggio dei dati: " + ex.ToString(),"Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }
                 
        }

        public void caricaDati()
        {
             DatiQuadro3 dq3 = new DatiQuadro3();

             try
             {
                 using (rd = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataq3.vin"), FileMode.Open, FileAccess.Read))
                 {

                     BinaryFormatter bynforead = new BinaryFormatter();

                     dq3 = (DatiQuadro3)bynforead.Deserialize(rd);

                     //assegna i valori alle proprieta'
                     this.limiteEi = dq3.limiteEi;
                     this.limiteEcs = dq3.limiteEcs;
                     this.varOR = dq3.varOR;

                 }
             }
             catch (Exception ex2)
             {
                 MessageBox.Show("Errore durante il caricamento dei dati del Quadro 3: " + ex2.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 MessageBox.Show("Verranno utilizzati i valori di default per il Quadro 3");
                 this.limiteEi = 3;
                 this.limiteEcs = 3.7;
                 this.varOR = true;

             }
        }
    }
}
