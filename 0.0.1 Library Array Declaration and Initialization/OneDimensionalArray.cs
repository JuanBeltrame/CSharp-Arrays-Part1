namespace _0._0._1_Library_Array_Declaration
{
    public class OneDimensionalArray
    {
        //--------- ARRAYS UNIDIMENSIONALES ---------
        // Los arrays en C# son objetos, por lo tanto ademas, son tipos de referencia. 

        // Forma 1: Declaracion con valores iniciales por defecto, con capacidad especificada;
        // Opcion 1.a:
        int[] array1a = new int[5]; // { 0, 0, 0, 0, 0 }
        bool[] booleanos = new bool[3]; // { false, false, false }
        string[] textos = new string[4]; // { null, null, null, null }
        // Opcion 1.b: Implicitly typed array
        // var array1b = new int[10];

        //Forma 2: Declaracion con valores iniciales
        // Opcion 2.a: Usando Collection Expressions
        int[] array2a = [1, 2, 3, 4, 5];
        string[] array2aa = ["Juan", "Pepe", "Lucia"];
        // Opcion 2.b: Usando Corchetes
        int[] array2b = { 1, 2, 3, 4, 5 };
        string[] array2bb = { "Juan", "Pepe", "Lucia" };
        // Opcion 2.c: Within a method
        // var array2c = new[] { 1, 2, 3, 4, 5 };

        // Forma 3: Declaracion e inicializacion en varias Lineas
        // Opcion 3.a:
        int[]? array3a;
        // array3a = new int[10];
        // Opcion 3.b: 
        static int tamanio = 30;
        int[] array3b = new int[tamanio];

        // Forma 4: Usando Array.CreateInstance;
        // Opcion 4.a:
        Array array5a = Array.CreateInstance(typeof(int), 5);

        // Forma 5: Declaracion y asignacion en una linea sin valores iniciales
        // Opcion 5.a: 
        int[] arrayVacio5a = new int[0];
        // Opción 5.b: Usando Array.Empty<T>() (Recomendado)
        int[] arrayVacio5b = Array.Empty<int>();
        // Opcion 5.c: 
        int[] arrayVacio5c = null!;

    }
}
