/* Write a program that takes a number as input and
checks whether it is a multiple of 7 and 23 at the same time. */

int a = 7;
int b = 23;
Console.WriteLine("Enter an integer:");
int c = Convert.ToInt32(Console.ReadLine());

if ((c % a == 0) && (c % b == 0))
{
    Console.WriteLine($"{c} - multiple number");
}
else
{
    Console.WriteLine($"{c} - not a multiple number");
}