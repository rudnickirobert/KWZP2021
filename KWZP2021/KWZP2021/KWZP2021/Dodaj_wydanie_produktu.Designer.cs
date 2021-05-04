
namespace KWZP2021
{
    partial class Dodaj_wydanie_produktu
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
            this.dtpDataWydania = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUwagi = new System.Windows.Forms.TextBox();
            this.cmbIdWydania = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnAddNewWlasciwoscMaterialu = new System.Windows.Forms.Button();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDataWydania
            // 
            this.dtpDataWydania.CustomFormat = "";
            this.dtpDataWydania.Location = new System.Drawing.Point(138, 144);
            this.dtpDataWydania.Name = "dtpDataWydania";
            this.dtpDataWydania.Size = new System.Drawing.Size(154, 20);
            this.dtpDataWydania.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Uwagi";
            // 
            // txtUwagi
            // 
            this.txtUwagi.Location = new System.Drawing.Point(138, 178);
            this.txtUwagi.Multiline = true;
            this.txtUwagi.Name = "txtUwagi";
            this.txtUwagi.Size = new System.Drawing.Size(154, 50);
            this.txtUwagi.TabIndex = 86;
            // 
            // cmbIdWydania
            // 
            this.cmbIdWydania.FormattingEnabled = true;
            this.cmbIdWydania.Location = new System.Drawing.Point(138, 65);
            this.cmbIdWydania.Name = "cmbIdWydania";
            this.cmbIdWydania.Size = new System.Drawing.Size(154, 21);
            this.cmbIdWydania.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(52, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Dodawanie nowego wydania";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Pracownik wydający";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Id gotowego produktu";
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Location = new System.Drawing.Point(181, 264);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(75, 25);
            this.btnCancelOperation.TabIndex = 81;
            this.btnCancelOperation.Text = "Anuluj";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            // 
            // btnAddNewWlasciwoscMaterialu
            // 
            this.btnAddNewWlasciwoscMaterialu.Location = new System.Drawing.Point(58, 264);
            this.btnAddNewWlasciwoscMaterialu.Name = "btnAddNewWlasciwoscMaterialu";
            this.btnAddNewWlasciwoscMaterialu.Size = new System.Drawing.Size(75, 25);
            this.btnAddNewWlasciwoscMaterialu.TabIndex = 80;
            this.btnAddNewWlasciwoscMaterialu.Text = "Dodaj";
            this.btnAddNewWlasciwoscMaterialu.UseVisualStyleBackColor = true;
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(138, 104);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(154, 21);
            this.cmbPracownik.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Data wydania";
            // 
            // Dodaj_wydanie_produktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 301);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUwagi);
            this.Controls.Add(this.cmbIdWydania);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.btnAddNewWlasciwoscMaterialu);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.dtpDataWydania);
            this.Name = "Dodaj_wydanie_produktu";
            this.Text = "Dodaj_wydanie_produktu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtpDataWydania;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUwagi;
        private System.Windows.Forms.ComboBox cmbIdWydania;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Button btnAddNewWlasciwoscMaterialu;
        private System.Windows.Forms.ComboBox cmbPracownik;
        private System.Windows.Forms.Label label5;
    }
}