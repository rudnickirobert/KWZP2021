
namespace KWZP2021
{
    partial class Szczegoly_zatrudnienia
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
            this.dataSzczegoly = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUsunPracownika = new System.Windows.Forms.Button();
            this.buttonNowyPracownik = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSzczegoly)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSzczegoly
            // 
            this.dataSzczegoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSzczegoly.Location = new System.Drawing.Point(6, 111);
            this.dataSzczegoly.Name = "dataSzczegoly";
            this.dataSzczegoly.Size = new System.Drawing.Size(785, 230);
            this.dataSzczegoly.TabIndex = 53;
            this.dataSzczegoly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSzczegoly_CellContentClick);
            this.dataSzczegoly.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSzczegoly_CellContentDoubleClick);
            this.dataSzczegoly.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSzczegoly_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Kliknij dwa razy, aby edytować szczegóły zatrudnienia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(657, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 58;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUsunPracownika
            // 
            this.buttonUsunPracownika.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonUsunPracownika.Location = new System.Drawing.Point(258, 45);
            this.buttonUsunPracownika.Name = "buttonUsunPracownika";
            this.buttonUsunPracownika.Size = new System.Drawing.Size(112, 29);
            this.buttonUsunPracownika.TabIndex = 57;
            this.buttonUsunPracownika.Text = "Usuń szczegóły";
            this.buttonUsunPracownika.UseVisualStyleBackColor = false;
            this.buttonUsunPracownika.Click += new System.EventHandler(this.buttonUsunPracownika_Click);
            // 
            // buttonNowyPracownik
            // 
            this.buttonNowyPracownik.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonNowyPracownik.Location = new System.Drawing.Point(439, 44);
            this.buttonNowyPracownik.Name = "buttonNowyPracownik";
            this.buttonNowyPracownik.Size = new System.Drawing.Size(144, 30);
            this.buttonNowyPracownik.TabIndex = 56;
            this.buttonNowyPracownik.Text = "Nowe szczegóły";
            this.buttonNowyPracownik.UseVisualStyleBackColor = false;
            this.buttonNowyPracownik.Click += new System.EventHandler(this.buttonNowyPracownik_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 60;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Wyszukaj ";
            // 
            // Szczegoly_zatrudnienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUsunPracownika);
            this.Controls.Add(this.buttonNowyPracownik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataSzczegoly);
            this.Name = "Szczegoly_zatrudnienia";
            this.Text = "Szczegóły zatrudnienia";
            this.Load += new System.EventHandler(this.Szczegoly_zatrudnienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSzczegoly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataSzczegoly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUsunPracownika;
        private System.Windows.Forms.Button buttonNowyPracownik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}