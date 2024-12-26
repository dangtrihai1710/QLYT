using DTO.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class LichSuKhamDAL
    {

        private string connectionString = "DBContextYT";


        public List<KhamBenh> GetLichSuKhamByBenhNhan(int maBenhNhan)
        {
            List<KhamBenh> danhSachLichSu = new List<KhamBenh>();

            string query = "SELECT * FROM KhamBenh WHERE MaBenhNhan = @MaBenhNhan";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    KhamBenh khamBenh = new KhamBenh
                    {
                        MaKhamBenh = (int)reader["MaKhamBenh"],
                        MaBenhNhan = (int)reader["MaBenhNhan"],
                        MaBacSi = reader["MaBacSi"] as int?,
                        NgayKham = (DateTime)reader["NgayKham"],
                        ChanDoan = reader["ChanDoan"].ToString(),
                        Thuoc = reader["Thuoc"].ToString(),
                        GhiChu = reader["GhiChu"].ToString()
                    };
                    danhSachLichSu.Add(khamBenh);
                }
            }
            return danhSachLichSu;
        }


        


    }
}
