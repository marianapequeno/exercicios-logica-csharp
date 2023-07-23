using System.Globalization;

namespace ExercicioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] values = Console.ReadLine().Split(' ');
            double A = double.Parse(values[0], CultureInfo.InvariantCulture);
            double B = double.Parse(values[1], CultureInfo.InvariantCulture);
            double C = double.Parse(values[2], CultureInfo.InvariantCulture);

            double triangle = A * C / 2.0;
            double circle = Math.PI * C * C;
            double trapeze = (A + B) / 2.0 * C;
            double square = B * B;
            double retangle = A * B;

            Console.WriteLine($"\nTRIANGULO: {triangle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapeze.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {square.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangle.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
