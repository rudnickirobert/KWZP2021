namespace KWZP2021
{
    partial class Dodaj_zamowienie_klienta
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
            this.lblNowyKlient = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_nazwa_firmy = new System.Windows.Forms.ComboBox();
            this.comboBox2_Pracownik = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1_Data_zam = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2_oczekiwany_termin = new System.Windows.Forms.DateTimePicker();
            this.button1_Zapisz = new System.Windows.Forms.Button();
            this.button2_Powrot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNowyKlient
            // 
            this.lblNowyKlient.AutoSize = true;
            this.lblNowyKlient.Location = new System.Drawing.Point(220, 18);
            this.lblNowyKlient.Name = "lblNowyKlient";
            this.lblNowyKlient.Size = new System.Drawing.Size(79, 13);
            this.lblNowyKlient.TabIndex = 22;
            this.lblNowyKlient.Text = "Uzupełnij dane";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Oczekiwany termin wykonania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data zamówienia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pracownik przyjmujący zamówienie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nazwa firmy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1_nazwa_firmy
            // 
            this.comboBox1_nazwa_firmy.FormattingEnabled = true;
            this.comboBox1_nazwa_firmy.Location = new System.Drawing.Point(223, 62);
            this.comboBox1_nazwa_firmy.Name = "comboBox1_nazwa_firmy";
            this.comboBox1_nazwa_firmy.Size = new System.Drawing.Size(190, 21);
            this.comboBox1_nazwa_firmy.TabIndex = 27;
            // 
            // comboBox2_Pracownik
            // 
            this.comboBox2_Pracownik.FormattingEnabled = true;
            this.comboBox2_Pracownik.Location = new System.Drawing.Point(223, 89);
            this.comboBox2_Pracownik.Name = "comboBox2_Pracownik";
            this.comboBox2_Pracownik.Size = new System.Drawing.Size(190, 21);
            this.comboBox2_Pracownik.TabIndex = 28;
            // 
            // dateTimePicker1_Data_zam
            // 
            this.dateTimePicker1_Data_zam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_Data_zam.Location = new System.Drawing.Point(223, 116);
            this.dateTimePicker1_Data_zam.Name = "dateTimePicker1_Data_zam";
            this.dateTimePicker1_Data_zam.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1_Data_zam.TabIndex = 29;
            // 
            // dateTimePicker2_oczekiwany_termin
            // 
            this.dateTimePicker2_oczekiwany_termin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2_oczekiwany_termin.Location = new System.Drawing.Point(223, 142);
            this.dateTimePicker2_oczekiwany_termin.Name = "dateTimePicker2_oczekiwany_termin";
            this.dateTimePicker2_oczekiwany_termin.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2_oczekiwany_termin.TabIndex = 30;
            // 
            // button1_Zapisz
            // 
            this.button1_Zapisz.Location = new System.Drawing.Point(12, 181);
            this.button1_Zapisz.Name = "button1_Zapisz";
            this.button1_Zapisz.Size = new System.Drawing.Size(75, 23);
            this.button1_Zapisz.TabIndex = 31;
            this.button1_Zapisz.Text = "Zapisz";
            this.button1_Zapisz.UseVisualStyleBackColor = true;
            this.button1_Zapisz.Click += new System.EventHandler(this.button1_Zapisz_Click);
            // 
            // button2_Powrot
            // 
            this.button2_Powrot.Location = new System.Drawing.Point(338, 181);
            this.button2_Powrot.Name = "button2_Powrot";
            this.button2_Powrot.Size = new System.Drawing.Size(75, 23);
            this.button2_Powrot.TabIndex = 32;
            this.button2_Powrot.Text = "Powrót";
            this.button2_Powrot.UseVisualStyleBackColor = true;
            this.button2_Powrot.Click += new System.EventHandler(this.button2_Powrot_Click);
            // 
            // Dodaj_zamowienie_klienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 214);
            this.Controls.Add(this.button2_Powrot);
            this.Controls.Add(this.button1_Zapisz);
            this.Controls.Add(this.dateTimePicker2_oczekiwany_termin);
            this.Controls.Add(this.dateTimePicker1_Data_zam);
            this.Controls.Add(this.comboBox2_Pracownik);
            this.Controls.Add(this.comboBox1_nazwa_firmy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNowyKlient);
            this.Name = "Dodaj_zamowienie_klienta";
            this.Text = "Dodaj zamówienie klienta";
            this.Load += new System.EventHandler(this.Dodaj_zamowienie_klienta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNowyKlient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_nazwa_firmy;
        private System.Windows.Forms.ComboBox comboBox2_Pracownik;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_Data_zam;
        private System.Windows.Forms.DateTimePicker dateTimePicker2_oczekiwany_termin;
        private System.Windows.Forms.Button button1_Zapisz;
        private System.Windows.Forms.Button button2_Powrot;
    }
}