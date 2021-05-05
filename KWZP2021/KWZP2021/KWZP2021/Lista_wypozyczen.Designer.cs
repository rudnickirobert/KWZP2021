
namespace KWZP2021
{
    partial class Lista_wypozyczen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvWypozyczenia = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3Dodanie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWypozyczenia)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wyszukaj część";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvWypozyczenia
            // 
            this.dgvWypozyczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWypozyczenia.Location = new System.Drawing.Point(12, 103);
            this.dgvWypozyczenia.Name = "dgvWypozyczenia";
            this.dgvWypozyczenia.RowHeadersWidth = 51;
            this.dgvWypozyczenia.RowTemplate.Height = 24;
            this.dgvWypozyczenia.Size = new System.Drawing.Size(762, 310);
            this.dgvWypozyczenia.TabIndex = 3;
            this.dgvWypozyczenia.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvWypozyczenia_CellMouseDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3Dodanie
            // 
            this.button3Dodanie.Location = new System.Drawing.Point(455, 12);
            this.button3Dodanie.Name = "button3Dodanie";
            this.button3Dodanie.Size = new System.Drawing.Size(147, 62);
            this.button3Dodanie.TabIndex = 5;
            this.button3Dodanie.Text = "Dodaj część do wypożyczenia\r\n";
            this.button3Dodanie.UseVisualStyleBackColor = true;
            this.button3Dodanie.Click += new System.EventHandler(this.button3Dodanie_Click);
            // 
            // Lista_wypozyczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 425);
            this.Controls.Add(this.button3Dodanie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvWypozyczenia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Lista_wypozyczen";
            this.Text = "Lista wypożyczeń";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWypozyczenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgvWypozyczenia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3Dodanie;
    }
}