using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_esperto
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
           
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Info inf = new Info();
            inf.Show();
        }       
        
    }
}