using System.Net.Http.Headers;


namespace EX005

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media de notas");

            

            double NotaMedia, num1, num2;


            Console.WriteLine("Digite sua Nota");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua segunda Nota");
            num2 = Convert.ToDouble(Console.ReadLine());    

            NotaMedia = (num1 + num2) / 2;


            Console.WriteLine("A média é  {0}", NotaMedia);

            
           
        }
    }
}
