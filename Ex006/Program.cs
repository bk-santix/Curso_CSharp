namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final, n1, n2, n3, n4;
            string resultado;

            Console.WriteLine("Digite a primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (n1 + n2 + n3 + n4) / 4;

            if (nota_final >= 60)
            {
                if (nota_final >= 90)
                {
                    resultado = "Aprovado com louvor";
                }
                else
                {
                    resultado = "Aprovado";
                }
            }
            else
            {
                if(nota_final >= 40)
                {
                    resultado = "Recuperação";
                }
                else
                {
                    resultado = "Reprovado";
                }
            }

            Console.WriteLine("Nota do aluno: {0} - Resultado: {1}", nota_final, resultado);
        }
    }
}
