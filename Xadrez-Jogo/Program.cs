using System;
using Xadrez_Jogo.tabuleiro;
using Xadrez_Jogo.tabuleiro.Enums;
using Xadrez_Jogo.xadrez;

namespace Xadrez_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 5));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 6));

            Tela.ImprimirTabuleiro(tab);

            PosicaoXadrez pos = new PosicaoXadrez('a', 8);

            Console.WriteLine(pos.toPosicao());
        }
    }
}
