/* Set N and print "#" to N with a herringbone. */

Console.WriteLine("Enter an odd unsigned integer (number ≥ 3):");
int n = Convert.ToInt32(Console.ReadLine());

if ((n >= 3) && ((n % 2) != 0))
{
for (int i = 1, a = n/2; i <= n; i += 2, a--)
{
    for (int j = a; j > 0; j--)
    {
        Console.Write(" ");
    }
    for (int m = 0; m < i; m++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine("Happy New Year!");
}
else
{
    Console.WriteLine("The number does not meet the conditions.");
}