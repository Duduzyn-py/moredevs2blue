//OPERAADORES ARITIMÉTICOS

//Exercicio 1:
//1. Escreva um programa que leia dois números inteiros e exiba a soma deles.

Console.WriteLine("Escreva um numero inteiro(sem casas decimais):");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva outro numero inteiro:");
int numero2 = int.Parse(Console.ReadLine());
int soma = numero1 + numero2;
Console.WriteLine($"A soma dos números é: {soma}");

//Exercicio 2:
//2. Escreva um programa que leia dois números inteiros e mostre a diferença entre o primeiro e o segundo número

Console.WriteLine("Escreva um numero inteiro(sem casas decimais):");
int sub1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva outro numero inteiro:");
int sub2 = int.Parse(Console.ReadLine());
int diferenca = sub1 + sub2;
Console.WriteLine($"A diferença dos números é: {diferenca}");

//Exercicio 3:
//3. Escreva um programa que leia dois números inteiros e exiba o produto deles.

Console.WriteLine("Escreva um numero inteiro: ");
int multiplicante = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva um numero inteiro: ");
int multiplicador = int.Parse(Console.ReadLine());
int produto = multiplicador * multiplicante;
Console.WriteLine($"O produto dos números é: {}");

//Exercicio 4:
//4. Escreva um programa que leia dois números inteiros e mostre o resultado da divisão do primeiro pelo segundo.
//(Considere a divisão inteira, sem ponto flutuante.).

Console.WriteLine("Escreva um numero inteiro: ");
int dividendo = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva um numero inteiro: ");
int divisor = int.Parse(Console.ReadLine());
int quociente = dividendo / divisor;
Console.WriteLine($"O quociente dos números é: {}");

//Exercicio 5:
//5. Escreva um programa que leia dois números inteiros e exiba o resto da divisão do primeiro pelo segundo.
Console.WriteLine("escreva um numero inteiro: ");
int dividendo2 = int.Parse(Console.ReadLine());
Console.WriteLine("EScreva um numero inteiro: ");
int divisor2 = int.Parse(Console.ReadLine());
int quociente2 = dividendo2 % divisor2;
Console.WriteLine($"O módulo dos produtos é: {quociente2}");

//OPERADORES DE ATRIBUIÇÃO

//Exercicio 1:
//1. Escreva um programa que declare uma variável inteira, atribua a ela um valor digitado pelo usuário e exiba esse valor.
int num1;
Console.WriteLine("Digite um nunmero: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine(num1);

//Exercicio 2:
//2. Escreva um programa que declare uma variável inteira, atribua um valor a ela,
//depois adicione um valor digitado pelo usuário a essa variável e exiba o resultado.

int num2 = 10;
Console.WriteLine("digite um numero inteiro:");
num2 += int.Parse(Console.ReadLine());
Console.WriteLine(num2);

//Exercicio 3:
//3. Escreva um programa que declare uma variável inteira, atribua um valor inicial,
//depois subtraia um valor digitado pelo usuário dessa variável e mostre o resultado.

int num3 = 100;
Console.WriteLine("Digite um numero inteiro: ");
num3 -= int.Parse(Console.ReadLine());
Console.WriteLine(num3);

//Exercicio 4:
//4. Escreva um programa que declare uma variável inteira, atribua um valor a ela,
//multiplique essa variável por um número digitado pelo usuário e exiba o resultado.

int num4 = 5;
Console.WriteLine("Digite um número: ");
num4 *= int.Parse(Console.ReadLine());
Console.WriteLine(num4);

//Exercício 5:
//5. Escreva um programa que declare uma variável inteira, atribua um valor inicial,
//divida essa variável por um número digitado pelo usuário e mostre o resultado da divisão.

int num5 = 2;
Console.WriteLine("Digite um numero: ");
num5 /= int.Parse(Console.ReadLine());
Console.WriteLine(num5);

//OPERADORES RELACIONAIS

//EXERCICIO 1:
//1. Escreva um programa que leia dois números inteiros e exiba se eles são iguais ou não.
Console.WriteLine("DIGITE UM NUMERO: ");
int num6 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro numero:");
int num7 = int.Parse(Console.ReadLine());
Console.WriteLine($"{num6} == {num7} é {num6 == num7}");

//Exercício 2:
//2. Escreva um programa que leia dois números inteiros e exiba se eles são diferentes.
Console.WriteLine("Digite um numero: ");
int num8 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro numero:");
int num9 = int.Parse(Console.ReadLine());
Console.WriteLine($"{num8} != {num9} é {num8 != num9}");

//EXercício 3:
//3. Escreva um programa que leia dois números inteiros e mostre se o primeiro número é maior que o segundo.
Console.WriteLine("Digite um número: ");
int num10 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número: ");
int num11 = int.Parse(Console.ReadLine());
Console.WriteLine($"{num10} > {num11} é {num10 > num11}");

//Exercicio 4:
//4. Escreva um programa que leia dois números inteiros e exiba se o primeiro número é menor que o segundo.
Console.WriteLine("Digite um número: ");
int num12 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número: ");
int num13 = int.Parse(Console.ReadLine());
Console.WriteLine($"{num12} < {num13} é {num12 < num13}");

//Exercicio 5:
//5. Escreva um programa que leia dois números inteiros e mostre se o primeiro número é maior ou igual ao segundo.
Console.WriteLine("Digite um número: ");
int num14 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número: ");
int num15 = int.Parse(Console.ReadLine());
Console.WriteLine($"{num14} >= {num15} é {num14 >= num15}");

//OPERADORES LÓGICOS
//Exercício 1:
//1. Escreva um programa que leia dois números inteiros e verifique se ambos
//são maiores que zero usando o operador lógico &&.

Console.WriteLine("Digite um numero");
int num16 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número:");
int num17 = int.Parse(Console.ReadLine());
var verificar1 = num16 > 0;
var verificar2 = num17 > 0;
Console.WriteLine($"{verificar1} && {verificar2} é {verificar1 && verificar2}");

//Exercicios 2:
//2. Escreva um programa que leia dois números inteiros e verifique se pelo menos
//um deles é menor que zero usando o operador lógico ||.

Console.WriteLine("Digite um numero");
int num18 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número:");
int num19 = int.Parse(Console.ReadLine());
var verificar3 = num18 > 0;
var verificar4 = num19 > 0;
Console.WriteLine($"{verificar3} && {verificar4} é {verificar3 || verificar4}");

OPERADORES TERNÁRIOS

//Exercicios 1:
//1. Escreva um programa que leia a idade de uma pessoa e
//use o operador ternário para verificar se ela é maior de idade ou não.
Console.WriteLine("DIgite sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine($"{(idade >= 18 ? "Você é maior de idade" : "Você é menor de idade")}");

//Exercicio 2:
//2. Escreva um programa que leia um número inteiro e use o operador ternário para verificar se o número é par ou ímpar.
Console.WriteLine("DIgite um número: ");
int num20 = int.Parse(Console.ReadLine());
Console.WriteLine($"{(num20 % 2 == 0 ? "O número é par" : "O número é impar")}");

//Exercício 3:
//3.Escreva um programa que leia um número inteiro e use o operador ternário para exibir "Positivo" se o número
//for maior que zero, "Negativo" se o número for menor que zero, e "Zero" se for exatamente zero.
Console.WriteLine("DIgite um número: ");
int num21 = int.Parse(Console.ReadLine());
Console.WriteLine($"{(num21 == 0 ? "ZERO" : (num21 > 0 ? "POSITIVO" : "NEGATIVO"))}");
