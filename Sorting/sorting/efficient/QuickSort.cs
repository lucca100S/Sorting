namespace Sorting.sorting.efficient
{
    class QuickSort
    {
        public static int[] Sorting(int[] vet, int esq, int dir)
        {
            int i = esq;
            int j = dir;
            int pivo = vet[(esq + dir) / 2];

            while(i <= j)
            {
                while (vet[i] < pivo)
                {
                    i++;
                }
                while (vet[j] > pivo)
                {
                    j--;
                }
                if (i <= j)
                {
                    // Troca de itens
                    int tmp = vet[i];
                    vet[i] = vet[j];
                    vet[j] = tmp;

                    i++;
                    j--;
                }
            }
            if (esq < j)
            {
                vet = Sorting(vet, esq, j);
            }
            if (i < dir)
            {
                vet = Sorting(vet, i, dir);
            }

            return vet;
        }
    }
}
