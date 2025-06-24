// Variaveis
double valor = 500;
string pagamento = "à vista";

// Condicional Composta
if (valor >= 100 && pagamento == "à vista")
{
    Console.WriteLine($"Desconto de 10%. Valor a pagar: {valor * 90 / 100}");
}
else
{
    Console.WriteLine($"Valor a pagar: {valor}");
}