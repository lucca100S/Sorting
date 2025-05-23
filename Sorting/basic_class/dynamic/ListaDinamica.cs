namespace Sorting.basic_class.dynamic
{
    internal class ListaDinamica
    {
        Celula? primeiro;
        Celula? ultimo;

        public ListaDinamica()
        {
            primeiro = ultimo = null;
        }

        public void InserirInicio(int valor)
        {
            if (primeiro == null) // Lista está vazia
            {
                primeiro = new Celula(valor);
                ultimo = primeiro;
            }
            else
            {
                Celula tmp = primeiro!; // Primeiro não será nulo
                primeiro = new Celula(valor);
                primeiro.prox = tmp;
            }
        }

        public void InserirFim(int valor)
        {
            if (primeiro == null) // Lista está vazia
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

        public void InserirPos(int valor, int pos)
        {
            if (pos >= 0)
            {
                if (primeiro == null) // Lista está vazia
                {
                    primeiro = new Celula(valor);
                    ultimo = primeiro;
                }
                else
                {
                    Celula? tmp = primeiro;
                    int count = 0;
                    while (count < pos - 1)
                    {
                        if (tmp.prox == null)
                        {
                            Console.WriteLine("Não é possível inserir nessa posição");
                            return;
                        }
                        tmp = tmp.prox;
                        count++;
                    }

                    Celula novo = new Celula(valor);
                    if (pos == 0)
                    {
                        novo.prox = primeiro;
                        primeiro = novo;
                    }
                    else
                    {
                        novo.prox = tmp.prox;
                        tmp.prox = novo;
                    }
                }
            }
            else
            {
                Console.WriteLine("A posição deve ser maior do que 0");
            }

        }

        public int? RemoverInicio()
        {
            if (primeiro == null)
            {
                Console.WriteLine("Lista vazia. Impossível remover");
                return null;
            }
            else if (primeiro == ultimo) // Lista contem apenas um elemento
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

        public int? RemoverFim()
        {
            if (primeiro == null)
            {
                Console.WriteLine("Lista vazia. Impossível remover");
                return null;
            }
            else if (primeiro == ultimo) // Lista contem apenas um elemento
            {
                int? valor = ultimo.valor;
                primeiro = ultimo = null;
                Console.WriteLine("Elemento removido com sucesso");
                return valor;
            }
            else
            {
                Celula tmp = primeiro!;
                while (tmp.prox != ultimo)
                {
                    tmp = tmp.prox;
                }

                int? valor = ultimo!.valor; // Ultimo não será nulo
                tmp.prox = null;
                ultimo = tmp;
                Console.WriteLine("Elemento removido com sucesso");
                return valor;
            }
        }

        public int? RemoverPos(int pos)
        {
            if (pos >= 0)
            {
                if (primeiro == null)
                {
                    Console.WriteLine("Lista vazia. Impossível remover");
                    return null;
                }
                else if (primeiro == ultimo) // Lista contem apenas um elemento
                {
                    int? valor = ultimo.valor;
                    primeiro = ultimo = null;
                    Console.WriteLine("Elemento removido com sucesso");
                    return valor;
                }
                else
                {
                    Celula? tmp = primeiro;
                    int count = 0;
                    while (count < pos - 1)
                    {
                        tmp = tmp.prox;
                        count++;
                    }

                    if (tmp.prox == null)
                    {
                        Console.WriteLine("Não é possível remover nessa posição");
                        return null;
                    }

                    Celula? removido;
                    if (pos == 0)
                    {
                        removido = primeiro;
                        primeiro = primeiro.prox;
                    }
                    else
                    {
                        removido = tmp.prox;
                        tmp.prox = removido.prox;
                    }
                    removido.prox = null;
                    int? valor = removido.valor;
                    Console.WriteLine("Elemento removido com sucesso");
                    return valor;
                }
            }
            else
            {
                Console.WriteLine("A posição deve ser maior do que 0");
                return null;
            }

        }

        public void Mostrar()
        {
            if (primeiro == null)
            {
                Console.WriteLine("Lista vazia");
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

        public void MostrarPos(int pos)
        {
            if (pos >= 0)
            {
                if (primeiro == null)
                {
                    Console.WriteLine("Lista vazia");
                }
                else
                {
                    Celula? tmp = primeiro;
                    int count = 0;
                    while (count < pos)
                    {
                        if (tmp.prox == null)
                        {
                            Console.WriteLine("Posição escolhida ultrapassa o tamanho da lista");
                            return;
                        }
                        tmp = tmp.prox;
                        count++;
                    }
                    Console.WriteLine(tmp.valor);
                }
            }
            else
            {
                Console.WriteLine("A posição deve ser maior do que 0");
            }
        }
    }
}
