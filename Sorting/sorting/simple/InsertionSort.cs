namespace Sorting.sorting.simple
{
    class InsertionSort
    {
        static long countComparacao;
        static long countAtribuicoes;
        static long countTrocas;

        public static (int[], long, long, long) Sorting(int[] vet)
        {
            int j, x;
            int n = vet.Length;
            countComparacao = 0;
            countAtribuicoes = 0;
            countTrocas = 0;
            for (int i = 1; i < n; i++)
            {
                x = vet[i];
                ContarAtribuicao(1);
                j = i - 1;
                while (j >= 0 && Comparacao(vet[j], x))
                {
                    vet[j + 1] = vet[j];
                    ContarAtribuicao(1);
                    j--;
                }
                vet[j + 1] = x;
                ContarTrocas();
                ContarAtribuicao(1);
            }
            return (vet, countComparacao, countAtribuicoes, countTrocas);
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
