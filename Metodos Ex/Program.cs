namespace Metodos_Ex
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            saudacao("Bruno");
            Soma(25, 20);

            // Metodos Saudação !!

            static void saudacao(string nome)
            {
                Console.WriteLine($"Olá {nome}, seja bem vindo !! ");

            }

           
            static void Soma(int a, int b)
            {
                int resultado = a + b;
                Console.WriteLine($"A soma de {a} + {b} é igual a {resultado}");
            }




        }
    }
}
