
namespace KWZP2021
{
    partial class ProcesTechnologiczny
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCzynnosci = new System.Windows.Forms.Button();
            this.dgv_proces_wydruk = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnWydruk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proces_wydruk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCzynnosci
            // 
            this.btnCzynnosci.Location = new System.Drawing.Point(1311, 126);
            this.btnCzynnosci.Name = "btnCzynnosci";
            this.btnCzynnosci.Size = new System.Drawing.Size(89, 27);
            this.btnCzynnosci.TabIndex = 0;
            this.btnCzynnosci.Text = "Czynności";
            this.btnCzynnosci.UseVisualStyleBackColor = true;
            this.btnCzynnosci.Click += new System.EventHandler(this.btnCzynnosci_Click);
            // 
            // dgv_proces_wydruk
            // 
            this.dgv_proces_wydruk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_proces_wydruk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_proces_wydruk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_proces_wydruk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proces_wydruk.Location = new System.Drawing.Point(12, 68);
            this.dgv_proces_wydruk.Name = "dgv_proces_wydruk";
            this.dgv_proces_wydruk.Size = new System.Drawing.Size(1008, 379);
            this.dgv_proces_wydruk.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(1311, 423);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 24);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnWydruk
            // 
            this.btnWydruk.Location = new System.Drawing.Point(1247, 68);
            this.btnWydruk.Name = "btnWydruk";
            this.btnWydruk.Size = new System.Drawing.Size(156, 52);
            this.btnWydruk.TabIndex = 3;
            this.btnWydruk.Text = "Kreator Wydruku";
            this.btnWydruk.UseVisualStyleBackColor = true;
            this.btnWydruk.Click += new System.EventHandler(this.btnWydruk_Click);
            // 
            // ProcesTechnologiczny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 575);
            this.Controls.Add(this.btnWydruk);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgv_proces_wydruk);
            this.Controls.Add(this.btnCzynnosci);
            this.Name = "ProcesTechnologiczny";
            this.Text = "ProcesTechnologiczny";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proces_wydruk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCzynnosci;
        private System.Windows.Forms.DataGridView dgv_proces_wydruk;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnWydruk;
    }
}