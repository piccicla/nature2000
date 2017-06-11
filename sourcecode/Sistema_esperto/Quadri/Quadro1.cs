using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema_esperto;
using Sistema_esperto.Serializzazione;
using System.Diagnostics;

namespace Sistema_esperto.Quadri
{
    public partial class Quadro1 : Form
    {
        //proprieta' che contiene il primo valore limite di hotspot
        private double _Qs1;
        public double Qs1
        {
            get { return _Qs1; }
            set { _Qs1 = value; }
        }      
        //contatore che registra il numero di specie conformi al primo valore di hotspot
        private int contQs1 = 0;
        //limite numero di specie conformi al primo valore di hotspot      
        private int _numQs1;
        public int numQs1
        {
            get { return _numQs1; }
            set { _numQs1 = value; }
        }	
        //proprieta' che contiene il secondo valore limite di hotspot
        private double _Qs2;
        public double Qs2
        {
            get { return _Qs2; }
            set { _Qs2 = value; }
        }
        //contatore che registra il numero di specie conformi al primo valore di hotspot
        private int contQs2 = 0;
        //limite numero di specie conformi al secondo valore di hotspot
        private int _numQs2;
        public int numQs2
        {
            get { return _numQs2; }
            set { _numQs2 = value; }
        }
        //valore booleano che specifica se usare solo il valore superiore di qs
        private bool _sup;
        public bool sup
        {
            get { return _sup; }
            set { _sup = value; }
        }
        //raggio per la ricerca delle specie attorno all'area d'intervento
        private int _raggio;
        public int raggio
        {
            get { return _raggio; }
            set { _raggio = value; }
        }
        //proprieta' che registra il testo contenuto nella listaNomi e serv
        private string _lista;
        public string listaQ1
        {
            get { return _lista; }
            set { _lista = value; }
        }
        //booleano per visibilita' calcolo manuale del qs
        private bool _qsOk;
        public bool qsOk
        {
            get { return _qsOk; }
            set { _qsOk = value; }
        }

