using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO.Entities;
using QuanLyYTe.BUS;

namespace GUI.UI
{
    public partial class FrmKhoa : Form
    {
        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            Khoa = new KhoaBLL();
            khoaBLL.GetAllKhoa
            khoa = 
        }
        private void FillKhoa(List<Khoa> listKhoa)
        {
            dgv.Rows.Clear();
            foreach (Khoa bs in listKhoa)
            {
                int index = dgv.Rows.Add();
                dgv.Rows[index].Cells[0].Value = bs.MaKhoa;
                dgv.Rows[index].Cells[1].Value = bs.TenKhoa;
                dgv.Rows[index].Cells[2].Value = bs.MoTa;
            }
        }
    }
}
