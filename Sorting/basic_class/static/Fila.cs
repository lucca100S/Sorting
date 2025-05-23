namespace Sorting.basic_class.@static
{
    class Fila
    {
        public int[] fila;
        public int cont;
        public Fila(int n)
        {
            fila = new int[n];
            cont = 0;
        }

        public bool Inserir(int item)
        {
            if (cont < fila.Length)
            {
                fila[cont] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("\nFila está cheia!!! Não é possível inserir o " + item);
                return false;
            }
        }

        public bool InserirFila(int[] dados)
        {
            if (fila.Length == dados.Length)
            {
                fila = dados;
                cont = fila.Length;
                return true;
            }
            else
            {
                Console.WriteLine("Vetor de dados não tem o mesmo tamanho q a fila. Tente novamente");
                return false;
            }
            
        }

        public int Remover()
        {
            int tmp = fila[0];
            for (int i = 0; i < cont - 1; i++)
            {
                fila[i] = fila[i + 1];
            }

            fila[cont - 1] = -1;
            cont--;
            return tmp;
        }

        public void Mostrar()
        {
            Console.WriteLine(" Fila ");

            for (int i = 0; i < cont; i++)
            {
                Console.Write(fila[i] + " ");
            }

            Console.WriteLine(" ");

        }
    }
}
