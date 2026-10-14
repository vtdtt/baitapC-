
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _6
{
    public partial class Formthongtintaikhoanhs : Form
    {
        private readonly string connectionstring =
            @"Data Source=DESKTOP-3U6O521\SQLEXPRESS;Initial Catalog=login_system;Integrated Security=True;TrustServerCertificate=True;";

        private long userId = 1;

        public Formthongtintaikhoanhs()
        {
            InitializeComponent();
            this.Load += Formthongtintaikhoanhs_Load;
        }
        private void Formthongtintaikhoanhs_Load(
            object sender, EventArgs e)
        {
            txtmhs.ReadOnly = true;
            txttendangnhap.ReadOnly = true;
            txthovaten.ReadOnly = true;
            txtemail.ReadOnly = true;

         

            LoadThongTin();
            txtemail.ReadOnly = true;

            bttnsua.Enabled = true;
            bttnluu.Enabled = false;
            bttnhuy.Enabled = false;
        }
private void LoadThongTin()
        {
            string sql = @"
        SELECT id, student_code, full_name, username, email
        FROM dbo.users
        WHERE id = @id AND is_active = 1";

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionstring))
                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.BigInt)
                        .Value = userId;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtmhs.Text =
                                reader["student_code"] == DBNull.Value
                                ? ""
                                : reader["student_code"].ToString();

                            txthovaten.Text =
                                reader["full_name"] == DBNull.Value
                                ? ""
                                : reader["full_name"].ToString();

                            txttendangnhap.Text =
                                reader["username"].ToString();

                            txtemail.Text =
                                reader["email"].ToString();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy tài khoản đang hoạt động.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải thông tin: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void bttnsua_Click(object sender, EventArgs e)
        {
            txthovaten.ReadOnly = false;
            txtemail.ReadOnly = false;

            // Giữ nguyên Mã học sinh, Tên đăng nhập
            txtmhs.ReadOnly = true;
            txttendangnhap.ReadOnly = true;

            bttnsua.Enabled = false;
            bttnluu.Enabled = true;
            bttnhuy.Enabled = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txthovaten_TextChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) ||
                !System.Text.RegularExpressions.Regex.IsMatch(
                    email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ!");
                txtemail.Focus();
                return;
            }

            string sql = @"
    UPDATE dbo.users
    SET full_name = @full_name,
        email = @email,
        updated_at = SYSDATETIME()
    WHERE id = @id AND is_active = 1";

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionstring))
                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@full_name", SqlDbType.NVarChar, 100)
     .Value = txthovaten.Text.Trim();

                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 255)
                        .Value = txtemail.Text.Trim();

                    cmd.Parameters.Add("@id", SqlDbType.BigInt)
                        .Value = userId;

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");

                        txtemail.ReadOnly = true;
                        bttnsua.Enabled = true;
                        bttnluu.Enabled = false;
                        bttnhuy.Enabled = false;

                        LoadThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản đang hoạt động.");
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("Email này đã được tài khoản khác sử dụng!");
                }
                else
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bttnhuy_Click(object sender, EventArgs e)
        {
            LoadThongTin();

            txtemail.ReadOnly = true;

            bttnsua.Enabled = true;
            bttnluu.Enabled = false;
            bttnhuy.Enabled = false;
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formthongtintaikhoanhs_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void bttnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn thoát chương trình không?",
        "Xác nhận thoát",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
