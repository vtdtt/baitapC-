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
    public partial class Formlichsuthihs : Form
    {
        public Formlichsuthihs()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void botron(Panel pnl, int radius)
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
        private void guna2CustomGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Formlichsuthihs_Load(object sender, EventArgs e)
        {
            botron(panel1, 10);
            botron(pnl_menuchinh, 10);
            botron(panel3, 10);
            botron(pnl_lichsuthi, 10);
            botron(panel6, 10);
            botron(paneltongsobaithi, 10);
            botron(pnl_dahoanthanh, 10);
            botron(pnl_danglam, 10);
            botron(pnl_diemcaonhat, 10);
           
        }
    }
}
