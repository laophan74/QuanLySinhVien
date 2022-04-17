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
    public partial class ThemLopHoc : Form
    {
        private Database db = new Database();

        public ThemLopHoc()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string tenMH = guna2ComboBox1.SelectedItem.ToString();
            string tenGV = guna2ComboBox2.SelectedItem.ToString();
            string maMH = "";
            string maGV = "";
            try
            {
                //Lấy mã môn học
                SqlConnection conn = new SqlConnection(db.connectionString);
                string sql = "select*from MonHoc where tenMH =N'" + tenMH + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0)
                {
                    maMH = dt.Rows[0]["maMH"].ToString();
                }

                string sql1 = "select*from GiaoVien where hoten =N'" + tenGV + "'";
                SqlCommand cmdd = new SqlCommand(sql1, conn);
                conn.Open();
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmdd);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                conn.Close();
                if(dt1.Rows.Count > 0)
                {
                    maGV = dt1.Rows[0]["maGV"].ToString();
                }

                //Them vao database
                string sqll =
                    "insert into LopHoc(maMH,tenMH,tenGV,maGV) values(" + maMH + ",N'" + tenMH + "',N'" + tenGV + "'," + maGV + ")";
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sqll, conn);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập sai thông tin!");
            }

        }

        private void ThemLopHoc_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select tenMH from MonHoc";

                SqlConnection conn = new SqlConnection(db.connectionString);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    guna2ComboBox1.Items.Add(dr["tenMH"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string sql = "select hoten from GiaoVien";

                SqlConnection conn = new SqlConnection(db.connectionString);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    guna2ComboBox2.Items.Add(dr["hoten"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
