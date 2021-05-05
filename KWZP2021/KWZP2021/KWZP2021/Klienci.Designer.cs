
namespace KWZP2021
{
    partial class Klienci
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dvgKlient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNowyKlient = new System.Windows.Forms.Button();
            this.buttonWyszukajKlienta = new System.Windows.Forms.Button();
            this.buttonUsunKlienta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgKlient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wyszukaj klienta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dvgKlient
            // 
            this.dvgKlient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgKlient.Location = new System.Drawing.Point(22, 90);
            this.dvgKlient.Name = "dvgKlient";
            this.dvgKlient.Size = new System.Drawing.Size(1224, 423);
            this.dvgKlient.TabIndex = 3;
            this.dvgKlient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgKlient_CellContentClick);
            this.dvgKlient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgKlient_CellDoubleClick_1);
            this.dvgKlient.DoubleClick += new System.EventHandler(this.dvgKlient_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Przejdź do formularza dodania nowego klienta";
            // 
            // buttonNowyKlient
            // 
            this.buttonNowyKlient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonNowyKlient.Location = new System.Drawing.Point(644, 35);
            this.buttonNowyKlient.Name = "buttonNowyKlient";
            this.buttonNowyKlient.Size = new System.Drawing.Size(144, 30);
            this.buttonNowyKlient.TabIndex = 5;
            this.buttonNowyKlient.Text = "Nowy klient";
            this.buttonNowyKlient.UseVisualStyleBackColor = false;
            this.buttonNowyKlient.Click += new System.EventHandler(this.buttonNowyKlient_Click);
            // 
            // buttonWyszukajKlienta
            // 
            this.buttonWyszukajKlienta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonWyszukajKlienta.Location = new System.Drawing.Point(20, 35);
            this.buttonWyszukajKlienta.Name = "buttonWyszukajKlienta";
            this.buttonWyszukajKlienta.Size = new System.Drawing.Size(83, 30);
            this.buttonWyszukajKlienta.TabIndex = 6;
            this.buttonWyszukajKlienta.Text = "Wyszukaj";
            this.buttonWyszukajKlienta.UseVisualStyleBackColor = false;
            this.buttonWyszukajKlienta.Click += new System.EventHandler(this.buttonWyszukajKlienta_Click);
            // 
            // buttonUsunKlienta
            // 
            this.buttonUsunKlienta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonUsunKlienta.Location = new System.Drawing.Point(347, 35);
            this.buttonUsunKlienta.Name = "buttonUsunKlienta";
            this.buttonUsunKlienta.Size = new System.Drawing.Size(112, 29);
            this.buttonUsunKlienta.TabIndex = 7;
            this.buttonUsunKlienta.Text = "Usuń klienta";
            this.buttonUsunKlienta.UseVisualStyleBackColor = false;
            this.buttonUsunKlienta.Click += new System.EventHandler(this.buttonUsunKlienta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(882, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kliknij dwa razy, aby edytować dane wskazanego klienta";
            // 
            // Klienci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUsunKlienta);
            this.Controls.Add(this.buttonWyszukajKlienta);
            this.Controls.Add(this.buttonNowyKlient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgKlient);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Klienci";
            this.Text = "Klienci";
            this.Load += new System.EventHandler(this.Klienci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgKlient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNowyKlient;
        private System.Windows.Forms.Button buttonWyszukajKlienta;
        private System.Windows.Forms.Button buttonUsunKlienta;
        public System.Windows.Forms.DataGridView dvgKlient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}