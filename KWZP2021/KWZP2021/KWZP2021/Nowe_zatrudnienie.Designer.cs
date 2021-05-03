
namespace KWZP2021
{
    partial class Nowe_zatrudnienie
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
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.buttonWyczyscPola = new System.Windows.Forms.Button();
            this.buttonZapiszNowegoKlienta = new System.Windows.Forms.Button();
            this.lblNowyKlient = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStanowisko = new System.Windows.Forms.ComboBox();
            this.cmbDzial = new System.Windows.Forms.ComboBox();
            this.cmbEtat = new System.Windows.Forms.ComboBox();
            this.cmbRodzaj_umowy = new System.Windows.Forms.ComboBox();
            this.dataZatrudnienia = new System.Windows.Forms.DateTimePicker();
            this.dataZwolnienia = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(169, 339);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(131, 30);
            this.buttonPowrot.TabIndex = 48;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // buttonWyczyscPola
            // 
            this.buttonWyczyscPola.Location = new System.Drawing.Point(15, 339);
            this.buttonWyczyscPola.Name = "buttonWyczyscPola";
            this.buttonWyczyscPola.Size = new System.Drawing.Size(116, 30);
            this.buttonWyczyscPola.TabIndex = 47;
            this.buttonWyczyscPola.Text = "Wyczyść pola";
            this.buttonWyczyscPola.UseVisualStyleBackColor = true;
            this.buttonWyczyscPola.Click += new System.EventHandler(this.buttonWyczyscPola_Click);
            // 
            // buttonZapiszNowegoKlienta
            // 
            this.buttonZapiszNowegoKlienta.Location = new System.Drawing.Point(15, 385);
            this.buttonZapiszNowegoKlienta.Name = "buttonZapiszNowegoKlienta";
            this.buttonZapiszNowegoKlienta.Size = new System.Drawing.Size(285, 45);
            this.buttonZapiszNowegoKlienta.TabIndex = 46;
            this.buttonZapiszNowegoKlienta.Text = "Zapisz";
            this.buttonZapiszNowegoKlienta.UseVisualStyleBackColor = true;
            this.buttonZapiszNowegoKlienta.Click += new System.EventHandler(this.buttonZapiszNowegoKlienta_Click);
            // 
            // lblNowyKlient
            // 
            this.lblNowyKlient.AutoSize = true;
            this.lblNowyKlient.Location = new System.Drawing.Point(166, 9);
            this.lblNowyKlient.Name = "lblNowyKlient";
            this.lblNowyKlient.Size = new System.Drawing.Size(79, 13);
            this.lblNowyKlient.TabIndex = 45;
            this.lblNowyKlient.Text = "Uzupełnij dane";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Data zwolnienia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Data zatrudnienia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Wybierz rodzaj umowy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Wybierz rodzaj etatu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Wybierz dział";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Wybierz stanowisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dodaj pracownika";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbStanowisko
            // 
            this.cmbStanowisko.FormattingEnabled = true;
            this.cmbStanowisko.Location = new System.Drawing.Point(155, 122);
            this.cmbStanowisko.Name = "cmbStanowisko";
            this.cmbStanowisko.Size = new System.Drawing.Size(177, 21);
            this.cmbStanowisko.TabIndex = 50;
            // 
            // cmbDzial
            // 
            this.cmbDzial.FormattingEnabled = true;
            this.cmbDzial.Location = new System.Drawing.Point(155, 151);
            this.cmbDzial.Name = "cmbDzial";
            this.cmbDzial.Size = new System.Drawing.Size(177, 21);
            this.cmbDzial.TabIndex = 51;
            // 
            // cmbEtat
            // 
            this.cmbEtat.FormattingEnabled = true;
            this.cmbEtat.Location = new System.Drawing.Point(155, 178);
            this.cmbEtat.Name = "cmbEtat";
            this.cmbEtat.Size = new System.Drawing.Size(177, 21);
            this.cmbEtat.TabIndex = 52;
            // 
            // cmbRodzaj_umowy
            // 
            this.cmbRodzaj_umowy.FormattingEnabled = true;
            this.cmbRodzaj_umowy.Location = new System.Drawing.Point(155, 205);
            this.cmbRodzaj_umowy.Name = "cmbRodzaj_umowy";
            this.cmbRodzaj_umowy.Size = new System.Drawing.Size(177, 21);
            this.cmbRodzaj_umowy.TabIndex = 53;
            // 
            // dataZatrudnienia
            // 
            this.dataZatrudnienia.Location = new System.Drawing.Point(155, 232);
            this.dataZatrudnienia.Name = "dataZatrudnienia";
            this.dataZatrudnienia.Size = new System.Drawing.Size(176, 20);
            this.dataZatrudnienia.TabIndex = 54;
            // 
            // dataZwolnienia
            // 
            this.dataZwolnienia.Location = new System.Drawing.Point(155, 261);
            this.dataZwolnienia.Name = "dataZwolnienia";
            this.dataZwolnienia.Size = new System.Drawing.Size(175, 20);
            this.dataZwolnienia.TabIndex = 55;
            this.dataZwolnienia.Value = new System.DateTime(2021, 5, 3, 18, 37, 41, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 29);
            this.button1.TabIndex = 56;
            this.button1.Text = "Dodaj pracownika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 57;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 58;
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(368, 45);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(206, 21);
            this.cmbPracownik.TabIndex = 59;
            // 
            // Nowe_zatrudnienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataZwolnienia);
            this.Controls.Add(this.dataZatrudnienia);
            this.Controls.Add(this.cmbRodzaj_umowy);
            this.Controls.Add(this.cmbEtat);
            this.Controls.Add(this.cmbDzial);
            this.Controls.Add(this.cmbStanowisko);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonWyczyscPola);
            this.Controls.Add(this.buttonZapiszNowegoKlienta);
            this.Controls.Add(this.lblNowyKlient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nowe_zatrudnienie";
            this.Text = "Nowe_zatrudnienie";
            this.Load += new System.EventHandler(this.Nowe_zatrudnienie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.Button buttonWyczyscPola;
        private System.Windows.Forms.Button buttonZapiszNowegoKlienta;
        private System.Windows.Forms.Label lblNowyKlient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dataZatrudnienia;
        public System.Windows.Forms.DateTimePicker dataZwolnienia;
        public System.Windows.Forms.ComboBox cmbStanowisko;
        public System.Windows.Forms.ComboBox cmbDzial;
        public System.Windows.Forms.ComboBox cmbEtat;
        public System.Windows.Forms.ComboBox cmbRodzaj_umowy;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbPracownik;
    }
}