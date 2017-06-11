using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Sistema_esperto.Serializzazione
{

    class CreazioneDatiEi
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
        private string _testoParametro2Info;
        public string testoParametro2Info
        {
            get { return _testoParametro2Info; }
            set { _testoParametro2Info = value; }
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

        //stream per la serializzazione in registrazione dati
        FileStream fs;
        //stream per la serializzazione in caricamento dati
        FileStream rd;

        public CreazioneDatiEi() { }

        public void registraDati()
        {
            //Apertura classe serializzabile e assegnamento dei dati da serializzare
            DatiEi dq = new DatiEi();
            //testo parametri
            dq.testoParametro1 = this.testoParametro1;
            dq.testoParametro2 = this.testoParametro2;
            dq.testoParametro3 = this.testoParametro3;
            dq.testoParametro2Info= this.testoParametro2Info;
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

            try
            {
                using(fs = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataEi.vin"), FileMode.Create, FileAccess.Write))
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
            DatiEi dq2 = new DatiEi();

            try
            {
                using (rd = new FileStream(Path.Combine(Application.StartupPath,@"dati/dataEi.vin"), FileMode.Open, FileAccess.Read))
                {


                    BinaryFormatter bynforead = new BinaryFormatter();

                    dq2 = (DatiEi)bynforead.Deserialize(rd);
                

                    //assegna i valori alle proprieta'
                    //testo parametri
                    this.testoParametro1 = dq2.testoParametro1;
                    this.testoParametro2 = dq2.testoParametro2;
                    this.testoParametro3 = dq2.testoParametro3;
                    this.testoParametro2Info = dq2.testoParametro2Info;
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

                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Errore durante il caricamento dei dati della tabella Ei: " + ex2.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Verranno utilizzati i valori di default per la tabella Ei");
                this.testoParametro1 = "Parametro 1" + "\n" + "Aumento indotto (prevedibile a seguito dell’intervento) del traffico motorizzato " +
                "in aree sensibili del SIC (aree riproduttive; aree focali ecc.). I dati sono espressi come % del traffico stimato prima " +
                "del piano/intervento oggetto della valutazione";

                this.testoParametro2 = "Parametro 2" + "\n" + "Diminuzione prevedibile provocata dall’intervento (direttamente o per via cumulativa)  nel livello idrico o peggiormento della qualità delle acque, dell’aria, del suolo in aree focali del SIC o in elementi della Rete ecologica." + "\n" +
                "Caso 1: si verifica una delle cinque situazioni qui sotto contrassegnate con le lettere a-b-c-d-e. L’intervento provoca (direttamente o per via cumulativa) presumibilmente* a) una carenza idrica nei corsi o nelle raccolte d’acqua d’acqua tale da determinare frequentemente (es.: 2 anni su 5) una diminuzione del successo riproduttivo di specie di interesse comunitario legate all’acqua  ; b)  il superamento per uno o più parametri delle soglie stabilite  per acque a Salmonidi o a Ciprinidi previste dalla direttiva 2006/44 CE; c) uno slittamento di classe nei valori L.I.M. preesistenti (tab. 7 dell’allegato 1 del D.legs 258/2000) oppure uno slittamento di classe IBE; d) un peggioramento della qualità dell’aria rilevabile con l’indice lichenico o con indici di efficienza fotosintetica o con analisi dei parametri chimici utilizzati nelle normative vigenti; e) un peggioramento della qualità dei suoli rilevabile con l’indice QBSar." + "\n" +
                "Caso 2: si verifica una delle due situazioni qui sotto contrassegnate con le lettere a-b. L’intervento provoca presumibilmente* a) una carenza idrica nei corsi o nelle raccolte d’acqua d’acqua tale da determinare saltuariamente (es.: 1 anno su 5) una diminuzione del successo riproduttivo di specie di interesse comunitario legate all’acqua ; b)  il raggiungimento per 3 o più parametri delle soglie stabilite  per acque a Salmonidi o a Ciprinidi nella tab. 7 dell’allegato 1 del  nella direttiva 2006/44 CE;" + "\n" +
                "Caso 3. si verifica quando l’intervento (anche per via cumulativa)  provoca presumibilmente* il raggiungimento per 1-2 parametri delle soglie stabilite  per acque a Salmonidi o a Ciprinidi nella tab. 7 dell’allegato 1 del  nella direttiva 2006/44 CE;" + "\n" +
                "Caso 4. Si verifica quando l’intervento non influisce sulla qualità dell’acqua, dell’aria o del suolo.";

                this.testoParametro2Info = "(*) \"presumibilmente\" significa che (tenuto conto dei parametri ambientali rilevati precedentemente all’intervento ; tenuto conto del consumo d’acqua e/o delle emissioni derivanti dall’opera in esercizio) appare altamente probabile il verificarsi di una fra le situazioni delineate per i casi  1-2-3";                             
                
                this.testoParametro3 = "Parametro 3 \nEffetto edge (margine). Distanza in metri dell’intervento (o da aspetti indotti dall’intervento, " +
                "come la costruzione di nuove strade o l’allargamento delle preesistenti) dai confini del SIC (se l’intervento è esterno al SIC) ; oppure " +
                "dai confini di aree interpretabili come corridoi o  stepping stones  (per interventi esterni o interni al SIC)";
                //--------misura parametro 1-----------------
                this.misura51 = "+20%";
                this.misura41 = "+15%";
                this.misura31 = "+10%";
                this.misura21 = "+5%";
                this.misura11 = "0";
                //--------misura parametro 2-----------------
                this.misura52 = "caso 1";
                this.misura42 = "caso 2";
                this.misura32 = "caso 3";
                this.misura22 = "----";
                this.misura12 = "caso 4";
                //--------misura parametro 3-----------------
                this.misura53 = "<=300";
                this.misura43 = "400";
                this.misura33 = "500";
                this.misura23 = "1000";
                this.misura13 = "2000";

            }
        }
    }
}
