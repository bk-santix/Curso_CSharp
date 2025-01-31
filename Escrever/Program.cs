namespace Escrever
{
    internal class Program
    {
       
        static void Escrever(string Texto)

        {
            // Padleft pode centralizar o texto subtraindo o numero digitado no metodo
            // * Mutiplica o numero + depois do lenghth
            int tam = Texto.Length + 4;
            string linha = new('*', tam);
            string TextoCentralizado = Texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine(TextoCentralizado);
            Console.WriteLine(linha);

        }
        
        
        static void Main(string[] args)
        {
            Escrever("Bruno luis Ferreira Dos Santos");
            Console.WriteLine();
            Escrever("Curso C#");
            Console.WriteLine();


        }
    }
}
