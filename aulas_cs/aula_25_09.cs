string[] nomes = new string[5];
double[] notas = new double[5];

Console.WriteLine("Digite o nome do primeiro alunos: ");
nomes[0] = Console.ReadLine();

Console.WriteLine("Digite a nota do aluno:");
notas[0] = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome do segundo alunos: ");
nomes[1] = Console.ReadLine();

Console.WriteLine("Digite a nota do aluno:");
notas[1] = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome do terceiro alunos: ");
nomes[2] = Console.ReadLine();

Console.WriteLine("Digite a nota do aluno:");
notas[2] = double.Parse(Console.ReadLine());


Console.WriteLine("Digite o nome do quarto alunos: ");
nomes[3] = Console.ReadLine();

Console.WriteLine("Digite a nota do aluno:");
notas[3] = double.Parse(Console.ReadLine());


Console.WriteLine("Digite o nome do quinto alunos: ");
nomes[4] = Console.ReadLine();

Console.WriteLine("Digite a nota do aluno:");
notas[4] = double.Parse(Console.ReadLine());

Console.WriteLine("NOTAS DOS ALUNOS");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine($"{nomes[0]}: {notas[0]} ");
Console.WriteLine($"{nomes[1]}: {notas[1]} ");
Console.WriteLine($"{nomes[2]}: {notas[2]} ");
Console.WriteLine($"{nomes[3]}: {notas[3]} ");
Console.WriteLine($"{nomes[4]}: {notas[4]} ");

//LISTAS

List<string> nomes = new List<string>();
List<float> notas = new List<float>();

Console.WriteLine("Digite o nome do aluno:");
nomes.Add(Console.ReadLine());
Console.WriteLine("Digite a nota:");
notas.Add(float.Parse(Console.ReadLine()));

Console.WriteLine("Digite o nome do aluno:");
nomes.Add(Console.ReadLine());
Console.WriteLine("Digite a nota:");
notas.Add(float.Parse(Console.ReadLine()));

Console.WriteLine("Digite o nome do aluno:");
nomes.Add(Console.ReadLine());
Console.WriteLine("Digite a nota:");
notas.Add(float.Parse(Console.ReadLine()));

Console.WriteLine("Digite o nome do aluno:");
nomes.Add(Console.ReadLine());
Console.WriteLine("Digite a nota:");
notas.Add(float.Parse(Console.ReadLine()));

Console.WriteLine("Digite o nome do aluno:");
nomes.Add(Console.ReadLine());
Console.WriteLine("Digite a nota:");
notas.Add(float.Parse(Console.ReadLine()));

Console.WriteLine("\nNOTAS DOS ALUNOS ABAIXO:");
Console.WriteLine($"{nomes[0]}: {notas[0]}");
Console.WriteLine($"{nomes[1]}: {notas[1]}");
Console.WriteLine($"{nomes[2]}: {notas[2]}");
Console.WriteLine($"{nomes[3]}: {notas[3]}");
Console.WriteLine($"{nomes[4]}: {notas[4]}");

/*
Console.WriteLine("\nNOTAS DOS ALUNOS ABAIXO:");
for (int i = 0; i < nomes.Count; i++)
{
    Console.WriteLine($"{nomes[i]}: {notas[i]}");
}
*/

