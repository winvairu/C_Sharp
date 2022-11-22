/* Write a program that takes two numbers as input and
checks whether the first number is the square of the second. */

Console.WriteLine("Enter the first integer: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a != (b * b))
{
    Console.WriteLine("The first number is not the square of the second number.");
}
else
{
    Console.WriteLine("The first number is the square of the second number.");
}