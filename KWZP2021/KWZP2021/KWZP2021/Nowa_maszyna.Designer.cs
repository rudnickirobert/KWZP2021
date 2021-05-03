
namespace KWZP2021
{
    partial class Nowa_maszyna
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
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.buttonWyczyscPola = new System.Windows.Forms.Button();
            this.buttonZapiszNowaMaszyna = new System.Windows.Forms.Button();
            this.lblNowaMaszyna = new System.Windows.Forms.Label();
            this.txtKoszt_1rh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtData_wprowadzenia = new System.Windows.Forms.TextBox();
            this.txtNumer_seryjny = new System.Windows.Forms.TextBox();
            this.txtNazwa_modelu = new System.Windows.Forms.TextBox();
            this.txtRodzaj_maszyny = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(315, 248);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(131, 30);
            this.buttonPowrot.TabIndex = 72;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            // 
            // buttonWyczyscPola
            // 
            this.buttonWyczyscPola.Location = new System.Drawing.Point(161, 248);
            this.buttonWyczyscPola.Name = "buttonWyczyscPola";
            this.buttonWyczyscPola.Size = new System.Drawing.Size(116, 30);
            this.buttonWyczyscPola.TabIndex = 71;
            this.buttonWyczyscPola.Text = "Wyczyść pola";
            this.buttonWyczyscPola.UseVisualStyleBackColor = true;
            this.buttonWyczyscPola.Click += new System.EventHandler(this.buttonWyczyscPola_Click);
            // 
            // buttonZapiszNowaMaszyna
            // 
            this.buttonZapiszNowaMaszyna.Location = new System.Drawing.Point(161, 294);
            this.buttonZapiszNowaMaszyna.Name = "buttonZapiszNowaMaszyna";
            this.buttonZapiszNowaMaszyna.Size = new System.Drawing.Size(285, 45);
            this.buttonZapiszNowaMaszyna.TabIndex = 70;
            this.buttonZapiszNowaMaszyna.Text = "Zapisz";
            this.buttonZapiszNowaMaszyna.UseVisualStyleBackColor = true;
            this.buttonZapiszNowaMaszyna.Click += new System.EventHandler(this.buttonZapiszNowaMaszyna_Click);
            // 
            // lblNowaMaszyna
            // 
            this.lblNowaMaszyna.AutoSize = true;
            this.lblNowaMaszyna.Location = new System.Drawing.Point(278, 48);
            this.lblNowaMaszyna.Name = "lblNowaMaszyna";
            this.lblNowaMaszyna.Size = new System.Drawing.Size(120, 13);
            this.lblNowaMaszyna.TabIndex = 69;
            this.lblNowaMaszyna.Text = "Uzupelnij dane maszyny";
            // 
            // txtKoszt_1rh
            // 
            this.txtKoszt_1rh.Location = new System.Drawing.Point(295, 184);
            this.txtKoszt_1rh.Name = "txtKoszt_1rh";
            this.txtKoszt_1rh.Size = new System.Drawing.Size(151, 20);
            this.txtKoszt_1rh.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Koszt 1 roboczogodziny";
            // 
            // txtData_wprowadzenia
            // 
            this.txtData_wprowadzenia.Location = new System.Drawing.Point(295, 158);
            this.txtData_wprowadzenia.Name = "txtData_wprowadzenia";
            this.txtData_wprowadzenia.Size = new System.Drawing.Size(151, 20);
            this.txtData_wprowadzenia.TabIndex = 56;
            // 
            // txtNumer_seryjny
            // 
            this.txtNumer_seryjny.Location = new System.Drawing.Point(295, 135);
            this.txtNumer_seryjny.Name = "txtNumer_seryjny";
            this.txtNumer_seryjny.Size = new System.Drawing.Size(151, 20);
            this.txtNumer_seryjny.TabIndex = 55;
            // 
            // txtNazwa_modelu
            // 
            this.txtNazwa_modelu.Location = new System.Drawing.Point(295, 109);
            this.txtNazwa_modelu.Name = "txtNazwa_modelu";
            this.txtNazwa_modelu.Size = new System.Drawing.Size(151, 20);
            this.txtNazwa_modelu.TabIndex = 54;
            // 
            // txtRodzaj_maszyny
            // 
            this.txtRodzaj_maszyny.Location = new System.Drawing.Point(295, 78);
            this.txtRodzaj_maszyny.Name = "txtRodzaj_maszyny";
            this.txtRodzaj_maszyny.Size = new System.Drawing.Size(151, 20);
            this.txtRodzaj_maszyny.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Data wprowadzenia maszyny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Numer seryjny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nazwa modelu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Rodzaj maszyny";
            // 
            // Nowa_maszyna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonWyczyscPola);
            this.Controls.Add(this.buttonZapiszNowaMaszyna);
            this.Controls.Add(this.lblNowaMaszyna);
            this.Controls.Add(this.txtKoszt_1rh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtData_wprowadzenia);
            this.Controls.Add(this.txtNumer_seryjny);
            this.Controls.Add(this.txtNazwa_modelu);
            this.Controls.Add(this.txtRodzaj_maszyny);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nowa_maszyna";
            this.Text = "Nowa maszyna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.Button buttonWyczyscPola;
        private System.Windows.Forms.Button buttonZapiszNowaMaszyna;
        private System.Windows.Forms.Label lblNowaMaszyna;
        public System.Windows.Forms.TextBox txtKoszt_1rh;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtData_wprowadzenia;
        public System.Windows.Forms.TextBox txtNumer_seryjny;
        public System.Windows.Forms.TextBox txtNazwa_modelu;
        public System.Windows.Forms.TextBox txtRodzaj_maszyny;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}