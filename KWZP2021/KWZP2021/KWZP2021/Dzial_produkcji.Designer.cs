﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dzial_produkcji));
            this.btnRodzajCzynnosci = new System.Windows.Forms.Button();
            this.btnMaszyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRodzajCzynnosci
            // 
            this.btnRodzajCzynnosci.Location = new System.Drawing.Point(442, 53);
            this.btnRodzajCzynnosci.Name = "btnRodzajCzynnosci";
            this.btnRodzajCzynnosci.Size = new System.Drawing.Size(127, 53);
            this.btnRodzajCzynnosci.TabIndex = 0;
            this.btnRodzajCzynnosci.Text = "Proces Technologiczny";
            this.btnRodzajCzynnosci.UseVisualStyleBackColor = true;
            this.btnRodzajCzynnosci.Click += new System.EventHandler(this.btnRodzajCzynnosci_Click);
            // 
            // btnMaszyna
            // 
            this.btnMaszyna.Location = new System.Drawing.Point(227, 53);
            this.btnMaszyna.Name = "btnMaszyna";
            this.btnMaszyna.Size = new System.Drawing.Size(127, 53);
            this.btnMaszyna.TabIndex = 1;
            this.btnMaszyna.Text = "Utrzymanie ruchu";
            this.btnMaszyna.UseVisualStyleBackColor = true;
            this.btnMaszyna.Click += new System.EventHandler(this.btnMaszyna_Click);
            // 
            // Dzial_produkcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaszyna);
            this.Controls.Add(this.btnRodzajCzynnosci);
            this.Name = "Dzial_produkcji";
            this.Text = "Dzial_produkcji";
            this.Load += new System.EventHandler(this.Dzial_produkcji_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRodzajCzynnosci;
        private System.Windows.Forms.Button btnMaszyna;
    }
}