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
    public partial class FrmChangePw : Form
    {
        public int manhanvien;
        NhanVienBLL NVBLL = new NhanVienBLL();
        public FrmChangePw()
        {
            InitializeComponent();
        }

        private void btnChangPw_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = Application.OpenForms["FrmMain"] as FrmMain;
            //nv = NVBLL.layTheoMa(manhanvien);
            NhanVien nv = frmMain.nv;
            if (txtPass.Text == txtRetypePw.Text)
            {
                try
                {
                    string passwordHash = PasswordHelper.sha1Hash(txtPass.Text.Trim());
                    NVBLL.DoiMatKhau(nv.MaNV, passwordHash);
                    DialogResult dl = MessageBox.Show("Đổi mật khẩu thành công!","",MessageBoxButtons.OK);
                    if(dl == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                    throw ex;
                }
            }else
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu!");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
