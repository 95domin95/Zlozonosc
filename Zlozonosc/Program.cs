using System;
using Zlozonosc.Constants;
using Zlozonosc.Helpers;
using ZlozonoscAlgorithm;
using ZlozonoscAlgorithm.Helpers;

namespace Zlozonosc
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = UserInputHelper.GetIntValFromInput(Messages.EnterColumns);
            int[,] matrix = new int[lenght, lenght]; 
            MatrixFiller.FillWithRandomNumbers(ref matrix);
            MatrixFiller.DisplayMatrix(ref matrix);
            var result = Calculate.BasicMethod(ref matrix);
            Console.WriteLine("Result using basic method: {0}", result);
            result = Calculate.SubtotalsMethod(ref matrix);
            Console.WriteLine("Result using subtotals method: {0}", result);
        }
    }
}
