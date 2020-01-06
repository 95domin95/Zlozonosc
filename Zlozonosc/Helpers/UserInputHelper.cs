using System;
using Zlozonosc.Constants;

namespace Zlozonosc.Helpers
{
    public static class UserInputHelper
    {
        public static int GetIntValFromInput(string message)
        {
            int value;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write(Messages.TryAgain);
            }
            if(value < 2)
            {
                value = 2;
            }
            return value;
        }
    }
}
