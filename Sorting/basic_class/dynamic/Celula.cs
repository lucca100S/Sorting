namespace Sorting.basic_class.dynamic
{
    internal class Celula
    {
        public int? valor;
        public Celula? prox;

        public Celula(int valor)
        {
            this.valor = valor;
            prox = null;
        }
    }
}
