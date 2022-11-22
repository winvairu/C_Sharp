/* Write a program that accepts two numbers as input and
outputs which number is greater and which is smaller. */

Console.WriteLine("Enter the first integer: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"max = {a}");
}
else
{
    Console.WriteLine($"max = {b}");
}