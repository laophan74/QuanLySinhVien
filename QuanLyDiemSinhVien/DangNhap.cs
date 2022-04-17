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
    public partial class DangNhap : Form
    {
        private Database db = new Database();
        public DangNhap()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string tk = guna2TextBox1.Text;
            string mk = guna2TextBox3.Text;
            string sql =
                    "select*from TaiKhoan where taikhoan ='" + tk + "' and matkhau ='" + mk + "'";

            if(tk =="" || mk == "")
            {
                MessageBox.Show("Xin nhập thông tin", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(db.connectionString);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0)
                {
                    switch (dt.Rows[0]["loaiTK"].ToString())
                    {
                        case "1":
                            {
                                MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK);

                                this.Hide();
                                Main_SinhVien m = new Main_SinhVien();
                                m.ShowDialog();
                                break;
                            }
                        case "2":
                            {
                                MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK);

                                this.Hide();
                                Main_GiaoVien m = new Main_GiaoVien();
                                m.ShowDialog();
                                break;
                            }

                        default:
                            {
                                MessageBox.Show("error");
                                break;
                            }
                    }

                }
                else
                {
                    MessageBox.Show("Nhập sai thông tin!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập sai thông tin!");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dang = new DangKy();
            dang.ShowDialog();
        }
    }
}
