namespace KWZP2021
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DZ_Button = new System.Windows.Forms.Button();
            this.DM_button = new System.Windows.Forms.Button();
            this.DP_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DZ_Button
            // 
            this.DZ_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DZ_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.DZ_Button.Location = new System.Drawing.Point(23, 142);
            this.DZ_Button.Name = "DZ_Button";
            this.DZ_Button.Size = new System.Drawing.Size(153, 82);
            this.DZ_Button.TabIndex = 0;
            this.DZ_Button.Text = "Dział zarządzania";
            this.DZ_Button.UseVisualStyleBackColor = false;
            this.DZ_Button.Click += new System.EventHandler(this.DZ_Button_Click);
            // 
            // DM_button
            // 
            this.DM_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DM_button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.DM_button.Location = new System.Drawing.Point(236, 143);
            this.DM_button.Name = "DM_button";
            this.DM_button.Size = new System.Drawing.Size(153, 81);
            this.DM_button.TabIndex = 1;
            this.DM_button.Text = "Dział magazynowy";
            this.DM_button.UseVisualStyleBackColor = false;
            this.DM_button.Click += new System.EventHandler(this.DM_button_Click);
            // 
            // DP_Button
            // 
            this.DP_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DP_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DP_Button.Location = new System.Drawing.Point(458, 142);
            this.DP_Button.Name = "DP_Button";
            this.DP_Button.Size = new System.Drawing.Size(140, 82);
            this.DP_Button.TabIndex = 2;
            this.DP_Button.Text = "Dział produkcji";
            this.DP_Button.UseVisualStyleBackColor = false;
            this.DP_Button.Click += new System.EventHandler(this.DP_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(635, 457);
            this.Controls.Add(this.DP_Button);
            this.Controls.Add(this.DM_button);
            this.Controls.Add(this.DZ_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DZ_Button;
        private System.Windows.Forms.Button DM_button;
        private System.Windows.Forms.Button DP_Button;
    }
}

