using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace QuanLyVatLieu
{
    public partial class FrmLogin : Form
    {
        NhanVienBLL NVBLL = new NhanVienBLL();

        private static FrmLogin _instance;

        public static FrmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmLogin();
                return _instance;
            }
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string passwordHash = PasswordHelper.sha1Hash(tbMatkhau.Text);
            NhanVien nv = NVBLL.layTheoTendangnhapVaMatkhau(tbTaikhoan.Text, passwordHash);

            if(nv != null)
            {
                Close();
                if (Application.OpenForms["FrmMain"] != null)
                {
                    FrmMain frmMain = Application.OpenForms["FrmMain"] as FrmMain;
                    frmMain.isLoggedIn = true;
                    frmMain.nv = nv;
                    frmMain.CheckLogin();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
