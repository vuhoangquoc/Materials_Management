using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LoaiHangBLL
    {
        QLKhoDataContext DB = new QLKhoDataContext();

        public LoaiHangBLL()
        {

        }

        public void them(string ten, string mota)
        {
            LoaiHang lh = new LoaiHang();
            lh.TenNH = ten;
            lh.MoTa = mota;

            DB.LoaiHangs.InsertOnSubmit(lh);
            DB.SubmitChanges();
        }

        public List<LoaiHang> danhsach()
        {
            return DB.LoaiHangs.ToList();
        }

        public void capnhat()
        {
            
        }

        /*
        public void xoa(int idMH)
        {
            LoaiHang LH = DB.LoaiHangs.Where(lh => lh.MaNH == idMH).FirstOrDefault();
            DB.LoaiHangs.DeleteOnSubmit(LH);
            DB.SubmitChanges();
        }
        */

        public List<HangHoa> TimLH(int MaNH)
        {
            //return DB.HangHoas.Where(hh => hh.MaHH == MaHH).ToList();
            return DB.HangHoas.Where(lh => lh.MaNH == MaNH).ToList();
        }

        public bool xoa(int MNH)
        {
            /*
            HangHoa HH= DB.HangHoas.Where(hh => hh.MaHH == MaHH).FirstOrDefault();
            DB.HangHoas.DeleteOnSubmit(HH);
            DB.SubmitChanges();
            */
            HangHoa LH = DB.HangHoas.Where(lh => lh.MaNH == MNH).FirstOrDefault();
            if (LH != null)
            {
                DB.HangHoas.DeleteOnSubmit(LH);
                DB.SubmitChanges();
                return true;
            }
            else return false;
        }
    }
}
