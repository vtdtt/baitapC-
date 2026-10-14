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
using System.Drawing.Drawing2D;

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
    }
}
