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
    public partial class escolhaPersonagem : Form
    {
        private int escolha = 0;
        public escolhaPersonagem()
        {
            InitializeComponent();
            label1.Text = "Escolha um Personagem";
            pictureBox1.ImageLocation = "..\\..\\imagens\\Personagens\\personagem01.gif";
            pictureBox2.ImageLocation = "..\\..\\imagens\\Personagens\\personagem02.gif";
            pictureBox3.ImageLocation = "..\\..\\imagens\\Personagens\\personagem03.gif";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.escolha = 1;
            Personagem.Criar(escolha);
            label1.Text = "Catarina Holmes\r\nHabilidade: " + Personagem.getHabilidade().ToString() + "\r\nEnergia: " + Personagem.getEnergia().ToString() + "\r\nSorte: " + Personagem.getSorte().ToString() + "\r\nFé: " + Personagem.getFe().ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.escolha = 2;
            Personagem.Criar(escolha);
            label1.Text = "Cyborg Celeste\r\nHabilidade: " + Personagem.getHabilidade().ToString() + "\r\nEnergia: " + Personagem.getEnergia().ToString() + "\r\nSorte: " + Personagem.getSorte().ToString() + "\r\nFé: " + Personagem.getFe().ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.escolha = 3;
            Personagem.Criar(escolha);
            label1.Text = "Escudeiro Infernal\r\nHabilidade: " + Personagem.getHabilidade().ToString() + "\r\nEnergia: " + Personagem.getEnergia().ToString() + "\r\nSorte: " + Personagem.getSorte().ToString() + "\r\nFé: " + Personagem.getFe().ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (this.escolha != 0)
            {
                this.Hide();
                var form = new historia();
                form.Show();
            }
        }
    }
}

