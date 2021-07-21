using System;
using Xadrez_Jogo.Tabuleiro;

namespace Xadrez_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tab = new Xadrez_Jogo.Tabuleiro.Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);
            Console.WriteLine();
        }
    }
}
