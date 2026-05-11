namespace ListaStruct;

public struct Professor
{
    public string nome;
    public string disciplina;
    public int cargaHoraria;
    public double salario;
    public int quantidadeFaltas;

    public Professor(
        string nome,
        string disciplina,
        int cargaHoraria,
        double salario,
        int quantidadeFaltas
    )
    {
        this.nome = nome;
        this.disciplina = disciplina;
        this.cargaHoraria = cargaHoraria;
        this.salario = salario;
        this.quantidadeFaltas = quantidadeFaltas;
    }

    public void reajusteSalarialEmValor(double valor)
    {
        this.salario += valor;
    }

    public void reajusteSalarialEmPorcentagem(double porcentagem)
    {
        double reajuste = this.salario * porcentagem / 100;
        this.salario += reajuste;
    }

    public void descontoSalarialPorFaltaEmValor(double valor)
    {
        this.quantidadeFaltas++;
        this.salario -= valor;

        if (this.salario < 0)
        {
            this.salario = 0;
        }
    }

    public void descontoSalarialPorFaltaEmPorcentagem(double porcentagem)
    {
        this.quantidadeFaltas++;
        double desconto = this.salario * porcentagem / 100;
        this.salario -= desconto;

        if (this.salario < 0)
        {
            this.salario = 0;
        }
    }

    public void aumentarCargaHorariaDeTrabalho(int horas, double valorReajuste)
    {
        this.cargaHoraria += horas;
        this.reajusteSalarialEmValor(valorReajuste);
    }

    public string imprimir()
    {
        return "\nNome: " + this.nome +
               "\nDisciplina: " + this.disciplina +
               "\nCarga horária: " + this.cargaHoraria + " horas" +
               "\nSalário: R$ " + this.salario.ToString("F2") +
               "\nQuantidade de faltas: " + this.quantidadeFaltas;
    }
}
