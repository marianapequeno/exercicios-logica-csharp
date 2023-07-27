namespace ExercicioDuracaoJogo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ENTRADA: ");
            string[] horas = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(horas[0]);
            int horaFinal = int.Parse(horas[1]);

            int duracaoJogo;
            if (horaInicial < horaFinal)
            {
                duracaoJogo = horaFinal - horaInicial;//16-2==14
            }
            else
            {
                duracaoJogo = (24 - horaInicial) + horaFinal;//8+2==10
            }
            Console.WriteLine($"O JOGO DUROU {duracaoJogo} HORA(S)");

        }
    }
}
