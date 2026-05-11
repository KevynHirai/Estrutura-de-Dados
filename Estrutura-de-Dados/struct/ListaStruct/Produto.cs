namespace ListaStruct;

public struct Produto
{
    public string nome;
    public string categoria;
    public double preco;
    public int quantidadeEmEstoque;

    public Produto(
        string nome,
        string categoria,
        double preco,
        int quantidadeEmEstoque
    )
    {
        this.nome = nome;
        this.categoria = categoria;
        this.preco = preco;
        this.quantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void aplicarCupomDescontoValor(double valorDesconto)
    {
        this.preco -= valorDesconto;

        if (this.preco < 0)
        {
            this.preco = 0;
        }
    }

    public void aplicarCupomDescontoPorcentagem(double porcentagem)
    {
        double desconto = this.preco * porcentagem / 100;
        this.preco -= desconto;

        if (this.preco < 0)
        {
            this.preco = 0;
        }
    }

    public string verificarQuantidadeEmEstoque()
    {
        if (this.quantidadeEmEstoque > 0)
        {
            return "Produto disponível em estoque.";
        }

        return "Produto indisponível em estoque.";
    }

    public string imprimir()
    {
        return "\nNome: " + this.nome +
               "\nCategoria: " + this.categoria +
               "\nPreço: R$ " + this.preco.ToString("F2") +
               "\nQuantidade em estoque: " + this.quantidadeEmEstoque;
    }
}
