namespace Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            Contador(1, 10, 1);
            Contador(10, 0, 2);
          
           
            
            
            Escrever("Agora e sua vez de personalizar a contagem");
            
            Console.WriteLine("Digite o inicio");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Fim");
            int final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o passo");
            int pas = Convert.ToInt32(Console.ReadLine());
            Contador(ini, final, pas);

        }

        

        static void Contador(int inicio, int fim, int passo)

        {
            if (passo < 0)
            {
                passo *= -1;
            }
                

       
         


            

           






            if (inicio < fim)
            {
                int cont = inicio;
                while (cont <= fim)
                {
                    Console.WriteLine($"{cont} ");
                    cont += passo;
                }
            }
            else
            {
                int cont = passo;
                while (cont >= fim )
                {
                    Console.Write($"{cont} ");
                    Thread.Sleep(500);
                    cont -=  passo;
                }
                
                   
                
                Console.WriteLine("Fim!");

            }

            

            
               
            
        }

        static void Escrever(string Texto)

        {
            // Padleft pode centralizar o texto subtraindo o numero digitado no metodo
            // * Mutiplica o numero + depois do lenghth
            int tam = Texto.Length + 4;
            string linha = new('*', tam);
            string TextoCentralizado = Texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine(TextoCentralizado);
            Console.WriteLine(linha);





        }
    }
}      
