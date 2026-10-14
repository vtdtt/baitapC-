using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _6
{
    public partial class loginhocsinh : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=login_system;Integrated Security=True";
        public loginhocsinh(Color maunen)
        {
            InitializeComponent();
            this.BackColor = maunen;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void BogocPanel(Panel pnl, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = radius * 2;

            Rectangle rect = new Rectangle(
                0, 0, pnl.Width - 1, pnl.Height - 1);

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d,
                d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d,
                d, d, 90, 90);

            path.CloseFigure();
            pnl.Region = new Region(path);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BogocPanel(panel1, 9);

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Dangky f = new Dangky(this.BackColor);
            f.Show();
            f.Location = this.Location;
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Phanquyen f = new Phanquyen(this.BackColor);
            f.Show();
            f.Location = this.Location;
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string tk = guna2TextBox1.Text.Trim();
            string mk = guna2TextBox2.Text;
            if (tk == "" || mk == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT password_hash
                    FROM users
                    WHERE username = @username
                    AND is_active = 1;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", tk);
                    object result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Tài khoản này không tồn tại");
                        return;
                    }
                    string password_hash = result.ToString().Trim();
                    bool dungmatkhau = BCrypt.Net.BCrypt.Verify(mk, password_hash);
                    if (dungmatkhau)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        trangthi f = new trangthi();
                        f.Show();
                        f.Location = this.Location;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu");
                    }
                }
            }
        }
    }
}

