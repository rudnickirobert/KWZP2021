
namespace KWZP2021
{
    partial class Zuzyte_narzedzie
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
            this.btnDodajZuzyteNarzedzia = new System.Windows.Forms.Button();
            this.btnZuzyteNarzedziaPowrot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZuzyteNarzedziaWyszukaj = new System.Windows.Forms.TextBox();
            this.dgvZuzyteNarzedzia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZuzyteNarzedzia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajZuzyteNarzedzia
            // 
            this.btnDodajZuzyteNarzedzia.Location = new System.Drawing.Point(577, 66);
            this.btnDodajZuzyteNarzedzia.Name = "btnDodajZuzyteNarzedzia";
            this.btnDodajZuzyteNarzedzia.Size = new System.Drawing.Size(158, 50);
            this.btnDodajZuzyteNarzedzia.TabIndex = 0;
            this.btnDodajZuzyteNarzedzia.Text = "Dodaj zużyte narzędzie";
            this.btnDodajZuzyteNarzedzia.UseVisualStyleBackColor = true;
            this.btnDodajZuzyteNarzedzia.Click += new System.EventHandler(this.btnDodajZuzyteNarzedzia_Click);
            // 
            // btnZuzyteNarzedziaPowrot
            // 
            this.btnZuzyteNarzedziaPowrot.Location = new System.Drawing.Point(602, 238);
            this.btnZuzyteNarzedziaPowrot.Name = "btnZuzyteNarzedziaPowrot";
            this.btnZuzyteNarzedziaPowrot.Size = new System.Drawing.Size(122, 37);
            this.btnZuzyteNarzedziaPowrot.TabIndex = 1;
            this.btnZuzyteNarzedziaPowrot.Text = "Powrót";
            this.btnZuzyteNarzedziaPowrot.UseVisualStyleBackColor = true;
            this.btnZuzyteNarzedziaPowrot.Click += new System.EventHandler(this.btnZuzyteNarzedziaPowrot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wyszukaj zużyte narzędzie\r\n";
            // 
            // txtZuzyteNarzedziaWyszukaj
            // 
            this.txtZuzyteNarzedziaWyszukaj.Location = new System.Drawing.Point(48, 29);
            this.txtZuzyteNarzedziaWyszukaj.Name = "txtZuzyteNarzedziaWyszukaj";
            this.txtZuzyteNarzedziaWyszukaj.Size = new System.Drawing.Size(100, 22);
            this.txtZuzyteNarzedziaWyszukaj.TabIndex = 3;
            this.txtZuzyteNarzedziaWyszukaj.TextChanged += new System.EventHandler(this.txtZuzyteNarzedziaWyszukaj_TextChanged);
            // 
            // dgvZuzyteNarzedzia
            // 
            this.dgvZuzyteNarzedzia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZuzyteNarzedzia.Location = new System.Drawing.Point(12, 66);
            this.dgvZuzyteNarzedzia.Name = "dgvZuzyteNarzedzia";
            this.dgvZuzyteNarzedzia.RowHeadersWidth = 51;
            this.dgvZuzyteNarzedzia.RowTemplate.Height = 24;
            this.dgvZuzyteNarzedzia.Size = new System.Drawing.Size(550, 223);
            this.dgvZuzyteNarzedzia.TabIndex = 5;
            // 
            // Zuzyte_narzedzie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 300);
            this.Controls.Add(this.dgvZuzyteNarzedzia);
            this.Controls.Add(this.txtZuzyteNarzedziaWyszukaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZuzyteNarzedziaPowrot);
            this.Controls.Add(this.btnDodajZuzyteNarzedzia);
            this.Name = "Zuzyte_narzedzie";
            this.Text = "Zużyte narzędzia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZuzyteNarzedzia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajZuzyteNarzedzia;
        private System.Windows.Forms.Button btnZuzyteNarzedziaPowrot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZuzyteNarzedziaWyszukaj;
        public System.Windows.Forms.DataGridView dgvZuzyteNarzedzia;
    }
}