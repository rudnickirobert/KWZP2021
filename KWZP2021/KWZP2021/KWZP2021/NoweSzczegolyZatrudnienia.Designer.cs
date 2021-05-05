
namespace KWZP2021
{
    partial class NoweSzczegolyZatrudnienia
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
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.dataZatrudnienia = new System.Windows.Forms.DateTimePicker();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.buttonZapiszNowegoKlienta = new System.Windows.Forms.Button();
            this.lblNowyKlient = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(156, 54);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(176, 21);
            this.cmbPracownik.TabIndex = 78;
            this.cmbPracownik.SelectedIndexChanged += new System.EventHandler(this.cmbPracownik_SelectedIndexChanged);
            // 
            // dataZatrudnienia
            // 
            this.dataZatrudnienia.Location = new System.Drawing.Point(156, 126);
            this.dataZatrudnienia.Name = "dataZatrudnienia";
            this.dataZatrudnienia.Size = new System.Drawing.Size(176, 20);
            this.dataZatrudnienia.TabIndex = 75;
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(94, 229);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(131, 30);
            this.buttonPowrot.TabIndex = 70;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // buttonZapiszNowegoKlienta
            // 
            this.buttonZapiszNowegoKlienta.Location = new System.Drawing.Point(26, 169);
            this.buttonZapiszNowegoKlienta.Name = "buttonZapiszNowegoKlienta";
            this.buttonZapiszNowegoKlienta.Size = new System.Drawing.Size(285, 45);
            this.buttonZapiszNowegoKlienta.TabIndex = 68;
            this.buttonZapiszNowegoKlienta.Text = "Zapisz";
            this.buttonZapiszNowegoKlienta.UseVisualStyleBackColor = true;
            this.buttonZapiszNowegoKlienta.Click += new System.EventHandler(this.buttonZapiszNowegoKlienta_Click);
            // 
            // lblNowyKlient
            // 
            this.lblNowyKlient.AutoSize = true;
            this.lblNowyKlient.Location = new System.Drawing.Point(166, 15);
            this.lblNowyKlient.Name = "lblNowyKlient";
            this.lblNowyKlient.Size = new System.Drawing.Size(79, 13);
            this.lblNowyKlient.TabIndex = 67;
            this.lblNowyKlient.Text = "Uzupełnij dane";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Data wpisania wynagrodzenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Wynagrodzenie";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Wybierz pracownika";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 79;
            // 
            // NoweSzczegolyZatrudnienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 281);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.dataZatrudnienia);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonZapiszNowegoKlienta);
            this.Controls.Add(this.lblNowyKlient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "NoweSzczegolyZatrudnienia";
            this.Text = "NoweSzczegolyZatrudnienia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbPracownik;
        public System.Windows.Forms.DateTimePicker dataZatrudnienia;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.Button buttonZapiszNowegoKlienta;
        private System.Windows.Forms.Label lblNowyKlient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
    }
}