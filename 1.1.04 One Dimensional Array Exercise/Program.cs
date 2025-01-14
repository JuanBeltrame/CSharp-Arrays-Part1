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



char[] array = new char[30];

void PrintIntialValues(char[] array)
{
    Random randomChar = new();
    for (int i = 0; i < array.Length; i++)
        array[i] = (char)randomChar.Next(32,127);
}

