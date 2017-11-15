using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split(' ');
            var secondInput = Console.ReadLine().Split(' ');
            var lenght = Math.Min(firstInput.Length, secondInput.Length);
            int leftCount = 0;
            int reightCount = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    leftCount++;
                }
                if (firstInput[firstInput.Length -i -1]  == secondInput[secondInput.Length -i -1])
                {
                    reightCount++;
                }
            }
            Console.WriteLine(Math.Max(leftCount, reightCount));
        }
    }
}
