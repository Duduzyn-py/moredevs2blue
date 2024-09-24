//Iniciando a parte de laços de repetições
var idade = 18;
if (idade < 18)
{
    Console.WriteLine("DE MENOR, CERTO");
}

else if (idade < 60) {
    Console.WriteLine("BEM VIVIDO, CERTO");
}
else
{
    Console.WriteLine("DE MENOR, CERTO");
}

// Verficar se o nome do convidado esta na lista com IF
Console.WriteLine("Qual o seu nome?");
var nome = Console.ReadLine();
if (nome == "Ana" || nome == "João" || nome == "Maria" || nome == "José" || nome == "Carlos")
{
    Console.WriteLine($"Desculpe {nome}, mas seu nome não esta na lista.");
}
else {
    Console.WriteLine($"Desculpe {nome}, seu nome não esta na lista");
};

//Usando o Switch
switch (nome) 
{
    case "Maria":
    case "João":
    case "José":
    case "Carlos":
    case "Ana":
        Console.WriteLine($"Pode entrar {nome}, seu nome  esta na lista.");
        break;
    default:
        Console.WriteLine($"Desculpe {nome}, seu nome não esta na lista");
        break;
}

//MOSTRANDO A FILA QUE SE SENTARA BASEADO NA SUA INICAL

Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();
char inicial = nome[0];

switch (inicial)
{
    case 'K':
    case 'L':
    case 'M':
    case 'N':
    case 'O':
    case 'P':
    case 'Q':
    case 'R':
    case 'S':
        Console.WriteLine("FILA 1");
        break;

    case 'A':
    case 'B':
    case 'C':
    case 'D':
    case 'E':
    case 'F':
    case 'G':
    case 'H':
    case 'I':
    case 'J':
        Console.WriteLine("FILA 2");
        break;

    case 'T':
    case 'U':
    case 'V':
    case 'W':
    case 'X':
    case 'Y':
    case 'Z':
        Console.WriteLine("FILA 3");
        break;
//CÓDIGO HORRIVEL MAIS É DAQUELE JEITO
