/* Write a program that takes a number (N) as input,
and shows all even numbers from 1 to N as output. */

Console.WriteLine("Enter an unsigned integer:");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < n; i++)
{
    if (i % 2 == 0)
    Console.WriteLine(i);
}
if (n < 1)
{
    Console.WriteLine("the number must be greater than 1");
}