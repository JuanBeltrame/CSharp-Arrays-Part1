﻿
using _0._2._1_Arrays_Operations;

//--------Read-------- 
int[] readArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];
//--------Write-------- 
int[] writeArray = [0, 0, 0, 0, 0, 0, 0, 0, 0];

//AccessElementsbyIndex.ReadElementbyIndex(array);
//Console.WriteLine(AccessElementsbyIndex.WriteElementbyIndex(array));

ArrayTraversal.TraverseAndReadArray(readArray);
System.Console.WriteLine();
ArrayTraversal.TraverseAndWriteArray(readArray, writeArray);