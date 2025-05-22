namespace Sorting.sorting.specials
{
    class CountingSort
    {
        static long countComparacao;
        static long countAtribuicoes;
        static long countTrocas;

        public static (int[], long, long, long) Sorting(int[] vet)
        {
            countComparacao = 0;
            countAtribuicoes = 0;
            countTrocas = 0;

            int[] count = new int[GetMaior(vet) + 1];
            int[] ordenado = new int[vet.Length];

            for (int i = 0; i < vet.Length; i++)
            {
                count[i] = 0;
                ContarAtribuicao(1);
            }

            for (int i = 0; i < vet.Length; i++)
            {
                count[vet[i]]++;
                ContarAtribuicao(1);
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
                ContarAtribuicao(1);
            }

            for (int i = vet.Length - 1; i >= 0; i--)
            {
                ordenado[count[vet[i]] - 1] = vet[i];
                count[vet[i]]--;
                ContarTrocas();
                ContarAtribuicao(2);
            }

            return (ordenado, countComparacao, countAtribuicoes, countTrocas);
        }

        public static int GetMaior(int[] vet)
        {
            int max = vet[0];

            for(int i = 1; i < vet.Length; i++)
            {
                ContarComparacao();
                if (vet[i] > max)
                {
                    max = vet[i];
                }
            }

            return max;
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
