namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRADA: ");

            string senha = Console.ReadLine();
            while (senha != "2002")
            {
                Console.WriteLine("Senha Inválida");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Acesso Permitido");


        }
    }
}
