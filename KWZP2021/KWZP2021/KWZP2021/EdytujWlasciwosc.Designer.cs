
namespace KWZP2021
{
    partial class EdytujWlasciwosc
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Location = new System.Drawing.Point(211, 142);
            this.btnCancelOperation.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(100, 44);
            this.btnCancelOperation.TabIndex = 45;
            this.btnCancelOperation.Text = "Anuluj";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 142);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 44);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Edytuj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Jednostka pomiarowa";
            // 
            // txtNIP
            // 
            this.txtNIP.Location = new System.Drawing.Point(168, 103);
            this.txtNIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(160, 22);
            this.txtNIP.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(82, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Edycja własciwości";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nazwa";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(168, 73);
            this.txtNew.Margin = new System.Windows.Forms.Padding(4);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(160, 22);
            this.txtNew.TabIndex = 39;
            // 
            // EdytujWlasciwosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 231);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNew);
            this.Name = "EdytujWlasciwosc";
            this.Text = "EdytujWlasciwosc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNew;
    }
}