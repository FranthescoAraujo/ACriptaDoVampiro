using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACriptaDoVampiro
{
    class Inimigo
    {
        private int habilidade;
        private int energia;

        public Inimigo(int habilidade, int energia)
        {
            this.habilidade = habilidade;
            this.energia = energia;
        }

        public int getHabilidade()
        {
            return this.habilidade;
        }

        public void setHabilidade(int value)
        {
            this.habilidade = value;
        }

        public int getEnergia()
        {
            return this.energia;
        }

        public void setEnergia(int value)
        {
            this.energia += value;
        }

        public int lancarDado()
        {
            return Personagem.dado.Next(1, 7);
        }
    }
}

    
