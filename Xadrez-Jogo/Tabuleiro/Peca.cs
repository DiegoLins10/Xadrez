using Xadrez_Jogo.Tabuleiro.Enums;

namespace Xadrez_Jogo.Tabuleiro
{   /*
     * Nessa classe é onde sera registrado o objeto peca do jogo
     */
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        /*
         * Construtores
         */
        public Peca()
        {

        }

        public Peca(Posicao posicao, Cor cor, int qteMovimentos, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            QteMovimentos = 0;
            Tabuleiro = tabuleiro;
        }
    }
}
