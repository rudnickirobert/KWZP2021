﻿
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
            this.SuspendLayout();
            // 
            // btnRodzajMaterial
            // 
            this.btnRodzajMaterial.Location = new System.Drawing.Point(45, 33);
            this.btnRodzajMaterial.Name = "btnRodzajMaterial";
            this.btnRodzajMaterial.Size = new System.Drawing.Size(107, 50);
            this.btnRodzajMaterial.TabIndex = 0;
            this.btnRodzajMaterial.Text = "Rodzaj materialu";
            this.btnRodzajMaterial.UseVisualStyleBackColor = true;
            this.btnRodzajMaterial.Click += new System.EventHandler(this.btnRodzajMaterial_Click);
            // 
            // Dzial_magazynowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRodzajMaterial);
            this.Name = "Dzial_magazynowy";
            this.Text = "Dzial_magazynowy";
            this.Load += new System.EventHandler(this.Dzial_magazynowy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRodzajMaterial;
    }
}