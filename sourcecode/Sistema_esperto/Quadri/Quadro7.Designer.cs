namespace Sistema_esperto.Quadri
{
    partial class Quadro7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quadro7));
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelSi = new System.Windows.Forms.Label();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonSi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxRed = new System.Windows.Forms.GroupBox();
            this.labelRed = new System.Windows.Forms.Label();
            this.listBoxRed = new System.Windows.Forms.ListBox();
            this.red_listDataSet1 = new Sistema_esperto.red_listDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.specieTableAdapter1 = new Sistema_esperto.red_listDataSetTableAdapters.specieTableAdapter();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red_listDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Si verificano effetti cumulativi non sostenibili?\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelSi);
            this.panel4.Controls.Add(this.buttonNo);
            this.panel4.Controls.Add(this.buttonSi);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(1, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 140);
            this.panel4.TabIndex = 17;
            // 
            // labelSi
            // 
            this.labelSi.AutoSize = true;
            this.labelSi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSi.Location = new System.Drawing.Point(11, 98);
            this.labelSi.Name = "labelSi";
            this.labelSi.Size = new System.Drawing.Size(379, 28);
            this.labelSi.TabIndex = 18;
            this.labelSi.Text = "Livello soglia Ecum  < -5 qualora trattasi di specie non vulnerabili\r\nEcum < -4 s" +
                "e figurano nella red list regionale ";
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.White;
            this.buttonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNo.Location = new System.Drawing.Point(512, 69);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 4;
            this.buttonNo.Text = "NO";
            this.buttonNo.UseVisualStyleBackColor = false;
            // 
            // buttonSi
            // 
            this.buttonSi.BackColor = System.Drawing.Color.White;
            this.buttonSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSi.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonSi.Location = new System.Drawing.Point(43, 69);
            this.buttonSi.Name = "buttonSi";
            this.buttonSi.Size = new System.Drawing.Size(75, 23);
            this.buttonSi.TabIndex = 3;
            this.buttonSi.Text = "SI";
            this.buttonSi.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 49);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Determinazione dell\' indicatore";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(220, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 21);
            this.button3.TabIndex = 8;
            this.button3.Text = "APRI DOCUMENTO\r\n";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Studi e parametri su cui è basata la decisione";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBoxRed);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(1, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 468);
            this.panel3.TabIndex = 16;
            // 
            // groupBoxRed
            // 
            this.groupBoxRed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxRed.Controls.Add(this.labelRed);
            this.groupBoxRed.Controls.Add(this.listBoxRed);
            this.groupBoxRed.Location = new System.Drawing.Point(17, 240);
            this.groupBoxRed.Name = "groupBoxRed";
            this.groupBoxRed.Size = new System.Drawing.Size(601, 217);
            this.groupBoxRed.TabIndex = 11;
            this.groupBoxRed.TabStop = false;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRed.Location = new System.Drawing.Point(206, 12);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(184, 20);
            this.labelRed.TabIndex = 10;
            this.labelRed.Text = "RED LIST REGIONALE";
            // 
            // listBoxRed
            // 
            this.listBoxRed.DataSource = this.red_listDataSet1;
            this.listBoxRed.DisplayMember = "specie.SPECIE";
            this.listBoxRed.FormattingEnabled = true;
            this.listBoxRed.Location = new System.Drawing.Point(13, 42);
            this.listBoxRed.Name = "listBoxRed";
            this.listBoxRed.Size = new System.Drawing.Size(575, 160);
            this.listBoxRed.Sorted = true;
            this.listBoxRed.TabIndex = 9;
            this.listBoxRed.ValueMember = "specie.SPECIE";
            // 
            // red_listDataSet1
            // 
            this.red_listDataSet1.DataSetName = "red_listDataSet";
            this.red_listDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(618, 385);
            this.label3.TabIndex = 13;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "manuale libioss su incidenza delle attività umane";
            // 
            // specieTableAdapter1
            // 
            this.specieTableAdapter1.ClearBeforeFill = true;
            // 
            // Quadro7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 619);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quadro7";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadro7";
            this.Load += new System.EventHandler(this.Quadro7_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBoxRed.ResumeLayout(false);
            this.groupBoxRed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red_listDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonSi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelSi;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.ListBox listBoxRed;
        private red_listDataSet red_listDataSet1;
        private Sistema_esperto.red_listDataSetTableAdapters.specieTableAdapter specieTableAdapter1;
        private System.Windows.Forms.GroupBox groupBoxRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}