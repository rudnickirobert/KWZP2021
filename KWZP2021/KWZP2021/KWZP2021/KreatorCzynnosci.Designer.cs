
namespace KWZP2021
{
    partial class KreatorCzynnosci
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewProcesCzynnosci = new System.Windows.Forms.Button();
            this.cmbPOczynnosc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCzynnosci = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnWydruk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCzynnosc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzynnosci)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(212, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "lub stwórz nowy proces*";
            // 
            // btnNewProcesCzynnosci
            // 
            this.btnNewProcesCzynnosci.Location = new System.Drawing.Point(394, 45);
            this.btnNewProcesCzynnosci.Name = "btnNewProcesCzynnosci";
            this.btnNewProcesCzynnosci.Size = new System.Drawing.Size(185, 25);
            this.btnNewProcesCzynnosci.TabIndex = 15;
            this.btnNewProcesCzynnosci.Text = "Stwórz nowy proces czynności";
            this.btnNewProcesCzynnosci.UseVisualStyleBackColor = true;
            // 
            // cmbPOczynnosc
            // 
            this.cmbPOczynnosc.FormattingEnabled = true;
            this.cmbPOczynnosc.Location = new System.Drawing.Point(394, 12);
            this.cmbPOczynnosc.Name = "cmbPOczynnosc";
            this.cmbPOczynnosc.Size = new System.Drawing.Size(187, 21);
            this.cmbPOczynnosc.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(60, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Wybierz numer procesu czynności";
            // 
            // dgvCzynnosci
            // 
            this.dgvCzynnosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzynnosci.Location = new System.Drawing.Point(394, 89);
            this.dgvCzynnosci.Name = "dgvCzynnosci";
            this.dgvCzynnosci.Size = new System.Drawing.Size(537, 401);
            this.dgvCzynnosci.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Wybierz czynność";
            // 
            // btnWydruk
            // 
            this.btnWydruk.Location = new System.Drawing.Point(215, 136);
            this.btnWydruk.Name = "btnWydruk";
            this.btnWydruk.Size = new System.Drawing.Size(124, 32);
            this.btnWydruk.TabIndex = 20;
            this.btnWydruk.Text = "Stwórz nową czynność";
            this.btnWydruk.UseVisualStyleBackColor = true;
            this.btnWydruk.Click += new System.EventHandler(this.btnWydruk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(135, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Czynność";
            // 
            // cmbCzynnosc
            // 
            this.cmbCzynnosc.FormattingEnabled = true;
            this.cmbCzynnosc.Location = new System.Drawing.Point(20, 143);
            this.cmbCzynnosc.Name = "cmbCzynnosc";
            this.cmbCzynnosc.Size = new System.Drawing.Size(171, 21);
            this.cmbCzynnosc.TabIndex = 18;
            // 
            // KreatorCzynnosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 536);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnWydruk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCzynnosc);
            this.Controls.Add(this.dgvCzynnosci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNewProcesCzynnosci);
            this.Controls.Add(this.cmbPOczynnosc);
            this.Controls.Add(this.label5);
            this.Name = "KreatorCzynnosci";
            this.Text = "KreatorCzynnosci";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzynnosci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNewProcesCzynnosci;
        private System.Windows.Forms.ComboBox cmbPOczynnosc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCzynnosci;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnWydruk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCzynnosc;
    }
}