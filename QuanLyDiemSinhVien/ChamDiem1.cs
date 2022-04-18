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
    public partial class ChamDiem1 : Form
    {
        private Database db = new Database();

        public ChamDiem1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string diemGK = guna2TextBox1.Text;
            string diemCK = guna2TextBox2.Text;
            using (SqlConnection conn = new SqlConnection(db.connectionString))
            {

                string sql = 
                    "update DangKyLop set diemGK = "+diemGK+",diemCK = "+diemCK+" where maSV = '"+ChamDiem.maSVV+"' and maMH = '"+ChamDiem.maMHH+"' ";
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
                conn.Close();
            }
        }
    }
}
