
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.btn_Rodzaje.Location = new System.Drawing.Point(23, 100);
            this.btn_Rodzaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Rodzaje.Name = "btn_Rodzaje";
            this.btn_Rodzaje.Size = new System.Drawing.Size(147, 62);
            this.btn_Rodzaje.TabIndex = 5;
            this.btn_Rodzaje.Text = "Rodzaje narzędzi";
            this.btn_Rodzaje.UseVisualStyleBackColor = true;
            this.btn_Rodzaje.Click += new System.EventHandler(this.btn_Rodzaje_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Właściwości narzędzi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 62);
            this.button2.TabIndex = 7;
            this.button2.Text = "Wypożyczenie narzędzi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Narzedzie_glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 195);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Rodzaje);
            this.Controls.Add(this.btnNarzedzie);
            this.Name = "Narzedzie_glowny";
            this.Text = "Narzedzie_glowny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNarzedzie;
        private System.Windows.Forms.Button btn_Rodzaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}