namespace Sorting.sorting.efficient
{
    class HeapSort
    {

        public static int[] Sorting(int[] vet)
        {
            ConstruirMaxHeap(vet);
            for (int i = vet.Length - 1; i > 0; i--)
            {
                Trocar(vet, 0, i);
                Heapify(vet, i, 0);
            }

            return vet;
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

            if ((left < size) && (vet[left] > vet[i]))
            {
                max = left;
            }
            else
            {
                max = i;
            }

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


        public static void Construir(int[] vet, int tam)
        {
            for (int i = tam; i > 1 && vet[i] > vet[i/2]; i/= 2)
            {
                Trocar(vet, i, i / 2);
            }
        }

        public static void Reconstruir(int[] vet, int tam)
        {
            int i = 1;
            while(HasFilho(i, tam) == true)
            {
                int filho = GetMaiorFilho(vet, i, tam);
                if (vet[i] < vet[filho])
                {
                    Trocar(vet, i, filho);
                    i = filho;
                }
                else
                {
                    i = tam;
                }
            }
        }

        public static bool HasFilho(int i, int tam)
        {
            return i <= (tam / 2);
        }

        public static int GetMaiorFilho(int[] vet, int i, int tam)
        {
            int filho;
            if (2*i == tam || vet[2*i] > vet[2*i + 1])
            {
                filho = 2 * i;
            }
            else
            {
                filho = 2 * i + 1;
            }
            return filho;
        }

        public static void Trocar(int[] vet, int i, int j)
        {
            int tmp = vet[i];
            vet[i] = vet[j];
            vet[j] = tmp;
        }
    }
}
