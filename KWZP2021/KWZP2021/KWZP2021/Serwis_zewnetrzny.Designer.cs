
namespace KWZP2021
{
    partial class Serwis_zewnetrzny
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnUsunSerw = new System.Windows.Forms.Button();
            this.btnAddSerwis = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSerwisZew = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerwisZew)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Przejdź do formularza dodania nowego serwisu";
            // 
            // btnUsunSerw
            // 
            this.btnUsunSerw.Location = new System.Drawing.Point(546, 43);
            this.btnUsunSerw.Name = "btnUsunSerw";
            this.btnUsunSerw.Size = new System.Drawing.Size(101, 48);
            this.btnUsunSerw.TabIndex = 34;
            this.btnUsunSerw.Text = "Usuń";
            this.btnUsunSerw.UseVisualStyleBackColor = true;
            this.btnUsunSerw.Click += new System.EventHandler(this.btnUsunSerw_Click);
            // 
            // btnAddSerwis
            // 
            this.btnAddSerwis.Location = new System.Drawing.Point(332, 45);
            this.btnAddSerwis.Name = "btnAddSerwis";
            this.btnAddSerwis.Size = new System.Drawing.Size(95, 45);
            this.btnAddSerwis.TabIndex = 33;
            this.btnAddSerwis.Text = "Dodaj";
            this.btnAddSerwis.UseVisualStyleBackColor = true;
            this.btnAddSerwis.Click += new System.EventHandler(this.btnAddSerwis_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 24);
            this.button1.TabIndex = 31;
            this.button1.Text = "Powrót: Dział produkcji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Wyszukaj serwis zewnętrzny po nazwie firmy";
            // 
            // dgvSerwisZew
            // 
            this.dgvSerwisZew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerwisZew.Location = new System.Drawing.Point(43, 94);
            this.dgvSerwisZew.Name = "dgvSerwisZew";
            this.dgvSerwisZew.Size = new System.Drawing.Size(660, 215);
            this.dgvSerwisZew.TabIndex = 29;
            this.dgvSerwisZew.DoubleClick += new System.EventHandler(this.dgvSerwisZew_DoubleClick);
            // 
            // Serwis_zewnetrzny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUsunSerw);
            this.Controls.Add(this.btnAddSerwis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSerwisZew);
            this.Name = "Serwis_zewnetrzny";
            this.Text = "Serwis_zewnetrzny";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerwisZew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnUsunSerw;
        public System.Windows.Forms.Button btnAddSerwis;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvSerwisZew;
    }
}