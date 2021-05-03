
namespace KWZP2021
{
    partial class EdytujWlasciwoscNarzedzia
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
            this.cmbNazwa = new System.Windows.Forms.ComboBox();
            this.cmbWlasciwosc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWartosc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbNazwa
            // 
            this.cmbNazwa.FormattingEnabled = true;
            this.cmbNazwa.Location = new System.Drawing.Point(179, 48);
            this.cmbNazwa.Name = "cmbNazwa";
            this.cmbNazwa.Size = new System.Drawing.Size(160, 24);
            this.cmbNazwa.TabIndex = 42;
            // 
            // cmbWlasciwosc
            // 
            this.cmbWlasciwosc.FormattingEnabled = true;
            this.cmbWlasciwosc.Location = new System.Drawing.Point(179, 81);
            this.cmbWlasciwosc.Name = "cmbWlasciwosc";
            this.cmbWlasciwosc.Size = new System.Drawing.Size(160, 24);
            this.cmbWlasciwosc.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nazwa narzędzia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Właściwość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Dodawanie nowej właściwości narzędzia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Wartość";
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Location = new System.Drawing.Point(229, 211);
            this.btnCancelOperation.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(100, 31);
            this.btnCancelOperation.TabIndex = 36;
            this.btnCancelOperation.Text = "Anuluj";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 211);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 31);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Edytuj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtWartosc
            // 
            this.txtWartosc.Location = new System.Drawing.Point(179, 121);
            this.txtWartosc.Margin = new System.Windows.Forms.Padding(4);
            this.txtWartosc.Name = "txtWartosc";
            this.txtWartosc.Size = new System.Drawing.Size(160, 22);
            this.txtWartosc.TabIndex = 34;
            // 
            // EdytujWlasciwoscNarzedzia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 255);
            this.Controls.Add(this.cmbNazwa);
            this.Controls.Add(this.cmbWlasciwosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtWartosc);
            this.Name = "EdytujWlasciwoscNarzedzia";
            this.Text = "EdytujWlasciwoscNarzedzia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbNazwa;
        public System.Windows.Forms.ComboBox cmbWlasciwosc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtWartosc;
    }
}