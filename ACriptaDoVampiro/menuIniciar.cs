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
    public partial class menuIniciar : Form
    {
        public menuIniciar()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new escolhaPersonagem();
            form.Show();
        }

        private void credits_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new creditos();
            form.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
