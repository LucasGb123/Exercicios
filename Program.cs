using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;


class Program
{
    static void Main()
    {
    /*
       int num1 = 25;
       int num2 = 25;
       Console.WriteLine(num1 + num2);

        string nome = Console.ReadLine();

       Console.WriteLine($"Seu nome é {nome}");

       Console.WriteLine("Digite: ");
       Console.WriteLine("+ para adição");
       Console.WriteLine("- para subtração");
       Console.WriteLine("* para multiplicaçao");
       Console.WriteLine("/ para divisão");

       string opcao = Console.ReadLine();

        Console.WriteLine("Digite um numero: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo numero:");
        int b = int.Parse(Console.ReadLine());

       if (opcao == "+")
        {
            Console.WriteLine("Seu resultado é " + (a + b));
        }
        else if  (opcao == "-")
        {
            Console.WriteLine("Seu resultado é" + (a - b));
        }
        else if (opcao == "*")
        {
            Console.WriteLine("Seu resultado é" + (a * b));
        }
        else if (opcao == "/")
        {
            Console.WriteLine("Seu resultado é" + (a / b));
        }
        else
        {
            Console.WriteLine("Erro na operação");
        }
     */
        List<string> nomes = new List<string>();
        nomes.Add("Luccas");
        nomes.Add("Dante");

        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}

