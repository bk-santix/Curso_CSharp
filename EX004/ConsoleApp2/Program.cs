namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumeroMultiplicador;


            Console.WriteLine("digite o numero");

            NumeroMultiplicador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} * 1 = {1}", NumeroMultiplicador, NumeroMultiplicador * 1);
            Console.WriteLine("{0} * 2 = {1}", NumeroMultiplicador, NumeroMultiplicador * 2);
            Console.WriteLine("{0} * 3 = {1}", NumeroMultiplicador, NumeroMultiplicador * 3);
            Console.WriteLine("{0} * 4 = {1}", NumeroMultiplicador, NumeroMultiplicador * 4);
            Console.WriteLine("{0} * 5 = {1}", NumeroMultiplicador, NumeroMultiplicador * 5);
            Console.WriteLine("{0} * 6 = {1}", NumeroMultiplicador, NumeroMultiplicador * 6);
            Console.WriteLine("{0} * 7 = {1}", NumeroMultiplicador, NumeroMultiplicador * 7);
            Console.WriteLine("{0} * 8 = {1}", NumeroMultiplicador, NumeroMultiplicador * 8);
            Console.WriteLine("{0} * 9 = {1}", NumeroMultiplicador, NumeroMultiplicador * 9);
            Console.WriteLine("{0} * 10 ={1}", NumeroMultiplicador, NumeroMultiplicador * 10);
        }
    }
}
