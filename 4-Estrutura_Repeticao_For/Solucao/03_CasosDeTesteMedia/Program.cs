using System;
using System.Globalization;

namespace CasosDeTesteMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double v1, v2, v3, media;

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
                media = (v1 * 2.0 + v2 * 3.0 + v3 * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
