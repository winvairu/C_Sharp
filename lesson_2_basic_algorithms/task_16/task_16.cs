/* Write a program that takes two numbers as input and
checks whether one number is the square of the other. */

Console.WriteLine("Enter the first integer:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second integer:");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine($"{a} is the square of the number {b}");
}
else if (b == a * a)
{
    Console.WriteLine($"{b} is the square of the number {a}");
}
else
{
    Console.WriteLine($"Neither {a} nor {b} are squares for each other");
}