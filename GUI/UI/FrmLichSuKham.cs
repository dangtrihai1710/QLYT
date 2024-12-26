using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI
{
    public partial class FrmLichSuKham : Form
    {
        public FrmLichSuKham()
        {
            InitializeComponent();
        }
        public FrmLichSuKham(String MaBenhNhan)
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string input = txtTimKiem.Text;
            if (System.Text.RegularExpressions.Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Chuỗi chỉ chứa chữ cái");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d+$"))
            {
                MessageBox.Show("Chuỗi chỉ chứa số");
            }
        }
    }
}
