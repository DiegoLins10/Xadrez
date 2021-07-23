﻿
using Xadrez_Jogo.tabuleiro;

namespace Xadrez_Jogo.xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        /*
         * Construtores
         */
        public PosicaoXadrez()
        {

        }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        /*
         * 
         */
        public Posicao toPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }


        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}