using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema_esperto.Serializzazione;
using Sistema_esperto.Quadri;
using System.Diagnostics;

namespace Sistema_esperto
{
    public partial class IMPOSTAZIONI : Form
    {
        //proprieta' che registra se e' avvenuta una modifica delle impostazioni 
        private bool _newImp;
        public bool newImp
        {
            get { return _newImp; }
            set { _newImp = value; }
        }
	
        public IMPOSTAZIONI()
        {
            InitializeComponent();
            newImp = false;
        }

      
        private void IMPOSTAZIONI_Load(object sender, EventArgs e)
        {
            
            //INIZIALIZZAZIONE IMPOSTAZIONI QUADRO1
            CreazioneDatiQ1 crd = new CreazioneDatiQ1();
            crd.caricaDati();

            this.numericUpDownQs1.Value = (decimal)crd.Qs1;
            this.numericUpDownnumQs1.Value = (decimal)crd.numQs1;
            this.numericUpDownQs2.Value = (decimal)crd.Qs2;
            this.numericUpDownnumQs2.Value = (decimal)crd.numQs2;
            if (crd.qsOk == true)
            {
                this.checkBoxAbilitaQsManu.Checked = true;
            }
            else
            {
                this.checkBoxAbilitaQsManu.Checked = false;
            }
            if (crd.sup == true) { 
                this.checkBoxSupQs.Checked = true;
            }
            else{
                this.checkBoxSupQs.Checked = false;
            }
            this.numericUpDownRaggio.Value = crd.raggio;

            //hook per il cambio di valore del quadro1(li ho messi qui perche' non funzionava il cambio del numericupdownnumQs1
            this.numericUpDownnumQs1.ValueChanged += new System.EventHandler(this.numericUpDownnumQs1_ValueChanged);
            this.numericUpDownQs2.ValueChanged += new System.EventHandler(this.numericUpDownQs2_ValueChanged);
            this.numericUpDownQs1.ValueChanged += new System.EventHandler(this.numericUpDownQs1_ValueChanged);
            this.numericUpDownnumQs2.ValueChanged += new System.EventHandler(this.numericUpDownnumQs2_ValueChanged);

            //INIZIALIZZAZIONE IMPOSTAZIONI QUADRO3
            CreazioneDatiQ3 crd3 = new CreazioneDatiQ3();
            crd3.caricaDati();

            this.numericUpDownEi.Value = (decimal)crd3.limiteEi;
            this.numericUpDownEcs.Value = (decimal)crd3.limiteEcs;
            if (crd3.varOR == true)
            {
                radioButtonQ3OR.Checked = true;
            }
            else {
                radioButtonQ3AND.Checked = true;
            }

            //INIZIALIZZAZIONE IMPOSTAZIONI TABELLA PER IL CALCOLO DI Ei
            //ottieni dati serializzati per riempire la tabella
            CreazioneDatiEi crdEi = new CreazioneDatiEi();
            crdEi.caricaDati();
            //assegna dati ai componenti della tabella
            //testo parametri
            this.textBoxParametro1Ei.Text = crdEi.testoParametro1;
            this.textBoxParametro2Ei.Text = crdEi.testoParametro2;
            this.textBoxParametro3Ei.Text = crdEi.testoParametro3;
            this.textBoxParametro2EiInfo.Text = crdEi.testoParametro2Info;
            //--------misura parametro 1-----------------
            this.misura51Ei.Text = crdEi.misura51;
            this.misura41Ei.Text = crdEi.misura41;
            this.misura31Ei.Text = crdEi.misura31;
            this.misura21Ei.Text = crdEi.misura21;
            this.misura11Ei.Text = crdEi.misura11;
            //--------misura parametro 2-----------------
            this.misura52Ei.Text = crdEi.misura52;
            this.misura42Ei.Text = crdEi.misura42;
            this.misura32Ei.Text = crdEi.misura32;
            this.misura22Ei.Text = crdEi.misura22;
            this.misura12Ei.Text = crdEi.misura12;
            //--------misura parametro 3-----------------
            this.misura53Ei.Text = crdEi.misura53;
            this.misura43Ei.Text = crdEi.misura43;
            this.misura33Ei.Text = crdEi.misura33;
            this.misura23Ei.Text = crdEi.misura23;
            this.misura13Ei.Text = crdEi.misura13;
            
            //INIZIALIZZAZIONE IMPOSTAZIONI TABELLA PER IL CALCOLO DI ECS
            //ottieni dati serializzati per riempire la tabella
            CreazioneDatiEcs crdEcs = new CreazioneDatiEcs();
            crdEcs.caricaDati();
            //assegna dati ai componenti della tabella
            //testo parametri
            this.textBoxParametro1Ecs.Text = crdEcs.testoParametro1;
            this.textBoxParametro2Ecs.Text = crdEcs.testoParametro2;
            this.textBoxParametro3Ecs.Text = crdEcs.testoParametro3;
            //--------misura parametro 1-----------------
            this.misura51Ecs.Text = crdEcs.misura51;
            this.misura41Ecs.Text = crdEcs.misura41;
            this.misura31Ecs.Text = crdEcs.misura31;
            this.misura21Ecs.Text = crdEcs.misura21;
            this.misura11Ecs.Text = crdEcs.misura11;
            //--------misura parametro 2-----------------
            this.misura52Ecs.Text = crdEcs.misura52;
            this.misura42Ecs.Text = crdEcs.misura42;
            this.misura32Ecs.Text = crdEcs.misura32;
            this.misura22Ecs.Text = crdEcs.misura22;
            this.misura12Ecs.Text = crdEcs.misura12;
            //--------misura parametro 3-----------------
            this.misura53Ecs.Text = crdEcs.misura53;
            this.misura43Ecs.Text = crdEcs.misura43;
            this.misura33Ecs.Text = crdEcs.misura33;
            this.misura23Ecs.Text = crdEcs.misura23;
            this.misura13Ecs.Text = crdEcs.misura13;
            //---------avvertimenti----------------------
            this.textBoxAvvertimento1Ecs.Text = crdEcs.avvertimento1;
            this.textBoxAvvertimento2Ecs.Text = crdEcs.avvertimento2;
            this.textBoxAvvertimento3Ecs.Text = crdEcs.avvertimento3;
            
            //INIZIALIZZAZIONE IMPOSTAZIONI TABELLA PER IL CALCOLO DI PS
            //ottieni dati serializzati per riempire la tabella
            CreazioneDatiPs crdPs = new CreazioneDatiPs();
            crdPs.caricaDati();
            //assegna dati ai componenti della tabella
            //testo parametri
            //TABELLA 1
            this.textBoxParametro11Ps.Text = crdPs.testoParametro11;
            this.textBoxParametro21Ps.Text = crdPs.testoParametro21;
            this.textBoxParametro31Ps.Text = crdPs.testoParametro31;
            //--------misura caso 1-----------------
            this.misura51Ps1.Text = crdPs.misura51Ps1;
            this.misura41Ps1.Text = crdPs.misura41Ps1;
            this.misura31Ps1.Text = crdPs.misura31Ps1;
            this.misura21Ps1.Text = crdPs.misura21Ps1;
            this.misura11Ps1.Text = crdPs.misura11Ps1;
            //--------misura caso 2-----------------
            this.misura52Ps1.Text = crdPs.misura52Ps1;
            this.misura42Ps1.Text = crdPs.misura42Ps1;
            this.misura32Ps1.Text = crdPs.misura32Ps1;
            this.misura22Ps1.Text = crdPs.misura22Ps1;
            this.misura12Ps1.Text = crdPs.misura12Ps1;
            //--------misura caso 3-----------------
            this.misura53Ps1.Text = crdPs.misura53Ps1;
            this.misura43Ps1.Text = crdPs.misura43Ps1;
            this.misura33Ps1.Text = crdPs.misura33Ps1;
            this.misura23Ps1.Text = crdPs.misura23Ps1;
            this.misura13Ps1.Text = crdPs.misura13Ps1;
            //TABELLA 2
            this.textBoxParametro12Ps.Text = crdPs.testoParametro12;
            this.textBoxParametro22Ps.Text = crdPs.testoParametro22;
            this.textBoxParametro32Ps.Text = crdPs.testoParametro32;
            //--------misura caso 1-----------------
            this.misura51Ps2.Text = crdPs.misura51Ps2;
            this.misura41Ps2.Text = crdPs.misura41Ps2;
            this.misura31Ps2.Text = crdPs.misura31Ps2;
            this.misura21Ps2.Text = crdPs.misura21Ps2;
            this.misura11Ps2.Text = crdPs.misura11Ps2;
            //--------misura caso 2-----------------
            this.misura52Ps2.Text = crdPs.misura52Ps2;
            this.misura42Ps2.Text = crdPs.misura42Ps2;
            this.misura32Ps2.Text = crdPs.misura32Ps2;
            this.misura22Ps2.Text = crdPs.misura22Ps2;
            this.misura12Ps2.Text = crdPs.misura12Ps2;
            //--------misura caso 3-----------------
            this.misura53Ps2.Text = crdPs.misura53Ps2;
            this.misura43Ps2.Text = crdPs.misura43Ps2;
            this.misura33Ps2.Text = crdPs.misura33Ps2;
            this.misura23Ps2.Text = crdPs.misura23Ps2;
            this.misura13Ps2.Text = crdPs.misura13Ps2;
            //TABELLA 3
            this.textBoxParametro13Ps.Text = crdPs.testoParametro13;
            //--------misura caso 1-----------------
            this.misura51Ps3.Text = crdPs.misura51Ps3;
            this.misura41Ps3.Text = crdPs.misura41Ps3;
            this.misura31Ps3.Text = crdPs.misura31Ps3;
            this.misura21Ps3.Text = crdPs.misura21Ps3;
            this.misura11Ps3.Text = crdPs.misura11Ps3;
           
            //INIZIALIZZAZIONE IMPOSTAZIONI QUADRO 6
            //ottieni dati serializzati per riempire la tabella
            CreazioneDatiQ6 crdQ6 = new CreazioneDatiQ6();
            crdQ6.caricaDati();
            //assegna dati ai componenti 
            this.numericUpDownPs.Text = crdQ6.limitePs.ToString();

            //INIZIALIZZAZIONE IMPOSTAZIONI QUADRO7
            CreazioneDatiQ7 crdQ7 = new CreazioneDatiQ7();
            crdQ7.caricaDati();

            this.numericUpDownEcumNoRedList.Value = (decimal)crdQ7.limiteEcumNoRedList;
            this.numericUpDownEcumRedList.Value = (decimal)crdQ7.limiteEcumRedList;

            //INIZIALIZZAZIONE IMPOSTAZIONI QUADRO7
            
            //INIZIALIZZAZIONE IMPOSTAZIONI TABELLA PER IL CALCOLO DI Paa
            //ottieni dati serializzati per riempire la tabella
            CreazioneDatiPaa crdPaa = new CreazioneDatiPaa();
            crdPaa.caricaDati();
            //assegna dati ai componenti della tabella
            //testo parametri
            this.textBoxParametro1Paa.Text = crdPaa.testoParametro1;
            this.textBoxParametro2Paa.Text = crdPaa.testoParametro2;
            this.textBoxParametro3Paa.Text = crdPaa.testoParametro3;
            //--------misura parametro 1-----------------
            this.misura51Paa.Text = crdPaa.misura51;
            this.misura41Paa.Text = crdPaa.misura41;
            this.misura31Paa.Text = crdPaa.misura31;
            this.misura21Paa.Text = crdPaa.misura21;
            this.misura11Paa.Text = crdPaa.misura11;
            //--------misura parametro 2sx-----------------
            this.misurasx52Paa.Text = crdPaa.misurasx52;
            this.misurasx42Paa.Text = crdPaa.misurasx42;
            this.misurasx32Paa.Text = crdPaa.misurasx32;
            this.misurasx22Paa.Text = crdPaa.misurasx22;
            this.misurasx12Paa.Text = crdPaa.misurasx12;
            //--------misura parametro 2dx-----------------
            this.misuradx52Paa.Value = crdPaa.misuradx52;
            this.misuradx42Paa.Value = crdPaa.misuradx42;
            this.misuradx32Paa.Value = crdPaa.misuradx32;
            this.misuradx22Paa.Value = crdPaa.misuradx22;
            this.misuradx12Paa.Value = crdPaa.misuradx12;
            //--------misura parametro 3-----------------
            this.misura53Paa.Text = crdPaa.misura53;
            this.misura33Paa.Text = crdPaa.misura33;
            this.misura23Paa.Text = crdPaa.misura23;
            this.misura13Paa.Text = crdPaa.misura13;
            //---passaggio valore di Ps-----------
            if (crdPaa.isPsOk == true)
            {
                this.checkBoxPaa.Checked = true;
            }
            else {
                this.checkBoxPaa.Checked = false;
            }
            
            //INIZIALIZZAZIONE IMPOSTAZIONI QUADRO 8
            //ottieni dati serializzati per riempire la tabella
            CreazioneDatiQ8 crdQ8 = new CreazioneDatiQ8();
            crdQ8.caricaDati();
            //assegna dati ai componenti della tabella
            //valori limiti
            this.LimitiPaa1.Value =(decimal) crdQ8.limite1;
            this.LimitiPaa2.Value = (decimal)crdQ8.limite2;
            this.LimitiPaa3.Value = (decimal)crdQ8.limite3;
            this.LimitiPaa4.Value = (decimal)crdQ8.limite4;
            this.LimitiPaa5.Value = (decimal)crdQ8.limite5;
            this.LimitiPaa6.Value = (decimal)crdQ8.limite6;
            this.LimitiPaa7.Value = (decimal)crdQ8.limite7;

            this.LimitePercPaa1.Value = (decimal)crdQ8.areale1;
            this.LimitePercPaa2.Value = (decimal)crdQ8.areale2;
            this.LimitePercPaa3.Value = (decimal)crdQ8.areale3;
            this.LimitePercPaa4.Value = (decimal)crdQ8.areale4;
            this.LimitePercPaa5.Value = (decimal)crdQ8.areale5;
            this.LimitePercPaa6.Value = (decimal)crdQ8.areale6;
            this.LimitePercPaa7.Value = (decimal)crdQ8.areale7;
            this.LimitePercPaa8.Value = (decimal)crdQ8.areale8;
         }
        
