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
using System.Data.SqlClient;

namespace QuanLyDiemSinhVien
{
    public partial class DangKyLop : Form
    {
        private Database db = new Database();
        public string tenSV;
        public DangKyLop()
        {
            InitializeComponent();
        }

        private void DangKyLop_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(db.connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select*from LopHoc", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(db.connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "select * from SinhVien where maSV = ' " + DangNhap.maSV + "'", con);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0) { tenSV = dt.Rows[0]["hoten"].ToString(); }

            }
            string malh = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            string maMH = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            string tenMH = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            string maGV = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            string tenGV = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            string maSV = DangNhap.maSV;


            using (SqlConnection conn = new SqlConnection(db.connectionString))
            {

                string sql = "insert into DangKyLop(maLH,maMH,tenMH,maGV,tenGV,maSV,tenSV,trangthai) " +
                    "values (" + malh + "," + maMH + ",N'" + tenMH + "'," + maGV + ",N'" + tenGV + "','" + maSV + "',N'"+tenSV+"',N'Đã đăng ký')";
                
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
                conn.Close();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(db.connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "select * from SinhVien where maSV = ' " + DangNhap.maSV + "'", con);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                if(dt.Rows.Count > 0) { tenSV = dt.Rows[0]["hoten"].ToString(); }
                
            }
            MessageBox.Show(tenSV);
        }
    }
}
