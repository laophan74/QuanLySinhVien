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
    public partial class SuaGiaoVien : Form
    {
        private Database db = new Database();
        public SuaGiaoVien()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string ten = guna2TextBox_user.Text;
            string ngaysinh = this.dateTimePicker1.Text;
            string gioitinh = guna2ComboBox1.SelectedItem.ToString();
            string sdt = guna2TextBox_sdt.Text;
            string email = guna2TextBox_email.Text;
            string diachi = guna2TextBox_diachi.Text;

            if (ten == "" || gioitinh == "" ||
                sdt == "" || email == "" || diachi == "" )
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(db.connectionString))
            {

                string sql =
                    "update GiaoVien set hoten = N'" + ten + "', dob = '" + ngaysinh + "', gender = N'" + gioitinh + "', phone = '" + sdt + "', email = '" + email + "', diachia = N'" + diachi + "' where maGV = '" + GiaoVien.magv + "'";
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
                conn.Close();
            }
        }
    }
}
