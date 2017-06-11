namespace Sistema_esperto
{
    partial class AiutoQs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AiutoQs));
            this.pictureBoxTabellaQs = new System.Windows.Forms.PictureBox();
            this.labelSpiegazione = new System.Windows.Forms.Label();
            this.linkLabelSpegazioneVilla = new System.Windows.Forms.LinkLabel();
            this.labelRisultatoQs = new System.Windows.Forms.Label();
            this.textBoxRisultatoQs = new System.Windows.Forms.TextBox();
            this.numericUpDownParametro3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownParametro2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownParametro1 = new System.Windows.Forms.NumericUpDown();
            this.labelCalcoloParametro3 = new System.Windows.Forms.Label();
            this.labelCalcoloParametro2 = new System.Windows.Forms.Label();
            this.labelCalcoloParametro1 = new System.Windows.Forms.Label();
            this.numericUpDownParametro4 = new System.Windows.Forms.NumericUpDown();
            this.labelCalcoloParametro4 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTabellaQs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParametro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParametro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParametro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParametro4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTabellaQs
            // 
            this.pictureBoxTabellaQs.Image = global::Sistema_esperto.Properties.Resources.calcoloqs;
            this.pictureBoxTabellaQs.InitialImage = null;
            this.pictureBoxTabellaQs.Location = new System.Drawing.Point(1, 6);
            this.pictureBoxTabellaQs.Name = "pictureBoxTabellaQs";
            this.pictureBoxTabellaQs.Size = new System.Drawing.Size(668, 716);
            this.pictureBoxTabellaQs.TabIndex = 0;
            this.pictureBoxTabellaQs.TabStop = false;
            // 
            // labelSpiegazione
            // 
            this.labelSpiegazione.AutoSize = true;
            this.labelSpiegazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSpiegazione.Location = new System.Drawing.Point(675, 6);
            this.labelSpiegazione.Name = "labelSpiegazione";
            this.labelSpiegazione.Size = new System.Drawing.Size(287, 158);
            this.labelSpiegazione.TabIndex = 1;
            this.labelSpiegazione.Text = resources.GetString("labelSpiegazione.Text");
            // 
            // linkLabelSpegazioneVilla
            // 
            this.linkLabelSpegazioneVilla.AutoSize = true;
            this.linkLabelSpegazioneVilla.Cursor = System.Windows.Forms.Cursors.Help;
            this.linkLabelSpegazioneVilla.Location = new System.Drawing.Point(691, 394);
            this.linkLabelSpegazioneVilla.Name = "linkLabelSpegazioneVilla";
            this.linkLabelSpegazioneVilla.Size = new System.Drawing.Size(194, 13);
            this.linkLabelSpegazioneVilla.TabIndex = 32;
            this.linkLabelSpegazioneVilla.TabStop = true;
            this.linkLabelSpegazioneVilla.Text = "Il calcolo utilizza la formula di Storie-Villa";
            this.linkLabelSpegazioneVilla.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSpegazioneVilla_LinkClicked);
            // 
            // labelRisultatoQs
            // 
            this.labelRisultatoQs.AutoSize = true;
            this.labelRisultatoQs.Location = new System.Drawing.Point(691, 353);
            this.labelRisultatoQs.Name = "labelRisultatoQs";
            this.labelRisultatoQs.Size = new System.Drawing.Size(29, 13);
            this.labelRisultatoQs.TabIndex = 31;
            this.labelRisultatoQs.Text = "Qs =";
            // 
            // textBoxRisultatoQs
            // 
            this.textBoxRisultatoQs.Enabled = false;
            this.textBoxRisultatoQs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRisultatoQs.Location = new System.Drawing.Point(723, 347);
            this.textBoxRisultatoQs.Multiline = true;
            this.textBoxRisultatoQs.Name = "textBoxRisultatoQs";
            this.textBoxRisultatoQs.ReadOnly = true;
            this.textBoxRisultatoQs.Size = new System.Drawing.Size(99, 24);
            this.textBoxRisultatoQs.TabIndex = 30;
            this.textBoxRisultatoQs.Text = "0";
            // 
            // numericUpDownParametro3
            // 
            this.numericUpDownParametro3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownParametro3.Location = new System.Drawing.Point(800, 263);
            this.numericUpDownParametro3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownParametro3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownParametro3.Name = "numericUpDownParametro3";
            this.numericUpDownParametro3.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownParametro3.TabIndex = 29;
            this.numericUpDownParametro3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownParametro3.ValueChanged += new System.EventHandler(this.numericUpDownParametro3_ValueChanged);
            // 
            // numericUpDownParametro2
            // 
            this.numericUpDownParametro2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownParametro2.Location = new System.Drawing.Point(800, 228);
            this.numericUpDownParametro2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownParametro2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownParametro2.Name = "numericUpDownParametro2";
            this.numericUpDownParametro2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownParametro2.TabIndex = 28;
            this.numericUpDownParametro2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownParametro2.ValueChanged += new System.EventHandler(this.numericUpDownParametro2_ValueChanged);
            // 
            // numericUpDownParametro1
            // 
            this.numericUpDownParametro1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownParametro1.Location = new System.Drawing.Point(800, 194);
            this.numericUpDownParametro1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownParametro1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownParametro1.Name = "numericUpDownParametro1";
            this.numericUpDownParametro1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownParametro1.TabIndex = 27;
            this.numericUpDownParametro1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownParametro1.ValueChanged += new System.EventHandler(this.numericUpDownParametro1_ValueChanged_1);
            // 
            // labelCalcoloParametro3
            // 
            this.labelCalcoloParametro3.AutoSize = true;
            this.labelCalcoloParametro3.Location = new System.Drawing.Point(685, 265);
            this.labelCalcoloParametro3.Name = "labelCalcoloParametro3";
            this.labelCalcoloParametro3.Size = new System.Drawing.Size(91, 13);
            this.labelCalcoloParametro3.TabIndex = 26;
            this.labelCalcoloParametro3.Text = "PARAMETRO A4";
            // 
            // labelCalcoloParametro2
            // 
            this.labelCalcoloParametro2.AutoSize = true;
            this.labelCalcoloParametro2.Location = new System.Drawing.Point(685, 230);
            this.labelCalcoloParametro2.Name = "labelCalcoloParametro2";
            this.labelCalcoloParametro2.Size = new System.Drawing.Size(91, 13);
            this.labelCalcoloParametro2.TabIndex = 25;
            this.labelCalcoloParametro2.Text = "PARAMETRO A3";
            // 
            // labelCalcoloParametro1
            // 
            this.labelCalcoloParametro1.AutoSize = true;
            this.labelCalcoloParametro1.Location = new System.Drawing.Point(685, 196);
            this.labelCalcoloParametro1.Name = "labelCalcoloParametro1";
            this.labelCalcoloParametro1.Size = new System.Drawing.Size(109, 13);
            this.labelCalcoloParametro1.TabIndex = 24;
            this.labelCalcoloParametro1.Text = "PARAMETRO A1/A2";
            // 
            // numericUpDownParametro4
            // 
            this.numericUpDownParametro4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownParametro4.Location = new System.Drawing.Point(800, 300);
            this.numericUpDownParametro4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownParametro4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownParametro4.Name = "numericUpDownParametro4";
            this.numericUpDownParametro4.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownParametro4.TabIndex = 34;
            this.numericUpDownParametro4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownParametro4.ValueChanged += new System.EventHandler(this.numericUpDownParametro4_ValueChanged);
            // 
            // labelCalcoloParametro4
            // 
            this.labelCalcoloParametro4.AutoSize = true;
            this.labelCalcoloParametro4.Location = new System.Drawing.Point(685, 302);
            this.labelCalcoloParametro4.Name = "labelCalcoloParametro4";
            this.labelCalcoloParametro4.Size = new System.Drawing.Size(91, 13);
            this.labelCalcoloParametro4.TabIndex = 33;
            this.labelCalcoloParametro4.Text = "PARAMETRO A5";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(892, 686);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 35;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(842, 348);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(26, 23);
            this.buttonHelp.TabIndex = 36;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // AiutoQs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 726);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDownParametro4);
            this.Controls.Add(this.labelCalcoloParametro4);
            this.Controls.Add(this.linkLabelSpegazioneVilla);
            this.Controls.Add(this.labelRisultatoQs);
            this.Controls.Add(this.textBoxRisultatoQs);
            this.Controls.Add(this.numericUpDownParametro3);
            this.Controls.Add(this.numericUpDownParametro2);
            this.Controls.Add(this.numericUpDownParametro1);
            this.Controls.Add(this.labelCalcoloParametro3);
            this.Controls.Add(this.labelCalcoloParametro2);
            this.Controls.Add(this.labelCalcoloParametro1);
            this.Controls.Add(this.labelSpiegazione);
            this.Controls.Add(this.pictureBoxTabellaQs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AiutoQs";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Calcolo di Qs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTabellaQs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParametro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParametro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParametro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParametro4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTabellaQs;
        private System.Windows.Forms.Label labelSpiegazione;
        private System.Windows.Forms.LinkLabel linkLabelSpegazioneVilla;
        private System.Windows.Forms.Label labelRisultatoQs;
        private System.Windows.Forms.TextBox textBoxRisultatoQs;
        private System.Windows.Forms.NumericUpDown numericUpDownParametro3;
        private System.Windows.Forms.NumericUpDown numericUpDownParametro2;
        private System.Windows.Forms.NumericUpDown numericUpDownParametro1;
        private System.Windows.Forms.Label labelCalcoloParametro3;
        private System.Windows.Forms.Label labelCalcoloParametro2;
        private System.Windows.Forms.Label labelCalcoloParametro1;
        private System.Windows.Forms.NumericUpDown numericUpDownParametro4;
        private System.Windows.Forms.Label labelCalcoloParametro4;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonHelp;

    }
}