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
    public partial class bag : Form
    {
        public bag()
        {
            InitializeComponent();
            label1.Text = Personagem.getRefeicao().ToString();
            label2.Text = Personagem.getMoedas().ToString();
            pictureBox3.Visible = Personagem.getGarrafaIsVisible();
            pictureBox4.Visible = Personagem.getColarIsVisible();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Personagem.getRefeicao() > 0)
            {
                Personagem.setEnergia(4);
                Personagem.setRefeicao(-1);
                label1.Text = Personagem.getRefeicao().ToString();
            }
        }
    }
}
