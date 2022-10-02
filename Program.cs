using System;
using Xadrez.Tabuleiro;

namespace Xadrez.Tabuleiro{
	class Program
	{
		static void Main(string[] args){
			Tabuleiro tab = new Tabuleiro(8, 8);
			
			Tela.ImprimirTabuleiro(tab);
			
			Console.ReadLine();
		}
	}
}