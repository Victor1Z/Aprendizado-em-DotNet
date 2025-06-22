//Variavel
Console.WriteLine("Digite a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());

//Estrutura Condicional Encadeada
if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (nota >= 5)
{
    Console.WriteLine("Exame");
}
else
{
    Console.WriteLine("Reprovado");
}