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
