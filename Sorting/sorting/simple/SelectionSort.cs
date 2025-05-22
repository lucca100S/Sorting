namespace Sorting.sorting.simple
{
    class SelectionSort
    {
        static long countComparacao;
        static long countAtribuicoes;
        static long countTrocas;

        public static (int[], long, long, long) Sorting(int[] vet)
        {
            int n = vet.Length;
            int min;
            countComparacao = 0;
            countAtribuicoes = 0;
            countTrocas = 0;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    ContarComparacao();
                    if (vet[j] < vet[min])
                    {
                        min = j;
                    }
                }

                int tmp = vet[i];
                vet[i] = vet[min];
                vet[min] = tmp;
                ContarTrocas();
                ContarAtribuicao(3);
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
