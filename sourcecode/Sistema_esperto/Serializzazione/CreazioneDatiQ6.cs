using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Sistema_esperto.Serializzazione
{

    class CreazioneDatiQ6
    {

        //proprieta' da serializzare
        private double _limitePs;
        public double limitePs
        {
            get { return _limitePs; }
            set { _limitePs = value; }
        }

        //stream per la serializzazione in registrazione dati
        FileStream fs;
        //stream per la serializzazione in caricamento dati
        FileStream rd;

        public CreazioneDatiQ6() { }

        public void registraDati()
        {
            //Apertura classe serializzabile e assegnamento dei dati da serializzare
             DatiQuadro6 dq = new DatiQuadro6();
             dq.limitePs = this.limitePs;


            try
            {
                using (fs = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataq6.vin"), FileMode.Create, FileAccess.Write))
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
            DatiQuadro6 dq2 = new DatiQuadro6();

            try
            {
                using (rd = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataq6.vin"), FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bynforead = new BinaryFormatter();

                    dq2 = (DatiQuadro6)bynforead.Deserialize(rd);

                    //assegna i valori alle proprieta'
                    this.limitePs = dq2.limitePs;
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Errore durante il caricamento dei dati del Quadro 6: " + ex2.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Verranno utilizzati i valori di default per il Quadro 6");
                this.limitePs = 3.9;
            }
        }
    }
}
