
namespace KWZP2021
{
    partial class Dodaj_zuzyte_narzedzie
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
            this.btnDodajZuzyteNarzedzieDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDodajZuzyteNarzedziePowrot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajZuzyteNarzedzieDodaj
            // 
            this.btnDodajZuzyteNarzedzieDodaj.Location = new System.Drawing.Point(73, 215);
            this.btnDodajZuzyteNarzedzieDodaj.Name = "btnDodajZuzyteNarzedzieDodaj";
            this.btnDodajZuzyteNarzedzieDodaj.Size = new System.Drawing.Size(116, 44);
            this.btnDodajZuzyteNarzedzieDodaj.TabIndex = 0;
            this.btnDodajZuzyteNarzedzieDodaj.Text = "Dodaj zużyte narzędzie";
            this.btnDodajZuzyteNarzedzieDodaj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz narzędzie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wprowadź datę zużycia";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnDodajZuzyteNarzedziePowrot
            // 
            this.btnDodajZuzyteNarzedziePowrot.Location = new System.Drawing.Point(309, 215);
            this.btnDodajZuzyteNarzedziePowrot.Name = "btnDodajZuzyteNarzedziePowrot";
            this.btnDodajZuzyteNarzedziePowrot.Size = new System.Drawing.Size(112, 44);
            this.btnDodajZuzyteNarzedziePowrot.TabIndex = 6;
            this.btnDodajZuzyteNarzedziePowrot.Text = "Powrót";
            this.btnDodajZuzyteNarzedziePowrot.UseVisualStyleBackColor = true;
            this.btnDodajZuzyteNarzedziePowrot.Click += new System.EventHandler(this.btnDodajZuzyteNarzedziePowrot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wprowadzanie zużytego narzędzia\r\n";
            // 
            // Dodaj_zuzyte_narzedzie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 291);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodajZuzyteNarzedziePowrot);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajZuzyteNarzedzieDodaj);
            this.Name = "Dodaj_zuzyte_narzedzie";
            this.Text = "Dodawanie zużytego narzędzia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajZuzyteNarzedzieDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDodajZuzyteNarzedziePowrot;
        private System.Windows.Forms.Label label3;
    }
}