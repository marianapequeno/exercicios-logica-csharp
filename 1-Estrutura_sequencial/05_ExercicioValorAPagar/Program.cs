using System.Globalization;

namespace ExercicioValorAPagar
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] infosItem1 = Console.ReadLine().Split(' ');
            int codeItem1 = int.Parse(infosItem1[0]);
            int totalItem1 = int.Parse(infosItem1[1]);
            double priceItem1 = double.Parse(infosItem1[2], CultureInfo.InvariantCulture);
            double totalPriceItem1 = (double)totalItem1 * priceItem1;

            string[] infosItem2 = Console.ReadLine().Split(' ');
            int codeItem2 = int.Parse(infosItem2[0]);
            int totalItem2 = int.Parse(infosItem2[1]);
            double priceItem2 = double.Parse(infosItem2[2], CultureInfo.InvariantCulture);
            double totalPriceItem2 = (double)totalItem2 * priceItem2;

            double total = totalPriceItem1 + totalPriceItem2;

            Console.WriteLine($"\nVALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
