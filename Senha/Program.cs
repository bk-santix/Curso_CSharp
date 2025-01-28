namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Senha = "123"; // Senha correta 
            string SenhaDigitada; // Senha Digitada pelo usuario 
            int Tentativas = 0; // Contador de tentativas 



            // Loop Para solicitar a senha do usuario !!
            do
            {
                Console.Clear();
                Console.Write("Digite a Sua senha:");
                SenhaDigitada = Console.ReadLine();
                Tentativas++;

                if (SenhaDigitada != Senha && Tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta!");
                    Console.WriteLine("Você ainda tem " + (3 - Tentativas) + " Tentativa(s) ");
                    Console.ReadKey();
                }
                else if (SenhaDigitada != Senha && Tentativas == 3)
                {
                    Console.WriteLine("Senha incorreta - Seu acesso foi bloaqueado");
                    return;
                }
                
                   
                



            } while (SenhaDigitada != Senha);
           
            
            Console.Clear() ;
            Console.WriteLine("Senha Correta");
            Console.WriteLine("Tentativas:" + Tentativas);



        }
    }
}
