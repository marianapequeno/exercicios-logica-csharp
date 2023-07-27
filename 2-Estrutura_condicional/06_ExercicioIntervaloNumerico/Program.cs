using System;
using System.Globalization;

namespace ExercicioIntervaloNumerico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRADA: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num >= 0 && num <= 25)
            {
                Console.WriteLine($"INTERVALO [0,25]");
            }
            else if (num >25 && num <= 50)
            {
                Console.WriteLine($"INTERVALO [25,50]");
            }
            else if (num > 50 && num <= 75)
            {
                Console.WriteLine($"INTERVALO [50,75]");
            }
            else if (num > 75 && num <= 100)
            {
                Console.WriteLine($"INTERVALO [75,100]");
            }
            else
            {
                Console.WriteLine($"FORA DO INTERVALO");
            }
        }
    }
}
