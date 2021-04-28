
namespace KWZP2021
{
    partial class Czynnosci_do_Procesu
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_add_czynnosc = new System.Windows.Forms.Button();
            this.btn_del_czynnosc = new System.Windows.Forms.Button();
            this.GDV_czynnosci = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_akt = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GDV_czynnosci)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 411);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btn_add_czynnosc
            // 
            this.btn_add_czynnosc.Location = new System.Drawing.Point(286, 49);
            this.btn_add_czynnosc.Name = "btn_add_czynnosc";
            this.btn_add_czynnosc.Size = new System.Drawing.Size(106, 20);
            this.btn_add_czynnosc.TabIndex = 1;
            this.btn_add_czynnosc.Text = "Dodaj";
            this.btn_add_czynnosc.UseVisualStyleBackColor = true;
            // 
            // btn_del_czynnosc
            // 
            this.btn_del_czynnosc.Location = new System.Drawing.Point(620, 50);
            this.btn_del_czynnosc.Name = "btn_del_czynnosc";
            this.btn_del_czynnosc.Size = new System.Drawing.Size(106, 20);
            this.btn_del_czynnosc.TabIndex = 2;
            this.btn_del_czynnosc.Text = "Usuń";
            this.btn_del_czynnosc.UseVisualStyleBackColor = true;
            this.btn_del_czynnosc.Click += new System.EventHandler(this.btn_add_czynnosc_Click);
            // 
            // GDV_czynnosci
            // 
            this.GDV_czynnosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDV_czynnosci.Location = new System.Drawing.Point(36, 88);
            this.GDV_czynnosci.Name = "GDV_czynnosci";
            this.GDV_czynnosci.Size = new System.Drawing.Size(689, 285);
            this.GDV_czynnosci.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dodaj firmę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuń firmę";
            // 
            // btn_akt
            // 
            this.btn_akt.Location = new System.Drawing.Point(587, 411);
            this.btn_akt.Name = "btn_akt";
            this.btn_akt.Size = new System.Drawing.Size(138, 24);
            this.btn_akt.TabIndex = 6;
            this.btn_akt.Text = "Aktualizuj zmianę";
            this.btn_akt.UseVisualStyleBackColor = true;
            this.btn_akt.Click += new System.EventHandler(this.btn_akt_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(406, 411);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(138, 24);
            this.btnrefresh.TabIndex = 7;
            this.btnrefresh.Text = "Odśwież formularz";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Czynnosci_do_Procesu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btn_akt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GDV_czynnosci);
            this.Controls.Add(this.btn_del_czynnosc);
            this.Controls.Add(this.btn_add_czynnosc);
            this.Controls.Add(this.comboBox1);
            this.Name = "Czynnosci_do_Procesu";
            this.Text = "Rodzaj_czynnosci";
            ((System.ComponentModel.ISupportInitialize)(this.GDV_czynnosci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_add_czynnosc;
        private System.Windows.Forms.Button btn_del_czynnosc;
        private System.Windows.Forms.DataGridView GDV_czynnosci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_akt;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.TextBox textBox1;
    }
}