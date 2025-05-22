namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        public static long countComparacao;
        public static long countAtribuicoes;
        public static long countTrocas;

        public static (int[], long, long, long) Sorting(int[] vet, int esq, int dir)
        {
            if (esq < dir)
            {
                int meio = (esq + dir) / 2;
                Sorting(vet, esq, meio);
                Sorting(vet, meio + 1, dir);
                Intercalar(vet, esq, meio, dir);
            }
            
            return (vet, countComparacao, countAtribuicoes, countTrocas);
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
                ContarAtribuicao(1);
            }

            for (iDir = 0; iDir < nDir; iDir++)
            {
                vetDir[iDir] = vet[(meio + 1) + iDir];
                ContarAtribuicao(1);
            }

            iEsq = 0;
            iDir = 0;

            int i = esq;
            while (iEsq < nEsq && iDir < nDir)
            {
                ContarComparacao();
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
                ContarAtribuicao(1);
                ContarTrocas();
            }

            while(iEsq < nEsq)
            {
                vet[i] = vetEsq[iEsq];
                ContarAtribuicao(1);
                iEsq++;
                i++;
                ContarTrocas();
            }

            while (iDir < nDir)
            {
                vet[i] = vetDir[iDir];
                ContarAtribuicao(1);
                iDir++;
                i++;
                ContarTrocas();
            }
        }

        public static void ContarComparacao()
        {
            countComparacao++;
        }

        public static void ContarAtribuicao(int soma)
        {
            countAtribuicoes += soma;
        }

        public static void ContarTrocas()
        {
            countTrocas++;
        }
    }
}
