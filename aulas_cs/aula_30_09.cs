/*
EXERCICIO EXEMPLO DE WHILE(PANGUEI MAS DEPOIS DEU BOA)
Console.WriteLine("Digite um numero ou OK para sair");
string entrada = Console.ReadLine();

int maiorNumero = int.MinValue;
int menorNumero = int.MaxValue;

while (entrada.ToUpper() != "OK")
{
    var numero = int.Parse(entrada);
    if (menorNumero > numero)
    {
        menorNumero = numero;
    }
    if (maiorNumero < numero)
    {
        maiorNumero = numero;
    }

    Console.WriteLine("Digite um numero ou OK para sair");
    entrada = Console.ReadLine();
}

Console.WriteLine("Fime de execução");
Console.WriteLine($"Maior número: {maiorNumero}");
Console.WriteLine($"Menor número: {menorNumero}");
*/
//DO-WHILE
string entrada = "OK";
int maiorNumero = int.MinValue;
int menorNumero = int.MaxValue;

do
{
    Console.WriteLine("Digite um numero ou OK para sair");
    entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int numero))
    { 
        if (menorNumero > numero)
        {
            menorNumero = numero;
        }

        if (maiorNumero < numero)
        {
            maiorNumero = numero;
        }
    }
    else if (entrada.ToUpper() != "OK")
    {
        Console.Write("ISSO AI NÃO É UM NUMERO!");
    }
} while (entrada.ToUpper() != "OK");
