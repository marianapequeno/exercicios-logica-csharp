namespace Fatorial_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial =  fatorial * i;
            }
            Console.WriteLine(fatorial);
        }
    }
}
