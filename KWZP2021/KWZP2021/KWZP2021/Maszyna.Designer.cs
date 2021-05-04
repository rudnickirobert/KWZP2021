
namespace KWZP2021
{
    partial class Maszyna
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
            this.dgvMaszyna = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddMaszyna = new System.Windows.Forms.Button();
            this.btnUsunMasz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyna)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaszyna
            // 
            this.dgvMaszyna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaszyna.Location = new System.Drawing.Point(33, 70);
            this.dgvMaszyna.Name = "dgvMaszyna";
            this.dgvMaszyna.Size = new System.Drawing.Size(660, 215);
            this.dgvMaszyna.TabIndex = 0;
            this.dgvMaszyna.DoubleClick += new System.EventHandler(this.dgvMaszyna_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wyszukaj maszynę po rodzaju";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Powrót: Dział produkcji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAddMaszyna
            // 
            this.btnAddMaszyna.Location = new System.Drawing.Point(322, 21);
            this.btnAddMaszyna.Name = "btnAddMaszyna";
            this.btnAddMaszyna.Size = new System.Drawing.Size(95, 45);
            this.btnAddMaszyna.TabIndex = 26;
            this.btnAddMaszyna.Text = "Dodaj";
            this.btnAddMaszyna.UseVisualStyleBackColor = true;
            this.btnAddMaszyna.Click += new System.EventHandler(this.btnAddMaszyna_Click);
            // 
            // btnUsunMasz
            // 
            this.btnUsunMasz.Location = new System.Drawing.Point(536, 19);
            this.btnUsunMasz.Name = "btnUsunMasz";
            this.btnUsunMasz.Size = new System.Drawing.Size(101, 48);
            this.btnUsunMasz.TabIndex = 27;
            this.btnUsunMasz.Text = "Usuń";
            this.btnUsunMasz.UseVisualStyleBackColor = true;
            this.btnUsunMasz.Click += new System.EventHandler(this.btnUsunMasz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Przejdź do formularza dodania nowej maszyny";
            // 
            // Maszyna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUsunMasz);
            this.Controls.Add(this.btnAddMaszyna);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMaszyna);
            this.Name = "Maszyna";
            this.Text = "Maszyna";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvMaszyna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddMaszyna;
        private System.Windows.Forms.Button btnUsunMasz;
        private System.Windows.Forms.Label label2;
    }
}