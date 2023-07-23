using System.Globalization;

namespace ExercicioRadius
{
    class Program
    {
        static void Main(string[] args)
        {

            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            const double PI = 3.14159;
            double area = PI * (radius * radius);
            Console.WriteLine($"\nA = {area.ToString("F4", CultureInfo.InvariantCulture)}");






        }
    }
}