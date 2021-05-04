
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
            this.btnWlasciwoscMaterialu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(22, 21);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(110, 50);
            this.btnMaterial.TabIndex = 5;
            this.btnMaterial.Text = "Materiał";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnWlasciwosc
            // 
            this.btnWlasciwosc.Location = new System.Drawing.Point(22, 78);
            this.btnWlasciwosc.Name = "btnWlasciwosc";
            this.btnWlasciwosc.Size = new System.Drawing.Size(110, 50);
            this.btnWlasciwosc.TabIndex = 4;
            this.btnWlasciwosc.Text = "Wlasciwosc";
            this.btnWlasciwosc.UseVisualStyleBackColor = true;
            this.btnWlasciwosc.Click += new System.EventHandler(this.btnWlasciwosc_Click);
            // 
            // btnRodzajMaterial
            // 
            this.btnRodzajMaterial.Location = new System.Drawing.Point(139, 21);
            this.btnRodzajMaterial.Name = "btnRodzajMaterial";
            this.btnRodzajMaterial.Size = new System.Drawing.Size(110, 50);
            this.btnRodzajMaterial.TabIndex = 3;
            this.btnRodzajMaterial.Text = "Rodzaj materialu";
            this.btnRodzajMaterial.UseVisualStyleBackColor = true;
            this.btnRodzajMaterial.Click += new System.EventHandler(this.btnRodzajMaterial_Click);
            // 
            // btnWlasciwoscMaterialu
            // 
            this.btnWlasciwoscMaterialu.Location = new System.Drawing.Point(139, 78);
            this.btnWlasciwoscMaterialu.Name = "btnWlasciwoscMaterialu";
            this.btnWlasciwoscMaterialu.Size = new System.Drawing.Size(110, 50);
            this.btnWlasciwoscMaterialu.TabIndex = 6;
            this.btnWlasciwoscMaterialu.Text = "Wlasciwosc\r\nmateriału";
            this.btnWlasciwoscMaterialu.UseVisualStyleBackColor = true;
            this.btnWlasciwoscMaterialu.Click += new System.EventHandler(this.btnWlasciwoscMaterialu_Click);
            // 
            // Material_glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 182);
            this.Controls.Add(this.btnWlasciwoscMaterialu);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnWlasciwosc);
            this.Controls.Add(this.btnRodzajMaterial);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Material_glowny";
            this.Text = "Material_glowny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnWlasciwosc;
        private System.Windows.Forms.Button btnRodzajMaterial;
        private System.Windows.Forms.Button btnWlasciwoscMaterialu;
    }
}