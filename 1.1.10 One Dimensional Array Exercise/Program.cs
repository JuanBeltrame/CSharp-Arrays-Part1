/*
One-Dimensional Array
----------------------------------------------------------------------
English: 
Enter a word with a maximum of ten letters. 
Inform if it is a palindrome (equivalent to a capicua if it is numeric). For example: NEUQUEN. 
The end of the word is indicated with an ‘*’ if it has less than ten letters.

Spanish: 
Ingresar una palabra que como máximo tenga diez letras. 
Informar si es un palíndromo (equivalente a capicúa si fuese numérico). Por ejemplo: NEUQUEN. 
Se indica con un “*” el fin de la palabra si tiene menos de diez letras.
----------------------------------------------------------------------
*/

Console.Title = "One-Dimensional Array";
Console.ForegroundColor = ConsoleColor.Yellow;

string word;

Console.Write("Ingresar una Palabra: ");
word = Console.ReadLine()!;
Console.WriteLine($"La Palabra ingresada fue: {word}");

char[] letters = word.ToCharArray();
int longitudCadena = word.Length;
Console.WriteLine($"{word} tiene {longitudCadena} letras");

int posInicial = default;
int posFinal = word.Length;


while ((letters[posInicial] == letters[posFinal -1]) || (posInicial == 10) || letters[posInicial] == '*' )
{
    
    posInicial = +1;
    posFinal = -1;

}
Console.WriteLine($"{word} No es Palindromo");



for (int i = 0; i < letters.Length; i++)
{
    Console.Write($"{letters[i]} ");
}




