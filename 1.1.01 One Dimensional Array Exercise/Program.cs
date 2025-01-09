/*
One-Dimensional Array 
----------------------------------------------------------------------
English:
Enter 30 integers in an array and then display them.

Spanish: 
Ingresar 30 elementos enteros en un arreglo y luego mostrarlos.
----------------------------------------------------------------------
*/

internal class Program
{

    static void IngresarElementos(int[] array)
    {
        Random rn = new Random();

        for (int i = 0; i < array.Length; i++)
            array[i] = rn.Next();
    }

    static void MostrarElementos(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);
    }

    public static void Main(string[] args)
    {
        int[] array = new int[30];

        IngresarElementos(array);
        MostrarElementos(array);
    }
}