using System.Collections.Generic;
using System.Data;
using DAL.DAL;
using DTO.Entities;

namespace QuanLyYTe.BUS
{
    public class KhoaBUS
    {
        private KhoaDAL khoaDAL;

        public KhoaBUS()
        {
            khoaDAL = new KhoaDAL();
        }

        public List<Khoa> GetAllKhoa()
        {
            return khoaDAL.LayDanhSachKhoa();
        }

        public bool AddKhoa(int maKhoa, string tenKhoa, string moTa)
        {
            return khoaDAL.ThemKhoa(maKhoa, tenKhoa, moTa);
        }

        public bool UpdateKhoa(int maKhoa, string tenKhoa, string moTa)
        {
            return khoaDAL.CapNhatKhoa(maKhoa, tenKhoa, moTa);
        }

        public bool DeleteKhoa(int maKhoa)
        {
            return khoaDAL.XoaKhoa(maKhoa); 
        }
    }
}
