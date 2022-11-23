/* Write a program that accepts a three-digit number as input and
shows the second digit of this number as output. */

Console.WriteLine("Enter a three-digit integer:");
int a = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(a).ToString().Length == 3)
{
    if (a > 0)
    {
    a = (a % 100) / 10;
    Console.WriteLine($"The number {a} is in the middle.");
    }
    else
    {
        a = (a % 100) / 10 * (-1);
    Console.WriteLine($"The number {a} is in the middle.");
    }
}
else
{
    Console.WriteLine($"Invalid number entered.");
}