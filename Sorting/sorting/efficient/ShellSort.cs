namespace Sorting.sorting.efficient
{
    class ShellSort
    {
        static long countComparacao;
        static long countAtribuicoes;
        static long countTrocas;

        public static (int[], long, long, long) Sorting(int[] vet)
        {
            countComparacao = 0;
            countAtribuicoes = 0;
            countTrocas = 0;
            int h = 1;
            do
            {
                h = (h * 3) + 1;
            }
            while (h < vet.Length);

            do
            {
                h /= 3;
                for (int cor = 0; cor < h; cor++)
                {
                    InsercaoPorCor(cor, h, vet);
                }
            }
            while (h != 1);
            
            return (vet, countComparacao, countAtribuicoes, countTrocas);
        }

        public static void InsercaoPorCor(int cor, int h, int[] vet)
        {
            for (int i = (h + cor); i < vet.Length; i += h)
            {
                int tmp = vet[i];
                ContarAtribuicao(1);
                int j = i - h;
                while ((j >= 0) && Comparacao(vet[j], tmp))
                {
                    vet[j + h] = vet[j];
                    ContarAtribuicao(1);
                    j -= h;
                }
                vet[j + h] = tmp;
                ContarTrocas();
                ContarAtribuicao(1);
            }
        }

        public static bool Comparacao(int a, int b)
        {
            countComparacao++;
            return a > b;
        }

        public static void ContarAtribuicao(int soma)
        {
            countAtribuicoes += soma;
        }

        public static void ContarTrocas()
        {
            countTrocas++;
        }
    }
}
