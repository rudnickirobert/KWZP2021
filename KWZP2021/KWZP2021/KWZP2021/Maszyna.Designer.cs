
namespace KWZP2021
{
    partial class Maszyna
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
            this.dgvMaszyna = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyna)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaszyna
            // 
            this.dgvMaszyna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaszyna.Location = new System.Drawing.Point(59, 124);
            this.dgvMaszyna.Name = "dgvMaszyna";
            this.dgvMaszyna.Size = new System.Drawing.Size(660, 215);
            this.dgvMaszyna.TabIndex = 0;
            // 
            // Maszyna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMaszyna);
            this.Name = "Maszyna";
            this.Text = "Maszyna";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszyna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvMaszyna;
    }
}