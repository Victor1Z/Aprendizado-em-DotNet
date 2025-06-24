// Vetor de nomes
string[] nomes = {
    "Victor",
    "Gabriel",
    "Carlos",
    "Sabrine",
    "Eduardo"
};

// Exibindo os nomes do vetor
Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);
Console.WriteLine(nomes[3]);
Console.WriteLine(nomes[4]);

// Laço de repetição para exibindo os nomes do vetor
for (int indice = 0; indice < nomes.Length; indice++)
{
    Console.WriteLine($"Nome: {nomes[indice]}");
}