
namespace KWZP2021
{
    partial class Czesc
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
            this.dgvCzesc = new System.Windows.Forms.DataGridView();
            this.btnDodajCzesc = new System.Windows.Forms.Button();
            this.btnWydajCzesc = new System.Windows.Forms.Button();
            this.btnCzescPowrot = new System.Windows.Forms.Button();
            this.btnEdycjaCzesc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWyszukajCzesc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCzesc
            // 
            this.dgvCzesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzesc.Location = new System.Drawing.Point(12, 94);
            this.dgvCzesc.Name = "dgvCzesc";
            this.dgvCzesc.RowHeadersWidth = 51;
            this.dgvCzesc.RowTemplate.Height = 24;
            this.dgvCzesc.Size = new System.Drawing.Size(796, 258);
            this.dgvCzesc.TabIndex = 5;
            // 
            // btnDodajCzesc
            // 
            this.btnDodajCzesc.Location = new System.Drawing.Point(464, 21);
            this.btnDodajCzesc.Name = "btnDodajCzesc";
            this.btnDodajCzesc.Size = new System.Drawing.Size(150, 55);
            this.btnDodajCzesc.TabIndex = 8;
            this.btnDodajCzesc.Text = "Dodaj część";
            this.btnDodajCzesc.UseVisualStyleBackColor = true;
            this.btnDodajCzesc.Click += new System.EventHandler(this.btnDodajCzesc_Click);
            // 
            // btnWydajCzesc
            // 
            this.btnWydajCzesc.Location = new System.Drawing.Point(658, 21);
            this.btnWydajCzesc.Name = "btnWydajCzesc";
            this.btnWydajCzesc.Size = new System.Drawing.Size(150, 55);
            this.btnWydajCzesc.TabIndex = 9;
            this.btnWydajCzesc.Text = "Wydaj część";
            this.btnWydajCzesc.UseVisualStyleBackColor = true;
            // 
            // btnCzescPowrot
            // 
            this.btnCzescPowrot.Location = new System.Drawing.Point(843, 94);
            this.btnCzescPowrot.Name = "btnCzescPowrot";
            this.btnCzescPowrot.Size = new System.Drawing.Size(150, 258);
            this.btnCzescPowrot.TabIndex = 10;
            this.btnCzescPowrot.Text = "Powrót";
            this.btnCzescPowrot.UseVisualStyleBackColor = true;
            this.btnCzescPowrot.Click += new System.EventHandler(this.btnCzescPowrot_Click);
            // 
            // btnEdycjaCzesc
            // 
            this.btnEdycjaCzesc.Location = new System.Drawing.Point(843, 21);
            this.btnEdycjaCzesc.Name = "btnEdycjaCzesc";
            this.btnEdycjaCzesc.Size = new System.Drawing.Size(150, 57);
            this.btnEdycjaCzesc.TabIndex = 11;
            this.btnEdycjaCzesc.Text = "Edycja";
            this.btnEdycjaCzesc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wyszukaj część";
            // 
            // txtWyszukajCzesc
            // 
            this.txtWyszukajCzesc.Location = new System.Drawing.Point(43, 54);
            this.txtWyszukajCzesc.Name = "txtWyszukajCzesc";
            this.txtWyszukajCzesc.Size = new System.Drawing.Size(138, 22);
            this.txtWyszukajCzesc.TabIndex = 13;
            this.txtWyszukajCzesc.TextChanged += new System.EventHandler(this.txtWyszukajCzesc_TextChanged);
            // 
            // Czesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 369);
            this.Controls.Add(this.txtWyszukajCzesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdycjaCzesc);
            this.Controls.Add(this.btnCzescPowrot);
            this.Controls.Add(this.btnWydajCzesc);
            this.Controls.Add(this.btnDodajCzesc);
            this.Controls.Add(this.dgvCzesc);
            this.Name = "Czesc";
            this.Text = "Część";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajCzesc;
        private System.Windows.Forms.Button btnWydajCzesc;
        private System.Windows.Forms.Button btnCzescPowrot;
        private System.Windows.Forms.Button btnEdycjaCzesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWyszukajCzesc;
        public System.Windows.Forms.DataGridView dgvCzesc;
    }
}