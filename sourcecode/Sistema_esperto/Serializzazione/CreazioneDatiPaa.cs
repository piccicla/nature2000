using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Sistema_esperto.Serializzazione
{

    class CreazioneDatiPaa
    {
        //proprieta' da serializzare
        //testo parametri
        private string _testoParametro1;
        public string testoParametro1
        {
            get { return _testoParametro1; }
            set { _testoParametro1 = value; }
        }
        private string _testoParametro2;
        public string testoParametro2
        {
            get { return _testoParametro2; }
            set { _testoParametro2 = value; }
        }
        private string _testoParametro3;
        public string testoParametro3
        {
            get { return _testoParametro3; }
            set { _testoParametro3 = value; }
        }
        //testi misure
        //--------misura parametro 1------------------------
        private string _misura51;
        public string misura51
        {
            get { return _misura51; }
            set { _misura51 = value; }
        }
        private string _misura41;
        public string misura41
        {
            get { return _misura41; }
            set { _misura41 = value; }
        }
        private string _misura31;
        public string misura31
        {
            get { return _misura31; }
            set { _misura31 = value; }
        }
        private string _misura21;
        public string misura21
        {
            get { return _misura21; }
            set { _misura21 = value; }
        }
        private string _misura11;
        public string misura11
        {
            get { return _misura11; }
            set { _misura11 = value; }
        }
        //-----------misure parametro 2sx-----------------------
        private string _misurasx52;
        public string misurasx52
        {
            get { return _misurasx52; }
            set { _misurasx52 = value; }
        }
        private string _misurasx42;
        public string misurasx42
        {
            get { return _misurasx42; }
            set { _misurasx42 = value; }
        }
        private string _misurasx32;
        public string misurasx32
        {
            get { return _misurasx32; }
            set { _misurasx32 = value; }
        }
        private string _misurasx22;
        public string misurasx22
        {
            get { return _misurasx22; }
            set { _misurasx22 = value; }
        }
        private string _misurasx12;
        public string misurasx12
        {
            get { return _misurasx12; }
            set { _misurasx12 = value; }
        }
        //-----------misure parametro 2dx-----------------------
        private decimal _misuradx52;
        public decimal misuradx52
        {
            get { return _misuradx52; }
            set { _misuradx52 = value; }
        }
        private decimal _misuradx42;
        public decimal misuradx42
        {
            get { return _misuradx42; }
            set { _misuradx42 = value; }
        }
        private decimal _misuradx32;
        public decimal misuradx32
        {
            get { return _misuradx32; }
            set { _misuradx32 = value; }
        }
        private decimal _misuradx22;
        public decimal misuradx22
        {
            get { return _misuradx22; }
            set { _misuradx22 = value; }
        }
        private decimal _misuradx12;
        public decimal misuradx12
        {
            get { return _misuradx12; }
            set { _misuradx12 = value; }
        }
        //------------misure parametro 3-----------------------
        private string _misura53;
        public string misura53
        {
            get { return _misura53; }
            set { _misura53 = value; }
        }
        private string _misura33;
        public string misura33
        {
            get { return _misura33; }
            set { _misura33 = value; }
        }
        private string _misura23;
        public string misura23
        {
            get { return _misura23; }
            set { _misura23 = value; }
        }
        private string _misura13;
        public string misura13
        {
            get { return _misura13; }
            set { _misura13 = value; }
        }
        //---------booleano per passare il valore di ps-------------
        private bool _isPsOk;

        public bool isPsOk
        {
            get { return _isPsOk; }
            set { _isPsOk = value; }
        }
	

        //stream per la serializzazione in registrazione dati
        FileStream fs;
        //stream per la serializzazione in caricamento dati
        FileStream rd;

        public CreazioneDatiPaa() { }

        public void registraDati()
        {
            //Apertura classe serializzabile e assegnamento dei dati da serializzare
            DatiPaa dPaa = new DatiPaa();
            dPaa.testoParametro1 = this.testoParametro1;
            dPaa.testoParametro2 = this.testoParametro2;
            dPaa.testoParametro3 = this.testoParametro3;
            //--------misura parametro 1-----------------
            dPaa.misura51 = this.misura51;
            dPaa.misura41 = this.misura41;
            dPaa.misura31 = this.misura31;
            dPaa.misura21 = this.misura21;
            dPaa.misura11 = this.misura11;
            //--------misura parametro 2sx----------------
            dPaa.misurasx52 = this.misurasx52;
            dPaa.misurasx42 = this.misurasx42;
            dPaa.misurasx32 = this.misurasx32;
            dPaa.misurasx22 = this.misurasx22;
            dPaa.misurasx12 = this.misurasx12;
            //--------misura parametro 2dx----------------
            dPaa.misuradx52 = this.misuradx52;
            dPaa.misuradx42 = this.misuradx42;
            dPaa.misuradx32 = this.misuradx32;
            dPaa.misuradx22 = this.misuradx22;
            dPaa.misuradx12 = this.misuradx12;
            //--------misura parametro 3-----------------
            dPaa.misura53 = this.misura53;
            dPaa.misura33 = this.misura33;
            dPaa.misura23 = this.misura23;
            dPaa.misura13 = this.misura13;
            //---------booleano per passare il valore di ps-------------
            dPaa.isPsOk = this.isPsOk;

            try
            {
                using(fs = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataPaa.vin"), FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter bynfor = new BinaryFormatter();
                    bynfor.Serialize(fs, dPaa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il salvataggio dei dati: " + ex.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void caricaDati()
        {
            DatiPaa dPaa2 = new DatiPaa();

            try
            {
                using(rd = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataPaa.vin"), FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bynforead = new BinaryFormatter();

                     dPaa2 = (DatiPaa)bynforead.Deserialize(rd);

                    //assegna i valori alle proprieta'
                     //assegna i valori alle proprieta'
                     //testo parametri
                     this.testoParametro1 = dPaa2.testoParametro1;
                     this.testoParametro2 = dPaa2.testoParametro2;
                     this.testoParametro3 = dPaa2.testoParametro3;
                     //--------misura parametro 1-----------------
                     this.misura51 = dPaa2.misura51;
                     this.misura41 = dPaa2.misura41;
                     this.misura31 = dPaa2.misura31;
                     this.misura21 = dPaa2.misura21;
                     this.misura11 = dPaa2.misura11;
                     //--------misura parametro 2sx----------------
                     this.misurasx52=dPaa2.misurasx52;
                     this.misurasx42=dPaa2.misurasx42;
                     this.misurasx32=dPaa2.misurasx32;
                     this.misurasx22=dPaa2.misurasx22;
                     this.misurasx12=dPaa2.misurasx12;
                     //--------misura parametro 2dx----------------
                     this.misuradx52=dPaa2.misuradx52;
                     this.misuradx42=dPaa2.misuradx42;
                     this.misuradx32 = dPaa2.misuradx32;
                     this.misuradx22 = dPaa2.misuradx22;
                     this.misuradx12 = dPaa2.misuradx12;
                     //--------misura parametro 3-----------------
                     this.misura53 = dPaa2.misura53;
                     this.misura33 = dPaa2.misura33;
                     this.misura23 = dPaa2.misura23;
                     this.misura13 = dPaa2.misura13;
                     //---------booleano per passare il valore di ps-------------
                     this.isPsOk = dPaa2.isPsOk;
                }

            }
            catch (Exception ex2)
            {
                MessageBox.Show("Errore durante il caricamento dei dati della tabella Paa: " + ex2.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Verranno utilizzati i valori di default per la tabella Paa");
                
                //testo parametri
                this.testoParametro1 = "Parametro 1   Importanza dell’area";
                this.testoParametro2 = "Parametro 2   Valore dell'indicatore PS";
                this.testoParametro3 = "Parametro 3   Vg = valutazione globale del ruolo ecologico del sito per la conservazione della specie (vedi schede Natura 2000)";
                //--------misura parametro 1-----------------
                this.misura51 = "Ruolo del sito per la specie = 1 (dato rinvenibile nella scheda relativa alle misure di conservazione del SIC)";
                this.misura41 = "Ruolo del sito per la specie = 2 (dato rinvenibile nella scheda relativa alle misure di conservazione del SIC)";
                this.misura31 = "Ruolo del sito per la specie = 3 (dato rinvenibile nella scheda relativa alle misure di conservazione del SIC)";
                this.misura21 = "Ruolo del sito per la specie = 4 (dato rinvenibile nella scheda relativa alle misure di conservazione del SIC)";
                this.misura11 = "Ruolo del sito = 4, ma l’area interessata dagli interventi gioca un ruolo per la conservazione della specie comparabile a quello di numerose altre aree presenti non solo nel SIC, ma anche sull’intero territorio regionale";
                //--------misura parametro 2sx----------------
                this.misurasx52 = ">=";
                this.misurasx42 = ">=";
                this.misurasx32 = ">=";
                this.misurasx22 = ">=";
                this.misurasx12 = ">=";
                //--------misura parametro 2dx----------------
                this.misuradx52 = (decimal)3.50;
                this.misuradx42 = (decimal)2.50;
                this.misuradx32 = (decimal)2.00;
                this.misuradx22 = (decimal)1.50;
                this.misuradx12 = (decimal)1.00;
                //--------misura parametro 3-----------------
                this.misura53 = "A (oppure specie contrassegnata con priorità alta nelle schede sulle misure di conservazione del SIC)";
                this.misura33 = "B (oppure specie che è contrassegnata con priorità media nelle schede sulle  misure di conservazione del SIC)";
                this.misura23 = "C";
                this.misura13 = "Assente (D)";
                //---------booleano per passare il valore di ps-------------
                this.isPsOk = true;

            }
        }
    }
}
