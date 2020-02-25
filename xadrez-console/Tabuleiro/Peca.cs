
namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qtdMovimentos = 0;
        }

        public void IncrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }

        public void DecrementarQtdMovimentos()
        {
            qtdMovimentos--;
        }

        public abstract bool[,] MovimentosPossiveis();

        public bool ExisteMovimentosPossiveis()
        {
            bool [,] match = MovimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (match[i, j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.linha, pos.coluna];
        }
    }
}
