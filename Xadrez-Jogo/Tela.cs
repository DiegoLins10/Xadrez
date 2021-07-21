using System;
using Xadrez_Jogo;

namespace Xadrez_Jogo.Tabuleiro
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
                //colunas
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i, j) == null) // verificando se a posicao do tabuleiro está vazia
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
