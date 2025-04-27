namespace Sorting.sorting.specials
{
    class RadixSort
    {
        public static int[] Sorting(int[] vet)
        {
            int max = GetMaior(vet);

            for (int exponent = 1; max / exponent > 0; exponent *= 10)
            {
                vet = CountingSortDigits(vet, exponent);
            }

            return vet;
        }

        public static int GetMaior(int[] vet)
        {
            int max = vet[0];

            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] > max)
                {
                    max = vet[i];
                }
            }

            return max;
        }

        public static int[] CountingSortDigits(int[] vet, int exponent)
        {
            int[] count = new int[10];
            int[] ordenado = new int[vet.Length];

            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < vet.Length; i++)
            {
                count[(vet[i] / exponent) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = vet.Length - 1; i >=0; i--)
            {
                ordenado[count[(vet[i] / exponent) % 10] - 1] = vet[i];
                count[(vet[i] / exponent) % 10]--;
            }

            return ordenado;
        }
    }
}
