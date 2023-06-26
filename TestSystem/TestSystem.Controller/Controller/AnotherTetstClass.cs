using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedCsharp.src.Controller
{
    public class AnotherTetstClass
    {
        private int[] numbers;

        public AnotherTetstClass()
        {
            numbers = new int[] { 1, 0, 1, 1, 1 };
        }

        public void CountBinary()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }


    }
}