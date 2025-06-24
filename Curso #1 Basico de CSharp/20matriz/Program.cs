// Matriz
string[,] dados = {
    {"Victor", "Dois Irmãos"},
    { "Maria", "Manaus"},
    { "João", "São Paulo"},
    { "Ana", "Rio de Janeiro"},
    { "Pedro", "Belo Horizonte"},
    { "Lucas", "Curitiba"}
};

// Exibindo os dados da matriz
Console.WriteLine($"Dados:{dados[0, 1]}");

foreach (string dado in dados)
{
        Console.WriteLine(dado);
}