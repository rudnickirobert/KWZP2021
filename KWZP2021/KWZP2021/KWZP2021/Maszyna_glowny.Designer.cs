﻿
namespace KWZP2021
{
    partial class Maszyna_glowny
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
            this.btn2maszyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2maszyna
            // 
            this.btn2maszyna.Location = new System.Drawing.Point(96, 68);
            this.btn2maszyna.Name = "btn2maszyna";
            this.btn2maszyna.Size = new System.Drawing.Size(75, 23);
            this.btn2maszyna.TabIndex = 0;
            this.btn2maszyna.Text = "Maszyna";
            this.btn2maszyna.UseVisualStyleBackColor = true;
            this.btn2maszyna.Click += new System.EventHandler(this.btn2maszyna_Click);
            // 
            // Maszyna_glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2maszyna);
            this.Name = "Maszyna_glowny";
            this.Text = "Maszyna_glowny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2maszyna;
    }
}