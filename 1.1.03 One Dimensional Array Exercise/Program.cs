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

    for (int i = 0; i < array.Length ; i++)
        array[i] = rn.Next(minValue, maxValue);
}

static void PrintArray(int[] array)
{
    Console.Write($"Initial Values: ");
    for (int i = 0; i < array.Length ; i++)
        Console.Write($" {array[i]}");
}


int size = 25;
int[] array = new int[size];

LoadArray(array);
PrintArray(array);



