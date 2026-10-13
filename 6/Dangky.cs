using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Dangky : Form
    {
        public Dangky(Color maunen)
        {
            InitializeComponent();
            this.BackColor = maunen;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Dangnhap f = new Dangnhap(this.BackColor);
            f.Show();
            f.Location = this.Location;
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dangnhap f = new Dangnhap(this.BackColor);
            f.Show();
            f.Location = this.Location;
            this.Hide();
        }
    }
}
