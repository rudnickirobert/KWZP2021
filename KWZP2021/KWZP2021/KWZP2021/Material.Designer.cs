
namespace KWZP2021
{
    partial class Material
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.btnUpdateMaterial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewMaterial = new System.Windows.Forms.Button();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.txtFindMaterial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Edytowanie materialu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Usuwanie materialu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Wyszukaj po nazwie";
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.Location = new System.Drawing.Point(265, 50);
            this.btnDeleteMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteMaterial.TabIndex = 15;
            this.btnDeleteMaterial.Text = "Usuń";
            this.btnDeleteMaterial.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMaterial
            // 
            this.btnUpdateMaterial.Location = new System.Drawing.Point(445, 50);
            this.btnUpdateMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateMaterial.Name = "btnUpdateMaterial";
            this.btnUpdateMaterial.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateMaterial.TabIndex = 14;
            this.btnUpdateMaterial.Text = "Edytuj";
            this.btnUpdateMaterial.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dodanie nowego materialu";
            // 
            // btnAddNewMaterial
            // 
            this.btnAddNewMaterial.Location = new System.Drawing.Point(69, 50);
            this.btnAddNewMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewMaterial.Name = "btnAddNewMaterial";
            this.btnAddNewMaterial.Size = new System.Drawing.Size(100, 28);
            this.btnAddNewMaterial.TabIndex = 12;
            this.btnAddNewMaterial.Text = "Dodaj";
            this.btnAddNewMaterial.UseVisualStyleBackColor = true;
            this.btnAddNewMaterial.Click += new System.EventHandler(this.btnAddNewMaterial_Click);
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Location = new System.Drawing.Point(13, 110);
            this.dgvMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowHeadersWidth = 51;
            this.dgvMaterial.Size = new System.Drawing.Size(1035, 415);
            this.dgvMaterial.TabIndex = 11;
            // 
            // txtFindMaterial
            // 
            this.txtFindMaterial.Location = new System.Drawing.Point(900, 54);
            this.txtFindMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindMaterial.Name = "txtFindMaterial";
            this.txtFindMaterial.Size = new System.Drawing.Size(132, 22);
            this.txtFindMaterial.TabIndex = 10;
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 552);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteMaterial);
            this.Controls.Add(this.btnUpdateMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewMaterial);
            this.Controls.Add(this.dgvMaterial);
            this.Controls.Add(this.txtFindMaterial);
            this.Name = "Material";
            this.Text = "Material";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteMaterial;
        private System.Windows.Forms.Button btnUpdateMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewMaterial;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.TextBox txtFindMaterial;
    }
}