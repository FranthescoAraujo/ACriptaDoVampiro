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
    public partial class historia08 : Form
    {
        public historia08()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = Personagem.getGif();
            label1.Text = Personagem.getHabilidade().ToString();
            label2.Text = Personagem.getEnergia().ToString();
            label3.Text = Personagem.getFe().ToString();
            label4.Text = Personagem.getSorte().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new historia09();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new bag();
            form.Show();
        }
    }
}
