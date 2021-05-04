namespace KWZP2021
{
    partial class ZamowienieZewn
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgZamowienie_zewn = new System.Windows.Forms.DataGridView();
            this.button2_Usun_zamowienie = new System.Windows.Forms.Button();
            this.button1_nowe_zamowienie = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dvgZamowienie_zewn)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aby zobaczyć szczegóły konkretnego zamówienie, kliknij dwukrotnie wybrany rekord";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dodaj zamówienie zewnętrzne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wybierz zamówienie z poniższej listy";
            // 
            // dvgZamowienie_zewn
            // 
            this.dvgZamowienie_zewn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgZamowienie_zewn.Location = new System.Drawing.Point(18, 161);
            this.dvgZamowienie_zewn.Name = "dvgZamowienie_zewn";
            this.dvgZamowienie_zewn.Size = new System.Drawing.Size(597, 216);
            this.dvgZamowienie_zewn.TabIndex = 9;
            this.dvgZamowienie_zewn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgZamowienie_zewn_CellDoubleClick);
            // 
            // button2_Usun_zamowienie
            // 
            this.button2_Usun_zamowienie.Location = new System.Drawing.Point(311, 120);
            this.button2_Usun_zamowienie.Name = "button2_Usun_zamowienie";
            this.button2_Usun_zamowienie.Size = new System.Drawing.Size(177, 23);
            this.button2_Usun_zamowienie.TabIndex = 8;
            this.button2_Usun_zamowienie.Text = "Usuń wybrane zamówienie";
            this.button2_Usun_zamowienie.UseVisualStyleBackColor = true;
            this.button2_Usun_zamowienie.Click += new System.EventHandler(this.button2_Usun_zamowienie_Click);
            // 
            // button1_nowe_zamowienie
            // 
            this.button1_nowe_zamowienie.Location = new System.Drawing.Point(168, 121);
            this.button1_nowe_zamowienie.Name = "button1_nowe_zamowienie";
            this.button1_nowe_zamowienie.Size = new System.Drawing.Size(71, 23);
            this.button1_nowe_zamowienie.TabIndex = 7;
            this.button1_nowe_zamowienie.Text = "Dodaj";
            this.button1_nowe_zamowienie.UseVisualStyleBackColor = true;
            this.button1_nowe_zamowienie.Click += new System.EventHandler(this.button1_nowe_zamowienie_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Materiałów";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(552, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Narzędzi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Maszyn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Szczegóły zamówienia zewnętrznego";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(552, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Części";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Pracownik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Data zamówienia";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // ZamowienieZewn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 419);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgZamowienie_zewn);
            this.Controls.Add(this.button2_Usun_zamowienie);
            this.Controls.Add(this.button1_nowe_zamowienie);
            this.Name = "ZamowienieZewn";
            this.Text = "ZamowienieZewn";
            this.Load += new System.EventHandler(this.ZamowienieZewn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgZamowienie_zewn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dvgZamowienie_zewn;
        private System.Windows.Forms.Button button2_Usun_zamowienie;
        private System.Windows.Forms.Button button1_nowe_zamowienie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}