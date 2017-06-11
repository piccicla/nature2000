using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Sistema_esperto.Serializzazione
{
    class CreazioneDatiPs
    {
        //proprieta' da serializzare
        //TABELLA PARAMETRO1
        //testo parametri
        private string _testoParametro11;
        public string testoParametro11
        {
            get { return _testoParametro11; }
            set { _testoParametro11 = value; }
        }
        private string _testoParametro21;
        public string testoParametro21
        {
            get { return _testoParametro21; }
            set { _testoParametro21 = value; }
        }
        private string _testoParametro31;
        public string testoParametro31
        {
            get { return _testoParametro31; }
            set { _testoParametro31 = value; }
        }
        //testi misure
        //--------misura caso 1------------------------
        private string _misura51Ps1;
        public string misura51Ps1
        {
            get { return _misura51Ps1; }
            set { _misura51Ps1 = value; }
        }
        private string _misura41Ps1;
        public string misura41Ps1
        {
            get { return _misura41Ps1; }
            set { _misura41Ps1 = value; }
        }
        private string _misura31Ps1;
        public string misura31Ps1
        {
            get { return _misura31Ps1; }
            set { _misura31Ps1 = value; }
        }
        private string _misura21Ps1;
        public string misura21Ps1
        {
            get { return _misura21Ps1; }
            set { _misura21Ps1 = value; }
        }
        private string _misura11Ps1;
        public string misura11Ps1
        {
            get { return _misura11Ps1; }
            set { _misura11Ps1 = value; }
        }
        //-----------misure caso 2------------------------
        private string _misura52Ps1;
        public string misura52Ps1
        {
            get { return _misura52Ps1; }
            set { _misura52Ps1 = value; }
        }
        private string _misura42Ps1;
        public string misura42Ps1
        {
            get { return _misura42Ps1; }
            set { _misura42Ps1 = value; }
        }
        private string _misura32Ps1;
        public string misura32Ps1
        {
            get { return _misura32Ps1; }
            set { _misura32Ps1 = value; }
        }
        private string _misura22Ps1;
        public string misura22Ps1
        {
            get { return _misura22Ps1; }
            set { _misura22Ps1 = value; }
        }
        private string _misura12Ps1;
        public string misura12Ps1
        {
            get { return _misura12Ps1; }
            set { _misura12Ps1 = value; }
        }
        //------------misure caso 3-----------------------
        private string _misura53Ps1;
        public string misura53Ps1
        {
            get { return _misura53Ps1; }
            set { _misura53Ps1 = value; }
        }
        private string _misura43Ps1;
        public string misura43Ps1
        {
            get { return _misura43Ps1; }
            set { _misura43Ps1 = value; }
        }
        private string _misura33Ps1;
        public string misura33Ps1
        {
            get { return _misura33Ps1; }
            set { _misura33Ps1 = value; }
        }
        private string _misura23Ps1;
        public string misura23Ps1
        {
            get { return _misura23Ps1; }
            set { _misura23Ps1 = value; }
        }
        private string _misura13Ps1;
        public string misura13Ps1
        {
            get { return _misura13Ps1; }
            set { _misura13Ps1 = value; }
        }
        //TABELLA PARAMETRO2
        //testo parametri
        private string _testoParametro12;
        public string testoParametro12
        {
            get { return _testoParametro12; }
            set { _testoParametro12 = value; }
        }
        private string _testoParametro22;
        public string testoParametro22
        {
            get { return _testoParametro22; }
            set { _testoParametro22 = value; }
        }
        private string _testoParametro32;
        public string testoParametro32
        {
            get { return _testoParametro32; }
            set { _testoParametro32 = value; }
        }
        //testi misure
        //--------misura caso 1------------------------
        private string _misura51Ps2;
        public string misura51Ps2
        {
            get { return _misura51Ps2; }
            set { _misura51Ps2 = value; }
        }
        private string _misura41Ps2;
        public string misura41Ps2
        {
            get { return _misura41Ps2; }
            set { _misura41Ps2 = value; }
        }
        private string _misura31Ps2;
        public string misura31Ps2
        {
            get { return _misura31Ps2; }
            set { _misura31Ps2 = value; }
        }
        private string _misura21Ps2;
        public string misura21Ps2
        {
            get { return _misura21Ps2; }
            set { _misura21Ps2 = value; }
        }
        private string _misura11Ps2;
        public string misura11Ps2
        {
            get { return _misura11Ps2; }
            set { _misura11Ps2 = value; }
        }
        //-----------misure caso 2------------------------
        private string _misura52Ps2;
        public string misura52Ps2
        {
            get { return _misura52Ps2; }
            set { _misura52Ps2 = value; }
        }
        private string _misura42Ps2;
        public string misura42Ps2
        {
            get { return _misura42Ps2; }
            set { _misura42Ps2 = value; }
        }
        private string _misura32Ps2;
        public string misura32Ps2
        {
            get { return _misura32Ps2; }
            set { _misura32Ps2 = value; }
        }
        private string _misura22Ps2;
        public string misura22Ps2
        {
            get { return _misura22Ps2; }
            set { _misura22Ps2 = value; }
        }
        private string _misura12Ps2;
        public string misura12Ps2
        {
            get { return _misura12Ps2; }
            set { _misura12Ps2 = value; }
        }
        //------------misure caso 3-----------------------
        private string _misura53Ps2;
        public string misura53Ps2
        {
            get { return _misura53Ps2; }
            set { _misura53Ps2 = value; }
        }
        private string _misura43Ps2;
        public string misura43Ps2
        {
            get { return _misura43Ps2; }
            set { _misura43Ps2 = value; }
        }
        private string _misura33Ps2;
        public string misura33Ps2
        {
            get { return _misura33Ps2; }
            set { _misura33Ps2 = value; }
        }
        private string _misura23Ps2;
        public string misura23Ps2
        {
            get { return _misura23Ps2; }
            set { _misura23Ps2 = value; }
        }
        private string _misura13Ps2;
        public string misura13Ps2
        {
            get { return _misura13Ps2; }
            set { _misura13Ps2 = value; }
        }
        //TABELLA PARAMETRO3
        //testo parametri
        private string _testoParametro13;
        public string testoParametro13
        {
            get { return _testoParametro13; }
            set { _testoParametro13 = value; }
        }

        //testi misure
        //--------misura caso 1------------------------
        private string _misura51Ps3;
        public string misura51Ps3
        {
            get { return _misura51Ps3; }
            set { _misura51Ps3 = value; }
        }
        private string _misura41Ps3;
        public string misura41Ps3
        {
            get { return _misura41Ps3; }
            set { _misura41Ps3 = value; }
        }
        private string _misura31Ps3;
        public string misura31Ps3
        {
            get { return _misura31Ps3; }
            set { _misura31Ps3 = value; }
        }
        private string _misura21Ps3;
        public string misura21Ps3
        {
            get { return _misura21Ps3; }
            set { _misura21Ps3 = value; }
        }
        private string _misura11Ps3;
        public string misura11Ps3
        {
            get { return _misura11Ps3; }
            set { _misura11Ps3 = value; }
        }
        //stream per la serializzazione in registrazione dati
        FileStream fs;
        //stream per la serializzazione in caricamento dati
        FileStream rd;

        public CreazioneDatiPs() { }

        public void registraDati()
        {
            //Apertura classe serializzabile e assegnamento dei dati da serializzare
            DatiPs dPs = new DatiPs();
            //TABELLA 1
            dPs.testoParametro11 = this.testoParametro11;
            dPs.testoParametro21 = this.testoParametro21;
            dPs.testoParametro31 = this.testoParametro31;
            //--------misura caso 1-----------------
            dPs.misura51Ps1 = this.misura51Ps1;
            dPs.misura41Ps1 = this.misura41Ps1;
            dPs.misura31Ps1 = this.misura31Ps1;
            dPs.misura21Ps1 = this.misura21Ps1;
            dPs.misura11Ps1 = this.misura11Ps1;
            //--------misura caso 2-----------------
            dPs.misura52Ps1 = this.misura52Ps1;
            dPs.misura42Ps1 = this.misura42Ps1;
            dPs.misura32Ps1 = this.misura32Ps1;
            dPs.misura22Ps1 = this.misura22Ps1;
            dPs.misura12Ps1 = this.misura12Ps1;
            //--------misura caso 3-----------------
            dPs.misura53Ps1 = this.misura53Ps1;
            dPs.misura43Ps1 = this.misura43Ps1;
            dPs.misura33Ps1 = this.misura33Ps1;
            dPs.misura23Ps1 = this.misura23Ps1;
            dPs.misura13Ps1 = this.misura13Ps1;
            //TABELLA 2
            dPs.testoParametro12 = this.testoParametro12;
            dPs.testoParametro22 = this.testoParametro22;
            dPs.testoParametro32 = this.testoParametro32;
            //--------misura caso 1-----------------
            dPs.misura51Ps2 = this.misura51Ps2;
            dPs.misura41Ps2 = this.misura41Ps2;
            dPs.misura31Ps2 = this.misura31Ps2;
            dPs.misura21Ps2 = this.misura21Ps2;
            dPs.misura11Ps2 = this.misura11Ps2;
            //--------misura caso 2-----------------
            dPs.misura52Ps2 = this.misura52Ps2;
            dPs.misura42Ps2 = this.misura42Ps2;
            dPs.misura32Ps2 = this.misura32Ps2;
            dPs.misura22Ps2 = this.misura22Ps2;
            dPs.misura12Ps2 = this.misura12Ps2;
            //--------misura caso 3-----------------
            dPs.misura53Ps2 = this.misura53Ps2;
            dPs.misura43Ps2 = this.misura43Ps2;
            dPs.misura33Ps2 = this.misura33Ps2;
            dPs.misura23Ps2 = this.misura23Ps2;
            dPs.misura13Ps2 = this.misura13Ps2;
            //TABELLA 3
            dPs.testoParametro13 = this.testoParametro13;
            //--------misura caso 1-----------------
            dPs.misura51Ps3 = this.misura51Ps3;
            dPs.misura41Ps3 = this.misura41Ps3;
            dPs.misura31Ps3 = this.misura31Ps3;
            dPs.misura21Ps3 = this.misura21Ps3;
            dPs.misura11Ps3 = this.misura11Ps3;
            try
            {
                using (fs = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataPs.vin"), FileMode.Create, FileAccess.Write))
                {

                    BinaryFormatter bynfor = new BinaryFormatter();
                    bynfor.Serialize(fs, dPs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il salvataggio dei dati: " + ex.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void caricaDati()
        {
            DatiPs dPs2 = new DatiPs();

            try
            {
                using (rd = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataPs.vin"), FileMode.Open, FileAccess.Read))
                {

                    BinaryFormatter bynforead = new BinaryFormatter();

                    dPs2 = (DatiPs)bynforead.Deserialize(rd);

                    //assegna i valori alle proprieta'
                    //assegna i valori alle proprieta'
                    //TABELLA 1
                    this.testoParametro11 = dPs2.testoParametro11;
                    this.testoParametro21 = dPs2.testoParametro21;
                    this.testoParametro31 = dPs2.testoParametro31;
                    //--------misura caso 1-----------------
                    this.misura51Ps1 = dPs2.misura51Ps1;
                    this.misura41Ps1 = dPs2.misura41Ps1;
                    this.misura31Ps1 = dPs2.misura31Ps1;
                    this.misura21Ps1 = dPs2.misura21Ps1;
                    this.misura11Ps1 = dPs2.misura11Ps1;
                    //--------misura caso 2-----------------
                    this.misura52Ps1 = dPs2.misura52Ps1;
                    this.misura42Ps1 = dPs2.misura42Ps1;
                    this.misura32Ps1 = dPs2.misura32Ps1;
                    this.misura22Ps1 = dPs2.misura22Ps1;
                    this.misura12Ps1 = dPs2.misura12Ps1;
                    //--------misura caso 3-----------------
                    this.misura53Ps1 = dPs2.misura53Ps1;
                    this.misura43Ps1 = dPs2.misura43Ps1;
                    this.misura33Ps1 = dPs2.misura33Ps1;
                    this.misura23Ps1 = dPs2.misura23Ps1;
                    this.misura13Ps1 = dPs2.misura13Ps1;
                    //TABELLA 2
                    this.testoParametro12 = dPs2.testoParametro12;
                    this.testoParametro22 = dPs2.testoParametro22;
                    this.testoParametro32 = dPs2.testoParametro32;
                    //--------misura caso 1-----------------
                    this.misura51Ps2 = dPs2.misura51Ps2;
                    this.misura41Ps2 = dPs2.misura41Ps2;
                    this.misura31Ps2 = dPs2.misura31Ps2;
                    this.misura21Ps2 = dPs2.misura21Ps2;
                    this.misura11Ps2 = dPs2.misura11Ps2;
                    //--------misura caso 2-----------------
                    this.misura52Ps2 = dPs2.misura52Ps2;
                    this.misura42Ps2 = dPs2.misura42Ps2;
                    this.misura32Ps2 = dPs2.misura32Ps2;
                    this.misura22Ps2 = dPs2.misura22Ps2;
                    this.misura12Ps2 = dPs2.misura12Ps2;
                    //--------misura caso 3-----------------
                    this.misura53Ps2 = dPs2.misura53Ps2;
                    this.misura43Ps2 = dPs2.misura43Ps2;
                    this.misura33Ps2 = dPs2.misura33Ps2;
                    this.misura23Ps2 = dPs2.misura23Ps2;
                    this.misura13Ps2 = dPs2.misura13Ps2;
                    //TABELLA 3
                    this.testoParametro13 = dPs2.testoParametro13;
                    //--------misura caso 1-----------------
                    this.misura51Ps3 = dPs2.misura51Ps3;
                    this.misura41Ps3 = dPs2.misura41Ps3;
                    this.misura31Ps3 = dPs2.misura31Ps3;
                    this.misura21Ps3 = dPs2.misura21Ps3;
                    this.misura11Ps3 = dPs2.misura11Ps3;
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Errore durante il caricamento dei dati della tabella Ps: " + ex2.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Verranno utilizzati i valori di default per la tabella Ps");
                //TABELLA 1

                this.testoParametro11 = "Caso relativo alle specie target terrrestri: il territorio complessivo " +
                "di idoneità ecologica per la specie target presenta un numero di ampie aree non frammentate* di superficie pari " +
                "a : *dimensione indicative delle aree: 55 ettari per mammiferi, uccelli e rettili; 1 ettaro per gli insetti e per " +
                "specie di margine. La superficie dell’area di idoneità ecologica per le specie di margine viene calcolata come superficie " +
                "della striscia ecotonale che comprenda porzioni idonee dei due diversi comparti ecologici frequentati dalla specie. " +
                "Le dimensioni della aree sono calcolabili dalla carta degli habitat e dalla carta delle connessioni ecologiche";
                this.testoParametro21 = "Caso relativo alle specie target legate a corsi d’acqua (inclusa Rana italica): " +
                "la profondità del buffer ripariale (arbustivo o boschivo) di corsi d’acqua ospitanti specie target è, per il 75% " +
                "della lunghezza del torrente*, è pari a metri:  * la lunghezza del torrente è misurata solo per il tratto presente " +
                "nel SIC a cui si aggiungono i tratti della rete ecologica eventualmente connessi.  La profondità del buffer ripariale " +
                "è stimabile attraverso la Carta regionale della connettività ecologica";
                this.testoParametro31 = "Caso relativo agli Anfibi (esclusa Rana italica): " +
                "Il territorio di in cui sono presenti specie target colpite dall’intervento presenta un numero di siti riproduttivi* ogni 100 ettari pari a: " +
                "*il numero di siti può essere stimato dalla carta bio-naturalistica (aree fauna minore e stazioni di presenza) e va comunque controllato con ricerche sul campo";
                //--------misura caso 1-----------------
                this.misura51Ps1 = "0";
                this.misura41Ps1 = "1";
                this.misura31Ps1 = "2";
                this.misura21Ps1 = "3";
                this.misura11Ps1 = ">=4";
                //--------misura caso 2-----------------
                this.misura52Ps1 = "<15";
                this.misura42Ps1 = "15";
                this.misura32Ps1 = "30";
                this.misura22Ps1 = "60";
                this.misura12Ps1 = "100";
                //--------misura caso 3-----------------
                this.misura53Ps1 = "<=4";
                this.misura43Ps1 = "6";
                this.misura33Ps1 = "8";
                this.misura23Ps1 = "15";
                this.misura13Ps1 = "25";
                //TABELLA 2
                this.testoParametro12 = "Percentuale di habitat idoneo rispetto alla superficie del SIC relativamente a uccelli, " +
                "mammiferi, rettili, anfibi (per gli anfibi, ai fini del calcolo di questo parametro, si intende come habitat idoneo " +
                "quello trofico e/o i boschi idonei alla fase terrestre)";
                this.testoParametro22 = "Insetti e specie di margine*" +
                "*per le specie di margine valgono le stesse considerazioni espresse per il parametro 1";
                this.testoParametro32 = "Specie legate ai corsi d’acqua (compreso Rana italica) " +
                "L’habitat è idoneo solo se possiede un buffer di 30 metri in entrambe le rive. " +
                "La superficie viene calcolata pertanto sulla strisca di torrente idoneo profonda 60 metri";
                //--------misura caso 1-----------------
                this.misura51Ps2 = "<=1";
                this.misura41Ps2 = "5";
                this.misura31Ps2 = "10";
                this.misura21Ps2 = "20";
                this.misura11Ps2 = ">=20";
                //--------misura caso 2-----------------
                this.misura52Ps2 = "1";
                this.misura42Ps2 = "2";
                this.misura32Ps2 = "3";
                this.misura22Ps2 = "4";
                this.misura12Ps2 = ">5";
                //--------misura caso 3-----------------
                this.misura53Ps2 = "1";
                this.misura43Ps2 = "1.5";
                this.misura33Ps2 = "2";
                this.misura23Ps2 = "2.5";
                this.misura13Ps2 = "3";
                //TABELLA 3
                this.testoParametro13 = "Numero di corridoi e stepping stones funzionali fra le  macchie occupate " +
                "dalla specie (per gli anfibi, fra siti riproduttivi) ; i corridoi, per essere funzionali, devono avere una profondità>100 m ; " +
                "le stepping stones,  un diametro > 100 m";
                //--------misura caso 1-----------------
                this.misura51Ps3 = "0";
                this.misura41Ps3 = "1";
                this.misura31Ps3 = "2";
                this.misura21Ps3 = "3";
                this.misura11Ps3 = ">=4";

            }
        }
    }
}
