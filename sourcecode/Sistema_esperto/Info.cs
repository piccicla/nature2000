using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Sistema_esperto
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //metti un limite superiore allo zoom
            if (this.richTextBox1.ZoomFactor < 2)
            {
                this.richTextBox1.ZoomFactor = this.richTextBox1.ZoomFactor + 0.1F;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //metti un limite inferiore allo zoom
            if(this.richTextBox1.ZoomFactor>1){
            this.richTextBox1.ZoomFactor = this.richTextBox1.ZoomFactor - 0.1F;
            }
        }

        private void Info_Load(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile(Path.Combine(Application.StartupPath, @"testi\info.rtf"));
            }
            catch (Exception error) { 
            MessageBox.Show("Errore nel caricamento delle informazioni.\nControllare se il file e' presente o se e' nel formato corretto (.rtf)");
            }

        }
     
    }
}