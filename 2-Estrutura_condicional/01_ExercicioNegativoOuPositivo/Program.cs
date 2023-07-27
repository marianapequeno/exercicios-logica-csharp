namespace ExercicioNegativoOuPositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}
