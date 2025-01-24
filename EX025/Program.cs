namespace EX025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, N3, opção = 0;

            Console.Write("Digite o primeiro numero: ");
            N1 = Convert.ToInt32(Console.ReadLine());
            
            
            Console.Write("Digite o segundo numero: ");
            N2 = Convert.ToInt32(Console.ReadLine());

            //Contador e repetidor.
            while(opção != 5)
            {
                Console.WriteLine("Escolha a opção: ");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair ");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Novos numero");
                Console.WriteLine("5 - Sair");
                opção = Convert.ToInt32(Console.ReadLine());
           
                switch (opção)
                {
                    case 1:
                        N3 = N1 + N2;
                        Console.WriteLine("A soma de {0} + {1} e igual a {2}.", N1, N2, N3);
                        break;

                    case 2:
                        N3 = N1 - N2;
                        Console.WriteLine("A Subtração de {0} - {1} e igual a {2}.", N1, N2, N3);
                        break;
                       
                    case 3:
                        N3 = N1 * N2;
                        Console.WriteLine("A Multiplicação de {0} * {1} e igual a {2}.", N1, N2, N3);
                        break;

                    case 4:
                        Console.Write("Digite o primeiro numero: ");
                        N1 = Convert.ToInt32(Console.ReadLine());


                        Console.Write("Digite o segundo numero: ");
                        N2 = Convert.ToInt32(Console.ReadLine());
                        break;



                    case 5:
                        Console.WriteLine("Saindo.......");
                        break;



                    default:
                        Console.WriteLine("Opção inválida!");
                        break;


                }

            }

           
        }

    }
}
