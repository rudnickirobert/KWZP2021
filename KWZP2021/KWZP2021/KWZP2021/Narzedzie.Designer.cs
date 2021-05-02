
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
            this.btnUsuwanieNarzedzia = new System.Windows.Forms.Button();
            this.btnAddRodzajMaterialu = new System.Windows.Forms.Button();
            this.dgvNarzedzie = new System.Windows.Forms.DataGridView();
            this.btnNarzedziePowrot = new System.Windows.Forms.Button();
            this.btnEdycjaCzesc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarzedzie)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Wyszukaj narzędzie po nazwie\r\n";
            // 
            // btnUsuwanieNarzedzia
            // 
            this.btnUsuwanieNarzedzia.Location = new System.Drawing.Point(814, 11);
            this.btnUsuwanieNarzedzia.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuwanieNarzedzia.Name = "btnUsuwanieNarzedzia";
            this.btnUsuwanieNarzedzia.Size = new System.Drawing.Size(143, 60);
            this.btnUsuwanieNarzedzia.TabIndex = 14;
            this.btnUsuwanieNarzedzia.Text = "Zużyte narzędzia";
            this.btnUsuwanieNarzedzia.UseVisualStyleBackColor = true;
            this.btnUsuwanieNarzedzia.Click += new System.EventHandler(this.btnUsuwanieNarzedzia_Click);
            // 
            // btnAddRodzajMaterialu
            // 
            this.btnAddRodzajMaterialu.Location = new System.Drawing.Point(491, 11);
            this.btnAddRodzajMaterialu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRodzajMaterialu.Name = "btnAddRodzajMaterialu";
            this.btnAddRodzajMaterialu.Size = new System.Drawing.Size(138, 60);
            this.btnAddRodzajMaterialu.TabIndex = 13;
            this.btnAddRodzajMaterialu.Text = "Dodaj";
            this.btnAddRodzajMaterialu.UseVisualStyleBackColor = true;
            // 
            // dgvNarzedzie
            // 
            this.dgvNarzedzie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarzedzie.Location = new System.Drawing.Point(13, 81);
            this.dgvNarzedzie.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNarzedzie.Name = "dgvNarzedzie";
            this.dgvNarzedzie.RowHeadersWidth = 51;
            this.dgvNarzedzie.Size = new System.Drawing.Size(780, 284);
            this.dgvNarzedzie.TabIndex = 12;
            // 
            // btnNarzedziePowrot
            // 
            this.btnNarzedziePowrot.Location = new System.Drawing.Point(816, 81);
            this.btnNarzedziePowrot.Name = "btnNarzedziePowrot";
            this.btnNarzedziePowrot.Size = new System.Drawing.Size(141, 284);
            this.btnNarzedziePowrot.TabIndex = 22;
            this.btnNarzedziePowrot.Text = "Powrót";
            this.btnNarzedziePowrot.UseVisualStyleBackColor = true;
            this.btnNarzedziePowrot.Click += new System.EventHandler(this.btnNarzedziePowrot_Click);
            // 
            // btnEdycjaCzesc
            // 
            this.btnEdycjaCzesc.Location = new System.Drawing.Point(646, 11);
            this.btnEdycjaCzesc.Name = "btnEdycjaCzesc";
            this.btnEdycjaCzesc.Size = new System.Drawing.Size(147, 60);
            this.btnEdycjaCzesc.TabIndex = 23;
            this.btnEdycjaCzesc.Text = "Edycja";
            this.btnEdycjaCzesc.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Narzedzie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 377);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEdycjaCzesc);
            this.Controls.Add(this.btnNarzedziePowrot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUsuwanieNarzedzia);
            this.Controls.Add(this.btnAddRodzajMaterialu);
            this.Controls.Add(this.dgvNarzedzie);
            this.Name = "Narzedzie";
            this.Text = "Narzedzie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarzedzie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUsuwanieNarzedzia;
        private System.Windows.Forms.Button btnAddRodzajMaterialu;
        private System.Windows.Forms.Button btnNarzedziePowrot;
        private System.Windows.Forms.Button btnEdycjaCzesc;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dgvNarzedzie;
    }
}