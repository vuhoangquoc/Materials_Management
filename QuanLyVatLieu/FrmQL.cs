using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace QuanLyVatLieu
{
    public partial class FrmQL : Form
    {
        public FrmQL()
        {
            InitializeComponent();
        }
        NhanVienBLL nv = new NhanVienBLL();
        public string ma = "";
        public int check = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.DanhSachNV();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.DanhSachNV();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtChucVu.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbbGioitinh.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSodienthoai.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTendangnhap.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                //txtTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                //txt_HoTen.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                //txt_DiaChi.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                // txt_Username.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                // txt_Password.Text = dgv_NhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                // cbb_Quyen.SelectedValue = int.Parse(dgv_NhanVien.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            catch
            {

            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txt_mafind.Text);
            dataGridView1.DataSource = nv.TimNV(ma);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int MNV = int.Parse("0" + txt_mafind.Text);
            NhanVienBLL nv = new NhanVienBLL();
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nv.xoa(MNV) == true)
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mã nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.LayTatCa();
        }
    }
}
