namespace Calculo_de_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Peso, altura;

            Console.WriteLine("Digite seu Peso");
            Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite Sua Altura");
            altura = Convert.ToDouble(Console.ReadLine());

            double IMC = Peso / (altura * altura);

            Console.WriteLine($"Seu IMC é: {IMC:F2}");

            if (IMC < 18.5)

                Console.WriteLine("Classificação: Abaixo do peso");

            else if (IMC <= 18.5)

                Console.WriteLine("Classificação: Peso normal");
            else if (IMC < 24.9)
                Console.WriteLine("Classificação: Sobrepeso");
            else if (IMC < 29.9) 
                Console.WriteLine("Classificação: Obesidade Grau I");
            else if (IMC < 34.9)
                Console.WriteLine("Classificação: Obesidade Grau II");
            else if(IMC < 34.9)
                Console.WriteLine("Classificação: Obesidade Grau III (mórbida)");
        }
    }






}
    

