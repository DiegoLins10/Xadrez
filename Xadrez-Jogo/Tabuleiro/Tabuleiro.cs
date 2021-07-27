
using Xadrez_Jogo.tabuleiro.Exceptions;

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
        public Peca Peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca Peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        /*
         * Verificando se existe uma pesa em determinada posicao
         */
        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }

        /*
         *Colocando um objeto peca em uma posicao 
         */
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peca nessa posicao!");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        /*
         * Metodo para retirar peças
         */
        public Peca RetirarPeca(Posicao pos)
        {
            if(Peca(pos) == null)
            {
                return null;
            }
            Peca aux = Peca(pos);
            aux.Posicao = null;
            pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        /*
         * Validando posicao recebida
         */
        public bool PosicaoValida(Posicao pos)
        {
            if(pos.Linha < 0 || pos.Linha>=Linhas || pos.Coluna<0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        /*
         * Chama a exception personalizada
         */
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posicao invalida!!!");
            }
        }
    }
}
