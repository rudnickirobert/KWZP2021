
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
            this.btnFirma = new System.Windows.Forms.Button();
            this.btn_Rodzaje = new System.Windows.Forms.Button();
            this.btn_Modele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2maszyna
            // 
            this.btn2maszyna.Location = new System.Drawing.Point(96, 68);
            this.btn2maszyna.Name = "btn2maszyna";
            this.btn2maszyna.Size = new System.Drawing.Size(87, 34);
            this.btn2maszyna.TabIndex = 0;
            this.btn2maszyna.Text = "Maszyna";
            this.btn2maszyna.UseVisualStyleBackColor = true;
            this.btn2maszyna.Click += new System.EventHandler(this.btn2maszyna_Click);
            // 
            // btnFirma
            // 
            this.btnFirma.Location = new System.Drawing.Point(203, 68);
            this.btnFirma.Name = "btnFirma";
            this.btnFirma.Size = new System.Drawing.Size(117, 34);
            this.btnFirma.TabIndex = 1;
            this.btnFirma.Text = "Firma serwisowa";
            this.btnFirma.UseVisualStyleBackColor = true;
            this.btnFirma.Click += new System.EventHandler(this.btnFirma_Click);
            // 
            // btn_Rodzaje
            // 
            this.btn_Rodzaje.Location = new System.Drawing.Point(96, 107);
            this.btn_Rodzaje.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Rodzaje.Name = "btn_Rodzaje";
            this.btn_Rodzaje.Size = new System.Drawing.Size(87, 34);
            this.btn_Rodzaje.TabIndex = 6;
            this.btn_Rodzaje.Text = "Rodzaje maszyn";
            this.btn_Rodzaje.UseVisualStyleBackColor = true;
            this.btn_Rodzaje.Click += new System.EventHandler(this.btn_Rodzaje_Click);
            // 
            // btn_Modele
            // 
            this.btn_Modele.Location = new System.Drawing.Point(96, 145);
            this.btn_Modele.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modele.Name = "btn_Modele";
            this.btn_Modele.Size = new System.Drawing.Size(87, 34);
            this.btn_Modele.TabIndex = 7;
            this.btn_Modele.Text = "Modele maszyn";
            this.btn_Modele.UseVisualStyleBackColor = true;
            this.btn_Modele.Click += new System.EventHandler(this.btn_Modele_Click);
            // 
            // Maszyna_glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Modele);
            this.Controls.Add(this.btn_Rodzaje);
            this.Controls.Add(this.btnFirma);
            this.Controls.Add(this.btn2maszyna);
            this.Name = "Maszyna_glowny";
            this.Text = "Utrzymanie ruchu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2maszyna;
        private System.Windows.Forms.Button btnFirma;
        private System.Windows.Forms.Button btn_Rodzaje;
        private System.Windows.Forms.Button btn_Modele;
    }
}