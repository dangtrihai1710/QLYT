using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
     public class KhamBenhDAL
    {
        private string connectionString = "DBContextYT";
        public bool ThemKhamBenh(int maBenhNhan, int maBacSi, DateTime ngayKham, string chanDoan, string thuoc, string ghiChu)
        {
            string query = @"
                INSERT INTO KhamBenh (MaBenhNhan, MaBacSi, NgayKham, ChanDoan, Thuoc, GhiChu)
                VALUES (@MaBenhNhan, @MaBacSi, @NgayKham, @ChanDoan, @Thuoc, @GhiChu);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaBenhNhan", maBenhNhan);
                    command.Parameters.AddWithValue("@MaBacSi", maBacSi);
                    command.Parameters.AddWithValue("@NgayKham", ngayKham);
                    command.Parameters.AddWithValue("@ChanDoan", chanDoan);
                    command.Parameters.AddWithValue("@Thuoc", thuoc);
                    command.Parameters.AddWithValue("@GhiChu", ghiChu);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Log lỗi hoặc xử lý lỗi
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }


    }



}
