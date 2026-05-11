namespace ListaStruct;

public struct EquipeEsports
{
    public string nome;
    public string jogo;
    public string pais;
    public int anoEstreia;
    public int numeroCampeonatosVencidos;
    public double valorTotalPremiacoes;

    public EquipeEsports(
        string nome,
        string jogo,
        string pais,
        int anoEstreia,
        int numeroCampeonatosVencidos,
        double valorTotalPremiacoes
    )
    {
        this.nome = nome;
        this.jogo = jogo;
        this.pais = pais;
        this.anoEstreia = anoEstreia;
        this.numeroCampeonatosVencidos = numeroCampeonatosVencidos;
        this.valorTotalPremiacoes = valorTotalPremiacoes;
    }

    public void registrarCampeonatoVencido(double valorPremio)
    {
        this.numeroCampeonatosVencidos++;
        this.atualizarValorTotalPremiacoes(valorPremio);
    }

    public void atualizarValorTotalPremiacoes(double valor)
    {
        this.valorTotalPremiacoes += valor;
    }

    public string verificarAnoEstreia()
    {
        int anoAtual = DateTime.Now.Year;

        if (this.anoEstreia == anoAtual)
        {
            return "A equipe é novata no cenário nacional de e-sports.";
        }

        return "A equipe é veterana no cenário nacional de e-sports.";
    }

    public string imprimir()
    {
        return "\nNome da equipe: " + this.nome +
               "\nJogo: " + this.jogo +
               "\nPaís: " + this.pais +
               "\nAno de estreia: " + this.anoEstreia +
               "\nCampeonatos vencidos: " + this.numeroCampeonatosVencidos +
               "\nValor total de premiações: R$ " + this.valorTotalPremiacoes.ToString("F2");
    }
}
