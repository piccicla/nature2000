using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_esperto
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPassword.Text == "biodiversity") {
                this.Close();
                IMPOSTAZIONI imp = new IMPOSTAZIONI();
                imp.ShowDialog();           
            }
            else{
            MessageBox.Show("PASSWORD ERRATA");
            }
        }
    }
}