namespace ExercicioParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entrada: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }
        }
    }
}
