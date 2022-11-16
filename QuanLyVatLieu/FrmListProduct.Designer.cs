namespace QuanLyVatLieu
{
    partial class FrmListProduct
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.txt_mafind = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_deleteIP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(792, 402);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnXoa.Location = new System.Drawing.Point(182, 468);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(93, 38);
            this.BtnXoa.TabIndex = 5;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_reload.Location = new System.Drawing.Point(182, 531);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(93, 58);
            this.btn_reload.TabIndex = 9;
            this.btn_reload.Text = "Làm mới danh sách";
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // txt_mafind
            // 
            this.txt_mafind.Location = new System.Drawing.Point(163, 420);
            this.txt_mafind.Name = "txt_mafind";
            this.txt_mafind.Size = new System.Drawing.Size(212, 22);
            this.txt_mafind.TabIndex = 17;
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_tim.Location = new System.Drawing.Point(282, 468);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(93, 38);
            this.btn_tim.TabIndex = 18;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_deleteIP
            // 
            this.btn_deleteIP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_deleteIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteIP.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteIP.Location = new System.Drawing.Point(81, 468);
            this.btn_deleteIP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteIP.Name = "btn_deleteIP";
            this.btn_deleteIP.Size = new System.Drawing.Size(93, 38);
            this.btn_deleteIP.TabIndex = 19;
            this.btn_deleteIP.Text = "Làm mới";
            this.btn_deleteIP.UseVisualStyleBackColor = false;
            this.btn_deleteIP.Click += new System.EventHandler(this.btn_deleteIP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deleteIP);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_mafind);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListProduct";
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.FrmListProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.TextBox txt_mafind;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_deleteIP;
        private System.Windows.Forms.Label label1;
    }
}