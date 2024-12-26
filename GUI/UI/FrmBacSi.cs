using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DTO.Entities;

namespace LabYTe3
{
    public partial class FrmBacSi : Form
    {
        public FrmBacSi()
        {
            InitializeComponent();
        }

        private void FrmBacSi_Load(object sender, EventArgs e)
        {
            try
            {
                List<BacSi> bacSis = new List<BacSi>();
                FillBS(bacSis);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillBS(List<BacSi> listBS)
        {
            dgvBacSi.Rows.Clear();
            foreach (BacSi bs in listBS)
            {
                int index = dgvBacSi.Rows.Add();
                dgvBacSi.Rows[index].Cells[0].Value = bs.MaBacSi;
                dgvBacSi.Rows[index].Cells[1].Value = bs.HoTen;
                dgvBacSi.Rows[index].Cells[2].Value = bs.MaKhoa;             
                dgvBacSi.Rows[index].Cells[3].Value = bs.SoDienThoai;
                dgvBacSi.Rows[index].Cells[4].Value = bs.Email;
            }
        }
        private void Clear()
        {
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtMaKhoa.Text = "";
            txtSoDienThoai.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBacSi.Rows[e.RowIndex];
                txtMaBacSi.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtMaKhoa.Text = row.Cells[2].Value.ToString();
                txtSoDienThoai.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
