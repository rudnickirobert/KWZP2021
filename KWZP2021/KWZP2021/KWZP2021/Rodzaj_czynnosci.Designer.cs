
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
            this.dvgRodzajCzynnosci.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgRodzajCzynnosci_CellMouseDoubleClick);
            // 
            // cmbRodzajCzynnosci
            // 
            this.cmbRodzajCzynnosci.FormattingEnabled = true;
            this.cmbRodzajCzynnosci.Location = new System.Drawing.Point(57, 68);
            this.cmbRodzajCzynnosci.Name = "cmbRodzajCzynnosci";
            this.cmbRodzajCzynnosci.Size = new System.Drawing.Size(121, 21);
            this.cmbRodzajCzynnosci.TabIndex = 1;
            // 
            // txtNewRodzajCzynnosci
            // 
            this.txtNewRodzajCzynnosci.Location = new System.Drawing.Point(227, 69);
            this.txtNewRodzajCzynnosci.Name = "txtNewRodzajCzynnosci";
            this.txtNewRodzajCzynnosci.Size = new System.Drawing.Size(137, 20);
            this.txtNewRodzajCzynnosci.TabIndex = 2;
            // 
            // btnAddRodzajCzynnosci
            // 
            this.btnAddRodzajCzynnosci.Location = new System.Drawing.Point(608, 101);
            this.btnAddRodzajCzynnosci.Name = "btnAddRodzajCzynnosci";
            this.btnAddRodzajCzynnosci.Size = new System.Drawing.Size(75, 23);
            this.btnAddRodzajCzynnosci.TabIndex = 3;
            this.btnAddRodzajCzynnosci.Text = "Dodanie";
            this.btnAddRodzajCzynnosci.UseVisualStyleBackColor = true;
            this.btnAddRodzajCzynnosci.Click += new System.EventHandler(this.btnAddRodzajCzynnosci_Click);
            // 
            // btnDeleteRodzajCzynnosci
            // 
            this.btnDeleteRodzajCzynnosci.Location = new System.Drawing.Point(608, 151);
            this.btnDeleteRodzajCzynnosci.Name = "btnDeleteRodzajCzynnosci";
            this.btnDeleteRodzajCzynnosci.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRodzajCzynnosci.TabIndex = 4;
            this.btnDeleteRodzajCzynnosci.Text = "Usunięcie";
            this.btnDeleteRodzajCzynnosci.UseVisualStyleBackColor = true;
            this.btnDeleteRodzajCzynnosci.Click += new System.EventHandler(this.btnDeleteRodzajCzynnosci_Click);
            // 
            // Rodzaj_czynnosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteRodzajCzynnosci);
            this.Controls.Add(this.btnAddRodzajCzynnosci);
            this.Controls.Add(this.txtNewRodzajCzynnosci);
            this.Controls.Add(this.cmbRodzajCzynnosci);
            this.Controls.Add(this.dvgRodzajCzynnosci);
            this.Name = "Rodzaj_czynnosci";
            this.Text = "Rodzaj_czynnosci";
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
    }
}