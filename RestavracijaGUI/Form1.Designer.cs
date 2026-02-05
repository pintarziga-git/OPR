namespace RestavracijaGUI
{
    partial class Form1
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
            this.listBoxMeni = new System.Windows.Forms.ListBox();
            this.listBoxNarocilo = new System.Windows.Forms.ListBox();
            this.comboBoxMiza = new System.Windows.Forms.ComboBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonOdstrani = new System.Windows.Forms.Button();
            this.buttonZakljuciRacun = new System.Windows.Forms.Button();
            this.buttonNovoNarocilo = new System.Windows.Forms.Button();
            this.labelSkupaj = new System.Windows.Forms.Label();
            this.labelZDDV = new System.Windows.Forms.Label();
            this.labelRacun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxMeni
            // 
            this.listBoxMeni.FormattingEnabled = true;
            this.listBoxMeni.Location = new System.Drawing.Point(28, 57);
            this.listBoxMeni.Name = "listBoxMeni";
            this.listBoxMeni.Size = new System.Drawing.Size(144, 95);
            this.listBoxMeni.TabIndex = 0;
            // 
            // listBoxNarocilo
            // 
            this.listBoxNarocilo.FormattingEnabled = true;
            this.listBoxNarocilo.Location = new System.Drawing.Point(28, 202);
            this.listBoxNarocilo.Name = "listBoxNarocilo";
            this.listBoxNarocilo.Size = new System.Drawing.Size(144, 95);
            this.listBoxNarocilo.TabIndex = 1;
            // 
            // comboBoxMiza
            // 
            this.comboBoxMiza.FormattingEnabled = true;
            this.comboBoxMiza.Location = new System.Drawing.Point(39, 328);
            this.comboBoxMiza.Name = "comboBoxMiza";
            this.comboBoxMiza.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMiza.TabIndex = 2;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(242, 74);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(103, 23);
            this.buttonDodaj.TabIndex = 3;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonOdstrani
            // 
            this.buttonOdstrani.Location = new System.Drawing.Point(242, 119);
            this.buttonOdstrani.Name = "buttonOdstrani";
            this.buttonOdstrani.Size = new System.Drawing.Size(103, 23);
            this.buttonOdstrani.TabIndex = 4;
            this.buttonOdstrani.Text = "Odstrani";
            this.buttonOdstrani.UseVisualStyleBackColor = true;
            this.buttonOdstrani.Click += new System.EventHandler(this.buttonOdstrani_Click);
            // 
            // buttonZakljuciRacun
            // 
            this.buttonZakljuciRacun.Location = new System.Drawing.Point(242, 219);
            this.buttonZakljuciRacun.Name = "buttonZakljuciRacun";
            this.buttonZakljuciRacun.Size = new System.Drawing.Size(103, 23);
            this.buttonZakljuciRacun.TabIndex = 5;
            this.buttonZakljuciRacun.Text = "Zaključi račun";
            this.buttonZakljuciRacun.UseVisualStyleBackColor = true;
            this.buttonZakljuciRacun.Click += new System.EventHandler(this.buttonZakljuciRacun_Click);
            // 
            // buttonNovoNarocilo
            // 
            this.buttonNovoNarocilo.Location = new System.Drawing.Point(242, 260);
            this.buttonNovoNarocilo.Name = "buttonNovoNarocilo";
            this.buttonNovoNarocilo.Size = new System.Drawing.Size(103, 23);
            this.buttonNovoNarocilo.TabIndex = 6;
            this.buttonNovoNarocilo.Text = "Novo naročilo";
            this.buttonNovoNarocilo.UseVisualStyleBackColor = true;
            this.buttonNovoNarocilo.Click += new System.EventHandler(this.buttonNovoNarocilo_Click);
            // 
            // labelSkupaj
            // 
            this.labelSkupaj.AutoSize = true;
            this.labelSkupaj.Location = new System.Drawing.Point(432, 129);
            this.labelSkupaj.Name = "labelSkupaj";
            this.labelSkupaj.Size = new System.Drawing.Size(35, 13);
            this.labelSkupaj.TabIndex = 7;
            this.labelSkupaj.Text = "label1";
            // 
            // labelZDDV
            // 
            this.labelZDDV.AutoSize = true;
            this.labelZDDV.Location = new System.Drawing.Point(432, 164);
            this.labelZDDV.Name = "labelZDDV";
            this.labelZDDV.Size = new System.Drawing.Size(35, 13);
            this.labelZDDV.TabIndex = 8;
            this.labelZDDV.Text = "label2";
            // 
            // labelRacun
            // 
            this.labelRacun.AutoSize = true;
            this.labelRacun.Location = new System.Drawing.Point(432, 229);
            this.labelRacun.Name = "labelRacun";
            this.labelRacun.Size = new System.Drawing.Size(35, 13);
            this.labelRacun.TabIndex = 9;
            this.labelRacun.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 391);
            this.Controls.Add(this.labelRacun);
            this.Controls.Add(this.labelZDDV);
            this.Controls.Add(this.labelSkupaj);
            this.Controls.Add(this.buttonNovoNarocilo);
            this.Controls.Add(this.buttonZakljuciRacun);
            this.Controls.Add(this.buttonOdstrani);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.comboBoxMiza);
            this.Controls.Add(this.listBoxNarocilo);
            this.Controls.Add(this.listBoxMeni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMeni;
        private System.Windows.Forms.ListBox listBoxNarocilo;
        private System.Windows.Forms.ComboBox comboBoxMiza;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonOdstrani;
        private System.Windows.Forms.Button buttonZakljuciRacun;
        private System.Windows.Forms.Button buttonNovoNarocilo;
        private System.Windows.Forms.Label labelSkupaj;
        private System.Windows.Forms.Label labelZDDV;
        private System.Windows.Forms.Label labelRacun;
    }
}

