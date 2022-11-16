using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatLieu
{
    public partial class FrmMain : Form
    {
        private Form FormShowing;
        public bool isLoggedIn = false;
        public NhanVien nv;
        public Button btnListInstance = new Button();
        public FrmMain()
        {
            InitializeComponent();
            nv = new NhanVien();
            btnListInstance = this.BtnList;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CheckLogin();
        }

        public void CheckLogin()
        {
            if (isLoggedIn)
            {
                BtnAddCategories.Enabled = true;
                BtnChangePw.Enabled = true;
                BtnCreate.Enabled = true;
                BtnList.Enabled = true;
                BtnLogout.Enabled = true;
                BtnInfo.Enabled = true;
                BtnLogin.Enabled = false;
                BtnSignUp.Enabled = false;

                if (nv.QuanTriVien == true)
                {
                 btnQL.Enabled = true;
                }    

                BtnList.PerformClick();
            }
            else
            {
                BtnAddCategories.Enabled = false;
                BtnChangePw.Enabled = false;
                BtnCreate.Enabled = false;
                BtnList.Enabled = false;
                BtnLogout.Enabled = false;
                BtnInfo.Enabled = false;
                BtnLogin.Enabled = true;
                BtnSignUp.Enabled = true;
                btnQL.Enabled = false;

                ShowForm(new FrmLogin());
            }
        }
        private void ShowForm(Form frm)
        {
            if (FormShowing != null) FormShowing.Close();
            FormShowing = frm;

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            PanelShowForm.Controls.Add(FormShowing);
            PanelShowForm.Tag = FormShowing;

            frm.BringToFront();
            frm.Show();
        }
        private void BtnChangePw_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmChangePw());
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmLogin());

        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmRegister());

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            isLoggedIn = false;
            CheckLogin();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmProfile());

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmProducts());

        }

        private void BtnAddCategories_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmCategory());

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmListProduct());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelShowForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmQL());
        }
    }
}
