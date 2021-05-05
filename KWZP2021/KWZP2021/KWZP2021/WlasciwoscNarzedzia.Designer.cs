
namespace KWZP2021
{
    partial class WlasciwoscNarzedzia
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvWlasciwosc = new System.Windows.Forms.DataGridView();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnPowrot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWlasciwosc)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(220, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Właściwości narzędzi";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(374, 40);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 45);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(251, 40);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 45);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvWlasciwosc
            // 
            this.dgvWlasciwosc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWlasciwosc.Location = new System.Drawing.Point(13, 119);
            this.dgvWlasciwosc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvWlasciwosc.Name = "dgvWlasciwosc";
            this.dgvWlasciwosc.RowHeadersWidth = 51;
            this.dgvWlasciwosc.Size = new System.Drawing.Size(615, 366);
            this.dgvWlasciwosc.TabIndex = 29;
            this.dgvWlasciwosc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWlasciwosc_CellDoubleClick);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(44, 61);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(193, 22);
            this.txtFind.TabIndex = 28;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnPowrot
            // 
            this.btnPowrot.Location = new System.Drawing.Point(496, 40);
            this.btnPowrot.Margin = new System.Windows.Forms.Padding(4);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(123, 45);
            this.btnPowrot.TabIndex = 35;
            this.btnPowrot.Text = "Powrót";
            this.btnPowrot.UseVisualStyleBackColor = true;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "W celu edycji właściwości narzędzia kliknij dwukrotnie na wybraną właściwość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(61, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Wyszukaj narzędzie";
            // 
            // WlasciwoscNarzedzia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 498);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPowrot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvWlasciwosc);
            this.Controls.Add(this.txtFind);
            this.Name = "WlasciwoscNarzedzia";
            this.Text = "WlasciwoscNarzedzia";
            this.Load += new System.EventHandler(this.WlasciwoscNarzedzia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWlasciwosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DataGridView dgvWlasciwosc;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnPowrot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}