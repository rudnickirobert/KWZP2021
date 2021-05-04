namespace KWZP2021
{
    partial class Zamowienie_klienta
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
            this.button1_nowe_zamowienie = new System.Windows.Forms.Button();
            this.button2_Usun_zamowienie = new System.Windows.Forms.Button();
            this.dvgZamowienie_klienta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgZamowienie_klienta)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_nowe_zamowienie
            // 
            this.button1_nowe_zamowienie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1_nowe_zamowienie.Location = new System.Drawing.Point(217, 84);
            this.button1_nowe_zamowienie.Name = "button1_nowe_zamowienie";
            this.button1_nowe_zamowienie.Size = new System.Drawing.Size(124, 23);
            this.button1_nowe_zamowienie.TabIndex = 0;
            this.button1_nowe_zamowienie.Text = "Nowe zamówienie";
            this.button1_nowe_zamowienie.UseVisualStyleBackColor = false;
            this.button1_nowe_zamowienie.Click += new System.EventHandler(this.button1_nowe_zamowienie_Click);
            // 
            // button2_Usun_zamowienie
            // 
            this.button2_Usun_zamowienie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2_Usun_zamowienie.Location = new System.Drawing.Point(15, 84);
            this.button2_Usun_zamowienie.Name = "button2_Usun_zamowienie";
            this.button2_Usun_zamowienie.Size = new System.Drawing.Size(177, 23);
            this.button2_Usun_zamowienie.TabIndex = 1;
            this.button2_Usun_zamowienie.Text = "Usuń wybrane zamówienie";
            this.button2_Usun_zamowienie.UseVisualStyleBackColor = false;
            this.button2_Usun_zamowienie.Click += new System.EventHandler(this.button2_Usun_zamowienie_Click);
            // 
            // dvgZamowienie_klienta
            // 
            this.dvgZamowienie_klienta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgZamowienie_klienta.Location = new System.Drawing.Point(12, 123);
            this.dvgZamowienie_klienta.Name = "dvgZamowienie_klienta";
            this.dvgZamowienie_klienta.Size = new System.Drawing.Size(597, 232);
            this.dvgZamowienie_klienta.TabIndex = 2;
            this.dvgZamowienie_klienta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgZamowienie_klienta_CellContentClick);
            this.dvgZamowienie_klienta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgZamowienie_klienta_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz zamówienie z poniższej listy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(214, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dodaj zamówienie klienta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(15, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aby edytować konkretne zamówienie, kliknij dwukrotnie wybrany rekord";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(534, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(485, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Szczególy zamówienia klienta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Zamowienie_klienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgZamowienie_klienta);
            this.Controls.Add(this.button2_Usun_zamowienie);
            this.Controls.Add(this.button1_nowe_zamowienie);
            this.Name = "Zamowienie_klienta";
            this.Text = "Zamowienie_klienta";
            this.Load += new System.EventHandler(this.Zamowienie_klienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgZamowienie_klienta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_nowe_zamowienie;
        private System.Windows.Forms.Button button2_Usun_zamowienie;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dvgZamowienie_klienta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}