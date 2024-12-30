using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2._1_Arrays_Operations
{
    public class Write
    {
        public static void WriteArray(int[] array, int position, int number)
        {
            int size = array.Length;
            if (position < size)
            {
                array[position] = number;
                Console.WriteLine();
            }

        }
    }
}
