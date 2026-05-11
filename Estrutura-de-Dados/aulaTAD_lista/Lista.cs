public class Lista
{
    // Atributos
    public No inicio; // cabeça
    public No fim;    // cauda


    // Construtor
    public Lista()
    {
        this.inicio = null;
        this.fim = null;
    }

    public bool estVazia()
    {
        return this.inicio == null && this.fim == null;
    }

    public void inserirInicio(int valor)
    {
        No novoNo = new No(valor);

        if (this.estVazia())
        {
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else
        {
            novoNo.prox = this.inicio;
            this.inicio = novoNo;
        }
    }

    public void Percurso()
    {
        No noAtual = this.inicio;

        while (noAtual != null)
        {
            Console.WriteLine(noAtual.valor + " -> ");
            noAtual = noAtual.prox;
        }

        Console.WriteLine("null");
    }

    public bool buscar(int chave)
    {
        No noAtual = this.inicio;

        while (noAtual != null)
        {
            if (noAtual.valor == chave)
            {
                return true;
            }

            noAtual = noAtual.prox;
        }

        return false;
    }
}
