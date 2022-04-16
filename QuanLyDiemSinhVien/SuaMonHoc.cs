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
    public partial class SuaMonHoc : Form
    {
        private Database db = new Database();

        public SuaMonHoc()
        {
            InitializeComponent();
        }

        private void SuaMonHoc_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string ten = guna2TextBox_ten.Text;
            string sotc = guna2TextBox_soTC.Text;
            if (ten == "" || sotc == "")
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(db.connectionString))
            {

                string sql =
                    "update MonHoc set tenMH = N'" + ten + "', soTC = " + Convert.ToInt32(sotc) + " where maMH = " + Convert.ToInt32(MonHoc.mamh);
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
                conn.Close();
            }
        }
    }
}
