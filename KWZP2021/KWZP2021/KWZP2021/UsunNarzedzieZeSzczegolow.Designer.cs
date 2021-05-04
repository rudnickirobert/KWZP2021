
namespace KWZP2021
{
    partial class UsunNarzedzieZeSzczegolow
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvSzczeg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczeg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 56);
            this.button2.TabIndex = 8;
            this.button2.Text = "Powrót";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvSzczeg
            // 
            this.dgvSzczeg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzczeg.Location = new System.Drawing.Point(24, 80);
            this.dgvSzczeg.Name = "dgvSzczeg";
            this.dgvSzczeg.RowHeadersWidth = 51;
            this.dgvSzczeg.RowTemplate.Height = 24;
            this.dgvSzczeg.Size = new System.Drawing.Size(752, 353);
            this.dgvSzczeg.TabIndex = 7;
            // 
            // UsunNarzedzieZeSzczegolow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvSzczeg);
            this.Name = "UsunNarzedzieZeSzczegolow";
            this.Text = "UsunNarzedzieZeSzczegolow";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczeg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dgvSzczeg;
    }
}