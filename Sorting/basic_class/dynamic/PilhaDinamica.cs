namespace Sorting.basic_class.dynamic
{
    internal class PilhaDinamica
    {
        Celula? topo;

        public PilhaDinamica()
        {
            topo = null;
        }

        public void Inserir(int valor)
        {
            if (topo == null)
            {
                topo = new Celula(valor);
            }
            else
            {
                Celula tmp = topo;
                topo = new Celula(valor);
                topo.prox = tmp;
            }
        }

        public int? Remover()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia. Impossível remover");
                return null;
            }
            else
            {
                int? valor = topo.valor;
                Celula tmp = topo;
                topo = topo.prox;
                tmp.prox = null;
                Console.WriteLine("Elemento removido com sucesso");
                return valor;
            }
        }

        public void Mostrar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia");
            }
            else
            {
                Celula? tmp = topo;
                do
                {
                    Console.WriteLine(tmp.valor);
                    tmp = tmp.prox;
                }
                while (tmp != null);
            }
        }
    }
}
