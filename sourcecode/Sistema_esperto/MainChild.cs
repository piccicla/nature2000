using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema_esperto.Quadri;
using System.IO;
using System.Drawing.Printing;
using System.Diagnostics;

namespace Sistema_esperto
{
    public partial class MainChild : Form
    {
        //classe per l'output del file di testo
        private StreamWriter sw;
        private StreamReader sr;
        //variabile per il conteggio dei passagi
        private int counter = 1;
        //vriabili per la stampa
        //carattere di stampa
        private Font printFont;
        //righe da stampare
        private int righe = 0;
        //documento da stampare
        PrintDocument pd;
        //numero di pagina
        private int numPag = 0;
        // valore di ps da prelevare dal quadro 6 e passare al costruttore del quadro 8
        private double _Ps;
        public double Ps
        {
            get { return _Ps; }
            set { _Ps = value; }
        }
        private bool _isQuadro6;

        public bool isQuadro6
        {
            get { return _isQuadro6; }
            set { _isQuadro6 = value; }
        }
	
        /*//proprieta'da passare al costruttore del quadro1        
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
        }*/
	


        public MainChild()
        {
            InitializeComponent();

            this.Ps = 0;
            this.isQuadro6 = false;
            /*//assegna i valori limiti per gli hotspot da passare al quadro1
            //leggi i dati contenuti nel file serializzato
            CreazioneDati crd = new CreazioneDati();
            crd.caricaDati();

            Qs1 = crd.Qs1;
            numQs1 = crd.numQs1;
            Qs2 = crd.Qs2;
            numQs2 = crd.numQs2;
            sup = crd.sup;
            raggio = crd.raggio;*/
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
            this.richTextBox1.Text = this.richTextBox1.Text + "\nInizio valutazione " + DateTime.Now.ToString();
            open1();
        }

