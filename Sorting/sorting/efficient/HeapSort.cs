namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        static long countComparacao;
        static long countAtribuicoes;
        static long countTrocas;

        public static (int[], long, long, long) Sorting(int[] vet)
        {
            countComparacao = 0;
            countAtribuicoes = 0;
            countTrocas = 0;
            ConstruirMaxHeap(vet);
            for (int i = vet.Length - 1; i > 0; i--)
            {
                Trocar(vet, 0, i);
                Heapify(vet, i, 0);
            }

            return (vet, countComparacao, countAtribuicoes, countTrocas);
        }

        public static void ConstruirMaxHeap(int[] vet)
        {
            for (int i = (vet.Length / 2) - 1; i >= 0; i--)
            {
                Heapify(vet, vet.Length, i);
            }
        }

        public static void Heapify(int[] vet, int size, int i)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            int max;

            ContarComparacao();
            if ((left < size) && (vet[left] > vet[i]))
            {
                max = left;
            }
            else
            {
                max = i;
            }

            ContarComparacao();
            if ((right < size) && (vet[right] > vet[max]))
            {
                max = right;
            }

            if (max != i)
            {
                Trocar(vet, i, max);
                Heapify(vet, size, max);
            }
        }

        public static void Trocar(int[] vet, int i, int j)
        {
            int tmp = vet[i];
            vet[i] = vet[j];
            vet[j] = tmp;

            ContarTrocas();
            ContarAtribuicao(3);
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
