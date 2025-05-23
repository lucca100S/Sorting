namespace Sorting.basic_class.dynamic
{
    internal class FilaDinamica
    {
        Celula? primeiro;
        Celula? ultimo;

        public FilaDinamica()
        {
            primeiro = null;
            ultimo = null;
        }

        public void Inserir(int valor)
        {
            if (primeiro == null) // Fila está vazia
            {
                primeiro = new Celula(valor);
                ultimo = primeiro;
            }
            else
            {
                Celula tmp = ultimo!; // Ultimo não será nulo
                ultimo = new Celula(valor);
                tmp.prox = ultimo;
            }
        }

        public int? Remover()
        {
            if (primeiro == null)
            {
                Console.WriteLine("Fila vazia. Impossível remover");
                return null;
            }
            else if (primeiro == ultimo) // Fila contem apenas um elemento
            {
                int? valor = primeiro.valor;
                primeiro = ultimo = null;
                Console.WriteLine("Elemento removido com sucesso");
                return valor;
            }
            else
            {
                int? valor = primeiro.valor;
                Celula tmp = primeiro;
                primeiro = primeiro.prox;
                tmp.prox = null;
                Console.WriteLine("Elemento removido com sucesso");
                return valor;
            }
        }

        public void Mostrar()
        {
            if (primeiro == null)
            {
                Console.WriteLine("Fila vazia");
            }
            else
            {
                Celula? tmp = primeiro;
                do
                {
                    Console.Write($"{tmp.valor} ");
                    tmp = tmp.prox;
                }
                while (tmp != null);
            }
        }
    }
}
