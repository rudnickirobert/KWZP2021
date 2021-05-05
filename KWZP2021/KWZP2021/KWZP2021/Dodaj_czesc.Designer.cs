
namespace KWZP2021
{
    partial class DodajCzesc
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
            this.btnDodajCzesc = new System.Windows.Forms.Button();
            this.btnAnulujDodanieCzesci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDodajCzescNazwa = new System.Windows.Forms.TextBox();
            this.txtDodajCzescIlosc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDodajCzesc
            // 
            this.btnDodajCzesc.Location = new System.Drawing.Point(60, 228);
            this.btnDodajCzesc.Name = "btnDodajCzesc";
            this.btnDodajCzesc.Size = new System.Drawing.Size(110, 48);
            this.btnDodajCzesc.TabIndex = 0;
            this.btnDodajCzesc.Text = "Dodaj";
            this.btnDodajCzesc.UseVisualStyleBackColor = true;
            this.btnDodajCzesc.Click += new System.EventHandler(this.btnDodajCzesc_Click);
            // 
            // btnAnulujDodanieCzesci
            // 
            this.btnAnulujDodanieCzesci.Location = new System.Drawing.Point(218, 228);
            this.btnAnulujDodanieCzesci.Name = "btnAnulujDodanieCzesci";
            this.btnAnulujDodanieCzesci.Size = new System.Drawing.Size(109, 48);
            this.btnAnulujDodanieCzesci.TabIndex = 1;
            this.btnAnulujDodanieCzesci.Text = "Anuluj";
            this.btnAnulujDodanieCzesci.UseVisualStyleBackColor = true;
            this.btnAnulujDodanieCzesci.Click += new System.EventHandler(this.btnAnulujDodanieCzesci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wpisz nazwę części";
            // 
            // txtDodajCzescNazwa
            // 
            this.txtDodajCzescNazwa.Location = new System.Drawing.Point(227, 95);
            this.txtDodajCzescNazwa.Name = "txtDodajCzescNazwa";
            this.txtDodajCzescNazwa.Size = new System.Drawing.Size(100, 22);
            this.txtDodajCzescNazwa.TabIndex = 3;
            // 
            // txtDodajCzescIlosc
            // 
            this.txtDodajCzescIlosc.Location = new System.Drawing.Point(227, 128);
            this.txtDodajCzescIlosc.Name = "txtDodajCzescIlosc";
            this.txtDodajCzescIlosc.Size = new System.Drawing.Size(100, 22);
            this.txtDodajCzescIlosc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wpisz ilość początkową";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dodawanie nowej części";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wpisz model maszyny";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(227, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // DodajCzesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 302);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDodajCzescIlosc);
            this.Controls.Add(this.txtDodajCzescNazwa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnulujDodanieCzesci);
            this.Controls.Add(this.btnDodajCzesc);
            this.Name = "DodajCzesc";
            this.Text = "Dodawanie części";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajCzesc;
        private System.Windows.Forms.Button btnAnulujDodanieCzesci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDodajCzescNazwa;
        private System.Windows.Forms.TextBox txtDodajCzescIlosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}