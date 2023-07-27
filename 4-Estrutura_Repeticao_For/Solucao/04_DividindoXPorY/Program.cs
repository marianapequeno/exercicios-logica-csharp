using System;
using System.Globalization;

namespace DividindoXPorY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string[] nums;
            int x, y;
            double divisao;
            for (int i = 0; i < n; i++)
            {
                nums = Console.ReadLine().Split(' ');
                x = int.Parse(nums[0]);
                y = int.Parse(nums[1]);
                divisao = (double) x / y;
                if (y == 0)
                {
                    Console.WriteLine("Divisão impossível.");
                }
                else
                {
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
