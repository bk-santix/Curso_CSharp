namespace Cauculo_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("====================");
            Console.WriteLine("Controle de Terrenos");
            Console.WriteLine("=====================");
            Console.WriteLine();

            Console.Write("Digite a largura do terreno (m): ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Comprimento do terreno (m): ");
            double Comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            AreaTerreno(largura, Comprimento);
        }

        static void AreaTerreno(double l, double c)
        {
            double  a = l * c;
            Console.WriteLine($"A área do terrreno de {l}m² x {c}m² é de {a:F2}m².");
        }
    }
}
