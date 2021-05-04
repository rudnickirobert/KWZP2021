
namespace KWZP2021
{
    partial class Wydanie_produktu
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
            this.btnAddNewWydanieProduktu = new System.Windows.Forms.Button();
            this.dgvWydanieProduktu = new System.Windows.Forms.DataGridView();
            this.txtFindWydanieProduktu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWydanieProduktu)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(331, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Wydanie produktów";
            // 
            // btnAddNewWydanieProduktu
            // 
            this.btnAddNewWydanieProduktu.Location = new System.Drawing.Point(719, 54);
            this.btnAddNewWydanieProduktu.Name = "btnAddNewWydanieProduktu";
            this.btnAddNewWydanieProduktu.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewWydanieProduktu.TabIndex = 29;
            this.btnAddNewWydanieProduktu.Text = "Dodaj";
            this.btnAddNewWydanieProduktu.UseVisualStyleBackColor = true;
            this.btnAddNewWydanieProduktu.Click += new System.EventHandler(this.btnAddNewWydanieProduktu_Click);
            // 
            // dgvWydanieProduktu
            // 
            this.dgvWydanieProduktu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWydanieProduktu.Location = new System.Drawing.Point(8, 92);
            this.dgvWydanieProduktu.Name = "dgvWydanieProduktu";
            this.dgvWydanieProduktu.RowHeadersWidth = 51;
            this.dgvWydanieProduktu.Size = new System.Drawing.Size(786, 347);
            this.dgvWydanieProduktu.TabIndex = 28;
            this.dgvWydanieProduktu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWydanieProduktu_CellDoubleClick);
            // 
            // txtFindWydanieProduktu
            // 
            this.txtFindWydanieProduktu.Location = new System.Drawing.Point(7, 56);
            this.txtFindWydanieProduktu.Name = "txtFindWydanieProduktu";
            this.txtFindWydanieProduktu.Size = new System.Drawing.Size(120, 20);
            this.txtFindWydanieProduktu.TabIndex = 27;
            this.txtFindWydanieProduktu.TextChanged += new System.EventHandler(this.txtFindWydanieProduktu_TextChanged);
            // 
            // Wydanie_produktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddNewWydanieProduktu);
            this.Controls.Add(this.dgvWydanieProduktu);
            this.Controls.Add(this.txtFindWydanieProduktu);
            this.Name = "Wydanie_produktu";
            this.Text = "Wydanie_produktu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWydanieProduktu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNewWydanieProduktu;
        public System.Windows.Forms.DataGridView dgvWydanieProduktu;
        private System.Windows.Forms.TextBox txtFindWydanieProduktu;
    }
}