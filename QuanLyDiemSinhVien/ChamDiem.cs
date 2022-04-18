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
    public partial class ChamDiem : Form
    {
        private Database db = new Database();
        public static string maSVV;
        public static string maMHH;

        public ChamDiem()
        {
            InitializeComponent();
        }

        private void ChamDiem_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(db.connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select maMH,tenMH,maSV,tenSV,diemGK,diemCK from DangKyLop where maLH = "+LopHoc.malh+"", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            maMHH = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            maSVV = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            ChamDiem1 chamDiem = new ChamDiem1();
            chamDiem.ShowDialog();
        }
    }
}
