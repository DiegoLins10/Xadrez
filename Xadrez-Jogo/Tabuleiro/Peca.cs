﻿using Xadrez_Jogo.tabuleiro.Enums;

namespace Xadrez_Jogo.tabuleiro
{   /*
     * Nessa classe é onde sera registrado o objeto peca do jogo
     * a classe tem um metodo abstrato, ou seja ela tem que ser abstrata.
     */
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        /*
         * Construtores
         */
        public Peca()
        {

        }

        public Peca( Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QteMovimentos = 0;
            Tab = tabuleiro;
        }

        /*
         * Incrementa quantidade de movimentos
         */
        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        /*
         * Metodo abstrato da super classe
         * pois cada peça é generica e tem regras diferentes.
         * deve ser implementada na classe filha
         */
        public abstract bool[,] movimentosPosiveis();
        
    }
}
