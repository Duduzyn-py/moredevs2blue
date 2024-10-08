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

/* EXERCÌCIO EXEMPLO DE DO-WHILE
string senha = "flavinhodupneu";
string tentativa = "";
do
{
    Console.WriteLine("Digite a senha de acesso: ");
    tentativa = Console.ReadLine();

    if (tentativa == senha)
    {
        Console.WriteLine("Acesso permitido.");
    }
    else if (tentativa != senha)
    {
        Console.WriteLine("Senha incorreta por favor tente novament");
    }
}while (tentativa != senha);

*/
//FOREACH
var turma = new List<string>();
string nome = "";
do
{
    Console.WriteLine("Digite o nome do aluno ou OK para finalizar o cadastrament");
    nome = Console.ReadLine();
    
    if (!string.IsNullOrEmpty(nome))
    {
        nome = nome.ToUpper();
       
        if (nome != "OK")
        {
            turma.Add(nome);
        }
    }
} while (nome.ToUpper() != "OK");

int num = 0;
Console.Clear();
Console.WriteLine("Cadastro finalizado.");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
foreach (string alunos in turma)
{
    Console.WriteLine($"#{++num} {alunos}");
}
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
