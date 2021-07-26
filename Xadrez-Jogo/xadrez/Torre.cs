using Xadrez_Jogo.tabuleiro;
using Xadrez_Jogo.tabuleiro.Enums;

namespace Xadrez_Jogo.xadrez
{
    class Torre : Peca
    {
        /*
         * Construtores
         */
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        /*
         * Metodo toString
         */
        public override string ToString()
        {
            return "T";
        }

        /*
        * Verifica se a pesa pdoe mover para a posição
        * ou se tem uma peca adversaria
        * conforme as regras do xadrez
        */
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != this.Cor;
        }

        /*
         * sobrescrevendo metodo abstract da classe pai
         * aqui é colocada a regra de movimentãção do rei
         * esse metodo está atribuindo as regras para onde o rei pode se mexer.
         * retorna uma matriz com os movimento possiveis de um rei
         */
        public override bool[,] movimentosPosiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            while(Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(Tab.peca(pos)!= null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }
            //abaixo
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            while(Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(Tab.peca(pos)!= null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }
            //direita
            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            while(Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(Tab.peca(pos)!= null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }
            //esquerda
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            while(Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(Tab.peca(pos)!= null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }
            return mat;
        }
    }
}