        //public Quadro1(double newQs1, int newnumQs1, double newQs2, int newnumQs2, bool newsup, int newraggio)
        public Quadro1()
        {
            //assegna i valori limiti per gli hotspot 
            //leggendo i dati contenuti nel file serializzato
            CreazioneDatiQ1 crd = new CreazioneDatiQ1();
            crd.caricaDati();

            this.Qs1 = crd.Qs1;
            this.numQs1 = crd.numQs1;
            this.Qs2 = crd.Qs2;
            this.numQs2 = crd.numQs2;
            this.sup = crd.sup;
            this.raggio = crd.raggio;
            this.qsOk = crd.qsOk;
            /*//inizializza i valori delle proprieta'
            Qs1 = newQs1;
            numQs1 = newnumQs1;
            Qs2 = newQs2;
            numQs2 = newnumQs2;
            sup = newsup;
            raggio = newraggio;*/

            this.listaQ1 = "";

            //inizializza il layout della maschera
            InitializeComponent();
            
            //se qsok e' falso allora disabilita la scelta manuale dei valori di qs
            if (this.qsOk == false)
            {
                this.groupBoxQsPersonale.Visible = false;
            }
            //scrivi testo della textbox
            this.textBoxSpiegaQs.Text = "I valori di QuS sono riportati, per la maggior parte delle specie, nel database regionale NaturaLi";
            // se se qsok  e' vero aggiungi del testo al textbox per avvertire del pulsante per il calcolo manuale
            if (this.qsOk == true)
            {
                this.textBoxSpiegaQs.Text = this.textBoxSpiegaQs.Text + " oppure calcolabili manualmente (premi il pulsante 'Aiuto per il calcolo del Qus')";
            }
            this.textBoxValori.Text = "(*) una situazione di hot spot si configura quando" +
            " all’interno dell'area occupata dall'intervento esiste una zona circolare " +
            " avente un raggio di " + raggio.ToString() + " mt, in cui sono presenti, anche come diffusione potenziale "
            + numQs1.ToString() + " specie con valore QuS > " + Qs1.ToString();
            if (sup == false)
            {
                this.textBoxValori.Text = this.textBoxValori.Text + " oppure " + numQs2.ToString() + " specie con valore QuS > " + Qs2.ToString();
            }

            ///////////////
            
        }
        private void Quadro1_Shown(object sender, EventArgs e)
        {
            //quando si apre la finestra avviene il collegamento al database per permettere all'utente
            //di scegliere la specie e il relativo valore di qs
            try
            {                
                this.specieTableAdapter1.Fill(this.specieDataSet1.specie);
            }
            catch (Exception err)
            {
                MessageBox.Show("Errore di collegamento al database :"+err.ToString(), "Errore di collegamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }     
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            //quando l'utente preme il bottone la specie viene aggiunta alla lista
            this.listBoxNomi.Items.Add(this.comboBoxNomi.Text + "\tQs= "+this.textBoxQs.Text);
            //viene aggiunto il valore di qs in una lista nascosta
            this.listBoxQsHidden.Items.Add(this.textBoxQs.Text);
            //controlla il valore di qs ed eventualmente aggiorna i contatori
            if (double.Parse(this.textBoxQs.Text) > Qs1)
            {
                contQs1 += 1;
            }
            if (double.Parse(this.textBoxQs.Text) > Qs2)
            {
                contQs2 += 1;
            }
            //varia lo stato del bottone "SI" in base ai valori dei limiti di hotspot
            if (checkLimits())
            {
                this.buttonSi.Enabled = true;
                this.buttonSi.BackColor = Color.Lime;
                this.buttonNo.Enabled = false;
                this.buttonNo.BackColor = Color.White;
            }
            //aggiorna la variabile lista
            aggiornaLista(this.listBoxNomi);
        }
        private void buttonAggiungi2_Click(object sender, EventArgs e)
        {
            this.listBoxNomi.Items.Add(this.textBoxNomi.Text + "\tQs= " + this.numericUpDownQs.Text);
            //viene aggiunto il valore di qs in una lista nascosta
            this.listBoxQsHidden.Items.Add(this.numericUpDownQs.Text);
            //controlla il valore di qs ed eventualmente aggiorna i contatori
            if (double.Parse(this.numericUpDownQs.Text) > Qs1)
            {
                contQs1 += 1;
            }
            if (double.Parse(this.numericUpDownQs.Text) > Qs2)
            {
                contQs2 += 1;
            }
            //varia lo stato del bottone "SI" in base ai valori dei limiti di hotspot
            if (checkLimits())
            {
                this.buttonSi.Enabled = true;
                this.buttonSi.BackColor = Color.Lime;
                this.buttonNo.Enabled = false;
                this.buttonNo.BackColor = Color.White;
            }
            //aggiorna la variabile lista
            aggiornaLista(this.listBoxNomi);

        }

        // metodo che controlla la condizione di hotspot in base ai limiti
        private bool checkLimits()
        {
            //se i contatori superano i valori di 
            if (contQs1 >= numQs1) {
                this.labelAvvertimento.Text = "CI SONO " + numQs1.ToString() + " SPECIE CON Qs >" + Qs1.ToString();  
                return true;
            }
            //il superamento del secondo valore e' segnalato solo se le impostazione conservata nella variabile sup e' falsa
            if (sup == false)
            {
                if (contQs2 >= numQs2)
                {
                    this.labelAvvertimento.Text = "CI SONO " + numQs2.ToString() + " SPECIE CON Qs >" + Qs2.ToString();
                    return true;
                }
            }
                this.labelAvvertimento.Text = "";              
                return false;
            }

        private void listBoxNomi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //quando l'utente seleziona un oggetto dalla lista si attiva il bottone per cancellarlo
            this.buttonCancella.Enabled = true;
            this.buttonCancella.BackColor = Color.PeachPuff;
        }

        private void buttonCancella_Click(object sender, EventArgs e)
        {
            //variabile che conserva l'indice della selezione dalla lista
            int a = this.listBoxNomi.SelectedIndex;
            //quando l'utente preme il pulsante la specie viene eliminata dalla lista
            this.listBoxNomi.Items.RemoveAt(a);
            //controlla il valore della selezione corrispondente nella lista nascosta
            //ed eventualmente aggiorna i valori dei contatori
            if ( double.Parse(this.listBoxQsHidden.Items[a].ToString())> Qs1)
            {
                contQs1 -= 1;
            }
            if (double.Parse(this.listBoxQsHidden.Items[a].ToString()) > Qs2)
            {
                contQs2 -= 1;
            }
            //varia lo stato del bottone "SI" in base ai valori dei limiti di hotspot
            if (checkLimits()==false)
            {
                this.buttonSi.Enabled = false;
                this.buttonSi.BackColor = Color.White;
                this.buttonNo.Enabled = true;
                this.buttonNo.BackColor = Color.Lime;
            }
            //viene eliminato anche il corrispettivo valore presente nella lista nascosta
            this.listBoxQsHidden.Items.RemoveAt(a);
            //viene disattivato il pulsante per cancellare gli oggetti
            this.buttonCancella.Enabled = false;
            this.buttonCancella.BackColor = Color.LightGray;
            //annulla valore variabile che conserva l'indice della selezione dalla lista
            a = -1;
            //aggiorna la variabile lista
            aggiornaLista(this.listBoxNomi);
        }
        
        //metodo che aggiorna la proprieta' lista con i dati contenuti nella listboxNomi
        private void aggiornaLista(ListBox listBox) {

            listaQ1 = "";
            foreach (string str in listBox.Items)
            {
                listaQ1 =listaQ1 + "\n   " + str;
            }
            //MessageBox.Show(lista);
        }

        private void buttonAiutoQs_Click(object sender, EventArgs e)
        {
            AiutoQs aiutoQs = new AiutoQs();
            aiutoQs.ShowDialog();
            if (aiutoQs.DialogResult == DialogResult.OK) {
                this.numericUpDownQs.Value = (decimal)aiutoQs.Qs;
                aiutoQs.Dispose();
            }
            if (aiutoQs.DialogResult == DialogResult.Cancel)
            {
                aiutoQs.Dispose();
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            try
            {
                string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
                Process.Start(iePath, Application.StartupPath + @"\help\quadri\quadro1.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
                    
        }


    }

}  


