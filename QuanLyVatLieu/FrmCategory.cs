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
    public partial class FrmCategory : Form
    {
        LoaiHangBLL LHBLL = new LoaiHangBLL();

        public FrmCategory()
        {
            InitializeComponent();
        }

        //public string ma2 = "";

        private void btnSave_Click(object sender, EventArgs e)
        {
            LHBLL.them(txtName.Text, txtCatDesc.Text);
            updateGrid();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void updateGrid()
        {
            dgvCategories.DataSource = LHBLL.danhsach();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            dgvCategories.DataSource = LHBLL.danhsach();
            txtCatDesc.Clear();
            txtName.Clear();
        }

        
    }
}

