using System.Globalization;

namespace SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salary = (double)hours * valuePerHour;

            Console.WriteLine($"\nNUMBER = {number}");
            Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
