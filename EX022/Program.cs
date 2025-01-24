namespace EX022
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Digite um numero: ");


            int Soma, quant;

            Soma = quant = 0;


            for (int i = 0; i <= 500; i ++)
            {
               
                
                if (i  % 3 == 0 )
                {
                    Soma += i;
                    quant++;
                                      
                }

                
               
                  
            }
            Console.Write("A soma dos {0} valores informados é {1}.", quant, Soma);
              
                
                 


            
            
        }
        
          
    }
}
