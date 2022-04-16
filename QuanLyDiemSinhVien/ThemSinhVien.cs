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
    public partial class ThemSinhVien : Form
    {
        private Database db = new Database();

        public ThemSinhVien()
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
            using (SqlConnection conn = new SqlConnection(db.connectionString))
            {

                string sql =
                    "insert into SinhVien(maSV,hoten,dob,gender,phone,email,diachia) values(' " + masv + " ',N'" + ten + "','" + ngaysinh + "',N'" + gioitinh + "','" + sdt + "','" + email + "','" + masv + "')";
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
                conn.Close();
            }

        }

        private void ThemSinhVien_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.Text = "Nam";
        }
    }
}
