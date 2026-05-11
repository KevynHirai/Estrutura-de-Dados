namespace ListaStruct;

public struct JogadorFutebol
{
    public string nome;
    public int idade;
    public string posicao;
    public string clube;
    public int numeroCamisa;
    public int numeroCartoesAmarelos;
    public int numeroCartoesVermelhos;

    public JogadorFutebol(
        string nome,
        int idade,
        string posicao,
        string clube,
        int numeroCamisa,
        int numeroCartoesAmarelos,
        int numeroCartoesVermelhos
    )
    {
        this.nome = nome;
        this.idade = idade;
        this.posicao = posicao;
        this.clube = clube;
        this.numeroCamisa = numeroCamisa;
        this.numeroCartoesAmarelos = numeroCartoesAmarelos;
        this.numeroCartoesVermelhos = numeroCartoesVermelhos;
    }

    public void registrarNumeroCartoesAmarelos()
    {
        this.numeroCartoesAmarelos++;
    }

    public void registrarNumeroCartoesVermelhos()
    {
        this.numeroCartoesVermelhos++;
    }

    public string verificarVinculoClube()
    {
        if (this.clube != "")
        {
            return "O jogador possui vínculo com o clube " + this.clube + ".";
        }

        return "O jogador não possui vínculo com nenhum clube.";
    }

    public string imprimir()
    {
        return "\nNome: " + this.nome +
               "\nIdade: " + this.idade +
               "\nPosição: " + this.posicao +
               "\nClube: " + this.clube +
               "\nNúmero da camisa: " + this.numeroCamisa +
               "\nCartões amarelos: " + this.numeroCartoesAmarelos +
               "\nCartões vermelhos: " + this.numeroCartoesVermelhos;
    }
}
