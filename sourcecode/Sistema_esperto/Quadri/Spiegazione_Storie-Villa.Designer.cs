namespace Sistema_esperto.Quadri
{
    partial class Spiegazione_Storie_Villa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spiegazione_Storie_Villa));
            this.labelSpiegazioneVilla1 = new System.Windows.Forms.Label();
            this.pictureBoxStorieVilla = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStorieVilla)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSpiegazioneVilla1
            // 
            this.labelSpiegazioneVilla1.AutoSize = true;
            this.labelSpiegazioneVilla1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpiegazioneVilla1.Location = new System.Drawing.Point(12, 22);
            this.labelSpiegazioneVilla1.Name = "labelSpiegazioneVilla1";
            this.labelSpiegazioneVilla1.Size = new System.Drawing.Size(374, 144);
            this.labelSpiegazioneVilla1.TabIndex = 0;
            this.labelSpiegazioneVilla1.Text = resources.GetString("labelSpiegazioneVilla1.Text");
            this.labelSpiegazioneVilla1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxStorieVilla
            // 
            this.pictureBoxStorieVilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStorieVilla.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStorieVilla.Image")));
            this.pictureBoxStorieVilla.Location = new System.Drawing.Point(15, 149);
            this.pictureBoxStorieVilla.Name = "pictureBoxStorieVilla";
            this.pictureBoxStorieVilla.Size = new System.Drawing.Size(341, 70);
            this.pictureBoxStorieVilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStorieVilla.TabIndex = 1;
            this.pictureBoxStorieVilla.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 96);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(387, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "CHIUDI";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Spiegazione_Storie_Villa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxStorieVilla);
            this.Controls.Add(this.labelSpiegazioneVilla1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spiegazione_Storie_Villa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Formula di Storie-Villa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStorieVilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpiegazioneVilla1;
        private System.Windows.Forms.PictureBox pictureBoxStorieVilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}