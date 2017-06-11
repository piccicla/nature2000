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
    public partial class Quadro7 : Form
    {
        //proprieta' che contengono i valori risultanti di ecum e servono
        //per aggiornare il pannello di mainchild
        private double _Ecum;
        public double Ecum
        {
            get { return _Ecum; }
            set { _Ecum = value; }
        }
        
        //proprieta' che contengono le impostazioni ottenute dalla deserializzazione
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

        public Quadro7()
        {
            InitializeComponent();
            this.Ecum = 0;

            ////deserializza i file di impostazioni
            CreazioneDatiQ7 crd7 = new CreazioneDatiQ7();
            crd7.caricaDati();
            this.limiteEcumNoRedList = crd7.limiteEcumNoRedList;
            this.limiteEcumRedList = crd7.limiteEcumRedList;

            //scrivi il testo corrispondente alle impostazioni
            this.labelSi.Text = "Livello soglia Ecum  < "+this.limiteEcumNoRedList.ToString()+ " qualora trattasi di specie non vulnerabili";
            this.labelSi.Text = this.labelSi.Text + "\n"+"Ecum < " + this.limiteEcumRedList.ToString() + " se figurano nella red list regionale ";
                                  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //inizia un processo per l'apertura di un file esterno
            try
            {
                using (Process myProcess = new Process())
                {
                    //prendi il nome del file e aprilo
                    myProcess.StartInfo.FileName = Application.StartupPath + @"\incidenza\incidenza.doc";
                    myProcess.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

        private void Quadro7_Load(object sender, EventArgs e)
        {
            //quando si apre la finestra avviene il collegamento al database per permettere all'utente
            //di scegliere la specie e il relativo valore di qs
            try
            {
                this.specieTableAdapter1.Fill(this.red_listDataSet1.specie);
            }
            catch (Exception err)
            {
                MessageBox.Show("Errore di collegamento al database :" + err.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }     
        }
    }
}