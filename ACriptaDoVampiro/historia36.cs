using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACriptaDoVampiro
{
    public partial class historia36 : Form
    {
        public historia36()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new bag();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new historia41();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new historia37();
            form.Show();
        }
    }
}
