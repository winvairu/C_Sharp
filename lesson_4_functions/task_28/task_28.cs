/* Write a program that accepts a number as input and
outputs the number of digits in it. */

using static System.Console;

int digitCounter(int a)
{
    int sum = 0;
    for (int i = 0; a > 0; i++)
    {
        a /= 10;
        sum += 1;
    }
    return sum;
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
            int s = digitCounter(num);
            WriteLine($"{s}");
        }
    }
    else
    {
        WriteLine("Invalid input.");
    }
}