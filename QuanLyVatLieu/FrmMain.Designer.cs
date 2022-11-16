
namespace QuanLyVatLieu
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQL = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnAddCategories = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnChangePw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelShowForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQL);
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.BtnSignUp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnList);
            this.panel1.Controls.Add(this.BtnAddCategories);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnInfo);
            this.panel1.Controls.Add(this.BtnChangePw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(265, 638);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnQL
            // 
            this.btnQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQL.Location = new System.Drawing.Point(10, 492);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(245, 50);
            this.btnQL.TabIndex = 16;
            this.btnQL.Text = "Quản lý nhân viên";
            this.btnQL.UseVisualStyleBackColor = true;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Red;
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(10, 568);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(245, 60);
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.Text = "Đăng xuất";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogin.Location = new System.Drawing.Point(10, 442);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(245, 50);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Đăng nhập";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSignUp.Location = new System.Drawing.Point(10, 393);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(245, 49);
            this.BtnSignUp.TabIndex = 5;
            this.BtnSignUp.Text = "Đăng ký";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 348);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label3.Size = new System.Drawing.Size(245, 45);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đăng ký, đăng nhập";
            // 
            // BtnList
            // 
            this.BtnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnList.Location = new System.Drawing.Point(10, 295);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(245, 53);
            this.BtnList.TabIndex = 14;
            this.BtnList.Text = "Danh sách";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnAddCategories
            // 
            this.BtnAddCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddCategories.Location = new System.Drawing.Point(10, 242);
            this.BtnAddCategories.Name = "BtnAddCategories";
            this.BtnAddCategories.Size = new System.Drawing.Size(245, 53);
            this.BtnAddCategories.TabIndex = 13;
            this.BtnAddCategories.Text = "Nhập danh mục";
            this.BtnAddCategories.UseVisualStyleBackColor = true;
            this.BtnAddCategories.Click += new System.EventHandler(this.BtnAddCategories_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCreate.Location = new System.Drawing.Point(10, 189);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(245, 53);
            this.BtnCreate.TabIndex = 12;
            this.BtnCreate.Text = "Tạo phiếu nhập";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 144);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label2.Size = new System.Drawing.Size(245, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quản lý";
            // 
            // BtnInfo
            // 
            this.BtnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInfo.Location = new System.Drawing.Point(10, 91);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(245, 53);
            this.BtnInfo.TabIndex = 7;
            this.BtnInfo.Text = "Thông tin";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnChangePw
            // 
            this.BtnChangePw.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnChangePw.Location = new System.Drawing.Point(10, 38);
            this.BtnChangePw.Name = "BtnChangePw";
            this.BtnChangePw.Size = new System.Drawing.Size(245, 53);
            this.BtnChangePw.TabIndex = 3;
            this.BtnChangePw.Text = "Đổi mật khẩu";
            this.BtnChangePw.UseVisualStyleBackColor = true;
            this.BtnChangePw.Click += new System.EventHandler(this.BtnChangePw_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // PanelShowForm
            // 
            this.PanelShowForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelShowForm.Location = new System.Drawing.Point(265, 0);
            this.PanelShowForm.Name = "PanelShowForm";
            this.PanelShowForm.Size = new System.Drawing.Size(567, 638);
            this.PanelShowForm.TabIndex = 1;
            this.PanelShowForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelShowForm_Paint);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 638);
            this.Controls.Add(this.PanelShowForm);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản lý vật liệu xây dựng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnChangePw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelShowForm;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnAddCategories;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQL;
    }
}