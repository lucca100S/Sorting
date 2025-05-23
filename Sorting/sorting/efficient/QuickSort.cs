using Sorting.print;
using Sorting.enums;

namespace Sorting.sorting.efficient
{
    class QuickSort
    {
        public static long countComparacao;
        public static long countAtribuicoes;
        public static long countTrocas;

        public static (int[] Ordenado, long, long, long) Sorting(int[] vet, int esq, int dir)
        {
            int i = esq;
            int j = dir;
            int pivo = vet[(esq + dir) / 2];
            ContarAtribuicao(1);

            while(i <= j)
            {
                while (Comparacao(pivo, vet[i])) // vet[i] < pivo
                {
                    i++;
                }
                while (Comparacao(vet[j], pivo)) // vet[j] > pivo
                {
                    j--;
                }
                if (i <= j)
                {
                    // Troca de itens
                    int tmp = vet[i];
                    vet[i] = vet[j];
                    vet[j] = tmp;
                    ContarTrocas();
                    ContarAtribuicao(3);

                    i++;
                    j--;
                }
            }

            if (esq < j)
            {
                Sorting(vet, esq, j);
            }
            if (i < dir)
            {
                Sorting(vet, i, dir);
            }

            return (vet, countComparacao,countAtribuicoes, countTrocas);
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
