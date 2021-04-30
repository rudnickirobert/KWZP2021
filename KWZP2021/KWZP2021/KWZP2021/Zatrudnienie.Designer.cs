
namespace KWZP2021
{
    partial class Zatrudnienie
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
            this.dgvZatrudnienie = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZatrudnienie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZatrudnienie
            // 
            this.dgvZatrudnienie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZatrudnienie.Location = new System.Drawing.Point(22, 110);
            this.dgvZatrudnienie.Name = "dgvZatrudnienie";
            this.dgvZatrudnienie.Size = new System.Drawing.Size(1135, 394);
            this.dgvZatrudnienie.TabIndex = 0;
            this.dgvZatrudnienie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZatrudnienie_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zatrudnienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvZatrudnienie);
            this.Name = "Zatrudnienie";
            this.Text = "Zatrudnienie";
            this.Load += new System.EventHandler(this.Zatrudnienie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZatrudnienie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZatrudnienie;
        private System.Windows.Forms.Button button1;
    }
}