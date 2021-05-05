
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrzejdzmaterial
            // 
            this.btnPrzejdzmaterial.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPrzejdzmaterial.FlatAppearance.BorderSize = 2;
            this.btnPrzejdzmaterial.Location = new System.Drawing.Point(143, 65);
            this.btnPrzejdzmaterial.Name = "btnPrzejdzmaterial";
            this.btnPrzejdzmaterial.Size = new System.Drawing.Size(110, 50);
            this.btnPrzejdzmaterial.TabIndex = 5;
            this.btnPrzejdzmaterial.Text = "Materiał";
            this.btnPrzejdzmaterial.UseVisualStyleBackColor = true;
            this.btnPrzejdzmaterial.Click += new System.EventHandler(this.btnPrzejdzmaterial_Click);
            // 
            // btnPrzejdzczesc
            // 
            this.btnPrzejdzczesc.BackColor = System.Drawing.Color.LightGray;
            this.btnPrzejdzczesc.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPrzejdzczesc.FlatAppearance.BorderSize = 2;
            this.btnPrzejdzczesc.Location = new System.Drawing.Point(111, 12);
            this.btnPrzejdzczesc.Name = "btnPrzejdzczesc";
            this.btnPrzejdzczesc.Size = new System.Drawing.Size(110, 50);
            this.btnPrzejdzczesc.TabIndex = 6;
            this.btnPrzejdzczesc.Text = "Część";
            this.btnPrzejdzczesc.UseVisualStyleBackColor = false;
            this.btnPrzejdzczesc.Click += new System.EventHandler(this.btnPrzejdzczesc_Click);
            // 
            // btnPrzejdzdostawa
            // 
            this.btnPrzejdzdostawa.BackColor = System.Drawing.Color.LightGray;
            this.btnPrzejdzdostawa.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPrzejdzdostawa.FlatAppearance.BorderSize = 2;
            this.btnPrzejdzdostawa.Location = new System.Drawing.Point(111, 15);
            this.btnPrzejdzdostawa.Name = "btnPrzejdzdostawa";
            this.btnPrzejdzdostawa.Size = new System.Drawing.Size(110, 50);
            this.btnPrzejdzdostawa.TabIndex = 7;
            this.btnPrzejdzdostawa.Text = "Dostawy i wydania";
            this.btnPrzejdzdostawa.UseVisualStyleBackColor = false;
            this.btnPrzejdzdostawa.Click += new System.EventHandler(this.btnPrzejdzdostawa_Click);
            // 
            // btnPrzejdznarzedzie
            // 
            this.btnPrzejdznarzedzie.BackColor = System.Drawing.Color.LightGray;
            this.btnPrzejdznarzedzie.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPrzejdznarzedzie.FlatAppearance.BorderSize = 2;
            this.btnPrzejdznarzedzie.Location = new System.Drawing.Point(111, 13);
            this.btnPrzejdznarzedzie.Name = "btnPrzejdznarzedzie";
            this.btnPrzejdznarzedzie.Size = new System.Drawing.Size(110, 50);
            this.btnPrzejdznarzedzie.TabIndex = 8;
            this.btnPrzejdznarzedzie.Text = "Narzędzie";
            this.btnPrzejdznarzedzie.UseVisualStyleBackColor = false;
            this.btnPrzejdznarzedzie.Click += new System.EventHandler(this.btnPrzejdznarzedzie_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(32, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 78);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnPrzejdzczesc);
            this.panel2.Location = new System.Drawing.Point(32, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 78);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.btnPrzejdznarzedzie);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(32, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 78);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.btnPrzejdzdostawa);
            this.panel4.Location = new System.Drawing.Point(32, 304);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 78);
            this.panel4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dział magazynowy";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KWZP2021.Properties.Resources.MicrosoftTeams_image__1_;
            this.pictureBox4.Location = new System.Drawing.Point(19, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Image = global::KWZP2021.Properties.Resources.MicrosoftTeams_image__5_;
            this.pictureBox2.Location = new System.Drawing.Point(20, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = global::KWZP2021.Properties.Resources.MicrosoftTeams_image__4_;
            this.pictureBox1.Location = new System.Drawing.Point(20, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KWZP2021.Properties.Resources.MicrosoftTeams_image__6_;
            this.pictureBox3.Location = new System.Drawing.Point(20, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Dzial_magazynowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(308, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrzejdzmaterial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Dzial_magazynowy";
            this.Text = "Dzial_magazynowy";
            this.Load += new System.EventHandler(this.Dzial_magazynowy_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrzejdzmaterial;
        private System.Windows.Forms.Button btnPrzejdzczesc;
        private System.Windows.Forms.Button btnPrzejdzdostawa;
        private System.Windows.Forms.Button btnPrzejdznarzedzie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}