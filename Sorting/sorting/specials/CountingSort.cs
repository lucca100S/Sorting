namespace Sorting.sorting.specials
{
    class CountingSort
    {
        public static int[] Sorting(int[] vet)
        {
            int[] count = new int[GetMaior(vet) + 1];
            int[] ordenado = new int[vet.Length];

            for (int i = 0; i < count.Length; count[i] = 0, i++) ;

            for (int i = 0; i < vet.Length; count[vet[i]]++, i++) ;

            for (int i = 1; i < count.Length; count[i] += count[i - 1], i++) ;

            for (int i = vet.Length - 1; i >= 0; ordenado[count[vet[i]] - 1] = vet[i], count[vet[i]]--, i--) ;


            return ordenado;
        }

        public static int GetMaior(int[] vet)
        {
            int max = vet[0];

            for(int i = 1; i < vet.Length; i++)
            {
                if (vet[i] > max)
                {
                    max = vet[i];
                }
            }

            return max;
        }
    }
}
