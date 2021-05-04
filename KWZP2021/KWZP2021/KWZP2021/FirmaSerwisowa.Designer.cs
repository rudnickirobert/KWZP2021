
namespace KWZP2021
{
    partial class FirmaSerwisowa
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
            this.dgvFirma = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUsunFirma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMaszyna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFirma
            // 
            this.dgvFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirma.Location = new System.Drawing.Point(70, 118);
            this.dgvFirma.Name = "dgvFirma";
            this.dgvFirma.Size = new System.Drawing.Size(660, 215);
            this.dgvFirma.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wyszukaj firmę po nazwie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 31);
            this.button1.TabIndex = 27;
            this.button1.Text = "Powrót: Dział produkcji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUsunFirma
            // 
            this.btnUsunFirma.Location = new System.Drawing.Point(542, 47);
            this.btnUsunFirma.Name = "btnUsunFirma";
            this.btnUsunFirma.Size = new System.Drawing.Size(96, 43);
            this.btnUsunFirma.TabIndex = 28;
            this.btnUsunFirma.Text = "Usuń";
            this.btnUsunFirma.UseVisualStyleBackColor = true;
            this.btnUsunFirma.Click += new System.EventHandler(this.btnUsunFirma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Przejdź do formularza dodania nowej firmy";
            // 
            // btnAddMaszyna
            // 
            this.btnAddMaszyna.Location = new System.Drawing.Point(336, 47);
            this.btnAddMaszyna.Name = "btnAddMaszyna";
            this.btnAddMaszyna.Size = new System.Drawing.Size(95, 45);
            this.btnAddMaszyna.TabIndex = 29;
            this.btnAddMaszyna.Text = "Dodaj";
            this.btnAddMaszyna.UseVisualStyleBackColor = true;
            this.btnAddMaszyna.Click += new System.EventHandler(this.btnAddMaszyna_Click);
            // 
            // FirmaSerwisowa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddMaszyna);
            this.Controls.Add(this.btnUsunFirma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFirma);
            this.Name = "FirmaSerwisowa";
            this.Text = "Firma Serwisowa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvFirma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUsunFirma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMaszyna;
    }
}