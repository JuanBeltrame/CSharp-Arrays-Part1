/*
One-Dimensional Array
----------------------------------------------------------------------
English: 
From an array called X of 50 integer elements, create and display:
a. Another array DX such that the first element is the difference between the second and
the first element of X, the second element of DX is the difference between
the third and the second of X and so on.

b. idem section (a) but on itself, that is, without generating an array DX.

Spanish: 
A partir de un arreglo llamado X de 50 elementos enteros, crear y exhibir:
a. Otro arreglo DX tal que el primer elemento sea la diferencia entre el segundo y
el primer elemento de X, el segundo elemento de DX sea la diferencia entre
el tercero y el segundo de X y así sucesivamente.

b. ídem apartado (a) pero sobre sí mismo, o sea sin generar un arreglo DX.
----------------------------------------------------------------------
*/

using System.Globalization;
using System.Runtime.CompilerServices;

int[] x = new int[30];
int[] dx = new int[30];

InitializeArray(x);
DisplayValues(nameof(x), x);
Console.WriteLine();
GenerateSecondArray(nameof(dx), dx);
DisplayValues(nameof(dx), dx);


static int GenerateRandomValues()
{
    Random rn = new();
    return rn.Next(1, 100);
}

static void InitializeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = GenerateRandomValues();
}

static void DisplayValues(string arrayName, int[] array)
{
    Console.WriteLine($"Array {arrayName}");
    for (int i = 0; i < array.Length; i++)
        Console.Write($" {array[i]} - ");
}

static void GenerateSecondArray(string arrayName, int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + i; j < array.Length; j++)
        {
            array[i] = array[j] - array[i];
        }
    }
    for(int k = 0; k < array.Length; k++)
    {
        array[k] = array[i];
    }
}