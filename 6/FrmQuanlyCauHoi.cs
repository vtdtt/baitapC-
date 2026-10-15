using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class FrmQuanlyCauHoi : Form
    {
        public FrmQuanlyCauHoi()
        {
            InitializeComponent();
            LoadMonHoc();
            LoadDanhSachCauHoi();
        }
        private void LoadMonHoc()
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=htthi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            string query = "SELECT id, tenmon FROM monthi";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbo_MonHoc.DataSource = dt;
                    cbo_MonHoc.DisplayMember = "tenmon"; 
                    cbo_MonHoc.ValueMember = "id";
                    cboDeThi.DataSource = dt;
                    cboDeThi.DisplayMember = "tenmon";
                    cboDeThi.ValueMember = "id";

                }
            }

        }
        private void LoadDanhSachCauHoi()
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=htthi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            string query = @"SELECT c.Id, c.NoiDung, m.tenmon
                                FROM cauhoi c
                                JOIN monthi m ON c.MonId = m.id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    dgvKetQua.DataSource = dataTable;
                    dgvKetQua.Columns["Id"].HeaderText = "STT";
                    dgvKetQua.Columns["NoiDung"].HeaderText = "Nội dung câu hỏi";
                    dgvKetQua.Columns["tenmon"].HeaderText = "Môn học";
                }
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblTimKiemCauHoi_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=htthi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            string query = "INSERT INTO CauHoi (MonID,NoiDung, DapAnA, DapAnB, DapAnC, DapAnD) VALUES (@MonID,@NoiDung, @A, @B, @C, @D)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MonID", cbo_MonHoc.SelectedValue);
                    cmd.Parameters.AddWithValue("@NoiDung", txtB_NoiDung.Text);
                    cmd.Parameters.AddWithValue("@A", txtB_DapAnA.Text);            
                    cmd.Parameters.AddWithValue("@B", txtB_DapAnB.Text);            
                    cmd.Parameters.AddWithValue("@C", txtB_DapAnC.Text);           
                    cmd.Parameters.AddWithValue("@D", txtB_DapAnD.Text);

                    try
                    {
                        conn.Open();                
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm câu hỏi thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=htthi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            string query = @"SELECT c.Id, c.NoiDung, m.tenmon 
                     FROM cauhoi c 
                     JOIN monthi m ON c.MonId = m.id 
                     WHERE c.NoiDung LIKE @TuKhoa";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + txtTimKiem.Text.Trim() + "%");

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.SelectCommand = cmd;

                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                       
                        dgvKetQua.AutoGenerateColumns = true;
                        dgvKetQua.DataSource = dataTable;

                        if (dgvKetQua.Columns["Id"] != null)
                            dgvKetQua.Columns["Id"].HeaderText = "STT";
                        if (dgvKetQua.Columns["NoiDung"] != null)
                            dgvKetQua.Columns["NoiDung"].HeaderText = "Nội dung câu hỏi";
                        if (dgvKetQua.Columns["tenmon"] != null)
                            dgvKetQua.Columns["tenmon"].HeaderText = "Môn học";
                    }
                }
            }
        }

        private void cboDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
