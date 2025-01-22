namespace EX010
{
    internal class Program
    {
        static void Main(string[] args)
        {


            float Salario, Valortotal;

            Console.WriteLine("Digite o seu Salario Atual");
            Salario = float.Parse(Console.ReadLine());


           
             if (Salario > 2.500 )
            {
                Valortotal = Salario + (Salario * 0.05F);
                Console.WriteLine("O aumento e: {0}", Valortotal);
            }
                
            
               
                
                else if (Salario > 1.250)
                 {
                    Valortotal = Salario + (Salario * 10);
                    Console.WriteLine("O aumento e: {0}", Valortotal);

                }
                else if (Salario < 1.250)
                {
                    Valortotal = Salario + (Salario * 15);
                    Console.WriteLine("O aumento e: {0}", Valortotal);
                }
            

                    

                

                


            


            
                
            
            
            
                


            

            
            

            






        }
    }
}
