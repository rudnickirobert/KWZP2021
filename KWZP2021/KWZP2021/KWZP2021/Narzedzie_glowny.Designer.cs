
namespace KWZP2021
{
    partial class Narzedzie_glowny
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
            this.btnNarzedzie = new System.Windows.Forms.Button();
            this.btn_Rodzaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNarzedzie
            // 
            this.btnNarzedzie.Location = new System.Drawing.Point(23, 23);
            this.btnNarzedzie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNarzedzie.Name = "btnNarzedzie";
            this.btnNarzedzie.Size = new System.Drawing.Size(147, 62);
            this.btnNarzedzie.TabIndex = 4;
            this.btnNarzedzie.Text = "Lista narzędzi";
            this.btnNarzedzie.UseVisualStyleBackColor = true;
            this.btnNarzedzie.Click += new System.EventHandler(this.btnNarzedzie_Click);
            // 
            // btn_Rodzaje
            // 
            this.btn_Rodzaje.Location = new System.Drawing.Point(23, 110);
            this.btn_Rodzaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Rodzaje.Name = "btn_Rodzaje";
            this.btn_Rodzaje.Size = new System.Drawing.Size(147, 62);
            this.btn_Rodzaje.TabIndex = 5;
            this.btn_Rodzaje.Text = "Rodzaje narzędzi";
            this.btn_Rodzaje.UseVisualStyleBackColor = true;
            this.btn_Rodzaje.Click += new System.EventHandler(this.btn_Rodzaje_Click);
            // 
            // Narzedzie_glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Rodzaje);
            this.Controls.Add(this.btnNarzedzie);
            this.Name = "Narzedzie_glowny";
            this.Text = "Narzedzie_glowny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNarzedzie;
        private System.Windows.Forms.Button btn_Rodzaje;
    }
}