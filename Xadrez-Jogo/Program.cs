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
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Digite a posição origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] possicoesPossiveis = partida.tab.peca(origem).movimentosPosiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.tab, possicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Digite a posição destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                        Console.WriteLine("Aperte enter para tentar novamente...");
                        Console.ReadLine();
                    }
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
