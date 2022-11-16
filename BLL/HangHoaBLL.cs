using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;

namespace BLL
{
    public class HangHoaBLL
    {
        QLKhoDataContext DB = new QLKhoDataContext();

        public HangHoaBLL()
        {

        }

        public List<HangHoa> danhsach()
        {
            return DB.HangHoas.ToList();
        }

        public void them(string ten,string mota,string hinhanh,int maNhomHang, string xuatxu)
        {
            HangHoa hh = new HangHoa();
            hh.TenHH = ten;
            hh.MoTa = mota;
            hh.HinhAnh = hinhanh;
            hh.MaNH = maNhomHang;
            hh.XuatXu = xuatxu;

            DB.HangHoas.InsertOnSubmit(hh);
            DB.SubmitChanges();
        }
        /*
        public List<HangHoa> TimHH(int MaHH)
        {
            //return DB.HangHoas.Where(hh => hh.MaHH == MaHH).ToList();
            return DB.HangHoas.Where(hh => hh.MaHH == MaHH).ToList();
        }
        */
        //test
        public List<HangHoa> TimHH(string TenHH)
        {
            //return DB.HangHoas.Where(hh => hh.MaHH == MaHH).ToList();
            return DB.HangHoas.Where(hh => hh.TenHH == TenHH).ToList();
        }

        /*
        public bool xoa(int MHH)
        {
            /*
            HangHoa HH= DB.HangHoas.Where(hh => hh.MaHH == MaHH).FirstOrDefault();
            DB.HangHoas.DeleteOnSubmit(HH);
            DB.SubmitChanges();
            */
        /*
            HangHoa HH = DB.HangHoas.Where(hh => hh.MaHH == MHH).FirstOrDefault();
            if (HH != null)
            {
                DB.HangHoas.DeleteOnSubmit(HH);
                DB.SubmitChanges();
                return true;
            }
            else return false;
        }
        */

        //test
        public bool xoa(string MHH)
        {
            /*
            HangHoa HH= DB.HangHoas.Where(hh => hh.MaHH == MaHH).FirstOrDefault();
            DB.HangHoas.DeleteOnSubmit(HH);
            DB.SubmitChanges();
            */
            HangHoa HH = DB.HangHoas.Where(hh => hh.TenHH == MHH).FirstOrDefault();
            if (HH != null)
            {
                DB.HangHoas.DeleteOnSubmit(HH);
                DB.SubmitChanges();
                return true;
            }
            else return false;
        }
    }
}
