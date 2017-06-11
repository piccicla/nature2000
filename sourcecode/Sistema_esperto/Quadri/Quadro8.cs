using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema_esperto.Serializzazione;

namespace Sistema_esperto.Quadri
{
    public partial class Quadro8 : Form
    {
        //proprieta' che conserva il testo da trasmettere al form parent
        private String _testo;
        public String testo
        {
            get { return _testo; }
            set { _testo = value; }
        }
        //proprieta' che dice al form parent quale quadro dovra' essere aperto
        private int _valTipo;

        public int valTipo
        {
            get { return _valTipo; }
            set { _valTipo = value; }
        }
	       
        //proprieta' per il valore di ps che arriva dal quadro 6 o per il valore che arriva dalla 
        //tabella per il calcolo di paa nel caso non si sia passati dal quadro 6
        private double _Ps;

        public double Ps
        {
            get { return _Ps; }
            set { _Ps = value; }
        }
        //proprieta' per il valore di Paa da ritornare alla maichild
        private double _Paa;
        public double Paa
        {
            get { return _Paa; }
            set { _Paa = value; }
        }
        //proprieta' per aggiornare il testo della tabella
        //valori per etichette percentuali
        private double _areale1;
        public double areale1
        {
            get { return _areale1; }
            set { _areale1 = value; }
        }
        private double _areale2;
        public double areale2
        {
            get { return _areale2; }
            set { _areale2 = value; }
        }
        private double _areale3;
        public double areale3
        {
            get { return _areale3; }
            set { _areale3 = value; }
        }
        private double _areale4;
        public double areale4
        {
            get { return _areale4; }
            set { _areale4 = value; }
        }
        private double _areale5;
        public double areale5
        {
            get { return _areale5; }
            set { _areale5 = value; }
        }
        private double _areale6;
        public double areale6
        {
            get { return _areale6; }
            set { _areale6 = value; }
        }
        private double _areale7;
        public double areale7
        {
            get { return _areale7; }
            set { _areale7 = value; }
        }
        private double _areale8;
        public double areale8
        {
            get { return _areale8; }
            set { _areale8 = value; }
        }
        //valori per limiti di Paa
        private double _limite1;
        public double limite1
        {
            get { return _limite1; }
            set { _limite1 = value; }
        }
        private double _limite2;
        public double limite2
        {
            get { return _limite2; }
            set { _limite2 = value; }
        }
        private double _limite3;
        public double limite3
        {
            get { return _limite3; }
            set { _limite3 = value; }
        }
        private double _limite4;
        public double limite4
        {
            get { return _limite4; }
            set { _limite4 = value; }
        }
        private double _limite5;
        public double limite5
        {
            get { return _limite5; }
            set { _limite5 = value; }
        }
        private double _limite6;
        public double limite6
        {
            get { return _limite6; }
            set { _limite6 = value; }
        }
        private double _limite7;
        public double limite7
        {
            get { return _limite7; }
            set { _limite7 = value; }
        }
        private double _limite8;
        public double limite8
        {
            get { return _limite8; }
            set { _limite8 = value; }
        }
        //booleano che indica se e' stato calcolato paa
        private bool isPaaOk;
        //booleano che indica se e' stato scelto valore 4 o 5 per il parametro importanza area nel calcolo delo Paa
        private bool _isParam1Ok;
        public bool isParam1Ok
        {
            get { return _isParam1Ok; }
            set { _isParam1Ok = value; }
        }
        
        //booleano che indica se e' stato precedentemente aperto il quadro6 da passare alla tabella calcola paa
        private bool _isQ6Ok;
        public bool isQ6Ok
        {
            get { return _isQ6Ok; }
            set { _isQ6Ok = value; }
        }
        //booleano che indica se dalla tabella e' stata aperta la tabella per il calcolo di Ps( cosa che avviene
        //solamente se non si e' passati dal quadro 6)
        private bool _isPsOk;
        public bool isPsOk
        {
            get { return _isPsOk; }
            set { _isPsOk = value; }
        }
        
