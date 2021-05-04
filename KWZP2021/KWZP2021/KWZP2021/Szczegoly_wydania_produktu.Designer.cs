
namespace KWZP2021
{
    partial class Szczegoly_wydania_produktu
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreviousScreen = new System.Windows.Forms.Button();
            this.txtProdukt = new System.Windows.Forms.TextBox();
            this.txtNrWydania = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ilość";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(128, 141);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(71, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 42;
            this.label3.Text = "Szczegóły\r\nwydania produktu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Produkt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Numer wydania";
            // 
            // btnPreviousScreen
            // 
            this.btnPreviousScreen.Location = new System.Drawing.Point(99, 177);
            this.btnPreviousScreen.Name = "btnPreviousScreen";
            this.btnPreviousScreen.Size = new System.Drawing.Size(75, 25);
            this.btnPreviousScreen.TabIndex = 39;
            this.btnPreviousScreen.Text = "Powrót";
            this.btnPreviousScreen.UseVisualStyleBackColor = true;
            this.btnPreviousScreen.Click += new System.EventHandler(this.btnPreviousScreen_Click);
            // 
            // txtProdukt
            // 
            this.txtProdukt.Location = new System.Drawing.Point(128, 104);
            this.txtProdukt.Name = "txtProdukt";
            this.txtProdukt.ReadOnly = true;
            this.txtProdukt.Size = new System.Drawing.Size(121, 20);
            this.txtProdukt.TabIndex = 46;
            // 
            // txtNrWydania
            // 
            this.txtNrWydania.Location = new System.Drawing.Point(128, 65);
            this.txtNrWydania.Name = "txtNrWydania";
            this.txtNrWydania.ReadOnly = true;
            this.txtNrWydania.Size = new System.Drawing.Size(121, 20);
            this.txtNrWydania.TabIndex = 47;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // Szczegoly_wydania_produktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 221);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNrWydania);
            this.Controls.Add(this.txtProdukt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreviousScreen);
            this.Name = "Szczegoly_wydania_produktu";
            this.Text = "Szczegoly_wydania_produktu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreviousScreen;
        public System.Windows.Forms.TextBox txtProdukt;
        public System.Windows.Forms.TextBox txtNrWydania;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}