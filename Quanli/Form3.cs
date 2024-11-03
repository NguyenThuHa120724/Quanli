using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quanli
{
    public partial class Form3 : Form
    {
        // Danh sách lưu trữ tài khoản đã đăng ký
        private List<User> users;

        public Form3(List<User> users)
        {
            InitializeComponent();
            this.users = users; // Gán giá trị cho danh sách users
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu các trường không được để trống
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mật khẩu và xác nhận mật khẩu khớp nhau
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tên đăng nhập đã tồn tại
            if (users.Exists(u => u.Tendangnhap == textBox1.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng User mới và thêm vào danh sách users
            User newUser = new User
            {
                Tendangnhap = textBox1.Text,
                Matkhau = textBox2.Text
            };
            users.Add(newUser);

            // Thông báo đăng ký thành công
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Console.WriteLine("Danh sách người dùng:");
            foreach (var user in users)
            {
                Console.WriteLine($"Tên đăng nhập: {user.Tendangnhap}, Mật khẩu: {user.Matkhau}");
            }

            // Xóa các trường nhập sau khi đăng ký thành công
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void butto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Lớp User để lưu thông tin tài khoản
    public class User
    {
        public string Tendangnhap { get; set; }
        public string Matkhau { get; set; }
    }
   
}