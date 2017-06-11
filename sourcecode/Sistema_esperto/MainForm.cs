using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sistema_esperto.Quadri;
using System.IO;
using System.Diagnostics;

namespace Sistema_esperto
{
    public partial class MainForm : Form
    {

        //variabile che tiene il conto delle form childs aperte
        private int childFormNumber = 0;
        // pannello di valutazione
        private MainChild mainChild;
        //variabile che indica se e' in corso una valutazione
        private bool valutazione = false;
        //IMPOSTAZIONI imp;
        //splashapertura
        Splash splash = new Splash();

        public MainForm()
        {
            
            //visualizza splashscreen
            splash.ShowDialog();
            if (splash.DialogResult == DialogResult.OK) {
                splash.Dispose();
            }
            //quando lo splash si chiude inizializza i componenti
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //apri subito il pannello di valutazione
            showMainChild();

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            showMainChild();

        }

        private void showMainChild()
        {
            /*// Create a new instance of the child form.
            Quadro1 quadro1 = new Quadro1();
            // Make it a child of this MDI form before showing it.
            quadro1.MdiParent = this;
            //quadro1.Text = "Window " + childFormNumber++;
            quadro1.Show();
            Quadro2 quadro2 = new Quadro2();
            quadro2.MdiParent = this;
            quadro2.Show();
            Quadro3 quadro3 = new Quadro3();
            quadro3.MdiParent = this;
            quadro3.Show();*/
            // se non e' gia' in corso una valutazione allora apri il pannello di valutazione
            if (valutazione == false)
            {
                mainChild = new MainChild();
                //imposta il pannello di valutazione come child della form principale
                mainChild.MdiParent = this;
                
                //fai in modo da massimizzare le dimensioni del pannello all'interno della form principale
                //mainChild.Width = this.Width;
                //mainChild.Height = this.Height;
              

                //inserisci il messaggio e colora di giallo lo statusbar
                this.toolStripStatusLabel.Text = "Valutazione in corso";
                this.toolStripStatusLabel.BackColor = Color.Yellow;
                //tieni in memoria che e' in corso un a valutazione
                valutazione = true;
                //abilita il pulsante di salvataggio e apertura del testo della valutazione
                this.saveToolStripMenuItem.Enabled = true;
                this.openToolStripMenuItem.Enabled = true;
                //mostra il pannello di valutazione
                mainChild.Show();
                //se ci sono altre form child ordinale in verticale
                LayoutMdi(MdiLayout.TileVertical);
                //quando il pannello di valutazione viene chiuso genera una risposta all'evento
                mainChild.FormClosing += new FormClosingEventHandler(this.checkValutazione);
            }
            //se e' gia' in corso una valutazione avverti l'utente
            else
            {
                MessageBox.Show("Il pannello di valutazione e' gia' aperto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //risposta all'evento di chiusura del pannello di valutazione
        private void checkValutazione(object sender, EventArgs e)
        {
            // tieni in memoria che non e' in corso una valutazione
            valutazione = false;
            //elimina il testo dalla status bar
            this.toolStripStatusLabel.Text = "";
            //disabilita il pulsante di salvataggio del testo di valutazione
            this.saveToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.Enabled = false;

        }

        private void OpenFile(object sender, EventArgs e)
        {
            mainChild.apri();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abilita o disabilita la statusbar
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.MdiParent = this;
            info.Show();
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //salva i contenuti del testo di valutazione contenuto nel pannello di valutazione
            mainChild.salva();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Password pw=new Password();

            //hook all'evento che occorre quando si chiude il pannello solo se c'e' una valutazione in corso
            //imp.FormClosing += new FormClosingEventHandler(imp_FormClosing);

            pw.Show();          
        }

        private void quadro1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadro1 q1 = new Quadro1();
            q1.Show();
        }

        private void quadro2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadro2 q2 = new Quadro2();
            q2.Show();
        }

        private void quadro3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadro3 q3 = new Quadro3();
            q3.Show();
        }

        private void quadro3bisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadro3Bis q3b = new Quadro3Bis();
            q3b.Show();
        }
        
        private void quadro4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadro4 q4 = new Quadro4();
            q4.Show();
        }

        private void quadro5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadro5 q5 = new Quadro5();
            q5.Show();
        }

        private void quadro6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadro6 q6 = new Quadro6();
            q6.Show();
        }

        private void quadro7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadro7 q7 = new Quadro7();
            q7.Show();
        }

        private void quadro8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadro8 q8 = new Quadro8();
            q8.Show();
        }

        private void quadro9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadro9 q9 = new Quadro9();
            q9.Show();
        }

        private void quadro10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadro10 q10 = new Quadro10();
            q10.Show();
        }

        private void calcolaEiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcolaEi cei = new CalcolaEi();
            cei.Show();
        }

        private void calcolaEcsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcolaEcs cecs = new CalcolaEcs();
            cecs.Show();
        }

        private void calcolaPsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcolaPs cps = new CalcolaPs();
            cps.Show();
        }

        private void ps1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcolaPaa paa1 = new CalcolaPaa(1,true);
            paa1.Show();
        }

        private void ps2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcolaPaa paa15 = new CalcolaPaa(1.5, true);
            paa15.Show();
        }

        private void ps3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcolaPaa paa2 = new CalcolaPaa(2, true);
            paa2.Show();
        }

        private void ps4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcolaPaa paa25 = new CalcolaPaa(2.5, true);
            paa25.Show();
        }

        private void ps35ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcolaPaa paa35 = new CalcolaPaa(3.5, true);
            paa35.Show();
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
            try
            {
                string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
                //ProcessStartInfo startInfo = new ProcessStartInfo(iePath);
                //startInfo.Arguments = Application.StartupPath + @"\help\index.htm";
                //Process.Start(startInfo);
                Process.Start(iePath, Application.StartupPath + @"\help\index.htm");   
                //using (Process myProcess = new Process())
                //{
                    //prendi il nome del file e aprilo
                    //string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                   // string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");
                   // string docPath = Application.StartupPath + @"\help\index.htm";
                    //myProcess.StartInfo.FileName = Application.StartupPath + @"\help\index.htm";
                    //myProcess.Start();
                   // Process.Start(iePath, docPath);                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath + this.comboBoxNome.SelectedValue.ToString() + ".doc");
            //inizia un processo per l'apertura di un file esterno
            try
            {
               string programFilesPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
               string iePath = System.IO.Path.Combine(programFilesPath, @"Internet Explorer\IExplore.exe");               
               Process.Start(iePath, Application.StartupPath + @"\help\pannelloprincipale\pannello principale.html");                          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'apertura del file " + ex.ToString());
            }
        }

       

        //avverti l'utente di chiudere il pannello di valutazione se e' aperto e se e' stato premuto il pulsante di modifica delle impostazioni
        //il programma e' stato modificato e questo non serve piu' perche' la serializzazione ora
        //avviene all'apertura delle singole maschere e non all'apertura del mainchild
        /*void imp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (valutazione)
            {
                if (imp.newImp)
                {
                    MessageBox.Show("PER APPLICARE LE NUOVE IMPOSTAZIONI E' NECESSARIO RIAVVIARE IL PANNELLO DI VALUTAZIONE");
                }
            }
        }*/       
    }
}

