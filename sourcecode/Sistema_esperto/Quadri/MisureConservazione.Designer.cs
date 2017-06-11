namespace Sistema_esperto.Quadri
{
    partial class MisureConservazione
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisureConservazione));
            this.labelConsulta = new System.Windows.Forms.Label();
            this.labelConsultaSigle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSigle = new System.Windows.Forms.ComboBox();
            this.misureDataSet = new Sistema_esperto.misureDataSet();
            this.comboBoxNome = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonApriNome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.misureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.misureTableAdapter = new Sistema_esperto.misureDataSetTableAdapters.misureTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.misureDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.misureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConsulta
            // 
            this.labelConsulta.AutoSize = true;
            this.labelConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsulta.Location = new System.Drawing.Point(30, 9);
            this.labelConsulta.Name = "labelConsulta";
            this.labelConsulta.Size = new System.Drawing.Size(525, 24);
            this.labelConsulta.TabIndex = 0;
            this.labelConsulta.Text = "CONSULTA LE  MISURE DI CONSERVAZIONE DEI SIC";
            // 
            // labelConsultaSigle
            // 
            this.labelConsultaSigle.AutoSize = true;
            this.labelConsultaSigle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaSigle.Location = new System.Drawing.Point(12, 16);
            this.labelConsultaSigle.Name = "labelConsultaSigle";
            this.labelConsultaSigle.Size = new System.Drawing.Size(157, 13);
            this.labelConsultaSigle.TabIndex = 1;
            this.labelConsultaSigle.Text = "SCELTA PER CODICE SIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCELTA PER NOME SIC";
            // 
            // comboBoxSigle
            // 
            this.comboBoxSigle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxSigle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSigle.DataSource = this.misureDataSet;
            this.comboBoxSigle.DisplayMember = "misure.SIGLA";
            this.comboBoxSigle.FormattingEnabled = true;
            this.comboBoxSigle.Location = new System.Drawing.Point(15, 39);
            this.comboBoxSigle.Name = "comboBoxSigle";
            this.comboBoxSigle.Size = new System.Drawing.Size(133, 21);
            this.comboBoxSigle.TabIndex = 3;
            this.comboBoxSigle.ValueMember = "misure.URL";
            // 
            // misureDataSet
            // 
            this.misureDataSet.DataSetName = "misureDataSet";
            this.misureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxNome
            // 
            this.comboBoxNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNome.DataSource = this.misureDataSet;
            this.comboBoxNome.DisplayMember = "misure.SIC";
            this.comboBoxNome.FormattingEnabled = true;
            this.comboBoxNome.Location = new System.Drawing.Point(184, 39);
            this.comboBoxNome.Name = "comboBoxNome";
            this.comboBoxNome.Size = new System.Drawing.Size(257, 21);
            this.comboBoxNome.TabIndex = 4;
            this.comboBoxNome.ValueMember = "misure.URL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHelp);
            this.groupBox1.Controls.Add(this.buttonApriNome);
            this.groupBox1.Controls.Add(this.comboBoxNome);
            this.groupBox1.Controls.Add(this.comboBoxSigle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelConsultaSigle);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(539, 10);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(27, 24);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonApriNome
            // 
            this.buttonApriNome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonApriNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApriNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApriNome.Location = new System.Drawing.Point(462, 40);
            this.buttonApriNome.Name = "buttonApriNome";
            this.buttonApriNome.Size = new System.Drawing.Size(51, 20);
            this.buttonApriNome.TabIndex = 5;
            this.buttonApriNome.Text = "APRI";
            this.buttonApriNome.UseVisualStyleBackColor = false;
            this.buttonApriNome.Click += new System.EventHandler(this.buttonApriNome_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "LEGENDA TABELLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // misureBindingSource
            // 
            this.misureBindingSource.DataMember = "misure";
            this.misureBindingSource.DataSource = this.misureDataSet;
            // 
            // misureTableAdapter
            // 
            this.misureTableAdapter.ClearBeforeFill = true;
            // 
            // MisureConservazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 158);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MisureConservazione";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Misure di conservazione";
            this.Load += new System.EventHandler(this.MisureConservazione_Load);
            ((System.ComponentModel.ISupportInitialize)(this.misureDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.misureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConsulta;
        private System.Windows.Forms.Label labelConsultaSigle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSigle;
        private System.Windows.Forms.ComboBox comboBoxNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonApriNome;
        private System.Windows.Forms.Button button1;
        private misureDataSet misureDataSet;
        private System.Windows.Forms.BindingSource misureBindingSource;
        private Sistema_esperto.misureDataSetTableAdapters.misureTableAdapter misureTableAdapter;
        private System.Windows.Forms.Button buttonHelp;
    }
}