using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Sistema_esperto.Serializzazione
{

    class CreazioneDatiQ7
    {
        //proprieta' da serializzare
        private double _limiteEcumNoRedList;
        public double limiteEcumNoRedList
        {
            get { return _limiteEcumNoRedList; }
            set { _limiteEcumNoRedList = value; }
        }
        private double _limiteEcumRedList;
        public double limiteEcumRedList
        {
            get { return _limiteEcumRedList; }
            set { _limiteEcumRedList = value; }
        }

        //stream per la serializzazione in registrazione dati
        FileStream fs;
        //stream per la serializzazione in caricamento dati
        FileStream rd;

        public CreazioneDatiQ7() { }

        public void registraDati()
        {
            //Apertura classe serializzabile e assegnamento dei dati da serializzare
            DatiQuadro7 dq = new DatiQuadro7();
            dq.limiteEcumNoRedList = this.limiteEcumNoRedList;
            dq.limiteEcumRedList = this.limiteEcumRedList;

            try
            {
                using(fs = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataq7.vin"), FileMode.Create, FileAccess.Write))
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
            DatiQuadro7 dq2 = new DatiQuadro7();

            try
            {
                using(rd = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataq7.vin"), FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bynforead = new BinaryFormatter();

                    dq2 = (DatiQuadro7)bynforead.Deserialize(rd);

                    //assegna i valori alle proprieta'
                    this.limiteEcumNoRedList = dq2.limiteEcumNoRedList;
                    this.limiteEcumRedList = dq2.limiteEcumRedList;
                }

            }
            catch (Exception ex2)
            {
                MessageBox.Show("Errore durante il caricamento dei dati del Quadro 7: " + ex2.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Verranno utilizzati i valori di default per il Quadro 7");
                
                this.limiteEcumNoRedList = 5;
                this.limiteEcumRedList = 4;

            }
        }
    }
}
