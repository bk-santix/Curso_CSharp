using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int num1, num2, num3;
            float num4, num5;

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = num1 + num2;
            Console.WriteLine("A soma de {0} + {1} = {2}", num1, num2, num3);

            num3 = num1 - num2;

      


            Console.WriteLine("A subtração de {0} - {1} = {2}", num1, num2, num3);

            num3 = num1 % num2;

            Console.WriteLine("a divisão de {0} / {1} = {2}", num1, num2, num3);

            num3 = num1 * num2;

            Console.WriteLine("a mutiplicação de {0} * {1} = {2}", num1, num2, num3);
            num3 = num1 % num2;

            Console.WriteLine("O resto da divisãode {0} % {1} = {2}", num1, num2, num3);

            num4 = 35f;

            num5 = num1 / num4;

            Console.WriteLine("A divisão {0} / {1} = {2}", num1, num4, num5);

            Console.ReadLine();


                
           
        }
    }
}
