namespace NumerosIntervalorInOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números deseja digitar? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int x;
            int xIn = 0;
            int xOut = 0;
            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    xIn += 1;
                }
                else
                {
                    xOut += 1;
                }
            }
            Console.WriteLine($"{xIn} in");
            Console.WriteLine($"{xOut} out");

        }
    }
}
