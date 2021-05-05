
namespace KWZP2021
{
    partial class DostawaMaterialu
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPowrot = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDostawa = new System.Windows.Forms.DataGridView();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostawa)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(677, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "W celu otworzenia szczegółów dostawy materiału kliknij dwukrotnie na wybraną dost" +
    "awę\r\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 56);
            this.button2.TabIndex = 53;
            this.button2.Text = "Dodaj materiał do dostawy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPowrot
            // 
            this.btnPowrot.Location = new System.Drawing.Point(221, 68);
            this.btnPowrot.Margin = new System.Windows.Forms.Padding(4);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(165, 67);
            this.btnPowrot.TabIndex = 51;
            this.btnPowrot.Text = "Powrót";
            this.btnPowrot.UseVisualStyleBackColor = true;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(221, 20);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 40);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 85);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 50);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Przyjmij nową dostawę";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDostawa
            // 
            this.dgvDostawa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostawa.Location = new System.Drawing.Point(13, 177);
            this.dgvDostawa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDostawa.Name = "dgvDostawa";
            this.dgvDostawa.RowHeadersWidth = 51;
            this.dgvDostawa.Size = new System.Drawing.Size(854, 323);
            this.dgvDostawa.TabIndex = 47;
            this.dgvDostawa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDostawa_CellDoubleClick);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(485, 99);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(330, 22);
            this.txtFind.TabIndex = 46;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(524, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Wyszukaj dostawę po nazwisku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(524, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 29);
            this.label3.TabIndex = 56;
            this.label3.Text = "Dostawa materiału";
            // 
            // DostawaMaterialu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPowrot);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDostawa);
            this.Controls.Add(this.txtFind);
            this.Name = "DostawaMaterialu";
            this.Text = "DostawaMaterialu";
            this.Load += new System.EventHandler(this.DostawaMaterialu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostawa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPowrot;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DataGridView dgvDostawa;
        private System.Windows.Forms.TextBox txtFind;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}