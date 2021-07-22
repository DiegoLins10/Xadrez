
namespace Xadrez_Jogo.tabuleiro
{
    /*
     * Classe que vai representar o objeto tabuleiro 
     */
    class Tabuleiro
    {
      /*
      * Properties e atributos, usando um atributo matriz do tipo Peca para representar o tabuleiro
      */
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas; 

        /*
         * Construtores
         */
        public Tabuleiro()
        {

        }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            this.pecas = new Peca[Linhas, Colunas];
        }

        /*
         * Retorna as pecas do tabuleiro
         */
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        /*
         *Colocando um objeto peca em uma posicao 
         */
        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
