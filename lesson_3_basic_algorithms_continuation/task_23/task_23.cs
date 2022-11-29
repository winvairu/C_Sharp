/* Write a program that takes a number (N) as input and
outputs a table of cubes of numbers from 1 to N. */

Console.WriteLine("Enter an unsigned integer (n ≥ 1):");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Cube of numbers from 1 to {n}:");
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i * i * i}");
}
