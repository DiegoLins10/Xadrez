using Xadrez_Jogo.tabuleiro.Enums;

namespace Xadrez_Jogo.tabuleiro
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

        public Peca( Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QteMovimentos = 0;
            Tabuleiro = tabuleiro;
        }

        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }
    }
}
