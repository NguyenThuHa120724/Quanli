using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quanli
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>(); // Danh sách người dùng

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu tên đăng nhập và mật khẩu không được để trống
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm người dùng trong danh sách theo tên đăng nhập và mật khẩu
            User user = users.Find(u => u.Tendangnhap == textBox1.Text && u.Matkhau == textBox2.Text);
            if (user != null)
            {
                // Nếu tìm thấy, mở Form2
                Form2 f = new Form2();
                f.ShowDialog();  // Đảm bảo gọi ShowDialog để đảm bảo Form2 được load đúng
            }
            else
            {
                // Nếu không tìm thấy, hiển thị thông báo lỗi
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(users);
            f.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
