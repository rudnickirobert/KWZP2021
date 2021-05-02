
namespace KWZP2021
{
    partial class Material_glowny
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
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnWlasciwosc = new System.Windows.Forms.Button();
            this.btnRodzajMaterial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(30, 26);
            this.btnMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(147, 62);
            this.btnMaterial.TabIndex = 5;
            this.btnMaterial.Text = "Materiał";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnWlasciwosc
            // 
            this.btnWlasciwosc.Location = new System.Drawing.Point(30, 96);
            this.btnWlasciwosc.Margin = new System.Windows.Forms.Padding(4);
            this.btnWlasciwosc.Name = "btnWlasciwosc";
            this.btnWlasciwosc.Size = new System.Drawing.Size(147, 62);
            this.btnWlasciwosc.TabIndex = 4;
            this.btnWlasciwosc.Text = "Wlasciwosc";
            this.btnWlasciwosc.UseVisualStyleBackColor = true;
            this.btnWlasciwosc.Click += new System.EventHandler(this.btnWlasciwosc_Click);
            // 
            // btnRodzajMaterial
            // 
            this.btnRodzajMaterial.Location = new System.Drawing.Point(185, 26);
            this.btnRodzajMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnRodzajMaterial.Name = "btnRodzajMaterial";
            this.btnRodzajMaterial.Size = new System.Drawing.Size(147, 62);
            this.btnRodzajMaterial.TabIndex = 3;
            this.btnRodzajMaterial.Text = "Rodzaj materialu";
            this.btnRodzajMaterial.UseVisualStyleBackColor = true;
            this.btnRodzajMaterial.Click += new System.EventHandler(this.btnRodzajMaterial_Click);
            // 
            // Material_glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnWlasciwosc);
            this.Controls.Add(this.btnRodzajMaterial);
            this.Name = "Material_glowny";
            this.Text = "Material_glowny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnWlasciwosc;
        private System.Windows.Forms.Button btnRodzajMaterial;
    }
}