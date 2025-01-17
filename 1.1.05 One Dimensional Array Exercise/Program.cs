/*
One-Dimensional Array 
----------------------------------------------------------------------
English:
Enter integers into an array A of 10 elements 
and enter integers in another array B of equal dimension (use procedure LOAD with parameters).

Obtain, an array C, being C = A + B. (each element of C is obtained as the sum of the homologous elements of A and B).
a. Show A, B and C, one below the other.
b. Show A, B, and C, side by side.

Spanish: 
Ingresar números enteros en un arreglo A de 10 elementos 
e ingresar números enteros en otro arreglo B de igual dimensión (utilizar procedure CARGA con parámetros).

Obtener, un arreglo C, siendo C = A + B. (cada elemento de C se obtiene como la suma de los elementos homólogos de A y B).
a. Mostrar A, B y C, uno debajo del otro.
b. Mostrar A, B y C, uno al lado del otro.
----------------------------------------------------------------------
*/

static int GenerateRandonValues()
{
    Random rn = new();
    var randomValue = rn.Next(1, 11);
    return randomValue;
}

static void InitializeArrayWithCustomValues(int[] arrayX)
{
    for (int i = 0; i < arrayX.Length; i++)
        arrayX[i] = GenerateRandonValues();
}

static void DisplayValues(int[] arrayX)
{
    System.Console.Write($". Default values from are: ");
    for (int i = 0; i < arrayX.Length; i++)
        System.Console.Write($" {arrayX[i]} ");
}

static int GenerateSum(int[] arraryX, int[] arrayY, int i) => arraryX[i] + arrayY[i];

var arrayA = new int[10];
var arrayB = new int[10];
int[] arrayC = new int[10];

InitializeArrayWithCustomValues(arrayA);
InitializeArrayWithCustomValues(arrayB);

DisplayValues(arrayA);
System.Console.WriteLine();
DisplayValues(arrayB);

for (int i = 0; i < arrayC.Length; i++)
    arrayC[i] = GenerateSum(arrayA, arrayB, i);
System.Console.WriteLine();
DisplayValues(arrayC);


