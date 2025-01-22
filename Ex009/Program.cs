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



                Console.WriteLine("Os valores não formam um triagulo");
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {

                    Console.WriteLine("Ele e um triangulo Equilátero. ");
                }


                else if ((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
                {
                    Console.WriteLine("Ele e um triagulo Isósceles.  ");

                }
                else
                {
                    Console.WriteLine("E ele é um triagulo Escaleno. ");


                    
    

                }




            }
            
            
              

               
               









             





        }
    }
}