        private void open1()
        {
            //inizializza il valore di ps per la nuova valutazione
            this.Ps = 0;
            //inizializza il valore di isQuadro6 per la nuova valutazione
            this.isQuadro6 = false;
            //inizia la valutazione aprendo il primo quadro (passo false perche' voglio i pulsanti si e no della maschera abilitati)
            Quadro1 quadro1 = new Quadro1();
            //Quadro1 quadro1 = new Quadro1(Qs1, numQs1, Qs2, numQs2, sup, raggio);
            //abilita il pulsante di salvataggio del testo di valutazione
            this.toolStripButton1.Enabled = true;

            //mostra il quadro in maniera modale 
            quadro1.ShowDialog();
            if (quadro1.DialogResult == DialogResult.Yes)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "L'area in cui e' progettato l'intervento si configura come hotspot di biodiversita' regionale";
                //ottieni la lista delle specie considerate    
                if (quadro1.listaQ1 != "")
                {
                    this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + "   Le specie considerate per l'analisi sono:";
                    this.richTextBox1.Text = this.richTextBox1.Text + quadro1.listaQ1;
                }
                quadro1.Dispose();
                counter += 1;
                this.richTextBox1.ScrollToCaret();
                open10();
            }
            else if (quadro1.DialogResult == DialogResult.No)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "L'area in cui e' progettato l'intervento non si configura come hotspot di biodiversita' regionale";
                if (quadro1.listaQ1 != "")
                {
                    this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + "   Le specie considerate per l'analisi sono:";
                    //ottieni la lista delle specie considerate           
                    this.richTextBox1.Text = this.richTextBox1.Text + quadro1.listaQ1;
                }
                quadro1.Dispose();
                counter += 1;
                this.richTextBox1.ScrollToCaret();
                open2();
            }
            else if (quadro1.DialogResult == DialogResult.Cancel)
            {
                quadro1.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nValutazione interrotta dall'utente " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }        
        private void open2()
        {
            Quadro2 quadro2 = new Quadro2();
            quadro2.ShowDialog();
            if (quadro2.DialogResult == DialogResult.Yes)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "L'area in cui e' progettato l'intervento rappresenta un'area focale per specie costituenti obiettivo \ndi conservazione del sito";
                quadro2.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open4();
            }
            else if (quadro2.DialogResult == DialogResult.No)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "L'area in cui e' progettato l'intervento non rappresenta un'area focale per specie costituenti obiettivo \ndi conservazione del sito";
                quadro2.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open3();
            }
            else if (quadro2.DialogResult == DialogResult.Cancel)
            {
                quadro2.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nValutazione interrotta dall'utente " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        private void open3()
        {
            Quadro3 quadro3 = new Quadro3();
            quadro3.ShowDialog();
            if (quadro3.DialogResult == DialogResult.Yes)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "L'intervento, qualora fosse localizzato al di fuori del sito o in aree matrice del sito, puo' influire \nsu specie presenti in aree focali distanti";
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + "   I valori degli indicatori Ei e Ecs sono:";
                this.richTextBox1.Text = this.richTextBox1.Text + "\n" + "   Ei  =" + quadro3.Ei.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n" + "   Ecs =" + quadro3.Ecs.ToString();
                
                quadro3.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                
                //////////QUI MODIFICA PER INSERIRE IL QUADRO 3BIS
                //open8();
                open3Bis();
            }
            else if (quadro3.DialogResult == DialogResult.No)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "L'intervento, qualora fosse localizzato al di fuori del sito o in aree matrice del sito, non influisce \nsu specie presenti in aree focali distanti";
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + "   I valori degli indicatori Ei e Ecs sono:";
                this.richTextBox1.Text = this.richTextBox1.Text + "\n" + "   Ei  =" + quadro3.Ei.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n" + "   Ecs =" + quadro3.Ecs.ToString();

                quadro3.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                openValPos();
            }
            else if (quadro3.DialogResult == DialogResult.Cancel)
            {
                quadro3.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nValutazione interrotta dall'utente " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        private void open3Bis()
        {
            Quadro3Bis quadro3Bis = new Quadro3Bis();
            quadro3Bis.ShowDialog();
            if (quadro3Bis.DialogResult == DialogResult.Yes)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "L’intervento provoca, direttamente o per via cumulativa, problemi di carenza idrica o di inquinamento \ndell' acqua, dell’aria o del suolo";
                quadro3Bis.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open9();
            }
            else if (quadro3Bis.DialogResult == DialogResult.No)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "L’intervento non provoca, direttamente o per via cumulativa, problemi di carenza idrica o di inquinamento \ndell' acqua, dell’aria o del suolo";
                quadro3Bis.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open8();
            }
            else if (quadro3Bis.DialogResult == DialogResult.Cancel)
            {
                quadro3Bis.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nValutazione interrotta dall'utente " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        
        private void open4()
        {
            Quadro4 quadro4 = new Quadro4();
            quadro4.ShowDialog();
            if (quadro4.DialogResult == DialogResult.Yes)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "L'intervento puo' ridurre il territorio trofico o riproduttivo o indispensabile per altri aspetti \ndella biologia della specie o puo' interferire con la sua fisiologia, ecologia o etologia";
                quadro4.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open6();
            }
            else if (quadro4.DialogResult == DialogResult.No)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "L'intervento non riduce il territorio trofico o riproduttivo o indispensabile per altri aspetti \ndella biologia della specie e non interferisce con la sua fisiologia, ecologia o etologia";
                quadro4.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open5();
            }
            else if (quadro4.DialogResult == DialogResult.Cancel)
            {
                quadro4.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nValutazione interrotta dall'utente " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        private void open5()
        {
            Quadro5 quadro5 = new Quadro5();
            quadro5.ShowDialog();
            if (quadro5.DialogResult == DialogResult.Yes)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "La specie interessata dall'intervento e' una specie minacciata a livello Regionale";
                quadro5.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                openValPos2();
            }
            else if (quadro5.DialogResult == DialogResult.No)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "La specie interessata dall'intervento non e' una specie minacciata a livello Regionale";
                quadro5.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                openValPos();
            }
            else if (quadro5.DialogResult == DialogResult.Cancel)
            {
                quadro5.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nValutazione interrotta dall'utente " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        private void open6()
        {
            //registra che e' stato aperto il quadro6 per settare il quadro 8
            this.isQuadro6 = true;
            Quadro6 quadro6 = new Quadro6();
            quadro6.ShowDialog();
            if (quadro6.DialogResult == DialogResult.Yes)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "Viene intaccata possibilita' di permanenza della specie nel paesaggio ecologico di sua pertinenza";
                
                //se e' stata aperta la tabella per il calcolo di ps
                if (quadro6.isPsOk)
                {
                    //registra il valore massimo di ps
                    this.Ps = quadro6.MaxPs;
                   
                    this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + "   Il valore massimo dell' indicatore Ps e':";
                    this.richTextBox1.Text = this.richTextBox1.Text + "\n" + "   Ps  =" + quadro6.Ps.ToString();
                }

                quadro6.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open9();
            }
            else if (quadro6.DialogResult == DialogResult.No)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "Non viene intaccata possibilita' di permanenza della specie nel paesaggio ecologico di sua pertinenza";
                //se e' stata aperta la tabella per il calcolo di ps
                if (quadro6.isPsOk)
                {
                    //registra il valore massimo di ps
                    this.Ps = quadro6.MaxPs;                   
                    this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + "   Il valore massimo dell' indicatore Ps e':";
                    this.richTextBox1.Text = this.richTextBox1.Text + "\n" + "   Ps  =" + quadro6.Ps.ToString();
                }
                quadro6.Dispose();
                counter += 1;
                this.richTextBox1.ScrollToCaret();
                open7();
            }
            else if (quadro6.DialogResult == DialogResult.Cancel)
            {
                quadro6.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nValutazione interrotta dall'utente " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        private void open7()
        {
            Quadro7 quadro7 = new Quadro7();
            quadro7.ShowDialog();
            if (quadro7.DialogResult == DialogResult.Yes)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "Si verificano effetti cumulativi non sostenibili";

                quadro7.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open9();
            }
            else if (quadro7.DialogResult == DialogResult.No)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "Non Si verificano effetti cumulativi non sostenibili";
                quadro7.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open8();
            }
            else if (quadro7.DialogResult == DialogResult.Cancel)
            {
                quadro7.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nValutazione interrotta dall'utente " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        private void open8()
        {
            Quadro8 quadro8 = new Quadro8(this.Ps,this.isQuadro6);
            quadro8.ShowDialog();
            if (quadro8.DialogResult == DialogResult.Yes)
            {
                //preleva il testo dal quadro 8
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n"+ counter.ToString()+") "+ quadro8.testo;
                //preleva l'informazione per decidere quale quadro aprire
                if (quadro8.valTipo == 0)
                {
                    quadro8.Dispose();
                    this.richTextBox1.ScrollToCaret();
                    counter += 1;
                    openValNeg();
                }
                if (quadro8.valTipo == 1)
                {
                    quadro8.Dispose();
                    this.richTextBox1.ScrollToCaret();
                    counter += 1;
                    openValPos3();
                }
            }

             if (quadro8.DialogResult == DialogResult.Cancel)
            {
                quadro8.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nValutazione interrotta dall'utente " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
             }
        }
        private void open9()
        {
            Quadro9 quadro9 = new Quadro9();
            quadro9.ShowDialog();
            if (quadro9.DialogResult == DialogResult.Yes)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "E' possibile introdurre mitigazioni per azzerare l'incidenza";
                quadro9.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open2();
            }
            else if (quadro9.DialogResult == DialogResult.No)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "Non e' possibile introdurre mitigazioni per azzerare l'incidenza";
                quadro9.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open10();
            }
            else if (quadro9.DialogResult == DialogResult.Cancel)
            {
                quadro9.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nValutazione interrotta dall'utente " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        private void open10()
        {
            Quadro10 quadro10 = new Quadro10();
            quadro10.ShowDialog();
            if (quadro10.DialogResult == DialogResult.Yes)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "Sono possibili soluzioni o localizzazioni  alternative in grado di superare la situazione incidente";
                quadro10.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                open1();
            }
            else if (quadro10.DialogResult == DialogResult.No)
            {
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\n" + counter.ToString() + ") " + "Non sono possibili soluzioni o localizzazioni  alternative in grado di superare la situazione incidente";
                quadro10.Dispose();
                this.richTextBox1.ScrollToCaret();
                counter += 1;
                openValNeg2();
            }
            else if (quadro10.DialogResult == DialogResult.Cancel)
            {
                quadro10.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nValutazione interrotta dall'utente " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }

        private void openValPos()
        {
            ValutazionePositiva valPos = new ValutazionePositiva();
            this.richTextBox1.Text = this.richTextBox1.Text + "\n\nVALUTAZIONE POSITIVA";
            valPos.ShowDialog();
            if (valPos.DialogResult == DialogResult.Cancel)
            {
                valPos.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nFine valutazione " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        private void openValPos2()
        {
            ValutazionePositiva2 valPos2 = new ValutazionePositiva2();
            this.richTextBox1.Text = this.richTextBox1.Text + "\n\nVALUTAZIONE POSITIVA \ncon opere di mitigazione ed interventi aggiuntivi in grado di aumentare le misure \ndi conservazione gia' previste";
            valPos2.ShowDialog();
            if (valPos2.DialogResult == DialogResult.Cancel)
            {
                valPos2.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nFine valutazione " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        private void openValPos3()
        {
            ValutazionePositiva3 valPos3 = new ValutazionePositiva3();
            this.richTextBox1.Text = this.richTextBox1.Text + "\n\nVALUTAZIONE POSITIVA a condizione che PS rimanga <3.9 dopo la sottrazione di areale \nQualora la perturbazione coinvolga specie con Vus >4.5 oppure  con status IUCN regionale EN-CR sono \nnecessarie misure di mitigazione e la realizzazione di  interventi aggiuntivi in grado di aumentare \nl'efficienza delle misure di conservazione gia' previste";
            valPos3.ShowDialog();
            if (valPos3.DialogResult == DialogResult.Cancel)
            {
                valPos3.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nFine valutazione " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        private void openValNeg()
        {
            ValutazioneNegativa valNeg = new ValutazioneNegativa();
            this.richTextBox1.Text = this.richTextBox1.Text + "\n\nVALUTAZIONE NEGATIVA \nse ritenuto possibile, invocare le deroghe previste dall'art.6 par.4 della direttiva habitat, \nattuare gli interventi di compensazione ed informare la Commissione Europea";
            valNeg.ShowDialog();
            if (valNeg.DialogResult == DialogResult.Cancel)
            {
                valNeg.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nFine valutazione " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }
        private void openValNeg2()
        {
            ValutazioneNegativa2 valNeg2 = new ValutazioneNegativa2();
            this.richTextBox1.Text = this.richTextBox1.Text + "\n\nVALUTAZIONE NEGATIVA \nse ritenuto possibile, invocare le deroghe previste dall'art.6 par.4 della direttiva habitat, \nattuare gli interventi di compensazione ed informare la Commissione Europea";
            valNeg2.ShowDialog();
            if (valNeg2.DialogResult == DialogResult.Cancel)
            {
                valNeg2.Dispose();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n\nFine valutazione " + DateTime.Now.ToString();
                this.richTextBox1.Text = this.richTextBox1.Text + "\n--------------------------------------------------";
                counter = 1;
                this.richTextBox1.ScrollToCaret();
            }
        }

 

        //metodo per il salvataggio del testo di valutazione
        public void salva()
        {
            //apri un filedialog
             SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //imposta il file in formato ritchtextformat 
             saveFileDialog.Filter = "Testo di valutazione(*.tvz)|*.tvz";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try{
                    //preleva il nome del file inserito dall'utente 
                    string fileName = saveFileDialog.FileName;
                    //apri lo stream
                    using(sw = new StreamWriter(fileName)){
                    //aggiungi il testo di valutazione
                    sw.Write(this.richTextBox1.Text);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Errore nella creazione del file: " + e.ToString());
                }
                
            }
           }
        
        public void apri() 
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Testo di valutazione (*.tvz)|*.tvz";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog.FileName;
                    // TODO: Add code here to open the file.
                    using(sr = new StreamReader(fileName)){

                    //controlla se c'e' del testo gia' presente
                    if (this.richTextBox1.Text != "")
                    {
                        //chiedi all'utente se vuole cancellare il testo gia' presente o mantenerlo
                        DialogResult dl = MessageBox.Show("Vuoi aggiungerlo al testo gia' presente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dl == DialogResult.Yes)
                        {
                            this.richTextBox1.Text += sr.ReadToEnd();
                            this.richTextBox1.ScrollToCaret();
                        }
                        if (dl == DialogResult.No)
                        {
                            cancella();
                            this.richTextBox1.Text = sr.ReadToEnd();
                            this.richTextBox1.ScrollToCaret();
                        }
                    }                 
                    else
                    {
                        this.richTextBox1.Text = sr.ReadToEnd();
                    }
                    //abilita il pulsante di salvataggio del testo di valutazione
                    this.toolStripButton1.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nella lettura del file: " + ex.ToString());
                }
            
            }
        }
        
        
        public void cancella() {
            DialogResult dl=MessageBox.Show("Vuoi salvare il testo prima di cancellarlo?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dl == DialogResult.Yes) {
                salva();
            }
            if (dl == DialogResult.No)
            {
                this.richTextBox1.Text = "";
            }
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {              
            //salva il testo di valutazione
            salva();        
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {            
            apri();
        }      

        private void toolStripButton6_CheckStateChanged(object sender, EventArgs e)
        {
            //abilita il pulsante di salvataggio nel caso sia disabilitato
            this.toolStripButton1.Enabled = true;
            //cambio la proprieta' readonly del testo a seconda dello stato del bottone
            if (this.toolStripButton6.CheckState == CheckState.Checked)
            {
                this.richTextBox1.ReadOnly = false;
            }
            if (this.toolStripButton6.CheckState == CheckState.Unchecked)
            {
                this.richTextBox1.ReadOnly = true;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            cancella();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            numPag = 1;

            try
            {
                printFont = new Font("Arial", 10);
                pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                PrintDialog printDialog1 = new PrintDialog();
                printDialog1.Document = pd;
                pd.DocumentName = "Valutazione d'incidenza";
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    righe = 0;
                    pd.Print();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float rightMargin = ev.MarginBounds.Right;

            float topMargin = ev.MarginBounds.Top;

            //MessageBox.Show("OK");
            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < (linesPerPage-2) && (this.righe < this.richTextBox1.Lines.Length))
            //while (count < linesPerPage-2 &&((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(this.richTextBox1.Lines[this.righe], printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                righe++;
                count++;
                //MessageBox.Show(righe.ToString());
            }
            //stampa il numero di pagina
            yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString("", printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            count++;
            yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString("Pagina " + numPag, printFont, Brushes.Black, rightMargin, yPos, new StringFormat());
            numPag++;
            // If more lines exist, print another page.
            if (this.righe < this.richTextBox1.Lines.Length)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
        private void ButtonMisureConserv_Click(object sender, EventArgs e)
        {
            MisureConservazione miscons = new MisureConservazione();
            miscons.ShowDialog();
            if (miscons.DialogResult == DialogResult.Cancel)
            {
                miscons.Dispose();
            }

        }

        private void ButtonPs_Click(object sender, EventArgs e)
        {
            CalcolaPs calcps = new CalcolaPs();
            calcps.ShowDialog();
            if (calcps.DialogResult == DialogResult.Cancel)
            {
                calcps.Dispose();
            }
            if (calcps.DialogResult == DialogResult.OK)
            { 
                calcps.Dispose(); 
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            CalcolaEcs calcecs = new CalcolaEcs();
            calcecs.ShowDialog();
            if (calcecs.DialogResult == DialogResult.Cancel)
            {
                calcecs.Dispose();
            }
            if (calcecs.DialogResult == DialogResult.OK)
            {
                calcecs.Dispose();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CalcolaEi cei = new CalcolaEi();
            cei.ShowDialog();
            if (cei.DialogResult == DialogResult.Cancel)
            {
                cei.Dispose();
            }
            if (cei.DialogResult == DialogResult.OK) {
                cei.Dispose();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            CalcolaPaa calcpaa = new CalcolaPaa(1, false);
            calcpaa.ShowDialog();
            if (calcpaa.DialogResult == DialogResult.Cancel)
            {
                calcpaa.Dispose();
            }
            if (calcpaa.DialogResult == DialogResult.OK)
            {
                calcpaa.Dispose();
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
            try
            {
                using (Process myProcess = new Process())
                {
                    //prendi il nome del file e aprilo
                    myProcess.StartInfo.FileName = Application.StartupPath + @"\help\pannellovalutazione\pannello di valutazione.html";
                    myProcess.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }       
    }
}