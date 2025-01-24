namespace EX023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Digite um Numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                resultado = numero * i;
                Console.WriteLine("{0} X {1} = {2}" , numero, i, resultado);
            }






        }
    }
}
