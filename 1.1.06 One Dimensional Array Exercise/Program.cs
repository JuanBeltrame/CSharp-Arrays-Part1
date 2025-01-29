/*
One-Dimensional Array 
----------------------------------------------------------------------
English:
You have the grades from a test taken by 30 students in a class.
The goal is to determine how many of them scored above the average grade of the class.

Spanish: 
Se tienen como datos las notas de un parcial de los 30 alumnos de un curso. 
Se desea saber cuántos de ellos obtuvieron una calificación superior al promedio del curso.
----------------------------------------------------------------------
*/

Random rn = new();
decimal average = default;
decimal acum = default;
int count = default;
decimal[] grades = new decimal[30];

Console.Write($". Students grades are: ");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write($" {grades[i] = GenerateGrades()}");
    acum += grades[i];
}
System.Console.WriteLine();
average = acum / grades.Length;
Console.WriteLine($". The {nameof(average)} is {Math.Round(average, 2)}");

for (int i = 0; i < grades.Length; i++)
    if (grades[i] > average) count ++;

Console.WriteLine($". La cantidad de alumnos que obtuvo una calificación superior al promedio es: {count}");


decimal GenerateGrades() => rn.Next(100, 1001) / 100m;

