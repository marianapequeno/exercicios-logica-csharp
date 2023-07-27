namespace QuadradoECubo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }
}
