
namespace KWZP2021
{
    partial class ProcesDrukowania
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
            this.dgvProcesDrukowania = new System.Windows.Forms.DataGridView();
            this.cmbProcesTechno = new System.Windows.Forms.ComboBox();
            this.cmbWydruk = new System.Windows.Forms.ComboBox();
            this.txtCzas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesDrukowania)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcesDrukowania
            // 
            this.dgvProcesDrukowania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesDrukowania.Location = new System.Drawing.Point(272, 63);
            this.dgvProcesDrukowania.Name = "dgvProcesDrukowania";
            this.dgvProcesDrukowania.Size = new System.Drawing.Size(745, 302);
            this.dgvProcesDrukowania.TabIndex = 0;
            // 
            // cmbProcesTechno
            // 
            this.cmbProcesTechno.FormattingEnabled = true;
            this.cmbProcesTechno.Location = new System.Drawing.Point(84, 144);
            this.cmbProcesTechno.Name = "cmbProcesTechno";
            this.cmbProcesTechno.Size = new System.Drawing.Size(166, 21);
            this.cmbProcesTechno.TabIndex = 1;
            // 
            // cmbWydruk
            // 
            this.cmbWydruk.FormattingEnabled = true;
            this.cmbWydruk.Location = new System.Drawing.Point(84, 210);
            this.cmbWydruk.Name = "cmbWydruk";
            this.cmbWydruk.Size = new System.Drawing.Size(166, 21);
            this.cmbWydruk.TabIndex = 2;
            // 
            // txtCzas
            // 
            this.txtCzas.Location = new System.Drawing.Point(84, 272);
            this.txtCzas.Name = "txtCzas";
            this.txtCzas.Size = new System.Drawing.Size(166, 20);
            this.txtCzas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz proces technologiczny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wybierz wydruk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wpisz zamierzony czas wydruku w h";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(634, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 36);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Aby usunąć, wybierz proces wydruku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(79, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dodanie nowego procesu drukowania";
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(71, 402);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(297, 21);
            this.cmbDelete.TabIndex = 16;
            this.cmbDelete.SelectionChangeCommitted += new System.EventHandler(this.cmbDelete_SelectionChangeCommitted);
            // 
            // ProcesDrukowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 495);
            this.Controls.Add(this.cmbDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCzas);
            this.Controls.Add(this.cmbWydruk);
            this.Controls.Add(this.cmbProcesTechno);
            this.Controls.Add(this.dgvProcesDrukowania);
            this.Name = "ProcesDrukowania";
            this.Text = "ProcesDrukowania";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesDrukowania)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcesDrukowania;
        private System.Windows.Forms.ComboBox cmbProcesTechno;
        private System.Windows.Forms.ComboBox cmbWydruk;
        private System.Windows.Forms.TextBox txtCzas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDelete;
    }
}