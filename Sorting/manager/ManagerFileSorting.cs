using Sorting.enums;
using Sorting.sorting.simple;
using Sorting.sorting.efficient;
using Sorting.sorting.specials;

namespace Sorting.manager
{
    class ManagerFileSorting
    {
        public static int[] Ordenar(Sortings algoritmo, int[] vet)
        {
            int[] ordenado = vet;

            switch (algoritmo)
            {
                case Sortings.BUBBLESORT:
                    ordenado = BubbleSort.Sorting(vet);
                    break;

                case Sortings.SELECTIONSORT:
                    ordenado = SelectionSort.Sorting(vet);
                    break;

                case Sortings.INSERTIONSORT:
                    ordenado = InsertionSort.Sorting(vet);
                    break;

                case Sortings.BUCKETSORT:
                    break;

                case Sortings.COUNTINGSORT:
                    ordenado = CountingSort.Sorting(vet);
                    break;

                case Sortings.RADIXSORT:
                    ordenado = RadixSort.Sorting(vet);
                    break;

                case Sortings.SHELLSORT:
                    ordenado = ShellSort.Sorting(vet);
                    break;

                case Sortings.QUICKSORT:
                    ordenado = QuickSort.Sorting(vet, 0, vet.Length - 1);
                    break;

                case Sortings.MERGESORT:
                    ordenado = MergeSort.Sorting(vet, 0, vet.Length - 1);
                    break;

                case Sortings.HEAPSORT:
                    ordenado = HeapSort.Sorting(vet);
                    break;
            }

            return ordenado;
        }
    }
}
