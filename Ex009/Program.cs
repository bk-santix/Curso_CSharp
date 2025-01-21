namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Progama para testar triagulos");
            



            int ladoA, ladoB, ladoC;

            Console.WriteLine("Digite lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            //Codicões
            
            
            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoC))
            {
                Console.WriteLine("Os valores informados formam um triagulo");

            }
            else
            {
                Console.WriteLine("Os valores não formam um triagulo");
            }
             





        }
    }
}
