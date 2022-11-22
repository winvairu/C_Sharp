/* Write a program that accepts three numbers as input and outputs the maximum of these numbers. */

Console.WriteLine("Enter the first integer:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second integer:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third integer:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a) 
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine($"The maximum number is: {max}");
