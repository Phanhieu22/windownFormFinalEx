using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_thuoc
{
    public partial class TK_khach_hang : Form
    {
        public TK_khach_hang()
        {
            InitializeComponent();
        }

        private void rbt_ten_kh_CheckedChanged(object sender, EventArgs e)
        {
            txt_ma_kh.Enabled = false;
            txt_ten_kh.Enabled = true;
            txt_ma_kh.Clear();
        }

        private void rbt_ma_kh_CheckedChanged(object sender, EventArgs e)
        {
            txt_ten_kh.Enabled = false;
            txt_ma_kh.Enabled = true;
            txt_ten_kh.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (rbt_ten_kh.Checked == true)
            {
                sql = "select makhachhang , tenKhachHang ,diachi , soDienthoai from khachHang where khachHang.tenKhachHang ='" + txt_ten_kh.Text.Trim() + "'";
                DataTable dt2 = connect.query(sql);
                dataGridView1.DataSource = dt2;

            }
            else if (rbt_ma_kh.Checked == true)
            {
                sql = "select makhachhang , tenKhachHang ,diachi , soDienthoai from khachHang where khachHang.maKhachHang ='" + txt_ma_kh.Text.Trim() + "'";
                DataTable dt3 = connect.query(sql);
                dataGridView1.DataSource = dt3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select makhachhang , tenKhachHang ,diachi , soDienthoai from khachHang";
            dataGridView1.DataSource = connect.query(sql);
        }

        private void TK_khach_hang_Load(object sender, EventArgs e)
        {
            string sql = "select makhachhang , tenKhachHang ,diachi , soDienthoai from khachHang";
            dataGridView1.DataSource = connect.query(sql);
        }
    }
}
