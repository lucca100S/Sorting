using Sorting.manager;
using Sorting.print;

public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776

        //int[] vet = ManagerFileReader.Arquivo10TXT();

        //PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.INSERTIONSORT);

        //ManagerFileSorting.Ordenar(Sorting.enums.Sortings.INSERTIONSORT, vet);

        //PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.INSERTIONSORT);

        //Console.ReadKey();

        // Crie um menu que solicite ao usuário qual é o arquivo que será lido e qual algoritmo deverá ser executado

        int[] vet;
        int x;
        Sorting.enums.Sortings sorting = Sorting.enums.Sortings.NONE;
        do
        {
            Console.WriteLine("Escolha o arquivo a ser lido:\n" +
                              "1 - 10-aleatorios\n" +
                              "2 - 100-aleatorios\n" +
                              "3 - 1000-aleatorios\n" +
                              "4 - 10000-aleatorios\n" +
                              "5 - 100000-aleatorios\n" +
                              "6 - 1000000-aleatorios\n" +
                              "0 - Sair");

            x = int.Parse(Console.ReadLine());

            if (x != 0)
            {
                bool validSortingType;
                do
                {
                    validSortingType = true;
                    Console.WriteLine("Escolha o algoritmo de ordenação a ser usado:\n" +
                                  "1 - Selection sort\n" +
                                  "2 - Insertion sort\n" +
                                  "3 - Bubble sort\n" +
                                  "4 - Heap sort\n" +
                                  "5 - Merge sort\n" +
                                  "6 - Quick sort\n" +
                                  "7 - Shell sort\n" +
                                  "8 - Bucket sort\n" +
                                  "9 - Counting sort\n" +
                                  "10 - RadixSort");

                    int y = int.Parse(Console.ReadLine());


                    switch (y)
                    {
                        case 1:
                            sorting = Sorting.enums.Sortings.SELECTIONSORT;
                            break;
                        case 2:
                            sorting = Sorting.enums.Sortings.INSERTIONSORT;
                            break;
                        case 3:
                            sorting = Sorting.enums.Sortings.BUBBLESORT;
                            break;
                        case 4:
                            sorting = Sorting.enums.Sortings.HEAPSORT;
                            break;
                        case 5:
                            sorting = Sorting.enums.Sortings.MERGESORT;
                            break;
                        case 6:
                            sorting = Sorting.enums.Sortings.QUICKSORT;
                            break;
                        case 7:
                            sorting = Sorting.enums.Sortings.SHELLSORT;
                            break;
                        case 8:
                            sorting = Sorting.enums.Sortings.BUCKETSORT;
                            break;
                        case 9:
                            sorting = Sorting.enums.Sortings.COUNTINGSORT;
                            break;
                        case 10:
                            sorting = Sorting.enums.Sortings.RADIXSORT;
                            break;
                        default:
                            Console.WriteLine("Entrada inválida. Escolha novamente o tipo do algoritmo de ordenação.");
                            validSortingType = false;
                            break;
                    }
                }
                while (!validSortingType);
            }


            switch (x)
            {
                case 1:
                    vet = ManagerFileReader.Arquivo10TXT();
                    break;
                case 2:
                    vet = ManagerFileReader.Arquivo100TXT();
                    break;
                case 3:
                    vet = ManagerFileReader.Arquivo1000TXT();
                    break;
                case 4:
                    vet = ManagerFileReader.Arquivo10000TXT();
                    break;
                case 5:
                    vet = ManagerFileReader.Arquivo100000TXT();
                    break;
                case 6:
                    vet = ManagerFileReader.Arquivo1000000TXT();
                    break;
                default:
                    vet = new int[0];
                    break;
            }

            if (vet.Length > 0 && sorting != Sorting.enums.Sortings.NONE)
            {
                Console.WriteLine(sorting.ToString());
                int[] ordenado = ManagerFileSorting.Ordenar(sorting, vet);
                PrintSolutionStatic.ImprimirArrayMesmaLinha(ordenado, sorting);
            }

        } while (x != 0);
    }
}