// INSTRUÇÃO IF
//1. Escreva um programa que peça para o usuário um número. O programa deve
//informar ao usuário se o número é ímpar ou par
Console.WriteLine("Por informe um número");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} é par");
}
else { 
    Console.WriteLine($"{num} é ímpar");
}
//2. Escreva um programa que peça ao usuário o nome e a idade.
//Caso o usuário seja menor de idade ou sua idade seja superior a 60 anos,
//o programa deve indicar que sua entrada será barrada por normas de segurança.

Console.WriteLine("Bem vindo, por questões de segurança, informe sua idade por favor: ");
int idade = int.Parse(Console.ReadLine());

if (idade < 18) {
    Console.WriteLine("Você é menor de idade, infelizmente não poderá entrar");
}
else if (idade > 60)
{
    Console.WriteLine("Você é hexagenário, ou superior em idade, infelizmente não poderá entrar");
}
else
{
    Console.WriteLine("Você pode estrar.");
//INSTRUÇÃO SWITCH
//1. Escreva um programa que peça ao usuário um número de 1 a 7 e após isso,
//retorne o dia da semana correspondente a esse número. Exemplo: 1 == “Domingo”. 7 == “Sábado”.

Console.WriteLine("Digite um número de dia da semana(1 a 7): ");
var diaSemana =(Console.ReadLine());

switch (diaSemana)
{
    case "1":
        Console.WriteLine("Domingo");
        break;
    case "2":
        Console.WriteLine("Segunda");
        break;
    case "3":
        Console.WriteLine("Terça");
        break;
    case "4":
        Console.WriteLine("Quarta");
        break;
    case "5":
        Console.WriteLine("Quinta");
        break;
    case "6":
        Console.WriteLine("Sexta");
        break;
    case "7":
        Console.WriteLine("Sábado");
        break;
}
