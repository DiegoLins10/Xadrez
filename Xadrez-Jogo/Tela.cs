using System;
using Xadrez_Jogo;

namespace Xadrez_Jogo.tabuleiro
{
    class Tela
    {
        /*
         * Metodo estatico para imprimir visualmente a matriz na tela 
         * para representar o tabuleiro
         */
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            //linhas
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                //colunas
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i, j) == null) // verificando se a posicao do tabuleiro está vazia
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Tela.ImprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        /*
         * Metodo para mudar a cor da peca
         */
        public static void ImprimirPeca(Peca peca)
        {
            if(peca.Cor == Enums.Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
