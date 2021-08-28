using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string Texto;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite o seu texto: ");
            Console.ResetColor();
            Texto = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Texto com dilalia: ");
            Console.ResetColor();
            Console.WriteLine(Texto
                            .Replace("r","l")
                            .Replace("R","L"));
            Console.WriteLine();

        }
    }
}