        //costruttore senza passaggio del valore di ps( serve solo per il debug)
        public Quadro8()
        {
            InitializeComponent();
            //inizializza le proprieta'
            testo = "";
            valTipo = 0;
            this.Ps = 4;
            this.Paa = 0;
            this.isPaaOk=false;
            this.isParam1Ok=false;
            //assumi che e' stato aperto il quadro 6
            this.isQ6Ok = true;
            //assumi che e' non e'stata aperta la tabella per il calcolo di ps
            this.isPsOk = false;
           
            InitializeComponents2();

         }
        //costruttore con passaggio del valore di ps
        public Quadro8(double newPs,bool isQ6Ok)
        {
            InitializeComponent();
            //inizializza le proprieta'
            testo = "";
            valTipo = 0;
            this.Ps = newPs;
            this.Paa = 0;
            this.isPaaOk=false;
            this.isParam1Ok=false;
            this.isQ6Ok = isQ6Ok;
            this.isPsOk = false;
            
            InitializeComponents2();
        }
        private void InitializeComponents2()
        {
            ////deserializza i file di impostazioni
            CreazioneDatiQ8 crd8 = new CreazioneDatiQ8();
            crd8.caricaDati();

            this.areale1 = crd8.areale1;
            this.areale2 = crd8.areale2;
            this.areale3 = crd8.areale3;
            this.areale4 = crd8.areale4;
            this.areale5 = crd8.areale5;
            this.areale6 = crd8.areale6;
            this.areale7 = crd8.areale7;
            this.areale8 = crd8.areale8;

            this.limite1 = crd8.limite1;
            this.limite2 = crd8.limite2;
            this.limite3 = crd8.limite3;
            this.limite4 = crd8.limite4;
            this.limite5 = crd8.limite5;
            this.limite6 = crd8.limite6;
            this.limite7 = crd8.limite7;

            //scrivi le etichette in base ai dati deserializzati
            this.labelAreale1.Text = crd8.areale1.ToString() + "%";
            this.labelAreale2.Text = crd8.areale2.ToString() + "%";
            this.labelAreale3.Text = crd8.areale3.ToString() + "%";
            this.labelAreale4.Text = crd8.areale4.ToString() + "%";
            this.labelAreale5.Text = crd8.areale5.ToString() + "%";
            this.labelAreale6.Text = crd8.areale6.ToString() + "%";
            this.labelAreale7.Text = crd8.areale7.ToString() + "%";
            this.labelAreale8.Text = crd8.areale8.ToString() + "%";

            this.labelPaa1.Text = "PAA <=" + crd8.limite1.ToString();
            this.labelPaa2.Text = "PAA >" + crd8.limite1.ToString() + " <" + crd8.limite2.ToString();
            this.labelPaa3.Text = "PAA >=" + crd8.limite2.ToString() + " <" + crd8.limite3.ToString();
            this.labelPaa4.Text = "PAA >=" + crd8.limite3.ToString() + " <" + crd8.limite4.ToString();
            this.labelPaa5.Text = "PAA >=" + crd8.limite4.ToString() + " <" + crd8.limite5.ToString();
            this.labelPaa6.Text = "PAA >=" + crd8.limite5.ToString() + " <" + crd8.limite6.ToString();
            this.labelPaa7.Text = "PAA >=" + crd8.limite6.ToString() + " <=" + crd8.limite7.ToString();
            this.labelPaa8.Text = "Valore del parametro \"importanza area\"= 4-5 oppure PAA >" + crd8.limite7.ToString() ;

        }


