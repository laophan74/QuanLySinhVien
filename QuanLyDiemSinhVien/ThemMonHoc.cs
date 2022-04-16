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
    public partial class ThemMonHoc : Form
    {
        private Database db = new Database();

        public ThemMonHoc()
        {
            InitializeComponent();
        }

        private void ThemMonHoc_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string ten = guna2TextBox_ten.Text;
            string sotc = guna2TextBox_soTC.Text;
            if (ten == "" || sotc == "" )             
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(db.connectionString))
            {

                string sql =
                    "insert into MonHoc(tenMH,soTC) values(N'" + ten + "'," + Convert.ToInt32(sotc) + ")";
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
                conn.Close();
            }
        }
    }
}
