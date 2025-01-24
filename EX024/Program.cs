namespace EX024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Gênero;

            Console.WriteLine("Digite o gênero: ");
            Gênero = Console.ReadLine().ToUpper();

            while(Gênero != "F" && Gênero != "M")
            {
                Console.Write("Digite o Gênero: ");
                Gênero = Console.ReadLine();
            }

            Console.WriteLine("Bem vindos ao curso C#");







        }
    }
}
