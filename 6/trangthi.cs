using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class trangthi : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=htthi;Integrated Security=True";
        int MonId;
        DataTable dt = new DataTable();
        int idx = 0;
        string[] dapAnChon;
        private System.Windows.Forms.Timer timerlambai;
        Label lblDem, lblCauHoi;
        TableLayoutPanel tblDapAn;
        Guna.UI2.WinForms.Guna2Button[] btnDA = new Guna.UI2.WinForms.Guna2Button[4];
        string[] nhan = { "A", "B", "C", "D" };
      
        public trangthi(int MonId)
        {
            InitializeComponent();
            this.MonId = MonId;
            btnDA = new Guna.UI2.WinForms.Guna2Button[]
         {
            guna2Button5,
            guna2Button6,
            guna2Button7,
            guna2Button8
         };

            // Chỉ thêm các sự kiện này nếu chưa gán Click
            // cho 4 nút trong cửa sổ Properties > Events của Designer.
            guna2Button5.Click += (s, e) => ChonDapAn(0);
            guna2Button6.Click += (s, e) => ChonDapAn(1);
            guna2Button7.Click += (s, e) => ChonDapAn(2);
            guna2Button8.Click += (s, e) => ChonDapAn(3);
            timerlambai = new System.Windows.Forms.Timer();
            timerlambai.Interval = 1000;
            timerlambai.Tick += Timerlambai_Tick;
            this.FormClosed += (s, e) => timerlambai.Dispose();
        }
        private void capnhatdongho()
        {
            TimeSpan conlai = chamthi.thoigianketthuc - DateTime.Now;
            if (conlai <= TimeSpan.Zero)
            {
                timerlambai.Stop();
                MessageBox.Show("Hết thời gian làm bài! Bài thi sẽ được nộp tự động.");
                chamthi.nopbai();
                this.Close();
            }
            else
            {
                label1.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", conlai.Hours, conlai.Minutes, conlai.Seconds);
            }
        }
        private void Timerlambai_Tick(object sender, EventArgs e)
        {
            if (!this.Visible) return;
            if (DateTime.Now >= chamthi.thoigianketthuc)
            {
                timerlambai.Stop();
                MessageBox.Show("Hết thời gian làm bài! Bài thi sẽ được nộp tự động.");
                chamthi.nopbai();
                this.Close();
            }
            else
            {
                capnhatdongho();
            }
        }
        private void HienCau(int index)
        {
            if (index < 0 || index >= chamthi.Danhsach.Count)
                return;

            idx = index;
            cauhoi ch = chamthi.Danhsach[idx];

            label2.Text = $"{idx + 1} / {chamthi.Danhsach.Count}";
            label3.Text = ch.NoiDung;
            string[] nd = { ch.DapAnA, ch.DapAnB, ch.DapAnC, ch.DapAnD };
            for (int k = 0; k < 4; k++) btnDA[k].Text = nd[k];

            ToSang();

            guna2Button1.Enabled = idx > 0;
            guna2Button2.Enabled = idx < chamthi.Danhsach.Count - 1;
        }
        private void ChonDapAn(int k)
        {
            if (chamthi.danop) return;
            chamthi.DapAn[idx] = nhan[k];
            ToSang();
        }
        private void TaoSangPlaceholder() { }
        private void ToSang()
        {
            chamthi.DapAn.TryGetValue(idx, out string daChon);

            for (int k = 0; k < 4; k++)
            {
                bool chon = daChon == nhan[k];

                btnDA[k].BorderColor = Color.White;
                btnDA[k].BorderThickness = chon ? 3 : 0;
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            HienCau(idx + 1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HienCau(idx - 1);
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            dethi f = new dethi();
            f.Show();
            f.Location = this.Location;
            f.Size = this.Size;
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (chamthi.danop)
            {
                MessageBox.Show("Bạn đã nộp bài rồi!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn nộp bài không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                chamthi.nopbai();
                timerlambai.Stop();
                if (chamthi.danop)
                {
                    guna2Button1.Enabled = false;
                    guna2Button2.Enabled = false;
                    guna2Button3.Enabled = false;

                }
            }
        }

        private void trangthi_Load(object sender, EventArgs e)
        {
            try
            {
                chamthi.batdau(MonId);

                if (chamthi.Danhsach.Count == 0)
                {
                    MessageBox.Show("Không tải được câu hỏi từ database!");
                    return;
                }

                timerlambai.Start();
                capnhatdongho();
                HienCau(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải câu hỏi: " + ex.Message);
            }
        }
    }
}
