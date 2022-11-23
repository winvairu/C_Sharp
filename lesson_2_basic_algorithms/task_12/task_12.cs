/* Write a program that will take two numbers as input and
output whether the second number is a multiple of the first.
If the second number is not a multiple of the first,
then the program outputs the remainder of the division. */

Console.WriteLine("Enter the first integer: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second integer: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine($"{b} is a multiple of {a}");
}
else
{
    Console.WriteLine($"{b} is not a multiple of {a}, the remainder is {a % b}");
}