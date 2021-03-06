using System;
using System.Collections.Generic;
using Xadrez_Jogo;
using Xadrez_Jogo.xadrez;

namespace Xadrez_Jogo.tabuleiro
{
    class Tela
    {
        /*
         * imprime as informacoes da partida na tela
         */
        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            ImprimirTabuleiro(partida.tab);
            Console.WriteLine();
            ImprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            if (!partida.Terminada)
            {
                Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
                if (partida.Xeque)
                {
                    Console.WriteLine("XEQUE!!");
                }
            }
            else
            {
                Console.WriteLine("XEQUEMATE!!");
                Console.WriteLine("Vencedor: " + partida.jogadorAtual);
            }
        }

        /*
         * Imprime as pecas capturadas no jogo
         */
        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Pecas Capturadas: ");
            Console.Write("Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Enums.Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(partida.PecasCapturadas(Enums.Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        /*
         * Imprime o conjunto que está as pecas 
         * capturadas do jogo
         */
        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach(Peca x in conjunto)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }

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
                    Tela.ImprimirPeca(tab.Peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] possicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            //linhas
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                //colunas
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if(possicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado; // mudando cor pra mostrar aonde a peca pode se mexer
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    Tela.ImprimirPeca(tab.Peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        /*
         * metodo static lendo a posicao que o usuario digita
         * e passando pro construtor posição de xadres
         */
        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        /*
         * Metodo para mudar a cor da peca
         */
        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null) // verificando se a posicao do tabuleiro está vazia
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Enums.Cor.Branca)
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
                Console.Write(" ");
            }
        }
    }
}
