﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class Main_GiaoVien : Form
    {
        public Main_GiaoVien()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.panel_Container.Controls.Clear();
            SinhVien a = new SinhVien();
            a.TopLevel = false;
            a.Dock = DockStyle.Fill;
            this.panel_Container.Controls.Add(a);
            a.Show();
        }
    }
}