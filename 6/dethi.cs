using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _6
{
    
    public partial class dethi : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=htthi;Integrated Security=True";
        public dethi()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT Id,MaDe,TenDe,MonId,ThoiGian FROM dethi";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                    guna2DataGridView1.Columns.Clear();
                    guna2DataGridView1.AutoGenerateColumns = true;
                    guna2DataGridView1.DataSource = dt;
                        
                    }
                }
            }
        
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            object value = guna2DataGridView1
         .Rows[e.RowIndex].Cells["MonId"].Value;

            if (value == null || value == DBNull.Value)
            {
                MessageBox.Show("Đề thi chưa có mã môn học.");
                return;
            }
            int MonId = Convert.ToInt32(value);
            trangthi f = new trangthi(MonId);
            f.Show();
            f.Location = this.Location;
            this.Hide();
        }

        private void dethi_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string MonId = guna2TextBox1.Text;
            if(MonId == "")
            {
                MessageBox.Show("nhap MonId can tim");
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Id, MaDe, TenDe, MonId, ThoiGian FROM dethi WHERE MonId = @MonId;";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MonId", MonId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    guna2DataGridView1.Columns.Clear();
                    guna2DataGridView1.AutoGenerateColumns = true;
                    guna2DataGridView1.DataSource = dt;
                    guna2DataGridView1.ReadOnly = true;
                    guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Formgiaodien f = new Formgiaodien();
            f.Show();
            f.Location = this.Location;
            f.Size = this.Size;
            this.Hide();
        }
    }
}
