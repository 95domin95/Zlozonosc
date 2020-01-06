using System;
using System.Collections.Generic;
using System.Text;

namespace ZlozonoscAlgorithm.Helpers
{
    public static class MatrixFiller
    {
        public static void FillWithRandomNumbers(ref int[,] matrix)
        {
            if(matrix is null)
            {
                return;
            }

            int columns = matrix.GetLength(0);
            int rows = matrix.GetLength(1);

            Random generatorGenerator = new Random();

            for (int i=0; i< columns; i++)
            {
                for(int j=0; j<rows; j++)
                {
                    matrix[i, j] = generatorGenerator.Next(0, 2);
                }
            }
        }

        public static void DisplayMatrix(ref int[,] matrix)
        {
            if (matrix is null)
            {
                return;
            }

            int columns = matrix.GetLength(0);
            int rows = matrix.GetLength(1);

            Console.Clear();
            for (int i=0; i<columns; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <rows; j++)
                {
                    Console.Write(matrix[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}
