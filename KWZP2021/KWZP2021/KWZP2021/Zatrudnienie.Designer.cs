
namespace KWZP2021
{
    partial class Zatrudnienie
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
            this.dgvZatrudnienie = new System.Windows.Forms.DataGridView();
            this.buttonNoweZatrudnienie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZatrudnienie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZatrudnienie
            // 
            this.dgvZatrudnienie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZatrudnienie.Location = new System.Drawing.Point(22, 110);
            this.dgvZatrudnienie.Name = "dgvZatrudnienie";
            this.dgvZatrudnienie.Size = new System.Drawing.Size(1135, 394);
            this.dgvZatrudnienie.TabIndex = 0;
            this.dgvZatrudnienie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZatrudnienie_CellContentClick);
            this.dgvZatrudnienie.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZatrudnienie_CellDoubleClick);
            // 
            // buttonNoweZatrudnienie
            // 
            this.buttonNoweZatrudnienie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonNoweZatrudnienie.Location = new System.Drawing.Point(275, 50);
            this.buttonNoweZatrudnienie.Name = "buttonNoweZatrudnienie";
            this.buttonNoweZatrudnienie.Size = new System.Drawing.Size(148, 35);
            this.buttonNoweZatrudnienie.TabIndex = 1;
            this.buttonNoweZatrudnienie.Text = "Nowe zatrudnienie";
            this.buttonNoweZatrudnienie.UseVisualStyleBackColor = false;
            this.buttonNoweZatrudnienie.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(429, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Szczegóły umów";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(583, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(737, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Powrót";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wyszukaj ";
            // 
            // Zatrudnienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 529);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNoweZatrudnienie);
            this.Controls.Add(this.dgvZatrudnienie);
            this.Name = "Zatrudnienie";
            this.Text = "Zatrudnienie";
            this.Load += new System.EventHandler(this.Zatrudnienie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZatrudnienie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNoweZatrudnienie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dgvZatrudnienie;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}