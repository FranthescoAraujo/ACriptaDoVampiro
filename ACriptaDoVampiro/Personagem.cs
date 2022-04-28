using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACriptaDoVampiro
{
	public static class Personagem
	{
		static int[] habilidade = new int[2];
		static int[] energia = new int[2];
		static int[] sorte = new int[2];
		static int[] fe = new int[2];
		static int refeicao = 10;
		static int moedas = 0;
		static bool garrafaIsVisible = false;
		static bool colarIsVisible = false;
		static List<string> itens = new List<string>();
		static List<string> aflicoes = new List<string>();
		static string gif;
		public static Random dado = new Random();
		public static void Criar(int escolha)
		{
			switch (escolha)
			{
				case 1:
					setPersonagem(10, 18, 7, 6);
					gif = "..\\..\\imagens\\Personagens\\personagem01.gif";
					break;
				case 2:
					setPersonagem(8, 19, 10, 9);
					gif = "..\\..\\imagens\\Personagens\\personagem02.gif";
					break;
				case 3:
					setPersonagem(12, 16, 8, 8);
					gif = "..\\..\\imagens\\Personagens\\personagem03.gif";
					break;
			}
		}

		private static void setPersonagem(int habil, int energ, int sor, int f)
		{
			habilidade[0] = habil;
			habilidade[1] = habilidade[0];
			energia[0] = energ;
			energia[1] = energia[0];
			sorte[0] = sor;
			sorte[1] = sorte[0];
			fe[0] = f;
			fe[1] = fe[0];
		}

		public static int getMoedas()
		{
			return moedas;
		}

		public static void setMoedas(int valor)
		{
			moedas += valor;
		}

		public static bool getGarrafaIsVisible()
		{
			return garrafaIsVisible;
		}

		public static void setGarrafaIsVisible(bool valor)
		{
			garrafaIsVisible = valor;
		}

		public static bool getColarIsVisible()
		{
			return colarIsVisible;
		}

		public static void setColarIsVisible(bool valor)
		{
			colarIsVisible = valor;
		}

		public static int getRefeicao()
		{
			return refeicao;
		}

		public static void setRefeicao(int valor)
		{
			refeicao += valor;
		}

		public static int lancarDado()
		{
			return dado.Next(1, 7);
		}

		public static string getGif()
		{
			return gif;
		}

		public static void setHabilidade(int valor)
		{
			habilidade[1] += valor;
		}

		public static int getHabilidade()
		{
			return habilidade[1];
		}

		public static void setEnergia(int valor)
		{
			if (energia[1] + valor >= energia[0])
			{
				energia[1] = energia[0];
			}
			else
			{
				energia[1] += valor;
			}
		}

		public static int getEnergia()
		{
			return energia[1];
		}

		public static void setSorte(int valor)
		{
			sorte[1] += valor;
		}

		public static int getSorte()
		{
			return sorte[1];
		}

		public static void setFe(int valor)
		{
			fe[1] += valor;
		}

		public static int getFe()
		{
			return fe[1];
		}

		public static void setItem(string item)
		{
			itens.Add(item);
		}

		public static bool verificaSeExisteItem(string item)
		{
			foreach (string i in itens)
			{
				if (i == item)
				{
					return true;
				}
			}
			return false;
		}

		public static void setAflicao(string aflicao)
		{
			aflicoes.Add(aflicao);
		}

		public static void removerAflicao(string aflicao)
		{
			aflicoes.Remove(aflicao);
		}

		public static bool verificaAflicao(string aflicao)
		{
			foreach (string i in aflicoes)
			{
				if (i == aflicao)
				{
					return true;
				}
			}
			return false;
		}
	}
}
