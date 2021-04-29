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
            this.dvgZamowienie_klienta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1_nowe_zamowienie = new System.Windows.Forms.Button();
            this.button1_Usun_zamowienie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgZamowienie_klienta)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgZamowienie_klienta
            // 
            this.dvgZamowienie_klienta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgZamowienie_klienta.Location = new System.Drawing.Point(12, 118);
            this.dvgZamowienie_klienta.Margin = new System.Windows.Forms.Padding(5);
            this.dvgZamowienie_klienta.Name = "dvgZamowienie_klienta";
            this.dvgZamowienie_klienta.RowHeadersWidth = 60;
            this.dvgZamowienie_klienta.Size = new System.Drawing.Size(657, 259);
            this.dvgZamowienie_klienta.TabIndex = 0;
            this.dvgZamowienie_klienta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgZamowienie_klienta_CellContentClick);
            this.dvgZamowienie_klienta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgZamowienie_klienta_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dodaj nowe zamówienie";
            // 
            // button1_nowe_zamowienie
            // 
            this.button1_nowe_zamowienie.Location = new System.Drawing.Point(493, 52);
            this.button1_nowe_zamowienie.Name = "button1_nowe_zamowienie";
            this.button1_nowe_zamowienie.Size = new System.Drawing.Size(119, 23);
            this.button1_nowe_zamowienie.TabIndex = 6;
            this.button1_nowe_zamowienie.Text = "Nowe zamówienie";
            this.button1_nowe_zamowienie.UseVisualStyleBackColor = true;
            this.button1_nowe_zamowienie.Click += new System.EventHandler(this.button1_nowe_zamowienie_Click);
            // 
            // button1_Usun_zamowienie
            // 
            this.button1_Usun_zamowienie.Location = new System.Drawing.Point(23, 52);
            this.button1_Usun_zamowienie.Name = "button1_Usun_zamowienie";
            this.button1_Usun_zamowienie.Size = new System.Drawing.Size(109, 23);
            this.button1_Usun_zamowienie.TabIndex = 7;
            this.button1_Usun_zamowienie.Text = "Usuń zamówienie";
            this.button1_Usun_zamowienie.UseVisualStyleBackColor = true;
            this.button1_Usun_zamowienie.Click += new System.EventHandler(this.button1_Usun_zamowienie_Click);
            // 
            // Zamowienie_klienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 389);
            this.Controls.Add(this.button1_Usun_zamowienie);
            this.Controls.Add(this.button1_nowe_zamowienie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgZamowienie_klienta);
            this.Name = "Zamowienie_klienta";
            this.Text = "Zamówienie klienta";
            this.Load += new System.EventHandler(this.Zamowienie_klienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgZamowienie_klienta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgZamowienie_klienta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1_nowe_zamowienie;
        private System.Windows.Forms.Button button1_Usun_zamowienie;
    }
}