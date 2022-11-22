/* Write a program that accepts a three-digit integer as input and
shows the last digit of this number as output. */

Console.WriteLine("Enter a three-digit integer:");
int a = Convert.ToInt32(Console.ReadLine());

a = a % 10;
Console.WriteLine($"The last digit is equal to: {a}");