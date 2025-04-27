namespace Sorting.sorting.efficient
{
    class ShellSort
    {
        public static int[] Sorting(int[] vet)
        {
            int h = 1;
            do
            {
                h = (h * 3) + 1;
            }
            while (h < vet.Length);

            do
            {
                h /= 3;
                for (int cor = 0; cor < h; cor++)
                {
                    InsercaoPorCor(cor, h, vet);
                }
            }
            while (h != 1);
            
            return vet;
        }

        public static void InsercaoPorCor(int cor, int h, int[] vet)
        {
            for (int i = (h + cor); i < vet.Length; i += h)
            {
                int tmp = vet[i];
                int j = i - h;
                while ((j >= 0) && (vet[j] > tmp))
                {
                    vet[j + h] = vet[j];
                    j -= h;
                }
                vet[j + h] = tmp;
            }
        }
    }
}
