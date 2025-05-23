using System;
using System.Diagnostics;
using Sorting.manager;
using Sorting.print;
using Sorting.basic_class.@static;
using Sorting.basic_class.dynamic;

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
        int z;
        Sorting.enums.Sortings sorting = Sorting.enums.Sortings.NONE;

        do
        {
            Console.WriteLine("Escolha uma ação:\n" +
                                  "1 - Ordernar arquivos\n" +
                                  "2 - Manipular Fila estática\n" +
                                  "3 - Manipular Pilha estática\n" +
                                  "4 - Ordenar Lista estática\n" +
                                  "0 - Sair");

            z = int.Parse(Console.ReadLine());


            switch (z)
            {
                case 1:
                    Console.WriteLine("Escolha o arquivo a ser lido:\n" +
                                  "1 - 10-aleatorios\n" +
                                  "2 - 100-aleatorios\n" +
                                  "3 - 1000-aleatorios\n" +
                                  "4 - 10000-aleatorios\n" +
                                  "5 - 100000-aleatorios\n" +
                                  "6 - 1000000-aleatorios\n" +
                                  "7 - 1000000-ordenados\n" +
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
                                          "8 - Counting sort\n" +
                                          "9 - RadixSort");

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
                                    sorting = Sorting.enums.Sortings.COUNTINGSORT;
                                    break;
                                case 9:
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
                        case 7:
                            vet = ManagerFileReader.Arquivo1000000OrdenadoTXT();
                            break;
                        default:
                            vet = new int[0];
                            break;
                    }

                    if (vet.Length > 0 && sorting != Sorting.enums.Sortings.NONE)
                    {
                        // Inicia relogio
                        Console.WriteLine($"Ordenação iniciada: {DateTime.Now}");
                        Stopwatch stopwatch = Stopwatch.StartNew();

                        // Ordenacao
                        var (ordenado, countComparacao, countAtribuicoes, countTrocas) = ManagerFileSorting.Ordenar(sorting, vet);

                        // Para relogio
                        stopwatch.Stop();
                        Console.WriteLine($"Ordenação finalizada: {DateTime.Now}");
                        Console.WriteLine($"Tempo de execução: {stopwatch.Elapsed}");

                        // Imprime numero de comparacoes
                        Console.WriteLine($"Numero de comparações: {countComparacao}");

                        // Imprime numero de atribuicoes
                        Console.WriteLine($"Numero de atribuições: {countAtribuicoes}");

                        // Imprime numero de atribuicoes
                        Console.WriteLine($"Numero de trocas: {countTrocas}");

                        // Imprime vetor ordenado
                        PrintSolutionStatic.ImprimirArrayMesmaLinha(ordenado, sorting);
                    }
                    break;
                case 2:
                    Fila fila = new Fila(100);
                    vet = ManagerFileReader.Arquivo100TXT();
                    fila.InserirFila(vet);

                    int entradaFila;
                    do
                    {
                        Console.WriteLine("Escolha uma ação:\n" +
                                  "1 - Mostrar Fila\n" +
                                  "2 - Inserir elemento\n" +
                                  "3 - Remover elemento\n" +
                                  "0 - Sair");

                        entradaFila = int.Parse(Console.ReadLine());

                        switch (entradaFila)
                        {
                            case 1:
                                fila.Mostrar();
                                break;
                            case 2:
                                Console.WriteLine("Informe o elemento (em inteiro) a ser inserido");
                                int item = int.Parse(Console.ReadLine());
                                fila.Inserir(item);
                                break;
                            case 3:
                                fila.Remover();
                                break;
                        }
                    } while (entradaFila != 0);

                    break;
                case 3:
                    Pilha pilha = new Pilha(100);
                    vet = ManagerFileReader.Arquivo100TXT();
                    pilha.InserirPilha(vet);

                    int entradaPilha;
                    do
                    {
                        Console.WriteLine("Escolha uma ação:\n" +
                                  "1 - Mostrar Pilha\n" +
                                  "2 - Inserir elemento\n" +
                                  "3 - Remover elemento\n" +
                                  "0 - Sair");

                        entradaPilha = int.Parse(Console.ReadLine());

                        switch (entradaPilha)
                        {
                            case 1:
                                pilha.Mostrar();
                                break;
                            case 2:
                                Console.WriteLine("Informe o elemento (em inteiro) a ser inserido");
                                int item = int.Parse(Console.ReadLine());
                                pilha.Inserir(item);
                                break;
                            case 3:
                                pilha.Remover();
                                break;
                        }
                    } while (entradaPilha != 0);

                    break;
                case 4:
                    Lista lista = new Lista(1000000);
                    vet = ManagerFileReader.Arquivo1000000TXT();
                    lista.InserirLista(vet);
                    lista.Sort();

                    Console.WriteLine("Lista ordenada:");

                    lista.Mostrar();
                    break;
            }
        } while (z != 0);
    }
}