namespace ExercicioMultiplosOuNao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRADA: ");
            string[] nums = Console.ReadLine().Split(' ');
            int A = int.Parse(nums[0]);
            int B = int.Parse(nums[1]);

            if (A % B ==0 || B % A == 0)
            {
                Console.WriteLine("SÃO MÚLTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MÚLTIPLOS");
            }
        }
    }
}
