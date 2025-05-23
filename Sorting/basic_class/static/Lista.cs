using Sorting.sorting.efficient;

namespace Sorting.basic_class.@static
{
    class Lista
    {
        public int[] lista;
        public int cont;

        public Lista(int n)
        {
            lista = new int[n];
            cont = 0;
        }

        public bool InserirFim(int item)
        {
            if (cont < lista.Length)
            {
                lista[cont] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Lista está cheia, não é possível inserir " + item);
                return false;
            }
        }

        public bool InserirInicio(int item)
        {
            if (cont < lista.Length)
            {
                for (int i = cont; i >= 0; i--)
                {
                    lista[i + 1] = lista[i];
                }
                lista[0] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Lista está cheia, não é possível inserir " + item);
                return false;
            }
        }

        public bool InserirPosicao(int pos, int item)
        {
            if (cont < lista.Length)
            {
                for (int i = cont; i >= pos; i--)
                {
                    lista[i + 1] = lista[i];
                }
                lista[pos] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Lista está cheia, não é possível inserir " + item);
                return false;
            }
        }

        public bool InserirLista(int[] dados)
        {
            if (lista.Length == dados.Length)
            {
                lista = dados;
                cont = lista.Length;
                return true;
            }
            else
            {
                Console.WriteLine("Vetor de dados não tem o mesmo tamanho q a lista. Tente novamente");
                return false;
            }
        }

        public int? RemoverFim()
        {
            if (cont != 0)
            {
                int item = lista[cont];
                lista[cont] = 0;
                cont--;
                return item;
            }
            else
            {
                Console.WriteLine("Lista vazia, por isso não é possível remover elemento.");
                return null;
            }
        }

        public int? RemoverInicio()
        {
            if (cont != 0)
            {
                int item = lista[0];
                for (int i = 1; i <= cont; i++)
                {
                    lista[i - 1] = lista[i];
                }
                cont--;
                return item;
            }
            else
            {
                Console.WriteLine("Lista vazia, por isso não é possível remover elemento.");
                return null;
            }
        }

        public int? RemoverPosicao(int pos)
        {
            if (cont != 0)
            {
                int item = lista[pos];
                for (int i = pos + 1; i<= cont; i++)
                {
                    lista[i - 1] = lista[i];
                }
                cont--;
                return item;
            }
            else
            {
                Console.WriteLine("Lista vazia, por isso não é possível remover elemento.");
                return null;
            }
        }

        public void Mostrar()
        {
            for (int i = 0; i < cont; i++)
            {
                Console.Write(lista[i] + " ");
            }

            Console.WriteLine(" ");
        }

        public void Sort()
        {
            var result = QuickSort.Sorting(lista, 0, lista.Length - 1);
            lista = result.Ordenado;
        }
    }
}
