
namespace KWZP2021
{
    partial class Szczegoly_wydania_produktu
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
            this.btnAddNewSzczegoly = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvSzczegoly = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegoly)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(235, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 42;
            this.label3.Text = "Szczegóły\r\nwydania produktu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddNewSzczegoly
            // 
            this.btnAddNewSzczegoly.Location = new System.Drawing.Point(18, 14);
            this.btnAddNewSzczegoly.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewSzczegoly.Name = "btnAddNewSzczegoly";
            this.btnAddNewSzczegoly.Size = new System.Drawing.Size(110, 46);
            this.btnAddNewSzczegoly.TabIndex = 45;
            this.btnAddNewSzczegoly.Text = "Dodaj";
            this.btnAddNewSzczegoly.UseVisualStyleBackColor = true;
            this.btnAddNewSzczegoly.Click += new System.EventHandler(this.btnAddNewSzczegoly_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 46);
            this.button2.TabIndex = 44;
            this.button2.Text = "Powrót";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvSzczegoly
            // 
            this.dgvSzczegoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzczegoly.Location = new System.Drawing.Point(18, 65);
            this.dgvSzczegoly.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSzczegoly.Name = "dgvSzczegoly";
            this.dgvSzczegoly.RowHeadersWidth = 51;
            this.dgvSzczegoly.RowTemplate.Height = 24;
            this.dgvSzczegoly.Size = new System.Drawing.Size(564, 287);
            this.dgvSzczegoly.TabIndex = 43;
            this.dgvSzczegoly.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSzczegoly_CellDoubleClick_1);
            // 
            // Szczegoly_wydania_produktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAddNewSzczegoly);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvSzczegoly);
            this.Controls.Add(this.label3);
            this.Name = "Szczegoly_wydania_produktu";
            this.Text = "Szczegoly_wydania_produktu";
            this.Load += new System.EventHandler(this.Szczegoly_wydania_produktu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegoly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNewSzczegoly;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dgvSzczegoly;
    }
}