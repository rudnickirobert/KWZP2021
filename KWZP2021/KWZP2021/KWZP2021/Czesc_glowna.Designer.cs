
namespace KWZP2021
{
    partial class Czesc_glowna
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
            this.btnCzesc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCzesc
            // 
            this.btnCzesc.Location = new System.Drawing.Point(31, 26);
            this.btnCzesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCzesc.Name = "btnCzesc";
            this.btnCzesc.Size = new System.Drawing.Size(147, 62);
            this.btnCzesc.TabIndex = 5;
            this.btnCzesc.Text = "Część";
            this.btnCzesc.UseVisualStyleBackColor = true;
            this.btnCzesc.Click += new System.EventHandler(this.btnCzesc_Click);
            // 
            // Czesc_glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCzesc);
            this.Name = "Czesc_glowna";
            this.Text = "Czesc_glowna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCzesc;
    }
}