using System;
using System.Collections.Generic;
using System.Text;

namespace ZlozonoscAlgorithm
{
    public static class Calculate
    {
        public static int BasicMethod(ref int[,] matrix)
        {
            int result = 0;

            int lenght = matrix.GetLength(0);

            if(lenght < 2)
            {
                return 0;
            }

            //Iterate all possible dimensions of nested rectangles
            for(int i=2; i<=lenght; i++)
            {
                //Iterate over rows
                for(int j=0; j<=lenght-i; j++)
                {
                    //Iterate over columns
                    for(int k=0; k<=lenght-i; k++)
                    {
                        #region Check proportions in rectangle
                        int zeroCount = 0;
                        int oneCount = 0;
                        for(int l=j; l<j+i; l++)
                        {
                            for(int m=k; m<k+i; m++)
                            {
                                if(matrix[l, m] == 1)
                                {
                                    oneCount++;
                                }
                                else
                                {
                                    zeroCount++;
                                }
                            }
                        }
                        if(zeroCount == oneCount)
                        {
                            result++;
                        }
                        #endregion
                    }
                }
            }

            return result;
        }

        public static int SubtotalsMethod(ref int[,] matrix)
        {
            int result = 0;

            //TODO

            return result;
        }
    }
}
