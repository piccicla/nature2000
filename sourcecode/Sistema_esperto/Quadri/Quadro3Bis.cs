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
    public partial class Quadro3Bis : Form
    {
         	
        public Quadro3Bis()
        {
            InitializeComponent();
            //inizializza i valori numerici degli indicatori
            //ottieni dati serializzati per riempire la tabella
            CreazioneDatiEi crd = new CreazioneDatiEi();
            crd.caricaDati();
            //assegna dati ai componenti della tabella
            //testo parametri

            this.textBoxParametro2.Text = crd.testoParametro2;
            this.textBoxParametro2Info.Text = crd.testoParametro2Info;

            //--------misura parametro 2-----------------
            this.misura52.Text = crd.misura52;
            this.misura42.Text = crd.misura42;
            this.misura32.Text = crd.misura32;
            //this.misura22.Text = crd.misura22;
            this.misura12.Text = crd.misura12;            
                            
        }

        }   
    }
