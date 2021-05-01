
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
            this.buttonNoweZatrudnienie = new System.Windows.Forms.Button();
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
            this.dgvZatrudnienie.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZatrudnienie_CellDoubleClick);
            // 
            // buttonNoweZatrudnienie
            // 
            this.buttonNoweZatrudnienie.Location = new System.Drawing.Point(22, 12);
            this.buttonNoweZatrudnienie.Name = "buttonNoweZatrudnienie";
            this.buttonNoweZatrudnienie.Size = new System.Drawing.Size(148, 35);
            this.buttonNoweZatrudnienie.TabIndex = 1;
            this.buttonNoweZatrudnienie.Text = "Nowe zatrudnienie";
            this.buttonNoweZatrudnienie.UseVisualStyleBackColor = true;
            this.buttonNoweZatrudnienie.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Szczegóły umów";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Zatrudnienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNoweZatrudnienie);
            this.Controls.Add(this.dgvZatrudnienie);
            this.Name = "Zatrudnienie";
            this.Text = "Zatrudnienie";
            this.Load += new System.EventHandler(this.Zatrudnienie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZatrudnienie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZatrudnienie;
        private System.Windows.Forms.Button buttonNoweZatrudnienie;
        private System.Windows.Forms.Button button1;
    }
}