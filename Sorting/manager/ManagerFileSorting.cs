using Sorting.enums;
using Sorting.sorting.simple;
using Sorting.sorting.efficient;
using Sorting.sorting.specials;

namespace Sorting.manager
{
    class ManagerFileSorting
    {
        public static (int[], long, long, long) Ordenar(Sortings algoritmo, int[] vet)
        {
            int[] ordenado = vet;
            long countComparacao = 0;
            long countAtribuicoes = 0;
            long countTrocas = 0;
            switch (algoritmo)
            {
                case Sortings.BUBBLESORT:
                    (ordenado, countComparacao, countAtribuicoes, countTrocas) = BubbleSort.Sorting(vet);
                    break;

                case Sortings.SELECTIONSORT:
                    (ordenado, countComparacao, countAtribuicoes, countTrocas) = SelectionSort.Sorting(vet);
                    break;

                case Sortings.INSERTIONSORT:
                    (ordenado, countComparacao, countAtribuicoes, countTrocas) = InsertionSort.Sorting(vet);
                    break;

                case Sortings.BUCKETSORT:
                    break;

                case Sortings.COUNTINGSORT:
                    (ordenado, countComparacao, countAtribuicoes, countTrocas) = CountingSort.Sorting(vet);
                    break;

                case Sortings.RADIXSORT:
                    (ordenado, countComparacao, countAtribuicoes, countTrocas) = RadixSort.Sorting(vet);
                    break;

                case Sortings.SHELLSORT:
                    (ordenado, countComparacao, countAtribuicoes, countTrocas) = ShellSort.Sorting(vet);
                    break;

                case Sortings.QUICKSORT:
                    // Inicializa contagem
                    QuickSort.countComparacao = 0; 
                    QuickSort.countAtribuicoes = 0;
                    QuickSort.countTrocas = 0;

                    // Ordenacao
                    (ordenado, countComparacao, countAtribuicoes, countTrocas) = QuickSort.Sorting(vet, 0, vet.Length - 1);
                    break;

                case Sortings.MERGESORT:
                    // Inicializa contagem
                    MergeSort.countComparacao = 0; 
                    MergeSort.countAtribuicoes = 0;
                    MergeSort.countTrocas = 0;

                    // Ordenacao
                    (ordenado, countComparacao, countAtribuicoes, countTrocas) = MergeSort.Sorting(vet, 0, vet.Length - 1);
                    break;

                case Sortings.HEAPSORT:
                    (ordenado, countComparacao, countAtribuicoes, countTrocas) = HeapSort.Sorting(vet);
                    break;
            }

            return (ordenado, countComparacao, countAtribuicoes, countTrocas);
        }
    }
}
