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

    public partial class QL_kho_thuoc : Form
    {
        public QL_kho_thuoc()
        {
            InitializeComponent();
        }

        private void QL_kho_thuoc_Load(object sender, EventArgs e)
        {
            string selectAll = "Select * from Thuoc";
            dataGridView1.DataSource = connect.query(selectAll);
        }
        public bool kt_du_lieu()
        {
            string tenThuoc = txt_ten_thuoc.Text.Trim();
            string congDung = txt_cong_dung.Text.Trim();
            DateTime ngaySanXuat = dtp_ngay_xs.Value;
            DateTime ngayHetHan = dtp_ngay_hh.Value;
            string donViTinh = txt_don_vi_tinh.Text.Trim();
            int soLuongNhap = Int32.Parse(txt_so_luong_nhap.Text);
            float giaBan = float.Parse(txt_gia_ban.Text);
            float giaNhap = float.Parse(txt_gia_nhap.Text);


            if (tenThuoc == "")
            {
                MessageBox.Show("trườn tên thuốc là bắt buộc", "cảnh báo", MessageBoxButtons.YesNo);
                txt_ten_thuoc.Focus();
                return false;

            }
            if (congDung == "")
            {
                MessageBox.Show("vui lòng nhập trường công dụng", "cảnh báo", MessageBoxButtons.YesNo);
                txt_cong_dung.Focus();
                return false;

            }
            if (ngaySanXuat == null)
            {
                MessageBox.Show("Ngày sản xuất là trường bắt buộc", "cảnh báo", MessageBoxButtons.YesNo);
                dtp_ngay_xs.Focus();
                return false;

            }
            if (ngayHetHan == null)
            {
                MessageBox.Show("ngày hết hạn là trường bắt buộc", "cảnh báo", MessageBoxButtons.YesNo);
                dtp_ngay_hh.Focus();
                return false;

            }
            if (donViTinh == "")
            {
                MessageBox.Show("vui lòng nhập trường công dụng", "cảnh báo", MessageBoxButtons.YesNo);
                txt_don_vi_tinh.Focus();
                return false;

            }
            if (giaBan < 0)
            {

                MessageBox.Show("trường giá bán là trường bắt buộc và phải lơn hơn 0", "cảnh báo", MessageBoxButtons.YesNo);
                txt_gia_ban.Focus();
                return false;
            }
            if (giaNhap < 0)
            {

                MessageBox.Show("trường giá nhập là trường bắt buộc và phải lơn hơn 0", "cảnh báo", MessageBoxButtons.YesNo);
                txt_gia_nhap.Focus();
                return false;
            }
            if (soLuongNhap < 0)
            {

                MessageBox.Show("trường số lượng nhập là trường bắt buộc và phải lơn hơn 0", "cảnh báo", MessageBoxButtons.YesNo);
                txt_so_luong_nhap.Focus();
                return false;
            }

            return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // thêm btn
            string tenThuoc = txt_ten_thuoc.Text.Trim();
            string congDung = txt_cong_dung.Text.Trim();
            DateTime ngaySanXuat = dtp_ngay_xs.Value;
            DateTime ngayHetHan = dtp_ngay_hh.Value;
            string donViTinh = txt_don_vi_tinh.Text.Trim();
            int soLuongNhap = Int32.Parse(txt_so_luong_nhap.Text);
            float giaBan = float.Parse(txt_gia_ban.Text);
            float giaNhap = float.Parse(txt_gia_nhap.Text);

            if (kt_du_lieu())
            {
                string maThuoc = FormMdi.randomId("T");
                if (!connect.checkUniqueThuoc(maThuoc)) {
                    string sqlInsert = "insert into Thuoc(maThuoc ,  tenThuoc,  congDung, ngaySanXuat, ngayHetHan,giaNhap, giaBan , soLuongNhap,donViTinh) values('"+ maThuoc + "', N'"+tenThuoc+ "',  N'" + congDung + "',  '" + ngaySanXuat + "',  '" + ngayHetHan + "', '" + giaNhap + "',  '" + giaBan + "',  '" + soLuongNhap + "',  N'" + donViTinh + "')";
                    connect.execution(sqlInsert);

                    string selectAll = "select * from thuoc";
                    dataGridView1.DataSource = connect.query(selectAll);
                }
                else
                {
                    MessageBox.Show("giá trị id chưa hợp lệ");

                }
            }
           
                    
            else
            {
                MessageBox.Show("giá trị nhập chưa hợp lệ");
            }

            //MessageBox.Show(FormMdi.randomId("kh"));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
