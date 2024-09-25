//bool ganhei = false;
//ganhei = true;

//char letra = 'F';
//letra = 'LL'; ERROS  
//letra = "M"; ERROS

//string nome = "Eduardo";
//Console.WriteLine(nome[3]);

//Para pular linha usar o \n
//Console.WriteLine("Olá, meu nome é Marco.\nEsse programinha eu desenvolvi com meus alunos em sala");
//Console.WriteLine("");
//Console.WriteLine("Esse programinha eu desenvolvi com meus alunos em sala");
//========================================================================================
//var stringbuilder = new System.Text.StringBuilder();
//stringbuilder.AppendLine("olá, meu nome é Marco.");
//stringbuilder.AppendLine("Esse programinha eu desenvolvi com meus alunos em sala");

//Console.WriteLine(stringbuilder.ToString());
//============================================================================================================

//Console.WriteLine("Qual o seu nome?");
//string meuNome = Console.ReadLine();
//Console.WriteLine($"Ola {meuNome}, muito prazer");

//Console.WriteLine("Qual a sua idade?");
//int minhaIdade = int.Parse(Console.ReadLine());

//Console.WriteLine($"Que legal. ANo que vem vc terá {minhaIdade + 1} anos");
//===========================================================================
//var data = new DateTime();

//data = DateTime.MinValue;
//data = DateTime.MaxValue;
//data = DateTime.Today;
//data = DateTime.Now;

//data = new DateTime(2024, 9, 16);

//Console.WriteLine(data.ToString());
//================================================================================

//string informacao = null;
//Console.WriteLine("Voce gostaria de dizer algo? (Digite não caso o contrario)");
//var entrada = Console.ReadLine();

//if (entrada.ToUpper() == "NÂO")
//{
//    Console.WriteLine("Encerramos por aki");
//}
//else
//{
//    informacao = entrada;
//}

//Console.WriteLine($"ENtrada: {entrada}");
//if (informacao!=null)
//{ 
//Console.WriteLine($"Inoformação: {informacao.ToUpper()}");
//}
//======================================================================

//using System.Net.NetworkInformation;

const int num = 01;
const string cpf = 11111111111;

string meuNome = "Eduardo Caitano";
int minhaIdade = 20;
char umaLtra = 'A';
bool estouVivo = true;
double media = 9.9;

var nascimento = new DateTime();

Console.WriteLine("Em que dia voce nasceu?");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Em que mes voce nasceu?");
int mes = int.Parse(Console.ReadLine());
Console.WriteLine("Em que ano voce nasceu?");
int ano = int.Parse(Console.ReadLine());
nascimento = new DateTime(ano,mes,dia);
Console.WriteLine($"Voce nasce em: {nascimento.ToString("dd/MM/yyyy")}");

//TO String -> DATE TIME -> pode ser passado parametros
//toString é capaz de modular por templates os resultados
// dd/MM/yyyy HH:mm:ss
