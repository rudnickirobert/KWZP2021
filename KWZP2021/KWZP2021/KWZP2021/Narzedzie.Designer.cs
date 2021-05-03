
namespace KWZP2021
{
    partial class Narzedzie
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddnarzedzie = new System.Windows.Forms.Button();
            this.dgvNarzedzie = new System.Windows.Forms.DataGridView();
            this.btnNarzedziePowrot = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDeletenarzedzie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarzedzie)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Wyszukaj narzędzie po nazwie\r\n";
            // 
            // btnAddnarzedzie
            // 
            this.btnAddnarzedzie.Location = new System.Drawing.Point(242, 9);
            this.btnAddnarzedzie.Name = "btnAddnarzedzie";
            this.btnAddnarzedzie.Size = new System.Drawing.Size(104, 49);
            this.btnAddnarzedzie.TabIndex = 13;
            this.btnAddnarzedzie.Text = "Dodaj";
            this.btnAddnarzedzie.UseVisualStyleBackColor = true;
            this.btnAddnarzedzie.Click += new System.EventHandler(this.btnAddnarzedzie_Click);
            // 
            // dgvNarzedzie
            // 
            this.dgvNarzedzie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarzedzie.Location = new System.Drawing.Point(10, 66);
            this.dgvNarzedzie.Name = "dgvNarzedzie";
            this.dgvNarzedzie.RowHeadersWidth = 51;
            this.dgvNarzedzie.Size = new System.Drawing.Size(585, 231);
            this.dgvNarzedzie.TabIndex = 12;
            this.dgvNarzedzie.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarzedzie_CellDoubleClick);
            // 
            // btnNarzedziePowrot
            // 
            this.btnNarzedziePowrot.Location = new System.Drawing.Point(612, 66);
            this.btnNarzedziePowrot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNarzedziePowrot.Name = "btnNarzedziePowrot";
            this.btnNarzedziePowrot.Size = new System.Drawing.Size(106, 231);
            this.btnNarzedziePowrot.TabIndex = 22;
            this.btnNarzedziePowrot.Text = "Powrót";
            this.btnNarzedziePowrot.UseVisualStyleBackColor = true;
            this.btnNarzedziePowrot.Click += new System.EventHandler(this.btnNarzedziePowrot_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDeletenarzedzie
            // 
            this.btnDeletenarzedzie.Location = new System.Drawing.Point(352, 9);
            this.btnDeletenarzedzie.Name = "btnDeletenarzedzie";
            this.btnDeletenarzedzie.Size = new System.Drawing.Size(104, 49);
            this.btnDeletenarzedzie.TabIndex = 25;
            this.btnDeletenarzedzie.Text = "Usuń";
            this.btnDeletenarzedzie.UseVisualStyleBackColor = true;
            this.btnDeletenarzedzie.Click += new System.EventHandler(this.btnDeletenarzedzie_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 49);
            this.button1.TabIndex = 26;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Narzedzie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeletenarzedzie);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNarzedziePowrot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddnarzedzie);
            this.Controls.Add(this.dgvNarzedzie);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Narzedzie";
            this.Text = "Narzedzie";
            this.Load += new System.EventHandler(this.Narzedzie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarzedzie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNarzedziePowrot;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dgvNarzedzie;
        public System.Windows.Forms.Button btnAddnarzedzie;
        public System.Windows.Forms.Button btnDeletenarzedzie;
        public System.Windows.Forms.Button button1;
    }
}