/*
One-Dimensional Array 
----------------------------------------------------------------------
English:
Enter 30 elements of type char in an array
and then display only the elements that are different from ' * ', 
indicating the position that element occupies in the array. 

Spanish: 
Ingresar 30 elementos de tipo char en un arreglo
y luego mostrar sólo los elementos que sean distintos de ‘ * ‘, 
indicando la posición que dicho elemento ocupa en el arreglo.
----------------------------------------------------------------------
*/
using System.Runtime.InteropServices;

char DisplaytIntialValues()
{
    Random randomChar = new();
    char value = (char)randomChar.Next(32, 127);
    return value;
}


char[] array = new char[30];

Console.Write("Initial Values: ");
for (int i = 0; i < array.Length; i++)
    Console.Write($" {array[i] = DisplaytIntialValues()} ");
Console.WriteLine();

Console.Write($"Updated values with no '*' symbol: ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] is not (char)42)
    Console.Write($" {array[i]} ");
}
