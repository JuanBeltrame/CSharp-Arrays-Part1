/*
One-Dimensional Array 
----------------------------------------------------------------------
English:
Enter 20 elements of real type in an array and perform the sum of them. Use the procedures LOAD AND SUM

Spanish: 
Ingresar 20 elementos de tipo real en un arreglo y realizar la suma de los mismos.
Utilizar los procedimientos CARGA Y SUMA
----------------------------------------------------------------------
*/


using System.Runtime.InteropServices;

static void LoadElements(double[] array)
{
    Random rn = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rn.NextDouble();
}

double SumElements(double[] array)
{
    double acumulator = default;
    for (int i = 0; i < array.Length; i++)
        acumulator += array[i];

    return acumulator;
}


int size = 20;
double[] array = new double[size];

LoadElements(array);
Console.WriteLine($"Sum of Elements: {SumElements(array)}");


