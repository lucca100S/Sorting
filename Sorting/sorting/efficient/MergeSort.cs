namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        public static int[] Sorting(int[] vet, int esq, int dir)
        {
            if (esq < dir)
            {
                int meio = (esq + dir) / 2;
                Sorting(vet, esq, meio);
                Sorting(vet, meio + 1, dir);
                Intercalar(vet, esq, meio, dir);
            }
            
            return vet;
        }

        public static void Intercalar(int[] vet, int esq, int meio, int dir)
        {
            int nEsq = (meio + 1) - esq;
            int nDir = dir - meio;

            int[] vetEsq = new int[nEsq];
            int[] vetDir = new int[nDir];

            int iEsq, iDir;

            for (iEsq = 0; iEsq < nEsq; iEsq++)
            {
                vetEsq[iEsq] = vet[esq + iEsq];
            }

            for (iDir = 0; iDir < nDir; iDir++)
            {
                vetDir[iDir] = vet[(meio + 1) + iDir];
            }

            iEsq = 0;
            iDir = 0;

            int i = esq;
            while (iEsq < nEsq && iDir < nDir)
            {
                if (vetEsq[iEsq] <= vetDir[iDir])
                {
                    vet[i] = vetEsq[iEsq];
                    iEsq++;
                }
                else
                {
                    vet[i] = vetDir[iDir];
                    iDir++;
                }
                i++;
            }

            while(iEsq < nEsq)
            {
                vet[i] = vetEsq[iEsq];
                iEsq++;
                i++;
            }

            while (iDir < nDir)
            {
                vet[i] = vetDir[iDir];
                iDir++;
                i++;
            }
        }
    }
}
