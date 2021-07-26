using Xadrez_Jogo.tabuleiro;
using Xadrez_Jogo.tabuleiro.Enums;

namespace Xadrez_Jogo.xadrez
{
    class Rei : Peca
    {
        /*
         * Construtores
         */
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        /*
         * ToString da classe
         */
        public override string ToString()
        {
            return "R";
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
            if(Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //nordeste
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if(Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //direita
            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            if(Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //sudeste
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if(Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //abaixo
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            if(Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //sudoeste
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //esquerda
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // noroeste
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;
        }
    }
}
