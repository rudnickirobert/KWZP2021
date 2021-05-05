
namespace KWZP2021
{
    partial class Pracownicy
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
            this.buttonUsunPracownika = new System.Windows.Forms.Button();
            this.buttonWyszukajPracownika = new System.Windows.Forms.Button();
            this.buttonNowyPracownik = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgPracownik = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPracownik)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUsunPracownika
            // 
            this.buttonUsunPracownika.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonUsunPracownika.Location = new System.Drawing.Point(333, 30);
            this.buttonUsunPracownika.Name = "buttonUsunPracownika";
            this.buttonUsunPracownika.Size = new System.Drawing.Size(112, 29);
            this.buttonUsunPracownika.TabIndex = 14;
            this.buttonUsunPracownika.Text = "Usuń pracownika";
            this.buttonUsunPracownika.UseVisualStyleBackColor = false;
            this.buttonUsunPracownika.Click += new System.EventHandler(this.buttonUsunPracownika_Click);
            // 
            // buttonWyszukajPracownika
            // 
            this.buttonWyszukajPracownika.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonWyszukajPracownika.Location = new System.Drawing.Point(6, 30);
            this.buttonWyszukajPracownika.Name = "buttonWyszukajPracownika";
            this.buttonWyszukajPracownika.Size = new System.Drawing.Size(83, 30);
            this.buttonWyszukajPracownika.TabIndex = 13;
            this.buttonWyszukajPracownika.Text = "Wyszukaj";
            this.buttonWyszukajPracownika.UseVisualStyleBackColor = false;
            this.buttonWyszukajPracownika.Click += new System.EventHandler(this.buttonWyszukajPracownika_Click);
            // 
            // buttonNowyPracownik
            // 
            this.buttonNowyPracownik.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonNowyPracownik.Location = new System.Drawing.Point(630, 30);
            this.buttonNowyPracownik.Name = "buttonNowyPracownik";
            this.buttonNowyPracownik.Size = new System.Drawing.Size(144, 30);
            this.buttonNowyPracownik.TabIndex = 12;
            this.buttonNowyPracownik.Text = "Nowy pracownik";
            this.buttonNowyPracownik.UseVisualStyleBackColor = false;
            this.buttonNowyPracownik.Click += new System.EventHandler(this.buttonNowyPracownik_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Przejdź do formularza dodania nowego pracownika";
            // 
            // dvgPracownik
            // 
            this.dvgPracownik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPracownik.Location = new System.Drawing.Point(8, 98);
            this.dvgPracownik.Name = "dvgPracownik";
            this.dvgPracownik.Size = new System.Drawing.Size(1224, 410);
            this.dvgPracownik.TabIndex = 10;
            this.dvgPracownik.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPracownik_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wyszukaj pracownika";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(848, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kliknij dwa razy, aby edytować dane wskazanego pracownika";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUsunPracownika);
            this.Controls.Add(this.buttonWyszukajPracownika);
            this.Controls.Add(this.buttonNowyPracownik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgPracownik);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Pracownicy";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Pracownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPracownik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUsunPracownika;
        private System.Windows.Forms.Button buttonWyszukajPracownika;
        private System.Windows.Forms.Button buttonNowyPracownik;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dvgPracownik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}