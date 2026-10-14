using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _6
{
    public partial class Dangky : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=login_system;Integrated Security=True";
        public Dangky(Color maunen)
        {
            InitializeComponent();
            this.BackColor = maunen;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = guna2TextBox1.Text.Trim();
            string tk = guna2TextBox2.Text.Trim();
            string mk = guna2TextBox3.Text;
            string nhaplaimk = guna2TextBox4.Text;
            if (email == "" || tk == "" || mk == "" || nhaplaimk == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
            if (mk != nhaplaimk)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO users(email,username,password_hash)" +
                                    "VALUES (@email,@username,@password_hash)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@username", tk);
                        string password_hash = BCrypt.Net.BCrypt.HashPassword(mk);
                        cmd.Parameters.AddWithValue("@password_hash", password_hash);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công");
                        Lammoi();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi đăng ký: " + ex.Message);
                    }
                }
            }
        }
    
                

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loginhocsinh f = new loginhocsinh(this.BackColor);
            f.Show();
            f.Location = this.Location;
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loginhocsinh f = new loginhocsinh(this.BackColor);
            f.Show();
            f.Location = this.Location;
            this.Hide();
        }
        private void Lammoi()
        {
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            guna2TextBox4.Clear();
        }

    }
}
