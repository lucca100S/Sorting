namespace Sorting.sorting.simple
{
    class BubbleSort
    {
        static long countComparacao;
        static long countAtribuicoes;
        static long countTrocas;

        public static (int[], long, long, long) Sorting(int[] vet)
        {
            int n = vet.Length;
            countComparacao = 0;
            countAtribuicoes = 0;
            countTrocas = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    ContarComparacao();
                    if (vet[j] < vet[j - 1])
                    {
                        int tmp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = tmp;
                        ContarTrocas();
                        ContarAtribuicao(3);
                    }
                }
            }

            return (vet, countComparacao, countAtribuicoes, countTrocas);
        }

        public static void ContarComparacao()
        {
            countComparacao++;
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
