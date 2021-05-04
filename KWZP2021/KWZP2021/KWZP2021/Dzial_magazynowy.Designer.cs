
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
            this.btnPrzejdzmaterial = new System.Windows.Forms.Button();
            this.btnPrzejdzczesc = new System.Windows.Forms.Button();
            this.btnPrzejdzdostawa = new System.Windows.Forms.Button();
            this.btnPrzejdznarzedzie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrzejdzmaterial
            // 
            this.btnPrzejdzmaterial.Location = new System.Drawing.Point(20, 26);
            this.btnPrzejdzmaterial.Name = "btnPrzejdzmaterial";
            this.btnPrzejdzmaterial.Size = new System.Drawing.Size(110, 50);
            this.btnPrzejdzmaterial.TabIndex = 5;
            this.btnPrzejdzmaterial.Text = "Materiał";
            this.btnPrzejdzmaterial.UseVisualStyleBackColor = true;
            this.btnPrzejdzmaterial.Click += new System.EventHandler(this.btnPrzejdzmaterial_Click);
            // 
            // btnPrzejdzczesc
            // 
            this.btnPrzejdzczesc.Location = new System.Drawing.Point(150, 26);
            this.btnPrzejdzczesc.Name = "btnPrzejdzczesc";
            this.btnPrzejdzczesc.Size = new System.Drawing.Size(110, 50);
            this.btnPrzejdzczesc.TabIndex = 6;
            this.btnPrzejdzczesc.Text = "Część";
            this.btnPrzejdzczesc.UseVisualStyleBackColor = true;
            this.btnPrzejdzczesc.Click += new System.EventHandler(this.btnPrzejdzczesc_Click);
            // 
            // btnPrzejdzdostawa
            // 
            this.btnPrzejdzdostawa.Location = new System.Drawing.Point(20, 93);
            this.btnPrzejdzdostawa.Name = "btnPrzejdzdostawa";
            this.btnPrzejdzdostawa.Size = new System.Drawing.Size(110, 50);
            this.btnPrzejdzdostawa.TabIndex = 7;
            this.btnPrzejdzdostawa.Text = "Dostawy i wydania";
            this.btnPrzejdzdostawa.UseVisualStyleBackColor = true;
            this.btnPrzejdzdostawa.Click += new System.EventHandler(this.btnPrzejdzdostawa_Click);
            // 
            // btnPrzejdznarzedzie
            // 
            this.btnPrzejdznarzedzie.Location = new System.Drawing.Point(150, 93);
            this.btnPrzejdznarzedzie.Name = "btnPrzejdznarzedzie";
            this.btnPrzejdznarzedzie.Size = new System.Drawing.Size(110, 50);
            this.btnPrzejdznarzedzie.TabIndex = 8;
            this.btnPrzejdznarzedzie.Text = "Narzędzie";
            this.btnPrzejdznarzedzie.UseVisualStyleBackColor = true;
            this.btnPrzejdznarzedzie.Click += new System.EventHandler(this.btnPrzejdznarzedzie_Click);
            // 
            // Dzial_magazynowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(293, 182);
            this.Controls.Add(this.btnPrzejdznarzedzie);
            this.Controls.Add(this.btnPrzejdzdostawa);
            this.Controls.Add(this.btnPrzejdzczesc);
            this.Controls.Add(this.btnPrzejdzmaterial);
            this.Name = "Dzial_magazynowy";
            this.Text = "Dzial_magazynowy";
            this.Load += new System.EventHandler(this.Dzial_magazynowy_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrzejdzmaterial;
        private System.Windows.Forms.Button btnPrzejdzczesc;
        private System.Windows.Forms.Button btnPrzejdzdostawa;
        private System.Windows.Forms.Button btnPrzejdznarzedzie;
    }
}