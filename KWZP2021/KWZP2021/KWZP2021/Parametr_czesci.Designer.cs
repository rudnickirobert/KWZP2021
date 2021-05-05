
namespace KWZP2021
{
    partial class Parametr_czesci
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
            this.button4 = new System.Windows.Forms.Button();
            this.dgvParametrCzesci = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDodajParametr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametrCzesci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wyszukaj parametr";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(613, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 62);
            this.button4.TabIndex = 5;
            this.button4.Text = "Powrót";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvParametrCzesci
            // 
            this.dgvParametrCzesci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametrCzesci.Location = new System.Drawing.Point(12, 78);
            this.dgvParametrCzesci.Name = "dgvParametrCzesci";
            this.dgvParametrCzesci.RowHeadersWidth = 51;
            this.dgvParametrCzesci.RowTemplate.Height = 24;
            this.dgvParametrCzesci.Size = new System.Drawing.Size(748, 254);
            this.dgvParametrCzesci.TabIndex = 6;
            this.dgvParametrCzesci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParametrCzesci_CellDoubleClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 62);
            this.button3.TabIndex = 8;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDodajParametr
            // 
            this.btnDodajParametr.Location = new System.Drawing.Point(154, 9);
            this.btnDodajParametr.Name = "btnDodajParametr";
            this.btnDodajParametr.Size = new System.Drawing.Size(147, 62);
            this.btnDodajParametr.TabIndex = 9;
            this.btnDodajParametr.Text = "Dodaj";
            this.btnDodajParametr.UseVisualStyleBackColor = true;
            this.btnDodajParametr.Click += new System.EventHandler(this.btnDodajParametr_Click);
            // 
            // Parametr_czesci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 339);
            this.Controls.Add(this.btnDodajParametr);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvParametrCzesci);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Parametr_czesci";
            this.Text = "Parametr części";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametrCzesci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDodajParametr;
        public System.Windows.Forms.DataGridView dgvParametrCzesci;
    }
}