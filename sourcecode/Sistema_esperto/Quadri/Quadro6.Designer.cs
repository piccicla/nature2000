namespace Sistema_esperto.Quadri
{
    partial class Quadro6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quadro6));
            this.labelNo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAnnullaValMax = new System.Windows.Forms.Button();
            this.labelValoreMassimo = new System.Windows.Forms.Label();
            this.labelPs = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelSi = new System.Windows.Forms.Label();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonSi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNo
            // 
            this.labelNo.AutoSize = true;
            this.labelNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNo.Location = new System.Drawing.Point(383, 128);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(2, 15);
            this.labelNo.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonAnnullaValMax);
            this.panel3.Controls.Add(this.labelValoreMassimo);
            this.panel3.Controls.Add(this.labelPs);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(1, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 239);
            this.panel3.TabIndex = 14;
            // 
            // buttonAnnullaValMax
            // 
            this.buttonAnnullaValMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnnullaValMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnullaValMax.Location = new System.Drawing.Point(478, 203);
            this.buttonAnnullaValMax.Name = "buttonAnnullaValMax";
            this.buttonAnnullaValMax.Size = new System.Drawing.Size(137, 20);
            this.buttonAnnullaValMax.TabIndex = 11;
            this.buttonAnnullaValMax.Text = "annulla valore massimo";
            this.buttonAnnullaValMax.UseVisualStyleBackColor = true;
            this.buttonAnnullaValMax.Visible = false;
            this.buttonAnnullaValMax.Click += new System.EventHandler(this.buttonAnnullaValMax_Click);
            // 
            // labelValoreMassimo
            // 
            this.labelValoreMassimo.AutoSize = true;
            this.labelValoreMassimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValoreMassimo.ForeColor = System.Drawing.Color.Red;
            this.labelValoreMassimo.Location = new System.Drawing.Point(243, 205);
            this.labelValoreMassimo.Name = "labelValoreMassimo";
            this.labelValoreMassimo.Size = new System.Drawing.Size(197, 16);
            this.labelValoreMassimo.TabIndex = 10;
            this.labelValoreMassimo.Text = "Valore massimo riscontrato";
            this.labelValoreMassimo.Visible = false;
            // 
            // labelPs
            // 
            this.labelPs.AutoSize = true;
            this.labelPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPs.ForeColor = System.Drawing.Color.Red;
            this.labelPs.Location = new System.Drawing.Point(174, 205);
            this.labelPs.Name = "labelPs";
            this.labelPs.Size = new System.Drawing.Size(0, 15);
            this.labelPs.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(25, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 21);
            this.button3.TabIndex = 8;
            this.button3.Text = "CALCOLA Ps";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Studi e parametri su cui è basata la decisione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Determinazione degli indicatori";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelNo);
            this.panel4.Controls.Add(this.labelSi);
            this.panel4.Controls.Add(this.buttonNo);
            this.panel4.Controls.Add(this.buttonSi);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(1, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 157);
            this.panel4.TabIndex = 15;
            // 
            // labelSi
            // 
            this.labelSi.AutoSize = true;
            this.labelSi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSi.Location = new System.Drawing.Point(136, 128);
            this.labelSi.Name = "labelSi";
            this.labelSi.Size = new System.Drawing.Size(2, 15);
            this.labelSi.TabIndex = 5;
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.Lime;
            this.buttonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonNo.Location = new System.Drawing.Point(401, 94);
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
            this.buttonSi.Enabled = false;
            this.buttonSi.Location = new System.Drawing.Point(153, 94);
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
            this.panel1.Size = new System.Drawing.Size(612, 80);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Viene intaccata possibilità di permanenza della \r\nspecie nel paesaggio ecologico " +
                "di sua pertinenza ? \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(618, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "ampiezza e frammentazione dell\'habitat idoneo; presenza e numero di corridoi-step" +
                "ping stones";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(618, 133);
            this.label3.TabIndex = 13;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Quadro6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 408);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quadro6";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadro6";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelSi;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonSi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPs;
        private System.Windows.Forms.Label labelValoreMassimo;
        private System.Windows.Forms.Button buttonAnnullaValMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}