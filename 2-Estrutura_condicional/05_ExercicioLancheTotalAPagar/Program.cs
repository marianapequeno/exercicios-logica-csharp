
using System;
using System.Globalization;

namespace ExercicioLancheTotalAPagar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ENTRADA: ");
            string[] item = Console.ReadLine().Split(' ');
            int codigo = int.Parse(item[0]);
            int quantidade = int.Parse(item[1]);

            double totalAPagar = 0.0;
            switch (codigo)
            {
                case 1:
                    totalAPagar = 4.0 * quantidade;
                    break;

                case 2: 
                    totalAPagar = 4.5 * quantidade;
                    break;

                case 3:
                    totalAPagar = 5.0 * quantidade;
                    break;

                case 4:
                    totalAPagar = 2.0 * quantidade;
                    break;

                case 5:
                    totalAPagar = 1.5 * quantidade;
                    break;

                default: 
                    Console.WriteLine("Código inválido!");
                    break;
            }
            Console.WriteLine($"Total: R$ {totalAPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
