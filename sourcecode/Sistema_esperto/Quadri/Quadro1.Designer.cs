namespace Sistema_esperto.Quadri
{
    partial class Quadro1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quadro1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSi = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAvvertimento = new System.Windows.Forms.Label();
            this.groupBoxCalcoloQs = new System.Windows.Forms.GroupBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxQsPersonale = new System.Windows.Forms.GroupBox();
            this.numericUpDownQs = new System.Windows.Forms.NumericUpDown();
            this.buttonAiutoQs = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAggiungi2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNomi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxQs = new System.Windows.Forms.TextBox();
            this.specieDataSet1 = new Sistema_esperto.specieDataSet();
            this.comboBoxNomi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxNomi = new System.Windows.Forms.ListBox();
            this.listBoxQsHidden = new System.Windows.Forms.ListBox();
            this.buttonCancella = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.specieTableAdapter1 = new Sistema_esperto.specieDataSetTableAdapters.specieTableAdapter();
            this.textBoxValori = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.Label();
            this.textBoxSpiegaQs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxCalcoloQs.SuspendLayout();
            this.groupBoxQsPersonale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specieDataSet1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "L’area in cui è progettato l’intervento si configura \r\ncome hot spot di biodivers" +
                "ità  regionale?\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 107);
            this.panel1.TabIndex = 2;
            // 
            // buttonSi
            // 
            this.buttonSi.BackColor = System.Drawing.Color.White;
            this.buttonSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSi.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonSi.Enabled = false;
            this.buttonSi.Location = new System.Drawing.Point(198, 132);
            this.buttonSi.Name = "buttonSi";
            this.buttonSi.Size = new System.Drawing.Size(75, 23);
            this.buttonSi.TabIndex = 3;
            this.buttonSi.Text = "SI";
            this.buttonSi.UseVisualStyleBackColor = false;
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.Lime;
            this.buttonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNo.Location = new System.Drawing.Point(344, 132);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 4;
            this.buttonNo.Text = "NO";
            this.buttonNo.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "(*)";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxSpiegaQs);
            this.panel3.Controls.Add(this.textbox1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(6, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 442);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelAvvertimento);
            this.panel2.Controls.Add(this.groupBoxCalcoloQs);
            this.panel2.Controls.Add(this.listBoxNomi);
            this.panel2.Controls.Add(this.listBoxQsHidden);
            this.panel2.Controls.Add(this.buttonCancella);
            this.panel2.Location = new System.Drawing.Point(8, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 252);
            this.panel2.TabIndex = 10;
            // 
            // labelAvvertimento
            // 
            this.labelAvvertimento.AutoSize = true;
            this.labelAvvertimento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelAvvertimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvvertimento.ForeColor = System.Drawing.Color.Red;
            this.labelAvvertimento.Location = new System.Drawing.Point(353, 168);
            this.labelAvvertimento.Name = "labelAvvertimento";
            this.labelAvvertimento.Size = new System.Drawing.Size(0, 13);
            this.labelAvvertimento.TabIndex = 12;
            // 
            // groupBoxCalcoloQs
            // 
            this.groupBoxCalcoloQs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxCalcoloQs.Controls.Add(this.buttonHelp);
            this.groupBoxCalcoloQs.Controls.Add(this.groupBoxQsPersonale);
            this.groupBoxCalcoloQs.Controls.Add(this.buttonAggiungi);
            this.groupBoxCalcoloQs.Controls.Add(this.label7);
            this.groupBoxCalcoloQs.Controls.Add(this.textBoxQs);
            this.groupBoxCalcoloQs.Controls.Add(this.comboBoxNomi);
            this.groupBoxCalcoloQs.Controls.Add(this.label8);
            this.groupBoxCalcoloQs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxCalcoloQs.Location = new System.Drawing.Point(4, 2);
            this.groupBoxCalcoloQs.Name = "groupBoxCalcoloQs";
            this.groupBoxCalcoloQs.Size = new System.Drawing.Size(609, 150);
            this.groupBoxCalcoloQs.TabIndex = 13;
            this.groupBoxCalcoloQs.TabStop = false;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(580, 10);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(23, 23);
            this.buttonHelp.TabIndex = 21;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxQsPersonale
            // 
            this.groupBoxQsPersonale.Controls.Add(this.numericUpDownQs);
            this.groupBoxQsPersonale.Controls.Add(this.buttonAiutoQs);
            this.groupBoxQsPersonale.Controls.Add(this.label10);
            this.groupBoxQsPersonale.Controls.Add(this.buttonAggiungi2);
            this.groupBoxQsPersonale.Controls.Add(this.label9);
            this.groupBoxQsPersonale.Controls.Add(this.textBoxNomi);
            this.groupBoxQsPersonale.Controls.Add(this.label6);
            this.groupBoxQsPersonale.Location = new System.Drawing.Point(8, 65);
            this.groupBoxQsPersonale.Name = "groupBoxQsPersonale";
            this.groupBoxQsPersonale.Size = new System.Drawing.Size(592, 78);
            this.groupBoxQsPersonale.TabIndex = 20;
            this.groupBoxQsPersonale.TabStop = false;
            // 
            // numericUpDownQs
            // 
            this.numericUpDownQs.DecimalPlaces = 2;
            this.numericUpDownQs.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownQs.Location = new System.Drawing.Point(379, 29);
            this.numericUpDownQs.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownQs.Name = "numericUpDownQs";
            this.numericUpDownQs.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownQs.TabIndex = 19;
            // 
            // buttonAiutoQs
            // 
            this.buttonAiutoQs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAiutoQs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAiutoQs.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAiutoQs.Location = new System.Drawing.Point(9, 56);
            this.buttonAiutoQs.Name = "buttonAiutoQs";
            this.buttonAiutoQs.Size = new System.Drawing.Size(179, 21);
            this.buttonAiutoQs.TabIndex = 18;
            this.buttonAiutoQs.Text = "Aiuto per il calcolo del Qus";
            this.buttonAiutoQs.UseVisualStyleBackColor = false;
            this.buttonAiutoQs.Click += new System.EventHandler(this.buttonAiutoQs_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(10, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nome specie";
            // 
            // buttonAggiungi2
            // 
            this.buttonAggiungi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAggiungi2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAggiungi2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAggiungi2.Location = new System.Drawing.Point(474, 28);
            this.buttonAggiungi2.Name = "buttonAggiungi2";
            this.buttonAggiungi2.Size = new System.Drawing.Size(102, 22);
            this.buttonAggiungi2.TabIndex = 16;
            this.buttonAggiungi2.Text = "Aggiungi alla lista";
            this.buttonAggiungi2.UseVisualStyleBackColor = false;
            this.buttonAggiungi2.Click += new System.EventHandler(this.buttonAggiungi2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(337, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Qus = ";
            // 
            // textBoxNomi
            // 
            this.textBoxNomi.Location = new System.Drawing.Point(85, 30);
            this.textBoxNomi.Name = "textBoxNomi";
            this.textBoxNomi.Size = new System.Drawing.Size(241, 20);
            this.textBoxNomi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "INSERISCI DATI PERSONALIZZATI";
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAggiungi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAggiungi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAggiungi.Location = new System.Drawing.Point(481, 39);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(102, 22);
            this.buttonAggiungi.TabIndex = 8;
            this.buttonAggiungi.Text = "Aggiungi alla lista";
            this.buttonAggiungi.UseVisualStyleBackColor = false;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(344, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Qus = ";
            // 
            // textBoxQs
            // 
            this.textBoxQs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specieDataSet1, "specie.QuS", true));
            this.textBoxQs.Location = new System.Drawing.Point(386, 41);
            this.textBoxQs.Name = "textBoxQs";
            this.textBoxQs.ReadOnly = true;
            this.textBoxQs.Size = new System.Drawing.Size(66, 20);
            this.textBoxQs.TabIndex = 5;
            // 
            // specieDataSet1
            // 
            this.specieDataSet1.DataSetName = "specieDataSet";
            this.specieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxNomi
            // 
            this.comboBoxNomi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxNomi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNomi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNomi.DataSource = this.specieDataSet1;
            this.comboBoxNomi.DisplayMember = "specie.Nome specie";
            this.comboBoxNomi.FormattingEnabled = true;
            this.comboBoxNomi.Location = new System.Drawing.Point(16, 41);
            this.comboBoxNomi.Name = "comboBoxNomi";
            this.comboBoxNomi.Size = new System.Drawing.Size(317, 21);
            this.comboBoxNomi.TabIndex = 4;
            this.comboBoxNomi.ValueMember = "specie.Nome specie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(17, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "SCEGLI IL NOME DELLA SPECIE DAL DATABASE";
            // 
            // listBoxNomi
            // 
            this.listBoxNomi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxNomi.FormattingEnabled = true;
            this.listBoxNomi.HorizontalExtent = 20;
            this.listBoxNomi.HorizontalScrollbar = true;
            this.listBoxNomi.Location = new System.Drawing.Point(20, 158);
            this.listBoxNomi.Name = "listBoxNomi";
            this.listBoxNomi.Size = new System.Drawing.Size(317, 82);
            this.listBoxNomi.TabIndex = 0;
            this.listBoxNomi.SelectedIndexChanged += new System.EventHandler(this.listBoxNomi_SelectedIndexChanged);
            // 
            // listBoxQsHidden
            // 
            this.listBoxQsHidden.FormattingEnabled = true;
            this.listBoxQsHidden.Location = new System.Drawing.Point(483, 223);
            this.listBoxQsHidden.Name = "listBoxQsHidden";
            this.listBoxQsHidden.Size = new System.Drawing.Size(19, 17);
            this.listBoxQsHidden.TabIndex = 10;
            this.listBoxQsHidden.Visible = false;
            // 
            // buttonCancella
            // 
            this.buttonCancella.BackColor = System.Drawing.Color.LightGray;
            this.buttonCancella.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancella.Enabled = false;
            this.buttonCancella.Location = new System.Drawing.Point(351, 217);
            this.buttonCancella.Name = "buttonCancella";
            this.buttonCancella.Size = new System.Drawing.Size(106, 23);
            this.buttonCancella.TabIndex = 9;
            this.buttonCancella.Text = "Cancella dalla lista";
            this.buttonCancella.UseVisualStyleBackColor = false;
            this.buttonCancella.Click += new System.EventHandler(this.buttonCancella_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Studi e parametri su cui è basata la decisione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Metodo per il calcolo del valore QuS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBoxValori);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.buttonNo);
            this.panel4.Controls.Add(this.buttonSi);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(6, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 257);
            this.panel4.TabIndex = 9;
            // 
            // specieTableAdapter1
            // 
            this.specieTableAdapter1.ClearBeforeFill = true;
            // 
            // textBoxValori
            // 
            this.textBoxValori.BackColor = System.Drawing.Color.White;
            this.textBoxValori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValori.Location = new System.Drawing.Point(8, 161);
            this.textBoxValori.Name = "textBoxValori";
            this.textBoxValori.Size = new System.Drawing.Size(616, 87);
            this.textBoxValori.TabIndex = 7;
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.Color.White;
            this.textbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1.Location = new System.Drawing.Point(8, 30);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(616, 78);
            this.textbox1.TabIndex = 11;
            this.textbox1.Text = resources.GetString("textbox1.Text");
            // 
            // textBoxSpiegaQs
            // 
            this.textBoxSpiegaQs.BackColor = System.Drawing.Color.White;
            this.textBoxSpiegaQs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSpiegaQs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpiegaQs.Location = new System.Drawing.Point(7, 131);
            this.textBoxSpiegaQs.Name = "textBoxSpiegaQs";
            this.textBoxSpiegaQs.Size = new System.Drawing.Size(617, 43);
            this.textBoxSpiegaQs.TabIndex = 12;
            this.textBoxSpiegaQs.Text = "I valori di QuS sono riportati, per la maggior parte delle specie, nel database r" +
                "egionale NaturaLi";
            // 
            // Quadro1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(646, 720);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quadro1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUADRO 1";
            this.Shown += new System.EventHandler(this.Quadro1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxCalcoloQs.ResumeLayout(false);
            this.groupBoxCalcoloQs.PerformLayout();
            this.groupBoxQsPersonale.ResumeLayout(false);
            this.groupBoxQsPersonale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specieDataSet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSi;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxQs;
        private System.Windows.Forms.ComboBox comboBoxNomi;
        private System.Windows.Forms.Button buttonAggiungi;
        private specieDataSet specieDataSet1;
        private Sistema_esperto.specieDataSetTableAdapters.specieTableAdapter specieTableAdapter1;
        private System.Windows.Forms.ListBox listBoxNomi;
        private System.Windows.Forms.Button buttonCancella;
        private System.Windows.Forms.ListBox listBoxQsHidden;
        private System.Windows.Forms.Label labelAvvertimento;
        private System.Windows.Forms.GroupBox groupBoxCalcoloQs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAggiungi2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNomi;
        private System.Windows.Forms.Button buttonAiutoQs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownQs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxQsPersonale;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label textBoxValori;
        private System.Windows.Forms.Label textbox1;
        private System.Windows.Forms.Label textBoxSpiegaQs;
    }
}

