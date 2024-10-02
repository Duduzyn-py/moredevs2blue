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

//INSTRUÇÃO ARRAY
//1. Escreva um programa que peça ao usuário 5 valores numéricos e armazene-os em um Array.
//Calcule a soma de todos esses números e exiba o resultado na tela
int[] numeros = new int[5];
int contador = 0;
while (contador < numeros.Length)
{
    Console.WriteLine("digite um numero");
    numeros[contador] = int.Parse(Console.ReadLine());
    contador++;
}
int contagem = 0;
foreach (int num in numeros)
{
    contagem += num;  
}
Console.Clear();
Console.WriteLine(contagem);
    
//2. Escreva um programa que peça ao usuário 10 números e armazene-os em um Array.
//O programa deve identificar o maior e o menor número informado pelo usuário.
int[] numeros = new int[10];
int contador = 0;
while (contador < numeros.Length)
{
    Console.WriteLine("digite um numero");
    numeros[contador] = int.Parse(Console.ReadLine());
    contador++;
}

int maiorNum = int.MinValue;
int menorNum = int.MaxValue;

foreach (int numero in numeros)
{
    if (numero > maiorNum)
    {
        maiorNum = numero;
    }
    else if (numero < menorNum)
    {
        menorNum = numero;
    }
}
Console.WriteLine($"O maior numero informado foi: {maiorNum}");
Console.WriteLine($"O menor número digitado for: {menorNum}");

//3. Escreva um programa que peça ao usuário 5 nomes e armazene-os em um Array.
//Após isso exiba os nomes na ordem inversa da qual foram inseridos.
string[] nomes = new string[5];
int contador = 0;
while (contador < nomes.Length)
{
    Console.WriteLine("digite um nome: ");
    nomes[contador] = Console.ReadLine();
    contador++;
}
foreach (string nome in nomes.Reverse())
{
    Console.WriteLine(nome);
}
