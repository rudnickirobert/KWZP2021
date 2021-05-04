
namespace KWZP2021
{
    partial class Szcz_zatrudnienia_2
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
            this.txtWynagrodzenie = new System.Windows.Forms.TextBox();
            this.txtDataZmiany = new System.Windows.Forms.TextBox();
            this.txtNumerUmowy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPracownik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.buttonWyczyscPola = new System.Windows.Forms.Button();
            this.buttonZapiszKonkretnegoKlienta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWynagrodzenie
            // 
            this.txtWynagrodzenie.Location = new System.Drawing.Point(162, 101);
            this.txtWynagrodzenie.Name = "txtWynagrodzenie";
            this.txtWynagrodzenie.Size = new System.Drawing.Size(151, 20);
            this.txtWynagrodzenie.TabIndex = 57;
            // 
            // txtDataZmiany
            // 
            this.txtDataZmiany.Location = new System.Drawing.Point(162, 75);
            this.txtDataZmiany.Name = "txtDataZmiany";
            this.txtDataZmiany.Size = new System.Drawing.Size(151, 20);
            this.txtDataZmiany.TabIndex = 56;
            // 
            // txtNumerUmowy
            // 
            this.txtNumerUmowy.Location = new System.Drawing.Point(162, 47);
            this.txtNumerUmowy.Name = "txtNumerUmowy";
            this.txtNumerUmowy.Size = new System.Drawing.Size(151, 20);
            this.txtNumerUmowy.TabIndex = 55;
            this.txtNumerUmowy.TextChanged += new System.EventHandler(this.txtNumerUmowy_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Podstawa wynagrodzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Data zmiany wynagrodzenia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Numer umowy";
            // 
            // txtPracownik
            // 
            this.txtPracownik.Location = new System.Drawing.Point(162, 20);
            this.txtPracownik.Name = "txtPracownik";
            this.txtPracownik.Size = new System.Drawing.Size(151, 20);
            this.txtPracownik.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Nazwisko pracownika";
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(169, 153);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(144, 30);
            this.buttonPowrot.TabIndex = 76;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // buttonWyczyscPola
            // 
            this.buttonWyczyscPola.Location = new System.Drawing.Point(15, 153);
            this.buttonWyczyscPola.Name = "buttonWyczyscPola";
            this.buttonWyczyscPola.Size = new System.Drawing.Size(129, 30);
            this.buttonWyczyscPola.TabIndex = 75;
            this.buttonWyczyscPola.Text = "Wyczyść pola";
            this.buttonWyczyscPola.UseVisualStyleBackColor = true;
            // 
            // buttonZapiszKonkretnegoKlienta
            // 
            this.buttonZapiszKonkretnegoKlienta.Location = new System.Drawing.Point(15, 199);
            this.buttonZapiszKonkretnegoKlienta.Name = "buttonZapiszKonkretnegoKlienta";
            this.buttonZapiszKonkretnegoKlienta.Size = new System.Drawing.Size(298, 45);
            this.buttonZapiszKonkretnegoKlienta.TabIndex = 74;
            this.buttonZapiszKonkretnegoKlienta.Text = "Zapisz";
            this.buttonZapiszKonkretnegoKlienta.UseVisualStyleBackColor = true;
            // 
            // Szcz_zatrudnienia_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 272);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonWyczyscPola);
            this.Controls.Add(this.buttonZapiszKonkretnegoKlienta);
            this.Controls.Add(this.txtPracownik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWynagrodzenie);
            this.Controls.Add(this.txtDataZmiany);
            this.Controls.Add(this.txtNumerUmowy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Szcz_zatrudnienia_2";
            this.Text = "Szczegóły zatrudnienia danego pracownika";
            this.Load += new System.EventHandler(this.Szcz_zatrudnienia_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtWynagrodzenie;
        public System.Windows.Forms.TextBox txtDataZmiany;
        public System.Windows.Forms.TextBox txtNumerUmowy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPracownik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.Button buttonWyczyscPola;
        private System.Windows.Forms.Button buttonZapiszKonkretnegoKlienta;
    }
}