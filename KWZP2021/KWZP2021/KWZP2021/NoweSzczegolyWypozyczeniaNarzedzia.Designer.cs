
namespace KWZP2021
{
    partial class NoweSzczegolyWypozyczeniaNarzedzia
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CmbNazwa = new System.Windows.Forms.ComboBox();
            this.cmbNumer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dodaj narzędzie do wypożyczenia";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa narzędzia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ilość";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edytuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Powrót";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CmbNazwa
            // 
            this.CmbNazwa.FormattingEnabled = true;
            this.CmbNazwa.Location = new System.Drawing.Point(177, 78);
            this.CmbNazwa.Name = "CmbNazwa";
            this.CmbNazwa.Size = new System.Drawing.Size(171, 24);
            this.CmbNazwa.TabIndex = 7;
            // 
            // cmbNumer
            // 
            this.cmbNumer.FormattingEnabled = true;
            this.cmbNumer.Location = new System.Drawing.Point(177, 48);
            this.cmbNumer.Name = "cmbNumer";
            this.cmbNumer.Size = new System.Drawing.Size(171, 24);
            this.cmbNumer.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numer wypożyczenia";
            // 
            // NoweSzczegolyWypozyczeniaNarzedzia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 226);
            this.Controls.Add(this.cmbNumer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbNazwa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "NoweSzczegolyWypozyczeniaNarzedzia";
            this.Text = "NoweSzczegolyWypozyczeniaNarzedzia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CmbNazwa;
        private System.Windows.Forms.ComboBox cmbNumer;
        private System.Windows.Forms.Label label4;
    }
}