namespace Matrix_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 3];

            
            
            
            
            matrix[0, 0] = 10;
            matrix[0, 1] = 15;
            matrix[0, 2] = 20;




            matrix[1, 0] = 25;
            matrix[1, 1] = 30;
            matrix[1, 2] = 35;

           
            
            
            matrix[2, 0] = 40;
            matrix[2, 1] = 45;
            matrix[2, 2] = 50;

            matrix[3, 0] = 55;
            matrix[3, 1] = 60;
            matrix[3, 2] = 65;

            
            //Numa matrix o "J" simboliza colunas e o "i" As linhas 
            
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                  
                    
                    Console.Write(matrix[i, j] + " "); 
                }
                Console.WriteLine();
            }
           
            // Getlength conta a quantidade linhas e colunas (0) = linhas, (1) = colunas.
            
            Console.WriteLine();
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));





        }
    }
}
