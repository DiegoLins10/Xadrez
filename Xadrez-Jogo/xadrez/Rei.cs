using Xadrez_Jogo.tabuleiro;
using Xadrez_Jogo.tabuleiro.Enums;

namespace Xadrez_Jogo.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
