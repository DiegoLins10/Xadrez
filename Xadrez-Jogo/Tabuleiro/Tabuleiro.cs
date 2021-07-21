
namespace Xadrez_Jogo.Tabuleiro
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

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}
