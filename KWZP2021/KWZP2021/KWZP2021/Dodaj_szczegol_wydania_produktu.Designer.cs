
namespace KWZP2021
{
    partial class Dodaj_szczegol_wydania_produktu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnAddNewSzczegol = new System.Windows.Forms.Button();
            this.cmbNazwaProduktu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtIdWydania = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(34, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Dodawanie nowego szczegółu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nazwa produktu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id wydania";
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Location = new System.Drawing.Point(160, 172);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(75, 25);
            this.btnCancelOperation.TabIndex = 21;
            this.btnCancelOperation.Text = "Anuluj";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // btnAddNewSzczegol
            // 
            this.btnAddNewSzczegol.Location = new System.Drawing.Point(37, 172);
            this.btnAddNewSzczegol.Name = "btnAddNewSzczegol";
            this.btnAddNewSzczegol.Size = new System.Drawing.Size(75, 25);
            this.btnAddNewSzczegol.TabIndex = 20;
            this.btnAddNewSzczegol.Text = "Dodaj";
            this.btnAddNewSzczegol.UseVisualStyleBackColor = true;
            this.btnAddNewSzczegol.Click += new System.EventHandler(this.btnAddNewSzczegol_Click);
            // 
            // cmbNazwaProduktu
            // 
            this.cmbNazwaProduktu.FormattingEnabled = true;
            this.cmbNazwaProduktu.Location = new System.Drawing.Point(128, 99);
            this.cmbNazwaProduktu.Name = "cmbNazwaProduktu";
            this.cmbNazwaProduktu.Size = new System.Drawing.Size(121, 21);
            this.cmbNazwaProduktu.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ilość";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(128, 137);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 25;
            // 
            // txtIdWydania
            // 
            this.txtIdWydania.Location = new System.Drawing.Point(128, 60);
            this.txtIdWydania.Name = "txtIdWydania";
            this.txtIdWydania.ReadOnly = true;
            this.txtIdWydania.Size = new System.Drawing.Size(121, 20);
            this.txtIdWydania.TabIndex = 27;
            // 
            // Dodaj_szczegol_wydania_produktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 221);
            this.Controls.Add(this.txtIdWydania);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.btnAddNewSzczegol);
            this.Controls.Add(this.cmbNazwaProduktu);
            this.Name = "Dodaj_szczegol_wydania_produktu";
            this.Text = "Dodaj_szczegol_wydania_produktu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Button btnAddNewSzczegol;
        private System.Windows.Forms.ComboBox cmbNazwaProduktu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.TextBox txtIdWydania;
    }
}