
namespace KWZP2021
{
    partial class DodajMaterial
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
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnAddNewMaterial = new System.Windows.Forms.Button();
            this.cmbRodzajMaterialu = new System.Windows.Forms.ComboBox();
            this.txtNewMaterial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Location = new System.Drawing.Point(298, 218);
            this.btnCancelOperation.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(100, 28);
            this.btnCancelOperation.TabIndex = 7;
            this.btnCancelOperation.Text = "Anuluj";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            // 
            // btnAddNewMaterial
            // 
            this.btnAddNewMaterial.Location = new System.Drawing.Point(117, 218);
            this.btnAddNewMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewMaterial.Name = "btnAddNewMaterial";
            this.btnAddNewMaterial.Size = new System.Drawing.Size(100, 28);
            this.btnAddNewMaterial.TabIndex = 6;
            this.btnAddNewMaterial.Text = "Dodaj";
            this.btnAddNewMaterial.UseVisualStyleBackColor = true;
            this.btnAddNewMaterial.Click += new System.EventHandler(this.btnAddNewMaterial_Click);
            // 
            // cmbRodzajMaterialu
            // 
            this.cmbRodzajMaterialu.FormattingEnabled = true;
            this.cmbRodzajMaterialu.Location = new System.Drawing.Point(270, 124);
            this.cmbRodzajMaterialu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRodzajMaterialu.Name = "cmbRodzajMaterialu";
            this.cmbRodzajMaterialu.Size = new System.Drawing.Size(160, 24);
            this.cmbRodzajMaterialu.TabIndex = 5;            // 
            // txtNewMaterial
            // 
            this.txtNewMaterial.Location = new System.Drawing.Point(99, 124);
            this.txtNewMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewMaterial.Name = "txtNewMaterial";
            this.txtNewMaterial.Size = new System.Drawing.Size(132, 22);
            this.txtNewMaterial.TabIndex = 4;
            this.txtNewMaterial.Text = "Nowy materiał...";
            // 
            // DodajMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.btnAddNewMaterial);
            this.Controls.Add(this.cmbRodzajMaterialu);
            this.Controls.Add(this.txtNewMaterial);
            this.Name = "DodajMaterial";
            this.Text = "DodajMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Button btnAddNewMaterial;
        private System.Windows.Forms.ComboBox cmbRodzajMaterialu;
        private System.Windows.Forms.TextBox txtNewMaterial;
    }
}