        //a seconda dell'opzione scelta dall'utente scrivi il testo corrispondente e abilita il tasto per passare alla maschera successiva
        private void radioButtonAreale1_CheckedChanged(object sender, EventArgs e)
        {
            testo = "La perdita ammissibile di areale dell'intera area di occupancy della specie nel SIC e' "+areale1.ToString()+"%";
            if (this.isPaaOk)
            {
                testo = testo + "\n " + "   L'indicatore Paa ha valore " + this.Paa.ToString();
            }
            if (this.isPsOk == true)
            {
                testo = testo + "\n " + "   Il calcolo ha utilizzato l'indicatore Ps con valore " + this.Ps;
            }
            valTipo = 1;
            this.buttonAvanti.Enabled = true;
            this.buttonAvanti.BackColor = Color.Lime;
        }

        private void radioButtonAreale2_CheckedChanged(object sender, EventArgs e)
        {
            testo = "La perdita ammissibile di areale dell'intera area di occupancy della specie nel SIC e' "+areale2.ToString()+ "%";
            if (this.isPaaOk)
            {
                testo = testo + "\n " + "   L'indicatore Paa ha valore " + this.Paa.ToString();
            }
            if (this.isPsOk == true)
            {
                testo = testo + "\n " + "   Il calcolo ha utilizzato l'indicatore Ps con valore " + this.Ps;
            }
            valTipo = 1;
            this.buttonAvanti.Enabled = true;
            this.buttonAvanti.BackColor = Color.Lime;
        }

       
        private void radioButtonAreale3_CheckedChanged(object sender, EventArgs e)
        {
            testo = "La perdita ammissibile di areale dell'intera area di occupancy della specie nel SIC e' "+areale3.ToString()+"%";
            if (this.isPaaOk)
            {
                testo = testo + "\n " + "   L'indicatore Paa ha valore " + this.Paa.ToString();
            }
            if (this.isPsOk == true) {
                testo = testo + "\n " + "   Il calcolo ha utilizzato l'indicatore Ps con valore " + this.Ps;
            }
            valTipo = 1;
            this.buttonAvanti.Enabled = true;
            this.buttonAvanti.BackColor = Color.Lime;
        }

        private void radioButtonAreale4_CheckedChanged(object sender, EventArgs e)
        {
            testo = "La perdita ammissibile di areale dell'intera area di occupancy della specie nel SIC e' "+areale4.ToString()+"%";
            if (this.isPaaOk)
            {
                testo = testo + "\n " + "   L'indicatore Paa ha valore " + this.Paa.ToString();
            }
            if (this.isPsOk == true)
            {
                testo = testo + "\n " + "   Il calcolo ha utilizzato l'indicatore Ps con valore " + this.Ps;
            }
            valTipo = 1;
            this.buttonAvanti.Enabled = true;
            this.buttonAvanti.BackColor = Color.Lime;
        }

        private void radioButtonAreale5_CheckedChanged(object sender, EventArgs e)
        {
            testo = "La perdita ammissibile di areale dell'intera area di occupancy della specie nel SIC e' "+areale5.ToString()+"%";
            if (this.isPaaOk)
            {
                testo = testo + "\n " + "   L'indicatore Paa ha valore " + this.Paa.ToString();
            }
            if (this.isPsOk == true)
            {
                testo = testo + "\n " + "   Il calcolo ha utilizzato l'indicatore Ps con valore " + this.Ps;
            }
            valTipo = 1;
            this.buttonAvanti.Enabled = true;
            this.buttonAvanti.BackColor = Color.Lime;
        }

        private void radioButtonAreale6_CheckedChanged(object sender, EventArgs e)
        {
            testo = "La perdita ammissibile di areale dell'intera area di occupancy della specie nel SIC e' "+areale6.ToString()+"%";
            if (this.isPaaOk)
            {
                testo = testo + "\n " + "   L'indicatore Paa ha valore " + this.Paa.ToString();
            }
            if (this.isPsOk == true)
            {
                testo = testo + "\n " + "   Il calcolo ha utilizzato l'indicatore Ps con valore " + this.Ps;
            }
            valTipo = 1;
            this.buttonAvanti.Enabled = true;
            this.buttonAvanti.BackColor = Color.Lime;
        }

