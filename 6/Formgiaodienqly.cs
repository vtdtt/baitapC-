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
    public partial class Formgiaodienqly : Form
    {
        public Formgiaodienqly()
        {
            InitializeComponent();
        }

        private void Formgiaodienqly_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmQuanlydethi f = new FrmQuanlydethi();
            f.Show();
            f.Location = this.Location;
            f.Size = this.Size;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmQuanlytaikhoan f = new FrmQuanlytaikhoan();
            f.Show();
            f.Location = this.Location;
            f.Size = this.Size;
            this.Hide();
        }
    }
}
