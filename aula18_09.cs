/*
 OPERADORES
    ARITMÉTICOS: + ; - ; *; / ; %.
 */

//decimal valor1 = 25.25m;
//decimal valor2 = 20;

////decimal valor3 = valor1 / valor2;
//decimal valor4 = valor1 % valor2;

//console.writeline($"valor1 + valor2 = {valor1 + valor2}");
//console.writeline($"valor1 - valor2 = {valor1 - valor2} ");
//console.writeline($"valor1 x valor2 = {valor1 * valor2}");
//console.writeline($"valor1 / valor2 = {valor3.tostring("f2")}");
//console.writeline($"valor1 % valor2 = {valor4.tostring("f3")}");

/*
    ATRIBUIÇÃO: =; +=; -=; *=;

 */
//Atribuição
using System.Security.Cryptography.X509Certificates;

int valor = 10;
Console.WriteLine(valor);

//Atribuiçaõ com adição
valor += 12;
Console.WriteLine(valor);

//Atribuição com subtração
valor -= 2;
Console.WriteLine(valor);

//Atribuição com multiplicação
valor *= 10;
Console.WriteLine(valor);

//Atribuição com divisão
valor /= 2;
Console.WriteLine(valor);

//Atribuição com módulo
valor %= 55;
Console.WriteLine(valor);

//Icremento
valor++;
Console.WriteLine(valor);

//Decremento
valor--;
Console.WriteLine(valor);

/*

RELACIONAIS: ==; !=; >; <; >=; <=;

 */
// Igualdade ==
Console.WriteLine($"{valor} == {10} ? {valor == 10}");
Console.WriteLine($"{valor} == {8} ? {valor == 8}");

//Diferença !=
Console.WriteLine($"{valor} != {10} ? {valor != 10}");
Console.WriteLine($"{valor} != {8} ? {valor != 8}");

//Menor que
Console.WriteLine($"{valor} < {10} ? {valor < 10}");
Console.WriteLine($"{valor} < {11} ? {valor < 11}");
Console.WriteLine($"{valor} < {9} ? {valor < 9}");

//Maior que
Console.WriteLine($"{valor} > {10} ? {valor > 10}");
Console.WriteLine($"{valor} > {11} ? {valor > 11}");
Console.WriteLine($"{valor} > {9} ? {valor > 9}");

//Menor ou igual <=
Console.WriteLine($"{valor} <= {10} ? {valor <= 10}");
Console.WriteLine($"{valor} <= {11} ? {valor <= 11}");
Console.WriteLine($"{valor} <= {9} ? {valor <= 9}");

//Maior ou igual >=
Console.WriteLine($"{valor} >= {10} ? {valor >= 10}");
Console.WriteLine($"{valor} >= {11} ? {valor >= 11}");
Console.WriteLine($"{valor} >= {9} ? {valor >= 9}");

/*
 Lógicos
 */
Console.WriteLine("Tabela verdade do AND &&");
Console.WriteLine($"{true} && {true} = {true && true}");
Console.WriteLine($"{false} && {true} = {false && true}");
Console.WriteLine($"{true} && {false} = {true && false}");
Console.WriteLine($"{false} && {false} = {false && false}");

Console.WriteLine("\n Tabela verdade do OR ||");
Console.WriteLine($"{true} || {true} = {true || true}");
Console.WriteLine($"{false} || {true} = {false || true}");
Console.WriteLine($"{true} || {false} = {true || false}");
Console.WriteLine($"{false} || {false} = {false || false}");

Console.WriteLine("\n Tabela verdade do NOT !");
Console.WriteLine($"!{true} = {!true}");
Console.WriteLine($"!{false} = {!false}");

//OPERADOR TERNÁRIO

int minhaIdade = 720;
//string tipo = minhaIdade >= 18 ?  "Eu sou de maior" : "Eu sou de menor";
string tipo = minhaIdade < 18 ? "de menor" : (minhaIdade > 60 ? " bem vivido" : "de maior");

Console.WriteLine($"Eu Sou {(minhaIdade < 18 ? "Maior de Idade" : (minhaIdade > 60 ? "bem vivido" : "maior de idade"))}");
Console.WriteLine($"Eu sou {tipo}");
