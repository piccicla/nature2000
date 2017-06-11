
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Sistema_esperto.Serializzazione
{

    class CreazioneDatiEcs
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
        //-----------misure parametro 2------------------------
        private string _misura52;
        public string misura52
        {
            get { return _misura52; }
            set { _misura52 = value; }
        }
        private string _misura42;
        public string misura42
        {
            get { return _misura42; }
            set { _misura42 = value; }
        }
        private string _misura32;
        public string misura32
        {
            get { return _misura32; }
            set { _misura32 = value; }
        }
        private string _misura22;
        public string misura22
        {
            get { return _misura22; }
            set { _misura22 = value; }
        }
        private string _misura12;
        public string misura12
        {
            get { return _misura12; }
            set { _misura12 = value; }
        }
        //------------misure parametro 3-----------------------
        private string _misura53;
        public string misura53
        {
            get { return _misura53; }
            set { _misura53 = value; }
        }
        private string _misura43;
        public string misura43
        {
            get { return _misura43; }
            set { _misura43 = value; }
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
        //---------testi avvertimenti-----
        private string _avvertimento1;
        public string avvertimento1
        {
            get { return _avvertimento1; }
            set { _avvertimento1 = value; }
        }
        private string _avvertimento2;
        public string avvertimento2
        {
            get { return _avvertimento2; }
            set { _avvertimento2 = value; }
        }
        private string _avvertimento3;
        public string avvertimento3
        {
            get { return _avvertimento3; }
            set { _avvertimento3 = value; }
        }
        //stream per la serializzazione in registrazione dati
        FileStream fs;
        //stream per la serializzazione in caricamento dati
        FileStream rd;

        public CreazioneDatiEcs() { }

        public void registraDati()
        {
            //Apertura classe serializzabile e assegnamento dei dati da serializzare
            DatiEcs dq = new DatiEcs();
            //testo parametri
            dq.testoParametro1 = this.testoParametro1;
            dq.testoParametro2 = this.testoParametro2;
            dq.testoParametro3 = this.testoParametro3;
            //--------misura parametro 1-----------------
            dq.misura51 = this.misura51;
            dq.misura41 = this.misura41;
            dq.misura31 = this.misura31;
            dq.misura21 = this.misura21;
            dq.misura11 = this.misura11;
            //--------misura parametro 2-----------------
            dq.misura52 = this.misura52;
            dq.misura42 = this.misura42;
            dq.misura32 = this.misura32;
            dq.misura22 = this.misura22;
            dq.misura12 = this.misura12;
            //--------misura parametro 3-----------------
            dq.misura53 = this.misura53;
            dq.misura43 = this.misura43;
            dq.misura33 = this.misura33;
            dq.misura23 = this.misura23;
            dq.misura13 = this.misura13;
            //--------avvertimenti-------------------------
            dq.avvertimento1 = this.avvertimento1;
            dq.avvertimento2 = this.avvertimento2;
            dq.avvertimento3 = this.avvertimento3;

            try
            {
                using (fs = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataEcs.vin"), FileMode.Create, FileAccess.Write))
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
            DatiEcs dq2 = new DatiEcs();

            try
            {
                using (rd = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataEcs.vin"), FileMode.Open, FileAccess.Read))
                {

                    BinaryFormatter bynforead = new BinaryFormatter();

                    dq2 = (DatiEcs)bynforead.Deserialize(rd);                 

                    //assegna i valori alle proprieta'
                    //testo parametri
                    this.testoParametro1 = dq2.testoParametro1;
                    this.testoParametro2 = dq2.testoParametro2;
                    this.testoParametro3 = dq2.testoParametro3;
                    //--------misura parametro 1-----------------
                    this.misura51 = dq2.misura51;
                    this.misura41 = dq2.misura41;
                    this.misura31 = dq2.misura31;
                    this.misura21 = dq2.misura21;
                    this.misura11 = dq2.misura11;
                    //--------misura parametro 2-----------------
                    this.misura52 = dq2.misura52;
                    this.misura42 = dq2.misura42;
                    this.misura32 = dq2.misura32;
                    this.misura22 = dq2.misura22;
                    this.misura12 = dq2.misura12;
                    //--------misura parametro 3-----------------
                    this.misura53 = dq2.misura53;
                    this.misura43 = dq2.misura43;
                    this.misura33 = dq2.misura33;
                    this.misura23 = dq2.misura23;
                    this.misura13 = dq2.misura13;
                    //--------avvertimenti-------------------------
                    this.avvertimento1 = dq2.avvertimento1;
                    this.avvertimento2 = dq2.avvertimento2;
                    this.avvertimento3 = dq2.avvertimento3;
                }

            }
            catch (Exception ex2)
            {
                MessageBox.Show("Errore durante il caricamento dei dati della tabella Ecs: " + ex2.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Verranno utilizzati i valori di default per la tabella Ecs");
            
                this.testoParametro1 = "Parametro 1" + "\n" + "Il piano/intervento porta le stepping stones o i corridoi "+
                "ecologici ad avere una larghezza residua in metri pari a *";
                this.testoParametro2 = "Parametro 2"+"\n"+"Il piano/intervento porta un’artificializzazione cumulativa del greto o sponde "+
                "di corsi d’acqua interpretabili come corridoi per una percentuale della lunghezza** del corso d’acqua pari a:";
                this.testoParametro3 = "Parametro 3"+"\n"+"Il piano/intervento porta la profondità del buffer ripariale  di corsi d’acqua "+
                "interpretabili come corridoi al di sotto dei 30 metri  per una percentuale della lunghezza** del corso d’acqua pari a:";
                //--------misura parametro 1-----------------
                this.misura51 = "<=500**";
                this.misura41 = "600";
                this.misura31 = "700";
                this.misura21 = "800";
                this.misura11 = "1000";
                //--------misura parametro 2-----------------
                this.misura52 = "40";
                this.misura42 = "25";
                this.misura32 = "20";
                this.misura22 = "15";
                this.misura12 = "<10%";
                //--------misura parametro 3-----------------
                this.misura53 = "25";
                this.misura43 = "20";
                this.misura33 = "15";
                this.misura23 = "10";
                this.misura13 = "<10%";
                //--------avvertimenti-------------------------
                this.avvertimento1 = "* Il dato è espresso in metri lineari (larghezza , se corridoio; diametro medio se stepping stones)";
                this.avvertimento2 = "** La lunghezza del corso d’acqua è misurata come lunghezza del corridoio";
                this.avvertimento3 = "***(oppure interruzione del corridoio per costruzione di nuova strada o altre nuove opere senza efficaci"+
                                      "misure di mitigazione. Consultare la carta regionale delle connessioni ecologiche ";

            }
        }
    }
}
