using System;
using System.Collections.Generic;
using DAL.DAL;
using DTO.Entities;

namespace QuanLyYTe.BUS
{
    public class KhamBenhBUS
    {
        private KhamBenhDAL khamBenhDAL;

        public KhamBenhBUS()
        {
            khamBenhDAL = new KhamBenhDAL();
        }

        public bool ThemKhamBenh(int maBenhNhan, int maBacSi, DateTime ngayKham, string chanDoan, string thuoc, string ghiChu)
        {
            return khamBenhDAL.ThemKhamBenh(maBenhNhan, maBacSi, ngayKham, chanDoan, thuoc, ghiChu);
        }
    }
}
