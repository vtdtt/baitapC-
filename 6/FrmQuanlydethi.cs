using Microsoft.VisualBasic;
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
using System.Windows.Media.Animation;
using FontAwesome.Sharp;

namespace _6
{
    public partial class FrmQuanlydethi : Form
    {
       string connectionString= "Data Source=localhost;Initial Catalog=htthi;Integrated Security=True;";
        public FrmQuanlydethi()
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
        private void Loaddata()
        {
            string  Sql =  @"SELECT d.MaDe, d.TenDe,
                      d.MonId AS MonId,
                      m.tenmon AS Tenmon,
                      d.ThoiGian
               FROM dethi d
               INNER JOIN monthi m ON d.MonId = m.id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(Sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDethi.DataSource = dt;
                dgvDethi.Columns["MonId"].Visible = false;

            }
        }
        void LoadMon()
        {
                string sql = "SELECT id, tenmon FROM monthi";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboTenmon.DataSource = dt;
                    cboTenmon.DisplayMember = "tenmon";
                    cboTenmon.ValueMember = "id";
                    cboTenmon.SelectedIndex = -1;
                }
            
        }

        private void grpTimkiem_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maDe = txtMadethi.Text.Trim();
            string tenDe = txtTendethi.Text.Trim();
            string thoiGian = txtThoigian.Text.Trim();

            if (maDe == "" || tenDe == "" || cboTenmon.SelectedIndex == -1 || thoiGian == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            int tg;

            if (!int.TryParse(thoiGian, out tg) || tg <= 0)
            {
                MessageBox.Show("Thời gian thi phải là số nguyên dương!");
                return;
            }

            String Sql = @"UPDATE dethi
                   SET TenDe = @TenDe,
                       MonId = @MonId,
                       ThoiGian = @ThoiGian
                   WHERE MaDe = @MaDe";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(Sql, conn);

                cmd.Parameters.AddWithValue("@MaDe", maDe);
                cmd.Parameters.AddWithValue("@TenDe", tenDe);
                cmd.Parameters.AddWithValue("@MonId", cboTenmon.SelectedValue);
                cmd.Parameters.AddWithValue("@ThoiGian", tg);

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Sửa đề thi thành công!");

                    Loaddata();

                    txtMadethi.Clear();
                    txtTendethi.Clear();
                    txtThoigian.Clear();
                    cboTenmon.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đề thi cần sửa!");
                }
            }
        


        }

        private void FrmQuanlydethi_Load(object sender, EventArgs e)
        {
            Loaddata();
            LoadMon();
            BogocPanel(btnLuu, 12);
            BogocPanel(btnSua, 12);
            BogocPanel(btnXoa, 12);
            BogocPanel(btnTimkiem, 12);
            BogocPanel(btnLammoi, 12);
            BogocPanel(btnThemmon, 12);
            BoGoc(grpThongtin, 12);
            BoGoc(grpTimkiem, 12);
            BoGoc(grpDanhsachtacgia, 12);
            BoGoc(panel1, 12);


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maDe = txtMadethi.Text.Trim();
            string tenDe = txtTendethi.Text.Trim();
            string thoiGian = txtThoigian.Text.Trim();

            if (maDe == "" || tenDe == "" || cboTenmon.SelectedIndex == -1 || thoiGian == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            int tg;

            if (!int.TryParse(thoiGian, out tg) || tg <= 0)
            {
                MessageBox.Show("Thời gian thi phải là số nguyên dương!");
                return;
            }

            String sql = @"INSERT INTO dethi(MaDe, TenDe, MonId, ThoiGian)
                   VALUES(@MaDe, @TenDe, @MonId, @ThoiGian)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaDe", maDe);
                    cmd.Parameters.AddWithValue("@TenDe", tenDe);
                    cmd.Parameters.AddWithValue("@MonId", cboTenmon.SelectedValue);
                    cmd.Parameters.AddWithValue("@ThoiGian", tg);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Lưu đề thi thành công!");

                txtMadethi.Clear();
                txtTendethi.Clear();
                txtThoigian.Clear();
                cboTenmon.SelectedIndex = -1;

                Loaddata();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lưu đề thi: " + ex.Message);
            }

        }

        private void BtnThemmon_Click(object sender, EventArgs e)
        {
            string tenMon = txtThemmon.Text.Trim();

            if (tenMon == "")
            {
                MessageBox.Show("Vui lòng nhập tên môn học!");
                return;
            }

            string sql = "INSERT INTO monthi(tenmon) VALUES(@TenMon)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TenMon", tenMon);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadMon();
                cboTenmon.Text = tenMon;
                txtThemmon.Clear();

                MessageBox.Show("Thêm môn học thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvDethi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDethi.Rows[e.RowIndex];

                txtMadethi.Text = row.Cells["MaDe"].Value.ToString();
                txtTendethi.Text = row.Cells["TenDe"].Value.ToString();
                txtThoigian.Text = row.Cells["ThoiGian"].Value.ToString();
                cboTenmon.SelectedValue = row.Cells["MonId"].Value;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDe = txtMadethi.Text.Trim();

            if (maDe == "")
            {
                MessageBox.Show("Vui lòng chọn đề thi cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa đề thi này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                String Sql = "DELETE FROM dethi WHERE MaDe = @MaDe";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(Sql, conn);
                    cmd.Parameters.AddWithValue("@MaDe", maDe);

                    int kqXoa = cmd.ExecuteNonQuery();

                    if (kqXoa > 0)
                    {
                        MessageBox.Show("Xóa đề thi thành công!");

                        Loaddata();

                        txtMadethi.Clear();
                        txtTendethi.Clear();
                        txtThoigian.Clear();
                        cboTenmon.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy đề thi cần xóa!");
                    }
                }
            }
        }

        private void btnTImkiem_Click(object sender, EventArgs e)
        {
            string maDe = txtTimmadethi.Text.Trim();
            string tenDe = txtTimtendethi.Text.Trim();

            if (maDe == "" && tenDe == "")
            {
                MessageBox.Show("Vui lòng nhập mã đề hoặc tên đề cần tìm!");
                return;
            }

            string Sql = @"SELECT d.MaDe, d.TenDe, d.MonId,
                          m.tenmon AS Tenmon, d.ThoiGian
                   FROM dethi d
                   INNER JOIN monthi m ON d.MonId = m.id
                   WHERE (@MaDe = '' OR d.MaDe LIKE @MaDe)
                     AND (@TenDe = '' OR d.TenDe LIKE @TenDe)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(Sql, conn);

                cmd.Parameters.AddWithValue("@MaDe", "%" + maDe + "%");
                cmd.Parameters.AddWithValue("@TenDe", "%" + tenDe + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvDethi.DataSource = dt;

                if (dgvDethi.Columns["MonId"] != null)
                {
                    dgvDethi.Columns["MonId"].Visible = false;
                }

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm thấy " + dt.Rows.Count + " đề thi!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đề thi phù hợp!");
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        
            Formgiaodienqly f = new Formgiaodienqly();
            f.Show();
            f.Location = this.Location;
            f.Size = this.Size;
            this.Hide();
        }
    
    }
}



