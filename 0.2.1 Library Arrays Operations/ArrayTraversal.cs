using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2._1_Arrays_Operations
{
    public class ArrayTraversal
    {
        public static void TraverseAndReadArray(int[] nums)
        {
            Console.Write($"The Elements are: ");
            for (int i = 0; i < nums.Length; i++)
                Console.Write($" {i}");
        }
    }
}
