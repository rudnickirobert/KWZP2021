
namespace KWZP2021
{
    partial class EdytujMaterial
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cmbEdytujRodzajMaterialu = new System.Windows.Forms.ComboBox();
            this.txtEdytujMaterial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(75, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Edycja materiału";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rodzaj materiału";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nazwa materiału";
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Location = new System.Drawing.Point(160, 172);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(75, 25);
            this.btnCancelOperation.TabIndex = 14;
            this.btnCancelOperation.Text = "Anuluj";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(37, 172);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 25);
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Text = "Zapisz";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cmbEdytujRodzajMaterialu
            // 
            this.cmbEdytujRodzajMaterialu.FormattingEnabled = true;
            this.cmbEdytujRodzajMaterialu.Location = new System.Drawing.Point(128, 99);
            this.cmbEdytujRodzajMaterialu.Name = "cmbEdytujRodzajMaterialu";
            this.cmbEdytujRodzajMaterialu.Size = new System.Drawing.Size(121, 21);
            this.cmbEdytujRodzajMaterialu.TabIndex = 12;
            // 
            // txtEdytujMaterial
            // 
            this.txtEdytujMaterial.Location = new System.Drawing.Point(128, 60);
            this.txtEdytujMaterial.Name = "txtEdytujMaterial";
            this.txtEdytujMaterial.Size = new System.Drawing.Size(121, 20);
            this.txtEdytujMaterial.TabIndex = 11;
            // 
            // EdytujMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 221);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.cmbEdytujRodzajMaterialu);
            this.Controls.Add(this.txtEdytujMaterial);
            this.Name = "EdytujMaterial";
            this.Text = "EdytujMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Button btnSaveChanges;
        public System.Windows.Forms.TextBox txtEdytujMaterial;
        public System.Windows.Forms.ComboBox cmbEdytujRodzajMaterialu;
    }
}