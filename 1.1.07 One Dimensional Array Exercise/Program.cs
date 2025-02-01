/*
One-Dimensional Array
----------------------------------------------------------------------
English:
You have a set of 10 integers. The task is to modify this set in the following way: 
If the last number read is even, change to zero the numbers in the even positions of the set; 
if the last number read is odd, change to zero the numbers in the odd positions of the set.

Spanish: 
Se dispone de un conjunto de 10 numeros enteros. Se pide modificar ese conjunto de la siguiente forma: 
Si el ultimo numero leido es par, cambiar por cero los numeros contenidos en las posiciones par del conjutno; 
si el ultimo numero leido es impar, cambiar por cero los numeros contenidos en las posiciones impar del conjunto. 
----------------------------------------------------------------------
*/

int[] nums = new int[10];
InitializeArray(nums);
DisplayValues(nums);
Console.WriteLine();
SetNewValues(nums);
DisplayValues(nums);


static int GenerateRandomValues()
{
    Random rn = new();
    return rn.Next(1, 100);
}

static void InitializeArray(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
        nums[i] = GenerateRandomValues();
}

static void DisplayValues(int[] nums)
{
    Console.Write("Values are: ");
    for (int i = 0; i < nums.Length; i++)
        Console.Write($"{nums[i]} - ");
}

static bool CheckLastValue(int[] nums) => nums[^1] % 2 == 0 ? true : false;

static void SetNewValues(int[] nums)
{
    if (CheckLastValue(nums))
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
                nums[i] = 0;
        }
    }
    else
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 != 0)
                nums[i] = 0;
        }
    }
}












