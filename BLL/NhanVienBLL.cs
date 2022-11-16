using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        QLKhoDataContext DB = new QLKhoDataContext();

        public NhanVienBLL()
        {

        }

        public List<NhanVien> LayTatCa()
        {
            return DB.NhanViens.ToList();
        }

        public NhanVien layTheoMa(int ma)
        {
            return DB.NhanViens.Where(nv => nv.MaNV == ma).FirstOrDefault();
        }
        public NhanVien layTheoTendangnhapVaMatkhau(string tendangnhap, string matkhau)
        {
            return DB.NhanViens.Where(nv => nv.TenDangNhap == tendangnhap && nv.MatKhau == matkhau).FirstOrDefault();
        }

        public void Them(string tenNV, string chucVu, DateTime ngaySinh, int gioiTinh, string soDT, string tenDangNhap, string email, string matKhau, bool quanTriVien)
        {
            NhanVien nv = new NhanVien();

            nv.TenNV = tenNV;
            nv.ChucVu = chucVu;
            nv.NgaySinh = ngaySinh;
            nv.GioiTinh = gioiTinh;
            nv.SoDT = soDT;
            nv.TenDangNhap = tenDangNhap;
            nv.Email = email;
            nv.MatKhau = matKhau;
            nv.QuanTriVien = quanTriVien;

            DB.NhanViens.InsertOnSubmit(nv);

            DB.SubmitChanges();
        }

        public void Sua(int maNV, string tenNV, string chucVu, DateTime ngaySinh, int gioiTinh, string soDT, string tenDangNhap, string email, string matKhau, bool quanTriVien)
        {
            NhanVien nv = layTheoMa(maNV);

            nv.TenNV = tenNV;
            nv.ChucVu = chucVu;
            nv.NgaySinh = ngaySinh;
            nv.GioiTinh = gioiTinh;
            nv.SoDT = soDT;
            nv.TenDangNhap = tenDangNhap;
            nv.Email = email;
            nv.MatKhau = matKhau;
            nv.QuanTriVien = quanTriVien;

            DB.SubmitChanges();
        }

        public void CapNhat(int maNV, string tenNV, string chucVu, DateTime ngaySinh, int gioiTinh, string soDT, string tenDangNhap, string email)
        {
            NhanVien nv = layTheoMa(maNV);

            nv.TenNV = tenNV;
            nv.ChucVu = chucVu;
            nv.NgaySinh = ngaySinh;
            nv.GioiTinh = gioiTinh;
            nv.SoDT = soDT;
            nv.TenDangNhap = tenDangNhap;
            nv.Email = email;

            DB.SubmitChanges();
        }

        public void DoiMatKhau(int maNV, string matKhau)
        {
            NhanVien nv = layTheoMa(maNV);

            nv.MatKhau = matKhau;

            DB.SubmitChanges();
        }

        /*
        public void Xoa(int maNV)
        {
            NhanVien nv = layTheoMa(maNV);
            DB.NhanViens.DeleteOnSubmit(nv);
            DB.SubmitChanges();
        }
        */
        public bool xoa(int MNV)
        {
            /*
            HangHoa HH= DB.HangHoas.Where(hh => hh.MaHH == MaHH).FirstOrDefault();
            DB.HangHoas.DeleteOnSubmit(HH);
            DB.SubmitChanges();
            */
            NhanVien NV = DB.NhanViens.Where(nv => nv.MaNV == MNV).FirstOrDefault();
            if (NV != null)
            {
                DB.NhanViens.DeleteOnSubmit(NV);
                DB.SubmitChanges();
                return true;
            }
            else return false;
        }


        //test
        public List<NhanVien> DanhSachNV()
        {
            return DB.NhanViens.ToList();
        }

        public List<NhanVien> TimNV(int MaNV)
        {
            return DB.NhanViens.Where(nv => nv.MaNV == MaNV).ToList();
        }
        /*
        public void ThemNV(string Ten, string Gioitinh, int sdt, string Diachi, string username, string password)
        {
            NhanVien nv = new NhanVien();
            nv.TenNV = Ten;
            nv.SĐT = sdt;
            nv.GioiTinh = Gioitinh;
            nv.DiaChi = Diachi;
            nv.UserName = username;
            nv.PassWord = password;
            DB.NhanViens.InsertOnSubmit(nv);
            DB.SubmitChanges();
        }
        public void SuaNV(int ma, string Ten, string Gioitinh, int sdt, string Diachi, string username, string password)
        {
            NhanVien nv = DB.NhanViens.Where(nvien => nvien.Ma == ma).FirstOrDefault();
            nv.TenNV = Ten;
            nv.GioiTinh = Gioitinh;
            nv.SĐT = sdt;
            nv.DiaChi = Diachi;
            nv.UserName = username;
            nv.PassWord = password;
            DB.SubmitChanges();
        }
        public List<NhanVien> TimNV(int Ma)
        {
            return DB.NhanViens.Where(nv => nv.Ma == Ma).ToList();
        }
        public void Xoa2(int MaNV)
        {
            NhanVien nhanVien = DB.NhanViens.Where(nv => nv.Ma == MaNV).FirstOrDefault();
            DB.NhanViens.DeleteOnSubmit(nhanVien);
            DB.SubmitChanges();
        }
        */
    }
}
