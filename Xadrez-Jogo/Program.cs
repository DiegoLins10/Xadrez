using System;
using Xadrez_Jogo.tabuleiro;
using Xadrez_Jogo.tabuleiro.Enums;
using Xadrez_Jogo.tabuleiro.Exceptions;
using Xadrez_Jogo.xadrez;

namespace Xadrez_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Digite a posição origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Digite a posição destino: ");
                    Posicao destino= Tela.lerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, destino);

                }

                
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
