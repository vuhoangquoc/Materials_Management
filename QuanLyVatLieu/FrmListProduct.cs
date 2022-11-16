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
    public partial class FrmListProduct : Form
    {
        
        HangHoaBLL HHBLL = new HangHoaBLL();
        public FrmListProduct()
        {
            InitializeComponent();
        }
        public string ma = "";
        private void FrmListProduct_Load(object sender, EventArgs e)
        {
            List<HangHoa> hangHoa = HHBLL.danhsach();
            dataGridView1.DataSource = hangHoa;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[2].HeaderText = "Mô tả";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Mã Loại";
            dataGridView1.Columns[5].HeaderText = "Xuất xứ";
            dataGridView1.Columns[6].HeaderText = "Loại hàng";

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "ImageColumn";
            imageColumn.HeaderText = "Hình ảnh";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(imageColumn);
            dataGridView1.RowTemplate.Height = 100;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "LoaiHang")
            {
                LoaiHang lh = (LoaiHang) e.Value;
                e.Value = lh.TenNH;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ImageColumn")
            {
                if (dataGridView1["HinhAnh", e.RowIndex].Value != null)
                {
                    string s = dataGridView1["HinhAnh", e.RowIndex].Value.ToString();

                    string specific_folder = AppDomain.CurrentDomain.BaseDirectory + "\\images\\";

                    e.Value = Image.FromFile(specific_folder + s);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            //int ma = int.Parse(txt_mafind.Text);
            //dataGridView1.DataSource = nv.TimNV(ma);
            if (txt_mafind.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //int ma = int.Parse(txt_mafind.Text);
                //dataGridView1.DataSource = HHBLL.TimHH(ma);

                //test
                string ma = txt_mafind.Text;
                dataGridView1.DataSource = HHBLL.TimHH(ma);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            //HHBLL.xoa(int.Parse(txtIdSP.Text));
            //txtIdSP.Text = "";

            /*
            if (ma.Length > 0)
            {
                int kq = 0;
                if (kq > 0)
                {
                    MessageBox.Show("Có lỗi trong khi xóa");
                }
                else
                {
                    MessageBox.Show("Xóa thành công nhân viên");
                    HHBLL.xoa(int.Parse(ma));
                    dataGridView1.DataSource = HHBLL.danhsach();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */

            /*
            int MHH = int.Parse("0" + txt_mafind.Text);
            HangHoaBLL MHBLL = new HangHoaBLL();
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MHBLL.xoa(MHH) == true)
                {
                    MessageBox.Show("Xóa mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmListProduct_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("bạn chưa nhập mã hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            */
            string MHH = txt_mafind.Text;
            HangHoaBLL MHBLL = new HangHoaBLL();
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MHBLL.xoa(MHH) == true)
                {
                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmListProduct_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtIdSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = HHBLL.danhsach();
        }

        private void btn_deleteIP_Click(object sender, EventArgs e)
        {
            txt_mafind.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
