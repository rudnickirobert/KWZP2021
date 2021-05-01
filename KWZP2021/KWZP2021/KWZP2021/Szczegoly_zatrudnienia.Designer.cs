
namespace KWZP2021
{
    partial class Szczegoly_zatrudnienia
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
            this.lblNowyKlient = new System.Windows.Forms.Label();
            this.dataSzczegoly = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSzczegoly)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNowyKlient
            // 
            this.lblNowyKlient.AutoSize = true;
            this.lblNowyKlient.Location = new System.Drawing.Point(8, 22);
            this.lblNowyKlient.Name = "lblNowyKlient";
            this.lblNowyKlient.Size = new System.Drawing.Size(117, 13);
            this.lblNowyKlient.TabIndex = 52;
            this.lblNowyKlient.Text = "Szczegóły zatrudnienia";
            // 
            // dataSzczegoly
            // 
            this.dataSzczegoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSzczegoly.Location = new System.Drawing.Point(11, 50);
            this.dataSzczegoly.Name = "dataSzczegoly";
            this.dataSzczegoly.Size = new System.Drawing.Size(785, 230);
            this.dataSzczegoly.TabIndex = 53;
            this.dataSzczegoly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSzczegoly_CellContentClick);
            this.dataSzczegoly.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSzczegoly_CellContentDoubleClick);
            this.dataSzczegoly.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSzczegoly_CellDoubleClick);
            // 
            // Szczegoly_zatrudnienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataSzczegoly);
            this.Controls.Add(this.lblNowyKlient);
            this.Name = "Szczegoly_zatrudnienia";
            this.Text = "Szczegoly_zatrudnienia";
            this.Load += new System.EventHandler(this.Szczegoly_zatrudnienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSzczegoly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNowyKlient;
        private System.Windows.Forms.DataGridView dataSzczegoly;
    }
}