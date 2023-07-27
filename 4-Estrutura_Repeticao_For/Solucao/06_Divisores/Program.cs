namespace Divisores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
