
namespace KWZP2021
{
    partial class Dostawcy
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
            this.buttonUsunKlienta = new System.Windows.Forms.Button();
            this.buttonNowyKlient = new System.Windows.Forms.Button();
            this.dgvDostawca = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostawca)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUsunKlienta
            // 
            this.buttonUsunKlienta.Location = new System.Drawing.Point(315, 9);
            this.buttonUsunKlienta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUsunKlienta.Name = "buttonUsunKlienta";
            this.buttonUsunKlienta.Size = new System.Drawing.Size(201, 57);
            this.buttonUsunKlienta.TabIndex = 14;
            this.buttonUsunKlienta.Text = "Usuń dostawcę";
            this.buttonUsunKlienta.UseVisualStyleBackColor = true;
            this.buttonUsunKlienta.Click += new System.EventHandler(this.buttonUsunKlienta_Click);
            // 
            // buttonNowyKlient
            // 
            this.buttonNowyKlient.Location = new System.Drawing.Point(524, 11);
            this.buttonNowyKlient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNowyKlient.Name = "buttonNowyKlient";
            this.buttonNowyKlient.Size = new System.Drawing.Size(203, 58);
            this.buttonNowyKlient.TabIndex = 12;
            this.buttonNowyKlient.Text = "Nowy dostawca";
            this.buttonNowyKlient.UseVisualStyleBackColor = true;
            this.buttonNowyKlient.Click += new System.EventHandler(this.buttonNowyKlient_Click);
            // 
            // dgvDostawca
            // 
            this.dgvDostawca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostawca.Location = new System.Drawing.Point(10, 77);
            this.dgvDostawca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDostawca.Name = "dgvDostawca";
            this.dgvDostawca.RowHeadersWidth = 51;
            this.dgvDostawca.Size = new System.Drawing.Size(925, 430);
            this.dgvDostawca.TabIndex = 10;
            this.dgvDostawca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDostawca_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wyszukaj dostawcę po nazwie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(735, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dostawcy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUsunKlienta);
            this.Controls.Add(this.buttonNowyKlient);
            this.Controls.Add(this.dgvDostawca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Dostawcy";
            this.Text = "Dostawcy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostawca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUsunKlienta;
        private System.Windows.Forms.Button buttonNowyKlient;
        public System.Windows.Forms.DataGridView dgvDostawca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}