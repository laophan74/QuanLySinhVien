namespace QuanLyDiemSinhVien
{
    partial class ThemLopHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 5;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(40, 45);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(296, 36);
            this.guna2ComboBox1.TabIndex = 0;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderRadius = 5;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Location = new System.Drawing.Point(40, 113);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(296, 36);
            this.guna2ComboBox2.TabIndex = 1;
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 19;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.guna2Button2.Location = new System.Drawing.Point(195, 168);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(141, 41);
            this.guna2Button2.TabIndex = 38;
            this.guna2Button2.Text = "Thêm";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // ThemLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 234);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Name = "ThemLopHoc";
            this.Text = "ThemLopHoc";
            this.Load += new System.EventHandler(this.ThemLopHoc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}