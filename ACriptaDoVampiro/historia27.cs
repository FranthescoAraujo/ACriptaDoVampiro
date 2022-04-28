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
    public partial class historia27 : Form
    {
        Inimigo inimigo01 = new Inimigo(6, 6);

        public historia27()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = Personagem.getGif();
            label1.Text = Personagem.getHabilidade().ToString();
            label2.Text = Personagem.getEnergia().ToString();
            label3.Text = Personagem.getFe().ToString();
            label4.Text = Personagem.getSorte().ToString();
            pictureBox9.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox9.Enabled = true;
            int aux = morreu();
            if (aux == 2)
            {
                this.Hide();
                var gameOver = new gameOver();
                gameOver.Show();
                return;
            }
            else if (aux == 1)
            {
                this.Hide();
                var form = new historia30();
                form.Show();
                return;
            }
        }

        private int morreu()
        {
            int dadoPersonagem01 = Personagem.lancarDado();
            int dadoPersonagem02 = Personagem.lancarDado();
            int dadoInimigo0101 = inimigo01.lancarDado();
            int dadoInimigo0102 = inimigo01.lancarDado();
            label9.Text = "Personagem = " + dadoPersonagem01.ToString() + " - " + dadoPersonagem02.ToString();
            label7.Text = "Cobra = " + dadoInimigo0101.ToString() + " - " + dadoInimigo0102.ToString();
            int danoPersonagem = Personagem.getHabilidade() + dadoPersonagem01 + dadoPersonagem02;
            int danoInimigo01 = inimigo01.getHabilidade() + dadoInimigo0101 + dadoInimigo0102;

            if (danoPersonagem > danoInimigo01)
            {
                inimigo01.setEnergia(-2);
                label1.Text = Personagem.getHabilidade().ToString();
                label2.Text = Personagem.getEnergia().ToString();
                label3.Text = Personagem.getFe().ToString();
                label4.Text = Personagem.getSorte().ToString();
                label6.Text = inimigo01.getHabilidade().ToString();
                label5.Text = inimigo01.getEnergia().ToString();
                if (inimigo01.getEnergia() <= 0)
                {
                    return 1;
                }
            }
            else
            {
                Personagem.setEnergia(-2);
                label1.Text = Personagem.getHabilidade().ToString();
                label2.Text = Personagem.getEnergia().ToString();
                label3.Text = Personagem.getFe().ToString();
                label4.Text = Personagem.getSorte().ToString();
                label6.Text = inimigo01.getHabilidade().ToString();
                label5.Text = inimigo01.getEnergia().ToString();
                if (Personagem.getEnergia() <= 0)
                {
                    return 2;
                }
            }
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new bag();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
