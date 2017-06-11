using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_esperto.Quadri
{
    public partial class Quadro2 : Form
    {
        public Quadro2()
        {
            InitializeComponent();
            //disabilita i ulsanti si e no se la maschera viene richiamata dal menu' impostazioni
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Quadro4 quadro4 = new Quadro4();
            quadro4.MdiParent = this.ParentForm;
            quadro4.Show();
            this.Close();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Quadro3 quadro3 = new Quadro3();
            quadro3.MdiParent = this.ParentForm;
            quadro3.Show();
            this.Close();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MisureConservazione miscons = new MisureConservazione();
            miscons.ShowDialog();
            if (miscons.DialogResult == DialogResult.Cancel) {
                miscons.Dispose();
            }
        }
    }
}