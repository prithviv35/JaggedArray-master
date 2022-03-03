using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main()
        {
            int[][] jagged_arr = new int[][] { new int[] { 1, 2, 3, 4 },
            new int[] { 11, 34, 67 },new int[] { 89, 23 },new int[] { 0, 45, 78, 53, 99 } };

            for (int i = 0; i < jagged_arr.Length; i++)
            {
                // Print the row number
                Console.Write("Row({0}): ", i);
                for (int k = 0; k < jagged_arr[i].Length; k++)
                {
                    // Print the elements in the row
                    Console.Write("{0} ", jagged_arr[i][k]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
