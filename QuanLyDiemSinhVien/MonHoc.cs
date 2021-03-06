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
    public partial class MonHoc : Form
    {
        private Database db = new Database();
        public static string mamh;
        public MonHoc()
        {
            InitializeComponent();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            //Load dữ liệu từ database sql lên datagridview
            using (SqlConnection conn = new SqlConnection(db.connectionString))
            {
                //Mở kết nối
                conn.Open();
                //Sử dụng câu lệnh như trong sql : select,delete,update...
                SqlDataAdapter adapter = new SqlDataAdapter("select*from MonHoc", conn);
                //Chuyển dữ liệu qua dạng datatable để đưa lên datagridview
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //đưa dữ liệu lên datagridview
                guna2DataGridView1.DataSource = dt;
                //Khi dùng xong phải đóng kết nối
                conn.Close();
            }
        }

        private void guna2DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int numrow = guna2DataGridView1.Rows.Count;
            label1.Text = numrow.ToString();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            mamh = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();

            string sql = "delete from MonHoc where maMH='" + mamh + "'";
            if (MessageBox.Show("Bạn có muốn xóa!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(db.connectionString))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Thành công!");
                    con.Close();
                }
                guna2DataGridView1.Refresh();
                //Load lại datagridview
                using (SqlConnection conn = new SqlConnection(db.connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select*from MonHoc", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    guna2DataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThemMonHoc themMonHoc = new ThemMonHoc();
            themMonHoc.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            mamh = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();

            SuaMonHoc suaMonHoc = new SuaMonHoc();
            suaMonHoc.ShowDialog();
        }
    }
}
