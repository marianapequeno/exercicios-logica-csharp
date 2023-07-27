namespace Coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRADA: ");

            string[] coordenadas = Console.ReadLine().Split(' ');
            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[0]);
            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro quadrante");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto quadrante");
                }
                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }
        }
    }
}
