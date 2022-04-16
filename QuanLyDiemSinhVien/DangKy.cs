using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyDiemSinhVien
{
    public partial class DangKy : Form
    {
        private Database db = new Database();

        public DangKy()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string tk = guna2TextBox_user.Text;
            string mk = guna2TextBox_mk.Text;
            string rt = guna2TextBox_retp.Text;

            if(tk == "" || mk == "" || rt == "" || mk != rt)
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            using(SqlConnection conn = new SqlConnection(db.connectionString))
            {
                int loaiTk;
                if(guna2ComboBox1.SelectedItem.ToString() == "Sinh Viên")
                {
                    loaiTk = 1;
                }
                else
                {
                    loaiTk = 2;
                }
                string sql =
                    "insert into TaiKhoan(taikhoan,matkhau,loaiTK) values ('"+tk+ "','" + mk + "',"+loaiTk+")";
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Đăng ký thành công!");
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
                conn.Close();
            }
        }
    }
}
