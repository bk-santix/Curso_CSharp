using System;
using System.ComponentModel.Design;


namespace Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            double Nota_final = 70;
            string resultado = "Reprovado";

            //Condicões 

            if (Nota_final >= 60)
            {
                resultado = "Aprovado";

            }
            else
            {
                resultado = "Reprovado";
            }
            Console.WriteLine("O aluno foi {0}", resultado);
            
            


            
            


            
        }
    }
}
