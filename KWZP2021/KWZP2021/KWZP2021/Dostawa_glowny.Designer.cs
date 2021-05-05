
namespace KWZP2021
{
    partial class Dostawa_glowny
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
            this.btnWydanieProd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWydanieProd
            // 
            this.btnWydanieProd.Location = new System.Drawing.Point(28, 15);
            this.btnWydanieProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnWydanieProd.Name = "btnWydanieProd";
            this.btnWydanieProd.Size = new System.Drawing.Size(147, 62);
            this.btnWydanieProd.TabIndex = 8;
            this.btnWydanieProd.Text = "Wydanie produktów";
            this.btnWydanieProd.UseVisualStyleBackColor = true;
            this.btnWydanieProd.Click += new System.EventHandler(this.btnWydanieProd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dostawcy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 85);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 62);
            this.button2.TabIndex = 10;
            this.button2.Text = "Dostawa materiału";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dostawa_glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 224);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWydanieProd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dostawa_glowny";
            this.Text = "Dostawa_glowny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWydanieProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}