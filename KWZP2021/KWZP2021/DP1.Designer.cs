
namespace KWZP2021
{
    partial class DP1
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
            this.txtNewFirmaSerwisowa = new System.Windows.Forms.TextBox();
            this.btnAddFirmaSerwisowa = new System.Windows.Forms.Button();
            this.DGVFirma = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewFirmaSerwisowa
            // 
            this.txtNewFirmaSerwisowa.Location = new System.Drawing.Point(36, 35);
            this.txtNewFirmaSerwisowa.Name = "txtNewFirmaSerwisowa";
            this.txtNewFirmaSerwisowa.Size = new System.Drawing.Size(100, 22);
            this.txtNewFirmaSerwisowa.TabIndex = 0;
            // 
            // btnAddFirmaSerwisowa
            // 
            this.btnAddFirmaSerwisowa.Location = new System.Drawing.Point(152, 26);
            this.btnAddFirmaSerwisowa.Name = "btnAddFirmaSerwisowa";
            this.btnAddFirmaSerwisowa.Size = new System.Drawing.Size(75, 31);
            this.btnAddFirmaSerwisowa.TabIndex = 1;
            this.btnAddFirmaSerwisowa.Text = "Dodaj";
            this.btnAddFirmaSerwisowa.UseVisualStyleBackColor = true;
            this.btnAddFirmaSerwisowa.Click += new System.EventHandler(this.btnAddFirmaSerwisowa_Click);
            // 
            // DGVFirma
            // 
            this.DGVFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFirma.Location = new System.Drawing.Point(36, 85);
            this.DGVFirma.Name = "DGVFirma";
            this.DGVFirma.RowHeadersWidth = 51;
            this.DGVFirma.RowTemplate.Height = 24;
            this.DGVFirma.Size = new System.Drawing.Size(690, 353);
            this.DGVFirma.TabIndex = 2;
            // 
            // DP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVFirma);
            this.Controls.Add(this.btnAddFirmaSerwisowa);
            this.Controls.Add(this.txtNewFirmaSerwisowa);
            this.Name = "DP1";
            this.Text = "DP1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVFirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewFirmaSerwisowa;
        private System.Windows.Forms.Button btnAddFirmaSerwisowa;
        private System.Windows.Forms.DataGridView DGVFirma;
    }
}