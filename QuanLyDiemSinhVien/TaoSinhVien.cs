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


namespace QuanLyDiemSinhVien
{
    public partial class TaoSinhVien : Form
    {
        private Database db = new Database();
        public static string maSinhVien;
        public TaoSinhVien()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string masv = guna2TextBox1.Text;
            string ten = guna2TextBox_user.Text;
            string ngaysinh = this.dateTimePicker1.Text;
            string gioitinh = guna2ComboBox1.SelectedItem.ToString();
            string sdt = guna2TextBox_sdt.Text;
            string email = guna2TextBox_email.Text;
            string diachi = guna2TextBox_diachi.Text;

            if (ten == "" || gioitinh == "" ||
                sdt == "" || email == "" || diachi == "" || masv == "")
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            else { 
            using (SqlConnection conn = new SqlConnection(db.connectionString))
            {

                string sql =
                    "insert into SinhVien(maSV,hoten,dob,gender,phone,email,diachia) values(' " + masv + " ',N'" + ten + "','" + ngaysinh + "',N'" + gioitinh + "','" + sdt + "','" + email + "',N'" + diachi + "')";
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thành công!");

                maSinhVien = masv;
                    string sql1 = "update TaiKhoan set maSV = '"+masv+"' where taikhoan ='"+DangKy.taikhoan+"'";
                    SqlCommand sqlCommandd = new SqlCommand(sql1, conn);
                    sqlCommandd.ExecuteNonQuery();

                    conn.Close();
            }
                this.Hide();
                DangNhap dang = new DangNhap();
                dang.ShowDialog();
        }
        }

        private void TaoSinhVien_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.Text = "Nam";
        }
    }
}
