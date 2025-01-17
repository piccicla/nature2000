namespace Sistema_esperto.Quadri
{
    partial class Quadro3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quadro3));
            this.buttonSi = new System.Windows.Forms.Button();
            this.labelIndicatori = new System.Windows.Forms.Label();
            this.panelDomanda = new System.Windows.Forms.Panel();
            this.labelDomanda = new System.Windows.Forms.Label();
            this.panelDomandaSiNo = new System.Windows.Forms.Panel();
            this.labelNo = new System.Windows.Forms.Label();
            this.labelSi = new System.Windows.Forms.Label();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonCalcolaEi = new System.Windows.Forms.Button();
            this.labelStudiParametri = new System.Windows.Forms.Label();
            this.panelCorpo = new System.Windows.Forms.Panel();
            this.labelEcs = new System.Windows.Forms.Label();
            this.buttonCalcolaEcs = new System.Windows.Forms.Button();
            this.textBoxCalcolaEcs = new System.Windows.Forms.Label();
            this.labelEi = new System.Windows.Forms.Label();
            this.textBoxEi = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDomanda.SuspendLayout();
            this.panelDomandaSiNo.SuspendLayout();
            this.panelCorpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSi
            // 
            this.buttonSi.BackColor = System.Drawing.Color.White;
            this.buttonSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSi.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonSi.Enabled = false;
            this.buttonSi.Location = new System.Drawing.Point(125, 132);
            this.buttonSi.Name = "buttonSi";
            this.buttonSi.Size = new System.Drawing.Size(75, 23);
            this.buttonSi.TabIndex = 3;
            this.buttonSi.Text = "SI";
            this.buttonSi.UseVisualStyleBackColor = false;
            // 
            // labelIndicatori
            // 
            this.labelIndicatori.AutoSize = true;
            this.labelIndicatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndicatori.Location = new System.Drawing.Point(173, 151);
            this.labelIndicatori.Name = "labelIndicatori";
            this.labelIndicatori.Size = new System.Drawing.Size(256, 20);
            this.labelIndicatori.TabIndex = 2;
            this.labelIndicatori.Text = "Determinazione degli indicatori";
            // 
            // panelDomanda
            // 
            this.panelDomanda.BackColor = System.Drawing.Color.Lime;
            this.panelDomanda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDomanda.Controls.Add(this.labelDomanda);
            this.panelDomanda.Location = new System.Drawing.Point(11, 8);
            this.panelDomanda.Name = "panelDomanda";
            this.panelDomanda.Size = new System.Drawing.Size(612, 107);
            this.panelDomanda.TabIndex = 2;
            // 
            // labelDomanda
            // 
            this.labelDomanda.AutoSize = true;
            this.labelDomanda.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomanda.Location = new System.Drawing.Point(9, 2);
            this.labelDomanda.Name = "labelDomanda";
            this.labelDomanda.Size = new System.Drawing.Size(596, 124);
            this.labelDomanda.TabIndex = 1;
            this.labelDomanda.Text = "L’intervento, qualora fosse localizzato al di fuori \r\ndel SITO o in aree matrice " +
                "del SITO, può influire \r\nsu specie presenti in aree focali distanti?\r\n\r\n";
            this.labelDomanda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDomandaSiNo
            // 
            this.panelDomandaSiNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDomandaSiNo.Controls.Add(this.labelNo);
            this.panelDomandaSiNo.Controls.Add(this.labelSi);
            this.panelDomandaSiNo.Controls.Add(this.buttonNo);
            this.panelDomandaSiNo.Controls.Add(this.buttonSi);
            this.panelDomandaSiNo.Controls.Add(this.panelDomanda);
            this.panelDomandaSiNo.Location = new System.Drawing.Point(1, 4);
            this.panelDomandaSiNo.Name = "panelDomandaSiNo";
            this.panelDomandaSiNo.Size = new System.Drawing.Size(636, 204);
            this.panelDomandaSiNo.TabIndex = 13;
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNo.Location = new System.Drawing.Point(326, 168);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(2, 18);
            this.labelNo.TabIndex = 6;
            // 
            // labelSi
            // 
            this.labelSi.AutoSize = true;
            this.labelSi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSi.Location = new System.Drawing.Point(61, 168);
            this.labelSi.Name = "labelSi";
            this.labelSi.Size = new System.Drawing.Size(2, 18);
            this.labelSi.TabIndex = 5;
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.Lime;
            this.buttonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNo.Location = new System.Drawing.Point(373, 132);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 4;
            this.buttonNo.Text = "NO";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCalcolaEi
            // 
            this.buttonCalcolaEi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCalcolaEi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCalcolaEi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalcolaEi.Location = new System.Drawing.Point(205, 259);
            this.buttonCalcolaEi.Name = "buttonCalcolaEi";
            this.buttonCalcolaEi.Size = new System.Drawing.Size(132, 21);
            this.buttonCalcolaEi.TabIndex = 8;
            this.buttonCalcolaEi.Text = "CALCOLA Ei";
            this.buttonCalcolaEi.UseVisualStyleBackColor = false;
            this.buttonCalcolaEi.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelStudiParametri
            // 
            this.labelStudiParametri.AutoSize = true;
            this.labelStudiParametri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudiParametri.Location = new System.Drawing.Point(122, 5);
            this.labelStudiParametri.Name = "labelStudiParametri";
            this.labelStudiParametri.Size = new System.Drawing.Size(374, 20);
            this.labelStudiParametri.TabIndex = 3;
            this.labelStudiParametri.Text = "Studi e parametri su cui è basata la decisione";
            // 
            // panelCorpo
            // 
            this.panelCorpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCorpo.Controls.Add(this.labelEcs);
            this.panelCorpo.Controls.Add(this.buttonCalcolaEcs);
            this.panelCorpo.Controls.Add(this.buttonCalcolaEi);
            this.panelCorpo.Controls.Add(this.textBoxCalcolaEcs);
            this.panelCorpo.Controls.Add(this.labelEi);
            this.panelCorpo.Controls.Add(this.textBoxEi);
            this.panelCorpo.Controls.Add(this.linkLabel1);
            this.panelCorpo.Controls.Add(this.label1);
            this.panelCorpo.Controls.Add(this.labelStudiParametri);
            this.panelCorpo.Controls.Add(this.labelIndicatori);
            this.panelCorpo.Location = new System.Drawing.Point(1, 217);
            this.panelCorpo.Name = "panelCorpo";
            this.panelCorpo.Size = new System.Drawing.Size(636, 409);
            this.panelCorpo.TabIndex = 12;
            // 
            // labelEcs
            // 
            this.labelEcs.AutoSize = true;
            this.labelEcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEcs.ForeColor = System.Drawing.Color.Red;
            this.labelEcs.Location = new System.Drawing.Point(351, 377);
            this.labelEcs.Name = "labelEcs";
            this.labelEcs.Size = new System.Drawing.Size(0, 16);
            this.labelEcs.TabIndex = 12;
            // 
            // buttonCalcolaEcs
            // 
            this.buttonCalcolaEcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCalcolaEcs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCalcolaEcs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalcolaEcs.Location = new System.Drawing.Point(205, 372);
            this.buttonCalcolaEcs.Name = "buttonCalcolaEcs";
            this.buttonCalcolaEcs.Size = new System.Drawing.Size(132, 21);
            this.buttonCalcolaEcs.TabIndex = 10;
            this.buttonCalcolaEcs.Text = "CALCOLA Ecs";
            this.buttonCalcolaEcs.UseVisualStyleBackColor = false;
            this.buttonCalcolaEcs.Click += new System.EventHandler(this.buttonCalcolaEcs_Click);
            // 
            // textBoxCalcolaEcs
            // 
            this.textBoxCalcolaEcs.BackColor = System.Drawing.Color.White;
            this.textBoxCalcolaEcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCalcolaEcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalcolaEcs.Location = new System.Drawing.Point(10, 295);
            this.textBoxCalcolaEcs.Name = "textBoxCalcolaEcs";
            this.textBoxCalcolaEcs.Size = new System.Drawing.Size(615, 105);
            this.textBoxCalcolaEcs.TabIndex = 16;
            this.textBoxCalcolaEcs.Text = resources.GetString("textBoxCalcolaEcs.Text");
            // 
            // labelEi
            // 
            this.labelEi.AutoSize = true;
            this.labelEi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEi.ForeColor = System.Drawing.Color.Red;
            this.labelEi.Location = new System.Drawing.Point(351, 264);
            this.labelEi.Name = "labelEi";
            this.labelEi.Size = new System.Drawing.Size(0, 16);
            this.labelEi.TabIndex = 11;
            // 
            // textBoxEi
            // 
            this.textBoxEi.BackColor = System.Drawing.Color.White;
            this.textBoxEi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEi.Location = new System.Drawing.Point(10, 174);
            this.textBoxEi.Name = "textBoxEi";
            this.textBoxEi.Size = new System.Drawing.Size(615, 114);
            this.textBoxEi.TabIndex = 15;
            this.textBoxEi.Text = resources.GetString("textBoxEi.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.linkLabel1.Location = new System.Drawing.Point(16, 127);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(212, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Consulta le misure di conservazione del SIC";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 121);
            this.label1.TabIndex = 14;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Quadro3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 627);
            this.Controls.Add(this.panelDomandaSiNo);
            this.Controls.Add(this.panelCorpo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quadro3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadro3";
            this.panelDomanda.ResumeLayout(false);
            this.panelDomanda.PerformLayout();
            this.panelDomandaSiNo.ResumeLayout(false);
            this.panelDomandaSiNo.PerformLayout();
            this.panelCorpo.ResumeLayout(false);
            this.panelCorpo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSi;
        private System.Windows.Forms.Label labelIndicatori;
        private System.Windows.Forms.Panel panelDomanda;
        private System.Windows.Forms.Label labelDomanda;
        private System.Windows.Forms.Panel panelDomandaSiNo;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonCalcolaEi;
        private System.Windows.Forms.Label labelStudiParametri;
        private System.Windows.Forms.Panel panelCorpo;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelSi;
        private System.Windows.Forms.Button buttonCalcolaEcs;
        private System.Windows.Forms.Label labelEcs;
        private System.Windows.Forms.Label labelEi;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label textBoxEi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textBoxCalcolaEcs;
    }
}