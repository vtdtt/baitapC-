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
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;

namespace _6
{
    public partial class FrmQuanlytaikhoan : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=login_system;Integrated Security=True;";
        public FrmQuanlytaikhoan()
        {
            InitializeComponent();
        }
        private void BoGoc(Control ctrl, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            Rectangle rect = new Rectangle(
                0, 0, ctrl.Width - 1, ctrl.Height - 1);

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            ctrl.Region = new Region(path);
        }
        private void BogocPanel(IconButton btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = radius * 2;

            Rectangle rect = new Rectangle(
                0, 0, btn.Width - 1, btn.Height - 1);

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            btn.Region = new Region(path);
        }
        public void LoadData()
        {
             string Sql = @"SELECT id, username, email, is_active,
                          created_at, updated_at
                   FROM users";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(Sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvTaikhoan.DataSource = dt;
            }
        }

        private void FrmQuanlytaikhoan_Load(object sender, EventArgs e)
        {
            LoadData();
            BogocPanel(btnCapnhat, 12 );
            BogocPanel(btnKhoa, 12);
            BogocPanel(btnLammoi, 12);
            BogocPanel(btnTimkiem, 12);
            BogocPanel(btnXoa, 12);
            BoGoc(grpThongtin, 12);
            BoGoc(grpTimkiem, 12);
            BoGoc(grpDanhsachtacgia, 12);
        }

        private void dgvTaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaikhoan.Rows[e.RowIndex];

                txtIDtaikhoan.Text = row.Cells["ID"].Value.ToString();
                txtTendangnhap.Text = row.Cells["Tendangnhap"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();

                if (Convert.ToBoolean(row.Cells["Trangthai"].Value))
                {
                    txtTrangthai.Text = "Đang hoạt động";
                }
                else
                {
                    txtTrangthai.Text = "Đã khóa";
                }
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string id = txtIDtaikhoan.Text.Trim();
            string username = txtTendangnhap.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (id == "" || username == "" || email == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản và nhập đầy đủ thông tin!");
                return;
            }

            string Sql = @"UPDATE users
                   SET username = @Username,
                       email = @Email,
                       updated_at = GETDATE()
                   WHERE id = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Sql, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);

                    int kq = cmd.ExecuteNonQuery();

                    if (kq > 0)
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công!");

                        LoadData();
                        txtIDtaikhoan.Clear();
                        txtTendangnhap.Clear();
                        txtEmail.Clear();
                        txtTrangthai.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản cần cập nhật!");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi cập nhật tài khoản: " + ex.Message);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtIDtaikhoan.Text.Trim();

            if (id == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tài khoản này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                string Sql = "DELETE FROM users WHERE id = @Id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Sql, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int kqXoa = cmd.ExecuteNonQuery();

                    if (kqXoa > 0)
                    {
                        MessageBox.Show("Xóa tài khoản thành công!");

                        LoadData();

                        txtIDtaikhoan.Clear();
                        txtTendangnhap.Clear();
                        txtEmail.Clear();
                        txtTrangthai.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản cần xóa!");
                    }
                }
            }
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            string id = txtIDtaikhoan.Text.Trim();

            if (id == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần khóa hoặc mở khóa!");
                return;
            }

            string Sql = @"UPDATE users
                   SET is_active = CASE
                       WHEN is_active = 1 THEN 0
                       ELSE 1
                   END,
                   updated_at = GETDATE()
                   WHERE id = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(Sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Thay đổi trạng thái tài khoản thành công!");

                    LoadData();

                    string sqlTrangThai = "SELECT is_active FROM users WHERE id = @Id";
                    SqlCommand cmdTrangThai = new SqlCommand(sqlTrangThai, conn);
                    cmdTrangThai.Parameters.AddWithValue("@Id", id);

                    object trangThai = cmdTrangThai.ExecuteScalar();

                    if (trangThai != null)
                    {
                        if (Convert.ToBoolean(trangThai))
                        {
                            txtTrangthai.Text = "Đang hoạt động";
                        }
                        else
                        {
                            txtTrangthai.Text = "Đã khóa";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản cần thay đổi trạng thái!");
                }
            }
        }

        private void btnTImkiem_Click(object sender, EventArgs e)
        {
            string id = txtTimIDtaikhoan.Text.Trim();
            string username = txtTimtendangnhap.Text.Trim();

            if (id == "" && username == "")
            {
                MessageBox.Show("Vui lòng nhập ID hoặc tên đăng nhập cần tìm!");
                return;
            }

            string Sql = @"SELECT id, username, email, is_active,
                          created_at, updated_at
                   FROM users
                   WHERE (@Id = '' OR CAST(id AS VARCHAR(20)) LIKE @Id)
                     AND (@Username = '' OR username LIKE @Username)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(Sql, conn);

                cmd.Parameters.AddWithValue("@Id", id == "" ? "" : "%" + id + "%");
                cmd.Parameters.AddWithValue("@Username", username == "" ? "" : "%" + username + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvTaikhoan.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm thấy " + dt.Rows.Count + " tài khoản!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản phù hợp!");
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
       
            Formgiaodienqly f = new Formgiaodienqly();
            f.Show();
            f.Location = this.Location;
            f.Size = this.Size;
            this.Hide();
        }
   
    }
}



