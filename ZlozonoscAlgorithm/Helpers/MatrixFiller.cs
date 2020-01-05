using System;
using System.Collections.Generic;
using System.Text;

namespace ZlozonoscAlgorithm.Helpers
{
    public static class MatrixFiller
    {
        public static void FillWithRandomNumbers(ref bool[,] matrix)
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
                    matrix[i, j] = Convert.ToBoolean(generatorGenerator.Next(0, 2));
                }
            }
        }
    }
}
