//Usar o diretorio para chamar a funcao
// ConsoleApp2.Executor.Executar();

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    public class Carro
    {
        public const int PORCENTAGEM_RESERVA = 20;
        public string Modelo;
        public int Ano;
        public int TanqueAtual;
        public int TanqueLimite;

        public void Info() 
        {
            Console.WriteLine($"Carro de modelo {Modelo} e ano {Ano}");
        }

        public bool Reserva()
        {
            var porcentagemLimite = (TanqueLimite / 100) * PORCENTAGEM_RESERVA;
            Console.WriteLine("Dados do tanque: ");
            Console.WriteLine($"20% : {porcentagemLimite}");
            Console.WriteLine($"Atual: {TanqueAtual}");
            
            return TanqueAtual < porcentagemLimite;
        }
    }

    public class Animal
    {
        public string Nome;
        public string NomeCientifico;
        public int Idade;

        public void InformacaoAnimal()
        {
            Console.WriteLine($"Informações do Animal");
            Console.WriteLine($"Nome : {Nome}");
            Console.WriteLine($"NomeCientifico : {NomeCientifico}");
            Console.WriteLine($"Idade : {Idade}");
        }

        public void Comer()
        {
            Console.WriteLine($"O {Nome} está comendo");
        }
    }

    public class Livro
    {
        public string Titulo;
        public string Autor;
        public string Sinopse;

        public void InformacaoLivro()
        {
            Console.WriteLine($"\nInformações do Animal");
            Console.WriteLine($"Título : {Titulo}");
            Console.WriteLine($"Autor : {Autor}");
            Console.WriteLine($"Sinopse : {Sinopse}");
        }


    }

    public class Calculadora
    {
        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
    }

    public class Executor
    {
        public static void Executar() 
        {
            //var carro = new Carro();
            //carro.Modelo = "Clio";
            //carro.Ano = 1995;
            //carro.TanqueLimite = 100;
            //carro.TanqueAtual = 10;

            //carro.Info();
            //Console.WriteLine($"O carro {(carro.Reserva() ? "SIM" : "NÃO")} está na reserva.");

            var animal = new Animal();
            animal.Nome = "Sapo Boi";
            animal.NomeCientifico = "Bufos Regularis";
            animal.Idade = 1;


            animal.InformacaoAnimal();
            animal.Comer();

            var livro = new Livro();
            livro.Titulo = "Deuses Americanos";
            livro.Autor = "Neil Gaiman";
            livro.Sinopse = "Porradaira Fanca entre Deuse novos e antigos";

            livro.InformacaoLivro();

            var calculadora = new Calculadora();
            Console.WriteLine(calculadora.Somar(5, 5));
            Console.WriteLine(calculadora.Subtrair(10, 5));
            Console.WriteLine(calculadora.Multiplicar(5, 5));
            Console.WriteLine(calculadora.Dividir(10, 2));
            
        }
    }
}
