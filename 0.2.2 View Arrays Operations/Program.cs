using _0._2._1_Arrays_Operations;
using System;

class Program
{
    static void Main(string[] args)
    {
        //--------Read-------- 
        int[] readArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //--------Write-------- 
        int[] writeArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        //AccessElementsbyIndex.ReadElementbyIndex(array);
        //Console.WriteLine(AccessElementsbyIndex.WriteElementbyIndex(array));

        ArrayTraversal.TraverseAndReadArray(readArray);
        Console.WriteLine();
        ArrayTraversal.TraverseAndWriteArray(readArray, writeArray);
        Console.WriteLine();
        Console.WriteLine($"Size: {ArraySize.CalculateSize(readArray)}");
    }
}