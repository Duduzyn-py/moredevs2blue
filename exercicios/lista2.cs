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

//LISTAS
//1. Escreva um programa que peça ao usuário uma quantidade indeterminada de nomes.
//Ao final da execução, exiba todos os nomes informados pelo usuário (Sinta-se à vontade
//para definir o gatilho desejado para encerrar a coleta de nomes).
List<string> listaNomes = new List<string>();
string nome = string.Empty;
int contador = 0;
do
{
    Console.WriteLine("Digite um nome ou OK para sair");
    nome = Console.ReadLine();

    if (nome.ToUpper() != "OK")
    {
        listaNomes.Add(nome);
    }
} while (nome.ToUpper() != "OK");

foreach (string nomes in listaNomes)
{
    Console.WriteLine($"#{++contador} {nomes}");
}

//2. Escreva um programa que possua uma lista com 10 número de sua preferência, os quais devem estar
//entre 1 e 100. Peça para o usuário informar um número de 1 a 100 e após isso verifique se o número
//está presente na lista criada inicialmente. Dê três chances para o usuário acertar o máximo de números.

List<int> listaNumeros = new List<int>();
listaNumeros.Add(45);
listaNumeros.Add(15);
listaNumeros.Add(99);
listaNumeros.Add(56);
listaNumeros.Add(8);
listaNumeros.Add(18);
listaNumeros.Add(67);
listaNumeros.Add(53);
listaNumeros.Add(79);
listaNumeros.Add(12);

int contador = 0;
int numeroMagico = 0;
bool validar = false;
int aux = 3;
while(contador < 3)
{
    Console.WriteLine("Tente adivinhar um número(entre 0 e 100): ");
    numeroMagico = int.Parse(Console.ReadLine());

    foreach (int numero in listaNumeros) { 
        if (numero == numeroMagico)
        {
            validar = true;
            Console.WriteLine(validar);
            break; 
        }
    }
    Console.WriteLine($"Você tem mais {--aux} chances");
    contador++;

}

//INSTRUÇÃO FOR
//1. Escreva um programa que peça ao usuário um número inteiro positivo e calcule o fatorial desse número
//usando um loop for. Por exemplo: 5! = 5×4×3×2×1=120. 3! = 3×2×1=6. 0! = 1 (por definição).
Console.WriteLine("Digite um numero pra ver seu fatorial: ");
int num = int.Parse(Console.ReadLine());
int fatorial = 0;
int aux = num;
for (int i = 0; i <= num; i++)
{
    if (aux != 1)
    {
        fatorial *= aux * aux - i;
        aux--;
    }  
    else
    {
        break;
    }
}
Console.WriteLine(fatorial);
    
 //2. Escreva um rograma  que peça ao usuário um número e exiba a tabuada desse número para o usuario
Console.WriteLine("Digite um número");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"VEJA ABAIXO A TABUADA DO {num}");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} * {i} = {num * i}");
}
//INSTRUÇÃO WHILE
//1.Escreva um programa que permita ao usuário inserir números indefinidamente
//até que um número negativo seja inserido. O programa deve calcular e exibir a soma de todos
//os números positivos inseridos
int numero;
int soma = 0;

Console.WriteLine("Digite números inteiros positivos. Para parar, digite um número negativo.");

while (true)
{
    Console.Write("Digite um número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero < 0)
    {
        break;
    }

    soma += numero;
}

Console.WriteLine($"A soma de todos os números positivos inseridos é: {soma}");

////2.Escrever um programa que receba números indefinidamente e pare ao digitar zero. Após isso o programa
////irá exibir a quantidade de numeros pares inseridos pelo usuário.
int numero;
int quantidadePares = 0;

Console.WriteLine("Digite números inteiros positivos. Para parar, digite um número negativo.");

while (true)
{
    Console.Write("Digite um número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero == 0)
    {
        break;
    }

    if (numero % 2 == 0) // Verifica se o número é par
    {
        quantidadePares++;
    }
}

Console.WriteLine($"A quantidade de números pares inseridos é: {quantidadePares}");

////INSTRUÇÃO FOREACH
//// 1. Escreva um programa que declare uma lista com 5 nomes e exiba-os na tela 
//List<string> nomes = new List<string> { "Alice", "Bruno", "Carlos", "Daniela", "Eduardo" };

Console.WriteLine("Os nomes na lista são:");

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

////INSTRUÇÃO DO-WHILE

decimal saldo = 0;
int opcao;

do
{
    Console.Clear();
    Console.WriteLine("Banco +Devs2Blu, seja bem-vindo!");
    Console.WriteLine("1 - Consultar saldo");
    Console.WriteLine("2 - Realizar depósito");
    Console.WriteLine("3 - Realizar saque");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");

    // Lê a escolha do usuário e converte para um número inteiro
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1: 
            //saldo
            Console.WriteLine($"\nSeu saldo atual é: R$ {saldo}");
            break;

        case 2: 
            //depósito
            Console.Write("\nDigite o valor do depósito: R$ ");
            decimal deposito = decimal.Parse(Console.ReadLine());
            if (deposito > 0)
            {
                saldo += deposito;
                Console.WriteLine($"Depósito de R$ {deposito} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido!");
            }
            break;

        case 3: 
            // Realizar saque
            Console.Write("\nDigite o valor do saque: R$ ");
            decimal saque = decimal.Parse(Console.ReadLine());
            if (saque > 0 && saque <= saldo)
            {
                saldo -= saque;
                Console.WriteLine($"Saque de R$ {saque:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor de saque inválido!");
            }
            break;

        case 4: 
            // Sair
            Console.WriteLine("\nObrigado por utilizar nossos serviços. Até mais!");
            break;

        default: 
            // Opção inválida
            Console.WriteLine("\nOpção inválida! Por favor, escolha uma opção válida.");
            break;
    }
} while (opcao != 4);
