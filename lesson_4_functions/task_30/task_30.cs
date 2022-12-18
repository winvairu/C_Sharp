/* Write a program that takes the number N as input and
outputs the product of numbers from 1 to N. */

using static System.Console;

double prodNum(int a)
{
    double prod = 1;
    for (; a > 0; a--)
    {
        prod *= a;
    }
    return prod;
}
int num = 0;
while (true)
{
    Write("Enter an unsigned integer or \"0\" to complete: ");
    if (int.TryParse(ReadLine(), out num))
    {
        if (num == 0)
        {
            WriteLine("End");
            break;
        }
        else if (num < 0)
        {
            WriteLine("Invalid input.");
        }
        else
        {
            WriteLine(prodNum(num));
        }
    }
    else
    {
        WriteLine("Invalid input.");
    }
}