
namespace KWZP2021
{
    partial class Dzial_magazynowy
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
            this.btnRodzajMaterial = new System.Windows.Forms.Button();
            this.btnWlasciwosc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRodzajMaterial
            // 
            this.btnRodzajMaterial.Location = new System.Drawing.Point(60, 41);
            this.btnRodzajMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRodzajMaterial.Name = "btnRodzajMaterial";
            this.btnRodzajMaterial.Size = new System.Drawing.Size(143, 62);
            this.btnRodzajMaterial.TabIndex = 0;
            this.btnRodzajMaterial.Text = "Rodzaj materialu";
            this.btnRodzajMaterial.UseVisualStyleBackColor = true;
            this.btnRodzajMaterial.Click += new System.EventHandler(this.btnRodzajMaterial_Click);
            // 
            // btnWlasciwosc
            // 
            this.btnWlasciwosc.Location = new System.Drawing.Point(265, 41);
            this.btnWlasciwosc.Margin = new System.Windows.Forms.Padding(4);
            this.btnWlasciwosc.Name = "btnWlasciwosc";
            this.btnWlasciwosc.Size = new System.Drawing.Size(143, 62);
            this.btnWlasciwosc.TabIndex = 1;
            this.btnWlasciwosc.Text = "Wlasciwosc";
            this.btnWlasciwosc.UseVisualStyleBackColor = true;
            this.btnWlasciwosc.Click += new System.EventHandler(this.btnWlasciwosc_Click);
            // 
            // Dzial_magazynowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnWlasciwosc);
            this.Controls.Add(this.btnRodzajMaterial);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dzial_magazynowy";
            this.Text = "Dzial_magazynowy";
            this.Load += new System.EventHandler(this.Dzial_magazynowy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRodzajMaterial;
        private System.Windows.Forms.Button btnWlasciwosc;
    }
}