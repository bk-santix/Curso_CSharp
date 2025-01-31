namespace Area_do_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Área do Triângulo");



            Console.WriteLine("Digite o lado A");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o lado B");
            double ladoB = Convert.ToDouble(Console.ReadLine());
            AreadoTriagulo(ladoA, ladoB);




        }

        static void AreadoTriagulo(double a, double b)
        {
            double areadoTriagulo = a * b / 2 ;

            Console.WriteLine($"O resultado é: {a} x {b} = {areadoTriagulo}");
        }
    }
}
