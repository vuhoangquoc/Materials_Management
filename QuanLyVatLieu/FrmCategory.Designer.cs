namespace QuanLyVatLieu
{
    partial class FrmCategory
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
            this.panelNhapDM = new System.Windows.Forms.Panel();
            this.BtnReload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCatDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.panelNhapDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNhapDM
            // 
            this.panelNhapDM.Controls.Add(this.BtnReload);
            this.panelNhapDM.Controls.Add(this.btnSave);
            this.panelNhapDM.Controls.Add(this.txtCatDesc);
            this.panelNhapDM.Controls.Add(this.label2);
            this.panelNhapDM.Controls.Add(this.txtName);
            this.panelNhapDM.Controls.Add(this.label1);
            this.panelNhapDM.Location = new System.Drawing.Point(23, 42);
            this.panelNhapDM.Margin = new System.Windows.Forms.Padding(4);
            this.panelNhapDM.Name = "panelNhapDM";
            this.panelNhapDM.Size = new System.Drawing.Size(413, 345);
            this.panelNhapDM.TabIndex = 0;
            // 
            // BtnReload
            // 
            this.BtnReload.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReload.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnReload.Location = new System.Drawing.Point(274, 200);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(100, 38);
            this.BtnReload.TabIndex = 5;
            this.BtnReload.Text = "Làm mới";
            this.BtnReload.UseVisualStyleBackColor = false;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(142, 200);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCatDesc
            // 
            this.txtCatDesc.Location = new System.Drawing.Point(142, 69);
            this.txtCatDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatDesc.Multiline = true;
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.Size = new System.Drawing.Size(232, 99);
            this.txtCatDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên danh mục";
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(456, 42);
            this.dgvCategories.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.Size = new System.Drawing.Size(484, 345);
            this.dgvCategories.TabIndex = 2;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 654);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.panelNhapDM);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCategory";
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.panelNhapDM.ResumeLayout(false);
            this.panelNhapDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNhapDM;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCatDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Button BtnReload;
    }
}