using System;
using System.Globalization;

namespace ExercicioCoordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRADA: ");
            string[] coordenadas = Console.ReadLine().Split(' ');
            double X = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}
