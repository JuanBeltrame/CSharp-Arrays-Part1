using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2._1_Arrays_Operations
{
    public class AccessElementsbyIndex
    {
        public static void ReadElementbyIndex(int[] nums)
        {
            var readNumber = nums[3];
            Console.WriteLine(readNumber.ToString());
        }

        public static string WriteElementbyIndex(int[] nums)
        {
            nums[3] = 10;
            return $"{nums[3].ToString()}";
        }
    }
}
