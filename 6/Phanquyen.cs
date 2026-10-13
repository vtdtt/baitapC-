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
    public partial class Phanquyen : Form
    {
        public Phanquyen(Color maunen)
        {
            InitializeComponent();
            this.BackColor = maunen;
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BogocPanel(guna2CustomGradientPanel1, 9);
            
        }
        private void BogocPanel(Panel pnl , int radius)
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

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Dangnhap f = new Dangnhap(this.BackColor);
            f.Show();
            f.Location = this.Location;
            this.Hide();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Dangnhap f = new Dangnhap(this.BackColor);
            f.Show();
            f.Location = this.Location;
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private bool darkmode = false;
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            darkmode = !darkmode;
            if (darkmode)
            {
                this.BackColor = ColorTranslator.FromHtml("#232D45");
                
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#F1F5F9");
                
            }
        }
    }
}
