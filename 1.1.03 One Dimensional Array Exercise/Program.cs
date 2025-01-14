/*
One-Dimensional Array 
----------------------------------------------------------------------
English:
Enter 25 elements of type integer in an array, 
then get the sum of the positive values within the array. 

Spanish: 
Ingresar 25 elementos de tipo entero en un arreglo, 
luego obtener la suma de los valores positivos dentro del conjunto. 
----------------------------------------------------------------------
*/

static void LoadArray(int[] array)
{
    Random rn = new();
    int minValue = -10;
    int maxValue = 11;

    int capacity = array.Length;
    for (int i = 0; i < capacity; i++)
        array[i] = rn.Next(minValue, maxValue);
}

static void PrintIntialValues(int[] array)
{
    int capacity = array.Length;
    Console.Write($"Initial Values: ");
    for (int i = 0; i < capacity; i++)
        Console.Write($"{array[i]} ");
    System.Console.WriteLine();
}

static void PrintPositivesValues(int[] array)
{
    int capacity = array.Length;
    int negativeValue = 0;
    System.Console.Write($"Positives Values are: ");
    for (int i = 0; i < capacity; i++)
    {
        if (array[i] > negativeValue)
            System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

static int SumPositivesValues(int[] array)
{
    int capacity = array.Length;
    int negativeValue = 0;
    int acumulator = default;
    for (int i = 0; i < capacity; i++)
    {
        if (array[i] > negativeValue)
            acumulator += array[i];
    }
    return acumulator;
}


int size = 25;
int[] array = new int[size];

LoadArray(array);
PrintIntialValues(array);
PrintPositivesValues(array);
Console.Write($"Sum of Positives Values: {SumPositivesValues(array)}");