        private void buttonRegistraQ1_Click(object sender, EventArgs e)
        {
            //serializza i dati       
            CreazioneDatiQ1 crd = new CreazioneDatiQ1();
            //assegna i dati da serializzare
            crd.Qs1 = (double)this.numericUpDownQs1.Value;
            crd.numQs1 = (int)this.numericUpDownnumQs1.Value;
            crd.Qs2 = (double)this.numericUpDownQs2.Value;
            crd.numQs2 = (int)this.numericUpDownnumQs2.Value;
            if (this.checkBoxAbilitaQsManu.Checked == true)
            {
                crd.qsOk = true;
            }
            else
            {
                crd.qsOk = false;
            }
      
            if (this.checkBoxSupQs.Checked == true)
            {
                crd.sup = true;
            }
            else {
                crd.sup = false;
            }
            crd.raggio =(int)this.numericUpDownRaggio.Value;
            crd.registraDati();
            //
            newImp = true;          
        }
     
        //evita che qs1 sia inferiore a qs2
        private void numericUpDownQs1_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownQs1.Value <= this.numericUpDownQs2.Value) {
                this.numericUpDownQs1.Value = this.numericUpDownQs2.Value + (decimal)0.01;
            }
        }
        //evita che qs1 sia maggiore di qs2
        private void numericUpDownQs2_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownQs2.Value >= this.numericUpDownQs1.Value)
            {
                this.numericUpDownQs2.Value = this.numericUpDownQs1.Value - (decimal)0.01;
            }
        }               
        //evita che numqs2 sia minore di numqs1
        private void numericUpDownnumQs2_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownnumQs2.Value <= this.numericUpDownnumQs1.Value)
            {
                this.numericUpDownnumQs2.Value = this.numericUpDownnumQs1.Value + 1;
            }
        }
        //evita che numqs1 sia maggiore di numqs2
        private void numericUpDownnumQs1_ValueChanged(object sender, EventArgs e)
        {
            if (this.numericUpDownnumQs1.Value >= this.numericUpDownnumQs2.Value) {
                this.numericUpDownnumQs1.Value = (this.numericUpDownnumQs2.Value) - 1;
            }
        }

        private void buttonRegistraQ3_Click(object sender, EventArgs e)
        {
            //serializza i dati       
            CreazioneDatiQ3 crd3 = new CreazioneDatiQ3();
            //assegna i dati da serializzare
            crd3.limiteEi = (double)this.numericUpDownEi.Value;
            crd3.limiteEcs = (double)this.numericUpDownEcs.Value;

            if (this.radioButtonQ3OR.Checked == true)
            {
                crd3.varOR = true;
            }
            else
            {
                crd3.varOR = false;
            }
            
            crd3.registraDati();
            //
            newImp = true;     
        }

        private void buttonRegistraEi_Click(object sender, EventArgs e)
        {
            //serializza i dati       
            CreazioneDatiEi crdEi = new CreazioneDatiEi();
            //assegna i dati da serializzare
            //testo parametri
              crdEi.testoParametro1=this.textBoxParametro1Ei.Text;
              crdEi.testoParametro2=this.textBoxParametro2Ei.Text;
              crdEi.testoParametro3=this.textBoxParametro3Ei.Text;
              crdEi.testoParametro2Info=this.textBoxParametro2EiInfo.Text;
            //--------misura parametro 1-----------------
              crdEi.misura51=this.misura51Ei.Text;
              crdEi.misura41=this.misura41Ei.Text;
              crdEi.misura31=this.misura31Ei.Text;
              crdEi.misura21=this.misura21Ei.Text;
              crdEi.misura11=this.misura11Ei.Text;
            //--------misura parametro 2-----------------
              crdEi.misura52=this.misura52Ei.Text;
              crdEi.misura42=this.misura42Ei.Text;
              crdEi.misura32=this.misura32Ei.Text;
              crdEi.misura22=this.misura22Ei.Text;
              crdEi.misura12=this.misura12Ei.Text;
            //--------misura parametro 3-----------------
              crdEi.misura53=this.misura53Ei.Text;
              crdEi.misura43=this.misura43Ei.Text;
              crdEi.misura33=this.misura33Ei.Text;
              crdEi.misura23=this.misura23Ei.Text;
              crdEi.misura13=this.misura13Ei.Text;

              crdEi.registraDati();
              //
              newImp = true;     
        }

        private void buttonRegistraEcs_Click(object sender, EventArgs e)
        {
            //serializza i dati       
            CreazioneDatiEcs crdEcs = new CreazioneDatiEcs();
            //assegna i dati da serializzare
            //testo parametri
            crdEcs.testoParametro1 = this.textBoxParametro1Ecs.Text;
            crdEcs.testoParametro2 = this.textBoxParametro2Ecs.Text;
            crdEcs.testoParametro3 = this.textBoxParametro3Ecs.Text;
            //--------misura parametro 1-----------------
            crdEcs.misura51 = this.misura51Ecs.Text;
            crdEcs.misura41 = this.misura41Ecs.Text;
            crdEcs.misura31 = this.misura31Ecs.Text;
            crdEcs.misura21 = this.misura21Ecs.Text;
            crdEcs.misura11 = this.misura11Ecs.Text;
            //--------misura parametro 2-----------------
            crdEcs.misura52 = this.misura52Ecs.Text;
            crdEcs.misura42 = this.misura42Ecs.Text;
            crdEcs.misura32 = this.misura32Ecs.Text;
            crdEcs.misura22 = this.misura22Ecs.Text;
            crdEcs.misura12 = this.misura12Ecs.Text;
            //--------misura parametro 3-----------------
            crdEcs.misura53 = this.misura53Ecs.Text;
            crdEcs.misura43 = this.misura43Ecs.Text;
            crdEcs.misura33 = this.misura33Ecs.Text;
            crdEcs.misura23 = this.misura23Ecs.Text;
            crdEcs.misura13 = this.misura13Ecs.Text;
            //---------avvertimenti-----------------------
            crdEcs.avvertimento1 = this.textBoxAvvertimento1Ecs.Text;
            crdEcs.avvertimento2 = this.textBoxAvvertimento2Ecs.Text;
            crdEcs.avvertimento3 = this.textBoxAvvertimento3Ecs.Text;

            crdEcs.registraDati();
            //
            newImp = true;     
        }

        private void buttonRegistraPs_Click(object sender, EventArgs e)
        {
            //serializza i dati       
            CreazioneDatiPs crdPs = new CreazioneDatiPs();
            //assegna i dati da serializzare
            //testo parametri
            //TABELLA 1
            crdPs.testoParametro11 = this.textBoxParametro11Ps.Text;
            crdPs.testoParametro21 = this.textBoxParametro21Ps.Text;
            crdPs.testoParametro31 = this.textBoxParametro31Ps.Text;
            //--------misura caso 1-----------------
            crdPs.misura51Ps1 = this.misura51Ps1.Text;
            crdPs.misura41Ps1 = this.misura41Ps1.Text;
            crdPs.misura31Ps1 = this.misura31Ps1.Text;
            crdPs.misura21Ps1 = this.misura21Ps1.Text;
            crdPs.misura11Ps1 = this.misura11Ps1.Text;
            //--------misura caso 2-----------------
            crdPs.misura52Ps1 = this.misura52Ps1.Text;
            crdPs.misura42Ps1 = this.misura42Ps1.Text;
            crdPs.misura32Ps1 = this.misura32Ps1.Text;
            crdPs.misura22Ps1 = this.misura22Ps1.Text;
            crdPs.misura12Ps1 = this.misura12Ps1.Text;
            //--------misura caso 3-----------------
            crdPs.misura53Ps1 = this.misura53Ps1.Text;
            crdPs.misura43Ps1 = this.misura43Ps1.Text;
            crdPs.misura33Ps1 = this.misura33Ps1.Text;
            crdPs.misura23Ps1 = this.misura23Ps1.Text;
            crdPs.misura13Ps1 = this.misura13Ps1.Text;
            //TABELLA 2
            crdPs.testoParametro12 = this.textBoxParametro12Ps.Text;
            crdPs.testoParametro22 = this.textBoxParametro22Ps.Text;
            crdPs.testoParametro32 = this.textBoxParametro32Ps.Text;
            //--------misura caso 1-----------------
            crdPs.misura51Ps2 = this.misura51Ps2.Text;
            crdPs.misura41Ps2 = this.misura41Ps2.Text;
            crdPs.misura31Ps2 = this.misura31Ps2.Text;
            crdPs.misura21Ps2 = this.misura21Ps2.Text;
            crdPs.misura11Ps2 = this.misura11Ps2.Text;
            //--------misura caso 2-----------------
            crdPs.misura52Ps2 = this.misura52Ps2.Text;
            crdPs.misura42Ps2 = this.misura42Ps2.Text;
            crdPs.misura32Ps2 = this.misura32Ps2.Text;
            crdPs.misura22Ps2 = this.misura22Ps2.Text;
            crdPs.misura12Ps2 = this.misura12Ps2.Text;
            //--------misura caso 3-----------------
            crdPs.misura53Ps2 = this.misura53Ps2.Text;
            crdPs.misura43Ps2 = this.misura43Ps2.Text;
            crdPs.misura33Ps2 = this.misura33Ps2.Text;
            crdPs.misura23Ps2 = this.misura23Ps2.Text;
            crdPs.misura13Ps2 = this.misura13Ps2.Text;
            //TABELLA 3
            crdPs.testoParametro13 = this.textBoxParametro13Ps.Text;
            //--------misura caso 1-----------------
            crdPs.misura51Ps3 = this.misura51Ps3.Text;
            crdPs.misura41Ps3 = this.misura41Ps3.Text;
            crdPs.misura31Ps3 = this.misura31Ps3.Text;
            crdPs.misura21Ps3 = this.misura21Ps3.Text;
            crdPs.misura11Ps3 = this.misura11Ps3.Text;
            crdPs.registraDati();
            //
            newImp = true;     
        }

        private void buttonRegistraQ6_Click(object sender, EventArgs e)
        {
            //serializza i dati       
            CreazioneDatiQ6 crd6 = new CreazioneDatiQ6();
            //assegna i dati da serializzare
            crd6.limitePs = (double)this.numericUpDownPs.Value;
            crd6.registraDati();
            //
            newImp = true;       
        }

        private void buttonRegistraQ7_Click(object sender, EventArgs e)
        {
            //serializza i dati       
            CreazioneDatiQ7 crd7 = new CreazioneDatiQ7();
            //assegna i dati da serializzare
            crd7.limiteEcumNoRedList = (double)this.numericUpDownEcumNoRedList.Value;
            crd7.limiteEcumRedList = (double)this.numericUpDownEcumRedList.Value;
            
            crd7.registraDati();
            //
            newImp = true;  
        }

        private void buttonRegistraPaa_Click(object sender, EventArgs e)
        {
            //serializza i dati       
            CreazioneDatiPaa crdPaa = new CreazioneDatiPaa();
            //assegna i dati da serializzare
            //testo parametri
            crdPaa.testoParametro1 = this.textBoxParametro1Paa.Text;
            crdPaa.testoParametro2 = this.textBoxParametro2Paa.Text;
            crdPaa.testoParametro3 = this.textBoxParametro3Paa.Text;
            //--------misura parametro 1-----------------
            crdPaa.misura51 = this.misura51Paa.Text;
            crdPaa.misura41 = this.misura41Paa.Text;
            crdPaa.misura31 = this.misura31Paa.Text;
            crdPaa.misura21 = this.misura21Paa.Text;
            crdPaa.misura11 = this.misura11Paa.Text;
            //--------misura parametro 2sx-----------------
            crdPaa.misurasx52 = this.misurasx52Paa.Text;
            crdPaa.misurasx42 = this.misurasx42Paa.Text;
            crdPaa.misurasx32 = this.misurasx32Paa.Text;
            crdPaa.misurasx22 = this.misurasx22Paa.Text;
            crdPaa.misurasx12 = this.misurasx12Paa.Text;
            //--------misura parametro 2dx-----------------
            crdPaa.misuradx52 = Decimal.Parse(this.misuradx52Paa.Text);
            crdPaa.misuradx42 = Decimal.Parse(this.misuradx42Paa.Text);
            crdPaa.misuradx32 = Decimal.Parse(this.misuradx32Paa.Text);
            crdPaa.misuradx22 = Decimal.Parse(this.misuradx22Paa.Text);
            crdPaa.misuradx12 = Decimal.Parse(this.misuradx12Paa.Text);
            //--------misura parametro 3-----------------
            crdPaa.misura53 = this.misura53Paa.Text;
            crdPaa.misura33 = this.misura33Paa.Text;
            crdPaa.misura23 = this.misura23Paa.Text;
            crdPaa.misura13 = this.misura13Paa.Text;
            //------------passaggio Ps--------------
            if (this.checkBoxPaa.Checked == true)
            {
                crdPaa.isPsOk = true;
            }
            else {
                crdPaa.isPsOk = false;
            }


            crdPaa.registraDati();
            //
            newImp = true;     
        }

        private void buttonRegistraQ8_Click(object sender, EventArgs e)
        {
            //serializza i dati       
            CreazioneDatiQ8 crdQ8 = new CreazioneDatiQ8();
            //assegna i dati da serializzare
            crdQ8.limite1 = (double)this.LimitiPaa1.Value;
            crdQ8.limite2 = (double)this.LimitiPaa2.Value;
            crdQ8.limite3 = (double)this.LimitiPaa3.Value;
            crdQ8.limite4 = (double)this.LimitiPaa4.Value;
            crdQ8.limite5 = (double)this.LimitiPaa5.Value;
            crdQ8.limite6 = (double)this.LimitiPaa6.Value;
            crdQ8.limite7 = (double)this.LimitiPaa7.Value;

            crdQ8.areale1 = (double)this.LimitePercPaa1.Value;
            crdQ8.areale2 = (double)this.LimitePercPaa2.Value;
            crdQ8.areale3 = (double)this.LimitePercPaa3.Value;
            crdQ8.areale4 = (double)this.LimitePercPaa4.Value;
            crdQ8.areale5 = (double)this.LimitePercPaa5.Value;
            crdQ8.areale6 = (double)this.LimitePercPaa6.Value;
            crdQ8.areale7 = (double)this.LimitePercPaa7.Value;
            crdQ8.areale8 = (double)this.LimitePercPaa8.Value;

            crdQ8.registraDati();

            newImp = true;
        }

        private void buttonApriQ1_Click(object sender, EventArgs e)
        {
            Quadro1 q1 = new Quadro1();
            q1.ShowDialog();
            if (q1.DialogResult == DialogResult.Cancel)
            {
                q1.Dispose();
            }
            if (q1.DialogResult == DialogResult.Yes)
            {
                q1.Dispose();
            }
            if (q1.DialogResult == DialogResult.No)
            {
                q1.Dispose();
            }
        }

        private void buttonApriQ3_Click(object sender, EventArgs e)
        {
            Quadro3 q3 = new Quadro3();
            q3.ShowDialog();
            if (q3.DialogResult == DialogResult.Cancel)
            {
                q3.Dispose();
            }
            if (q3.DialogResult == DialogResult.Yes)
            {
                q3.Dispose();
            }
            if (q3.DialogResult == DialogResult.No)
            {
                q3.Dispose();
            }
        }
        
        private void buttonApriQ3Bis_Click(object sender, EventArgs e)
        {
            Quadro3Bis q3b = new Quadro3Bis();
            q3b.ShowDialog();
            if (q3b.DialogResult == DialogResult.Cancel)
            {
                q3b.Dispose();
            }
            if (q3b.DialogResult == DialogResult.Yes)
            {
                q3b.Dispose();
            }
            if (q3b.DialogResult == DialogResult.No)
            {
                q3b.Dispose();
            }
        }
      
        private void buttonApriEi_Click(object sender, EventArgs e)
        {
            CalcolaEi ei = new CalcolaEi();
            ei.ShowDialog();
            if (ei.DialogResult == DialogResult.Cancel)
            {
                ei.Dispose();
            }
            if (ei.DialogResult == DialogResult.OK)
            {
                ei.Dispose();
            }
           
        }

        private void buttonApriEcs_Click(object sender, EventArgs e)
        {
            CalcolaEcs ecs = new CalcolaEcs();
            ecs.ShowDialog();
            if (ecs.DialogResult == DialogResult.Cancel)
            {
                ecs.Dispose();
            }
            if (ecs.DialogResult == DialogResult.OK)
            {
                ecs.Dispose();
            }
           
        }

        private void buttonApriQ6_Click(object sender, EventArgs e)
        {
            Quadro6 q6 = new Quadro6();
            q6.ShowDialog();
            if (q6.DialogResult == DialogResult.Cancel)
            {
                q6.Dispose();
            }
            if (q6.DialogResult == DialogResult.Yes)
            {
                q6.Dispose();
            }
            if (q6.DialogResult == DialogResult.No)
            {
                q6.Dispose();
            }
        }

        private void buttonApriQ5_Click(object sender, EventArgs e)
        {
            Quadro5 q5 = new Quadro5();
            q5.ShowDialog();
            if (q5.DialogResult == DialogResult.Cancel)
            {
                q5.Dispose();
            }
            if (q5.DialogResult == DialogResult.Yes)
            {
                q5.Dispose();
            }
            if (q5.DialogResult == DialogResult.No)
            {
                q5.Dispose();
            }
        }

        private void buttonApriQ4_Click(object sender, EventArgs e)
        {
            Quadro4 q4 = new Quadro4();
            q4.ShowDialog();
            if (q4.DialogResult == DialogResult.Cancel)
            {
                q4.Dispose();
            }
            if (q4.DialogResult == DialogResult.Yes)
            {
                q4.Dispose();
            }
            if (q4.DialogResult == DialogResult.No)
            {
                q4.Dispose();
            }
        }

        private void buttonApriPs_Click(object sender, EventArgs e)
        {
            CalcolaPs ps = new CalcolaPs();
            ps.ShowDialog();
            if (ps.DialogResult == DialogResult.Cancel)
            {
                ps.Dispose();
            }
            if (ps.DialogResult == DialogResult.OK)
            {
                ps.Dispose();
            }
        }

        private void buttonApriQ7_Click(object sender, EventArgs e)
        {
            Quadro7 q7 = new Quadro7();
            q7.ShowDialog();
            if (q7.DialogResult == DialogResult.Cancel)
            {
                q7.Dispose();
            }
            if (q7.DialogResult == DialogResult.Yes)
            {
                q7.Dispose();
            }
            if (q7.DialogResult == DialogResult.No)
            {
                q7.Dispose();
            }
        }

        private void buttonApriQ8_Click(object sender, EventArgs e)
        {
            Quadro8 q8 = new Quadro8();
            q8.ShowDialog();
            if (q8.DialogResult == DialogResult.Cancel)
            {
                q8.Dispose();
            }
            if (q8.DialogResult == DialogResult.Yes)
            {
                q8.Dispose();
            }
            if (q8.DialogResult == DialogResult.No)
            {
                q8.Dispose();
            }
        }

        private void buttonApriPaa_Click(object sender, EventArgs e)
        {
            CalcolaPaa paa = new CalcolaPaa(1, this.checkBoxPaa.Checked);
            paa.ShowDialog();
            if (paa.DialogResult == DialogResult.Cancel)
            {
                paa.Dispose();
            }
            if (paa.DialogResult == DialogResult.OK)
            {
                paa.Dispose();
            }
        }

        private void buttonApri2_Click(object sender, EventArgs e)
        {
            Quadro2 q2 = new Quadro2();
            q2.ShowDialog();
            if (q2.DialogResult == DialogResult.Cancel)
            {
                q2.Dispose();
            }
            if (q2.DialogResult == DialogResult.Yes)
            {
                q2.Dispose();
            }
            if (q2.DialogResult == DialogResult.No)
            {
                q2.Dispose();
            }
        }

        private void buttonApriQ9_Click(object sender, EventArgs e)
        {
            Quadro9 q9 = new Quadro9();
            q9.ShowDialog();
            if (q9.DialogResult == DialogResult.Cancel)
            {
                q9.Dispose();
            }
            if (q9.DialogResult == DialogResult.Yes)
            {
                q9.Dispose();
            }
            if (q9.DialogResult == DialogResult.No)
            {
                q9.Dispose();
            }
        }

        private void buttonApriQ10_Click(object sender, EventArgs e)
        {
            Quadro10 q10 = new Quadro10();
            q10.ShowDialog();
            if (q10.DialogResult == DialogResult.Cancel)
            {
                q10.Dispose();
            }
            if (q10.DialogResult == DialogResult.Yes)
            {
                q10.Dispose();
            }
            if (q10.DialogResult == DialogResult.No)
            {
                q10.Dispose();
            }
        }

        private void buttonHelpQ1_Click(object sender, EventArgs e)
        {
            try
            {
               string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
               string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
               Process.Start(iePath, Application.StartupPath + @"\help\impostazioni\quadro1\imposta quadro1.html");                       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

        private void buttonHelpQ3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
                        try
            {
               string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
               string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
               Process.Start(iePath, Application.StartupPath + @"\help\impostazioni\quadro3\imposta quadro3.html");                       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

        private void buttonHelpQ6_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
             try
            {
               string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
               string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
               Process.Start(iePath, Application.StartupPath + @"\help\impostazioni\quadro6\imposta quadro6.html");  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
                    
        }

        private void buttonHelpQ7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
            try
            {
                string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
                Process.Start(iePath, Application.StartupPath + @"\help\impostazioni\quadro7\imposta quadro7.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
              
        }

        private void buttonHelpQ8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
            try
            {
                string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
                Process.Start(iePath, Application.StartupPath + @"\help\impostazioni\quadro8\imposta quadro8.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
              
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
            try
            {

               string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
               string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
               Process.Start(iePath, Application.StartupPath + @"\help\impostazioni\impostazioni.html");                                          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
               string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
               string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
               Process.Start(iePath, Application.StartupPath + @"\help\impostazioni\calcoloindicatori\calcolo indicatori.html");  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

        private void buttonHelpEcs_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
            try
            {
                string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
                Process.Start(iePath, Application.StartupPath + @"\help\impostazioni\calcoloindicatori\calcolo indicatori.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

        private void buttonHelpPs_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
            try
            {
                string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
                Process.Start(iePath, Application.StartupPath + @"\help\impostazioni\calcoloindicatori\calcolo indicatori.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

        private void buttonHelpPaa_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
            try
            {
                string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
                Process.Start(iePath, Application.StartupPath + @"\help\impostazioni\calcoloindicatori\calcolo indicatori.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }
             
    }
}