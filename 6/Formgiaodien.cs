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
    public partial class Formgiaodien : Form
    {
        public Formgiaodien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void BoTron(Control ctrl, int banKinh)
        {
            int d = banKinh * 2;

            if (d <= 0 || d > ctrl.Width || d > ctrl.Height)
                return;

            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(ctrl.Width - d, 0, d, d, 270, 90);
            path.AddArc(ctrl.Width - d, ctrl.Height - d, d, d, 0, 90);
            path.AddArc(0, ctrl.Height - d, d, d, 90, 90);
            path.CloseFigure();

            ctrl.Region = new Region(path);
       
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Formgiaodien_Load(object sender, EventArgs e)
        {
            BoTron(panel1, 10);
            BoTron(panel2, 10);
            BoTron(panel3, 10);
            BoTron(panel4, 10);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Phanquyen f = new Phanquyen(this.BackColor);
            f.Show();
            f.Location = this.Location;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dethi f = new dethi();
            f.Show();
            f.Location = this.Location;
            f.Size = this.Size;
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
