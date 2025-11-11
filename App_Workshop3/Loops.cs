using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop3
{
    internal class Loops
    {
        public void RunLoops()
        {
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
                sum += i;

            Console.WriteLine($"Sum from 1 to {N} = {sum}");

            Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");
            int j = 1;
            while (j <= 20)
            {
                if (j == 15) break;
                if (j % 4 == 0)
                {
                    j++;
                    continue;
                }
                Console.Write($"{j} ");
                j++;
            }
            Console.WriteLine();

            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nArray elements:");
            foreach (int num in arr)
                Console.Write($"{num} ");
            Console.WriteLine();

            int arraySum = 0;
            foreach (int num in arr)
                arraySum += num;

            Console.WriteLine($"Sum of array elements: {arraySum}");
        }
    }
}
