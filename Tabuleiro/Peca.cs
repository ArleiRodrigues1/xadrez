using System;
using Xadrez.Tabuleiro;

namespace Xadrez.Tabuleiro
{
	public class Peca
	{
		public Posicao Posicao {get; set;} 
		public Cor Cor {get; protected set;}
		public int QtdMovimentos{get; protected set;}
		public Tabuleiro Tab{get; set;}

		public Peca(Posicao posicao, Cor cor, Tabuleiro tab,int qtdMovimentos){
			Posicao = posicao;
			Cor = cor;
			Tab = tab;
			QtdMovimentos = 0;
		}	
	}
}