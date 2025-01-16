namespace _0._0._1_Library_Array_Declaration
{
    public class OneDimensionalArray
    {
        //--------- ARRAYS UNIDIMENSIONALES ---------
        // Los arrays en C# son objetos, por lo tanto ademas, son tipos de referencia. 

        // Forma 1: Declaracion y asignacion en una linea sin valores iniciales
            // Opcion 1.a: 
            int[] arrayVacio1a = new int[0];
            // Opción 1.b: Usando Array.Empty<T>() (Recomendado)
            int[] arrayVacio1b = Array.Empty<int>();
            // Opcion 1.c: 
            int[] arrayVacio1c = null!;


        // Forma 2: Declaracion y asignacion en una linea con valores iniciales por defecto con capacidad especificada;
            // Opcion 2.a:
            int[] array2a = new int[5]; // { 0, 0, 0, 0, 0 }
            bool[] booleanos = new bool[3]; // { false, false, false }
            string[] textos = new string[4]; // { null, null, null, null }
            // Opcion 2.b: Implicitly typed array
            // var array2b = new int[10];


        //Forma 3: Declaracion con valores iniciales
            // Opcion 3.a: Usando Collection Expressions
            int[] array3a = [1, 2, 3, 4, 5];
            string[] array3aa = ["Juan", "Pepe", "Lucia"];
            // Opcion 3.b: Usando Corchetes
            int[] array3b = { 1, 2, 3, 4, 5 };
            string[] array3bb = { "Juan", "Pepe", "Lucia" };
            // Opcion 3.c: 
            // var array3c = new[] { 1, 2, 3, 4, 5 };


        // Forma 4: Declaracion e inicializacion en varias Lineas
            // Opcion 4.a:
            int[]? array4a;
            // array4a = new int[10];
            // Opcion 4.b: 
            static int tamanio = 30;
            int[] array4b = new int[tamanio];


        // Forma 5: Usando Array.CreateInstance;
            // Opcion 5.a:
            Array array5a = Array.CreateInstance(typeof(int), 5);
    }
}
