using ListaStruct;

Console.WriteLine("===== EXERCICIO 1 - JOGADOR DE FUTEBOL =====");
JogadorFutebol jogador = new JogadorFutebol(
    "Ney Silva",
    21,
    "Atacante",
    "Hive FC",
    10,
    0,
    0
);

jogador.registrarNumeroCartoesAmarelos();
jogador.registrarNumeroCartoesVermelhos();

Console.WriteLine(jogador.verificarVinculoClube());
Console.WriteLine(jogador.imprimir());


Console.WriteLine("\n===== EXERCICIO 2 - EQUIPE DE ESPORTS =====");
EquipeEsports equipe = new EquipeEsports(
    "Dark Hive",
    "Valorant",
    "Brasil",
    2026,
    0,
    0
);

equipe.registrarCampeonatoVencido(15000);

Console.WriteLine(equipe.verificarAnoEstreia());
Console.WriteLine(equipe.imprimir());


Console.WriteLine("\n===== EXERCICIO 3 - PRODUTO =====");
Produto produto = new Produto(
    "Mouse Gamer",
    "Periférico",
    150.00,
    20
);

produto.aplicarCupomDescontoValor(25);
produto.aplicarCupomDescontoPorcentagem(10);

Console.WriteLine(produto.verificarQuantidadeEmEstoque());
Console.WriteLine(produto.imprimir());


Console.WriteLine("\n===== EXERCICIO 4 - PROFESSOR =====");
Professor professor = new Professor(
    "Bruno Lima",
    "Estrutura de Dados",
    40,
    4500.00,
    0
);

professor.reajusteSalarialEmValor(300);
professor.reajusteSalarialEmPorcentagem(10);
professor.descontoSalarialPorFaltaEmValor(100);
professor.descontoSalarialPorFaltaEmPorcentagem(5);
professor.aumentarCargaHorariaDeTrabalho(5, 500);

Console.WriteLine(professor.imprimir());
