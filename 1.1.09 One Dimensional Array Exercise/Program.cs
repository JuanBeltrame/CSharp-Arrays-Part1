/*
One-Dimensional Array
----------------------------------------------------------------------
English: 
A parlor game requires determining the number of matching letters between two five-letter words. 
Note that neither word contains repeated letters.

Spanish: 
Un juego de salón requiere saber la cantidad de letras iguales que hay entre dos palabras de cinco letras cada una. 
Considerar que ninguna de ellas tiene letras repetidas.
----------------------------------------------------------------------
*/

string? firstWord;
string? secondWord;

Console.Write("Enter first word: ");
firstWord = GenerateWords();

Console.Write("Enter second word: ");
secondWord = GenerateWords();

DisplayWords(firstWord);
DisplayWords(secondWord);

char[] firstWordLetters = firstWord.ToCharArray();
char[] secondWordLetters = secondWord.ToCharArray();

Console.WriteLine($"Existen {CompareLetters(firstWordLetters, secondWordLetters, firstWordLetters.Length)} letras repetidas");

static string GenerateWords() => Console.ReadLine()!;
static void DisplayWords(string word) => Console.WriteLine(word);
static int CompareLetters(char[] firstLetters, char[] secondLetters, int capacity)
{
    int countLetters = 0;
    for (int i = 0; i < capacity; i++)
    {
        for (int j = 0; j < capacity; j++)
            if (firstLetters[i] == secondLetters[j])
                countLetters += 1;
    }
    return countLetters;
}


