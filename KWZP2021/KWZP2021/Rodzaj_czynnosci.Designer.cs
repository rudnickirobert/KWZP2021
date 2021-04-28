
namespace KWZP2021
{
    partial class Rodzaj_czynnosci
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
            this.dvgRodzajCzynnosci = new System.Windows.Forms.DataGridView();
            this.cmbRodzajCzynnosci = new System.Windows.Forms.ComboBox();
            this.txtNewRodzajCzynnosci = new System.Windows.Forms.TextBox();
            this.btnAddRodzajCzynnosci = new System.Windows.Forms.Button();
            this.btnDeleteRodzajCzynnosci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRodzajCzynnosci)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgRodzajCzynnosci
            // 
            this.dvgRodzajCzynnosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRodzajCzynnosci.Location = new System.Drawing.Point(57, 113);
            this.dvgRodzajCzynnosci.Name = "dvgRodzajCzynnosci";
            this.dvgRodzajCzynnosci.Size = new System.Drawing.Size(435, 322);
            this.dvgRodzajCzynnosci.TabIndex = 0;
            // 
            // cmbRodzajCzynnosci
            // 
            this.cmbRodzajCzynnosci.FormattingEnabled = true;
            this.cmbRodzajCzynnosci.Location = new System.Drawing.Point(57, 68);
            this.cmbRodzajCzynnosci.Name = "cmbRodzajCzynnosci";
            this.cmbRodzajCzynnosci.Size = new System.Drawing.Size(141, 21);
            this.cmbRodzajCzynnosci.TabIndex = 1;
            // 
            // txtNewRodzajCzynnosci
            // 
            this.txtNewRodzajCzynnosci.Location = new System.Drawing.Point(227, 69);
            this.txtNewRodzajCzynnosci.Name = "txtNewRodzajCzynnosci";
            this.txtNewRodzajCzynnosci.Size = new System.Drawing.Size(181, 20);
            this.txtNewRodzajCzynnosci.TabIndex = 2;
            // 
            // btnAddRodzajCzynnosci
            // 
            this.btnAddRodzajCzynnosci.Location = new System.Drawing.Point(587, 101);
            this.btnAddRodzajCzynnosci.Name = "btnAddRodzajCzynnosci";
            this.btnAddRodzajCzynnosci.Size = new System.Drawing.Size(132, 23);
            this.btnAddRodzajCzynnosci.TabIndex = 3;
            this.btnAddRodzajCzynnosci.Text = "Dodanie";
            this.btnAddRodzajCzynnosci.UseVisualStyleBackColor = true;
            this.btnAddRodzajCzynnosci.Click += new System.EventHandler(this.btnAddRodzajCzynnosci_Click);
            // 
            // btnDeleteRodzajCzynnosci
            // 
            this.btnDeleteRodzajCzynnosci.Location = new System.Drawing.Point(587, 168);
            this.btnDeleteRodzajCzynnosci.Name = "btnDeleteRodzajCzynnosci";
            this.btnDeleteRodzajCzynnosci.Size = new System.Drawing.Size(132, 23);
            this.btnDeleteRodzajCzynnosci.TabIndex = 4;
            this.btnDeleteRodzajCzynnosci.Text = "Usunięcie";
            this.btnDeleteRodzajCzynnosci.UseVisualStyleBackColor = true;
            this.btnDeleteRodzajCzynnosci.Click += new System.EventHandler(this.btnDeleteRodzajCzynnosci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wybierz rodzaj czynności";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wpisz nową czynność";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kliknij aby dodać czynność";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kliknij aby usunąć czynność";
            // 
            // Rodzaj_czynnosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteRodzajCzynnosci);
            this.Controls.Add(this.btnAddRodzajCzynnosci);
            this.Controls.Add(this.txtNewRodzajCzynnosci);
            this.Controls.Add(this.cmbRodzajCzynnosci);
            this.Controls.Add(this.dvgRodzajCzynnosci);
            this.Name = "Rodzaj_czynnosci";
            this.Text = "Rodzaj_czynnosci";
            this.Load += new System.EventHandler(this.Rodzaj_czynnosci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgRodzajCzynnosci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgRodzajCzynnosci;
        private System.Windows.Forms.ComboBox cmbRodzajCzynnosci;
        private System.Windows.Forms.TextBox txtNewRodzajCzynnosci;
        private System.Windows.Forms.Button btnAddRodzajCzynnosci;
        private System.Windows.Forms.Button btnDeleteRodzajCzynnosci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}