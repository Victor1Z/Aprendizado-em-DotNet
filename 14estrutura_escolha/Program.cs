// // Variavel
Console.WriteLine("Digite uma linguagem de programação:");
string linguagem = Console.ReadLine();

// // Estrutura de escolha
// switch (linguagem)
// {
//     case "HTML":
//         Console.WriteLine("Linguagem de marcação");
//         break;
//     case "CSS":
//         Console.WriteLine("Linguagem de estilo");
//         break;
//     case "C#":
//         Console.WriteLine("Linguagem de programação");
//         break;
//     default:
//         Console.WriteLine("Linguagem desconhecida");
//         break;
// }

// Expressão switch
string retorno = linguagem switch
{
    "HTML" => "Linguagem de marcação",
    "CSS" => "Linguagem de estilo",
    "C#" => "Linguagem de programação",
    _ => "Linguagem desconhecida"
};
Console.WriteLine(retorno);