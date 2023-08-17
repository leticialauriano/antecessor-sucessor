using System;

namespace AntSuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Programa Antecessor e Sucessor--\n");

            Console.Write("\nInforme Seu Número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nO Antecessor do seu número é: {numero - 1}\nO Sucessor do seu número é: {numero + 1} ");

            Console.WriteLine("\n---Pressione ENTER para encerrar---");
            Console.ReadLine();
        }
    }
}
