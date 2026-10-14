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
    public partial class loginadmin : Form
    {
        public loginadmin(Color maunen)
        {
            InitializeComponent();
            this.BackColor = maunen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Phanquyen f = new Phanquyen(this.BackColor);
            f.Show();
            f.Location = this.Location;
            this.Hide()
;        }

        private void loginadmin_Load(object sender, EventArgs e)
        {

        }
    }
}
