
namespace KWZP2021
{
    partial class Wlasciwosc
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
            this.dgvWlasciwosc = new System.Windows.Forms.DataGridView();
            this.btnDeletenarzedzie = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNarzedziePowrot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddnarzedzie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWlasciwosc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWlasciwosc
            // 
            this.dgvWlasciwosc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWlasciwosc.Location = new System.Drawing.Point(13, 101);
            this.dgvWlasciwosc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvWlasciwosc.Name = "dgvWlasciwosc";
            this.dgvWlasciwosc.RowHeadersWidth = 51;
            this.dgvWlasciwosc.Size = new System.Drawing.Size(496, 337);
            this.dgvWlasciwosc.TabIndex = 29;
            this.dgvWlasciwosc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWlasciwosc_CellDoubleClick);
            // 
            // btnDeletenarzedzie
            // 
            this.btnDeletenarzedzie.Location = new System.Drawing.Point(226, 53);
            this.btnDeletenarzedzie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletenarzedzie.Name = "btnDeletenarzedzie";
            this.btnDeletenarzedzie.Size = new System.Drawing.Size(101, 40);
            this.btnDeletenarzedzie.TabIndex = 34;
            this.btnDeletenarzedzie.Text = "Usuń";
            this.btnDeletenarzedzie.UseVisualStyleBackColor = true;
            this.btnDeletenarzedzie.Click += new System.EventHandler(this.btnDeletenarzedzie_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 33;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNarzedziePowrot
            // 
            this.btnNarzedziePowrot.Location = new System.Drawing.Point(358, 24);
            this.btnNarzedziePowrot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNarzedziePowrot.Name = "btnNarzedziePowrot";
            this.btnNarzedziePowrot.Size = new System.Drawing.Size(134, 61);
            this.btnNarzedziePowrot.TabIndex = 32;
            this.btnNarzedziePowrot.Text = "Powrót";
            this.btnNarzedziePowrot.UseVisualStyleBackColor = true;
            this.btnNarzedziePowrot.Click += new System.EventHandler(this.btnNarzedziePowrot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Wyszukaj właściwość po nazwie\r\n";
            // 
            // btnAddnarzedzie
            // 
            this.btnAddnarzedzie.Location = new System.Drawing.Point(226, 12);
            this.btnAddnarzedzie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddnarzedzie.Name = "btnAddnarzedzie";
            this.btnAddnarzedzie.Size = new System.Drawing.Size(101, 41);
            this.btnAddnarzedzie.TabIndex = 30;
            this.btnAddnarzedzie.Text = "Dodaj";
            this.btnAddnarzedzie.UseVisualStyleBackColor = true;
            this.btnAddnarzedzie.Click += new System.EventHandler(this.btnAddnarzedzie_Click);
            // 
            // Wlasciwosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 451);
            this.Controls.Add(this.btnDeletenarzedzie);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNarzedziePowrot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddnarzedzie);
            this.Controls.Add(this.dgvWlasciwosc);
            this.Name = "Wlasciwosc";
            this.Text = "Wlasciwosc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWlasciwosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnDeletenarzedzie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNarzedziePowrot;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnAddnarzedzie;
        public System.Windows.Forms.DataGridView dgvWlasciwosc;
    }
}