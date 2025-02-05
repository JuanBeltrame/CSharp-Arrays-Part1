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


int[] x = new int[5];
int[] dx = new int[x.Length - 1];

InitializeArray(x);
DisplayValues(nameof(x), x, x.Length);

GenerateSecondArray(x, dx);
DisplayValues(nameof(dx), dx, dx.Length);


GenerateThirdArray(x);
DisplayValues(nameof(x), x, x.Length - 1);


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

static void DisplayValues(string arrayName, int[] array, int elementsToShow)
{
    Console.Write($"Array {arrayName}:");
    for (int i = 0; i < elementsToShow; i++)
        Console.Write($" {array[i]} - ");
    Console.WriteLine();
}

static void GenerateSecondArray(int[] arrayX, int[] arrayDX)
{
    for (int i = 0; i < arrayX.Length - 1; i++)
        arrayDX[i] = arrayX[i + 1] - arrayX[i];
}

static void GenerateThirdArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
        array[i] = array[i + 1] - array[i];
}