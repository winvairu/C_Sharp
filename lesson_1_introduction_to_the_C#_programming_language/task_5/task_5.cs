/* Write a program that takes one unsigned integer (N) as input,
and shows all integers in the range from -N to N. */

Console.WriteLine("Enter an unsigned integer:");
int n = Convert.ToInt32(Console.ReadLine());

for (int b = n * (-1); b <= n; b++)
{
    Console.WriteLine(b);
}