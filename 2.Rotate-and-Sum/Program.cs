using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var roatate = int.Parse(Console.ReadLine());

            int[] sum = new int[input.Length];

            for (int i = 0; i < roatate; i++)
            {
                RotateArray(input);
                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] = sum[j] + input[j];
                }

            }
            Console.WriteLine(String.Join(" ", sum));
        }

        private static void RotateArray(int[] input)
        {
            var lastNumber = input.Last();

            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }
            input[0] = lastNumber;
        }
    }
}
