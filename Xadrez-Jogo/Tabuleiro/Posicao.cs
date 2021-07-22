
namespace Xadrez_Jogo.tabuleiro
{/*
  * Nessa classe é onde será criada o objeto posicao do jogo.
  */
    class Posicao
    {
        /*
         * Properties
         */
        public int Linha { get; set; }
        public int Coluna { get; set; }

        /*
         * Construtores
         */
        public Posicao()
        {

        }
        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        /*
         * ToString
         */
        public override string ToString()
        {
            return Linha +
                ", " +
                Coluna;
        }
    }
}
