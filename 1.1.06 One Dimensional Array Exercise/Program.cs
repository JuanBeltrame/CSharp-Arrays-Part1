/*
One-Dimensional Array 
----------------------------------------------------------------------
English:
You have the grades from a test taken by 30 students in a class.
The goal is to determine how many of them scored above the average grade of the class.

Obtain, an array C, being C = A + B. (each element of C is obtained as the sum of the homologous elements of A and B).
a. Show A, B and C, one below the other.
b. Show A, B, and C, side by side.

Spanish: 
Se tienen como datos las notas de un parcial de los 30 alumnos de un curso. 
Se desea saber cuántos de ellos obtuvieron una calificación superior al promedio del curso.
----------------------------------------------------------------------
*/



using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;

Random rn = new();
decimal average = default;
decimal acum = default;
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








decimal GenerateGrades() => rn.Next(100, 1001) / 100m;