        private void radioButtonAreale7_CheckedChanged(object sender, EventArgs e)
        {
            testo = "La perdita ammissibile di areale dell'intera area di occupancy della specie nel SIC e' "+areale7.ToString()+"%";
            if (this.isPaaOk)
            {
                testo = testo + "\n " + "   L'indicatore Paa ha valore " + this.Paa.ToString();
            }
            if (this.isPsOk == true)
            {
                testo = testo + "\n " + "   Il calcolo ha utilizzato l'indicatore Ps con valore " + this.Ps;
            }
            valTipo = 1;
            this.buttonAvanti.Enabled = true;
            this.buttonAvanti.BackColor = Color.Lime;
        }

        private void radioButtonAreale8_CheckedChanged(object sender, EventArgs e)
        {
            testo = "La perdita ammissibile di areale dell'intera area di occupancy della specie nel SIC e' " + areale8.ToString() + "%";
            if (this.isPaaOk)
            {
                testo = testo + "\n " + "   L'indicatore Paa ha valore " + this.Paa.ToString();
            }
            if (this.isPsOk == true)
            {
                testo = testo + "\n " + "   Il calcolo ha utilizzato l'indicatore Ps con valore " + this.Ps;
            }
            valTipo = 0;
            this.buttonAvanti.Enabled = true;
            this.buttonAvanti.BackColor = Color.Lime;
        }     
        
        private void button1_Click(object sender, EventArgs e)
        {
            CalcolaPaa calcpaa = new CalcolaPaa(this.Ps,this.isQ6Ok);

            calcpaa.ShowDialog();
            if (calcpaa.DialogResult == DialogResult.OK)
            {
                this.labelPaa.Text = "Paa= " + calcpaa.Paa.ToString();
                this.Paa = calcpaa.Paa;
                isPaaOk = true;
                this.isParam1Ok = calcpaa.isParam1Ok;
                //se non si e' passati dal quadro 6 allora vedi se e' stato calcolato il ps nella
                //tabella collegata alla tabella del calcolo del paa
                if (this.isQ6Ok == false) {
                    this.Ps = calcpaa.MaxPs;
                    this.isPsOk = calcpaa.isPsOk;
                
                }
                calcpaa.Dispose();
                // controlla i valori di ps
                checkLimit();
            }
            if (calcpaa.DialogResult == DialogResult.Cancel) {
                calcpaa.Dispose();
            }           
        }

        private void checkLimit()
        {
            //se il parametro importanza ha valore 4 o 5  accendi il bottone 8
            if (this.isParam1Ok)
            {
                radioButtonAreale8.Checked = true;
            }
                // altrimenti accendi il bottone corrispondente al valore di Paa
            else
            {
                if (this.Paa <= this.limite1)
                {
                    radioButtonAreale1.Checked = true;
                }
                else if ((this.Paa > this.limite1) && (this.Paa < this.limite2))
                {
                    radioButtonAreale2.Checked = true;
                }
                else if ((this.Paa >= this.limite2) && (this.Paa < this.limite3))
                {
                    radioButtonAreale3.Checked = true;
                }
                else if ((this.Paa >= this.limite3) && (this.Paa < this.limite4))
                {
                    radioButtonAreale4.Checked = true;
                }
                else if ((this.Paa >= this.limite4) && (this.Paa < this.limite5))
                {
                    radioButtonAreale5.Checked = true;
                }
                else if ((this.Paa >= this.limite5) && (this.Paa < this.limite6))
                {
                    radioButtonAreale6.Checked = true;
                }
                else if ((this.Paa >= this.limite6) && (this.Paa <= this.limite7))
                {
                    radioButtonAreale7.Checked = true;
                }
                else if (this.Paa > this.limite7)
                {
                    radioButtonAreale8.Checked = true;
                }
            }
            
        }

    }
}