
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
            this.btnCzescGlownaWydanie = new System.Windows.Forms.Button();
            this.btnCzescGlownaDodajParametr = new System.Windows.Forms.Button();
            this.btnCzescGlownaPowrot = new System.Windows.Forms.Button();
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
            // btnCzescGlownaWydanie
            // 
            this.btnCzescGlownaWydanie.Location = new System.Drawing.Point(31, 122);
            this.btnCzescGlownaWydanie.Name = "btnCzescGlownaWydanie";
            this.btnCzescGlownaWydanie.Size = new System.Drawing.Size(147, 62);
            this.btnCzescGlownaWydanie.TabIndex = 6;
            this.btnCzescGlownaWydanie.Text = "Wydaj część";
            this.btnCzescGlownaWydanie.UseVisualStyleBackColor = true;
            this.btnCzescGlownaWydanie.Click += new System.EventHandler(this.btnCzescGlownaWydanie_Click);
            // 
            // btnCzescGlownaDodajParametr
            // 
            this.btnCzescGlownaDodajParametr.Location = new System.Drawing.Point(218, 26);
            this.btnCzescGlownaDodajParametr.Name = "btnCzescGlownaDodajParametr";
            this.btnCzescGlownaDodajParametr.Size = new System.Drawing.Size(147, 62);
            this.btnCzescGlownaDodajParametr.TabIndex = 7;
            this.btnCzescGlownaDodajParametr.Text = "Parametr części";
            this.btnCzescGlownaDodajParametr.UseVisualStyleBackColor = true;
            this.btnCzescGlownaDodajParametr.Click += new System.EventHandler(this.btnCzescGlownaDodajParametr_Click);
            // 
            // btnCzescGlownaPowrot
            // 
            this.btnCzescGlownaPowrot.Location = new System.Drawing.Point(218, 122);
            this.btnCzescGlownaPowrot.Name = "btnCzescGlownaPowrot";
            this.btnCzescGlownaPowrot.Size = new System.Drawing.Size(147, 62);
            this.btnCzescGlownaPowrot.TabIndex = 8;
            this.btnCzescGlownaPowrot.Text = "Powrót";
            this.btnCzescGlownaPowrot.UseVisualStyleBackColor = true;
            this.btnCzescGlownaPowrot.Click += new System.EventHandler(this.btnCzescGlownaPowrot_Click);
            // 
            // Czesc_glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(388, 213);
            this.Controls.Add(this.btnCzescGlownaPowrot);
            this.Controls.Add(this.btnCzescGlownaDodajParametr);
            this.Controls.Add(this.btnCzescGlownaWydanie);
            this.Controls.Add(this.btnCzesc);
            this.Name = "Czesc_glowna";
            this.Text = "Panel główny CZĘŚĆ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCzesc;
        private System.Windows.Forms.Button btnCzescGlownaWydanie;
        private System.Windows.Forms.Button btnCzescGlownaDodajParametr;
        private System.Windows.Forms.Button btnCzescGlownaPowrot;
    }
}