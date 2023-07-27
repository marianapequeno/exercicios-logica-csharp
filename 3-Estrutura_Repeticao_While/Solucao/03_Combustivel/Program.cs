namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRADA: ");
            int codigo = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    alcool += 1;
                }
                else if (codigo == 2)
                {
                    gasolina += 1;
                }
                else if (codigo == 3)
                {
                    diesel += 1;
                }
                codigo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADA");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina {gasolina}");
            Console.WriteLine($"Diesel {diesel}");
        }
    }
}
