
namespace KWZP2021
{
    partial class Dzial_produkcji
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
            this.btnRodzajCzynnosci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRodzajCzynnosci
            // 
            this.btnRodzajCzynnosci.Location = new System.Drawing.Point(332, 46);
            this.btnRodzajCzynnosci.Name = "btnRodzajCzynnosci";
            this.btnRodzajCzynnosci.Size = new System.Drawing.Size(237, 74);
            this.btnRodzajCzynnosci.TabIndex = 0;
            this.btnRodzajCzynnosci.Text = "Rodzaj Czynności";
            this.btnRodzajCzynnosci.UseVisualStyleBackColor = true;
            this.btnRodzajCzynnosci.Click += new System.EventHandler(this.btnRodzajCzynnosci_Click);
            // 
            // Dzial_produkcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRodzajCzynnosci);
            this.Name = "Dzial_produkcji";
            this.Text = "Dzial_produkcji";
            this.Load += new System.EventHandler(this.Dzial_produkcji_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRodzajCzynnosci;
    }
}