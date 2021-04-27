
namespace KWZP2021
{
    partial class Rodzaj_materialu
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
            this.dgvRodzajMaterialu = new System.Windows.Forms.DataGridView();
            this.btnAddRodzajMaterialu = new System.Windows.Forms.Button();
            this.btnDeleteRodzajMaterialu = new System.Windows.Forms.Button();
            this.txtNewRodzajMaterialu = new System.Windows.Forms.TextBox();
            this.cmbRodzajMaterialu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajMaterialu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRodzajMaterialu
            // 
            this.dgvRodzajMaterialu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRodzajMaterialu.Location = new System.Drawing.Point(42, 91);
            this.dgvRodzajMaterialu.Name = "dgvRodzajMaterialu";
            this.dgvRodzajMaterialu.Size = new System.Drawing.Size(496, 347);
            this.dgvRodzajMaterialu.TabIndex = 0;
            this.dgvRodzajMaterialu.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRodzajMaterialu_CellMouseDoubleClick);
            // 
            // btnAddRodzajMaterialu
            // 
            this.btnAddRodzajMaterialu.Location = new System.Drawing.Point(623, 91);
            this.btnAddRodzajMaterialu.Name = "btnAddRodzajMaterialu";
            this.btnAddRodzajMaterialu.Size = new System.Drawing.Size(75, 23);
            this.btnAddRodzajMaterialu.TabIndex = 1;
            this.btnAddRodzajMaterialu.Text = "Dodaj";
            this.btnAddRodzajMaterialu.UseVisualStyleBackColor = true;
            this.btnAddRodzajMaterialu.Click += new System.EventHandler(this.btnAddRodzajMaterialu_Click);
            // 
            // btnDeleteRodzajMaterialu
            // 
            this.btnDeleteRodzajMaterialu.Location = new System.Drawing.Point(623, 140);
            this.btnDeleteRodzajMaterialu.Name = "btnDeleteRodzajMaterialu";
            this.btnDeleteRodzajMaterialu.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRodzajMaterialu.TabIndex = 3;
            this.btnDeleteRodzajMaterialu.Text = "Usun";
            this.btnDeleteRodzajMaterialu.UseVisualStyleBackColor = true;
            this.btnDeleteRodzajMaterialu.Click += new System.EventHandler(this.btnDeleteRodzajMaterialu_Click);
            // 
            // txtNewRodzajMaterialu
            // 
            this.txtNewRodzajMaterialu.Location = new System.Drawing.Point(222, 43);
            this.txtNewRodzajMaterialu.Name = "txtNewRodzajMaterialu";
            this.txtNewRodzajMaterialu.Size = new System.Drawing.Size(100, 20);
            this.txtNewRodzajMaterialu.TabIndex = 5;
            // 
            // cmbRodzajMaterialu
            // 
            this.cmbRodzajMaterialu.FormattingEnabled = true;
            this.cmbRodzajMaterialu.Location = new System.Drawing.Point(42, 42);
            this.cmbRodzajMaterialu.Name = "cmbRodzajMaterialu";
            this.cmbRodzajMaterialu.Size = new System.Drawing.Size(121, 21);
            this.cmbRodzajMaterialu.TabIndex = 6;
            // 
            // Rodzaj_materialu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbRodzajMaterialu);
            this.Controls.Add(this.txtNewRodzajMaterialu);
            this.Controls.Add(this.btnDeleteRodzajMaterialu);
            this.Controls.Add(this.btnAddRodzajMaterialu);
            this.Controls.Add(this.dgvRodzajMaterialu);
            this.Name = "Rodzaj_materialu";
            this.Text = "Rodzaj_materialu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajMaterialu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRodzajMaterialu;
        private System.Windows.Forms.Button btnAddRodzajMaterialu;
        private System.Windows.Forms.Button btnDeleteRodzajMaterialu;
        private System.Windows.Forms.TextBox txtNewRodzajMaterialu;
        private System.Windows.Forms.ComboBox cmbRodzajMaterialu;
    }
}