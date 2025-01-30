namespace Vetores_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] num = new int[6];
           
            
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;
            num[5] = 60;


            Console.WriteLine(num[5]);

            int[] n = new int[5] { 60, 70, 80, 90, 100 };

            Console.WriteLine(n[0]);

            

                     Random radon = new Random();

            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = radon.Next(1, 100);
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine();

            double[] Reais = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Reais[i] = radon.NextDouble() * 10000;
                Console.WriteLine(Reais[i].ToString("P2")  ); 

            }

            */


            string[] Nomes = { "Maria", "João", "Carlos", "Pedro", "Ana", "Carlos", "Neymar", "Miguelito" };

            for (int i = 0; i < Nomes.Length; i++)
            {
                if (i < Nomes.Length - 1)
                {
                    Console.Write(Nomes[i] + ", ");
                }
                else
                {
                    Console.Write(Nomes[i] + ". " );
                }
               
            }


        }
    }
}
