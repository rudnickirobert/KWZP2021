
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
            this.btnMaterial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRodzajMaterial
            // 
            this.btnRodzajMaterial.Location = new System.Drawing.Point(45, 33);
            this.btnRodzajMaterial.Name = "btnRodzajMaterial";
            this.btnRodzajMaterial.Size = new System.Drawing.Size(110, 50);
            this.btnRodzajMaterial.TabIndex = 0;
            this.btnRodzajMaterial.Text = "Rodzaj materialu";
            this.btnRodzajMaterial.UseVisualStyleBackColor = true;
            this.btnRodzajMaterial.Click += new System.EventHandler(this.btnRodzajMaterial_Click);
            // 
            // btnWlasciwosc
            // 
            this.btnWlasciwosc.Location = new System.Drawing.Point(310, 33);
            this.btnWlasciwosc.Name = "btnWlasciwosc";
            this.btnWlasciwosc.Size = new System.Drawing.Size(110, 50);
            this.btnWlasciwosc.TabIndex = 1;
            this.btnWlasciwosc.Text = "Wlasciwosc";
            this.btnWlasciwosc.UseVisualStyleBackColor = true;
            this.btnWlasciwosc.Click += new System.EventHandler(this.btnWlasciwosc_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(174, 33);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(110, 50);
            this.btnMaterial.TabIndex = 2;
            this.btnMaterial.Text = "Materiał";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // Dzial_magazynowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnWlasciwosc);
            this.Controls.Add(this.btnRodzajMaterial);
            this.Name = "Dzial_magazynowy";
            this.Text = "Dzial_magazynowy";
            this.Load += new System.EventHandler(this.Dzial_magazynowy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRodzajMaterial;
        private System.Windows.Forms.Button btnWlasciwosc;
        private System.Windows.Forms.Button btnMaterial;
    }
}