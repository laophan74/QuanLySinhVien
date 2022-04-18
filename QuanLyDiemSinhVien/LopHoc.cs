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
    public partial class LopHoc : Form
    {
        private Database db = new Database();
        public static string malh;

        public LopHoc()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThemLopHoc themLopHoc = new ThemLopHoc();
            themLopHoc.ShowDialog();
        }

        private void LopHoc_Load(object sender, EventArgs e)
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

        private void guna2DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int numrow = guna2DataGridView1.Rows.Count;
            label1.Text = numrow.ToString();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            malh = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();

            string sql = "delete from LopHoc where maLH='" + malh + "'";
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
                    SqlDataAdapter adapter = new SqlDataAdapter("select*from LopHoc", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    guna2DataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            malh = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            ChamDiem chamDiem = new ChamDiem();
            chamDiem.ShowDialog();
        }
    }
}
