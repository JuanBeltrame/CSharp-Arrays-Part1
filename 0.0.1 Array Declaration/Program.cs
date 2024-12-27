
//--------- ARRAYS UNIDIMENSIONALES ---------
// Los arrays en C# son objetos, por lo tanto ademas, son tipos de referencia. 

// Forma 1: Declaracion y asignacion en una linea sin valores iniciales
    // Opcion 1.a: Usando Collection Expressions
    int[] arrayVacio01 = [];
    // Opcion 1.b: 
    int[] arrayVacio02 = new int[0];
    // Opción 1.c: Usando Array.Empty<T>() (Recomendado)
    int[] arrayVacio03 = Array.Empty<int>();
    // Opcion 1.d: 
    int[] arrayVacio04 = null!;


// Forma 2: Declaracion y asignacion en una linea sin valores iniciales con capacidad especificada;
    // Opcion 2.a:
    int[] array01 = new int[10];
    // Opcion 2.b: Implicitly typed empty array
    var array08 = new int[10];


//Forma 3: Declaracion e inicializacion en una sola linea con elementos
    // Opcion 3.a: Usando Collection Expressions
    int[] array02 = [ 1, 2, 3, 4, 5 ];
    string[] nombres02 = [ "Juan", "Pepe", "Lucia" ];
    // Opcion 3.b: Usando Corchetes
    int[] array03 = { 1, 2, 3, 4, 5 };
    string[] nombres03 = { "Juan", "Pepe", "Lucia" };
    // Opcion 3.c: 
    var array13 = new[] { 1, 2, 3, 4, 5 };


// Forma 4: Declaracion e inicializacion en varias Lineas
    // Opcion 4.a:
    int[] array04;
    array04 = new int[10];
    // Opcion 4.b: 
    int tamanio = 30;
    int[] array05 = new int[tamanio];


// Forma 5: Usando Array.CreateInstance;
    // Opcion 5.a:
    Array array06 = Array.CreateInstance(typeof(int), 5);


//--------- ARRAYS BIDIMENSIONALES/MATRICES ---------
// Forma 1: Declaracion y asignacion en una linea sin valores iniciales
// NO EXISTE LA FORMA 1; ya que el array debe ser declarado con un tamanio inicial

// 0.0.1 Arrays Declaration
// 0.1.1 Arrays Types
// 0.2.1 Arrays Operations

