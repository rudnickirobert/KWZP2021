
namespace KWZP2021
{
    partial class Edytuj_wlasciwosc_materialu
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cmbWlasciwosc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Wartość";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(128, 141);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(121, 20);
            this.txtValue.TabIndex = 35;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(128, 65);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterial.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(55, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Edycja\r\nwłaściwości materiału";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Właściwośćmateriału";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nazwa materiału";
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Location = new System.Drawing.Point(160, 177);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(75, 25);
            this.btnCancelOperation.TabIndex = 30;
            this.btnCancelOperation.Text = "Anuluj";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(37, 177);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 25);
            this.btnSaveChanges.TabIndex = 29;
            this.btnSaveChanges.Text = "Zapisz";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cmbWlasciwosc
            // 
            this.cmbWlasciwosc.FormattingEnabled = true;
            this.cmbWlasciwosc.Location = new System.Drawing.Point(128, 104);
            this.cmbWlasciwosc.Name = "cmbWlasciwosc";
            this.cmbWlasciwosc.Size = new System.Drawing.Size(121, 21);
            this.cmbWlasciwosc.TabIndex = 28;
            // 
            // Edytuj_wlasciwosc_materialu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 221);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.cmbWlasciwosc);
            this.Name = "Edytuj_wlasciwosc_materialu";
            this.Text = "Edytuj_wlasciwosc_materialu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Button btnSaveChanges;
        public System.Windows.Forms.ComboBox cmbMaterial;
        public System.Windows.Forms.ComboBox cmbWlasciwosc;
        public System.Windows.Forms.TextBox txtValue;
    }
}