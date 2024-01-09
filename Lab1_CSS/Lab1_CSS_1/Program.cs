using System;

namespace Lab1_CSS_1
{
    internal class Program
    {
        static void Main()
        {
            uint size;
            while (true)
            {
                Console.Write("Enter size of matrix: ");
                try
                {
                    size = Convert.ToUInt32(Console.ReadLine());
                    if (size == 0) continue;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            int[,] matr = new int[size, size];
            Console.WriteLine("Source matrix:\n");
            RandomMatrix(matr, -50, 50);
            PrintMatrix(matr);
            Console.WriteLine("\nSorted matrix:\n");
            SortMatrix(matr);
            PrintMatrix(matr);

            // Методи
            void RandomMatrix(int[,] matrix, int begin, int end)
            {
                Random r = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        matrix[i, j] = r.Next(begin, end);
            }
            void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        Console.Write("{0,4}", matrix[i, j]);
            }
            void SortMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1) / 2; j++)
                    {
                        int temp = matrix[i, j];
                        matr[i, j] = matrix[i, matrix.GetLength(1) - 1 - j];
                        matrix[i, matrix.GetLength(1) - 1 - j] = temp;
                    }
            }
        }
    }

}
