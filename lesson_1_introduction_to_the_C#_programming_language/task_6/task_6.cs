/* Write a program that takes a number as input and outputs whether the number is even. */

Console.WriteLine("Enter an integer:");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine($"{n} an even number");
}
else
{
    Console.WriteLine($"{n} not an even number");
}